using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LauncherForAll
{
    public partial class frmGames2 : Form
    {
        // RedMod Colors
        // 255 255 255 White
        private readonly Color WhiteColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));

        // 11 7 17 Purple
        private readonly Color BlackPurpleColor = Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
        // 19 12 29 BlackPurple 
        private readonly Color PurpleColor = Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(12)))), ((int)(((byte)(29)))));
        // 235 42 83 RedMod
        private readonly Color RedModColor = Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));

        // DefaultMod Colors
        // 46 51 73 Blue
        private readonly Color BackBlueColor = Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
        // 28 37 55 BlackBlue
        private readonly Color BackBlackBlueColor = Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
        // 0 126 249 Blue
        private readonly Color BlueColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
        public frmGames2()
        {
            InitializeComponent();

            string programData = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            // RedMod ?
            if (File.Exists(programData + @"\LauncherForAll\Set_redMod.config"))
            {
                this.BackColor = PurpleColor;
                this.buttonNext1.BackColor = PurpleColor;
                this.buttonNext1.ForeColor = WhiteColor;
            }
            else
            {
                this.BackColor = BackBlueColor;
                this.buttonNext1.BackColor = BackBlueColor;
                this.buttonNext1.ForeColor = Color.Black;
            }
        }
        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        private void buttonNext1_Click(object sender, EventArgs e)
        {
            this.pnlFormLoader.Controls.Clear();
            frmGames frmGames_vrb = new frmGames() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmGames_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmGames_vrb);
            frmGames_vrb.Show();
        }

        private void buttonR6_Click(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName("R6").Length == 0)
            {
                if (Process.GetProcessesByName("Steam").Length == 0)
                {
                    Process Steam = new Process();

                    // Preparing the launch of Steam
                    Steam.StartInfo.FileName = @"S:\Steam\steam.exe";

                    // Launch Steam
                    Steam.Start();
                }
                else if (Process.GetProcessesByName("Steam").Length > 0)
                {
                    this.Alert("Steam is already Launched", Form_Alert.enmType.Warning);
                }
                Process R6 = new Process();

                // Preparing the launch of R6
                R6.StartInfo.FileName = @"steam://rungameid/359550";

                // Launch R6
                R6.Start();
                if (R6.Responding == true)
                {
                    this.Alert("R6 Launched", Form_Alert.enmType.Success);
                }
                else
                {
                    this.Alert("R6 not Launched", Form_Alert.enmType.Success);
                }
            }
            else if (Process.GetProcessesByName("R6").Length > 0)
            {
                this.Alert("R6 is already Launched", Form_Alert.enmType.Warning);
            }
        }

        private void buttonCODMW_Click(object sender, EventArgs e)
        {

        }

        private void buttonGTAV_Click(object sender, EventArgs e)
        {

        }

        private void buttonGolfIt_Click(object sender, EventArgs e)
        {

        }

        private void buttonRimWorld_Click(object sender, EventArgs e)
        {

        }
    }
}
