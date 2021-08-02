using System.Runtime.InteropServices;

namespace SRTPluginProviderDR1.Structs.GameStructs
{
    [StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x8)]
    public struct TunnelCarInfo
    {
        #region Fields

        /// <summary>
        /// Field for current car health
        /// </summary>
        [FieldOffset(0x0)] internal int _currentHealth;

        /// <summary>
        /// Field for the max health
        /// </summary>
        [FieldOffset(0x4)] internal int _maxHealth;

        #endregion Fields

        #region Properties

        /// <summary>
        /// Gets the current health
        /// </summary>
        public int CurrentHealth => _currentHealth;

        /// <summary>
        /// Gets the max health
        /// </summary>
        public int MaxHealth => _maxHealth;
        #endregion Properties
    }
}
