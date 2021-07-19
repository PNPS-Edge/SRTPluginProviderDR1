namespace SRTPluginProviderDR1.Structs
{
    /// <summary>
    /// Class for the campain information
    /// </summary>
    public class Campaign
    {
        #region Fields

        /// <summary>
        /// Field for game time
        /// </summary>
        internal uint _gameTime;

        /// <summary>
        /// Field for cutscene id
        /// </summary>
        internal int _cutsceneId;

        /// <summary>
        /// Field for campaing progress
        /// </summary>
        internal int _campaignProgress;

        /// <summary>
        /// Field for current room identifier
        /// </summary>
        internal int _roomId;

        #endregion Fields

        #region Properties

        /// <summary>
        /// Gets or sets the game time
        /// </summary>
        public uint GameTime { get => _gameTime; set => _gameTime = value; }

        /// <summary>
        /// Gets or sets the cutscene id
        /// </summary>
        public int CutsceneId { get => _cutsceneId; set => _cutsceneId = value; }

        /// <summary>
        /// Gets or sets the campaign progress
        /// </summary>
        public int CampaignProgress { get => _campaignProgress; set => _campaignProgress = value; }

        /// <summary>
        /// Gets or sets the room identifer
        /// </summary>
        public int RoomId { get => _roomId; set => _roomId = value; }

        #endregion Properties
    }
}
