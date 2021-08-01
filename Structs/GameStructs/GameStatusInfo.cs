using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace SRTPluginProviderDR1.Structs.GameStructs
{
    [StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x19C)]

    public unsafe struct GameStatusInfo
    {
        [FieldOffset(0x38)] public int GameMenu;
        [FieldOffset(0x182)] public bool IsGamePaused;
        [FieldOffset(0x198)] public uint GameTime;

        public static GameStatusInfo AsStruct(byte[] data)
        {
            fixed (byte* pb = &data[0])
            {
                return *(GameStatusInfo*)pb;
            }
        }
    }
}
