using SRTPluginProviderDR1.Structs;
using SRTPluginProviderDR1.Structs.GameModel;
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
        /// Gets or sets the developper view
        /// </summary>
        DevelopperModelInfo DevelopperInfo { get; }

        /// <summary>
        /// Gets or sets the speedrunner view
        /// </summary>
        SpeedrunnerModelInfo SpeedrunnerInfo { get; }

        /// <summary>
        /// Gets or sets the PP Stickers Trainer view
        /// </summary>
        PPStickerModelInfo PPStickerInfo { get; }
    }
}
