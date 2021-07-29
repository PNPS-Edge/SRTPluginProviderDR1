using SRTPluginProviderDR1.Structs;
using SRTPluginProviderDR1.Structs.GameStructs;
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
        public GameStatusInfo Game { get => _game; set => _game = value; }
        internal GameStatusInfo _game;
        
        /// <summary>
        /// Gets game name for web server UI
        /// </summary>
        public string GameName => "Dead Rising 1";

        /// <summary>
        /// Gets or sets the campaign information
        /// </summary>
        public CampainInfo Campaign { get; set; }

        public PlayerInfo Player { get => _player; set => _player = value; }
        internal PlayerInfo _player;

        public PlayerStatusesInfo PlayerStats { get => _playerStats; set => _playerStats = value; }
        internal PlayerStatusesInfo _playerStats;

        public RoomInfo RoomData { get => _roomData; set => _roomData = value; }
        internal RoomInfo _roomData;

        /// <summary>
        /// Gets or sets the camera position information
        /// </summary>
        public CameraInfo CameraPosition { get => _cameraPosition; set => _cameraPosition = value; }
        internal CameraInfo _cameraPosition;

        public WeaponInfo CurrentWeapon { get => _currentWeapon; set => _currentWeapon = value; }
        internal WeaponInfo _currentWeapon;

        /// <summary>
        /// Gets or sets the boss information
        /// </summary>
        public BossInfo Boss { get => _boss; set => _boss = value; }
        internal BossInfo _boss;

        /// <summary>
        /// Gets or sets the tunnel car current health information
        /// </summary>
        public TunnelCarInfo CarInfo { get => _carInfo; set => _carInfo = value; }
        internal TunnelCarInfo _carInfo;
    }
}
