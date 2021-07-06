using System.Runtime.InteropServices;

namespace SRTPluginProviderDR1.Structs.GameStructs
{
    [StructLayout(LayoutKind.Explicit, Pack = 1)]

    public unsafe struct VelocityInfo
    {
        [FieldOffset(0xBF0)] public int WalkedDistance;

        public static VelocityInfo AsStruct(byte[] data)
        {
            fixed (byte* pb = &data[0])
            {
                return *(VelocityInfo*)pb;
            }
        }
    }
}
