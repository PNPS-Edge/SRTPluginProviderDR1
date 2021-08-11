using SRTPluginProviderDR1.Structs;
using SRTPluginProviderDR1.Structs.GameStructs;
using System.Numerics;

namespace SRTPluginProviderDR1
{
    /// <summary>
    /// Interface for Game Memory for Dead Rising (2016)
    /// </summary>
    public interface IGameInfoDR1
    {
        /// <summary>
        /// Gets the version
        /// </summary>
        string VersionInfo { get; }

        /// <summary>
        /// Gets or sets the game information
        /// </summary>
        GameMemoryInfo Game { get; set; }

        /// <summary>
        /// Gets or sets the campaign information
        /// </summary>
        CampaignMemoryInfo Campaign { get; set; }

        /// <summary>
        /// Gets or sets the player information
        /// </summary>
        PlayerMemoryInfo Player { get; set; }

        /// <summary>
        /// Gets or sets the player statuses information
        /// </summary>
        PlayerStatusesMemoryInfo PlayerStatuses { get; set; }

        /// <summary>
        /// Gets or sets the camera position information
        /// </summary>
        CameraMemoryInfo CameraPosition { get; set; }

        /// <summary>
        /// Gets or sets the weapon information
        /// </summary>
        WeaponMemoryInfo WeaponInfo { get; set; }

        /// <summary>
        /// Gets or sets the boss information
        /// </summary>
        BossMemoryInfo BossInfo { get; set; }

        /// <summary>
        /// Gets or sets the room information
        /// </summary>
        RoomRemoryInfo RoomInfo { get; set; }

        /// <summary>
        /// Gets or sets the tunnel information
        /// </summary>
        TunnelCarMemoryInfo TunnelCarInfo { get; set; }
    }
}
