using System.Runtime.InteropServices;

namespace SRTPluginProviderDR1.Structs.GameStructs
{
    /// <summary>
    /// Structure for weapon information
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x10)]
    public struct WeaponMemoryInfo
    {
        #region Fields

        /// <summary>
        /// Field for the durability
        /// </summary>
        [FieldOffset(0x0)] internal float _durability;
        
        /// <summary>
        /// Field for the max durability
        /// </summary>
        [FieldOffset(0x4)] internal float _maxDurability;

        /// <summary>
        /// Field for the ammo
        /// </summary>
        [FieldOffset(0x8)] internal short _ammo;

        /// <summary>
        /// Field for the max ammo
        /// </summary>
        [FieldOffset(0xA)] internal short _maxAmmo;

        #endregion Fields

        #region Properties

        /// <summary>
        /// Gets the durability of the weapon
        /// </summary>
        public float Durability => this._durability;

        /// <summary>
        /// Gets the Max durability of the weapon
        /// </summary>
        public float MaxDurability => this._maxDurability;

        /// <summary>
        /// Gets the Ammo of the weapon
        /// </summary>
        public short Ammo => this._ammo;

        /// <summary>
        /// Gets the Max Ammo of the weapon
        /// </summary>
        public short MaxAmmo => this._maxAmmo;
        #endregion Properties
    }
}
