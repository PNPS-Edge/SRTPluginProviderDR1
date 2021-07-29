using SRTPluginProviderDR1.Structs;
using SRTPluginProviderDR1.Structs.GameStructs;
using System.Numerics;

namespace SRTPluginProviderDR1
{
    /// <summary>
    /// Interface for Game Memory for Dead Rising (2016)
    /// </summary>
    public interface IGameMemoryDR1
    {
        /// <summary>
        /// Gets the version
        /// </summary>
        string VersionInfo { get; }
        
        /// <summary>
        /// Gets game name for web server UI
        /// </summary>
        string GameName { get; }

        /// <summary>
        /// Gets or sets the game information
        /// </summary>
        GameStatusInfo Game { get; set; }

        /// <summary>
        /// Gets or sets the campaign information
        /// </summary>
        CampainInfo Campaign { get; set; }

        PlayerInfo Player { get; set; }
        PlayerStatusesInfo PlayerStats { get; set; }

        RoomInfo RoomData { get; set; }
        /// <summary>
        /// Gets or sets the camera position information
        /// </summary>
        CameraInfo CameraPosition { get; set; }

        /// <summary>
        /// Gets or sets the current weapon information
        /// </summary>
        WeaponInfo CurrentWeapon { get; set; }

        /// <summary>
        /// Gets or sets the boss information
        /// </summary>
        BossInfo Boss { get; set; }

        TunnelCarInfo CarInfo { get; set; }
    }
}
