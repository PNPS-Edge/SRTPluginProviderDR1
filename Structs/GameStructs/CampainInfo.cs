using System.Runtime.InteropServices;

namespace SRTPluginProviderDR1.Structs.GameStructs
{
    [StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x830C)]

    public struct CampainInfo
    {
        [FieldOffset(0x150)] private int campainProgress;
        [FieldOffset(0x8308)] private int cutsceneId;

        public int CampainProgress => campainProgress;
        public int CutsceneId => cutsceneId;
    }
}
