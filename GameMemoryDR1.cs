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
        #region Fields

        /// <summary>
        /// Field for Game memory info
        /// </summary>
        internal GameStatusInfo _game;

        /// <summary>
        /// Field for campaign info
        /// </summary>
        internal CampaignInfo _campaign;

        /// <summary>
        /// Field for player info
        /// </summary>
        internal PlayerInfo _player;

        /// <summary>
        /// Field for player statuses info
        /// </summary>
        internal PlayerStatusesInfo _playerStatuses;

        /// <summary>
        /// Field for camera position info
        /// </summary>
        internal CameraInfo _cameraPosition;

        /// <summary>
        /// Field for weapon durability info
        /// </summary>
        internal WeaponInfo _weaponInfo;

        /// <summary>
        /// Field for boss info
        /// </summary>
        internal BossInfo _bossInfo;

        /// <summary>
        /// Field for room info
        /// </summary>
        internal RoomInfo _roomInfo;

        /// <summary>
        /// Field for tunnel car info
        /// </summary>
        internal TunnelCarInfo _tunnelCarInfo;

        #endregion Fields

        #region Properties

        /// <summary>
        /// Gets the version
        /// </summary>
        public string VersionInfo => FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion;

        /// <summary>
        /// Gets or sets the game information
        /// </summary>
        public GameStatusInfo Game { get => _game; set => _game = value; }

        /// <summary>
        /// Gets or sets the campaign information
        /// </summary>
        public CampaignInfo Campaign { get => _campaign; set => _campaign = value; }

        /// <summary>
        /// Gets or sets the player information
        /// </summary>
        public PlayerInfo Player { get => _player; set => _player = value; }

        /// <summary>
        /// Gets or sets the player information
        /// </summary>
        public PlayerStatusesInfo PlayerStatuses { get => _playerStatuses; set => _playerStatuses = value; }

        /// <summary>
        /// Gets or sets the camera position information
        /// </summary>
        public CameraInfo CameraPosition { get => _cameraPosition; set => _cameraPosition = value; }

        /// <summary>
        /// Gets or sets the weapon durability information
        /// </summary>
        public WeaponInfo WeaponInfo { get => _weaponInfo; set => _weaponInfo = value; }

        /// <summary>
        /// Gets or sets the boss current health information
        /// </summary>
        public BossInfo BossInfo { get => _bossInfo; set => _bossInfo = value; }

        /// <summary>
        /// Gets or sets the boss current health information
        /// </summary>
        public RoomInfo RoomInfo { get => _roomInfo; set => _roomInfo = value; }

        /// <summary>
        /// Gets or sets the tunnel car information
        /// </summary>
        public TunnelCarInfo TunnelCarInfo { get => _tunnelCarInfo; set => _tunnelCarInfo = value; }

        #endregion Properties
    }
}
