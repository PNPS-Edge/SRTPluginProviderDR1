using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace SRTPluginProviderDR1.Structs.GameStructs
{

    [StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x71)]
    
    public unsafe struct RoomInfo
    {
        [FieldOffset(0x40)] public int RoomId;
        [FieldOffset(0x44)] public int LoadingRoom1Id;
        [FieldOffset(0x48)] public int LoadingRoom2Id;
        [FieldOffset(0x70)] public bool IsLoading;

        public static RoomInfo AsStruct(byte[] data)
        {
            fixed (byte* pb = &data[0])
            {
                return *(RoomInfo*)pb;
            }
        }
    }
}
