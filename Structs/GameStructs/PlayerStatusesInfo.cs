using System.Runtime.InteropServices;

namespace SRTPluginProviderDR1.Structs.GameStructs
{
    [StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x77)]

    public struct PlayerStatusesInfo
    {
        [FieldOffset(0x50)] private int ppCounter;
        [FieldOffset(0x68)] private short level;
        [FieldOffset(0x72)] private short attack;
        [FieldOffset(0x78)] private byte speed;
        [FieldOffset(0x70)] private short maxHealth;
        [FieldOffset(0x77)] private byte itemStock;
        [FieldOffset(0x76)] private byte throwDistance;

        public int PPCounter => ppCounter;
        public short Level => level;
        public short Attack => attack;
        public byte Speed => speed;
        public short MaxHealth => maxHealth;
        public byte ItemStock => itemStock;
        public byte ThrowDistance => throwDistance;
    }
}
