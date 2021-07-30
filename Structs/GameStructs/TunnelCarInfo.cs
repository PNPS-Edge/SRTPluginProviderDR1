using System.Runtime.InteropServices;

namespace SRTPluginProviderDR1.Structs.GameStructs
{
    [StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x8)]
    public struct TunnelCarInfo
    {
        [FieldOffset(0x0)] private int maxHealth;
        [FieldOffset(0x4)] private int currentHealth;

        public int MaxHealth => maxHealth;
        public int CurrentHealth => currentHealth;
        public bool IsAlive => CurrentHealth != 0 && CurrentHealth > 0 && CurrentHealth <= MaxHealth;
        public float Percentage => IsAlive ? (float)CurrentHealth / (float)MaxHealth : 0f;

        public enum PlayerStatus
        {
            Dead,
            Fine,
            FineToo,
            Caution,
            Danger,
        }

        public PlayerStatus HealthState
        {
            get =>
                !IsAlive ? PlayerStatus.Dead :
                Percentage >= 0.75 ? PlayerStatus.Fine :
                Percentage >= 0.50 ? PlayerStatus.FineToo :
                Percentage >= 0.25 ? PlayerStatus.Caution : PlayerStatus.Danger;
        }

        public string CurrentHealthState => HealthState.ToString();
    }
}
