using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace SRTPluginProviderDR1.Structs.GameStructs
{
    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public unsafe struct TunnelCarInfo
    {
        [FieldOffset(0x12EC)] public int CurrentHealth;
        [FieldOffset(0x12E8)] public int MaxHealth;

        public static TunnelCarInfo AsStruct(byte[] data)
        {
            fixed (byte* pb = &data[0])
            {
                return *(TunnelCarInfo*)pb;
            }
        }
    }
}
