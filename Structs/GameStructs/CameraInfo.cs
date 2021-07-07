using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace SRTPluginProviderDR1.Structs.GameStructs
{
    [StructLayout(LayoutKind.Explicit, Pack = 1)]

    public unsafe struct CameraInfo
    {
        [FieldOffset(0x40)] public float XPosition;
        [FieldOffset(0x44)] public float YPosition;
        [FieldOffset(0x48)] public float ZPosition;

        public static CameraInfo AsStruct(byte[] data)
        {
            fixed (byte* pb = &data[0])
            {
                return *(CameraInfo*)pb;
            }
        }
    }
}
