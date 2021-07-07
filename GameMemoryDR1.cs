using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Reflection;
using SRTPluginProviderDR1.Structs;

namespace SRTPluginProviderDR1
{
    public class GameMemoryDR1 : IGameMemoryDR1
    {
        public string VersionInfo => FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion;

        public int GameMenu { get => _gamemenu; set => _gamemenu = value; }
        internal int _gamemenu;

        public bool IsGamePaused { get => _isGamePaused; set => _isGamePaused = value; }
        internal bool _isGamePaused;

        public uint GameTime { get => _gameTime; set => _gameTime = value; }
        internal uint _gameTime;

        public Player Player { get; set; }

        public float WeaponDurability { get => _weaponDurability; set => _weaponDurability = value; }
        internal float _weaponDurability;

        public float WeaponMaxDurability { get => _weaponMaxDurability; set => _weaponMaxDurability = value; }
        internal float _weaponMaxDurability;

        public short WeaponMaxAmmo { get => _weaponMaxAmmo; set => _weaponMaxAmmo = value; }
        internal short _weaponMaxAmmo;

        public int BossCurrentHealth { get => _bossCurrentHealth; set => _bossCurrentHealth = value; }
        internal int _bossCurrentHealth;

        public int BossMaxHealth { get => _bossMaxHealth; set => _bossMaxHealth = value; }
        internal int _bossMaxHealth;

        public int TunnelCarCurrentHealth { get => _tunnelCarCurrentHealth; set => _tunnelCarCurrentHealth = value; }
        internal int _tunnelCarCurrentHealth;

        public int TunnelCarMaxHealth { get => _tunnelCarMaxHealth; set => _tunnelCarMaxHealth = value; }
        internal int _tunnelCarMaxHealth;

        /// <summary>
        /// Initializes a new intance of the <see cref="GameMemoryDR1"/> class
        /// </summary>
        public GameMemoryDR1()
        {
            this.Player = new Player();
        }
    }
}
