using System;

namespace SRTPluginProviderDR1
{
    public interface IGameMemoryDR1
    {
        string VersionInfo { get; }

        int PlayerCurrentHealth { get; set; }

        int PlayerMaxHealth { get; set; }
    }
}
