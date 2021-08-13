using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SRTPluginProviderDR1.Structs.GameModel
{
    public class DevelopperModelInfo
    {
        #region Properties

        public int GameMenu { get; internal set; }

        public int IsMenuPaused { get; internal set; }

        public bool IsLoading { get; internal set; }

        public uint InGameTimeValue { get; internal set; }

        public string InGameTime
        {
            get
            {
                uint day = this.InGameTimeValue / (108000) / 24,
                hours = this.InGameTimeValue / (108000) % 24,
                minutes = this.InGameTimeValue / (108000 / 60) % 60,
                seconds = this.InGameTimeValue / (108000 / 60 / 60) % 60;

                string suffix = "AM";
                if (hours >= 12)
                {
                    suffix = "PM";
                    hours %= 12;
                }
                if (hours == 0) { hours = 12; }

                return string.Format("Day {0} - {1}:{2}:{3} {4}", (int)day, hours.ToString("D2"), minutes.ToString("D2"), seconds.ToString("D2"), suffix);
            }
        }

        public int CampaignProgressValue { get; internal set; }

        public string CampaignProgress 
        {
            get
            {
                switch (this.CampaignProgressValue)
                {
                    case < 80:
                        return "Prologue";
                    case < 110:
                        return "Case 1.1";
                    case < 130:
                        return "Case 1.2";
                    case < 140:
                        return "Case 1.3";
                    case < 150:
                        return "Case 1.4";
                    case < 205:
                        return "Case 2.1";
                    case < 215:
                        return "Case 2.2";
                    case < 220:
                        return "Case 2.3";
                    case < 230:
                        return "Case 3.1";
                    case < 250:
                        return "Case 4.1";
                    case < 280:
                        return "Case 4.2";
                    case < 290:
                        return "Case 5.1";
                    case < 300:
                        return "Case 5.2";
                    case < 320:
                        return "Case 6.1";
                    case < 340:
                        return "Case 7.1";
                    case < 350:
                        return "Case 7.2";
                    case < 360:
                        return "Case 8.1";
                    case < 370:
                        return "Case 8.2";
                    case < 390:
                        return "Case 8.3";
                    case < 400:
                        return "Case 8.4";
                    case < 500:
                        return "THE FACTS";
                    case < 650:
                        return "Overtime 1";
                    case < 999:
                        return "Overtime 2";
                    default:
                        return "Truth vanished!!";
                }
            }
        }

        public int RoomId { get; internal set; }

        public int CutsceneId { get; internal set; }

        public Vector3 PlayerPosition { get; internal set; }

        public Vector2 PlayerRotation { get; internal set; }

        public short PlayerHealth { get; internal set; }

        public int PlayerStatusPPCounter { get; internal set; }

        public short PlayerStatusLevel { get; internal set; }

        public short PlayerStatusMaxHealth { get; internal set; }

        public short PlayerStatusAttack { get; internal set; }

        public byte PlayerStatusThrowDistance { get; internal set; }

        public byte PlayerStatusItemStock { get; internal set; }

        public byte PlayerStatusSpeed { get; internal set; }

        public Vector3 CameraPosition { get; internal set; }

        public float WeaponDurability { get; internal set; }

        public float WeaponMaxDurability { get; internal set; }

        public float WeaponAmmo { get; internal set; }

        public float WeaponMaxAmmo { get; internal set; }

        public int BossHealth { get; internal set; }

        public int BossMaxHealth { get; internal set; }

        public int TunnelCarHealth { get; internal set; }

        public int TunnelCarMaxHealth { get; internal set; }

        #endregion Properties
    }
}
