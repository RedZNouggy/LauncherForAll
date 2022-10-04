using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LauncherForAll
{

    public partial class frmBrowseApps : Form
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

        // 42 40 60 BlackBack2BlueColor
        private Color BlackBack2BlueColor = Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
        // 28 26 43 BlackBack3BlueColor
        private Color BlackBack3BlueColor = Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(43)))));
        public frmBrowseApps()
        {
            InitializeComponent();

            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            string programData = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);

            // RedMod ?
            if (File.Exists(programData + @"\LauncherForAll\Set_progressbarRedMod.config"))
            {

                this.Opacity = 90;

                this.BackColor = PurpleColor;
                this.pictureBox1.BackgroundImage = Properties.Resources.RedMod_Title;
                this.label1.ForeColor = WhiteColor;

                this.buttonRedMod.BackgroundImage = Properties.Resources.redMod;

                this.buttonRocketLeague.PressedColor = PurpleColor;
                this.buttonLeagueOfLegends.PressedColor = PurpleColor;
                this.buttonCSGO.PressedColor = PurpleColor;
                this.buttonDiablo3.PressedColor = PurpleColor;
                this.buttonValorant.PressedColor = PurpleColor;
                this.buttonOverwatch.PressedColor = PurpleColor;
                this.buttonMinecraft.PressedColor = PurpleColor;
                this.buttonAOE3D.PressedColor = PurpleColor;
                this.buttonHMM.PressedColor = PurpleColor;
                this.buttonR6.PressedColor = PurpleColor;
                this.buttonCODMW.PressedColor = PurpleColor;
                this.buttonGTAV.PressedColor = PurpleColor;
                this.buttonGolfIt.PressedColor = PurpleColor;
                this.buttonRimWorld.PressedColor = PurpleColor;

                this.buttonRocketLeague.ForeColor = WhiteColor;
                this.buttonLeagueOfLegends.ForeColor = WhiteColor;
                this.buttonCSGO.ForeColor = WhiteColor;
                this.buttonDiablo3.ForeColor = WhiteColor;
                this.buttonValorant.ForeColor = WhiteColor;
                this.buttonOverwatch.ForeColor = WhiteColor;
                this.buttonMinecraft.ForeColor = WhiteColor;
                this.buttonAOE3D.ForeColor = WhiteColor;
                this.buttonHMM.ForeColor = WhiteColor;
                this.buttonR6.ForeColor = WhiteColor;
                this.buttonCODMW.ForeColor = WhiteColor;
                this.buttonGTAV.ForeColor = WhiteColor;
                this.buttonGolfIt.ForeColor = WhiteColor;
                this.buttonRimWorld.ForeColor = WhiteColor;

                this.buttonRocketLeague.FillColor = BlackPurpleColor;
                this.buttonLeagueOfLegends.FillColor = BlackPurpleColor;
                this.buttonCSGO.FillColor = BlackPurpleColor;
                this.buttonDiablo3.FillColor = BlackPurpleColor;
                this.buttonValorant.FillColor = BlackPurpleColor;
                this.buttonOverwatch.FillColor = BlackPurpleColor;
                this.buttonMinecraft.FillColor = BlackPurpleColor;
                this.buttonAOE3D.FillColor = BlackPurpleColor;
                this.buttonHMM.FillColor = BlackPurpleColor;
                this.buttonR6.FillColor = BlackPurpleColor;
                this.buttonCODMW.FillColor = BlackPurpleColor;
                this.buttonGTAV.FillColor = BlackPurpleColor;
                this.buttonGolfIt.FillColor = BlackPurpleColor;
                this.buttonRimWorld.FillColor = BlackPurpleColor;

                this.buttonRocketLeague.BackColor = PurpleColor;
                this.buttonLeagueOfLegends.BackColor = PurpleColor;
                this.buttonCSGO.BackColor = PurpleColor;
                this.buttonDiablo3.BackColor = PurpleColor;
                this.buttonValorant.BackColor = PurpleColor;
                this.buttonOverwatch.BackColor = PurpleColor;
                this.buttonMinecraft.BackColor = PurpleColor;
                this.buttonAOE3D.BackColor = PurpleColor;
                this.buttonHMM.BackColor = PurpleColor;
                this.buttonR6.BackColor = PurpleColor;
                this.buttonCODMW.BackColor = PurpleColor;
                this.buttonGTAV.BackColor = PurpleColor;
                this.buttonGolfIt.BackColor = PurpleColor;
                this.buttonRimWorld.BackColor = PurpleColor;


                this.buttonEXIT.BackColor = PurpleColor;
                this.buttonEXIT.FillColor = BlackPurpleColor;
                this.buttonEXIT.ForeColor = WhiteColor;

                this.buttonSTART.BackColor = PurpleColor;
                this.buttonSTART.FillColor = BlackPurpleColor;
                this.buttonSTART.ForeColor = WhiteColor;

                this.Icon = Properties.Resources.RedMod_Logo;
            }
            else
            {
                this.Opacity = 95;

                this.BackColor = BlackBack2BlueColor;
                this.pictureBox1.BackgroundImage = Properties.Resources.Title1;
                this.label1.ForeColor = Color.Black;
                this.buttonRedMod.BackgroundImage = Properties.Resources.blueMod;

                this.buttonRocketLeague.PressedColor = BlackBack3BlueColor;
                this.buttonLeagueOfLegends.PressedColor = BlackBack3BlueColor;
                this.buttonCSGO.PressedColor = BlackBack3BlueColor;
                this.buttonDiablo3.PressedColor = BlackBack3BlueColor;
                this.buttonValorant.PressedColor = BlackBack3BlueColor;
                this.buttonOverwatch.PressedColor = BlackBack3BlueColor;
                this.buttonMinecraft.PressedColor = BlackBack3BlueColor;
                this.buttonAOE3D.PressedColor = BlackBack3BlueColor;
                this.buttonHMM.PressedColor = BlackBack3BlueColor;
                this.buttonR6.PressedColor = BlackBack3BlueColor;
                this.buttonCODMW.PressedColor = BlackBack3BlueColor;
                this.buttonGTAV.PressedColor = BlackBack3BlueColor;
                this.buttonGolfIt.PressedColor = BlackBack3BlueColor;
                this.buttonRimWorld.PressedColor = BlackBack3BlueColor;

                this.buttonRocketLeague.ForeColor = Color.Black;
                this.buttonLeagueOfLegends.ForeColor = Color.Black;
                this.buttonCSGO.ForeColor = Color.Black;
                this.buttonDiablo3.ForeColor = Color.Black;
                this.buttonValorant.ForeColor = Color.Black;
                this.buttonOverwatch.ForeColor = Color.Black;
                this.buttonMinecraft.ForeColor = Color.Black;
                this.buttonAOE3D.ForeColor = Color.Black;
                this.buttonHMM.ForeColor = Color.Black;
                this.buttonR6.ForeColor = Color.Black;
                this.buttonCODMW.ForeColor = Color.Black;
                this.buttonGTAV.ForeColor = Color.Black;
                this.buttonGolfIt.ForeColor = Color.Black;
                this.buttonRimWorld.ForeColor = Color.Black;

                this.buttonRocketLeague.FillColor = BlackBack3BlueColor;
                this.buttonLeagueOfLegends.FillColor = BlackBack3BlueColor;
                this.buttonCSGO.FillColor = BlackBack3BlueColor;
                this.buttonDiablo3.FillColor = BlackBack3BlueColor;
                this.buttonValorant.FillColor = BlackBack3BlueColor;
                this.buttonOverwatch.FillColor = BlackBack3BlueColor;
                this.buttonMinecraft.FillColor = BlackBack3BlueColor;
                this.buttonAOE3D.FillColor = BlackBack3BlueColor;
                this.buttonHMM.FillColor = BlackBack3BlueColor;
                this.buttonR6.FillColor = BlackBack3BlueColor;
                this.buttonCODMW.FillColor = BlackBack3BlueColor;
                this.buttonGTAV.FillColor = BlackBack3BlueColor;
                this.buttonGolfIt.FillColor = BlackBack3BlueColor;
                this.buttonRimWorld.FillColor = BlackBack3BlueColor;

                this.buttonRocketLeague.BackColor = BlackBack2BlueColor;
                this.buttonLeagueOfLegends.BackColor = BlackBack2BlueColor;
                this.buttonCSGO.BackColor = BlackBack2BlueColor;
                this.buttonDiablo3.BackColor = BlackBack2BlueColor;
                this.buttonValorant.BackColor = BlackBack2BlueColor;
                this.buttonOverwatch.BackColor = BlackBack2BlueColor;
                this.buttonMinecraft.BackColor = BlackBack2BlueColor;
                this.buttonAOE3D.BackColor = BlackBack2BlueColor;
                this.buttonHMM.BackColor = BlackBack2BlueColor;
                this.buttonR6.BackColor = BlackBack2BlueColor;
                this.buttonCODMW.BackColor = BlackBack2BlueColor;
                this.buttonGTAV.BackColor = BlackBack2BlueColor;
                this.buttonGolfIt.BackColor = BlackBack2BlueColor;
                this.buttonRimWorld.BackColor = BlackBack2BlueColor;

                this.buttonEXIT.BackColor = BlackBack2BlueColor;
                this.buttonEXIT.FillColor = BlackBack3BlueColor;
                this.buttonEXIT.ForeColor = Color.Black;

                this.buttonSTART.BackColor = BlackBack2BlueColor;
                this.buttonSTART.FillColor = BlackBack3BlueColor;
                this.buttonSTART.ForeColor = Color.Black;

                this.Icon = Properties.Resources.LauncherForAll;
            }
        }

        private void buttonEXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonSTART_Click(object sender, EventArgs e)
        {
            frmBrowseApps.ActiveForm.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void buttonRedMod_Click(object sender, EventArgs e)
        {
            string programData = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);

            if (File.Exists(programData + @"\LauncherForAll\Set_progressbarRedMod.config"))
            {
                DirectoryInfo myDirectoryInfo1 = new DirectoryInfo(programData + @"\LauncherForAll");
                DirectorySecurity myDirectorySecurity1 = myDirectoryInfo1.GetAccessControl();
                myDirectorySecurity1.AddAccessRule(new FileSystemAccessRule("Everyone", FileSystemRights.FullControl, AccessControlType.Allow));
                myDirectoryInfo1.SetAccessControl(myDirectorySecurity1);

                File.Delete(programData + @"\LauncherForAll\Set_progressbarRedMod.config");

                this.Opacity = 95;

                this.BackColor = BlackBack2BlueColor;
                this.pictureBox1.BackgroundImage = Properties.Resources.Title1;
                this.label1.ForeColor = Color.Black;
                this.buttonRedMod.BackgroundImage = Properties.Resources.blueMod;

                this.buttonRocketLeague.PressedColor = BlackBack3BlueColor;
                this.buttonLeagueOfLegends.PressedColor = BlackBack3BlueColor;
                this.buttonCSGO.PressedColor = BlackBack3BlueColor;
                this.buttonDiablo3.PressedColor = BlackBack3BlueColor;
                this.buttonValorant.PressedColor = BlackBack3BlueColor;
                this.buttonOverwatch.PressedColor = BlackBack3BlueColor;
                this.buttonMinecraft.PressedColor = BlackBack3BlueColor;
                this.buttonAOE3D.PressedColor = BlackBack3BlueColor;
                this.buttonHMM.PressedColor = BlackBack3BlueColor;
                this.buttonR6.PressedColor = BlackBack3BlueColor;
                this.buttonCODMW.PressedColor = BlackBack3BlueColor;
                this.buttonGTAV.PressedColor = BlackBack3BlueColor;
                this.buttonGolfIt.PressedColor = BlackBack3BlueColor;
                this.buttonRimWorld.PressedColor = BlackBack3BlueColor;

                this.buttonRocketLeague.ForeColor = Color.Black;
                this.buttonLeagueOfLegends.ForeColor = Color.Black;
                this.buttonCSGO.ForeColor = Color.Black;
                this.buttonDiablo3.ForeColor = Color.Black;
                this.buttonValorant.ForeColor = Color.Black;
                this.buttonOverwatch.ForeColor = Color.Black;
                this.buttonMinecraft.ForeColor = Color.Black;
                this.buttonAOE3D.ForeColor = Color.Black;
                this.buttonHMM.ForeColor = Color.Black;
                this.buttonR6.ForeColor = Color.Black;
                this.buttonCODMW.ForeColor = Color.Black;
                this.buttonGTAV.ForeColor = Color.Black;
                this.buttonGolfIt.ForeColor = Color.Black;
                this.buttonRimWorld.ForeColor = Color.Black;

                this.buttonRocketLeague.FillColor = BlackBack3BlueColor;
                this.buttonLeagueOfLegends.FillColor = BlackBack3BlueColor;
                this.buttonCSGO.FillColor = BlackBack3BlueColor;
                this.buttonDiablo3.FillColor = BlackBack3BlueColor;
                this.buttonValorant.FillColor = BlackBack3BlueColor;
                this.buttonOverwatch.FillColor = BlackBack3BlueColor;
                this.buttonMinecraft.FillColor = BlackBack3BlueColor;
                this.buttonAOE3D.FillColor = BlackBack3BlueColor;
                this.buttonHMM.FillColor = BlackBack3BlueColor;
                this.buttonR6.FillColor = BlackBack3BlueColor;
                this.buttonCODMW.FillColor = BlackBack3BlueColor;
                this.buttonGTAV.FillColor = BlackBack3BlueColor;
                this.buttonGolfIt.FillColor = BlackBack3BlueColor;
                this.buttonRimWorld.FillColor = BlackBack3BlueColor;

                this.buttonRocketLeague.BackColor = BlackBack2BlueColor;
                this.buttonLeagueOfLegends.BackColor = BlackBack2BlueColor;
                this.buttonCSGO.BackColor = BlackBack2BlueColor;
                this.buttonDiablo3.BackColor = BlackBack2BlueColor;
                this.buttonValorant.BackColor = BlackBack2BlueColor;
                this.buttonOverwatch.BackColor = BlackBack2BlueColor;
                this.buttonMinecraft.BackColor = BlackBack2BlueColor;
                this.buttonAOE3D.BackColor = BlackBack2BlueColor;
                this.buttonHMM.BackColor = BlackBack2BlueColor;
                this.buttonR6.BackColor = BlackBack2BlueColor;
                this.buttonCODMW.BackColor = BlackBack2BlueColor;
                this.buttonGTAV.BackColor = BlackBack2BlueColor;
                this.buttonGolfIt.BackColor = BlackBack2BlueColor;
                this.buttonRimWorld.BackColor = BlackBack2BlueColor;

                this.buttonEXIT.BackColor = BlackBack2BlueColor;
                this.buttonEXIT.FillColor = BlackBack3BlueColor;
                this.buttonEXIT.ForeColor = Color.Black;

                this.buttonSTART.BackColor = BlackBack2BlueColor;
                this.buttonSTART.FillColor = BlackBack3BlueColor;
                this.buttonSTART.ForeColor = Color.Black;

                this.Icon = Properties.Resources.LauncherForAll;
            }
            else
            {
                string usr = Environment.UserName;
                DirectoryInfo myDirectoryInfo1 = new DirectoryInfo(programData + @"\LauncherForAll");
                DirectorySecurity myDirectorySecurity1 = myDirectoryInfo1.GetAccessControl();
                myDirectorySecurity1.AddAccessRule(new FileSystemAccessRule(usr, FileSystemRights.Write, AccessControlType.Allow));
                myDirectoryInfo1.SetAccessControl(myDirectorySecurity1);

                File.WriteAllText(programData + @"\LauncherForAll\Set_progressbarRedMod.config", "1");
                this.Opacity = 90;

                this.BackColor = PurpleColor;
                this.pictureBox1.BackgroundImage = Properties.Resources.RedMod_Title;
                this.label1.ForeColor = WhiteColor;

                this.buttonRedMod.BackgroundImage = Properties.Resources.redMod;

                this.buttonRocketLeague.PressedColor = PurpleColor;
                this.buttonLeagueOfLegends.PressedColor = PurpleColor;
                this.buttonCSGO.PressedColor = PurpleColor;
                this.buttonDiablo3.PressedColor = PurpleColor;
                this.buttonValorant.PressedColor = PurpleColor;
                this.buttonOverwatch.PressedColor = PurpleColor;
                this.buttonMinecraft.PressedColor = PurpleColor;
                this.buttonAOE3D.PressedColor = PurpleColor;
                this.buttonHMM.PressedColor = PurpleColor;
                this.buttonR6.PressedColor = PurpleColor;
                this.buttonCODMW.PressedColor = PurpleColor;
                this.buttonGTAV.PressedColor = PurpleColor;
                this.buttonGolfIt.PressedColor = PurpleColor;
                this.buttonRimWorld.PressedColor = PurpleColor;

                this.buttonRocketLeague.ForeColor = WhiteColor;
                this.buttonLeagueOfLegends.ForeColor = WhiteColor;
                this.buttonCSGO.ForeColor = WhiteColor;
                this.buttonDiablo3.ForeColor = WhiteColor;
                this.buttonValorant.ForeColor = WhiteColor;
                this.buttonOverwatch.ForeColor = WhiteColor;
                this.buttonMinecraft.ForeColor = WhiteColor;
                this.buttonAOE3D.ForeColor = WhiteColor;
                this.buttonHMM.ForeColor = WhiteColor;
                this.buttonR6.ForeColor = WhiteColor;
                this.buttonCODMW.ForeColor = WhiteColor;
                this.buttonGTAV.ForeColor = WhiteColor;
                this.buttonGolfIt.ForeColor = WhiteColor;
                this.buttonRimWorld.ForeColor = WhiteColor;

                this.buttonRocketLeague.FillColor = BlackPurpleColor;
                this.buttonLeagueOfLegends.FillColor = BlackPurpleColor;
                this.buttonCSGO.FillColor = BlackPurpleColor;
                this.buttonDiablo3.FillColor = BlackPurpleColor;
                this.buttonValorant.FillColor = BlackPurpleColor;
                this.buttonOverwatch.FillColor = BlackPurpleColor;
                this.buttonMinecraft.FillColor = BlackPurpleColor;
                this.buttonAOE3D.FillColor = BlackPurpleColor;
                this.buttonHMM.FillColor = BlackPurpleColor;
                this.buttonR6.FillColor = BlackPurpleColor;
                this.buttonCODMW.FillColor = BlackPurpleColor;
                this.buttonGTAV.FillColor = BlackPurpleColor;
                this.buttonGolfIt.FillColor = BlackPurpleColor;
                this.buttonRimWorld.FillColor = BlackPurpleColor;

                this.buttonRocketLeague.BackColor = PurpleColor;
                this.buttonLeagueOfLegends.BackColor = PurpleColor;
                this.buttonCSGO.BackColor = PurpleColor;
                this.buttonDiablo3.BackColor = PurpleColor;
                this.buttonValorant.BackColor = PurpleColor;
                this.buttonOverwatch.BackColor = PurpleColor;
                this.buttonMinecraft.BackColor = PurpleColor;
                this.buttonAOE3D.BackColor = PurpleColor;
                this.buttonHMM.BackColor = PurpleColor;
                this.buttonR6.BackColor = PurpleColor;
                this.buttonCODMW.BackColor = PurpleColor;
                this.buttonGTAV.BackColor = PurpleColor;
                this.buttonGolfIt.BackColor = PurpleColor;
                this.buttonRimWorld.BackColor = PurpleColor;


                this.buttonEXIT.BackColor = PurpleColor;
                this.buttonEXIT.FillColor = BlackPurpleColor;
                this.buttonEXIT.ForeColor = WhiteColor;

                this.buttonSTART.BackColor = PurpleColor;
                this.buttonSTART.FillColor = BlackPurpleColor;
                this.buttonSTART.ForeColor = WhiteColor;

                this.Icon = Properties.Resources.RedMod_Logo;
            }
        }

        private void buttonRocketLeague_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Get a File .lnk or a .exe (a .lnk is safer)";
            fdlg.InitialDirectory = @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs";
            fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                string programData = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);

                string usr = Environment.UserName;
                DirectoryInfo myDirectoryInfo1 = new DirectoryInfo(programData + @"\LauncherForAll");
                DirectorySecurity myDirectorySecurity1 = myDirectoryInfo1.GetAccessControl();
                myDirectorySecurity1.AddAccessRule(new FileSystemAccessRule(usr, FileSystemRights.Write, AccessControlType.Allow));
                myDirectoryInfo1.SetAccessControl(myDirectorySecurity1);

                if (Directory.Exists(@"\LauncherForAll\PathList"))
                {
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\RocketLeague.config", fdlg.FileName);
                }
                else
                {
                    Directory.CreateDirectory(@"\LauncherForAll\PathList");
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\RocketLeague.config", fdlg.FileName);
                }
            }
        }

        private void buttonLeagueOfLegends_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Get a File .lnk or a .exe (a .lnk is safer)";
            fdlg.InitialDirectory = @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs";
            fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                string programData = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);

                string usr = Environment.UserName;
                DirectoryInfo myDirectoryInfo1 = new DirectoryInfo(programData + @"\LauncherForAll");
                DirectorySecurity myDirectorySecurity1 = myDirectoryInfo1.GetAccessControl();
                myDirectorySecurity1.AddAccessRule(new FileSystemAccessRule(usr, FileSystemRights.Write, AccessControlType.Allow));
                myDirectoryInfo1.SetAccessControl(myDirectorySecurity1);

                if(Directory.Exists(@"\LauncherForAll\PathList"))
                {
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\LeagueOfLegends.config", fdlg.FileName);
                }
                else
                {
                    Directory.CreateDirectory(@"\LauncherForAll\PathList");
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\LeagueOfLegends.config", fdlg.FileName);
                }
            }
        }

        private void buttonCSGO_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Get a File .lnk or a .exe (a .lnk is safer)";
            fdlg.InitialDirectory = @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs";
            fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                string programData = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);

                string usr = Environment.UserName;
                DirectoryInfo myDirectoryInfo1 = new DirectoryInfo(programData + @"\LauncherForAll");
                DirectorySecurity myDirectorySecurity1 = myDirectoryInfo1.GetAccessControl();
                myDirectorySecurity1.AddAccessRule(new FileSystemAccessRule(usr, FileSystemRights.Write, AccessControlType.Allow));
                myDirectoryInfo1.SetAccessControl(myDirectorySecurity1);

                if (Directory.Exists(@"\LauncherForAll\PathList"))
                {
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\CSGO.config", fdlg.FileName);
                }
                else
                {
                    Directory.CreateDirectory(@"\LauncherForAll\PathList");
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\CSGO.config", fdlg.FileName);
                }
            }
        }

        private void buttonDiablo3_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Get a File .lnk or a .exe (a .lnk is safer)";
            fdlg.InitialDirectory = @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs";
            fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                string programData = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);

                string usr = Environment.UserName;
                DirectoryInfo myDirectoryInfo1 = new DirectoryInfo(programData + @"\LauncherForAll");
                DirectorySecurity myDirectorySecurity1 = myDirectoryInfo1.GetAccessControl();
                myDirectorySecurity1.AddAccessRule(new FileSystemAccessRule(usr, FileSystemRights.Write, AccessControlType.Allow));
                myDirectoryInfo1.SetAccessControl(myDirectorySecurity1);

                if (Directory.Exists(@"\LauncherForAll\PathList"))
                {
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\D3.config", fdlg.FileName);
                }
                else
                {
                    Directory.CreateDirectory(@"\LauncherForAll\PathList");
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\D3.config", fdlg.FileName);
                }
            }
        }

        private void buttonValorant_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Get a File .lnk or a .exe (a .lnk is safer)";
            fdlg.InitialDirectory = @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs";
            fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                string programData = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);

                string usr = Environment.UserName;
                DirectoryInfo myDirectoryInfo1 = new DirectoryInfo(programData + @"\LauncherForAll");
                DirectorySecurity myDirectorySecurity1 = myDirectoryInfo1.GetAccessControl();
                myDirectorySecurity1.AddAccessRule(new FileSystemAccessRule(usr, FileSystemRights.Write, AccessControlType.Allow));
                myDirectoryInfo1.SetAccessControl(myDirectorySecurity1);

                if (Directory.Exists(@"\LauncherForAll\PathList"))
                {
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\Valorant.config", fdlg.FileName);
                }
                else
                {
                    Directory.CreateDirectory(@"\LauncherForAll\PathList");
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\Valorant.config", fdlg.FileName);
                }
            }
        }

        private void buttonOverwatch_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Get a File .lnk or a .exe (a .lnk is safer)";
            fdlg.InitialDirectory = @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs";
            fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                string programData = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);

                string usr = Environment.UserName;
                DirectoryInfo myDirectoryInfo1 = new DirectoryInfo(programData + @"\LauncherForAll");
                DirectorySecurity myDirectorySecurity1 = myDirectoryInfo1.GetAccessControl();
                myDirectorySecurity1.AddAccessRule(new FileSystemAccessRule(usr, FileSystemRights.Write, AccessControlType.Allow));
                myDirectoryInfo1.SetAccessControl(myDirectorySecurity1);

                if (Directory.Exists(@"\LauncherForAll\PathList"))
                {
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\Overwatch.config", fdlg.FileName);
                }
                else
                {
                    Directory.CreateDirectory(@"\LauncherForAll\PathList");
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\Overwatch.config", fdlg.FileName);
                }
            }
        }

        private void buttonMinecraft_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Get a File .lnk or a .exe (a .lnk is safer)";
            fdlg.InitialDirectory = @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs";
            fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                string programData = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);

                string usr = Environment.UserName;
                DirectoryInfo myDirectoryInfo1 = new DirectoryInfo(programData + @"\LauncherForAll");
                DirectorySecurity myDirectorySecurity1 = myDirectoryInfo1.GetAccessControl();
                myDirectorySecurity1.AddAccessRule(new FileSystemAccessRule(usr, FileSystemRights.Write, AccessControlType.Allow));
                myDirectoryInfo1.SetAccessControl(myDirectorySecurity1);

                if (Directory.Exists(@"\LauncherForAll\PathList"))
                {
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\Minecraft.config", fdlg.FileName);
                }
                else
                {
                    Directory.CreateDirectory(@"\LauncherForAll\PathList");
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\Minecraft.config", fdlg.FileName);
                }
            }
        }

        private void buttonAOE3D_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Get a File .lnk or a .exe (a .lnk is safer)";
            fdlg.InitialDirectory = @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs";
            fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                string programData = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);

                string usr = Environment.UserName;
                DirectoryInfo myDirectoryInfo1 = new DirectoryInfo(programData + @"\LauncherForAll");
                DirectorySecurity myDirectorySecurity1 = myDirectoryInfo1.GetAccessControl();
                myDirectorySecurity1.AddAccessRule(new FileSystemAccessRule(usr, FileSystemRights.Write, AccessControlType.Allow));
                myDirectoryInfo1.SetAccessControl(myDirectorySecurity1);

                if (Directory.Exists(@"\LauncherForAll\PathList"))
                {
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\AOE3D.config", fdlg.FileName);
                }
                else
                {
                    Directory.CreateDirectory(@"\LauncherForAll\PathList");
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\AOE3D.config", fdlg.FileName);
                }
            }
        }

        private void buttonHMM_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Get a File .lnk or a .exe (a .lnk is safer)";
            fdlg.InitialDirectory = @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs";
            fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                string programData = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);

                string usr = Environment.UserName;
                DirectoryInfo myDirectoryInfo1 = new DirectoryInfo(programData + @"\LauncherForAll");
                DirectorySecurity myDirectorySecurity1 = myDirectoryInfo1.GetAccessControl();
                myDirectorySecurity1.AddAccessRule(new FileSystemAccessRule(usr, FileSystemRights.Write, AccessControlType.Allow));
                myDirectoryInfo1.SetAccessControl(myDirectorySecurity1);

                if (Directory.Exists(@"\LauncherForAll\PathList"))
                {
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\AOE3D.config", fdlg.FileName);
                }
                else
                {
                    Directory.CreateDirectory(@"\LauncherForAll\PathList");
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\AOE3D.config", fdlg.FileName);
                }
            }
        }

        private void buttonR6_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Get a File .lnk or a .exe (a .lnk is safer)";
            fdlg.InitialDirectory = @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs";
            fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                string programData = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);

                string usr = Environment.UserName;
                DirectoryInfo myDirectoryInfo1 = new DirectoryInfo(programData + @"\LauncherForAll");
                DirectorySecurity myDirectorySecurity1 = myDirectoryInfo1.GetAccessControl();
                myDirectorySecurity1.AddAccessRule(new FileSystemAccessRule(usr, FileSystemRights.Write, AccessControlType.Allow));
                myDirectoryInfo1.SetAccessControl(myDirectorySecurity1);

                if (Directory.Exists(@"\LauncherForAll\PathList"))
                {
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\R6.config", fdlg.FileName);
                }
                else
                {
                    Directory.CreateDirectory(@"\LauncherForAll\PathList");
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\R6.config", fdlg.FileName);
                }
            }
        }

        private void buttonCODMW_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Get a File .lnk or a .exe (a .lnk is safer)";
            fdlg.InitialDirectory = @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs";
            fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                string programData = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);

                string usr = Environment.UserName;
                DirectoryInfo myDirectoryInfo1 = new DirectoryInfo(programData + @"\LauncherForAll");
                DirectorySecurity myDirectorySecurity1 = myDirectoryInfo1.GetAccessControl();
                myDirectorySecurity1.AddAccessRule(new FileSystemAccessRule(usr, FileSystemRights.Write, AccessControlType.Allow));
                myDirectoryInfo1.SetAccessControl(myDirectorySecurity1);

                if (Directory.Exists(@"\LauncherForAll\PathList"))
                {
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\CODMW.config", fdlg.FileName);
                }
                else
                {
                    Directory.CreateDirectory(@"\LauncherForAll\PathList");
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\CODMW.config", fdlg.FileName);
                }
            }
        }

        private void buttonGTAV_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Get a File .lnk or a .exe (a .lnk is safer)";
            fdlg.InitialDirectory = @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs";
            fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                string programData = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);

                string usr = Environment.UserName;
                DirectoryInfo myDirectoryInfo1 = new DirectoryInfo(programData + @"\LauncherForAll");
                DirectorySecurity myDirectorySecurity1 = myDirectoryInfo1.GetAccessControl();
                myDirectorySecurity1.AddAccessRule(new FileSystemAccessRule(usr, FileSystemRights.Write, AccessControlType.Allow));
                myDirectoryInfo1.SetAccessControl(myDirectorySecurity1);

                if (Directory.Exists(@"\LauncherForAll\PathList"))
                {
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\GTAV.config", fdlg.FileName);
                }
                else
                {
                    Directory.CreateDirectory(@"\LauncherForAll\PathList");
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\GTAV.config", fdlg.FileName);
                }
            }
        }

        private void buttonGolfIt_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Get a File .lnk or a .exe (a .lnk is safer)";
            fdlg.InitialDirectory = @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs";
            fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                string programData = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);

                string usr = Environment.UserName;
                DirectoryInfo myDirectoryInfo1 = new DirectoryInfo(programData + @"\LauncherForAll");
                DirectorySecurity myDirectorySecurity1 = myDirectoryInfo1.GetAccessControl();
                myDirectorySecurity1.AddAccessRule(new FileSystemAccessRule(usr, FileSystemRights.Write, AccessControlType.Allow));
                myDirectoryInfo1.SetAccessControl(myDirectorySecurity1);

                if (Directory.Exists(@"\LauncherForAll\PathList"))
                {
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\GolfIt.config", fdlg.FileName);
                }
                else
                {
                    Directory.CreateDirectory(@"\LauncherForAll\PathList");
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\GolfIt.config", fdlg.FileName);
                }
            }
        }

        private void buttonRimWorld_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Get a File .lnk or a .exe (a .lnk is safer)";
            fdlg.InitialDirectory = @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs";
            fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                string programData = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);

                string usr = Environment.UserName;
                DirectoryInfo myDirectoryInfo1 = new DirectoryInfo(programData + @"\LauncherForAll");
                DirectorySecurity myDirectorySecurity1 = myDirectoryInfo1.GetAccessControl();
                myDirectorySecurity1.AddAccessRule(new FileSystemAccessRule(usr, FileSystemRights.Write, AccessControlType.Allow));
                myDirectoryInfo1.SetAccessControl(myDirectorySecurity1);

                if (Directory.Exists(@"\LauncherForAll\PathList"))
                {
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\RimWorld.config", fdlg.FileName);
                }
                else
                {
                    Directory.CreateDirectory(@"\LauncherForAll\PathList");
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\RimWorld.config", fdlg.FileName);
                }
            }
        }

        private void OtherApps_Click(object sender, EventArgs e)
        {
            this.frmLoader.Controls.Clear();
            frmBrowseApps2 frmBrowseApps2_vrb = new frmBrowseApps2() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmBrowseApps2_vrb.FormBorderStyle = FormBorderStyle.None;
            this.frmLoader.Controls.Add(frmBrowseApps2_vrb);
            frmBrowseApps2_vrb.Show();
        }
    }
}
