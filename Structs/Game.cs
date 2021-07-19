namespace SRTPluginProviderDR1.Structs
{
    /// <summary>
    /// Class for the game information
    /// </summary>
    public class Game
    {
        #region Fields

        /// <summary>
        /// Field for the game menu opened
        /// </summary>
        internal int _gamemenu;

        /// <summary>
        /// Field to indicates whether the game is paused
        /// </summary>
        internal bool _isGamePaused;

        /// <summary>
        /// Field to indicates whether the game is loading
        /// </summary>
        internal bool _isLoading;

        #endregion Fields

        #region Properties

        /// <summary>
        /// Gets or sets the game menu opened
        /// </summary>
        public int GameMenu { get => _gamemenu; set => _gamemenu = value; }

        /// <summary>
        /// Gets or sets a value indicating whether the game is paused
        /// </summary>
        public bool IsGamePaused { get => _isGamePaused; set => _isGamePaused = value; }

        /// <summary>
        /// Gets or sets a value indicating whether the game is loading
        /// </summary>
        public bool IsLoading { get => _isLoading; set => _isLoading = value; }

        #endregion Properties
    }
}
