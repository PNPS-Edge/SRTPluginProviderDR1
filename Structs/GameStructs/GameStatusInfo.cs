using System.Runtime.InteropServices;

namespace SRTPluginProviderDR1.Structs.GameStructs
{
    [StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x19C)]

    public struct GameStatusInfo
    {
        [FieldOffset(0x38)] private int gameMenu;
        [FieldOffset(0x182)] private bool isGamePaused;
        [FieldOffset(0x198)] private uint gameTime;

        public int GameMenu => gameMenu;
        public bool IsGamePaused => isGamePaused;
        public uint GameTime => gameTime;
    }
}
