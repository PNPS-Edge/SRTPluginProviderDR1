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
    public class GameInfoDR1 : IGameInfoDR1
    {
        #region Fields

        /// <summary>
        /// Field for Game memory info
        /// </summary>
        internal Developper _game;

        /// <summary>
        /// Field for campaign info
        /// </summary>
        internal CampaignMemoryInfo _campaign;

        /// <summary>
        /// Field for player info
        /// </summary>
        internal PlayerMemoryInfo _player;

        /// <summary>
        /// Field for player statuses info
        /// </summary>
        internal PlayerStatusesMemoryInfo _playerStatuses;

        /// <summary>
        /// Field for camera position info
        /// </summary>
        internal CameraMemoryInfo _cameraPosition;

        /// <summary>
        /// Field for weapon durability info
        /// </summary>
        internal WeaponMemoryInfo _weaponInfo;

        /// <summary>
        /// Field for boss info
        /// </summary>
        internal BossMemoryInfo _bossInfo;

        /// <summary>
        /// Field for room info
        /// </summary>
        internal RoomRemoryInfo _roomInfo;

        /// <summary>
        /// Field for tunnel car info
        /// </summary>
        internal TunnelCarMemoryInfo _tunnelCarInfo;

        /// <summary>
        /// Field for pp sticker info
        /// </summary>
        internal PPStickersMemoryInfo _ppStickersMemoryInfo;

        #endregion Fields

        #region Properties

        /// <summary>
        /// Gets the version
        /// </summary>
        public string VersionInfo => FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion;

        /// <summary>
        /// Gets or sets the game information
        /// </summary>
        public GameMemoryInfo Game { get => _game; set => _game = value; }

        /// <summary>
        /// Gets or sets the campaign information
        /// </summary>
        public CampaignMemoryInfo Campaign { get => _campaign; set => _campaign = value; }

        /// <summary>
        /// Gets or sets the player information
        /// </summary>
        public PlayerMemoryInfo Player { get => _player; set => _player = value; }

        /// <summary>
        /// Gets or sets the player information
        /// </summary>
        public PlayerStatusesMemoryInfo PlayerStatuses { get => _playerStatuses; set => _playerStatuses = value; }

        /// <summary>
        /// Gets or sets the camera position information
        /// </summary>
        public CameraMemoryInfo CameraPosition { get => _cameraPosition; set => _cameraPosition = value; }

        /// <summary>
        /// Gets or sets the weapon durability information
        /// </summary>
        public WeaponMemoryInfo WeaponInfo { get => _weaponInfo; set => _weaponInfo = value; }

        /// <summary>
        /// Gets or sets the boss current health information
        /// </summary>
        public BossMemoryInfo BossInfo { get => _bossInfo; set => _bossInfo = value; }

        /// <summary>
        /// Gets or sets the boss current health information
        /// </summary>
        public RoomRemoryInfo RoomInfo { get => _roomInfo; set => _roomInfo = value; }

        /// <summary>
        /// Gets or sets the tunnel car information
        /// </summary>
        public TunnelCarMemoryInfo TunnelCarInfo { get => _tunnelCarInfo; set => _tunnelCarInfo = value; }

        /// <summary>
        /// Gets or sets the PP Sticker info
        /// </summary>
        public PPStickersMemoryInfo PpStickersMemoryInfo { get => _ppStickersMemoryInfo; set => _ppStickersMemoryInfo = value; }

        #endregion Properties
    }
}
