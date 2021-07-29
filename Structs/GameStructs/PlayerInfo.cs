using System.Numerics;
using System.Runtime.InteropServices;

namespace SRTPluginProviderDR1.Structs.GameStructs
{
    [StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x12F0)]

    public struct PlayerInfo
    {
        [FieldOffset(0x40)] private Vector3 position;
        [FieldOffset(0x54)] private Vector2 rotation;
        [FieldOffset(0x12E8)] private int maxHealth;
        [FieldOffset(0x12EC)] private int currentHealth;

        public float X => position.X;
        public float Y => position.Y;
        public float Z => position.Z;
        public float RX => rotation.X;
        public float RY => rotation.Y;
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
