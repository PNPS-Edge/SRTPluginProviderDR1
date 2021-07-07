using System;
using System.Collections.Generic;
using System.Text;

namespace SRTPluginProviderDR1.Structs
{
    /// <summary>
    /// Class for the player information
    /// </summary>
    public class Player
    {
        #region Fields

        /// <summary>
        /// Field for current health of the player
        /// </summary>
        internal short _currentHealth;

        /// <summary>
        /// Field for max health of the player
        /// </summary>
        internal short _maxHealth;

        /// <summary>
        /// Field for the X position of the player
        /// </summary>
        internal float _xPosition;

        /// <summary>
        /// Field for the Y position of the player
        /// </summary>
        internal float _yPosition;

        /// <summary>
        /// Field for the Z position of the player
        /// </summary>
        internal float _zPosition;

        /// <summary>
        /// Field for the first rotation of the player
        /// </summary>
        internal float _rotation1;

        /// <summary>
        /// Field for the second rotation of the player
        /// </summary>
        internal float _rotation2;

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
        /// Gets or sets the current health of the player
        /// </summary>
        public short CurrentHealth { get => _currentHealth; set => _currentHealth = value; }

        /// <summary>
        /// Gets or sets the max health of the player
        /// </summary>
        public short MaxHealth { get => _maxHealth; set => _maxHealth = value; }

        /// <summary>
        /// Gets or sets the X position of the player
        /// </summary>
        public float XPosition { get => _xPosition; set => _xPosition = value; }

        /// <summary>
        /// Gets or sets the Y position of the player
        /// </summary>
        public float YPosition { get => _yPosition; set => _yPosition = value; }

        /// <summary>
        /// Gets or sets the Z position of the player
        /// </summary>
        public float ZPosition { get => _zPosition; set => _zPosition = value; }

        /// <summary>
        /// Gets or sets the first rotation of the player
        /// </summary>
        public float Rotation1 { get => _rotation1; set => _rotation1 = value; }

        /// <summary>
        /// Gets or sets the second rotation of the player
        /// </summary>
        public float Rotation2 { get => _rotation2; set => _rotation2 = value; }

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
    }
}
