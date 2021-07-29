using System.Runtime.InteropServices;

namespace SRTPluginProviderDR1.Structs.GameStructs
{
    [StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x8)]
    public struct TunnelCarInfo
    {
        [FieldOffset(0x0)] private int maxHealth;
        [FieldOffset(0x4)] private int currentHealth;

        public int MaxHealth => maxHealth;
        public int CurrentHealth => currentHealth;
    }
}
