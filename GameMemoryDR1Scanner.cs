using ProcessMemory;
using System;
using System.Diagnostics;
using System.Text;
using System.Collections.Generic;
using SRTPluginProviderDR1.Structs.GameStructs;

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
        private int pointerForGameSession;
        private int pointerForGameStatus;
        private int pointerForPlayerStatuses;
        private int pointerForCar;
        private int pointerForCampain;
        private int pointerForRoom;
        private int pointerForCamera;

        // Pointer Classes
        private IntPtr BaseAddress { get; set; }

        private MultilevelPointer PointerGameStatusInfo { get; set; }

        private MultilevelPointer PointerPlayerInfo { get; set; }

        private MultilevelPointer PointerPlayerStatusesInfo { get; set; }

        private MultilevelPointer PointerCurrentWeapon { get; set; }

        private MultilevelPointer PointerBossInfo { get; set; }

        private MultilevelPointer PointerTunnelCarInfo { get; set; }

        private MultilevelPointer PointerCampainInfo { get; set; }

        private MultilevelPointer PointerRoomInfo { get; set; }

        private MultilevelPointer PointerCameraInfo { get; set; }

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

                PointerGameStatusInfo = new MultilevelPointer(
                    memoryAccess,
                    IntPtr.Add(BaseAddress, pointerForGameStatus),
                    0x2F058
                );

                PointerPlayerInfo = new MultilevelPointer(
                    memoryAccess,
                    IntPtr.Add(BaseAddress, pointerForGameSession),
                    0xC8
                );

                PointerCurrentWeapon = new MultilevelPointer(
                    memoryAccess,
                    IntPtr.Add(BaseAddress, pointerForGameSession),
                    0xC8,
                    0x1230
                );

                PointerBossInfo = new MultilevelPointer(
                    memoryAccess,
                    IntPtr.Add(BaseAddress, pointerForGameSession),
                    0x118
                );

                PointerPlayerStatusesInfo = new MultilevelPointer(
                    memoryAccess,
                    IntPtr.Add(BaseAddress, pointerForPlayerStatuses)
                );

                PointerTunnelCarInfo = new MultilevelPointer(
                    memoryAccess,
                    IntPtr.Add(BaseAddress, pointerForCar),
                    0x1E8,
                    0x60,
                    0x8B0,
                    0x18
                );

                PointerCampainInfo = new MultilevelPointer(
                    memoryAccess,
                    IntPtr.Add(BaseAddress, pointerForCampain),
                    0x20DC0
                );

                PointerRoomInfo = new MultilevelPointer(
                    memoryAccess,
                    IntPtr.Add(BaseAddress, pointerForRoom)
                );

                PointerCameraInfo = new MultilevelPointer(
                    memoryAccess,
                    IntPtr.Add(BaseAddress, pointerForCamera),
                    0x40
                );
            }
        }

        private bool SelectPointerAddresses(GameVersion version)
        {
            switch (version)
            {
                case GameVersion.DR_20210128_3:
                    {
                        pointerForGameSession = 0x01CF2620;
                        pointerForGameStatus = 0x01946FC0;
                        pointerForPlayerStatuses = 0x01946950;
                        pointerForCar = 0x01946260;
                        pointerForCampain = 0x01944DD8;
                        pointerForRoom = 0x01945F70;
                        pointerForCamera = 0x01CF3128;
                        return true;
                    }
            }

            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        internal void UpdatePointers()
        {
            PointerGameStatusInfo.UpdatePointers();
            PointerPlayerInfo.UpdatePointers();
            PointerCurrentWeapon.UpdatePointers();
            PointerBossInfo.UpdatePointers();
            PointerPlayerStatusesInfo.UpdatePointers();
            PointerTunnelCarInfo.UpdatePointers();
            PointerCampainInfo.UpdatePointers();
            PointerRoomInfo.UpdatePointers();
            PointerCameraInfo.UpdatePointers();
        }

        internal unsafe IGameMemoryDR1 Refresh()
        {
            bool success;

            // Game Info
            gameMemoryValues._game = this.PointerGameStatusInfo.Deref<GameStatusInfo>(0x38);

            // player Info
            gameMemoryValues._player = this.PointerPlayerInfo.Deref<PlayerInfo>(0x40);

            // player Statuses Info
            gameMemoryValues._playerStatuses = this.PointerPlayerStatusesInfo.Deref<PlayerStatusesInfo>(0x50);

            // Current Weapon Info
            gameMemoryValues._weaponInfo = this.PointerCurrentWeapon.Deref<WeaponInfo>(0x2E24);

            // Boss Info
            gameMemoryValues._bossInfo = this.PointerBossInfo.Deref<BossInfo>(0x12E8);

            // Tunnel Car Info
            gameMemoryValues._tunnelCarInfo = this.PointerTunnelCarInfo.Deref<TunnelCarInfo>(0x12EC);

            // Campaign Info
            gameMemoryValues._campaign = this.PointerCampainInfo.Deref<CampaignInfo>(0x150);

            // Room Info
            gameMemoryValues._roomInfo = this.PointerRoomInfo.Deref<RoomInfo>(0x40);

            // Camera Info
            gameMemoryValues._cameraPosition = this.PointerCameraInfo.Deref<CameraInfo>(0x8);

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
                    if (memoryAccess != null)
                        memoryAccess.Dispose();
                }

                disposedValue = true;
            }
        }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            Dispose(true);
        }
        #endregion
    }
}