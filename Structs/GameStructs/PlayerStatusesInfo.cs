using System.Runtime.InteropServices;

namespace SRTPluginProviderDR1.Structs.GameStructs
{
    [StructLayout(LayoutKind.Explicit, Pack = 1)]

    public unsafe struct PlayerStatusesInfo
    {
        [FieldOffset(0x50)] public int PPCounter;
        [FieldOffset(0x68)] public short Level;
        [FieldOffset(0x72)] public short Attack;
        [FieldOffset(0x78)] public byte Speed;
        [FieldOffset(0x70)] public short MaxHealth;
        [FieldOffset(0x77)] public byte ItemStock;
        [FieldOffset(0x76)] public byte ThrowDistance;

        public static PlayerStatusesInfo AsStruct(byte[] data)
        {
            fixed (byte* pb = &data[0])
            {
                return *(PlayerStatusesInfo*)pb;
            }
        }
    }
}
