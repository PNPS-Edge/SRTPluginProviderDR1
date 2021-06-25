using ProcessMemory;
using System;
using System.Diagnostics;
using System.Text;
using System.Collections.Generic;

namespace SRTPluginProviderDR1
{
    internal class GameMemoryDR1Scanner : IDisposable
    {
        // Variables
        private ProcessMemoryHandler memoryAccess;
        private GameMemoryDR1 gameMemoryValues;
        public bool HasScanned;
        public bool ProcessRunning => memoryAccess != null && memoryAccess.ProcessRunning;
        public int ProcessExitCode => (memoryAccess != null) ? memoryAccess.ProcessExitCode : 0;

        // Pointer Address Variables
        private int pointerForHealth;
        private int pointerForMaxHealth;

        // Pointer Classes
        private IntPtr BaseAddress { get; set; }

        private MultilevelPointer PointerPlayerHP { get; set; }

        private MultilevelPointer PointerPlayerMaxHP { get; set; }

        internal GameMemoryDR1Scanner(Process process = null)
        {
            gameMemoryValues = new GameMemoryDR1();
            if (process != null)
                Initialize(process);
        }

        internal unsafe void Initialize(Process process)
        {
            if (process == null)
                return; // Do not continue if this is null.

            if (!SelectPointerAddresses(GameHashes.DetectVersion(process.MainModule.FileName)))
                return; // Unknown version.

            int pid = GetProcessId(process).Value;
            memoryAccess = new ProcessMemoryHandler(pid);
            if (ProcessRunning)
            {
                BaseAddress = NativeWrappers.GetProcessBaseAddress(pid, PInvoke.ListModules.LIST_MODULES_64BIT); // Bypass .NET's managed solution for getting this and attempt to get this info ourselves via PInvoke since some users are getting 299 PARTIAL COPY when they seemingly shouldn't.

                PointerPlayerHP = new MultilevelPointer(
                    memoryAccess, 
                    IntPtr.Add(BaseAddress, pointerForHealth),
                    0xC8
                );

                PointerPlayerMaxHP = new MultilevelPointer(
                    memoryAccess,
                    IntPtr.Add(BaseAddress, pointerForMaxHealth),
                    0x48
                );
            }
        }

        private bool SelectPointerAddresses(GameVersion version)
        {
            switch (version)
            {
                case GameVersion.DR_20210128_3:
                    {
                        pointerForHealth = 0x01CF2620;
                        pointerForMaxHealth = 0x01CF3128;
                        return true;
                    }
            }

            // If we made it this far... rest in pepperonis. We have failed to detect any of the correct versions we support and have no idea what pointer addresses to use. Bail out.
            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        internal void UpdatePointers()
        {
            PointerPlayerHP.UpdatePointers();
            PointerPlayerMaxHP.UpdatePointers();
        }

        internal unsafe IGameMemoryDR1 Refresh()
        {
            bool success;

            //Player HP
            fixed (int* p = &gameMemoryValues._playerCurrentHealth)
                success = PointerPlayerHP.TryDerefInt(0x12EC, p);

            fixed (int* p = &gameMemoryValues._playerMaxHealth)
                success = PointerPlayerMaxHP.TryDerefInt(0x120, p);

            HasScanned = true;
            return gameMemoryValues;
        }

        private string GetString(byte[] value)
        {
            if (value != null)
            {
                return Encoding.Unicode.GetString(value);
            }
            return "";
        }

        private int? GetProcessId(Process process) => process?.Id;

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        private unsafe bool SafeReadByteArray(IntPtr address, int size, out byte[] readBytes)
        {
            readBytes = new byte[size];
            fixed (byte* p = readBytes)
            {
                return memoryAccess.TryGetByteArrayAt(address, size, p);
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                    if (memoryAccess != null)
                        memoryAccess.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}