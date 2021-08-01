using System.Runtime.InteropServices;

namespace SRTPluginProviderDR1.Structs.GameStructs
{
    /// <summary>
    /// Structure for weapon information
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x10)]
    public unsafe struct WeaponInfo
    {
        [FieldOffset(0x2E24)] public float Durability;

        [FieldOffset(0x2E28)] public float MaxDurability;

        [FieldOffset(0x2E2C)] public short Ammo;

        [FieldOffset(0x2E2E)] public short MaxAmmo;

        public static WeaponInfo AsStruct(byte[] data)
        {
            fixed (byte* pb = &data[0])
            {
                return *(WeaponInfo*)pb;
            }
        }
    }
}
