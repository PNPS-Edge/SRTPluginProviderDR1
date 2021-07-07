using System.Runtime.InteropServices;

namespace SRTPluginProviderDR1.Structs.GameStructs
{
    [StructLayout(LayoutKind.Explicit, Pack = 1)]

    public unsafe struct PlayerInfo
    {
        [FieldOffset(0x40)] public float XPosition;
        [FieldOffset(0x44)] public float YPosition;
        [FieldOffset(0x48)] public float ZPosition;
        [FieldOffset(0x54)] public float Rotation1;
        [FieldOffset(0x5C)] public float Rotation2;
        [FieldOffset(0x12EC)] public short Health;

        public static PlayerInfo AsStruct(byte[] data)
        {
            fixed (byte* pb = &data[0])
            {
                return *(PlayerInfo*)pb;
            }
        }
    }
}
