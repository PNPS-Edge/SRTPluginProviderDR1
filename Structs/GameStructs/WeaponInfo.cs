using System.Runtime.InteropServices;

namespace SRTPluginProviderDR1.Structs.GameStructs
{
    /// <summary>
    /// Structure for weapon information
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x10)]
    public struct WeaponInfo
    {
        [FieldOffset(0x4)] private float durability;
        [FieldOffset(0x8)] private float maxDurability;
        [FieldOffset(0xC)] private short ammo;
        [FieldOffset(0xE)] private short maxAmmo;

        public float Durability => durability;
        public float MaxDurability => durability;
        public short Ammo => ammo;
        public short MaxAmmo => maxAmmo;
    }
}
