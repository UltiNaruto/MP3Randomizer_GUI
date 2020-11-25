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
            var args = String.Empty;
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
                            args += "--" + setting.Key + " " + setting.Value;
                    }
                }

                LogManager.Log("MP3Randomizer.log", "Command line : " + MP3RANDOMIZER_PATH + " " + args);

                using (var proc = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = MP3RANDOMIZER_PATH,
                        Arguments = args,
                        WorkingDirectory = Directory.GetCurrentDirectory(),
                        CreateNoWindow = true,
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                    }
                })
                {
                    proc.OutputDataReceived += (sender, _args) => LogManager.Log("MP3Randomizer.log", _args.Data);
                    proc.ErrorDataReceived += (sender, _args) => LogManager.Log("MP3Randomizer_err.log", _args.Data);
                    proc.Start();
                    proc.BeginOutputReadLine();
                    proc.BeginErrorReadLine();
                    proc.WaitForExit();
                    return proc.ExitCode == 0;
                }
            }
            catch (Exception ex)
            {
                LogManager.Log("MP3Randomizer_err.log", ex.Message + "\r\n" + ex.StackTrace);
                return false;
            }
        }
    }
}