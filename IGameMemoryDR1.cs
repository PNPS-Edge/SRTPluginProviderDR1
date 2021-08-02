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
        /// Gets or sets the game information
        /// </summary>
        GameStatusInfo Game { get; set; }

        /// <summary>
        /// Gets or sets the campaign information
        /// </summary>
        CampaignInfo Campaign { get; set; }

        /// <summary>
        /// Gets or sets the player information
        /// </summary>
        PlayerInfo Player { get; set; }

        /// <summary>
        /// Gets or sets the player statuses information
        /// </summary>
        PlayerStatusesInfo PlayerStatuses { get; set; }

        /// <summary>
        /// Gets or sets the camera position information
        /// </summary>
        CameraInfo CameraPosition { get; set; }

        /// <summary>
        /// Gets or sets the weapon information
        /// </summary>
        WeaponInfo WeaponInfo { get; set; }

        /// <summary>
        /// Gets or sets the boss information
        /// </summary>
        BossInfo BossInfo { get; set; }

        /// <summary>
        /// Gets or sets the room information
        /// </summary>
        RoomInfo RoomInfo { get; set; }

        /// <summary>
        /// Gets or sets the tunnel information
        /// </summary>
        TunnelCarInfo TunnelCarInfo { get; set; }
    }
}
