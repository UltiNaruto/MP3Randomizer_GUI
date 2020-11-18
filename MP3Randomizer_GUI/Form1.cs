using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace MP3Randomizer_GUI
{
    public partial class Form1 : DarkUI.Forms.DarkForm
    {
        #region WINAPI Constants
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        #endregion
        #region C Imports
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion
        readonly String[] FILES_TO_BACKUP = {
            "FrontEnd.pak",
            "Logbook.pak",
            "Metroid1.pak",
            "Metroid3.pak",
            "Metroid4.pak",
            "Metroid5.pak",
            "Metroid6.pak",
            "Metroid7.pak",
            "Metroid8.pak",
            "MiscData.pak",
            "UniverseArea.pak",
            "Worlds.pak",
            "Standard.ntwk"
        };
        readonly Random rand;
        String OutputFileExt = ".iso";
        Config.AppSettings appSettings = new Config.AppSettings();
        public Form1()
        {
            rand = new Random((int)((DateTime.Now.Ticks / TimeSpan.TicksPerSecond)));
            Directory.SetCurrentDirectory(Path.GetDirectoryName(Application.ExecutablePath));
            InitializeComponent();
        }

        String RandomizeDeveloperCode()
        {
            List<String> UsedDeveloperCodes = new List<String>();
            if(File.Exists(@".\udc.bin"))
                UsedDeveloperCodes.AddRange(File.ReadAllLines(@".\udc.bin"));
            const String AllowedCharacters = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int len = AllowedCharacters.Length;
            String DeveloperCode = "01";
            while (DeveloperCode == "01" || UsedDeveloperCodes.Contains(DeveloperCode))
                DeveloperCode = "" + AllowedCharacters[rand.Next(len)] + AllowedCharacters[rand.Next(len)];
            UsedDeveloperCodes.Add(DeveloperCode);
            File.WriteAllLines("udc.bin", UsedDeveloperCodes.ToArray());
            return DeveloperCode;
        }

        String GetGameID(string fileName)
        {
            if (!File.Exists(fileName))
                return "";
            using (var bR = new BinaryReader(File.OpenRead(fileName)))
            {
                return Encoding.ASCII.GetString(bR.ReadBytes(6));
            }
        }

        void SetProgressStatus(int cur, int max)
        {
            if (cur != max)
            {
                this.toolStripProgressBar1.Visible = true;
                this.toolStripProgressBar1.Value = (cur * 100) / (max - 1);
            }
            else
            {
                this.toolStripProgressBar1.Visible = false;
                this.toolStripProgressBar1.Value = 0;
            }
            this.toolStripProgressBar1.Invalidate();
            this.darkStatusStrip1.Update();
        }

        void SetStatus(String status, int cur = 0, int len = 0)
        {
            this.toolStripStatusLabel1.Text = "Status : " + status;
            if (len > 1)
                this.toolStripStatusLabel1.Text += " (" + (cur + 1) + " / " + len + ")";
            this.toolStripStatusLabel1.Invalidate();
            this.darkStatusStrip1.Update();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_inputISO_Click(object sender, EventArgs e)
        {
            using(var ofd = new OpenFileDialog())
            {
                ofd.Title = "Select a Metroid Prime 3 Corruption NTSC ISO";
                ofd.FileName = "";
                ofd.Filter = "ISO File|*.iso|Compressed ISO|*.ciso|NKit ISO|*.nkit.iso";
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    if(GetGameID(Path.GetFullPath(ofd.FileName)) != "RM3E01")
                    {
                        MessageBox.Show("Please choose a Metroid Prime 3 Corruption NTSC ISO instead!\r\nOnly that version is known to work for now.");
                        return;
                    }
                    txtBox_inputISO.Text = Path.GetFullPath(ofd.FileName);
                    appSettings.inputPath = txtBox_inputISO.Text;
                    appSettings.SaveToJson();
                }
            }
        }

        private void txtBox_inputISO_keyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter)
                return;

            // Normalize path
            txtBox_inputISO.Text = Path.GetFullPath(txtBox_inputISO.Text);

            if (GetGameID(Path.GetFullPath(txtBox_inputISO.Text)) != "RM3E01")
            {
                MessageBox.Show("Please choose a Metroid Prime 3 Corruption NTSC ISO instead!\r\nOnly that version is known to work for now.");
                return;
            }
            appSettings.inputPath = txtBox_inputISO.Text;
            appSettings.SaveToJson();
        }

        private void btn_outputISO_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                fbd.SelectedPath = "";
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    txtBox_outputPath.Text = Path.GetFullPath(fbd.SelectedPath);
                    appSettings.outputPath = txtBox_outputPath.Text;
                    appSettings.SaveToJson();
                }
            }
        }

        private void txtBox_outputPath_keyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter)
                return;

            // Normalize path
            txtBox_outputPath.Text = Path.GetFullPath(txtBox_outputPath.Text);

            appSettings.outputPath = txtBox_outputPath.Text;
            appSettings.SaveToJson();
        }

        private void radioBtn_ISO_Type_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtn_ISO_Type.Checked)
            {
                radioBtn_CISO_Type.Checked = radioBtn_WBFS_Type.Checked = false;
                OutputFileExt = ".iso";
                appSettings.outputType = OutputFileExt;
                appSettings.SaveToJson();
            }
        }

        private void radioBtn_CISO_Type_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtn_CISO_Type.Checked)
            {
                radioBtn_ISO_Type.Checked = radioBtn_WBFS_Type.Checked = false;
                OutputFileExt = ".ciso";
                appSettings.outputType = OutputFileExt;
                appSettings.SaveToJson();
            }
        }

        private void radioBtn_WBFS_Type_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtn_WBFS_Type.Checked)
            {
                radioBtn_ISO_Type.Checked = radioBtn_CISO_Type.Checked = false;
                OutputFileExt = ".wbfs";
                appSettings.outputType = OutputFileExt;
                appSettings.SaveToJson();
            }
        }

        void switchMode(bool generating)
        {
            // Switch all radio buttons to ON/OFF
            this.radioBtn_ISO_Type.Enabled = this.radioBtn_CISO_Type.Enabled = this.radioBtn_WBFS_Type.Enabled = !generating;
            // Switch all buttons to ON/OFF (except exit)
            this.btn_generate.Enabled = this.btn_inputISO.Enabled = this.btn_outputISO.Enabled = !generating;
            // Switch all text boxes readonly or not
            this.txtBox_inputISO.ReadOnly = this.txtBox_outputPath.ReadOnly = this.txtBox_seedLayout.ReadOnly = generating;
            // Switch all check boxes to ON/OFF
            this.chkBox_fastShipFlying.Enabled = this.chkBox_hyperHints.Enabled = this.chkBox_randomDoorColors.Enabled = this.chkBox_randomWeldingColors.Enabled = !generating;
            // Switch all combo boxes to ON/OFF
            this.comboBox_startingItems.Enabled = this.comboBox_startingLocation.Enabled = !generating;
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            var GameID = default(String);
            var PatchedGameID = default(String);
            var preGenerationStepCount = default(int);
            var generateStepCount = default(int);

            generateStepCount = 3;
            GameID = GetGameID(this.txtBox_inputISO.Text);
            if (!Directory.Exists(@".\tmp\wii"))
            {
                switchMode(true);
                preGenerationStepCount = 3;
                if (GameID.Length != 6)
                {
                    MessageBox.Show("Invalid input iso supplied!");
                    switchMode(false);
                    return;
                }

                // Normalize the path
                this.txtBox_inputISO.Text = Path.GetFullPath(this.txtBox_inputISO.Text);

                SetStatus("Extracting ISO...");
                SetProgressStatus(0, preGenerationStepCount + generateStepCount);

                if (this.txtBox_inputISO.Text.ToLower().EndsWith(".nkit.iso"))
                {
                    if(!NKitManager.ExtractISO(this.txtBox_inputISO.Text))
                    {
                        MessageBox.Show("Failed extracting wii iso!");
                        SetStatus("Idle");
                        SetProgressStatus(preGenerationStepCount + generateStepCount, preGenerationStepCount + generateStepCount);
                        switchMode(false);
                        return;
                    }
                }
                else // .ciso or .iso
                {
                    if(!WITManager.ExtractISO(this.txtBox_inputISO.Text))
                    {
                        MessageBox.Show("Failed extracting wii iso!");
                        SetStatus("Idle");
                        SetProgressStatus(preGenerationStepCount + generateStepCount, preGenerationStepCount + generateStepCount);
                        switchMode(false);
                        return;
                    }
                }

                SetStatus("Backing up files...");
                SetProgressStatus(1, preGenerationStepCount + generateStepCount);

                Directory.CreateDirectory(@".\bak\files");
                foreach(var file in FILES_TO_BACKUP)
                    File.Copy(@".\tmp\wii\DATA\files\" + file, @".\bak\files\" + file, true);
                Directory.CreateDirectory(@".\bak\sys");
                File.Copy(@".\tmp\wii\DATA\sys\main.dol", @".\bak\sys\main.dol", true);

                SetStatus("Removing attract videos...");
                SetProgressStatus(2, preGenerationStepCount + generateStepCount);

                File.WriteAllText(@".\tmp\wii\DATA\files\Video\FrontEnd\attract01.thp", "");
                File.WriteAllText(@".\tmp\wii\DATA\files\Video\FrontEnd\attract02.thp", "");

                if(!Directory.Exists(@".\tmp\wii\UPDATE"))
                    Directory.Delete(@".\tmp\wii\UPDATE");
            }
            else
            {
                preGenerationStepCount = 1;

                SetStatus("Restoring backup...");
                SetProgressStatus(0, preGenerationStepCount + generateStepCount);

                foreach (var file in FILES_TO_BACKUP)
                    File.Copy(@".\bak\files\" + file, @".\tmp\wii\DATA\files\" + file, true);
                File.Copy(@".\bak\sys\main.dol", @".\tmp\wii\DATA\sys\main.dol", true);
            }

            // Normalize the path
            this.txtBox_outputPath.Text = Path.GetFullPath(this.txtBox_outputPath.Text);

            SetStatus("Randomizing game with given seed layout...");
            SetProgressStatus(preGenerationStepCount, preGenerationStepCount + generateStepCount);

            PatcherManager.Patch(new Dictionary<String, String>() {
                { "input-path", this.lbl_inputISO.Text },
                { "output-path", this.lbl_outputISO.Text },
                { "layout", this.lbl_seedLayout.Text },
                { "starting-items", this.comboBox_startingItems.Text },
                { "starting-location", this.comboBox_startingLocation.Text },
                { "random-door-colors", this.chkBox_randomDoorColors.Checked ? "true":"false" },
                { "random-welding-colors", this.chkBox_randomWeldingColors.Checked ? "true":"false" },
                { "fast-flying", this.chkBox_fastShipFlying.Checked ? "true":"false" },
                { "hyper-hints", this.chkBox_hyperHints.Checked ? "true":"false" }
            });

            SetStatus("Applying dol patches...");
            SetProgressStatus(preGenerationStepCount + 1, preGenerationStepCount + generateStepCount);
            Patcher.Patcher.Init(GameID[3]);

            PatchedGameID = GameID.Substring(0, 4) + RandomizeDeveloperCode();

            Patcher.Patcher.SetSaveFilename(PatchedGameID.Substring(4, 2)+".bin");

            SetStatus("Creating "+OutputFileExt.Substring(1).ToUpper()+" file...");
            SetProgressStatus(preGenerationStepCount + 2, preGenerationStepCount + generateStepCount);

            if (OutputFileExt == ".iso")
            {
                Directory.CreateDirectory(this.txtBox_outputPath.Text);
                WITManager.CreateISO(@".\tmp\mp3.iso", PatchedGameID);
                File.Move(@".\tmp\mp3.iso", this.txtBox_outputPath.Text + @"\Metroid Prime 3 - Corruption [" + PatchedGameID + "].iso");
            }
            if (OutputFileExt == ".ciso")
            {
                Directory.CreateDirectory(this.txtBox_outputPath.Text);
                WITManager.CreateCISO(@".\tmp\mp3.ciso", PatchedGameID);
                File.Move(@".\tmp\mp3.ciso", this.txtBox_outputPath.Text + @"\Metroid Prime 3 - Corruption [" + PatchedGameID + "].ciso");
            }
            if (OutputFileExt == ".wbfs")
            {
                Directory.CreateDirectory(this.txtBox_outputPath.Text + @"\Metroid Prime 3 - Corruption [" + PatchedGameID + "]");
                WITManager.CreateWBFS(@".\tmp\mp3.wbfs", PatchedGameID);
                File.Move(@".\tmp\mp3.wbfs", this.txtBox_outputPath.Text + @"\Metroid Prime 3 - Corruption [" + PatchedGameID + @"]\" +PatchedGameID+".wbfs");
            }

            SetStatus("Idle");
            SetProgressStatus(preGenerationStepCount + 3, preGenerationStepCount + generateStepCount);
            switchMode(false);

            MessageBox.Show("Corruption ISO has been randomized! Have fun!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!WITManager.Installed())
            {
                SetProgressStatus(1, 1);
                SetStatus("Downloading and installing WIT...");
                if (!WITManager.Init())
                {
                    MessageBox.Show("Couldn't download WIT");
                    this.Close();
                    return;
                }
                SetProgressStatus(2, 2);
                SetStatus("Idle");
            }
            this.txtBox_inputISO.Text = appSettings.inputPath;
            this.txtBox_outputPath.Text = appSettings.outputPath;
            OutputFileExt = appSettings.outputType;
            if (appSettings.outputType == ".iso")
            {
                radioBtn_ISO_Type.Checked = true;
                radioBtn_CISO_Type.Checked = radioBtn_WBFS_Type.Checked = false;
            }
            if (appSettings.outputType == ".ciso")
            {
                radioBtn_CISO_Type.Checked = true;
                radioBtn_ISO_Type.Checked = radioBtn_WBFS_Type.Checked = false;
            }
            if (appSettings.outputType == ".wbfs")
            {
                radioBtn_WBFS_Type.Checked = true;
                radioBtn_ISO_Type.Checked = radioBtn_CISO_Type.Checked = false;
            }
            this.comboBox_startingLocation.SelectedIndex = 0;
            this.comboBox_startingLocation.Update();
            this.comboBox_startingItems.SelectedIndex = 0;
            this.comboBox_startingItems.Update();
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            // cancels any pending randomization
            foreach(var proc in Process.GetProcessesByName("MP3Randomizer"))
                proc.Close();
            // cancels any ISO extraction/creation
            foreach (var proc in Process.GetProcessesByName("wit"))
                proc.Close();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
