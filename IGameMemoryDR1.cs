using SRTPluginProviderDR1.Structs;
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
        Game Game { get; set; }

        /// <summary>
        /// Gets or sets the campaign information
        /// </summary>
        Campaign Campaign { get; set; }

        /// <summary>
        /// Gets or sets the player information
        /// </summary>
        Player Player { get; set; }

        /// <summary>
        /// Gets or sets the camera position information
        /// </summary>
        Vector3 CameraPosition { get; set; }

        /// <summary>
        /// Gets or sets the weapon durability information
        /// </summary>
        float WeaponDurability { get; set; }

        /// <summary>
        /// Gets or sets the weapon max durability information
        /// </summary>
        float WeaponMaxDurability { get; set; }

        /// <summary>
        /// Gets or sets the weapon max ammo information
        /// </summary>
        short WeaponMaxAmmo { get; set; }

        /// <summary>
        /// Gets or sets the boss current health information
        /// </summary>
        int BossCurrentHealth { get; set; }

        /// <summary>
        /// Gets or sets the boss max health information
        /// </summary>
        int BossMaxHealth { get; set; }

        /// <summary>
        /// Gets or sets the tunnel car current health information
        /// </summary>
        int TunnelCarCurrentHealth { get; set; }

        /// <summary>
        /// Gets or sets the tunnel car max health information
        /// </summary>
        int TunnelCarMaxHealth { get; set; }
    }
}
