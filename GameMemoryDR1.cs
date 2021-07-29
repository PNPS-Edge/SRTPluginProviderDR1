using SRTPluginProviderDR1.Structs;
using System.Diagnostics;
using System.Numerics;
using System.Reflection;

namespace SRTPluginProviderDR1
{
    /// <summary>
    /// Class for Game Memory for Dead Rising (2016)
    /// </summary>
    public class GameMemoryDR1 : IGameMemoryDR1
    {
        /// <summary>
        /// Gets the version
        /// </summary>
        public string VersionInfo => FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion;

        /// <summary>
        /// Gets or sets the game information
        /// </summary>
        public Game Game { get; set; }
        
        /// <summary>
        /// Gets game name for web server UI
        /// </summary>
        public string GameName => "Dead Rising 1";

        /// <summary>
        /// Gets or sets the campaign information
        /// </summary>
        public Campaign Campaign { get; set; }

        /// <summary>
        /// Gets or sets the player information
        /// </summary>
        public Player Player { get; set; }

        /// <summary>
        /// Gets or sets the camera position information
        /// </summary>
        public Vector3 CameraPosition { get => _cameraPosition; set => _cameraPosition = value; }
        internal Vector3 _cameraPosition;

        /// <summary>
        /// Gets or sets the weapon durability information
        /// </summary>
        public float WeaponDurability { get => _weaponDurability; set => _weaponDurability = value; }
        internal float _weaponDurability;

        /// <summary>
        /// Gets or sets the weapon max durability information
        /// </summary>
        public float WeaponMaxDurability { get => _weaponMaxDurability; set => _weaponMaxDurability = value; }
        internal float _weaponMaxDurability;

        /// <summary>
        /// Gets or sets the weapon max ammo information
        /// </summary>
        public short WeaponMaxAmmo { get => _weaponMaxAmmo; set => _weaponMaxAmmo = value; }
        internal short _weaponMaxAmmo;

        /// <summary>
        /// Gets or sets the boss current health information
        /// </summary>
        public int BossCurrentHealth { get => _bossCurrentHealth; set => _bossCurrentHealth = value; }
        internal int _bossCurrentHealth;

        /// <summary>
        /// Gets or sets the boss max health information
        /// </summary>
        public int BossMaxHealth { get => _bossMaxHealth; set => _bossMaxHealth = value; }
        internal int _bossMaxHealth;

        /// <summary>
        /// Gets or sets the tunnel car current health information
        /// </summary>
        public int TunnelCarCurrentHealth { get => _tunnelCarCurrentHealth; set => _tunnelCarCurrentHealth = value; }
        internal int _tunnelCarCurrentHealth;

        /// <summary>
        /// Gets or sets the tunnel car max health information
        /// </summary>
        public int TunnelCarMaxHealth { get => _tunnelCarMaxHealth; set => _tunnelCarMaxHealth = value; }
        internal int _tunnelCarMaxHealth;

        /// <summary>
        /// Initializes a new intance of the <see cref="GameMemoryDR1"/> class
        /// </summary>
        public GameMemoryDR1()
        {
            this.Game = new Game();
            this.Player = new Player();
            this.Campaign = new Campaign();
            this.CameraPosition = new Vector3();
        }
    }
}
