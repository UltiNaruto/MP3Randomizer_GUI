using System;

namespace MP3Randomizer_GUI.Patcher
{
    class Patcher
    {
        static Patches._Corruption patches = null;

        static UInt32 MakeJMP(UInt32 src, UInt32 dst)
        {
            return (UInt32)(0x48000000 + (dst - src));
        }

        public static void Init(char Game_Region)
        {
            if (Game_Region == 'E')
                patches = new Patches.NTSC_U();
        }

        public static void SetSaveFilename(String filename)
        {
            if (patches == null)
                return;

            if (!filename.EndsWith(".bin"))
                return;
            if (filename.Length > 8)
                return;
            while (filename.Length < 8)
                filename += "\0";

            patches.SetSaveFilename(filename);
        }
    }
}
