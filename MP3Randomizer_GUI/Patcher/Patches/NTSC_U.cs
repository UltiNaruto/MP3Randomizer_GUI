using System;

namespace MP3Randomizer_GUI.Patcher.Patches
{
    class NTSC_U : _Corruption
    {
        public override void SetSaveFilename(String filename)
        {
            new DolPatch<String>(Main_Dol_Path, 0x8057EF90, filename).Apply();
        }
    }
}
