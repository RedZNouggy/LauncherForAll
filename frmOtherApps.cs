using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LauncherForAll
{
    public partial class frmOtherApps : Form
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

        // BlueMod Colors
        // 46 51 73 Blue
        private Color BackBlueColor = Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
        // 28 37 55 BlackBlue
        private Color BackBlackBlueColor = Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
        // 0 126 249 Blue
        private Color BlueColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));

        public frmOtherApps()
        {
            InitializeComponent();
        }
        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        private void frmOtherApps_Load(object sender, EventArgs e)
        {
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

            // ButtonsFlat ?
            if (File.Exists(programData + @"\LauncherForAll\Set_AppsFlat.config"))
            {
                this.buttonAWS.FlatAppearance.BorderSize = 0;
                this.buttonAWS.FlatStyle = FlatStyle.Flat;

                this.buttonDashlane.FlatAppearance.BorderSize = 0 ;
                this.buttonDashlane.FlatStyle = FlatStyle.Flat;

                this.buttonDiscord.FlatAppearance.BorderSize = 0;
                this.buttonDiscord.FlatStyle = FlatStyle.Flat;

                this.buttonVSCode.FlatAppearance.BorderSize = 0;
                this.buttonVSCode.FlatStyle = FlatStyle.Flat;

                this.buttonVS.FlatAppearance.BorderSize = 0;
                this.buttonVS.FlatStyle = FlatStyle.Flat;
                
                this.buttonOutlook.FlatAppearance.BorderSize = 0;
                this.buttonOutlook.FlatStyle = FlatStyle.Flat;

                this.buttonOfficeHub.FlatAppearance.BorderSize = 0;
                this.buttonOfficeHub.FlatStyle = FlatStyle.Flat;

                this.buttonTeams.FlatAppearance.BorderSize = 0;
                this.buttonTeams.FlatStyle = FlatStyle.Flat;

                this.buttonOneNote.FlatAppearance.BorderSize = 0;
                this.buttonOneNote.FlatStyle = FlatStyle.Flat;

                this.buttonMsstore.FlatAppearance.BorderSize = 0;
                this.buttonMsstore.FlatStyle = FlatStyle.Flat;

                this.buttonChrome.FlatAppearance.BorderSize = 0;
                this.buttonChrome.FlatStyle = FlatStyle.Flat;

                this.buttonSignal.FlatAppearance.BorderSize = 0;
                this.buttonSignal.FlatStyle = FlatStyle.Flat;

                this.buttonHWM.FlatAppearance.BorderSize = 0;
                this.buttonHWM.FlatStyle = FlatStyle.Flat;

                this.buttonLivelyWP.FlatAppearance.BorderSize = 0;
                this.buttonLivelyWP.FlatStyle = FlatStyle.Flat;

                this.buttonDS4.FlatAppearance.BorderSize = 0;
                this.buttonDS4.FlatStyle = FlatStyle.Flat;

                this.buttonWindowsTerminal.FlatAppearance.BorderSize = 0;
                this.buttonWindowsTerminal.FlatStyle = FlatStyle.Flat;

                this.buttonHWiNFO64.FlatAppearance.BorderSize = 0;
                this.buttonHWiNFO64.FlatStyle = FlatStyle.Flat;

                this.buttonHVM.FlatAppearance.BorderSize = 0;
                this.buttonHVM.FlatStyle = FlatStyle.Flat;

                this.buttonHotSpot.FlatAppearance.BorderSize = 0;
                this.buttonHotSpot.FlatStyle = FlatStyle.Flat;

                this.buttonSpotify.FlatAppearance.BorderSize = 0;
                this.buttonSpotify.FlatStyle = FlatStyle.Flat;

                this.buttonBakkesMod.FlatAppearance.BorderSize = 0;
                this.buttonBakkesMod.FlatStyle = FlatStyle.Flat;

                this.buttonPorofessor.FlatAppearance.BorderSize = 0;
                this.buttonPorofessor.FlatStyle = FlatStyle.Flat;

                this.buttonSteam.FlatAppearance.BorderSize = 0;
                this.buttonSteam.FlatStyle = FlatStyle.Flat;

                this.buttonBattlenet.FlatAppearance.BorderSize = 0;
                this.buttonBattlenet.FlatStyle = FlatStyle.Flat;

                this.buttonEpicGames.FlatAppearance.BorderSize = 0;
                this.buttonEpicGames.FlatStyle = FlatStyle.Flat;

                this.buttonTautulli.FlatAppearance.BorderSize = 0;
                this.buttonTautulli.FlatStyle = FlatStyle.Flat;

                this.buttonOpenVPN.FlatAppearance.BorderSize = 0;
                this.buttonOpenVPN.FlatStyle = FlatStyle.Flat;

                this.buttonWireguard.FlatAppearance.BorderSize = 0;
                this.buttonWireguard.FlatStyle = FlatStyle.Flat;

                this.buttonYoutube.FlatAppearance.BorderSize = 0;
                this.buttonYoutube.FlatStyle = FlatStyle.Flat;

                this.buttonTwitch.FlatAppearance.BorderSize = 0;
                this.buttonTwitch.FlatStyle = FlatStyle.Flat;

                this.buttonVMWare.FlatAppearance.BorderSize = 0;
                this.buttonVMWare.FlatStyle = FlatStyle.Flat;

                this.buttonPlex.FlatAppearance.BorderSize = 0;
                this.buttonPlex.FlatStyle = FlatStyle.Flat;

                this.buttonRadarr.FlatAppearance.BorderSize = 0;
                this.buttonRadarr.FlatStyle = FlatStyle.Flat;

                this.buttonSonarr.FlatAppearance.BorderSize = 0;
                this.buttonSonarr.FlatStyle = FlatStyle.Flat;

                this.buttonTransmission.FlatAppearance.BorderSize = 0;
                this.buttonTransmission.FlatStyle = FlatStyle.Flat;

                this.buttonOwncloud.FlatAppearance.BorderSize = 0;
                this.buttonOwncloud.FlatStyle = FlatStyle.Flat;

            }
            else
            {
                this.buttonAWS.FlatAppearance.BorderSize = 1;
                this.buttonAWS.FlatStyle = FlatStyle.Popup;

                this.buttonDashlane.FlatAppearance.BorderSize = 1;
                this.buttonDashlane.FlatStyle = FlatStyle.Popup;

                this.buttonDiscord.FlatAppearance.BorderSize = 1;
                this.buttonDiscord.FlatStyle = FlatStyle.Popup;

                this.buttonVSCode.FlatAppearance.BorderSize = 1;
                this.buttonVSCode.FlatStyle = FlatStyle.Popup;

                this.buttonVS.FlatAppearance.BorderSize = 1;
                this.buttonVS.FlatStyle = FlatStyle.Popup;

                this.buttonOutlook.FlatAppearance.BorderSize = 1;
                this.buttonOutlook.FlatStyle = FlatStyle.Popup;

                this.buttonOfficeHub.FlatAppearance.BorderSize = 1;
                this.buttonOfficeHub.FlatStyle = FlatStyle.Popup;

                this.buttonTeams.FlatAppearance.BorderSize = 1;
                this.buttonTeams.FlatStyle = FlatStyle.Popup;

                this.buttonOneNote.FlatAppearance.BorderSize = 1;
                this.buttonOneNote.FlatStyle = FlatStyle.Popup;

                this.buttonMsstore.FlatAppearance.BorderSize = 1;
                this.buttonMsstore.FlatStyle = FlatStyle.Popup;

                this.buttonChrome.FlatAppearance.BorderSize = 1;
                this.buttonChrome.FlatStyle = FlatStyle.Popup;

                this.buttonSignal.FlatAppearance.BorderSize = 1;
                this.buttonSignal.FlatStyle = FlatStyle.Popup;

                this.buttonHWM.FlatAppearance.BorderSize = 1;
                this.buttonHWM.FlatStyle = FlatStyle.Popup;

                this.buttonLivelyWP.FlatAppearance.BorderSize = 1;
                this.buttonLivelyWP.FlatStyle = FlatStyle.Popup;

                this.buttonDS4.FlatAppearance.BorderSize = 1;
                this.buttonDS4.FlatStyle = FlatStyle.Popup;

                this.buttonWindowsTerminal.FlatAppearance.BorderSize = 1;
                this.buttonWindowsTerminal.FlatStyle = FlatStyle.Popup;

                this.buttonHWiNFO64.FlatAppearance.BorderSize = 1;
                this.buttonHWiNFO64.FlatStyle = FlatStyle.Popup;

                this.buttonHVM.FlatAppearance.BorderSize = 1;
                this.buttonHVM.FlatStyle = FlatStyle.Popup;

                this.buttonHotSpot.FlatAppearance.BorderSize = 1;
                this.buttonHotSpot.FlatStyle = FlatStyle.Popup;

                this.buttonSpotify.FlatAppearance.BorderSize = 1;
                this.buttonSpotify.FlatStyle = FlatStyle.Popup;

                this.buttonBakkesMod.FlatAppearance.BorderSize = 1;
                this.buttonBakkesMod.FlatStyle = FlatStyle.Popup;

                this.buttonPorofessor.FlatAppearance.BorderSize = 1;
                this.buttonPorofessor.FlatStyle = FlatStyle.Popup;

                this.buttonSteam.FlatAppearance.BorderSize = 1;
                this.buttonSteam.FlatStyle = FlatStyle.Popup;

                this.buttonBattlenet.FlatAppearance.BorderSize = 1;
                this.buttonBattlenet.FlatStyle = FlatStyle.Popup;

                this.buttonEpicGames.FlatAppearance.BorderSize = 1;
                this.buttonEpicGames.FlatStyle = FlatStyle.Popup;

                this.buttonTautulli.FlatAppearance.BorderSize = 1;
                this.buttonTautulli.FlatStyle = FlatStyle.Popup;

                this.buttonOpenVPN.FlatAppearance.BorderSize = 1;
                this.buttonOpenVPN.FlatStyle = FlatStyle.Popup;

                this.buttonWireguard.FlatAppearance.BorderSize = 1;
                this.buttonWireguard.FlatStyle = FlatStyle.Popup;

                this.buttonYoutube.FlatAppearance.BorderSize = 1;
                this.buttonYoutube.FlatStyle = FlatStyle.Popup;

                this.buttonTwitch.FlatAppearance.BorderSize = 1;
                this.buttonTwitch.FlatStyle = FlatStyle.Popup;

                this.buttonVMWare.FlatAppearance.BorderSize = 1;
                this.buttonVMWare.FlatStyle = FlatStyle.Popup;

                this.buttonPlex.FlatAppearance.BorderSize = 1;
                this.buttonPlex.FlatStyle = FlatStyle.Popup;

                this.buttonRadarr.FlatAppearance.BorderSize = 1;
                this.buttonRadarr.FlatStyle = FlatStyle.Popup;

                this.buttonSonarr.FlatAppearance.BorderSize = 1;
                this.buttonSonarr.FlatStyle = FlatStyle.Popup;

                this.buttonTransmission.FlatAppearance.BorderSize = 1;
                this.buttonTransmission.FlatStyle = FlatStyle.Popup;

                this.buttonOwncloud.FlatAppearance.BorderSize = 1;
                this.buttonOwncloud.FlatStyle = FlatStyle.Popup;
            }
        }

        private void buttonNext1_Click(object sender, EventArgs e)
        {
            this.pnlFormLoader.Controls.Clear();
            frmOtherApps2 frmOtherApps2_vrb = new frmOtherApps2() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmOtherApps2_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmOtherApps2_vrb);
            frmOtherApps2_vrb.Show();
        }

        private void buttonChrome_Click(object sender, EventArgs e)
        {
            /*/ TestConnection
            if (frmGames.CheckForInternetConnection() == false)
            {
                this.Alert("Check For your Internet connection...", Form_Alert.enmType.Error);
            }
            */
            if (Process.GetProcessesByName("Chrome").Length == 0)
            {
                Process Chrome = new Process();

                // Preparing to Launch Chrome
                Chrome.StartInfo.FileName = @"C:\Program Files\Google\Chrome\Application\chrome.exe";

                //Launch Chrome
                Chrome.Start();

                if (Chrome.Responding == true)
                {
                    this.Alert("GoogleChrome Launched", Form_Alert.enmType.Success);
                }
                else
                {
                    this.Alert("GoogleChrome not Launched", Form_Alert.enmType.Error);
                }
            }
            else
            {
                this.Alert("GoogleChrome is already Launched", Form_Alert.enmType.Warning);
            }
        }

        private void buttonDashlane_Click(object sender, EventArgs e)
        {
            /*/ TestConnection
            if (frmGames.CheckForInternetConnection() == false)
            {
                this.Alert("Check For your Internet connection...", Form_Alert.enmType.Error);
            }*/
            Process Dashlane = new Process();

            // Preparing to Launch DashlaneWebAppOnChrome
            Dashlane.StartInfo.FileName = @"C:\Program Files\Google\Chrome\Application\chrome.exe";
            Dashlane.StartInfo.Arguments = " --app=https://app.dashlane.com";

            // Launch Dashlane
            Dashlane.Start();

            this.Alert("Dashlane Launched", Form_Alert.enmType.Success);
        }

        private void buttonDiscord_Click(object sender, EventArgs e)
        {
            /*/ TestConnection
            if (frmGames.CheckForInternetConnection() == false)
            {
                this.Alert("Check For your Internet connection...", Form_Alert.enmType.Error);
            }
            */
            if (Process.GetProcessesByName("Discord").Length == 0)
            {
                Process Discord = new Process();

                Discord.StartInfo.FileName = @"C:\Users\samen\AppData\Local\Discord\Update.exe";
                Discord.StartInfo.Arguments = " --processStart Discord.exe";

                // Launch Discord
                Discord.Start();

                if (Discord.Responding == true)
                {
                    this.Alert("Discord Launched", Form_Alert.enmType.Success);
                }
                else
                {
                    this.Alert("Discord not Launched", Form_Alert.enmType.Error);
                }
            }
            else
            {
                this.Alert("Discord is already Launched", Form_Alert.enmType.Warning);
            }
        }

        private void buttonSignal_Click(object sender, EventArgs e)
        {
            /*/ TestConnection
            if (frmGames.CheckForInternetConnection() == false)
            {
                this.Alert("Check For your Internet connection...", Form_Alert.enmType.Error);
            }
            */
            if (Process.GetProcessesByName("Signal").Length == 0)
            {
                Process Signal = new Process();

                // Preparing to Launch Signal
                Signal.StartInfo.FileName = @"C:\Users\samen\AppData\Local\Programs\signal-desktop\Signal.exe";

                // Launch Signal
                Signal.Start();

                if (Signal.Responding == true)
                {
                    this.Alert("Signal Launched", Form_Alert.enmType.Success);
                }
                else
                {
                    this.Alert("Signal not Launched", Form_Alert.enmType.Error);
                }
            }
            else
            {
                this.Alert("Signal is already Launched", Form_Alert.enmType.Warning);
            }
        }

        private void buttonHWM_Click(object sender, EventArgs e)
        {
            /*/ TestConnection
            if (frmGames.CheckForInternetConnection() == false)
            {
                this.Alert("Check For your Internet connection...", Form_Alert.enmType.Error);
            }
            */
            if (Process.GetProcessesByName("HWMonitor").Length == 0)
            {
                Process HWMonitor = new Process();

                // Preparing to Launch HWMonitor
                HWMonitor.StartInfo.FileName = @"C:\Program Files\CPUID\HWMonitor\HWMonitor.exe";

                // Launch HWMonitor
                HWMonitor.Start();

                if (HWMonitor.Responding == true)
                {
                    this.Alert("HWMonitor Launched", Form_Alert.enmType.Success);
                }
                else
                {
                    this.Alert("HWMonitor not Launched", Form_Alert.enmType.Error);
                }
            }
            else
            {
                this.Alert("HWMonitor is already Launched", Form_Alert.enmType.Warning);
            }
        }

        private void buttonVSCode_Click(object sender, EventArgs e)
        {
            /*/ TestConnection
            if (frmGames.CheckForInternetConnection() == false)
            {
                this.Alert("Check For your Internet connection...", Form_Alert.enmType.Error);
            }
            */
            if (Process.GetProcessesByName("Code").Length == 0)
            {
                Process Code = new Process();

                // Preparing to Launch VSCode
                Code.StartInfo.FileName = @"D:\Microsoft VS Code\Code.exe";

                // Launch VSCode
                Code.Start();

                if (Code.Responding == true)
                {
                    this.Alert("VSCode Launched", Form_Alert.enmType.Success);
                }
                else
                {
                    this.Alert("VSCode not Launched", Form_Alert.enmType.Error);
                }
            }
            else
            {
                this.Alert("VSCode is already Launched", Form_Alert.enmType.Warning);
            }
        }

        private void buttonSpotify_Click(object sender, EventArgs e)
        {
            /*/ TestConnection
            if (frmGames.CheckForInternetConnection() == false)
            {
                this.Alert("Check For your Internet connection...", Form_Alert.enmType.Error);
            }
            */
            if (Process.GetProcessesByName("Spotify").Length == 0)
            {
                Process Spotify = new Process();

                // Preparing to Launch Spotify
                Spotify.StartInfo.FileName = @"C:\Windows\explorer.exe";
                Spotify.StartInfo.Arguments = @" shell:appsFolder\SpotifyAB.SpotifyMusic_zpdnekdrzrea0!Spotify";

                // Launch Spotify
                Spotify.Start();

                if (Spotify.Responding == true)
                {
                    this.Alert("Spotify Launched", Form_Alert.enmType.Success);
                }
                else
                {
                    this.Alert("Spotify not Launched", Form_Alert.enmType.Error);
                }
            }
            else
            {
                this.Alert("Spotify is already Launched", Form_Alert.enmType.Warning);
            }
        }

        private void buttonSteam_Click(object sender, EventArgs e)
        {
            /*/ TestConnection
            if (frmGames.CheckForInternetConnection() == false)
            {
                this.Alert("Check For your Internet connection...", Form_Alert.enmType.Error);
            }
            */
            if (Process.GetProcessesByName("Steam").Length == 0)
            {
                Process Steam = new Process();

                // Preparing to Launch Steam
                Steam.StartInfo.FileName = @"S:\Steam\Steam.exe";

                // Launch Steam
                Steam.Start();

                if (Steam.Responding == true)
                {
                    this.Alert("Steam Launched", Form_Alert.enmType.Success);
                }
                else
                {
                    this.Alert("Steam not Launched", Form_Alert.enmType.Error);
                }
            }
            else
            {
                this.Alert("Steam is already Launched", Form_Alert.enmType.Warning);
            }
        }

        private void buttonBattlenet_Click(object sender, EventArgs e)
        {
            /*/ TestConnection
            if (frmGames.CheckForInternetConnection() == false)
            {
                this.Alert("Check For your Internet connection...", Form_Alert.enmType.Error);
            }
            */
            if (Process.GetProcessesByName("Battlenet").Length == 0)
            {
                Process Battlenet = new Process();

                // Preparing to Launch Battlenet
                Battlenet.StartInfo.FileName = @"D:\Battle.net\Battle.net Launcher.exe";

                // Launch Battlenet
                Battlenet.Start();

                if (Battlenet.Responding == true)
                {
                    this.Alert("Battlenet Launched", Form_Alert.enmType.Success);
                }
                else
                {
                    this.Alert("Battlenet not Launched", Form_Alert.enmType.Error);
                }
            }
            else
            {
                this.Alert("Battlenet is already Launched", Form_Alert.enmType.Warning);
            }
        }

        private void buttonEpicGames_Click(object sender, EventArgs e)
        {
            /*/ TestConnection
            if (frmGames.CheckForInternetConnection() == false)
            {
                this.Alert("Check For your Internet connection...", Form_Alert.enmType.Error);
            }*/
            if (Process.GetProcessesByName("EpicGames").Length == 0)
            {
                Process EpicGames = new Process();

                // Preparing to Launch EpicGames
                EpicGames.StartInfo.FileName = @"S:\Epic Games\Launcher\Portal\Binaries\Win32\EpicGamesLauncher.exe";

                // Launch EpicGames
                EpicGames.Start();

                if (EpicGames.Responding == true)
                {
                    this.Alert("EpicGames Launched", Form_Alert.enmType.Success);
                }
                else
                {
                    this.Alert("EpicGames not Launched", Form_Alert.enmType.Error);
                }
            }
            else
            {
                this.Alert("EpicGames is already Launched", Form_Alert.enmType.Warning);
            }
        }

        private void buttonBakkesMod_Click(object sender, EventArgs e)
        {
            /*/ TestConnection
            if (frmGames.CheckForInternetConnection() == false)
            {
                this.Alert("Check For your Internet connection...", Form_Alert.enmType.Error);
            }*/
            if (Process.GetProcessesByName("BakkesMod").Length == 0)
            {
                Process BakkesMod = new Process();

                // Preparing to Launch BakkesMod
                BakkesMod.StartInfo.FileName = @"C:\Program Files\BakkesMod\BakkesMod.exe";

                // Launch BakkesMod
                BakkesMod.Start();

                if (BakkesMod.Responding == true)
                {
                    this.Alert("BakkesMod Launched", Form_Alert.enmType.Success);
                }
                else
                {
                    this.Alert("BakkesMod not Launched", Form_Alert.enmType.Error);
                }
            }
            else
            {
                this.Alert("BakkesMod is already Launched", Form_Alert.enmType.Warning);
            }

        }

        private void buttonPorofessor_Click(object sender, EventArgs e)
        {
            /*/ TestConnection
            if (frmGames.CheckForInternetConnection() == false)
            {
                this.Alert("Check For your Internet connection...", Form_Alert.enmType.Error);
            }
            */
            if (Process.GetProcessesByName("Overwolf").Length == 0)
            {
                Process Porofessor = new Process();

                // Preparing to Launch Porofessor
                Porofessor.StartInfo.FileName = @"D:\Overwolf\OverwolfLauncher.exe";
                Porofessor.StartInfo.Arguments = @" -launchapp pibhbkkgefgheeglaeemkkfjlhidhcedalapdggh -from-startmenu";

                // Launch Porofessor
                Porofessor.Start();

                if (Porofessor.Responding == true)
                {
                    this.Alert("Porofessor Launched", Form_Alert.enmType.Success);
                }
                else
                {
                    this.Alert("Porofessor not Launched", Form_Alert.enmType.Error);
                }
            }
            else
            {
                this.Alert("Porofessor is already Launched", Form_Alert.enmType.Warning);
            }
        }

        private void buttonYoutube_Click(object sender, EventArgs e)
        {
            /*/ TestConnection
            if (frmGames.CheckForInternetConnection() == false)
            {
                this.Alert("Check For your Internet connection...", Form_Alert.enmType.Error);
            }
            */
            Process Youtube = new Process();

            // Preparing to Launch Youtube
            Youtube.StartInfo.FileName = @"C:\Program Files\Google\Chrome\Application\chrome_proxy.exe";
            Youtube.StartInfo.Arguments = @" --profile-directory=Default --app-id=agimnkijcaahngcdmfeangaknmldooml";

            // Launch Youtube
            Youtube.Start();
            this.Alert("Youtube Launched", Form_Alert.enmType.Success);
        }

        private void buttonTwitch_Click(object sender, EventArgs e)
        {
            /*/ TestConnection
            if (frmGames.CheckForInternetConnection() == false)
            {
                this.Alert("Check For your Internet connection...", Form_Alert.enmType.Error);
            }
            */
            if (Process.GetProcessesByName("Twitch").Length == 0)
            {
                Process Twitch = new Process();

                // Preparing to Launch Twitch
                Twitch.StartInfo.FileName = @"D:\Twitch\Bin\Twitch.exe";

                // Launch Twitch
                Twitch.Start();

                if (Twitch.Responding == true)
                {
                    this.Alert("Twitch Launched", Form_Alert.enmType.Success);
                }
                else
                {
                    this.Alert("Twitch not Launched", Form_Alert.enmType.Error);
                }
            }
            else
            {
                this.Alert("Twitch is already Launched", Form_Alert.enmType.Warning);
            }
        }

        private void buttonOBSLauncher_Click(object sender, EventArgs e)
        {
            /*/ TestConnection
            if (frmGames.CheckForInternetConnection() == false)
            {
                this.Alert("Check For your Internet connection...", Form_Alert.enmType.Error);
            }
            */
            if (Process.GetProcessesByName("Streamlabs OBS").Length == 0)
            {
                Process OBS = new Process();

                // Preparing to Launch OBS
                OBS.StartInfo.FileName = @"D:\SteamLabs\Streamlabs OBS\Streamlabs OBS.exe";

                // Launch OBS
                OBS.Start();

                if (OBS.Responding == true)
                {
                    this.Alert("SteamLabs Launched", Form_Alert.enmType.Success);
                }
                else
                {
                    this.Alert("SteamLabs not Launched", Form_Alert.enmType.Error);
                }
            }
            else
            {
                this.Alert("SteamLabs is already Launched", Form_Alert.enmType.Warning);
            }
        }

        private void buttonVS_Click(object sender, EventArgs e)
        {
            /*/ TestConnection
            if (frmGames.CheckForInternetConnection() == false)
            {
                this.Alert("Check For your Internet connection...", Form_Alert.enmType.Error);
            }
            */
            if (Process.GetProcessesByName("devenv").Length == 0)
            {
                Process VS = new Process();

                // Preparing to Launch VS
                VS.StartInfo.FileName = @"C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\IDE\devenv.exe";

                // Launch VS
                VS.Start();

                if (VS.Responding == true)
                {
                    this.Alert("Visual Studio Launched", Form_Alert.enmType.Success);
                }
                else
                {
                    this.Alert("Visual Studio not Launched", Form_Alert.enmType.Error);
                }
            }
            else
            {
                this.Alert("Visual Studio is already Launched", Form_Alert.enmType.Warning);
            }
        }

        private void buttonLivelyWP_Click(object sender, EventArgs e)
        {
            /*/ TestConnection
            if (frmGames.CheckForInternetConnection() == false)
            {
                this.Alert("Check For your Internet connection...", Form_Alert.enmType.Error);
            }
            */
            if (Process.GetProcessesByName("livelywpf").Length == 0)
            {
                Process Lively = new Process();

                // Preparing to Launch Lively
                Lively.StartInfo.FileName = @"D:\Lively Wallpaper\Lively.exe";

                // Launch Lively
                Lively.Start();

                if (Lively.Responding == true)
                {
                    this.Alert("LivelyWPP Launched", Form_Alert.enmType.Success);
                }
                else
                {
                    this.Alert("LivelyWPP not Launched", Form_Alert.enmType.Error);
                }
            }
            else
            {
                this.Alert("LivelyWPP is already Launched", Form_Alert.enmType.Warning);
            }
        }

        private void buttonOutlook_Click(object sender, EventArgs e)
        {
            Process Outlook = new Process();

            // Preparing to Launch Outlook
            Outlook.StartInfo.FileName = @"C:\Program Files\Microsoft Office\root\Office16\OUTLOOK.EXE";

            // Launch Outlook
            Outlook.Start();

            if (Outlook.Responding == true)
            {
                this.Alert("Outlook Launched", Form_Alert.enmType.Success);
            }
            else
            {
                this.Alert("Outlook not Launched", Form_Alert.enmType.Error);
            }
        }

        private void buttonMsstore_Click(object sender, EventArgs e)
        {
            Process.Start("ms-windows-store://");
            this.Alert("MsStore Launched", Form_Alert.enmType.Success);
        }

        private void buttonOfficeHub_Click(object sender, EventArgs e)
        {
            Process OfficeHub = new Process();

            OfficeHub.StartInfo.FileName = @"C:\Windows\explorer.exe";
            OfficeHub.StartInfo.Arguments = @" shell:appsFolder\Microsoft.MicrosoftOfficeHub_8wekyb3d8bbwe!Microsoft.MicrosoftOfficeHub";

            OfficeHub.Start();

            this.Alert("Office Launched", Form_Alert.enmType.Success);
        }

        private void buttonPlex_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Program Files\Plex\Plex\Plex.exe");
            this.Alert("Plex Launched", Form_Alert.enmType.Success);
        }

        private void buttonRadarr_Click(object sender, EventArgs e)
        {
            Process.Start("http://samsrv:7878");
            this.Alert("Radarr Launched", Form_Alert.enmType.Success);
        }

        private void buttonSonarr_Click(object sender, EventArgs e)
        {
            Process.Start("http://samsrv:8989");
            this.Alert("Sonarr Launched", Form_Alert.enmType.Success);
        }

        private void buttonTransmission_Click(object sender, EventArgs e)
        {
            Process.Start("http://samsrv:9091/transmission/web/");
            this.Alert("Transmission Launched", Form_Alert.enmType.Success);
        }

        private void buttonWindowsTerminal_Click(object sender, EventArgs e)
        {
            // Launch WindowsTerminal
            Process.Start("wt");
            this.Alert("Windows Terminal Launched", Form_Alert.enmType.Success);
        }

        private void buttonTautulli_Click(object sender, EventArgs e)
        {
            Process.Start("http://samsrv:8181/home");
            this.Alert("Tautulli Launched", Form_Alert.enmType.Success);
        }

        private void buttonOwncloud_Click(object sender, EventArgs e)
        {
            Process.Start("http://samsrv/owncloud/index.php/login");
            this.Alert("Owncloud Launched", Form_Alert.enmType.Success);
        }

        private void buttonBazarr_Click(object sender, EventArgs e)
        {
            Process.Start("https://signin.aws.amazon.com/signin?redirect_uri=https%3A%2F%2Fus-east-1.console.aws.amazon.com%2Fconsole%2Fhome%3FhashArgs%3D%2523%26isauthcode%3Dtrue%26nc2%3Dh_ct%26region%3Dus-east-1%26skipRegion%3Dtrue%26src%3Dheader-signin%26state%3DhashArgsFromTB_us-east-1_d1ff62bdc895fc29&client_id=arn%3Aaws%3Asignin%3A%3A%3Aconsole%2Fcanvas&forceMobileApp=0&code_challenge=-Yh_03EoTGCpRiR-TxhBRtVY4Xu3N8R-qhu02xe1rzM&code_challenge_method=SHA-256");
            this.Alert("AWS Launched", Form_Alert.enmType.Success);
        }

        private void buttonHVM_Click(object sender, EventArgs e)
        {
            Process HVM = new Process();

            // Preparing to Launch Hyper-V
            HVM.StartInfo.FileName = @"C:\Windows\System32\mmc.exe";
            HVM.StartInfo.Arguments = @" C:\Windows\System32\virtmgmt.msc";

            HVM.StartInfo.WorkingDirectory = @"C:\Program Files\Hyper-V\";

            // Launch Hyper-V
            HVM.Start();

            if (HVM.Responding == true)
            {
                this.Alert("Hyper-V Launched", Form_Alert.enmType.Success);
            }
            else
            {
                this.Alert("Hyper-V not Launched", Form_Alert.enmType.Error);
            }
        }

        private void buttonHWiNFO64_Click_1(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName("HWiNFO64").Length == 0)
            {
                Process HWiNFO64 = new Process();

                // Preparing to Launch HWiNFO64
                HWiNFO64.StartInfo.FileName = @"C:\Program Files\HWiNFO64\HWiNFO64.EXE";

                // Launch HWiNFO64
                try
                {
                    HWiNFO64.Start();
                    this.Alert("HWiNFO64 Launched", Form_Alert.enmType.Success);
                }
                catch
                {
                    this.Alert("HWiNFO64 Error Admin Rights Needed ?", Form_Alert.enmType.Error);
                }
            }
            else
            {
                this.Alert("HWiNFO64 is already Launched", Form_Alert.enmType.Warning);
            }
        }

        private void buttonHotSpot_Click(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName("hydra").Length == 0)
            {
                Process HotSpot = new Process();

                // Preparing to Launch HotSpotShield
                HotSpot.StartInfo.FileName = @"C:\Program Files(x86)\Hotspot Shield\11.0.0\bin\hsscp.exe";
                HotSpot.StartInfo.WorkingDirectory = @"C:\Program Files(x86)\Hotspot Shield\11.0.0\bin\";

                // Launch HotSpotShield
                try
                {
                    HotSpot.Start();
                    this.Alert("HotSpotShield Launched", Form_Alert.enmType.Success);
                }
                catch
                {
                    this.Alert("HotSpotShield Error Admin Rights Needed ?", Form_Alert.enmType.Error);
                }
            }
            else
            {
                this.Alert("HotSpotShield is already Launched", Form_Alert.enmType.Warning);
            }
        }

        private void buttonWireguard_Click(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName("wireguard").Length == 0)
            {
                Process Wireguard = new Process();

                // Preparing to Launch HWiNFO64
                Wireguard.StartInfo.FileName = @"C:\Program Files\WireGuard\wireguard.exe";
                Wireguard.StartInfo.WorkingDirectory = @"C:\Program Files\WireGuard\";

                // Launch HWiNFO64
                try
                {
                    Wireguard.Start();
                    this.Alert("Wireguard Launched", Form_Alert.enmType.Success);
                }
                catch
                {
                    this.Alert("Wireguard Error Admin Rights Needed ?", Form_Alert.enmType.Error);
                }
            }
            else
            {
                this.Alert("Wireguard is already Launched", Form_Alert.enmType.Warning);
            }
        }

        private void buttonTeams_Click(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName("Teams").Length == 0)
            {
                Process Teams = new Process();

                // Preparing to Launch MS Teams
                Teams.StartInfo.FileName = @"C:\Users\samen\AppData\Local\Microsoft\Teams\Update.exe";
                Teams.StartInfo.Arguments = " --processStart" + " Teams.exe";

                // Launch MS Teams
                try
                {
                    Teams.Start();
                    this.Alert("MicrosoftTeams Launched", Form_Alert.enmType.Success);
                }
                catch
                {
                    this.Alert("MicrosoftTeams Error Admin Rights Needed ?", Form_Alert.enmType.Error);
                }
            }
            else
            {
                this.Alert("MicrosoftTeams is already Launched", Form_Alert.enmType.Warning);
            }
        }

        private void buttonOneNote_Click(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName("OneNote").Length == 0)
            {
                Process OneNote = new Process();

                // Preparing to Launch MS Teams
                OneNote.StartInfo.FileName = @"C:\Program Files\Microsoft Office\root\Office16\ONENOTE.EXE";

                // Launch MS Teams
                try
                {
                    OneNote.Start();
                    this.Alert("OneNote Launched", Form_Alert.enmType.Success);
                }
                catch
                {
                    this.Alert("OneNote Error Admin Rights Needed ?", Form_Alert.enmType.Error);
                }
            }
            else
            {
                this.Alert("OneNote is already Launched", Form_Alert.enmType.Warning);
            }
        }

        private void buttonOpenVPN_Click(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName("OpenVPNConnect").Length == 0)
            {
                Process OpenVPNConnect = new Process();

                // Preparing to Launch OpenVPNConnect
                OpenVPNConnect.StartInfo.FileName = @"C:\Program Files\OpenVPN Connect\OpenVPNConnect.exe";

                // Launch OpenVPNConnect
                try
                {
                    OpenVPNConnect.Start();
                    this.Alert("OpenVPNConnect Launched", Form_Alert.enmType.Success);
                }
                catch
                {
                    this.Alert("OpenVPNConnect Error Admin Rights Needed ?", Form_Alert.enmType.Error);
                }
            }
            else
            {
                this.Alert("OpenVPNConnect is already Launched", Form_Alert.enmType.Warning);
            }
        }

        private void buttonDS4_Click(object sender, EventArgs e)
        {
            Process DS4 = new Process();


            if (Process.GetProcessesByName("DS4Windows").Length == 0)
            {
                // Preparing to Launch DS4
                DS4.StartInfo.FileName = @"C:\Program Files\DS4\DS4Windows.exe";

                // Launch DS4
                DS4.Start();

                if (DS4.Responding == true)
                {
                    this.Alert("DS4 Windows Launched", Form_Alert.enmType.Success);
                }
                else
                {
                    this.Alert("DS4 Windows not Launched", Form_Alert.enmType.Error);
                }
            }
            else
            {
                this.Alert("DS4 Windows already Launched", Form_Alert.enmType.Warning);
            }
        }

        private void buttonVMWare_Click(object sender, EventArgs e)
        {
            Process VMWarePro = new Process();


            if (Process.GetProcessesByName("vmware").Length == 0)
            {
                // Preparing to Launch VMWare Pro
                VMWarePro.StartInfo.FileName = @"D:\VMWare\vmware.exe";

                // Launch VMWare Pro
                VMWarePro.Start();

                if (VMWarePro.Responding == true)
                {
                    this.Alert("VMWare Launched", Form_Alert.enmType.Success);
                }
                else
                {
                    this.Alert("VMWare not Launched", Form_Alert.enmType.Error);
                }
            }
            else
            {
                this.Alert("VMWare already Launched", Form_Alert.enmType.Warning);
            }
        }
    }
}
