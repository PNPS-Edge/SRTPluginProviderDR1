using System.Runtime.InteropServices;

namespace SRTPluginProviderDR1.Structs.GameStructs
{
    [StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x29)]

    public struct PlayerStatusesInfo
    {
        #region Fields

        /// <summary>
        /// Field for the PP Counter
        /// </summary>
        [FieldOffset(0x00)] internal int _pPCounter;

        /// <summary>
        /// Field for the Level
        /// </summary>
        [FieldOffset(0x18)] internal short _level;

        /// <summary>
        /// Field for the max health
        /// </summary>
        [FieldOffset(0x20)] internal short _maxHealth;

        /// <summary>
        /// Field for the attack
        /// </summary>
        [FieldOffset(0x22)] internal short _attack;

        /// <summary>
        /// Field for the throw distance
        /// </summary>
        [FieldOffset(0x26)] internal byte _throwDistance;

        /// <summary>
        /// Field for the item stock
        /// </summary>
        [FieldOffset(0x27)] internal byte _itemStock;

        /// <summary>
        /// Field for the speed
        /// </summary>
        [FieldOffset(0x28)] internal byte _speed;

        #endregion Fields

        #region Fields

        /// <summary>
        /// Get the PP counter
        /// </summary>
        public int PPCounter => this._pPCounter;

        /// <summary>
        /// Get the Level
        /// </summary>
        public short Level => this._level;

        /// <summary>
        /// Get the Max level
        /// </summary>
        public short MaxHealth => this._maxHealth;

        /// <summary>
        /// Get the attack
        /// </summary>
        public short Attack => this._attack;

        /// <summary>
        /// Get the throw distance
        /// </summary>
        public byte ThrowDistance => this._throwDistance;

        /// <summary>
        /// Get the item stock
        /// </summary>
        public byte ItemStock => this._itemStock;

        /// <summary>
        /// Get the speed
        /// </summary>
        public byte Speed => this._speed;

        #endregion Fields
    }
}
