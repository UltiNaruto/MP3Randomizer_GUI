using Nanook.NKit;
using System;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text.RegularExpressions;

namespace MP3Randomizer_GUI
{
    class NKitManager
    {
        static bool IsValidFilename(string value)
        {
            return Regex.IsMatch(value, @"^[\w\-. ]+$");
        }

        public static bool ExtractISO(string filename)
        {
            bool result = true;
            if (!Directory.Exists(@".\tmp\nkit"))
                Directory.CreateDirectory(@".\tmp\nkit");
            try
            {
                using(var ndisc = new NDisc(null, File.OpenRead(filename)))
                {
                    if (ndisc == null)
                        throw new System.Exception();
                    if (ndisc.ExtractBasicInfo().Id.Substring(0,6) != "RM3E01")
                        throw new System.Exception();
                    LogManager.Log("nkit.log", "Found Metroid Prime 3 - Corruption NTSC iso");
                    LogManager.Log("nkit.log", "Extracting files...");
                    ndisc.ExtractFiles(ext_f => true,
                    (f, ext_f) =>
                    {
                        var path = @".\tmp\nkit\DATA\" + (ext_f.PartitionId == null ? @"sys" : @"files");
                        if (ext_f.Path != "")
                            path += @"\" + ext_f.Path;
                        if (!Directory.Exists(path))
                            Directory.CreateDirectory(path);
                        LogManager.Log("nkit.log", "["+ (ext_f.PartitionId == null ? @"sys" : @"files") + "] Extracting "+ext_f.Path+"...");
                        using (var stream = File.OpenWrite(path + @"\" + ext_f.Name))
                            f.Copy(stream, ext_f.Length);
                    });
                    LogManager.Log("nkit.log", "Extracted "+Directory.EnumerateFiles(@".\tmp\nkit", "*.*", SearchOption.AllDirectories).ToArray().Length+ " files!");
                }
            }
            catch(Exception ex)
            {
                LogManager.Log("nkit_err.log", ex.Message + "\r\n" + ex.StackTrace);
                result = false;
            }
            if (Directory.Exists(@".\Dats"))
                Directory.Delete(@".\Dats", true);
            if (Directory.Exists(@".\Processed"))
                Directory.Delete(@".\Processed", true);
            if (Directory.Exists(@".\Recovery"))
                Directory.Delete(@".\Recovery", true);
            if (!result)
                Directory.Delete(@".\tmp\nkit", true);
            else
            {
                try
                {
                    LogManager.Log("nkit.log", "Extracting disc infos...");
                    File.WriteAllBytes(@".\tmp\nkit\nkit_files.zip", Properties.Resources.RM3E01_nkit);
                    ZipFile.ExtractToDirectory(@".\tmp\nkit\nkit_files.zip", @".\tmp\nkit\DATA");
                    File.Move(@".\tmp\nkit\DATA\files\main.dol", @".\tmp\nkit\DATA\sys\main.dol");
                    File.Delete(@".\tmp\nkit\nkit_files.zip");
                    File.Delete(@".\tmp\nkit\DATA\files\boot.bin");
                    File.Delete(@".\tmp\nkit\DATA\files\appldr.bin");
                    File.Delete(@".\tmp\nkit\DATA\files\bi2.bin");
                    File.Delete(@".\tmp\nkit\DATA\files\fst.bin");
                    File.Delete(@".\tmp\nkit\DATA\sys\R3MEhdr.bin");
                    File.Delete(@".\tmp\nkit\DATA\sys\hdr.bin");
                    LogManager.Log("nkit.log", "Disc infos extracted!");
                    LogManager.Log("nkit.log", @"Moving .\tmp\nkit to .\tmp\wii");
                    Directory.Move(@".\tmp\nkit", @".\tmp\wii");
                    LogManager.Log("nkit.log", @"Done!");
                }
                catch (Exception ex)
                {
                    Directory.Delete(@".\tmp\nkit", true);
                    LogManager.Log("nkit_err.log", ex.Message + "\r\n" + ex.StackTrace);
                    result = false;
                }
            }
            return result;
        }
    }
}
