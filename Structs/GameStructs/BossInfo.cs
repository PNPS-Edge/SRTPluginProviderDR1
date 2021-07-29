using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace SRTPluginProviderDR1.Structs.GameStructs
{
    [StructLayout(LayoutKind.Explicit, Pack = 1)]

    public unsafe struct BossInfo
    {
        [FieldOffset(0x12E8)] public int MaxHealth;
        [FieldOffset(0x12EC)] public int CurrentHealth;

        public bool IsAlive => MaximumHP > 0 && CurrentHP > 0 && CurrentHP <= MaximumHP;
        public bool IsDamaged => IsAlive && CurrentHP < MaximumHP;
        public float Percentage => IsAlive ? (float)CurrentHP / (float)MaximumHP : 0f;
        
        public static BossInfo AsStruct(byte[] data)
        {
            fixed (byte* pb = &data[0])
            {
                return *(BossInfo*)pb;
            }
        }
    }
}
