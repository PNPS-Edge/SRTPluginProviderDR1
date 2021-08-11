using System.Runtime.InteropServices;

namespace SRTPluginProviderDR1.Structs.GameStructs
{
    [StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x8)]

    public struct BossMemoryInfo
    {
        #region Fields

        /// <summary>
        /// Field for max health
        /// </summary>
        [FieldOffset(0x0)] internal int _maxHealth;

        /// <summary>
        /// Field for current health
        /// </summary>
        [FieldOffset(0x4)] internal int _currentHealth;

        #endregion Fields

        #region Properties

        /// <summary>
        /// Gets or sets the max health
        /// </summary>
        public int MaxHealth => _maxHealth;

        /// <summary>
        /// Gets or sets the current health
        /// </summary>
        public int CurrentHealth => _currentHealth;

        #endregion Properties
    }
}
