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
        private int pointerForVelocityInfo;

        // Pointer Classes
        private IntPtr BaseAddress { get; set; }

        private MultilevelPointer PointerGameStatusInfo { get; set; }

        private MultilevelPointer PointerCoordinatesInfo { get; set; }

        private MultilevelPointer PointerPlayerStatusesInfo { get; set; }

        private MultilevelPointer PointerCurrentWeapon { get; set; }

        private MultilevelPointer PointerBossInfo { get; set; }

        private MultilevelPointer PointerVelocityInfo { get; set; }

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

                PointerCoordinatesInfo = new MultilevelPointer(
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

                PointerVelocityInfo = new MultilevelPointer(
                    memoryAccess,
                    IntPtr.Add(BaseAddress, pointerForVelocityInfo),
                    0x500
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
                        pointerForVelocityInfo = 0x01965348;
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
            PointerGameStatusInfo.UpdatePointers();
            PointerCoordinatesInfo.UpdatePointers();
            PointerCurrentWeapon.UpdatePointers();
            PointerBossInfo.UpdatePointers();
            PointerPlayerStatusesInfo.UpdatePointers();
            PointerVelocityInfo.UpdatePointers();
        }

        internal unsafe IGameMemoryDR1 Refresh()
        {
            bool success;

            //Game Info
            if (SafeReadByteArray(PointerGameStatusInfo.Address, sizeof(GameStatusInfo), out byte[] gameStatusInfoBytes))
            {
                var gameStatus = GameStatusInfo.AsStruct(gameStatusInfoBytes);
                gameMemoryValues._isGamePaused = gameStatus.IsGamePaused;
                gameMemoryValues._gameTime = gameStatus.GameTime;
                gameMemoryValues._gamemenu = gameStatus.GameMenu;
            }

            //Coordinates Info
            if (SafeReadByteArray(PointerCoordinatesInfo.Address, sizeof(PlayerCoordinatesInfo), out byte[] gamePlayerCoordinatesInfoBytes))
            {
                var playerCoordinatesInfo = PlayerCoordinatesInfo.AsStruct(gamePlayerCoordinatesInfoBytes);
                gameMemoryValues._playerXPosition = playerCoordinatesInfo.XPosition;
                gameMemoryValues._playerYPosition = playerCoordinatesInfo.YPosition;
                gameMemoryValues._playerZPosition = playerCoordinatesInfo.ZPosition;
                gameMemoryValues._playerRotation1 = playerCoordinatesInfo.Rotation1;
                gameMemoryValues._playerRotation2 = playerCoordinatesInfo.Rotation2;
            }

            //Player Statuses Info
            if (SafeReadByteArray(PointerPlayerStatusesInfo.Address, sizeof(PlayerStatusesInfo), out byte[] gamePlayerStatusesInfoBytes))
            {
                var playerStatusesInfo = PlayerStatusesInfo.AsStruct(gamePlayerStatusesInfoBytes);
                gameMemoryValues._attack = playerStatusesInfo.Attack;
                gameMemoryValues._speed = playerStatusesInfo.Speed;
                gameMemoryValues._life = playerStatusesInfo.Life;
                gameMemoryValues._itemStock = playerStatusesInfo.ItemStock;
                gameMemoryValues._throwDistance = playerStatusesInfo.ThrowDistance;
            }

            // Velocity Info
            if (SafeReadByteArray(PointerVelocityInfo.Address, sizeof(VelocityInfo), out byte[] gameVelocityInfoBytes))
            {
                var velovity = VelocityInfo.AsStruct(gameVelocityInfoBytes);
                gameMemoryValues._walkedDistance = velovity.WalkedDistance;
            }

            // Current Weapon Info
            if (SafeReadByteArray(PointerCurrentWeapon.Address, sizeof(WeaponInfo), out byte[] gameWeaponInfoBytes))
            {
                var weapon = WeaponInfo.AsStruct(gameWeaponInfoBytes);
                gameMemoryValues._weaponDurability = weapon.Durability;
                gameMemoryValues._weaponMaxDurability = weapon.MaxDurability;
                gameMemoryValues._weaponMaxAmmo = weapon.MaxAmmo;
            }

            //Boss Info
            if (SafeReadByteArray(PointerBossInfo.Address, sizeof(BossInfo), out byte[] gameBossInfoBytes))
            {
                var bossInfo = BossInfo.AsStruct(gameBossInfoBytes);
                gameMemoryValues._bossCurrentHealth = bossInfo.CurrentHealth;
                gameMemoryValues._bossMaxHealth = bossInfo.MaxHealth;
            }

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