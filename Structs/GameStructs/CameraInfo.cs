using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;

namespace SRTPluginProviderDR1.Structs.GameStructs
{
    [StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x14)]

    public unsafe struct CameraInfo
    {
        [FieldOffset(0x8)] private Vector3 Position;

        public float X => Position.X;
        public float Y => Position.Y;
        public float Z => Position.Z;
    }
}
