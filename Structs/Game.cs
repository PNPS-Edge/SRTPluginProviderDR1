using System;
using System.Collections.Generic;
using System.Text;

namespace SRTPluginProviderDR1.Structs
{
    /// <summary>
    /// Class for the game information
    /// </summary>
    public class Game
    {
        #region Fields

        internal int _gamemenu;

        internal bool _isGamePaused;

        internal bool _isLoading;

        #endregion Fields

        #region Properties

        public int GameMenu { get => _gamemenu; set => _gamemenu = value; }

        public bool IsGamePaused { get => _isGamePaused; set => _isGamePaused = value; }

        public bool IsLoading { get => _isLoading; set => _isLoading = value; }

        #endregion Properties
    }
}
