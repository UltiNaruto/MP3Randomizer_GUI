using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace MP3Randomizer_GUI
{
    class PatcherManager
    {
        private const string MP3RANDOMIZER_PATH = @".\MP3Randomizer.exe";
        public static bool Patch(Dictionary<String, String> settings)
        {
            var args = default(String);
            var info = default(ProcessStartInfo);
            var proc = default(Process);
            try
            {
                foreach(KeyValuePair<String, String> setting in settings)
                {
                    if(setting.Value != "false")
                    {
                        if (args != String.Empty)
                            args += " ";
                        if (setting.Value == "true")
                            args += "--" + setting.Key;
                        else
                            args += "--" + setting.Key + " \"" + setting.Value+"\"";
                    }
                }
                info = new ProcessStartInfo(MP3RANDOMIZER_PATH);
                info.WorkingDirectory = Directory.GetCurrentDirectory();
                info.Arguments = args;
                info.CreateNoWindow = true;
                info.UseShellExecute = false;
                proc = Process.Start(info);
                proc.WaitForExit();
                return proc.ExitCode == 0;
            }
            catch
            {
                return false;
            }
        }
    }
}