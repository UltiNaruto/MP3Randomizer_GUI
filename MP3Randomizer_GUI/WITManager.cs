﻿using System;
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
                        Directory.CreateDirectory(@".\tmp");
                    client.DownloadFile(WIT_URL, @".\tmp\wit.zip");
                    ZipFile.ExtractToDirectory(@".\tmp\wit.zip", @".");
                    Directory.Move(@".\wit-v3.03a-r8245-cygwin", @".\wit");
                    File.Delete(@".\tmp\wit.zip");
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public static bool CreateISO(string filename, String GameCode)
        {
            try
            {
                ProcessStartInfo info = new ProcessStartInfo(WIT_PATH, "COPY .\\tmp\\wii -d \"" + filename + "\"  --id " + GameCode);
                info.WorkingDirectory = Directory.GetCurrentDirectory();
                info.CreateNoWindow = true;
                info.UseShellExecute = false;
                Process proc = Process.Start(info);
                proc.WaitForExit();
                return proc.ExitCode == 0;
            }
            catch
            {
                return false;
            }
        }

        public static bool CreateCISO(string filename, String GameCode)
        {
            try
            {
                ProcessStartInfo info = new ProcessStartInfo(WIT_PATH, "COPY .\\tmp\\wii -d \"" + filename + "\" -C  --id " + GameCode);
                info.WorkingDirectory = Directory.GetCurrentDirectory();
                info.CreateNoWindow = true;
                info.UseShellExecute = false;
                Process proc = Process.Start(info);
                proc.WaitForExit();
                return proc.ExitCode == 0;
            }
            catch
            {
                return false;
            }
        }

        public static bool CreateWBFS(string filename, String GameCode)
        {
            try
            {
                ProcessStartInfo info = new ProcessStartInfo(WIT_PATH, "COPY \".\\tmp\\wii\" -d \"" + filename + "\" -B --id \"" + GameCode + "\"");
                info.WorkingDirectory = Directory.GetCurrentDirectory();
                info.CreateNoWindow = true;
                info.UseShellExecute = false;
                Process proc = Process.Start(info);
                proc.WaitForExit();
                return proc.ExitCode == 0;
            }
            catch
            {
                return false;
            }
        }

        internal static bool ExtractISO(string filename)
        {
            try
            {
                ProcessStartInfo info = new ProcessStartInfo(WIT_PATH, "EXTRACT \"" + filename + "\" -d \".\\tmp\\wii\"");
                info.WorkingDirectory = Directory.GetCurrentDirectory();
                info.CreateNoWindow = true;
                info.UseShellExecute = false;
                Process proc = Process.Start(info);
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