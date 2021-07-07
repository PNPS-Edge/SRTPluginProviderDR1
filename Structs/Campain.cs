using System;
using System.Collections.Generic;
using System.Text;

namespace SRTPluginProviderDR1.Structs
{
    /// <summary>
    /// Class for the campain information
    /// </summary>
    public class Campain
    {
        #region Fields

        internal uint _gameTime;
        internal int _cutsceneId;
        internal int _campaignProgress;
        internal int _roomId;
        internal int _loadingRoom1Id;
        internal int _loadingRoom2Id;

        #endregion Fields

        #region Properties

        public uint GameTime { get => _gameTime; set => _gameTime = value; }

        public int CutsceneId { get => _cutsceneId; set => _cutsceneId = value; }

        public int CampaignProgress { get => _campaignProgress; set => _campaignProgress = value; }

        public int RoomId { get => _roomId; set => _roomId = value; }

        public int LoadingRoom1Id { get => _loadingRoom1Id; set => _loadingRoom1Id = value; }

        public int LoadingRoom2Id { get => _loadingRoom2Id; set => _loadingRoom2Id = value; }

        #endregion Properties
    }
}
