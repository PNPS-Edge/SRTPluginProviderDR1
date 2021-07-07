using SRTPluginProviderDR1.Structs;
using System;

namespace SRTPluginProviderDR1
{
    public interface IGameMemoryDR1
    {
        string VersionInfo { get; }

        int GameMenu { get; set; }

        bool IsGamePaused { get; set; }

        uint GameTime { get; set; }

        Player Player { get; set; } 

        float WeaponDurability { get; set; }

        float WeaponMaxDurability { get; set; }

        short WeaponMaxAmmo { get; set; }

        int BossCurrentHealth { get; set; }

        int BossMaxHealth { get; set; }

        int TunnelCarCurrentHealth { get; set; }

        int TunnelCarMaxHealth { get; set; }
    }
}
