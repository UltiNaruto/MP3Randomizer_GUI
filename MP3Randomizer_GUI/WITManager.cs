using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;

namespace MP3Randomizer_GUI
{
    class WITManager
    {
        private const string WIT_PATH = @".\wit\bin\wit.exe";
        private const string WIT_URL = "https://wit.wiimm.de/download/wit-v3.03a-r8245-cygwin.zip";

        public static bool Installed()
        {
            return File.Exists(WIT_PATH);
        }

        public static bool Init()
        {
            try
            {
                if (Installed())
                    return true;
                using (var client = new WebClientPlus())
                {
                    if (!Directory.Exists(@".\tmp"))
                    {
                        LogManager.Log("wit.log", @".\tmp doesn't exist it will be created");
                        Directory.CreateDirectory(@".\tmp");
                    }
                    LogManager.Log("wit.log", "Downloading WIT ...");
                    client.DownloadFile(WIT_URL, @".\tmp\wit.zip");
                    LogManager.Log("wit.log", "Extracting WIT ...");
                    ZipFile.ExtractToDirectory(@".\tmp\wit.zip", @".");
                    LogManager.Log("wit.log", "Renaming folder to wit ...");
                    Directory.Move(@".\wit-v3.03a-r8245-cygwin", @".\wit");
                    LogManager.Log("wit.log", "Cleaning ...");
                    File.Delete(@".\tmp\wit.zip");
                    LogManager.Log("wit.log", "Done!");
                    return true;
                }
            }
            catch (Exception ex)
            {
                LogManager.Log("wit_err.log", ex.Message + "\r\n" + ex.StackTrace);
                return false;
            }
        }

        public static bool CreateISO(string filename, String GameCode)
        {
            try
            {
                using (var proc = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = WIT_PATH,
                        Arguments = "COPY \".\\tmp\\wii\" -d \"" + filename + "\" --id \"" + GameCode + "\" --auto-split --overwrite",
                        WorkingDirectory = Directory.GetCurrentDirectory(),
                        CreateNoWindow = true,
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true
                    }
                })
                {
                    proc.OutputDataReceived += (sender, args) => LogManager.Log("wit.log", args.Data);
                    proc.ErrorDataReceived += (sender, args) => LogManager.Log("wit_err.log", args.Data);
                    proc.Start();
                    proc.BeginOutputReadLine();
                    proc.BeginErrorReadLine();
                    proc.WaitForExit();
                    return proc.ExitCode == 0;
                }
            }
            catch (Exception ex)
            {
                LogManager.Log("wit_err.log", ex.Message + "\r\n" + ex.StackTrace);
                return false;
            }
        }

        public static bool CreateCISO(string filename, String GameCode)
        {
            try
            {
                using (var proc = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = WIT_PATH,
                        Arguments = "COPY \".\\tmp\\wii\" -d \"" + filename + "\" -C --id \"" + GameCode + "\" -z --trunc --auto-split --overwrite",
                        WorkingDirectory = Directory.GetCurrentDirectory(),
                        CreateNoWindow = true,
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true
                    }
                })
                {
                    proc.OutputDataReceived += (sender, args) => LogManager.Log("wit.log", args.Data);
                    proc.ErrorDataReceived += (sender, args) => LogManager.Log("wit_err.log", args.Data);
                    proc.Start();
                    proc.BeginOutputReadLine();
                    proc.BeginErrorReadLine();
                    proc.WaitForExit();
                    return proc.ExitCode == 0;
                }
            }
            catch (Exception ex)
            {
                LogManager.Log("wit_err.log", ex.Message + "\r\n" + ex.StackTrace);
                return false;
            }
        }

        public static bool CreateWBFS(string filename, String GameCode)
        {
            try
            {
                using (var proc = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = WIT_PATH,
                        Arguments = "COPY \".\\tmp\\wii\" -d \"" + filename + "\" -B --id \"" + GameCode + "\" -z --trunc --auto-split --overwrite",
                        WorkingDirectory = Directory.GetCurrentDirectory(),
                        CreateNoWindow = true,
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true
                    }
                })
                {
                    proc.OutputDataReceived += (sender, args) => LogManager.Log("wit.log", args.Data);
                    proc.ErrorDataReceived += (sender, args) => LogManager.Log("wit_err.log", args.Data);
                    proc.Start();
                    proc.BeginOutputReadLine();
                    proc.BeginErrorReadLine();
                    proc.WaitForExit();
                    return proc.ExitCode == 0;
                }
            }
            catch (Exception ex)
            {
                LogManager.Log("wit_err.log", ex.Message + "\r\n" + ex.StackTrace);
                return false;
            }
        }

        internal static bool ExtractISO(string filename)
        {
            try
            {
                using (var proc = new Process {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = WIT_PATH,
                        Arguments = "EXTRACT \"" + filename + "\" -d \".\\tmp\\wii\"",
                        WorkingDirectory = Directory.GetCurrentDirectory(),
                        CreateNoWindow = true,
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true
                    }
                })
                {
                    proc.OutputDataReceived += (sender, args) => LogManager.Log("wit.log", args.Data);
                    proc.ErrorDataReceived += (sender, args) => LogManager.Log("wit_err.log", args.Data);
                    proc.Start();
                    proc.BeginOutputReadLine();
                    proc.BeginErrorReadLine();
                    proc.WaitForExit();
                    return proc.ExitCode == 0;
                }
            }
            catch (Exception ex)
            {
                LogManager.Log("wit_err.log", ex.Message + "\r\n" + ex.StackTrace);
                return false;
            }
        }
    }
}
