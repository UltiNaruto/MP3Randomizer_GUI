using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace MP3Randomizer_GUI
{
    class LogManager
    {
        static Int64 instance_id = -1;
        static String path = String.Empty;

        static async Task WriteToFileAsync(String filepath, String text)
        {
            byte[] encodedText = Encoding.Unicode.GetBytes(text + "\r\n");

            using (var stream = new FileStream(filepath, FileMode.Append, FileAccess.Write, FileShare.None, bufferSize: 4096, useAsync: true))
            {
                await stream.WriteAsync(encodedText, 0, encodedText.Length);
            }
        }

        public static void Log(String filename, String text)
        {
            DateTime InitTime = DateTime.Now;
            String date = String.Format("{0:00}{1:00}{2:0000}", InitTime.Day, InitTime.Month, InitTime.Year);

            if (text == null)
                return;

            if (text.Trim() == String.Empty)
                return;

            if (!Directory.Exists(@".\logs\" + date))
            {
                instance_id = -1;
                path = String.Empty;
            }

            if (instance_id < 0)
            {
                path = @".\logs\" + date + @"\" + (++instance_id);
                while (Directory.Exists(path))
                    path = @".\logs\" + date + @"\" + (++instance_id);
            }

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            WriteToFileAsync(path + @"\" + filename, text);
        }
    }
}
