using System;
using System.Diagnostics;
using System.ComponentModel;

namespace SteamLauncher.Modules
{
    internal class Launcher
    {

        public static void Launch()
        {
            Process process = new Process();
            // TODO: Do not use hardcoded directory
            process.StartInfo.FileName = "steam_og.exe";
            process.Start();
        }
    }
}
