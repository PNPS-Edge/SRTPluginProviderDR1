using System.Collections.Generic;
using System.Numerics;

namespace SRTPluginProviderDR1
{
    public class PreviousValues
    {
        public int RoomId;
        public Vector3 Position;
        public List<double> SpeedValues;

        public PreviousValues()
        {
            this.SpeedValues = new List<double>();
            this.Position = Vector3.Zero;
        }
    }
}
