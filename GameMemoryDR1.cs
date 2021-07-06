using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Reflection;

namespace SRTPluginProviderDR1
{
    public class GameMemoryDR1 : IGameMemoryDR1
    {
        public string VersionInfo => FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion;

        public int GameMenu { get => _gamemenu; set => _gamemenu = value; }
        internal int _gamemenu;

        public bool IsGamePaused { get => _isGamePaused; set => _isGamePaused = value; }
        internal bool _isGamePaused;

        public uint GameTime { get => _gameTime; set => _gameTime = value; }
        internal uint _gameTime;

        public float PlayerXPosition { get => _playerXPosition; set => _playerXPosition = value; }
        internal float _playerXPosition;

        public float PlayerYPosition { get => _playerYPosition; set => _playerYPosition = value; }
        internal float _playerYPosition;

        public float PlayerZPosition { get => _playerZPosition; set => _playerZPosition = value; }
        internal float _playerZPosition;

        public float PlayerRotation1 { get => _playerRotation1; set => _playerRotation1 = value; }
        internal float _playerRotation1;

        public float PlayerRotation2 { get => _playerRotation2; set => _playerRotation2 = value; }
        internal float _playerRotation2;

        public long WalkedDistance { get => _walkedDistance; set => _walkedDistance = value; }
        internal long _walkedDistance;

        public short Attack { get => _attack; set => _attack = value; }
        internal short _attack;

        public byte Speed { get => _speed; set => _speed = value; }
        internal byte _speed;

        public short Life { get => _life; set => _life = value; }
        internal short _life;

        public byte ItemStock { get => _itemStock; set => _itemStock = value; }
        internal byte _itemStock;

        public byte ThrowDistance { get => _throwDistance; set => _throwDistance = value; }
        internal byte _throwDistance;

        public float WeaponDurability { get => _weaponDurability; set => _weaponDurability = value; }
        internal float _weaponDurability;

        public float WeaponMaxDurability { get => _weaponMaxDurability; set => _weaponMaxDurability = value; }
        internal float _weaponMaxDurability;

        public short WeaponMaxAmmo { get => _weaponMaxAmmo; set => _weaponMaxAmmo = value; }
        internal short _weaponMaxAmmo;

        public int BossCurrentHealth { get => _bossCurrentHealth; set => _bossCurrentHealth = value; }
        internal int _bossCurrentHealth;

        public int BossMaxHealth { get => _bossMaxHealth; set => _bossMaxHealth = value; }

        internal int _bossMaxHealth;


    }
}
