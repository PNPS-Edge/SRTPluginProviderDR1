using SRTPluginProviderDR1.Structs;
using SRTPluginProviderDR1.Structs.GameModel;
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
        #region Properties

        /// <summary>
        /// Gets the version
        /// </summary>
        public string VersionInfo => FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion;

        /// <summary>
        /// Gets or sets the developper view
        /// </summary>
        public DevelopperModelInfo DevelopperInfo { get; internal set; }

        /// <summary>
        /// Gets or sets the speedrunner view
        /// </summary>
        public SpeedrunnerModelInfo SpeedrunnerInfo { get; internal set; }

        /// <summary>
        /// Gets or sets the PP Stickers Trainer view
        /// </summary>
        public PPStickerModelInfo PPStickerInfo { get; internal set; }

        #endregion Properties

        /// <summary>
        /// Loads the views according to memory values
        /// </summary>
        /// <param name="gameMemory"></param>
        public void Load(IGameMemoryDR1 gameMemory, PreviousValues previousValues)
        {
            if (gameMemory.RoomInfo.RoomId != previousValues.RoomId)
            {
                previousValues.SpeedValues.Clear();
            }


        }
    }
}
