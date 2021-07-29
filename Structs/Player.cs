using System.Numerics;

namespace SRTPluginProviderDR1.Structs
{
    /// <summary>
    /// Class for the player information
    /// </summary>
    public class Player
    {
        #region Fields

        /// <summary>
        /// Field for the position of the player
        /// </summary>
        internal Vector3 _position;

        /// <summary>
        /// Field for the rotation of the player
        /// </summary>
        internal Vector2 _rotation;

        /// <summary>
        /// Field for current health of the player
        /// </summary>
        internal short _currentHealth;

        /// <summary>
        /// Field for max health of the player
        /// </summary>
        internal short _maxHealth;

        /// <summary>
        /// Field for the walked distance of the player
        /// </summary>
        internal long _walkedDistance;

        /// <summary>
        /// Field for the attack status of the player
        /// </summary>
        internal short _statusAttack;

        /// <summary>
        /// Field for the speed status of the player
        /// </summary>
        internal byte _statusSpeed;

        /// <summary>
        /// Field for the item stock status of the player
        /// </summary>
        internal byte _statusItemStock;

        /// <summary>
        /// Field for the throw distance status of the player
        /// </summary>
        internal byte _statusThrowDistance;

        /// <summary>
        /// Field for the value of the pp counter the player
        /// </summary>
        internal int _ppCounter;

        /// <summary>
        /// Field for the level of the player
        /// </summary>
        internal int _level;

        #endregion Fields

        #region Properties

        /// <summary>
        /// Gets or sets the position of the player
        /// </summary>
        public Vector3 Position { get => _position; set => _position = value; }

        /// <summary>
        /// Gets or sets the rotation of the player
        /// </summary>
        public Vector2 Rotation { get => _rotation; set => _rotation = value; }

        /// <summary>
        /// Gets or sets the current health of the player
        /// </summary>
        public short CurrentHealth { get => _currentHealth; set => _currentHealth = value; }

        /// <summary>
        /// Gets or sets the max health of the player
        /// </summary>
        public short MaxHealth { get => _maxHealth; set => _maxHealth = value; }
        
        /// <summary>
        /// Gets or sets the percent of health for the player
        /// </summary>
        public bool IsAlive => CurrentHealth != 0 && CurrentHealth > 0 && CurrentHealth <= MaxHealth;
        
        /// <summary>
        /// Gets or sets the percent of health for the player
        /// </summary>
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

        /// <summary>
        /// Gets or sets the walked distance of the player
        /// </summary>
        public long WalkedDistance { get => _walkedDistance; set => _walkedDistance = value; }

        /// <summary>
        /// Gets or sets the attack status of the player
        /// </summary>
        public short StatusAttack { get => _statusAttack; set => _statusAttack = value; }

        /// <summary>
        /// Gets or sets the speed status of the player
        /// </summary>
        public byte StatusSpeed { get => _statusSpeed; set => _statusSpeed = value; }

        /// <summary>
        /// Gets or sets the item stock status of the player
        /// </summary>
        public byte StatusItemStock { get => _statusItemStock; set => _statusItemStock = value; }

        /// <summary>
        /// Gets or sets the throw distance status of the player
        /// </summary>
        public byte StatusThrowDistance { get => _statusThrowDistance; set => _statusThrowDistance = value; }

        /// <summary>
        /// Gets or sets the PP counter of the player
        /// </summary>
        public int PPCounter { get => _ppCounter; set => _ppCounter = value; }

        /// <summary>
        /// Gets or sets the level status of the player
        /// </summary>
        public int Level { get => _level; set => _level = value; }

        #endregion Properties

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Player"/> class
        /// </summary>
        public Player()
        {
            this.Position = new Vector3();
            this.Rotation = new Vector2();
        }

        #endregion Constuctors
    }
}
