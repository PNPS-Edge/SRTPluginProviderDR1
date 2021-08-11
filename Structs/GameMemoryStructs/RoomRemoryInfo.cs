using System.Runtime.InteropServices;

namespace SRTPluginProviderDR1.Structs.GameStructs
{
    [StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x31)]
    
    public struct RoomRemoryInfo
    {
        #region Fields

        /// <summary>
        /// Field for room
        /// </summary>
        [FieldOffset(0x0)] internal int _roomId;

        /// <summary>
        /// Field a value indicating whether the system is loadin
        /// </summary>
        [FieldOffset(0x30)] internal bool _isLoading;

        #endregion Fields

        #region Properties

        /// <summary>
        /// Gets the room id
        /// </summary>
        public int RoomId => _roomId;

        /// <summary>
        /// Gets a value indicating whether the game loading
        /// </summary>
        public bool IsLoading => _isLoading;

        #endregion Properties
    }
}
