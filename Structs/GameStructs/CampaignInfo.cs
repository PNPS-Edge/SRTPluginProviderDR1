using System.Runtime.InteropServices;

namespace SRTPluginProviderDR1.Structs.GameStructs
{
    [StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x81BC)]

    public struct CampaignInfo
    {
        #region Fields

        /// <summary>
        /// Field for campaign progress
        /// </summary>
        [FieldOffset(0x0)] internal int _campaignProgress;

        /// <summary>
        /// Field for cutscene id
        /// </summary>
        [FieldOffset(0x81B8)] internal int _cutsceneId;

        #endregion Fields

        #region Properties

        /// <summary>
        /// Gets the campaign progress
        /// </summary>
        public int CampaignProgress { get => _campaignProgress; set => _campaignProgress = value; }

        /// <summary>
        /// Gets the cutscene identifier
        /// </summary>
        public int CutsceneId { get => _cutsceneId; set => _cutsceneId = value; }

        #endregion Properties
    }
}
