using System.Runtime.InteropServices;

namespace SRTPluginProviderDR1.Structs.GameStructs
{
    [StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x8)]

    public unsafe struct BossInfo
    {
        [FieldOffset(0x0)] private int maxHealth;
        [FieldOffset(0x4)] private int currentHealth;

        public int MaxHealth => maxHealth;
        public int CurrentHealth => currentHealth;
        public bool IsAlive => MaxHealth > 0 && CurrentHealth > 0 && CurrentHealth <= MaxHealth;
        public bool IsDamaged => IsAlive && CurrentHealth < MaxHealth;
        public float Percentage => IsAlive ? (float)CurrentHealth / (float)MaxHealth : 0f;
    }
}
