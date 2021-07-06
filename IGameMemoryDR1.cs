using System;

namespace SRTPluginProviderDR1
{
    public interface IGameMemoryDR1
    {
        string VersionInfo { get; }

        int GameMenu { get; set; }

        bool IsGamePaused { get; set; }

        uint GameTime { get; set; }

        float PlayerXPosition { get; set; }

        float PlayerYPosition { get; set; }

        float PlayerZPosition { get; set; }

        float PlayerRotation1 { get; set; }

        float PlayerRotation2 { get; set; }

        long WalkedDistance { get; set; }

        short Attack { get; set; }

        byte Speed { get; set; }

        short Life { get; set; }

        byte ItemStock { get; set; }

        byte ThrowDistance { get; set; }

        float WeaponDurability { get; set; }

        float WeaponMaxDurability { get; set; }

        short WeaponMaxAmmo { get; set; }

        int BossCurrentHealth { get; set; }

        int BossMaxHealth { get; set; }
    }
}
