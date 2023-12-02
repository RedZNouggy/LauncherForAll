using System;
using System.ComponentModel;
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

                this.buttonDashlane.FlatAppearance.BorderSize = 0;
                this.buttonDashlane.FlatStyle = FlatStyle.Flat;

                this.buttonDiscord.FlatAppearance.BorderSize = 0;
                this.buttonDiscord.FlatStyle = FlatStyle.Flat;

                this.buttonWord.FlatAppearance.BorderSize = 0;
                this.buttonWord.FlatStyle = FlatStyle.Flat;

                this.buttonPowerPoint.FlatAppearance.BorderSize = 0;
                this.buttonPowerPoint.FlatStyle = FlatStyle.Flat;

                this.buttonExcel.FlatAppearance.BorderSize = 0;
                this.buttonExcel.FlatStyle = FlatStyle.Flat;

                this.buttonFirefox.FlatAppearance.BorderSize = 0;
                this.buttonFirefox.FlatStyle = FlatStyle.Flat;

                this.buttonWhatsApp.FlatAppearance.BorderSize = 0;
                this.buttonWhatsApp.FlatStyle = FlatStyle.Flat;

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

                this.buttonLivelyWP.FlatAppearance.BorderSize = 0;
                this.buttonLivelyWP.FlatStyle = FlatStyle.Flat;

                this.buttonDS4.FlatAppearance.BorderSize = 0;
                this.buttonDS4.FlatStyle = FlatStyle.Flat;

                this.buttonMyCanal.FlatAppearance.BorderSize = 0;
                this.buttonMyCanal.FlatStyle = FlatStyle.Flat;

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

                this.buttonYoutube.FlatAppearance.BorderSize = 0;
                this.buttonYoutube.FlatStyle = FlatStyle.Flat;

                this.buttonTwitch.FlatAppearance.BorderSize = 0;
                this.buttonTwitch.FlatStyle = FlatStyle.Flat;

                this.buttonOBSLauncher.FlatAppearance.BorderSize = 0;
                this.buttonOBSLauncher.FlatStyle = FlatStyle.Flat;

                this.buttonSteel.FlatAppearance.BorderSize = 0;
                this.buttonSteel.FlatStyle = FlatStyle.Flat;

                this.buttonRiotGames.FlatAppearance.BorderSize = 0;
                this.buttonRiotGames.FlatStyle = FlatStyle.Flat;

                this.buttonTeamViewer.FlatAppearance.BorderSize = 0;
                this.buttonTeamViewer.FlatStyle = FlatStyle.Flat;

                this.buttonParsec.FlatAppearance.BorderSize = 0;
                this.buttonParsec.FlatStyle = FlatStyle.Flat;

                this.buttonZoom.FlatAppearance.BorderSize = 0;
                this.buttonZoom.FlatStyle = FlatStyle.Flat;

                this.buttonNotion.FlatAppearance.BorderSize = 0;
                this.buttonNotion.FlatStyle = FlatStyle.Flat;
            }
            else
            {
                this.buttonDashlane.FlatAppearance.BorderSize = 1;
                this.buttonDashlane.FlatStyle = FlatStyle.Popup;

                this.buttonZoom.FlatAppearance.BorderSize = 1;
                this.buttonZoom.FlatStyle = FlatStyle.Popup;

                this.buttonDiscord.FlatAppearance.BorderSize = 1;
                this.buttonDiscord.FlatStyle = FlatStyle.Popup;

                this.buttonWord.FlatAppearance.BorderSize = 1;
                this.buttonWord.FlatStyle = FlatStyle.Popup;

                this.buttonPowerPoint.FlatAppearance.BorderSize = 1;
                this.buttonPowerPoint.FlatStyle = FlatStyle.Popup;

                this.buttonExcel.FlatAppearance.BorderSize = 1;
                this.buttonExcel.FlatStyle = FlatStyle.Popup;

                this.buttonWhatsApp.FlatAppearance.BorderSize = 1;
                this.buttonWhatsApp.FlatStyle = FlatStyle.Popup;

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

                this.buttonFirefox.FlatAppearance.BorderSize = 1;
                this.buttonFirefox.FlatStyle = FlatStyle.Popup;

                this.buttonChrome.FlatAppearance.BorderSize = 1;
                this.buttonChrome.FlatStyle = FlatStyle.Popup;

                this.buttonLivelyWP.FlatAppearance.BorderSize = 1;
                this.buttonLivelyWP.FlatStyle = FlatStyle.Popup;

                this.buttonDS4.FlatAppearance.BorderSize = 1;
                this.buttonDS4.FlatStyle = FlatStyle.Popup;

                this.buttonMyCanal.FlatAppearance.BorderSize = 1;
                this.buttonMyCanal.FlatStyle = FlatStyle.Popup;

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

                this.buttonYoutube.FlatAppearance.BorderSize = 1;
                this.buttonYoutube.FlatStyle = FlatStyle.Popup;

                this.buttonTwitch.FlatAppearance.BorderSize = 1;
                this.buttonTwitch.FlatStyle = FlatStyle.Popup;

                this.buttonOBSLauncher.FlatAppearance.BorderSize = 1;
                this.buttonOBSLauncher.FlatStyle = FlatStyle.Popup;

                this.buttonSteel.FlatAppearance.BorderSize = 1;
                this.buttonSteel.FlatStyle = FlatStyle.Popup;

                this.buttonRiotGames.FlatAppearance.BorderSize = 1;
                this.buttonRiotGames.FlatStyle = FlatStyle.Popup;

                this.buttonTeamViewer.FlatAppearance.BorderSize = 1;
                this.buttonTeamViewer.FlatStyle = FlatStyle.Popup;

                this.buttonParsec.FlatAppearance.BorderSize = 1;
                this.buttonParsec.FlatStyle = FlatStyle.Popup;

                this.buttonNotion.FlatAppearance.BorderSize = 1;
                this.buttonNotion.FlatStyle = FlatStyle.Popup;
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

        private void buttonSnapchat_Click(object sender, EventArgs e)
        {
            Process Snapchat = new Process();

            // Preparing to Launch Snapchat
            Snapchat.StartInfo.FileName = @"C:\Program Files\Google\Chrome\Application\chrome_proxy.exe";
            Snapchat.StartInfo.Arguments = " --profile-directory=Default --app-id=abdndmcckigaeepaljhpcngbfdkbiggb";

            // Launch Signal
            Snapchat.Start();
            this.Alert("Snapchat Launched", Form_Alert.enmType.Success);
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
            if (Process.GetProcessesByName("Twitch").Length == 0)
            {
                Process Twitch = new Process();

                // Preparing to Launch Twitch
                Twitch.StartInfo.FileName = @"https://www.twitch.tv/";

                // Launch Twitch
                Twitch.Start();
                this.Alert("Twitch Launched", Form_Alert.enmType.Success);
            }
        }

        private void buttonOBSLauncher_Click(object sender, EventArgs e)
        {
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

        private void buttonMyCanal_Click(object sender, EventArgs e)
        {
            Process MyCanal = new Process();

            // Preparing to Launch MyCanal
            MyCanal.StartInfo.FileName = @"C:\Program Files\Google\Chrome\Application\chrome_proxy.exe";
            MyCanal.StartInfo.Arguments = @" --profile-directory=Default --app-id=enaibefmjkdnhcbldaccphajjoallbom";

            // Launch MyCanal
            MyCanal.Start();
            this.Alert("MyCanal Launched", Form_Alert.enmType.Success);
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

        private void buttonPowerPoint_Click(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName("POWERPNT").Length == 0)
            {
                Process PowerPoint = new Process();

                // Preparing to Launch PowerPoint
                PowerPoint.StartInfo.FileName = @"C:\Program Files\Microsoft Office\root\Office16\POWERPNT.EXE";

                // Launch PowerPoint
                try
                {
                    PowerPoint.Start();
                    this.Alert("PowerPoint Launched", Form_Alert.enmType.Success);
                }
                catch
                {
                    this.Alert("PowerPoint can't be launch", Form_Alert.enmType.Error);
                }
            }
            else
            {
                this.Alert("PowerPoint is already Launched", Form_Alert.enmType.Warning);
            }
        }

        private void buttonWord_Click(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName("WINWORD").Length == 0)
            {
                Process WORD = new Process();

                // Preparing to Launch WORD
                WORD.StartInfo.FileName = @"C:\Program Files\Microsoft Office\root\Office16\WINWORD.EXE";

                // Launch WORD
                try
                {
                    WORD.Start();
                    this.Alert("WORD Launched", Form_Alert.enmType.Success);
                }
                catch
                {
                    this.Alert("WORD can't be launch", Form_Alert.enmType.Error);
                }
            }
            else
            {
                this.Alert("WORD is already Launched", Form_Alert.enmType.Warning);
            }
        }

        private void buttonExcel_Click(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName("EXCEL").Length == 0)
            {
                Process EXCEL = new Process();

                // Preparing to Launch EXCEL
                EXCEL.StartInfo.FileName = @"C:\Program Files\Microsoft Office\root\Office16\EXCEL.EXE";

                // Launch EXCEL
                try
                {
                    EXCEL.Start();
                    this.Alert("EXCEL Launched", Form_Alert.enmType.Success);
                }
                catch
                {
                    this.Alert("EXCEL can't be launch", Form_Alert.enmType.Error);
                }
            }
            else
            {
                this.Alert("EXCEL is already Launched", Form_Alert.enmType.Warning);
            }
        }

        private void buttonWhatsApp_Click(object sender, EventArgs e)
        {
            Process WhatsApp = new Process();
            // Preparing to Launch WhatsApp
            WhatsApp.StartInfo.FileName = @"C:\Program Files\WindowsApps\5319275A.WhatsAppDesktop_2.2401.5.0_x64__cv1g1gvanyjgm\WhatsApp.exe";

            if (Process.GetProcessesByName("WhatsApp").Length == 0)
            {
                // Launch WhatsApp
                try
                {
                    WhatsApp.Start();
                    this.Alert("WhatsApp Launched", Form_Alert.enmType.Success);
                }
                catch
                {
                    this.Alert("WhatsApp can't be launch", Form_Alert.enmType.Error);
                }
            }
            else
            {
                this.Alert("WhatsApp is already Launched", Form_Alert.enmType.Warning);
            }
        }

        private void buttonZoom_Click(object sender, EventArgs e)
        {
            Process Zoom = new Process();
            // Preparing to Launch Zoom
            Zoom.StartInfo.FileName = @"C:\Users\samen\AppData\Roaming\Zoom\bin\Zoom.exe";

            if (Process.GetProcessesByName("Zoom").Length == 0)
            {
                // Launch Zoom
                try
                {
                    Zoom.Start();
                    this.Alert("Zoom Launched", Form_Alert.enmType.Success);
                }
                catch
                {
                    this.Alert("Zoom can't be launch", Form_Alert.enmType.Error);
                }
            }
            else
            {
                this.Alert("Zoom is already Launched", Form_Alert.enmType.Warning);
            }
        }

        private void buttonTeamViewer_Click(object sender, EventArgs e)
        {
            Process TeamViewer = new Process();
            // Preparing to Launch TeamViewer
            TeamViewer.StartInfo.FileName = @"C:\Program Files\TeamViewer\TeamViewer.exe";
            TeamViewer.StartInfo.WorkingDirectory = @"C:\Program Files\TeamViewer";

            if (Process.GetProcessesByName("TeamViewer").Length == 0)
            {
                // Launch TeamViewer
                try
                {
                    TeamViewer.Start();
                    this.Alert("TeamViewer Launched", Form_Alert.enmType.Success);
                }
                catch
                {
                    this.Alert("TeamViewer can't be launch", Form_Alert.enmType.Error);
                }
            }
            else
            {
                this.Alert("TeamViewer is already Launched", Form_Alert.enmType.Warning);
            }
        }

        private void buttonParsec_Click(object sender, EventArgs e)
        {
            Process Parsec = new Process();
            // Preparing to Launch Parsec
            Parsec.StartInfo.FileName = @"C:\Program Files\Parsec\parsecd.exe";

            if (Process.GetProcessesByName("Parsec").Length == 0)
            {
                // Launch Parsec
                try
                {
                    Parsec.Start();
                    this.Alert("Parsec Launched", Form_Alert.enmType.Success);
                }
                catch
                {
                    this.Alert("Parsec can't be launch", Form_Alert.enmType.Error);
                }
            }
            else
            {
                this.Alert("Parsec is already Launched", Form_Alert.enmType.Warning);
            }
        }

        private void buttonRiotGames_Click(object sender, EventArgs e)
        {

            /*/ TestConnection
            if (frmGames.CheckForInternetConnection() == false)
            {
                this.Alert("Check For your Internet connection...", Form_Alert.enmType.Error);
            }
            */
            if (Process.GetProcessesByName("RiotGames").Length == 0)
            {
                Process RiotGames = new Process();

                // Preparing to Launch Riot Games
                RiotGames.StartInfo.FileName = @"S:\Riot Games\Riot Client\RiotClientServices.exe";
                RiotGames.StartInfo.WorkingDirectory = @"S:\Riot Games\Riot Client";
                RiotGames.StartInfo.Verb = "runas"; // Ask admin rights

                // Launch Riot Games
                try
                {
                    RiotGames.Start();
                    this.Alert("Riot Games Launched", Form_Alert.enmType.Success);
                }
                catch (Win32Exception ex)
                {
                    if (ex.NativeErrorCode == 1223)
                    {
                        // admins rights canceled
                        this.Alert("Riot Games Error Admin Rights Needed", Form_Alert.enmType.Error);
                    }
                    else
                    {
                        // Unespected Error
                        this.Alert("Unespected error" + ex.Message, Form_Alert.enmType.Error);
                    }
                }
            }
        }

        private void buttonFirefox_Click(object sender, EventArgs e)
        {
            /*/ TestConnection
            if (frmGames.CheckForInternetConnection() == false)
            {
                this.Alert("Check For your Internet connection...", Form_Alert.enmType.Error);
            }
            */
            if (Process.GetProcessesByName("Firefox").Length == 0)
            {
                Process Firefox = new Process();

                // Preparing to Launch Firefox
                Firefox.StartInfo.FileName = @"C:\Program Files\Mozilla Firefox\firefox.exe";
                Firefox.StartInfo.WorkingDirectory = @"C:\Program Files\Mozilla Firefox";

                //Launch Firefox
                Firefox.Start();

                if (Firefox.Responding == true)
                {
                    this.Alert("Firefox Launched", Form_Alert.enmType.Success);
                }
                else
                {
                    this.Alert("Firefox not Launched", Form_Alert.enmType.Error);
                }
            }
            else
            {
                this.Alert("Firefox is already Launched", Form_Alert.enmType.Warning);
            }
        }

        private void buttonSignal_Click(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName("Signal").Length == 0)
            {
                Process Signal = new Process();

                // Preparing to Launch Signal
                Signal.StartInfo.FileName = @"C:\Users\samen\AppData\Local\Programs\signal-desktop\Signal.exe";
                Signal.StartInfo.WorkingDirectory = @"C:\Users\samen\AppData\Local\Programs\signal-desktop";

                //Launch Signal
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

        private void buttonNotion_Click(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName("Notion").Length == 0)
            {
                Process Notion = new Process();

                // Preparing to Launch Notion
                Notion.StartInfo.FileName = @"C:\Users\samen\AppData\Local\Programs\Notion\Notion.exe";
                Notion.StartInfo.WorkingDirectory = @"C:\Users\samen\AppData\Local\Programs\Notion";

                //Launch Notion
                Notion.Start();

                if (Notion.Responding == true)
                {
                    this.Alert("Notion Launched", Form_Alert.enmType.Success);
                }
                else
                {
                    this.Alert("Notion not Launched", Form_Alert.enmType.Error);
                }
            }
            else
            {
                this.Alert("Notion is already Launched", Form_Alert.enmType.Warning);
            }
        }
    }
}
