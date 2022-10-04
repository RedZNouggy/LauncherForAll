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
    public partial class frmBrowseApps2 : Form
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
        public frmBrowseApps2()
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

                this.buttonDashlane.PressedColor = PurpleColor;
                this.buttonDiscord.PressedColor = PurpleColor;
                this.buttonVSCode.PressedColor = PurpleColor;
                this.buttonVS.PressedColor = PurpleColor;
                this.buttonOutlook.PressedColor = PurpleColor;
                this.buttonOfficeHub.PressedColor = PurpleColor;
                this.buttonTeams.PressedColor = PurpleColor;
                this.buttonOneNote.PressedColor = PurpleColor;
                this.buttonMsstore.PressedColor = PurpleColor;
                this.buttonChrome.PressedColor = PurpleColor;
                this.buttonSignal.PressedColor = PurpleColor;
                this.buttonHWM.PressedColor = PurpleColor;
                this.buttonLivelyWP.PressedColor = PurpleColor;
                this.buttonPaintNet.PressedColor = PurpleColor;
                this.buttonSteel.PressedColor = PurpleColor;
                this.buttonWindowsTerminal.PressedColor = PurpleColor;
                this.buttonHWiNFO64.PressedColor = PurpleColor;
                this.buttonHVM.PressedColor = PurpleColor;
                this.buttonHotSpot.PressedColor = PurpleColor;
                this.buttonSpotify.PressedColor = PurpleColor;
                this.buttonBakkesMod.PressedColor = PurpleColor;
                this.buttonPorofessor.PressedColor = PurpleColor;
                this.buttonSteam.PressedColor = PurpleColor;
                this.buttonBattlenet.PressedColor = PurpleColor;
                this.buttonEpicGames.PressedColor = PurpleColor;
                this.buttonYoutube.PressedColor = PurpleColor;
                this.buttonTwitch.PressedColor = PurpleColor;
                this.buttonOBSLauncher.PressedColor = PurpleColor;
                this.buttonPlex.PressedColor = PurpleColor;
                this.buttonRadarr.PressedColor = PurpleColor;
                this.buttonSonarr.PressedColor = PurpleColor;
                this.buttonLidarr.PressedColor = PurpleColor;
                this.buttonTransmission.PressedColor = PurpleColor;
                this.buttonWireguard.PressedColor = PurpleColor;

                this.buttonDashlane.ForeColor = WhiteColor;
                this.buttonDiscord.ForeColor = WhiteColor;
                this.buttonVSCode.ForeColor = WhiteColor;
                this.buttonVS.ForeColor = WhiteColor;
                this.buttonOutlook.ForeColor = WhiteColor;
                this.buttonOfficeHub.ForeColor = WhiteColor;
                this.buttonTeams.ForeColor = WhiteColor;
                this.buttonOneNote.ForeColor = WhiteColor;
                this.buttonMsstore.ForeColor = WhiteColor;
                this.buttonChrome.ForeColor = WhiteColor;
                this.buttonSignal.ForeColor = WhiteColor;
                this.buttonHWM.ForeColor = WhiteColor;
                this.buttonLivelyWP.ForeColor = WhiteColor;
                this.buttonPaintNet.ForeColor = WhiteColor;
                this.buttonSteel.ForeColor = WhiteColor;
                this.buttonWindowsTerminal.ForeColor = WhiteColor;
                this.buttonHWiNFO64.ForeColor = WhiteColor;
                this.buttonHVM.ForeColor = WhiteColor;
                this.buttonHotSpot.ForeColor = WhiteColor;
                this.buttonSpotify.ForeColor = WhiteColor;
                this.buttonBakkesMod.ForeColor = WhiteColor;
                this.buttonPorofessor.ForeColor = WhiteColor;
                this.buttonSteam.ForeColor = WhiteColor;
                this.buttonBattlenet.ForeColor = WhiteColor;
                this.buttonEpicGames.ForeColor = WhiteColor;
                this.buttonYoutube.ForeColor = WhiteColor;
                this.buttonTwitch.ForeColor = WhiteColor;
                this.buttonOBSLauncher.ForeColor = WhiteColor;
                this.buttonPlex.ForeColor = WhiteColor;
                this.buttonRadarr.ForeColor = WhiteColor;
                this.buttonSonarr.ForeColor = WhiteColor;
                this.buttonLidarr.ForeColor = WhiteColor;
                this.buttonTransmission.ForeColor = WhiteColor;
                this.buttonWireguard.ForeColor = WhiteColor;

                this.buttonDashlane.FillColor = BlackPurpleColor;
                this.buttonDiscord.FillColor = BlackPurpleColor;
                this.buttonVSCode.FillColor = BlackPurpleColor;
                this.buttonVS.FillColor = BlackPurpleColor;
                this.buttonOutlook.FillColor = BlackPurpleColor;
                this.buttonOfficeHub.FillColor = BlackPurpleColor;
                this.buttonTeams.FillColor = BlackPurpleColor;
                this.buttonOneNote.FillColor = BlackPurpleColor;
                this.buttonMsstore.FillColor = BlackPurpleColor;
                this.buttonChrome.FillColor = BlackPurpleColor;
                this.buttonSignal.FillColor = BlackPurpleColor;
                this.buttonHWM.FillColor = BlackPurpleColor;
                this.buttonLivelyWP.FillColor = BlackPurpleColor;
                this.buttonPaintNet.FillColor = BlackPurpleColor;
                this.buttonSteel.FillColor = BlackPurpleColor;
                this.buttonWindowsTerminal.FillColor = BlackPurpleColor;
                this.buttonHWiNFO64.FillColor = BlackPurpleColor;
                this.buttonHVM.FillColor = BlackPurpleColor;
                this.buttonHotSpot.FillColor = BlackPurpleColor;
                this.buttonSpotify.FillColor = BlackPurpleColor;
                this.buttonBakkesMod.FillColor = BlackPurpleColor;
                this.buttonPorofessor.FillColor = BlackPurpleColor;
                this.buttonSteam.FillColor = BlackPurpleColor;
                this.buttonBattlenet.FillColor = BlackPurpleColor;
                this.buttonEpicGames.FillColor = BlackPurpleColor;
                this.buttonYoutube.FillColor = BlackPurpleColor;
                this.buttonTwitch.FillColor = BlackPurpleColor;
                this.buttonOBSLauncher.FillColor = BlackPurpleColor;
                this.buttonPlex.FillColor = BlackPurpleColor;
                this.buttonRadarr.FillColor = BlackPurpleColor;
                this.buttonSonarr.FillColor = BlackPurpleColor;
                this.buttonLidarr.FillColor = BlackPurpleColor;
                this.buttonTransmission.FillColor = BlackPurpleColor;
                this.buttonWireguard.FillColor = BlackPurpleColor;

                this.buttonDashlane.BackColor = PurpleColor;
                this.buttonDiscord.BackColor = PurpleColor;
                this.buttonVSCode.BackColor = PurpleColor;
                this.buttonVS.BackColor = PurpleColor;
                this.buttonOutlook.BackColor = PurpleColor;
                this.buttonOfficeHub.BackColor = PurpleColor;
                this.buttonTeams.BackColor = PurpleColor;
                this.buttonOneNote.BackColor = PurpleColor;
                this.buttonMsstore.BackColor = PurpleColor;
                this.buttonChrome.BackColor = PurpleColor;
                this.buttonSignal.BackColor = PurpleColor;
                this.buttonHWM.BackColor = PurpleColor;
                this.buttonLivelyWP.BackColor = PurpleColor;
                this.buttonPaintNet.BackColor = PurpleColor;
                this.buttonSteel.BackColor = PurpleColor;
                this.buttonWindowsTerminal.BackColor = PurpleColor;
                this.buttonHWiNFO64.BackColor = PurpleColor;
                this.buttonHVM.BackColor = PurpleColor;
                this.buttonHotSpot.BackColor = PurpleColor;
                this.buttonSpotify.BackColor = PurpleColor;
                this.buttonBakkesMod.BackColor = PurpleColor;
                this.buttonPorofessor.BackColor = PurpleColor;
                this.buttonSteam.BackColor = PurpleColor;
                this.buttonBattlenet.BackColor = PurpleColor;
                this.buttonEpicGames.BackColor = PurpleColor;
                this.buttonYoutube.BackColor = PurpleColor;
                this.buttonTwitch.BackColor = PurpleColor;
                this.buttonOBSLauncher.BackColor = PurpleColor;
                this.buttonPlex.BackColor = PurpleColor;
                this.buttonRadarr.BackColor = PurpleColor;
                this.buttonSonarr.BackColor = PurpleColor;
                this.buttonLidarr.BackColor = PurpleColor;
                this.buttonTransmission.BackColor = PurpleColor;
                this.buttonWireguard.BackColor = PurpleColor;

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

                this.buttonDashlane.PressedColor = BlackBack3BlueColor;
                this.buttonDiscord.PressedColor = BlackBack3BlueColor;
                this.buttonVSCode.PressedColor = BlackBack3BlueColor;
                this.buttonVS.PressedColor = BlackBack3BlueColor;
                this.buttonOutlook.PressedColor = BlackBack3BlueColor;
                this.buttonOfficeHub.PressedColor = BlackBack3BlueColor;
                this.buttonTeams.PressedColor = BlackBack3BlueColor;
                this.buttonOneNote.PressedColor = BlackBack3BlueColor;
                this.buttonMsstore.PressedColor = BlackBack3BlueColor;
                this.buttonChrome.PressedColor = BlackBack3BlueColor;
                this.buttonSignal.PressedColor = BlackBack3BlueColor;
                this.buttonHWM.PressedColor = BlackBack3BlueColor;
                this.buttonLivelyWP.PressedColor = BlackBack3BlueColor;
                this.buttonPaintNet.PressedColor = BlackBack3BlueColor;
                this.buttonSteel.PressedColor = BlackBack3BlueColor;
                this.buttonWindowsTerminal.PressedColor = BlackBack3BlueColor;
                this.buttonHWiNFO64.PressedColor = BlackBack3BlueColor;
                this.buttonHVM.PressedColor = BlackBack3BlueColor;
                this.buttonHotSpot.PressedColor = BlackBack3BlueColor;
                this.buttonSpotify.PressedColor = BlackBack3BlueColor;
                this.buttonBakkesMod.PressedColor = BlackBack3BlueColor;
                this.buttonPorofessor.PressedColor = BlackBack3BlueColor;
                this.buttonSteam.PressedColor = BlackBack3BlueColor;
                this.buttonBattlenet.PressedColor = BlackBack3BlueColor;
                this.buttonEpicGames.PressedColor = BlackBack3BlueColor;
                this.buttonYoutube.PressedColor = BlackBack3BlueColor;
                this.buttonTwitch.PressedColor = BlackBack3BlueColor;
                this.buttonOBSLauncher.PressedColor = BlackBack3BlueColor;
                this.buttonPlex.PressedColor = BlackBack3BlueColor;
                this.buttonRadarr.PressedColor = BlackBack3BlueColor;
                this.buttonSonarr.PressedColor = BlackBack3BlueColor;
                this.buttonLidarr.PressedColor = BlackBack3BlueColor;
                this.buttonTransmission.PressedColor = BlackBack3BlueColor;
                this.buttonWireguard.PressedColor = BlackBack3BlueColor;

                this.buttonDashlane.ForeColor = Color.Black;
                this.buttonDiscord.ForeColor = Color.Black;
                this.buttonVSCode.ForeColor = Color.Black;
                this.buttonVS.ForeColor = Color.Black;
                this.buttonOutlook.ForeColor = Color.Black;
                this.buttonOfficeHub.ForeColor = Color.Black;
                this.buttonTeams.ForeColor = Color.Black;
                this.buttonOneNote.ForeColor = Color.Black;
                this.buttonMsstore.ForeColor = Color.Black;
                this.buttonChrome.ForeColor = Color.Black;
                this.buttonSignal.ForeColor = Color.Black;
                this.buttonHWM.ForeColor = Color.Black;
                this.buttonLivelyWP.ForeColor = Color.Black;
                this.buttonPaintNet.ForeColor = Color.Black;
                this.buttonSteel.ForeColor = Color.Black;
                this.buttonWindowsTerminal.ForeColor = Color.Black;
                this.buttonHWiNFO64.ForeColor = Color.Black;
                this.buttonHVM.ForeColor = Color.Black;
                this.buttonHotSpot.ForeColor = Color.Black;
                this.buttonSpotify.ForeColor = Color.Black;
                this.buttonBakkesMod.ForeColor = Color.Black;
                this.buttonPorofessor.ForeColor = Color.Black;
                this.buttonSteam.ForeColor = Color.Black;
                this.buttonBattlenet.ForeColor = Color.Black;
                this.buttonEpicGames.ForeColor = Color.Black;
                this.buttonYoutube.ForeColor = Color.Black;
                this.buttonTwitch.ForeColor = Color.Black;
                this.buttonOBSLauncher.ForeColor = Color.Black;
                this.buttonPlex.ForeColor = Color.Black;
                this.buttonRadarr.ForeColor = Color.Black;
                this.buttonSonarr.ForeColor = Color.Black;
                this.buttonLidarr.ForeColor = Color.Black;
                this.buttonTransmission.ForeColor = Color.Black;
                this.buttonWireguard.ForeColor = Color.Black;

                this.buttonDashlane.FillColor = BlackBack3BlueColor;
                this.buttonDiscord.FillColor = BlackBack3BlueColor;
                this.buttonVSCode.FillColor = BlackBack3BlueColor;
                this.buttonVS.FillColor = BlackBack3BlueColor;
                this.buttonOutlook.FillColor = BlackBack3BlueColor;
                this.buttonOfficeHub.FillColor = BlackBack3BlueColor;
                this.buttonTeams.FillColor = BlackBack3BlueColor;
                this.buttonOneNote.FillColor = BlackBack3BlueColor;
                this.buttonMsstore.FillColor = BlackBack3BlueColor;
                this.buttonChrome.FillColor = BlackBack3BlueColor;
                this.buttonSignal.FillColor = BlackBack3BlueColor;
                this.buttonHWM.FillColor = BlackBack3BlueColor;
                this.buttonLivelyWP.FillColor = BlackBack3BlueColor;
                this.buttonPaintNet.FillColor = BlackBack3BlueColor;
                this.buttonSteel.FillColor = BlackBack3BlueColor;
                this.buttonWindowsTerminal.FillColor = BlackBack3BlueColor;
                this.buttonHWiNFO64.FillColor = BlackBack3BlueColor;
                this.buttonHVM.FillColor = BlackBack3BlueColor;
                this.buttonHotSpot.FillColor = BlackBack3BlueColor;
                this.buttonSpotify.FillColor = BlackBack3BlueColor;
                this.buttonBakkesMod.FillColor = BlackBack3BlueColor;
                this.buttonPorofessor.FillColor = BlackBack3BlueColor;
                this.buttonSteam.FillColor = BlackBack3BlueColor;
                this.buttonBattlenet.FillColor = BlackBack3BlueColor;
                this.buttonEpicGames.FillColor = BlackBack3BlueColor;
                this.buttonYoutube.FillColor = BlackBack3BlueColor;
                this.buttonTwitch.FillColor = BlackBack3BlueColor;
                this.buttonOBSLauncher.FillColor = BlackBack3BlueColor;
                this.buttonPlex.FillColor = BlackBack3BlueColor;
                this.buttonRadarr.FillColor = BlackBack3BlueColor;
                this.buttonSonarr.FillColor = BlackBack3BlueColor;
                this.buttonLidarr.FillColor = BlackBack3BlueColor;
                this.buttonTransmission.FillColor = BlackBack3BlueColor;
                this.buttonWireguard.FillColor = BlackBack3BlueColor;

                this.buttonDashlane.BackColor = BlackBack2BlueColor;
                this.buttonDiscord.BackColor = BlackBack2BlueColor;
                this.buttonVSCode.BackColor = BlackBack2BlueColor;
                this.buttonVS.BackColor = BlackBack2BlueColor;
                this.buttonOutlook.BackColor = BlackBack2BlueColor;
                this.buttonOfficeHub.BackColor = BlackBack2BlueColor;
                this.buttonTeams.BackColor = BlackBack2BlueColor;
                this.buttonOneNote.BackColor = BlackBack2BlueColor;
                this.buttonMsstore.BackColor = BlackBack2BlueColor;
                this.buttonChrome.BackColor = BlackBack2BlueColor;
                this.buttonSignal.BackColor = BlackBack2BlueColor;
                this.buttonHWM.BackColor = BlackBack2BlueColor;
                this.buttonLivelyWP.BackColor = BlackBack2BlueColor;
                this.buttonPaintNet.BackColor = BlackBack2BlueColor;
                this.buttonSteel.BackColor = BlackBack2BlueColor;
                this.buttonWindowsTerminal.BackColor = BlackBack2BlueColor;
                this.buttonHWiNFO64.BackColor = BlackBack2BlueColor;
                this.buttonHVM.BackColor = BlackBack2BlueColor;
                this.buttonHotSpot.BackColor = BlackBack2BlueColor;
                this.buttonSpotify.BackColor = BlackBack2BlueColor;
                this.buttonBakkesMod.BackColor = BlackBack2BlueColor;
                this.buttonPorofessor.BackColor = BlackBack2BlueColor;
                this.buttonSteam.BackColor = BlackBack2BlueColor;
                this.buttonBattlenet.BackColor = BlackBack2BlueColor;
                this.buttonEpicGames.BackColor = BlackBack2BlueColor;
                this.buttonYoutube.BackColor = BlackBack2BlueColor;
                this.buttonTwitch.BackColor = BlackBack2BlueColor;
                this.buttonOBSLauncher.BackColor = BlackBack2BlueColor;
                this.buttonPlex.BackColor = BlackBack2BlueColor;
                this.buttonRadarr.BackColor = BlackBack2BlueColor;
                this.buttonSonarr.BackColor = BlackBack2BlueColor;
                this.buttonLidarr.BackColor = BlackBack2BlueColor;
                this.buttonTransmission.BackColor = BlackBack2BlueColor;
                this.buttonWireguard.BackColor = BlackBack2BlueColor;

                this.buttonEXIT.BackColor = BlackBack2BlueColor;
                this.buttonEXIT.FillColor = BlackBack3BlueColor;
                this.buttonEXIT.ForeColor = Color.Black;

                this.buttonSTART.BackColor = BlackBack2BlueColor;
                this.buttonSTART.FillColor = BlackBack3BlueColor;
                this.buttonSTART.ForeColor = Color.Black;

                this.Icon = Properties.Resources.LauncherForAll;
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

                this.Opacity = 95;

                this.BackColor = BlackBack2BlueColor;
                this.pictureBox1.BackgroundImage = Properties.Resources.Title1;
                this.label1.ForeColor = Color.Black;
                this.buttonRedMod.BackgroundImage = Properties.Resources.blueMod;

                this.buttonDashlane.PressedColor = BlackBack3BlueColor;
                this.buttonDiscord.PressedColor = BlackBack3BlueColor;
                this.buttonVSCode.PressedColor = BlackBack3BlueColor;
                this.buttonVS.PressedColor = BlackBack3BlueColor;
                this.buttonOutlook.PressedColor = BlackBack3BlueColor;
                this.buttonOfficeHub.PressedColor = BlackBack3BlueColor;
                this.buttonTeams.PressedColor = BlackBack3BlueColor;
                this.buttonOneNote.PressedColor = BlackBack3BlueColor;
                this.buttonMsstore.PressedColor = BlackBack3BlueColor;
                this.buttonChrome.PressedColor = BlackBack3BlueColor;
                this.buttonSignal.PressedColor = BlackBack3BlueColor;
                this.buttonHWM.PressedColor = BlackBack3BlueColor;
                this.buttonLivelyWP.PressedColor = BlackBack3BlueColor;
                this.buttonPaintNet.PressedColor = BlackBack3BlueColor;
                this.buttonSteel.PressedColor = BlackBack3BlueColor;
                this.buttonWindowsTerminal.PressedColor = BlackBack3BlueColor;
                this.buttonHWiNFO64.PressedColor = BlackBack3BlueColor;
                this.buttonHVM.PressedColor = BlackBack3BlueColor;
                this.buttonHotSpot.PressedColor = BlackBack3BlueColor;
                this.buttonSpotify.PressedColor = BlackBack3BlueColor;
                this.buttonBakkesMod.PressedColor = BlackBack3BlueColor;
                this.buttonPorofessor.PressedColor = BlackBack3BlueColor;
                this.buttonSteam.PressedColor = BlackBack3BlueColor;
                this.buttonBattlenet.PressedColor = BlackBack3BlueColor;
                this.buttonEpicGames.PressedColor = BlackBack3BlueColor;
                this.buttonYoutube.PressedColor = BlackBack3BlueColor;
                this.buttonTwitch.PressedColor = BlackBack3BlueColor;
                this.buttonOBSLauncher.PressedColor = BlackBack3BlueColor;
                this.buttonPlex.PressedColor = BlackBack3BlueColor;
                this.buttonRadarr.PressedColor = BlackBack3BlueColor;
                this.buttonSonarr.PressedColor = BlackBack3BlueColor;
                this.buttonLidarr.PressedColor = BlackBack3BlueColor;
                this.buttonTransmission.PressedColor = BlackBack3BlueColor;
                this.buttonWireguard.PressedColor = BlackBack3BlueColor;

                this.buttonDashlane.ForeColor = Color.Black;
                this.buttonDiscord.ForeColor = Color.Black;
                this.buttonVSCode.ForeColor = Color.Black;
                this.buttonVS.ForeColor = Color.Black;
                this.buttonOutlook.ForeColor = Color.Black;
                this.buttonOfficeHub.ForeColor = Color.Black;
                this.buttonTeams.ForeColor = Color.Black;
                this.buttonOneNote.ForeColor = Color.Black;
                this.buttonMsstore.ForeColor = Color.Black;
                this.buttonChrome.ForeColor = Color.Black;
                this.buttonSignal.ForeColor = Color.Black;
                this.buttonHWM.ForeColor = Color.Black;
                this.buttonLivelyWP.ForeColor = Color.Black;
                this.buttonPaintNet.ForeColor = Color.Black;
                this.buttonSteel.ForeColor = Color.Black;
                this.buttonWindowsTerminal.ForeColor = Color.Black;
                this.buttonHWiNFO64.ForeColor = Color.Black;
                this.buttonHVM.ForeColor = Color.Black;
                this.buttonHotSpot.ForeColor = Color.Black;
                this.buttonSpotify.ForeColor = Color.Black;
                this.buttonBakkesMod.ForeColor = Color.Black;
                this.buttonPorofessor.ForeColor = Color.Black;
                this.buttonSteam.ForeColor = Color.Black;
                this.buttonBattlenet.ForeColor = Color.Black;
                this.buttonEpicGames.ForeColor = Color.Black;
                this.buttonYoutube.ForeColor = Color.Black;
                this.buttonTwitch.ForeColor = Color.Black;
                this.buttonOBSLauncher.ForeColor = Color.Black;
                this.buttonPlex.ForeColor = Color.Black;
                this.buttonRadarr.ForeColor = Color.Black;
                this.buttonSonarr.ForeColor = Color.Black;
                this.buttonLidarr.ForeColor = Color.Black;
                this.buttonTransmission.ForeColor = Color.Black;
                this.buttonWireguard.ForeColor = Color.Black;

                this.buttonDashlane.FillColor = BlackBack3BlueColor;
                this.buttonDiscord.FillColor = BlackBack3BlueColor;
                this.buttonVSCode.FillColor = BlackBack3BlueColor;
                this.buttonVS.FillColor = BlackBack3BlueColor;
                this.buttonOutlook.FillColor = BlackBack3BlueColor;
                this.buttonOfficeHub.FillColor = BlackBack3BlueColor;
                this.buttonTeams.FillColor = BlackBack3BlueColor;
                this.buttonOneNote.FillColor = BlackBack3BlueColor;
                this.buttonMsstore.FillColor = BlackBack3BlueColor;
                this.buttonChrome.FillColor = BlackBack3BlueColor;
                this.buttonSignal.FillColor = BlackBack3BlueColor;
                this.buttonHWM.FillColor = BlackBack3BlueColor;
                this.buttonLivelyWP.FillColor = BlackBack3BlueColor;
                this.buttonPaintNet.FillColor = BlackBack3BlueColor;
                this.buttonSteel.FillColor = BlackBack3BlueColor;
                this.buttonWindowsTerminal.FillColor = BlackBack3BlueColor;
                this.buttonHWiNFO64.FillColor = BlackBack3BlueColor;
                this.buttonHVM.FillColor = BlackBack3BlueColor;
                this.buttonHotSpot.FillColor = BlackBack3BlueColor;
                this.buttonSpotify.FillColor = BlackBack3BlueColor;
                this.buttonBakkesMod.FillColor = BlackBack3BlueColor;
                this.buttonPorofessor.FillColor = BlackBack3BlueColor;
                this.buttonSteam.FillColor = BlackBack3BlueColor;
                this.buttonBattlenet.FillColor = BlackBack3BlueColor;
                this.buttonEpicGames.FillColor = BlackBack3BlueColor;
                this.buttonYoutube.FillColor = BlackBack3BlueColor;
                this.buttonTwitch.FillColor = BlackBack3BlueColor;
                this.buttonOBSLauncher.FillColor = BlackBack3BlueColor;
                this.buttonPlex.FillColor = BlackBack3BlueColor;
                this.buttonRadarr.FillColor = BlackBack3BlueColor;
                this.buttonSonarr.FillColor = BlackBack3BlueColor;
                this.buttonLidarr.FillColor = BlackBack3BlueColor;
                this.buttonTransmission.FillColor = BlackBack3BlueColor;
                this.buttonWireguard.FillColor = BlackBack3BlueColor;

                this.buttonDashlane.BackColor = BlackBack2BlueColor;
                this.buttonDiscord.BackColor = BlackBack2BlueColor;
                this.buttonVSCode.BackColor = BlackBack2BlueColor;
                this.buttonVS.BackColor = BlackBack2BlueColor;
                this.buttonOutlook.BackColor = BlackBack2BlueColor;
                this.buttonOfficeHub.BackColor = BlackBack2BlueColor;
                this.buttonTeams.BackColor = BlackBack2BlueColor;
                this.buttonOneNote.BackColor = BlackBack2BlueColor;
                this.buttonMsstore.BackColor = BlackBack2BlueColor;
                this.buttonChrome.BackColor = BlackBack2BlueColor;
                this.buttonSignal.BackColor = BlackBack2BlueColor;
                this.buttonHWM.BackColor = BlackBack2BlueColor;
                this.buttonLivelyWP.BackColor = BlackBack2BlueColor;
                this.buttonPaintNet.BackColor = BlackBack2BlueColor;
                this.buttonSteel.BackColor = BlackBack2BlueColor;
                this.buttonWindowsTerminal.BackColor = BlackBack2BlueColor;
                this.buttonHWiNFO64.BackColor = BlackBack2BlueColor;
                this.buttonHVM.BackColor = BlackBack2BlueColor;
                this.buttonHotSpot.BackColor = BlackBack2BlueColor;
                this.buttonSpotify.BackColor = BlackBack2BlueColor;
                this.buttonBakkesMod.BackColor = BlackBack2BlueColor;
                this.buttonPorofessor.BackColor = BlackBack2BlueColor;
                this.buttonSteam.BackColor = BlackBack2BlueColor;
                this.buttonBattlenet.BackColor = BlackBack2BlueColor;
                this.buttonEpicGames.BackColor = BlackBack2BlueColor;
                this.buttonYoutube.BackColor = BlackBack2BlueColor;
                this.buttonTwitch.BackColor = BlackBack2BlueColor;
                this.buttonOBSLauncher.BackColor = BlackBack2BlueColor;
                this.buttonPlex.BackColor = BlackBack2BlueColor;
                this.buttonRadarr.BackColor = BlackBack2BlueColor;
                this.buttonSonarr.BackColor = BlackBack2BlueColor;
                this.buttonLidarr.BackColor = BlackBack2BlueColor;
                this.buttonTransmission.BackColor = BlackBack2BlueColor;
                this.buttonWireguard.BackColor = BlackBack2BlueColor;

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

                this.buttonDashlane.PressedColor = PurpleColor;
                this.buttonDiscord.PressedColor = PurpleColor;
                this.buttonVSCode.PressedColor = PurpleColor;
                this.buttonVS.PressedColor = PurpleColor;
                this.buttonOutlook.PressedColor = PurpleColor;
                this.buttonOfficeHub.PressedColor = PurpleColor;
                this.buttonTeams.PressedColor = PurpleColor;
                this.buttonOneNote.PressedColor = PurpleColor;
                this.buttonMsstore.PressedColor = PurpleColor;
                this.buttonChrome.PressedColor = PurpleColor;
                this.buttonSignal.PressedColor = PurpleColor;
                this.buttonHWM.PressedColor = PurpleColor;
                this.buttonLivelyWP.PressedColor = PurpleColor;
                this.buttonPaintNet.PressedColor = PurpleColor;
                this.buttonSteel.PressedColor = PurpleColor;
                this.buttonWindowsTerminal.PressedColor = PurpleColor;
                this.buttonHWiNFO64.PressedColor = PurpleColor;
                this.buttonHVM.PressedColor = PurpleColor;
                this.buttonHotSpot.PressedColor = PurpleColor;
                this.buttonSpotify.PressedColor = PurpleColor;
                this.buttonBakkesMod.PressedColor = PurpleColor;
                this.buttonPorofessor.PressedColor = PurpleColor;
                this.buttonSteam.PressedColor = PurpleColor;
                this.buttonBattlenet.PressedColor = PurpleColor;
                this.buttonEpicGames.PressedColor = PurpleColor;
                this.buttonYoutube.PressedColor = PurpleColor;
                this.buttonTwitch.PressedColor = PurpleColor;
                this.buttonOBSLauncher.PressedColor = PurpleColor;
                this.buttonPlex.PressedColor = PurpleColor;
                this.buttonRadarr.PressedColor = PurpleColor;
                this.buttonSonarr.PressedColor = PurpleColor;
                this.buttonLidarr.PressedColor = PurpleColor;
                this.buttonTransmission.PressedColor = PurpleColor;
                this.buttonWireguard.PressedColor = PurpleColor;

                this.buttonDashlane.ForeColor = WhiteColor;
                this.buttonDiscord.ForeColor = WhiteColor;
                this.buttonVSCode.ForeColor = WhiteColor;
                this.buttonVS.ForeColor = WhiteColor;
                this.buttonOutlook.ForeColor = WhiteColor;
                this.buttonOfficeHub.ForeColor = WhiteColor;
                this.buttonTeams.ForeColor = WhiteColor;
                this.buttonOneNote.ForeColor = WhiteColor;
                this.buttonMsstore.ForeColor = WhiteColor;
                this.buttonChrome.ForeColor = WhiteColor;
                this.buttonSignal.ForeColor = WhiteColor;
                this.buttonHWM.ForeColor = WhiteColor;
                this.buttonLivelyWP.ForeColor = WhiteColor;
                this.buttonPaintNet.ForeColor = WhiteColor;
                this.buttonSteel.ForeColor = WhiteColor;
                this.buttonWindowsTerminal.ForeColor = WhiteColor;
                this.buttonHWiNFO64.ForeColor = WhiteColor;
                this.buttonHVM.ForeColor = WhiteColor;
                this.buttonHotSpot.ForeColor = WhiteColor;
                this.buttonSpotify.ForeColor = WhiteColor;
                this.buttonBakkesMod.ForeColor = WhiteColor;
                this.buttonPorofessor.ForeColor = WhiteColor;
                this.buttonSteam.ForeColor = WhiteColor;
                this.buttonBattlenet.ForeColor = WhiteColor;
                this.buttonEpicGames.ForeColor = WhiteColor;
                this.buttonYoutube.ForeColor = WhiteColor;
                this.buttonTwitch.ForeColor = WhiteColor;
                this.buttonOBSLauncher.ForeColor = WhiteColor;
                this.buttonPlex.ForeColor = WhiteColor;
                this.buttonRadarr.ForeColor = WhiteColor;
                this.buttonSonarr.ForeColor = WhiteColor;
                this.buttonLidarr.ForeColor = WhiteColor;
                this.buttonTransmission.ForeColor = WhiteColor;
                this.buttonWireguard.ForeColor = WhiteColor;

                this.buttonDashlane.FillColor = BlackPurpleColor;
                this.buttonDiscord.FillColor = BlackPurpleColor;
                this.buttonVSCode.FillColor = BlackPurpleColor;
                this.buttonVS.FillColor = BlackPurpleColor;
                this.buttonOutlook.FillColor = BlackPurpleColor;
                this.buttonOfficeHub.FillColor = BlackPurpleColor;
                this.buttonTeams.FillColor = BlackPurpleColor;
                this.buttonOneNote.FillColor = BlackPurpleColor;
                this.buttonMsstore.FillColor = BlackPurpleColor;
                this.buttonChrome.FillColor = BlackPurpleColor;
                this.buttonSignal.FillColor = BlackPurpleColor;
                this.buttonHWM.FillColor = BlackPurpleColor;
                this.buttonLivelyWP.FillColor = BlackPurpleColor;
                this.buttonPaintNet.FillColor = BlackPurpleColor;
                this.buttonSteel.FillColor = BlackPurpleColor;
                this.buttonWindowsTerminal.FillColor = BlackPurpleColor;
                this.buttonHWiNFO64.FillColor = BlackPurpleColor;
                this.buttonHVM.FillColor = BlackPurpleColor;
                this.buttonHotSpot.FillColor = BlackPurpleColor;
                this.buttonSpotify.FillColor = BlackPurpleColor;
                this.buttonBakkesMod.FillColor = BlackPurpleColor;
                this.buttonPorofessor.FillColor = BlackPurpleColor;
                this.buttonSteam.FillColor = BlackPurpleColor;
                this.buttonBattlenet.FillColor = BlackPurpleColor;
                this.buttonEpicGames.FillColor = BlackPurpleColor;
                this.buttonYoutube.FillColor = BlackPurpleColor;
                this.buttonTwitch.FillColor = BlackPurpleColor;
                this.buttonOBSLauncher.FillColor = BlackPurpleColor;
                this.buttonPlex.FillColor = BlackPurpleColor;
                this.buttonRadarr.FillColor = BlackPurpleColor;
                this.buttonSonarr.FillColor = BlackPurpleColor;
                this.buttonLidarr.FillColor = BlackPurpleColor;
                this.buttonTransmission.FillColor = BlackPurpleColor;
                this.buttonWireguard.FillColor = BlackPurpleColor;

                this.buttonDashlane.BackColor = PurpleColor;
                this.buttonDiscord.BackColor = PurpleColor;
                this.buttonVSCode.BackColor = PurpleColor;
                this.buttonVS.BackColor = PurpleColor;
                this.buttonOutlook.BackColor = PurpleColor;
                this.buttonOfficeHub.BackColor = PurpleColor;
                this.buttonTeams.BackColor = PurpleColor;
                this.buttonOneNote.BackColor = PurpleColor;
                this.buttonMsstore.BackColor = PurpleColor;
                this.buttonChrome.BackColor = PurpleColor;
                this.buttonSignal.BackColor = PurpleColor;
                this.buttonHWM.BackColor = PurpleColor;
                this.buttonLivelyWP.BackColor = PurpleColor;
                this.buttonPaintNet.BackColor = PurpleColor;
                this.buttonSteel.BackColor = PurpleColor;
                this.buttonWindowsTerminal.BackColor = PurpleColor;
                this.buttonHWiNFO64.BackColor = PurpleColor;
                this.buttonHVM.BackColor = PurpleColor;
                this.buttonHotSpot.BackColor = PurpleColor;
                this.buttonSpotify.BackColor = PurpleColor;
                this.buttonBakkesMod.BackColor = PurpleColor;
                this.buttonPorofessor.BackColor = PurpleColor;
                this.buttonSteam.BackColor = PurpleColor;
                this.buttonBattlenet.BackColor = PurpleColor;
                this.buttonEpicGames.BackColor = PurpleColor;
                this.buttonYoutube.BackColor = PurpleColor;
                this.buttonTwitch.BackColor = PurpleColor;
                this.buttonOBSLauncher.BackColor = PurpleColor;
                this.buttonPlex.BackColor = PurpleColor;
                this.buttonRadarr.BackColor = PurpleColor;
                this.buttonSonarr.BackColor = PurpleColor;
                this.buttonLidarr.BackColor = PurpleColor;
                this.buttonTransmission.BackColor = PurpleColor;
                this.buttonWireguard.BackColor = PurpleColor;

                this.buttonEXIT.BackColor = PurpleColor;
                this.buttonEXIT.FillColor = BlackPurpleColor;
                this.buttonEXIT.ForeColor = WhiteColor;

                this.buttonSTART.BackColor = PurpleColor;
                this.buttonSTART.FillColor = BlackPurpleColor;
                this.buttonSTART.ForeColor = WhiteColor;

                this.Icon = Properties.Resources.RedMod_Logo;
            }
        }

        private void Games_Click(object sender, EventArgs e)
        {
            this.frmLoader.Controls.Clear();
            frmBrowseApps frmBrowseApps_vrb = new frmBrowseApps() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmBrowseApps_vrb.FormBorderStyle = FormBorderStyle.None;
            this.frmLoader.Controls.Add(frmBrowseApps_vrb);
            frmBrowseApps_vrb.Show();
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

        private void buttonDashlane_Click(object sender, EventArgs e)
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
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\Dashlane.config", fdlg.FileName);
                }
                else
                {
                    Directory.CreateDirectory(@"\LauncherForAll\PathList");
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\Dashlane.config", fdlg.FileName);
                }
            }
        }

        private void buttonDiscord_Click(object sender, EventArgs e)
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
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\Discord.config", fdlg.FileName);
                }
                else
                {
                    Directory.CreateDirectory(@"\LauncherForAll\PathList");
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\Discord.config", fdlg.FileName);
                }
            }
        }

        private void buttonVSCode_Click(object sender, EventArgs e)
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
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\VSCode.config", fdlg.FileName);
                }
                else
                {
                    Directory.CreateDirectory(@"\LauncherForAll\PathList");
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\VSCode.config", fdlg.FileName);
                }
            }
        }

        private void buttonVS_Click(object sender, EventArgs e)
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
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\VS.config", fdlg.FileName);
                }
                else
                {
                    Directory.CreateDirectory(@"\LauncherForAll\PathList");
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\VS.config", fdlg.FileName);
                }
            }
        }

        private void buttonOutlook_Click(object sender, EventArgs e)
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
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\Outlook.config", fdlg.FileName);
                }
                else
                {
                    Directory.CreateDirectory(@"\LauncherForAll\PathList");
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\Outlook.config", fdlg.FileName);
                }
            }
        }

        private void buttonOfficeHub_Click(object sender, EventArgs e)
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
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\OfficeHub.config", fdlg.FileName);
                }
                else
                {
                    Directory.CreateDirectory(@"\LauncherForAll\PathList");
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\OfficeHub.config", fdlg.FileName);
                }
            }
        }

        private void buttonTeams_Click(object sender, EventArgs e)
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
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\Teams.config", fdlg.FileName);
                }
                else
                {
                    Directory.CreateDirectory(@"\LauncherForAll\PathList");
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\Teams.config", fdlg.FileName);
                }
            }
        }

        private void buttonOneNote_Click(object sender, EventArgs e)
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
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\OneNote.config", fdlg.FileName);
                }
                else
                {
                    Directory.CreateDirectory(@"\LauncherForAll\PathList");
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\OneNote.config", fdlg.FileName);
                }
            }
        }

        private void buttonMsstore_Click(object sender, EventArgs e)
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
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\Msstore.config", fdlg.FileName);
                }
                else
                {
                    Directory.CreateDirectory(@"\LauncherForAll\PathList");
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\Msstore.config", fdlg.FileName);
                }
            }
        }

        private void buttonChrome_Click(object sender, EventArgs e)
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
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\Chrome.config", fdlg.FileName);
                }
                else
                {
                    Directory.CreateDirectory(@"\LauncherForAll\PathList");
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\Chrome.config", fdlg.FileName);
                }
            }
        }

        private void buttonSignal_Click(object sender, EventArgs e)
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
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\Signal.config", fdlg.FileName);
                }
                else
                {
                    Directory.CreateDirectory(@"\LauncherForAll\PathList");
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\Signal.config", fdlg.FileName);
                }
            }
        }

        private void buttonHWM_Click(object sender, EventArgs e)
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
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\HWM.config", fdlg.FileName);
                }
                else
                {
                    Directory.CreateDirectory(@"\LauncherForAll\PathList");
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\HWM.config", fdlg.FileName);
                }
            }
        }

        private void buttonLivelyWP_Click(object sender, EventArgs e)
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
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\LivelyWP.config", fdlg.FileName);
                }
                else
                {
                    Directory.CreateDirectory(@"\LauncherForAll\PathList");
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\LivelyWP.config", fdlg.FileName);
                }
            }
        }

        private void buttonPaintNet_Click(object sender, EventArgs e)
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
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\LivelyWP.config", fdlg.FileName);
                }
                else
                {
                    Directory.CreateDirectory(@"\LauncherForAll\PathList");
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\LivelyWP.config", fdlg.FileName);
                }
            }
        }

        private void buttonSteel_Click(object sender, EventArgs e)
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
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\Steel.config", fdlg.FileName);
                }
                else
                {
                    Directory.CreateDirectory(@"\LauncherForAll\PathList");
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\Steel.config", fdlg.FileName);
                }
            }
        }

        private void buttonWindowsTerminal_Click(object sender, EventArgs e)
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
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\WindowsTerminal.config", fdlg.FileName);
                }
                else
                {
                    Directory.CreateDirectory(@"\LauncherForAll\PathList");
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\WindowsTerminal.config", fdlg.FileName);
                }
            }
        }

        private void buttonHWiNFO64_Click(object sender, EventArgs e)
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
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\HWiNFO64.config", fdlg.FileName);
                }
                else
                {
                    Directory.CreateDirectory(@"\LauncherForAll\PathList");
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\HWiNFO64.config", fdlg.FileName);
                }
            }
        }

        private void buttonHVM_Click(object sender, EventArgs e)
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
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\HVM.config", fdlg.FileName);
                }
                else
                {
                    Directory.CreateDirectory(@"\LauncherForAll\PathList");
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\HVM.config", fdlg.FileName);
                }
            }
        }

        private void buttonHotSpot_Click(object sender, EventArgs e)
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
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\HotSpot.config", fdlg.FileName);
                }
                else
                {
                    Directory.CreateDirectory(@"\LauncherForAll\PathList");
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\HotSpot.config", fdlg.FileName);
                }
            }
        }

        private void buttonSpotify_Click(object sender, EventArgs e)
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
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\Spotify.config", fdlg.FileName);
                }
                else
                {
                    Directory.CreateDirectory(@"\LauncherForAll\PathList");
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\Spotify.config", fdlg.FileName);
                }
            }
        }

        private void buttonBakkesMod_Click(object sender, EventArgs e)
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
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\BakkesMod.config", fdlg.FileName);
                }
                else
                {
                    Directory.CreateDirectory(@"\LauncherForAll\PathList");
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\BakkesMod.config", fdlg.FileName);
                }
            }
        }

        private void buttonPorofessor_Click(object sender, EventArgs e)
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
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\Porofessor.config", fdlg.FileName);
                }
                else
                {
                    Directory.CreateDirectory(@"\LauncherForAll\PathList");
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\Porofessor.config", fdlg.FileName);
                }
            }
        }

        private void buttonSteam_Click(object sender, EventArgs e)
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
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\Steam.config", fdlg.FileName);
                }
                else
                {
                    Directory.CreateDirectory(@"\LauncherForAll\PathList");
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\Steam.config", fdlg.FileName);
                }
            }
        }

        private void buttonBattlenet_Click(object sender, EventArgs e)
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
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\Battlenet.config", fdlg.FileName);
                }
                else
                {
                    Directory.CreateDirectory(@"\LauncherForAll\PathList");
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\Battlenet.config", fdlg.FileName);
                }
            }
        }

        private void buttonEpicGames_Click(object sender, EventArgs e)
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
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\EpicGames.config", fdlg.FileName);
                }
                else
                {
                    Directory.CreateDirectory(@"\LauncherForAll\PathList");
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\EpicGames.config", fdlg.FileName);
                }
            }
        }

        private void buttonYoutube_Click(object sender, EventArgs e)
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
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\Youtube.config", fdlg.FileName);
                }
                else
                {
                    Directory.CreateDirectory(@"\LauncherForAll\PathList");
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\Youtube.config", fdlg.FileName);
                }
            }
        }

        private void buttonTwitch_Click(object sender, EventArgs e)
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
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\Twitch.config", fdlg.FileName);
                }
                else
                {
                    Directory.CreateDirectory(@"\LauncherForAll\PathList");
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\Twitch.config", fdlg.FileName);
                }
            }
        }

        private void buttonOBSLauncher_Click(object sender, EventArgs e)
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
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\OBSLauncher.config", fdlg.FileName);
                }
                else
                {
                    Directory.CreateDirectory(@"\LauncherForAll\PathList");
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\OBSLauncher.config", fdlg.FileName);
                }
            }
        }

        private void buttonPlex_Click(object sender, EventArgs e)
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
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\Plex.config", fdlg.FileName);
                }
                else
                {
                    Directory.CreateDirectory(@"\LauncherForAll\PathList");
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\Plex.config", fdlg.FileName);
                }
            }
        }

        private void buttonRadarr_Click(object sender, EventArgs e)
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
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\Radarr.config", fdlg.FileName);
                }
                else
                {
                    Directory.CreateDirectory(@"\LauncherForAll\PathList");
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\Radarr.config", fdlg.FileName);
                }
            }
        }

        private void buttonSonarr_Click(object sender, EventArgs e)
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
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\Sonarr.config", fdlg.FileName);
                }
                else
                {
                    Directory.CreateDirectory(@"\LauncherForAll\PathList");
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\Sonarr.config", fdlg.FileName);
                }
            }
        }

        private void buttonLidarr_Click(object sender, EventArgs e)
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
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\Lidarr.config", fdlg.FileName);
                }
                else
                {
                    Directory.CreateDirectory(@"\LauncherForAll\PathList");
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\Lidarr.config", fdlg.FileName);
                }
            }
        }

        private void buttonTransmission_Click(object sender, EventArgs e)
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
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\Transmission.config", fdlg.FileName);
                }
                else
                {
                    Directory.CreateDirectory(@"\LauncherForAll\PathList");
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\Transmission.config", fdlg.FileName);
                }
            }
        }

        private void buttonWireguard_Click(object sender, EventArgs e)
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
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\Wireguard.config", fdlg.FileName);
                }
                else
                {
                    Directory.CreateDirectory(@"\LauncherForAll\PathList");
                    File.WriteAllText(programData + @"\LauncherForAll\PathList\Wireguard.config", fdlg.FileName);
                }
            }
        }
    }
}
