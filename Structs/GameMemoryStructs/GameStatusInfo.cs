using System.Runtime.InteropServices;

namespace SRTPluginProviderDR1.Structs.GameStructs
{
    [StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x164)]

    public struct GameStatusInfo
    {
        #region Fields

        /// <summary>
        /// Field for the current game menu opened
        /// </summary>
        [FieldOffset(0x0)] private int gameMenu;

        /// <summary>
        /// Field for indicating a value whether game is pause
        /// </summary>
        [FieldOffset(0x14A)] private bool isGamePaused;

        /// <summary>
        /// Field for the current campaign time
        /// </summary>
        [FieldOffset(0x160)] private uint inGameTime;

        #endregion Fields 

        #region Properties

        /// <summary>
        /// Gets the game menu
        /// </summary>
        public int GameMenu => gameMenu;

        /// <summary>
        /// Gets a value indicating whether the game is paused
        /// </summary>
        public bool IsGamePaused => isGamePaused;

        /// <summary>
        /// Gets a the current campaign time
        /// </summary>
        public uint InGameTime => inGameTime;

        #endregion Properties
    }
}
