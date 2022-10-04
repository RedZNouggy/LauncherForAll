using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LauncherForAll
{
    public partial class frmOtherApps2 : Form
    {
        // RedMod Colors
        // 255 255 255 White
        private Color WhiteColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));

        // 11 7 17 Purple
        private Color BlackPurpleColor = Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
        // 19 12 29 BlackPurple 
        private Color PurpleColor = Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(12)))), ((int)(((byte)(29)))));
        // 235 42 83 RedMod
        private Color RedModColor = Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));

        // DefaultMod Colors
        // 46 51 73 Blue
        private Color BackBlueColor = Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
        // 28 37 55 BlackBlue
        private Color BackBlackBlueColor = Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
        // 0 126 249 Blue
        private Color BlueColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));

        public frmOtherApps2()
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
            frmOtherApps frmOtherApps_vrb = new frmOtherApps() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmOtherApps_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmOtherApps_vrb);
            frmOtherApps_vrb.Show();
        }

        private void buttonPaintNet_Click(object sender, EventArgs e)
        {
            Process paintNet = new Process();

            // Preparing to Launch paint.net
            paintNet.StartInfo.FileName = @"C:\Program Files\paint.net\paintdotnet.exe";

            // Launch Outlook
            paintNet.Start();

            if (paintNet.Responding == true)
            {
                this.Alert("paint.Net Launched", Form_Alert.enmType.Success);
            }
            else
            {
                this.Alert("paint.Net not Launched", Form_Alert.enmType.Error);
            }
        }

        private void buttonSteel_Click(object sender, EventArgs e)
        {
            Process SteelS = new Process();


            if (Process.GetProcessesByName("SteelSeriesGG").Length == 0)
            {
                // Preparing to Launch SteelS
                SteelS.StartInfo.FileName = @"C:\Program Files\SteelSeries\GG\SteelSeriesGG.exe";

                // Launch SteelS
                SteelS.StartInfo.Arguments = @" - dataPath = 'C:\ProgramData\SteelSeries\GG' - dbEnv = production";
                SteelS.Start();

                if (SteelS.Responding == true)
                {
                    this.Alert("Steel Series Launched", Form_Alert.enmType.Success);
                }
                else
                {
                    this.Alert("Steel Series not Launched", Form_Alert.enmType.Error);
                }
            }
            else
            {
                // Open window of SteelS if not opened
                SteelS.StartInfo.FileName = @"C:\Program Files\SteelSeries\GG\SteelSeriesGGClient.exe";

                SteelS.Start();
                this.Alert("Steel Series already Launched", Form_Alert.enmType.Warning);
            }
        }
    }
}
