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
            process.StartInfo.FileName = "C:\\Program Files (x86)\\Steam\\steam.exe";
            process.Start();
        }
    }
}
