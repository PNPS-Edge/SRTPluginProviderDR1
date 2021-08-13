using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRTPluginProviderDR1.Structs.GameModel
{
    public struct SpeedrunnerModelInfo
    {
        #region Properties

        public byte PlayerStatusItemStock { get; internal set; }

        public float WeaponDurability { get; internal set; }

        public float WeaponMaxDurability { get; internal set; }

        public bool IsWeaponAlive => WeaponDurability != 0 && WeaponDurability > 0 && WeaponDurability <= WeaponMaxDurability;

        public float WeaponPercentage => IsWeaponAlive ? (float)WeaponDurability / (float)WeaponMaxDurability : 0f;

        public ItemStatus WeaponHealthState
        {
            get =>
                !this.IsWeaponAlive ? ItemStatus.Dead :
                this.WeaponPercentage >= 0.75 ? ItemStatus.Fine :
                this.WeaponPercentage >= 0.50 ? ItemStatus.FineToo :
                this.WeaponPercentage >= 0.25 ? ItemStatus.Caution : ItemStatus.Danger;
        }

        public string CurrentWeapongHealthState => WeaponHealthState.ToString();

        public int TunnelCarHealth { get; internal set; }

        public int TunnelCarMaxHealth { get; internal set; }

        public bool IsTunnelCarAlive => TunnelCarHealth != 0 && TunnelCarHealth > 0 && TunnelCarHealth <= TunnelCarMaxHealth;

        public float TunnelCarPercentage => IsTunnelCarAlive ? (float)TunnelCarHealth / (float)TunnelCarMaxHealth : 0f;

        public ItemStatus TunnelCarHealthState
        {
            get =>
                !this.IsTunnelCarAlive ? ItemStatus.Dead :
                this.TunnelCarPercentage >= 0.75 ? ItemStatus.Fine :
                this.TunnelCarPercentage >= 0.50 ? ItemStatus.FineToo :
                this.TunnelCarPercentage >= 0.25 ? ItemStatus.Caution : ItemStatus.Danger;
        }

        public string CurrentTunnelCarHealthState => TunnelCarHealthState.ToString();

        public enum ItemStatus
        {
            Dead,
            Fine,
            FineToo,
            Caution,
            Danger,
        }


        public float Speed
        {
            get
            {
                var distX = _previousPosition.X - gameMemory.Player.Position.X;
                var distY = _previousPosition.Y - gameMemory.Player.Position.Y;
                var distZ = _previousPosition.Z - gameMemory.Player.Position.Z;

                var speedX = distX / (gameMemory.Campaign.GameTime / 1000);
                var speedY = distY / (gameMemory.Campaign.GameTime / 1000);
                var speedZ = distZ / (gameMemory.Campaign.GameTime / 1000);

                var speed = (Math.Sqrt(Math.Pow(speedX, 2) + Math.Pow(speedY, 2) + Math.Pow(speedZ, 2)) * 1000);

                _previousPosition.X = gameMemory.Player.Position.X;
                _previousPosition.Y = gameMemory.Player.Position.Y;
                _previousPosition.Z = gameMemory.Player.Position.Z;

                _previousSpeedValues.Add(speed);

                if (speed > (_previousSpeedValues[_previousSpeedValues.Count - 1] * 3))
                {
                    _previousSpeedValues.RemoveAt(_previousSpeedValues.Count - 1);
                }

                if (_previousSpeedValues.Count > config.SpeedAverageFactor)
                {
                    _previousSpeedValues.RemoveAt(0);
                }

                if (speed == 0)
                {
                    for (int i = 0; i < _previousSpeedValues.Count; i++)
                    {
                        _previousSpeedValues[i] = 0;
                    }
                }
            }
        }
        #endregion Properties
    }
}
