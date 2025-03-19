using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LauncherForAll
{
    public partial class frmSamEnv : Form
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

        // BlueMod Colors
        // 46 51 73 Blue
        private readonly Color BackBlueColor = Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
        // 28 37 55 BlackBlue
        private readonly Color BackBlackBlueColor = Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
        // 0 126 249 Blue
        private readonly Color BlueColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));

        public frmSamEnv()
        {
            InitializeComponent();

            string programData = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);

            // RedMod ?
            if (File.Exists(programData + @"\LauncherForAll\Set_redMod.config"))
            {
                this.BackColor = PurpleColor;
            }
            else
            {
                this.BackColor = BackBlueColor;
            }

            // ButtonsFlat ?
            if (File.Exists(programData + @"\LauncherForAll\Set_AppsFlat.config"))
            {
                this.buttonProxmox.FlatAppearance.BorderSize = 0;
                this.buttonProxmox.FlatStyle = FlatStyle.Flat;

                this.buttonTautulli.FlatAppearance.BorderSize = 0;
                this.buttonTautulli.FlatStyle = FlatStyle.Flat;

                this.buttonWireguard.FlatAppearance.BorderSize = 0;
                this.buttonWireguard.FlatStyle = FlatStyle.Flat;

                this.buttonDLink.FlatAppearance.BorderSize = 0;
                this.buttonDLink.FlatStyle = FlatStyle.Flat;

                this.buttonPlex.FlatAppearance.BorderSize = 0;
                this.buttonPlex.FlatStyle = FlatStyle.Flat;

                this.buttonRadarr.FlatAppearance.BorderSize = 0;
                this.buttonRadarr.FlatStyle = FlatStyle.Flat;

                this.buttonSonarr.FlatAppearance.BorderSize = 0;
                this.buttonSonarr.FlatStyle = FlatStyle.Flat;

                this.buttonOwncloud.FlatAppearance.BorderSize = 0;
                this.buttonOwncloud.FlatStyle = FlatStyle.Flat;

                this.buttonVMWare.FlatAppearance.BorderSize = 0;
                this.buttonVMWare.FlatStyle = FlatStyle.Flat;

                this.buttonAWS.FlatAppearance.BorderSize = 0;
                this.buttonAWS.FlatStyle = FlatStyle.Flat;

                this.buttonHotSpot.FlatAppearance.BorderSize = 0;
                this.buttonHotSpot.FlatStyle = FlatStyle.Flat;

                this.buttonWindowsTerminal.FlatAppearance.BorderSize = 0;
                this.buttonWindowsTerminal.FlatStyle = FlatStyle.Flat;

                this.buttonHWM.FlatAppearance.BorderSize = 0;
                this.buttonHWM.FlatStyle = FlatStyle.Flat;

                this.buttonVirtualBox.FlatAppearance.BorderSize = 0;
                this.buttonVirtualBox.FlatStyle = FlatStyle.Flat;

                this.buttonAngryIP.FlatAppearance.BorderSize = 0;
                this.buttonAngryIP.FlatStyle = FlatStyle.Flat;

                this.buttonPlexamp.FlatAppearance.BorderSize = 0;
                this.buttonPlexamp.FlatStyle = FlatStyle.Flat;

                this.buttonVSCode.FlatAppearance.BorderSize = 0;
                this.buttonVSCode.FlatStyle = FlatStyle.Flat;

                this.buttonVS.FlatAppearance.BorderSize = 0;
                this.buttonVS.FlatStyle = FlatStyle.Flat;

                this.buttonPowerToys.FlatAppearance.BorderSize = 0;
                this.buttonPowerToys.FlatStyle = FlatStyle.Flat;

                this.buttonAdguard.FlatAppearance.BorderSize = 0;
                this.buttonAdguard.FlatStyle = FlatStyle.Flat;

                this.buttonHomarr.FlatAppearance.BorderSize = 0;
                this.buttonHomarr.FlatStyle = FlatStyle.Flat;

                this.buttonPortainer.FlatAppearance.BorderSize = 0;
                this.buttonPortainer.FlatStyle = FlatStyle.Flat;

                this.buttonDLink.FlatAppearance.BorderSize = 0;
                this.buttonDLink.FlatStyle = FlatStyle.Flat;

                this.buttonOverseer.FlatAppearance.BorderSize = 0;
                this.buttonOverseer.FlatStyle = FlatStyle.Flat;

                this.buttonNoIP.FlatAppearance.BorderSize = 0;
                this.buttonNoIP.FlatStyle = FlatStyle.Flat;

                this.buttonSwitch00.FlatAppearance.BorderSize = 0;
                this.buttonSwitch00.FlatStyle = FlatStyle.Flat;

                this.buttonSamSptodl.FlatAppearance.BorderSize = 0;
                this.buttonSamSptodl.FlatStyle = FlatStyle.Flat;

                this.buttonAzure.FlatAppearance.BorderSize = 0;
                this.buttonAzure.FlatStyle = FlatStyle.Flat;

                this.buttonChatGPT.FlatAppearance.BorderSize = 0;
                this.buttonChatGPT.FlatStyle = FlatStyle.Flat;

                this.buttonGoogleCloud.FlatAppearance.BorderSize = 0;
                this.buttonGoogleCloud.FlatStyle = FlatStyle.Flat;

                this.buttonJackett.FlatAppearance.BorderSize = 0;
                this.buttonJackett.FlatStyle = FlatStyle.Flat;

                this.buttonK8.FlatAppearance.BorderSize = 0;
                this.buttonK8.FlatStyle = FlatStyle.Flat;

                this.buttonMySpeed.FlatAppearance.BorderSize = 0;
                this.buttonMySpeed.FlatStyle = FlatStyle.Flat;

                this.buttonCloudflare.FlatAppearance.BorderSize = 0;
                this.buttonCloudflare.FlatStyle = FlatStyle.Flat;

                this.buttonCodeServer.FlatAppearance.BorderSize = 0;
                this.buttonCodeServer.FlatStyle = FlatStyle.Flat;

                this.buttonAffine.FlatAppearance.BorderSize = 0;
                this.buttonAffine.FlatStyle = FlatStyle.Flat;

                this.buttonWallos.FlatAppearance.BorderSize = 0;
                this.buttonWallos.FlatStyle = FlatStyle.Flat;

                this.buttonStirlingPDF.FlatAppearance.BorderSize = 0;
                this.buttonStirlingPDF.FlatStyle = FlatStyle.Flat;

                this.buttonOracleCloud.FlatAppearance.BorderSize = 0;
                this.buttonOracleCloud.FlatStyle = FlatStyle.Flat;

                this.buttonMemos.FlatAppearance.BorderSize = 0;
                this.buttonMemos.FlatStyle = FlatStyle.Flat;

                this.buttonStirlingPDF.FlatAppearance.BorderSize = 0;
                this.buttonStirlingPDF.FlatStyle = FlatStyle.Flat;

                this.buttonCheckmk.FlatAppearance.BorderSize = 0;
                this.buttonCheckmk.FlatStyle = FlatStyle.Flat;

                this.buttonqBittorrent.FlatAppearance.BorderSize = 0;
                this.buttonqBittorrent.FlatStyle = FlatStyle.Flat;
            }
            else
            {
                this.buttonProxmox.FlatAppearance.BorderSize = 1;
                this.buttonProxmox.FlatStyle = FlatStyle.Popup;

                this.buttonPlex.FlatAppearance.BorderSize = 1;
                this.buttonPlex.FlatStyle = FlatStyle.Popup;

                this.buttonRadarr.FlatAppearance.BorderSize = 1;
                this.buttonRadarr.FlatStyle = FlatStyle.Popup;

                this.buttonDLink.FlatAppearance.BorderSize = 1;
                this.buttonDLink.FlatStyle = FlatStyle.Popup;

                this.buttonSamSptodl.FlatAppearance.BorderSize = 1;
                this.buttonSamSptodl.FlatStyle = FlatStyle.Popup;

                this.buttonSonarr.FlatAppearance.BorderSize = 1;
                this.buttonSonarr.FlatStyle = FlatStyle.Popup;

                this.buttonOwncloud.FlatAppearance.BorderSize = 1;
                this.buttonOwncloud.FlatStyle = FlatStyle.Popup;

                this.buttonWireguard.FlatAppearance.BorderSize = 1;
                this.buttonWireguard.FlatStyle = FlatStyle.Popup;

                this.buttonTautulli.FlatAppearance.BorderSize = 1;
                this.buttonTautulli.FlatStyle = FlatStyle.Popup;

                this.buttonVMWare.FlatAppearance.BorderSize = 1;
                this.buttonVMWare.FlatStyle = FlatStyle.Popup;

                this.buttonAWS.FlatAppearance.BorderSize = 1;
                this.buttonAWS.FlatStyle = FlatStyle.Popup;

                this.buttonVirtualBox.FlatAppearance.BorderSize = 1;
                this.buttonVirtualBox.FlatStyle = FlatStyle.Popup;

                this.buttonAngryIP.FlatAppearance.BorderSize = 1;
                this.buttonAngryIP.FlatStyle = FlatStyle.Popup;

                this.buttonPlexamp.FlatAppearance.BorderSize = 1;
                this.buttonPlexamp.FlatStyle = FlatStyle.Popup;

                this.buttonVSCode.FlatAppearance.BorderSize = 1;
                this.buttonVSCode.FlatStyle = FlatStyle.Popup;

                this.buttonHWM.FlatAppearance.BorderSize = 1;
                this.buttonHWM.FlatStyle = FlatStyle.Popup;

                this.buttonVS.FlatAppearance.BorderSize = 1;
                this.buttonVS.FlatStyle = FlatStyle.Popup;

                this.buttonWindowsTerminal.FlatAppearance.BorderSize = 1;
                this.buttonWindowsTerminal.FlatStyle = FlatStyle.Popup;

                this.buttonHotSpot.FlatAppearance.BorderSize = 1;
                this.buttonHotSpot.FlatStyle = FlatStyle.Popup;

                this.buttonPowerToys.FlatAppearance.BorderSize = 1;
                this.buttonPowerToys.FlatStyle = FlatStyle.Popup;

                this.buttonAdguard.FlatAppearance.BorderSize = 1;
                this.buttonAdguard.FlatStyle = FlatStyle.Popup;

                this.buttonHomarr.FlatAppearance.BorderSize = 1;
                this.buttonHomarr.FlatStyle = FlatStyle.Popup;

                this.buttonPortainer.FlatAppearance.BorderSize = 1;
                this.buttonPortainer.FlatStyle = FlatStyle.Popup;

                this.buttonDLink.FlatAppearance.BorderSize = 1;
                this.buttonDLink.FlatStyle = FlatStyle.Popup;

                this.buttonOverseer.FlatAppearance.BorderSize = 1;
                this.buttonOverseer.FlatStyle = FlatStyle.Popup;

                this.buttonNoIP.FlatAppearance.BorderSize = 1;
                this.buttonNoIP.FlatStyle = FlatStyle.Popup;

                this.buttonSwitch00.FlatAppearance.BorderSize = 1;
                this.buttonSwitch00.FlatStyle = FlatStyle.Popup;

                this.buttonAzure.FlatAppearance.BorderSize = 1;
                this.buttonAzure.FlatStyle = FlatStyle.Popup;

                this.buttonChatGPT.FlatAppearance.BorderSize = 1;
                this.buttonChatGPT.FlatStyle = FlatStyle.Popup;

                this.buttonGoogleCloud.FlatAppearance.BorderSize = 1;
                this.buttonGoogleCloud.FlatStyle = FlatStyle.Popup;

                this.buttonJackett.FlatAppearance.BorderSize = 1;
                this.buttonJackett.FlatStyle = FlatStyle.Popup;

                this.buttonK8.FlatAppearance.BorderSize = 1;
                this.buttonK8.FlatStyle = FlatStyle.Popup;

                this.buttonMySpeed.FlatAppearance.BorderSize = 1;
                this.buttonMySpeed.FlatStyle = FlatStyle.Popup;

                this.buttonCloudflare.FlatAppearance.BorderSize = 1;
                this.buttonCloudflare.FlatStyle = FlatStyle.Popup;

                this.buttonCodeServer.FlatAppearance.BorderSize = 1;
                this.buttonCodeServer.FlatStyle = FlatStyle.Popup;

                this.buttonAffine.FlatAppearance.BorderSize = 1;
                this.buttonAffine.FlatStyle = FlatStyle.Popup;

                this.buttonWallos.FlatAppearance.BorderSize = 1;
                this.buttonWallos.FlatStyle = FlatStyle.Popup;

                this.buttonStirlingPDF.FlatAppearance.BorderSize = 1;
                this.buttonStirlingPDF.FlatStyle = FlatStyle.Popup;

                this.buttonOracleCloud.FlatAppearance.BorderSize = 1;
                this.buttonOracleCloud.FlatStyle = FlatStyle.Popup;

                this.buttonMemos.FlatAppearance.BorderSize = 1;
                this.buttonMemos.FlatStyle = FlatStyle.Popup;

                this.buttonStirlingPDF.FlatAppearance.BorderSize = 1;
                this.buttonStirlingPDF.FlatStyle = FlatStyle.Popup;

                this.buttonCheckmk.FlatAppearance.BorderSize = 1;
                this.buttonCheckmk.FlatStyle = FlatStyle.Popup;

                this.buttonqBittorrent.FlatAppearance.BorderSize = 1;
                this.buttonqBittorrent.FlatStyle = FlatStyle.Popup;
            }
        }

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        private void buttonAWS_Click(object sender, EventArgs e)
        {
            Process.Start("https://console.aws.amazon.com/console/home?nc2=h_ct&src=header-signin");
            this.Alert("AWS Launched", Form_Alert.enmType.Success);
        }

        private void buttonGoogleCloud_Click(object sender, EventArgs e)
        {
            Process.Start("https://console.cloud.google.com");
            this.Alert("GoogleCloud Launched", Form_Alert.enmType.Success);
        }

        private void buttonAzure_Click(object sender, EventArgs e)
        {
            Process.Start("https://portal.azure.com");
            this.Alert("Azure Launched", Form_Alert.enmType.Success);
        }

        private void buttonOracleCloud_Click(object sender, EventArgs e)
        {
            Process.Start("https://cloud.oracle.com/?region=eu-paris-1");
            this.Alert("OracleCloud Launched", Form_Alert.enmType.Success);
        }

        private void buttonCloudflare_Click(object sender, EventArgs e)
        {
            Process.Start("https://dash.cloudflare.com/login");
            this.Alert("CloudFlare Launched", Form_Alert.enmType.Success);
        }

        private void buttonVirtualBox_Click(object sender, EventArgs e)
        {
            Process VBox = new Process();


            if (Process.GetProcessesByName("VirtualBox").Length == 0)
            {
                // Preparing to Launch VBox
                VBox.StartInfo.FileName = @"D:\Vbox\VirtualBox.exe";
                VBox.StartInfo.WorkingDirectory = @"D:\Vbox\";
                // Launch VBox
                VBox.Start();

                if (VBox.Responding == true)
                {
                    this.Alert("Virtual Box Launched", Form_Alert.enmType.Success);
                }
                else
                {
                    this.Alert("Virtual Box not Launched", Form_Alert.enmType.Error);
                }
            }
            else
            {
                this.Alert("Virtual Box already Launched", Form_Alert.enmType.Warning);
            }
        }

        private void buttonVMWare_Click(object sender, EventArgs e)
        {
            Process VMWarePro = new Process();


            if (Process.GetProcessesByName("vmware").Length == 0)
            {
                // Preparing to Launch VMWare Pro
                VMWarePro.StartInfo.FileName = @"D:\VMWare Workstation\vmware.exe";

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

        private void buttonWireguard_Click(object sender, EventArgs e)
        {
            Process Wireguard = new Process();


            if (Process.GetProcessesByName("Wireguard").Length == 0)
            {
                // Preparing to Launch VBox
                Wireguard.StartInfo.FileName = @"C:\Program Files\WireGuard\wireguard.exe";
                Wireguard.StartInfo.WorkingDirectory = @"C:\Program Files\WireGuard\";
                // Launch VBox
                Wireguard.Start();

                if (Wireguard.Responding == true)
                {
                    this.Alert("Wireguard Launched", Form_Alert.enmType.Success);
                }
                else
                {
                    this.Alert("Wireguard Launched", Form_Alert.enmType.Error);
                }
            }
            else
            {
                this.Alert("Wireguard already Launched", Form_Alert.enmType.Warning);
            }
        }

        private void buttonPlex_Click(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName("Plex").Length == 0)
            {
                Process Plex = new Process();

                // Preparing to Launch Plex
                Plex.StartInfo.FileName = @"D:\Plex\Plex.exe";

                // Launch Plex
                try
                {
                    Plex.Start();
                    this.Alert("Plex Launched", Form_Alert.enmType.Success);
                }
                catch (Exception ex)
                {
                    this.Alert("Plex Error Admin Rights Needed ?", Form_Alert.enmType.Error);
                    Console.Write(ex.ToString());
                }
            }
            else
            {
                this.Alert("Plex is already Launched", Form_Alert.enmType.Warning);
            }
        }

        private void buttonAngryIP_Click(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName("ipscan").Length == 0)
            {
                Process AngryIPScanner = new Process();

                // Preparing to Launch AngryIPScanner
                AngryIPScanner.StartInfo.FileName = @"D:\Angry IP Scanner\ipscan.exe";
                AngryIPScanner.StartInfo.WorkingDirectory = @"D:\Angry IP Scanner";

                // Launch AngryIPScanner
                try
                {
                    AngryIPScanner.Start();
                    this.Alert("AngryIPScanner Launched", Form_Alert.enmType.Success);
                }
                catch (Exception ex)
                {
                    this.Alert("AngryIPScanner Error Admin Rights Needed ?", Form_Alert.enmType.Error);
                    Console.Write(ex.ToString());
                }
            }
            else
            {
                this.Alert("AngryIPScanner is already Launched", Form_Alert.enmType.Warning);
            }
        }

        private void buttonPlexamp_Click(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName("Plexamp").Length == 0)
            {
                Process Plexamp = new Process();

                // Preparing to Launch Plexamp
                Plexamp.StartInfo.FileName = @"C:\Users\samen\AppData\Local\Programs\Plexamp\Plexamp.exe";
                Plexamp.StartInfo.WorkingDirectory = @"C:\Users\samen\AppData\Local\Programs\Plexamp";

                // Launch Plexamp
                try
                {
                    Plexamp.Start();
                    this.Alert("Plexamp Launched", Form_Alert.enmType.Success);
                }
                catch (Exception ex)
                {
                    this.Alert("Plexamp Error Admin Rights Needed ?", Form_Alert.enmType.Error);
                    Console.Write(ex.ToString());
                }
            }
            else
            {
                this.Alert("Plexamp is already Launched", Form_Alert.enmType.Warning);
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


        private void buttonWindowsTerminal_Click(object sender, EventArgs e)
        {
            // Launch WindowsTerminal
            Process.Start("wt");
            this.Alert("Windows Terminal Launched", Form_Alert.enmType.Success);
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
                try
                {
                    HWMonitor.Start();
                    this.Alert("HWMonitor Launched", Form_Alert.enmType.Success);
                }
                catch (Win32Exception ex)
                {
                    if (ex.NativeErrorCode == 1223)
                    {
                        // admins rights canceled
                        this.Alert("HWMonitor Error Admin Rights Needed", Form_Alert.enmType.Error);
                    }
                    else
                    {
                        // Unespected Error
                        this.Alert("Unespected error" + ex.Message, Form_Alert.enmType.Error);
                    }
                }
            }
        }
        private void buttonPowerToys_Click(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName("PowerToys.Hosts").Length == 0)
            {
                Process PowerToysHosts = new Process();

                // Preparing to Launch PowerToysHosts
                PowerToysHosts.StartInfo.FileName = @"C:\Program Files\PowerToys\modules\Hosts\PowerToys.Hosts.exe";
                PowerToysHosts.StartInfo.WorkingDirectory = @"C:\Program Files\PowerToys\modules\Hosts";
                PowerToysHosts.StartInfo.Verb = "runas"; // Ask admin rights

                // Launch PowerToysHosts
                try
                {
                    PowerToysHosts.Start();
                    this.Alert("PowerToysHosts Launched", Form_Alert.enmType.Success);
                }
                catch (Win32Exception ex)
                {
                    if (ex.NativeErrorCode == 1223)
                    {
                        // admins rights canceled
                        this.Alert("PowerToysHosts Error Admin Rights Needed", Form_Alert.enmType.Error);
                    }
                    else
                    {
                        // Unespected Error
                        this.Alert("Unespected error" + ex.Message, Form_Alert.enmType.Error);
                    }
                }
            }
            else
            {
                this.Alert("PowerToysHosts is already Launched", Form_Alert.enmType.Warning);
            }
        }

        private void buttonTautulli_Click(object sender, EventArgs e)
        {
            Process.Start("http://samtautulli.local:8181/home");
            this.Alert("Tautulli Launched", Form_Alert.enmType.Success);
        }

        private void buttonRadarr_Click(object sender, EventArgs e)
        {
            Process.Start("http://samdownload.local:7878");
            this.Alert("Radarr Launched", Form_Alert.enmType.Success);
        }

        private void buttonSonarr_Click(object sender, EventArgs e)
        {
            Process.Start("http://samdownload.local:8989");
            this.Alert("Sonarr Launched", Form_Alert.enmType.Success);
        }

        private void buttonJackett_Click(object sender, EventArgs e)
        {
            Process.Start("http://samdownload.local:9117");
            this.Alert("Jackett Launched", Form_Alert.enmType.Success);
        }

        private void buttonProxmox_Click(object sender, EventArgs e)
        {
            Process.Start("https://samproxmox.local:8006");
            this.Alert("Samproxmox Launched", Form_Alert.enmType.Success);
        }
        private void buttonPortainer_Click(object sender, EventArgs e)
        {
            Process.Start("https://samdocker.local:9443");
            this.Alert("Portainer Launched", Form_Alert.enmType.Success);
        }

        private void buttonHomarr_Click(object sender, EventArgs e)
        {
            Process.Start("http://samdocker.local:7575/fr");
            this.Alert("Homarr Launched", Form_Alert.enmType.Success);
        }

        private void buttonDLink_Click(object sender, EventArgs e)
        {
            Process.Start("http://sw01.local/www/main.html");
            this.Alert("Dlink Launched", Form_Alert.enmType.Success);
        }

        private void buttonAdguard_Click(object sender, EventArgs e)
        {
            Process.Start("http://samadguard.local");
            this.Alert("Adguard Launched", Form_Alert.enmType.Success);
        }

        private void buttonOwncloud_Click(object sender, EventArgs e)
        {
            Process.Start("http://samowncloud.local");
            this.Alert("Owncloud Launched", Form_Alert.enmType.Success);
        }

        private void buttonHomeassistant_Click(object sender, EventArgs e)
        {
            Process.Start("http://samvpn:8123/");
            this.Alert("Homeassistant Launched", Form_Alert.enmType.Success);
        }

        private void buttonPortainer1_Click(object sender, EventArgs e)
        {
            Process.Start("http://samvpn:9002/");
            this.Alert("Portainer Launched", Form_Alert.enmType.Success);
        }

        private void buttonOverseer_Click(object sender, EventArgs e)
        {
            Process.Start("http://samdocker.local:5055/");
            this.Alert("Overseer Launched", Form_Alert.enmType.Success);
        }

        private void buttonNoIP_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.noip.com/login");
            this.Alert("NoIP Launched", Form_Alert.enmType.Success);
        }

        private void buttonSwitch00_Click(object sender, EventArgs e)
        {
            Process.Start("http://192.168.1.196");
            this.Alert("Switch00 Launched", Form_Alert.enmType.Success);
        }

        private void buttonSamSptodl_Click(object sender, EventArgs e)
        {
            Process.Start("http://samsrv2");
            this.Alert("SamSpotdl Launched", Form_Alert.enmType.Success);
        }

        private void buttonMySpeed_Click(object sender, EventArgs e)
        {
            Process.Start("http://sammyspeed.local:5216");
            this.Alert("MySpeed Launched", Form_Alert.enmType.Success);
        }

        private void buttonWallos_Click(object sender, EventArgs e)
        {
            Process.Start("http://samdocker.local:8282/stats.php");
            this.Alert("Wallos Launched", Form_Alert.enmType.Success);
        }

        private void buttonStirlingPDF_Click(object sender, EventArgs e)
        {
            Process Stirling = new Process();

            // Preparing the launch of Stirling
            Stirling.StartInfo.FileName = @"C:\Program Files\Google\Chrome\Application\chrome_proxy.exe";
            Stirling.StartInfo.Arguments = @"  --profile-directory=Default --app-id=bmbckoeanpiakjlbcighelmobhdhdpko";
            Stirling.StartInfo.WorkingDirectory = @"C:\Program Files\Google\Chrome\Application";

            // Launch Stirling
            Stirling.Start();
            this.Alert("Stirling Launched", Form_Alert.enmType.Success);
        }

        private void buttonK8_Click(object sender, EventArgs e)
        {
            Process.Start("https://samkubemaster.local:8443/#/login");
            this.Alert("Kubernetes Launched", Form_Alert.enmType.Success);
        }

        private void buttonAffine_Click(object sender, EventArgs e)
        {
            Process Affine = new Process();

            // Preparing the launch of Affine
            Affine.StartInfo.FileName = @"C:\Program Files\Google\Chrome\Application\chrome_proxy.exe";
            Affine.StartInfo.Arguments = @" --profile-directory=Default --app-id=ckoakcjpdanabpmnnmofmkpccnmfoagl";
            Affine.StartInfo.WorkingDirectory = @"C:\Program Files\Google\Chrome\Application";

            // Launch Affine
            Affine.Start();
            this.Alert("Affine Launched", Form_Alert.enmType.Success);
        }

        private void buttonCodeServer_Click(object sender, EventArgs e)
        {
            Process.Start("http://samcode.local:8080/?workspace=/root/.local/share/code-server/User/Workspaces/Untitled-1713292254041.code-workspace");
            this.Alert("CodeServer Launched", Form_Alert.enmType.Success);
        }

        private void buttonChatGPT_Click(object sender, EventArgs e)
        {
            Process ChatGPT = new Process();

            // Preparing the launch of ChatGPT
            ChatGPT.StartInfo.FileName = @"C:\Program Files\Google\Chrome\Application\chrome_proxy.exe";
            ChatGPT.StartInfo.Arguments = @" --profile-directory=Default --app-id=cadlkienfkclaiaibeoongdcgmdikeeg";
            ChatGPT.StartInfo.WorkingDirectory = @"C:\Program Files\Google\Chrome\Application";

            // Launch ChatGPT
            ChatGPT.Start();
            this.Alert("ChatGPT Launched", Form_Alert.enmType.Success);
        }

        private void buttonMemos_Click(object sender, EventArgs e)
        {
            Process Memos = new Process();

            // Preparing the launch of Memos
            Memos.StartInfo.FileName = @"C:\Program Files\Google\Chrome\Application\chrome_proxy.exe";
            Memos.StartInfo.Arguments = @" --profile-directory=Default --app-id=fccbgdgnmkgjimcdadeljnnjldkdgjmp";
            Memos.StartInfo.WorkingDirectory = @"C:\Program Files\Google\Chrome\Application";

            // Launch Memos
            Memos.Start();
            this.Alert("Memos Launched", Form_Alert.enmType.Success);
        }

        private void buttonCheckmk_Click(object sender, EventArgs e)
        {
            Process.Start("http://samcheckmk.local/monitoring/check_mk/index.py?start_url=%2Fmonitoring%2Fcheck_mk%2Fdashboard.py");
            this.Alert("Checkmk Launched", Form_Alert.enmType.Success);
        }

        private void buttonqBittorrent_Click(object sender, EventArgs e)
        {
            Process.Start("http://samdownload.local:1340/");
            this.Alert("qBittorrent Launched", Form_Alert.enmType.Success);
        }
    }
}
