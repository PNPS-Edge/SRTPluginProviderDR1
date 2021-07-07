using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace SRTPluginProviderDR1.Structs.GameStructs
{
    [StructLayout(LayoutKind.Explicit, Pack = 1)]

    public unsafe struct CampainInfo
    {
        [FieldOffset(0x150)] public int CampainProgress;
        [FieldOffset(0x8308)] public int CutsceneId;

        public static CampainInfo AsStruct(byte[] data)
        {
            fixed (byte* pb = &data[0])
            {
                return *(CampainInfo*)pb;
            }
        }
    }
}
