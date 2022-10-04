using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Windows.Forms;

namespace LauncherForAll
{
    public partial class FormProgressBar1 : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
           int nLeftRect,
           int nTopRect,
           int nRightRect,
           int nBottomRect,
           int nWidthEllipse,
           int nHeightEllipse

        );

        // RedMod Colors
        // 255 255 255 White
        private Color WhiteColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
        // 11 7 17 Purple
        private Color BlackPurpleColor = Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
        // 19 12 29 BlackPurple 
        private Color PurpleColor = Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(12)))), ((int)(((byte)(29)))));
        // 235 42 83 RedMod
        private Color RedModColor = Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
        private Color BackProgressColor = Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
        // 85 213 219 ProgressColor
        private Color ProgressColor = Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
        // 28 26 43 OuterColor
        private Color OuterColor = Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(43)))));


        // BlueMod Colors
        // 46 51 73 Blue
        private Color BackBlueColor = Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
        // 28 37 55 BlackBlue
        private Color BackBlackBlueColor = Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
        // 0 126 249 Blue
        private Color BlueColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
        public static void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }
        public FormProgressBar1()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            progressbar1.Value = 0;

            string programData = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);

            if (File.Exists(programData + @"\LauncherForAll\Set_progressbarRedMod.config"))
            {
                this.BackColor = BlackPurpleColor;

                this.progressbar1.BackColor = BlackPurpleColor;
                this.progressbar1.InnerColor = BlackPurpleColor;
                this.progressbar1.ProgressColor = RedModColor;
                this.progressbar1.ForeColor = RedModColor;
                this.progressbar1.OuterColor = PurpleColor;


                this.label3.ForeColor = RedModColor;
                this.label1.ForeColor = RedModColor;
                this.pictureBox1.BackgroundImage = Properties.Resources.RedMod_Title;
                this.buttonRedMod.BackgroundImage = Properties.Resources.redMod;

            }
            else
            {
                this.BackColor = Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));

                this.progressbar1.BackColor = Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
                this.progressbar1.InnerColor = Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
                this.progressbar1.ProgressColor = Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
                this.progressbar1.ForeColor = Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
                this.progressbar1.OuterColor = Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(43)))));
                this.label3.ForeColor = Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
                this.label1.ForeColor = Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
                this.pictureBox1.BackgroundImage = Properties.Resources.Title1;
                this.buttonRedMod.BackgroundImage = Properties.Resources.blueMod;

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressbar1.Value += 1;
            progressbar1.Text = progressbar1.Value.ToString() + "%";

            if (progressbar1.Value == 100)
            {
                timer1.Enabled = false;
                Form1 form1 = new Form1();
                form1.Show();

                this.Hide();
            }
        }

        private void buttonRedMod_Click(object sender, EventArgs e)
        {
            string programData = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);

            if (File.Exists(programData + @"\LauncherForAll\Set_progressbarRedMod.config"))
            {
                string usr = Environment.UserName;
                DirectoryInfo myDirectoryInfo1 = new DirectoryInfo(programData + @"\LauncherForAll");
                DirectorySecurity myDirectorySecurity1 = myDirectoryInfo1.GetAccessControl();
                myDirectorySecurity1.AddAccessRule(new FileSystemAccessRule(usr, FileSystemRights.Write, AccessControlType.Allow));
                myDirectoryInfo1.SetAccessControl(myDirectorySecurity1);

                File.Delete(programData + @"\LauncherForAll\Set_progressbarRedMod.config");

                this.BackColor = Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));

                this.progressbar1.BackColor = Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
                this.progressbar1.InnerColor = Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
                this.progressbar1.ProgressColor = Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
                this.progressbar1.ForeColor = Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
                this.progressbar1.OuterColor = Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(43)))));
                this.label3.ForeColor = Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
                this.label1.ForeColor = Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
                this.pictureBox1.BackgroundImage = Properties.Resources.Title1;
                this.buttonRedMod.BackgroundImage = Properties.Resources.blueMod;

            }
            else
            {
                string usr = Environment.UserName;
                DirectoryInfo myDirectoryInfo1 = new DirectoryInfo(programData + @"\LauncherForAll");
                DirectorySecurity myDirectorySecurity1 = myDirectoryInfo1.GetAccessControl();
                myDirectorySecurity1.AddAccessRule(new FileSystemAccessRule(usr, FileSystemRights.Write, AccessControlType.Allow));
                myDirectoryInfo1.SetAccessControl(myDirectorySecurity1);

                File.WriteAllText(programData + @"\LauncherForAll\Set_progressbarRedMod.config", "1");

                this.BackColor = BlackPurpleColor;

                this.progressbar1.BackColor = BlackPurpleColor;
                this.progressbar1.InnerColor = BlackPurpleColor;
                this.progressbar1.ProgressColor = RedModColor;
                this.progressbar1.ForeColor = RedModColor;
                this.progressbar1.OuterColor = PurpleColor;


                this.label3.ForeColor = RedModColor;
                this.label1.ForeColor = RedModColor;
                this.pictureBox1.BackgroundImage = Properties.Resources.RedMod_Title;
                this.buttonRedMod.BackgroundImage = Properties.Resources.redMod;

            }
        }
    }
}
