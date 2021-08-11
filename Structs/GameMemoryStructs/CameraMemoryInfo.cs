using System.Numerics;
using System.Runtime.InteropServices;

namespace SRTPluginProviderDR1.Structs.GameStructs
{
    [StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0xC)]

    public struct CameraMemoryInfo
    {
        #region Fields

        /// <summary>
        /// Field for position of the camera
        /// </summary>
        [FieldOffset(0x0)] internal Vector3 _position;

        #endregion Fields

        #region Properties

        /// <summary>
        /// Gets or the position
        /// </summary>
        public Vector3 Position => _position;

        #endregion Properties
    }
}
