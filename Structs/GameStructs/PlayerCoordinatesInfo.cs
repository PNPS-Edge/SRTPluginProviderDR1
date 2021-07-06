using System.Runtime.InteropServices;

namespace SRTPluginProviderDR1.Structs.GameStructs
{
    [StructLayout(LayoutKind.Explicit, Pack = 1)]

    public unsafe struct PlayerCoordinatesInfo
    {
        [FieldOffset(0x40)] public float XPosition;
        [FieldOffset(0x44)] public float YPosition;
        [FieldOffset(0x48)] public float ZPosition;
        [FieldOffset(0x54)] public float Rotation1;
        [FieldOffset(0x5C)] public float Rotation2;

        public static PlayerCoordinatesInfo AsStruct(byte[] data)
        {
            fixed (byte* pb = &data[0])
            {
                return *(PlayerCoordinatesInfo*)pb;
            }
        }
    }
}
