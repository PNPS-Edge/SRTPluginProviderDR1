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

        public int PlayerCurrentHealth { get => _playerCurrentHealth; set => _playerCurrentHealth = value; }
        internal int _playerCurrentHealth;

        public int PlayerMaxHealth { get => _playerMaxHealth; set => _playerMaxHealth = value; }
        internal int _playerMaxHealth;
    }
}
