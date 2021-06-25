using SRTPluginBase;
using System;

namespace SRTPluginProviderDR1
{
    internal class PluginInfo : IPluginInfo
    {
        public string Name => "Game Memory Provider (Dead Rising (2016))";

        public string Description => "A game memory provider plugin for Dead Rising (2016).";

        public string Author => "Squirrelies & VideoGameRoulette";

        public Uri MoreInfoURL => new Uri("https://github.com/talesofpixelia/SRTPluginProviderDR1");

        public int VersionMajor => assemblyVersion.Major;

        public int VersionMinor => assemblyVersion.Minor;

        public int VersionBuild => assemblyVersion.Build;

        public int VersionRevision => assemblyVersion.Revision;

        private Version assemblyVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
    }
}
