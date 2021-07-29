using System.Runtime.InteropServices;

namespace SRTPluginProviderDR1.Structs.GameStructs
{

    [StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x71)]
    
    public struct RoomInfo
    {
        [FieldOffset(0x40)] private int roomId;
        [FieldOffset(0x44)] private int loadingRoom1Id;
        [FieldOffset(0x48)] private int loadingRoom2Id;
        [FieldOffset(0x70)] private bool isLoading;

        public int RoomId => roomId;
        public int LoadingRoom1Id => loadingRoom1Id;
        public int LoadingRoom2Id => loadingRoom2Id;
        public bool IsLoading => isLoading;
    }
}
