using System;
using System.IO;
using System.Text.RegularExpressions;

namespace MP3Randomizer_GUI.Config
{
    class AppSettings
    {
        public String inputPath;
        public String outputPath;
        public String outputType;

        public AppSettings()
        {
            var line = default(String);
            var kvp = default(MatchCollection);
            try
            {
                String CurDir = Directory.GetCurrentDirectory();
                using (var sR = new StreamReader(File.OpenRead(CurDir + @"\settings.json")))
                {
                    while (!sR.EndOfStream)
                    {
                        line = sR.ReadLine().Trim().Trim(' ');
                        kvp = new Regex("\"(.*?)\"").Matches(line);
                        if (kvp.Count == 2)
                        {
                            if (kvp[0].Groups[1].Value == "inputPath")
                                this.inputPath = kvp[1].Groups[1].Value;
                            if (kvp[0].Groups[1].Value == "outputPath")
                                this.outputPath = kvp[1].Groups[1].Value;
                            if (kvp[0].Groups[1].Value == "outputType")
                                this.outputType = kvp[1].Groups[1].Value;
                        }
                    }
                }
            }
            catch
            {
                this.inputPath = "";
                this.outputPath = "";
                this.outputType = ".ciso";
                this.SaveToJson();
            }
        }

        public void SaveToJson()
        {
            String CurDir = Directory.GetCurrentDirectory();
            if (File.Exists(CurDir + @"\settings.json"))
                File.Delete(CurDir + @"\settings.json");
            using (var sW = new StreamWriter(File.OpenWrite(CurDir + @"\settings.json")))
            {
                sW.WriteLine("{");
                sW.WriteLine("\t\"inputPath\": \"" + this.inputPath + "\",");
                sW.WriteLine("\t\"outputPath\": \"" + this.outputPath + "\",");
                sW.WriteLine("\t\"outputType\": \"" + this.outputType + "\"");
                sW.WriteLine("}");
            }
        }
    }
}
