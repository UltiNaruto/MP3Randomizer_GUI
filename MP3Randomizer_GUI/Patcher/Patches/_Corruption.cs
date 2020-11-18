using System;

namespace MP3Randomizer_GUI.Patcher.Patches
{
    abstract class _Corruption
    {
        internal static String Main_Dol_Path = ".\\tmp\\wii\\DATA\\sys\\main.dol";

        public abstract void SetSaveFilename(String filename);
    }
}
