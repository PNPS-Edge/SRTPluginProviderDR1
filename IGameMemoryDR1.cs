using System;
using SRTPluginProviderDR1.Structs;
using SRTPluginProviderDR1.Structs.GameStructs;

namespace SRTPluginProviderDR1
{
    public interface IGameMemoryDR1
    {
        string VersionInfo { get; }
        PlayerStatus PlayerStatus { get; set; }
        float PlayerCurrentHealth { get; set; }
        float PlayerMaxHealth { get; set; }
        float PlayerPositionX { get; set; }
        float PlayerPositionY { get; set; }
        float PlayerPositionZ { get; set; }
        int RankScore { get; set; }
        int Rank { get; set; }
        int Lei { get; set; }
        int EventType { get; set; }
        byte IsMotionPlay { get; set; }
        string CurrentEvent { get; set; }
        InventoryEntry[] PlayerInventory { get; set; }
        EnemyHP[] EnemyHealth { get; set; }
        InventoryEntry LastKeyItem { get; set; }

    }
}
