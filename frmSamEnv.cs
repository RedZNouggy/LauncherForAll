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

                this.buttonHandbrake.FlatAppearance.BorderSize = 0;
                this.buttonHandbrake.FlatStyle = FlatStyle.Flat;

                this.buttonOpenVPN.FlatAppearance.BorderSize = 0;
                this.buttonOpenVPN.FlatStyle = FlatStyle.Flat;

                this.buttonVSCode.FlatAppearance.BorderSize = 0;
                this.buttonVSCode.FlatStyle = FlatStyle.Flat;

                this.buttonVS.FlatAppearance.BorderSize = 0;
                this.buttonVS.FlatStyle = FlatStyle.Flat;

                this.buttonPowerToys.FlatAppearance.BorderSize = 0;
                this.buttonPowerToys.FlatStyle = FlatStyle.Flat;

                this.buttonAdguard.FlatAppearance.BorderSize = 0;
                this.buttonAdguard.FlatStyle = FlatStyle.Flat;

                this.buttonDuckdns.FlatAppearance.BorderSize = 0;
                this.buttonDuckdns.FlatStyle = FlatStyle.Flat;

                this.buttonPihole.FlatAppearance.BorderSize = 0;
                this.buttonPihole.FlatStyle = FlatStyle.Flat;

                this.buttonOpensense.FlatAppearance.BorderSize = 0;
                this.buttonOpensense.FlatStyle = FlatStyle.Flat;

                this.buttonHeimdall.FlatAppearance.BorderSize = 0;
                this.buttonHeimdall.FlatStyle = FlatStyle.Flat;

                this.buttonPortainer.FlatAppearance.BorderSize = 0;
                this.buttonPortainer.FlatStyle = FlatStyle.Flat;

                this.buttonProxmox2.FlatAppearance.BorderSize = 0;
                this.buttonProxmox2.FlatStyle = FlatStyle.Flat;

                this.buttonTpLink.FlatAppearance.BorderSize = 0;
                this.buttonTpLink.FlatStyle = FlatStyle.Flat;

                this.buttonNZBFinder.FlatAppearance.BorderSize = 0;
                this.buttonNZBFinder.FlatStyle = FlatStyle.Flat;

                this.buttonNZBGet.FlatAppearance.BorderSize = 0;
                this.buttonNZBGet.FlatStyle = FlatStyle.Flat;

                this.buttonUsenetFarm.FlatAppearance.BorderSize = 0;
                this.buttonUsenetFarm.FlatStyle = FlatStyle.Flat;
            }
            else
            {
                this.buttonProxmox.FlatAppearance.BorderSize = 1;
                this.buttonProxmox.FlatStyle = FlatStyle.Popup;

                this.buttonPlex.FlatAppearance.BorderSize = 1;
                this.buttonPlex.FlatStyle = FlatStyle.Popup;

                this.buttonRadarr.FlatAppearance.BorderSize = 1;
                this.buttonRadarr.FlatStyle = FlatStyle.Popup;

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

                this.buttonHandbrake.FlatAppearance.BorderSize = 1;
                this.buttonHandbrake.FlatStyle = FlatStyle.Popup;

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

                this.buttonOpenVPN.FlatAppearance.BorderSize = 1;
                this.buttonOpenVPN.FlatStyle = FlatStyle.Popup;

                this.buttonPowerToys.FlatAppearance.BorderSize = 1;
                this.buttonPowerToys.FlatStyle = FlatStyle.Popup;

                this.buttonAdguard.FlatAppearance.BorderSize = 1;
                this.buttonAdguard.FlatStyle = FlatStyle.Popup;

                this.buttonDuckdns.FlatAppearance.BorderSize = 1;
                this.buttonDuckdns.FlatStyle = FlatStyle.Popup;

                this.buttonPihole.FlatAppearance.BorderSize = 1;
                this.buttonPihole.FlatStyle = FlatStyle.Popup;

                this.buttonOpensense.FlatAppearance.BorderSize = 1;
                this.buttonOpensense.FlatStyle = FlatStyle.Popup;

                this.buttonHeimdall.FlatAppearance.BorderSize = 1;
                this.buttonHeimdall.FlatStyle = FlatStyle.Popup;

                this.buttonPortainer.FlatAppearance.BorderSize = 1;
                this.buttonPortainer.FlatStyle = FlatStyle.Popup;

                this.buttonProxmox2.FlatAppearance.BorderSize = 1;
                this.buttonProxmox2.FlatStyle = FlatStyle.Popup;

                this.buttonTpLink.FlatAppearance.BorderSize = 1;
                this.buttonTpLink.FlatStyle = FlatStyle.Popup;

                this.buttonNZBFinder.FlatAppearance.BorderSize = 1;
                this.buttonNZBFinder.FlatStyle = FlatStyle.Popup;

                this.buttonNZBGet.FlatAppearance.BorderSize = 1;
                this.buttonNZBGet.FlatStyle = FlatStyle.Popup;

                this.buttonUsenetFarm.FlatAppearance.BorderSize = 1;
                this.buttonUsenetFarm.FlatStyle = FlatStyle.Popup;
            }
        }

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        private void buttonAWS_Click(object sender, EventArgs e)
        {
            Process.Start("https://signin.aws.amazon.com/signin?redirect_uri=https%3A%2F%2Fus-east-1.console.aws.amazon.com%2Fconsole%2Fhome%3FhashArgs%3D%2523%26isauthcode%3Dtrue%26nc2%3Dh_ct%26region%3Dus-east-1%26skipRegion%3Dtrue%26src%3Dheader-signin%26state%3DhashArgsFromTB_us-east-1_d1ff62bdc895fc29&client_id=arn%3Aaws%3Asignin%3A%3A%3Aconsole%2Fcanvas&forceMobileApp=0&code_challenge=-Yh_03EoTGCpRiR-TxhBRtVY4Xu3N8R-qhu02xe1rzM&code_challenge_method=SHA-256");
            this.Alert("AWS Launched", Form_Alert.enmType.Success);
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
                Plex.StartInfo.FileName = @"C:\Program Files\Plex\Plex\Plex.exe";

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
                AngryIPScanner.StartInfo.FileName = @"C:\Program Files\Angry IP Scanner\ipscan.exe";
                AngryIPScanner.StartInfo.WorkingDirectory = @"C:\Program Files\Angry IP Scanner";

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

        private void buttonHandbrake_Click(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName("HandBrake").Length == 0)
            {
                Process HandBrake = new Process();

                // Preparing to Launch HandBrake
                HandBrake.StartInfo.FileName = @"C:\Program Files\HandBrake\HandBrake.exe";
                HandBrake.StartInfo.WorkingDirectory = @"C:\Program Files\HandBrake\doc";

                // Launch HandBrake
                try
                {
                    HandBrake.Start();
                    this.Alert("HandBrake Launched", Form_Alert.enmType.Success);
                }
                catch (Exception ex)
                {
                    this.Alert("HandBrake Error Admin Rights Needed ?", Form_Alert.enmType.Error);
                    Console.Write(ex.ToString());
                }
            }
            else
            {
                this.Alert("HandBrake is already Launched", Form_Alert.enmType.Warning);
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

        private void buttonSonarr_Click(object sender, EventArgs e)
        {
            Process.Start("http://samsrv:8989");
            this.Alert("Sonarr Launched", Form_Alert.enmType.Success);
        }

        private void buttonRadarr_Click(object sender, EventArgs e)
        {
            Process.Start("http://samsrv:7878");
            this.Alert("Radarr Launched", Form_Alert.enmType.Success);
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

        private void buttonHeimdall_Click(object sender, EventArgs e)
        {
            Process.Start("http://samdocker.local:5080");
            this.Alert("Heimdall Launched", Form_Alert.enmType.Success);
        }

        private void buttonTpLink_Click(object sender, EventArgs e)
        {
            Process.Start("http://tplink.local/webpages/login.html?t=1476264749915");
            this.Alert("AdminTpLink Launched", Form_Alert.enmType.Success);
        }

        private void buttonPihole_Click(object sender, EventArgs e)
        {
            Process.Start("http://pihole.local/admin");
            this.Alert("Pihole Launched", Form_Alert.enmType.Success);
        }

        private void buttonAdguard_Click(object sender, EventArgs e)
        {
            Process.Start("http://samadguard.local");
            this.Alert("Adguard Launched", Form_Alert.enmType.Success);
        }

        private void buttonOpensense_Click(object sender, EventArgs e)
        {
            Process.Start("https://192.168.1.254");
            this.Alert("Opensense Launched", Form_Alert.enmType.Success);
        }

        private void buttonDuckdns_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.duckdns.org/domains");
            this.Alert("DuckDns Launched", Form_Alert.enmType.Success);
        }

        private void buttonProxmox2_Click(object sender, EventArgs e)
        {
            Process.Start("https://samproxmox2.local:8006");
            this.Alert("Samproxmox2 Launched", Form_Alert.enmType.Success);
        }

        private void buttonOwncloud_Click(object sender, EventArgs e)
        {
            Process.Start("http://samowncloud.local");
            this.Alert("Owncloud Launched", Form_Alert.enmType.Success);
        }

        private void buttonNZBFinder_Click(object sender, EventArgs e)
        {
            Process.Start("https://nzbfinder.ws/");
            this.Alert("NZBFinder Launched", Form_Alert.enmType.Success);
        }

        private void buttonNZBGet_Click(object sender, EventArgs e)
        {
            Process.Start("http://samsrv:6789/");
            this.Alert("NZBGet Launched", Form_Alert.enmType.Success);
        }

        private void buttonUsenetFarm_Click(object sender, EventArgs e)
        {
            Process.Start("https://usenet.farm/members.html#dashboard");
            this.Alert("Usenet.Farm Launched", Form_Alert.enmType.Success);
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
    }
}
