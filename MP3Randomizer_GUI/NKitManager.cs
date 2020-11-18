using Nanook.NKit;
using System.IO;
using System.IO.Compression;
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
                    ndisc.ExtractFiles(ext_f => true,
                    (f, ext_f) =>
                    {
                        var path = @".\tmp\nkit\DATA\" + (ext_f.PartitionId == null ? @"sys" : @"files");
                        if (ext_f.Path != "")
                            path += @"\" + ext_f.Path;
                        if (!Directory.Exists(path))
                            Directory.CreateDirectory(path);
                        using (var stream = File.OpenWrite(path + @"\" + ext_f.Name))
                            f.Copy(stream, ext_f.Length);
                    });
                }
            }
            catch
            {
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
                    Directory.Move(@".\tmp\nkit", @".\tmp\wii");
                }
                catch
                {
                    Directory.Delete(@".\tmp\nkit", true);
                    result = false;
                }
            }
            return result;
        }
    }
}
