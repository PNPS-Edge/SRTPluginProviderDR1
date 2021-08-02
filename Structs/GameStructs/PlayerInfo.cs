using System.Numerics;
using System.Runtime.InteropServices;

namespace SRTPluginProviderDR1.Structs.GameStructs
{
    [StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x12B0)]

    public struct PlayerInfo
    {
        #region Fields

        /// <summary>
        /// Field for the player position
        /// </summary>
        [FieldOffset(0x0)] internal Vector3 _position;

        /// <summary>
        /// Field for the player rotation
        /// </summary>
        [FieldOffset(0x14)] internal Vector2 _rotation;

        /// <summary>
        /// Filed for the player current health
        /// </summary>
        [FieldOffset(0x12AC)] internal short _health;

        #endregion Fields

        #region Properties

        /// <summary>
        /// Gets the position of the player
        /// </summary>
        public Vector3 Position => _position;

        /// <summary>
        /// Gets the rotation of the player
        /// </summary>
        public Vector2 Rotation => _rotation;

        /// <summary>
        /// Gets the health of the player
        /// </summary>
        public short Health => _health;

        #endregion Properties
    }
}
