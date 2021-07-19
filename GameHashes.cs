using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;

namespace SRTPluginProviderDR1
{
    /// <summary>
    /// SHA256 hashes for the Dead Rising game executable.
    /// 
    /// Dead Rising (DR): https://steamdb.info/app/427190/
    /// </summary>
    public static class GameHashes
    {
        /// <summary>
        /// Field for the hash of the 01-28-2021 update of patch 3
        /// </summary>
        private static readonly byte[] dr_20210128_3 = new byte[32] { 0x36, 0xaf, 0x81, 0x60, 0x2f, 0x4b, 0x8b, 0xda, 0xee, 0xf5, 0xa8, 0xac, 0xea, 0x6e, 0x4f, 0xe6, 0xc9, 0x68, 0x88, 0xaf, 0x06, 0x72, 0x99, 0x33, 0x5d, 0x0a, 0xd5, 0xe3, 0xcd, 0x60, 0x36, 0x6f };
        
        /// <summary>
        /// Detect the version of the game
        /// </summary>
        /// <param name="filePath">File path to the game exe file</param>
        /// <returns>Game version</returns>
        public static GameVersion DetectVersion(string filePath)
        {
            byte[] checksum;
            using (SHA256 hashFunc = SHA256.Create())
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite | FileShare.Delete))
                checksum = hashFunc.ComputeHash(fs);

            if (checksum.SequenceEqual(dr_20210128_3))
            {
                Console.WriteLine("Dead Rising (2016) Steam v1.0 Patch 3 Detected.");
                return GameVersion.DR_20210128_3;
            }

            Console.WriteLine("Unknown Version. If you have installed any third party mods, please uninstall and try again.");
            return GameVersion.Unknown;
        }
    }
}
