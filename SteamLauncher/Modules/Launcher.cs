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
            // TODO: Find steam installation directory instead of assuming this is being run from that location
            process.StartInfo.FileName = Directory.GetCurrentDirectory() + "\\steam.exe";
            Console.WriteLine("Starting: " + process.StartInfo.FileName);
            process.Start();
        }
    }
}
