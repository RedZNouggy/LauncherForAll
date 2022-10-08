using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace LauncherForAll
{
    public partial class frmGames : Form
    {
        // RedMod Colors
        // 255 255 255 White
        private Color WhiteColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));

        // 11 7 17 Purple
        private Color BlackPurpleColor = Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
        // 19 12 29 BlackPurple 
        private Color PurpleColor = Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(12)))), ((int)(((byte)(29)))));

        // DefaultMod Colors
        // 46 51 73 Blue
        private Color BackBlueColor = Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
        // 28 37 55 BlackBlue
        private Color BackBlackBlueColor = Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));

        public frmGames()
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
            frmGames2 frmGames2_vrb = new frmGames2() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmGames2_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmGames2_vrb);
            frmGames2_vrb.Show();
        }

        private void buttonRocketLeague_Click(object sender, EventArgs e)
        {
            string programData = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            // If RocketLeague Is already Running Dont do anithing...
            if (Process.GetProcessesByName("RocketLeague").Length > 0)
            {
                this.Alert("RocketLeague is already running", Form_Alert.enmType.Warning);
            }
            else if (Process.GetProcessesByName("RocketLeague").Length == 0)
            {
                if (File.Exists(programData + @"\LauncherForAll\PathList\RocketLeague.config"))
                {
                    // Preparing the launch of RocketLeague
                    Process RocketLeague = new Process();

                    RocketLeague.StartInfo.FileName = File.ReadAllLines(programData + @"\LauncherForAll\PathList\RimWorld.config").ToString(); 

                }
                else 
                {
                    // Preparing the launch of RocketLeague
                    Process RocketLeague = new Process();
                    RocketLeague.StartInfo.FileName = @"com.epicgames.launcher://apps/9773aa1aa54f4f7b80e44bef04986cea%3A530145df28a24424923f5828cc9031a1%3ASugar?action=launch&silent=true";

                    if (Process.GetProcessesByName("EpicGamesLauncher").Length == 0 & Process.GetProcessesByName("BakkesMod").Length == 0)
                    {
                        // Preparing the launch of EpicGames
                        Process EpicGames = new Process();
                        EpicGames.StartInfo.FileName = @"S:\Epic Games\Launcher\Portal\Binaries\Win32\EpicGamesLauncher.exe";

                        // Preparing the launch of BakkesMod
                        Process BakkesMod = new Process();
                        BakkesMod.StartInfo.FileName = @"C:\Program Files\BakkesMod\BakkesMod.exe";

                        //Launching BakkesMod & EpicGames
                        BakkesMod.Start();
                        EpicGames.Start();

                        // Wait 4seconds
                        Thread.Sleep(4000);

                        // Launch RocketLeague
                        RocketLeague.Start();
                        if (RocketLeague.Responding == true)
                        {
                            this.Alert("RocketLeague Launched", Form_Alert.enmType.Success);
                        }
                        else
                        {
                            this.Alert("RocketLeague not Launched", Form_Alert.enmType.Error);
                        }
                    }
                    else if (Process.GetProcessesByName("EpicGamesLauncher").Length == 0 | Process.GetProcessesByName("BakkesMod").Length == 0)
                    {
                        if (Process.GetProcessesByName("EpicGamesLauncher").Length == 0)
                        {
                            // Same but without launching BakkesMod
                            this.Alert("BakkesMod is already Launched", Form_Alert.enmType.Warning);

                            // Preparing the launch of EpicGames
                            Process EpicGames = new Process();
                            EpicGames.StartInfo.FileName = @"S:\Epic Games\Launcher\Portal\Binaries\Win32\EpicGamesLauncher.exe";

                            //Launching EpicGames
                            EpicGames.Start();

                            // Wait 4seconds
                            Thread.Sleep(4000);

                            // Launch RocketLeague
                            RocketLeague.Start();
                            if (RocketLeague.Responding == true)
                            {
                                this.Alert("RocketLeague Launched", Form_Alert.enmType.Success);
                            }
                            else
                            {
                                this.Alert("RocketLeague not Launched", Form_Alert.enmType.Error);
                            }
                        }
                        if (Process.GetProcessesByName("BakkesMod").Length == 0)
                        {
                            // Same but without launching EpicGames
                            this.Alert("EpicGames is already Launched", Form_Alert.enmType.Warning);


                            // Preparing the launch of BakkesMod
                            Process BakkesMod = new Process();
                            BakkesMod.StartInfo.FileName = @"S:\BakkesMod\BakkesMod.exe";


                            //Launching BakkesMod
                            BakkesMod.Start();

                            // Wait 4seconds
                            Thread.Sleep(4000);

                            // Launch RocketLeague
                            RocketLeague.Start();
                            if (RocketLeague.Responding == true)
                            {
                                this.Alert("RocketLeague Launched", Form_Alert.enmType.Success);
                            }
                            else
                            {
                                this.Alert("RocketLeague not Launched", Form_Alert.enmType.Error);
                            }

                        }
                    }
                    else
                    {
                        // Launch RocketLeague
                        RocketLeague.Start();
                        if (RocketLeague.Responding == true)
                        {
                            this.Alert("RocketLeague Launched", Form_Alert.enmType.Success);
                        }
                        else
                        {
                            this.Alert("RocketLeague not Launched", Form_Alert.enmType.Error);
                        }
                    }
                }

            }
        }

        private void buttonLeagueOfLegends_Click(object sender, EventArgs e)
        {
            // If LeagueOfLegends Is already Running Dont do anithing...
            if (Process.GetProcessesByName("LeagueClient").Length > 0)
            {
                this.Alert("LeagueClient is already running", Form_Alert.enmType.Warning);
            }
            else if (Process.GetProcessesByName("LeagueClient").Length == 0 & Process.GetProcessesByName("RiotClientUx").Length == 0 & Process.GetProcessesByName("Overwolf").Length == 0)
            {
                Process LeagueClient = new Process();
                Process Overwolf = new Process();

                // Preparing the launch of LeagueClient
                LeagueClient.StartInfo.FileName = @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Riot Games\Riot Client.lnk";

                // Preparing the launch of Overwolf
                Overwolf.StartInfo.FileName = @"D:\Overwolf\OverwolfLauncher.exe";
                Overwolf.StartInfo.Arguments = @" -launchapp pibhbkkgefgheeglaeemkkfjlhidhcedalapdggh -from-startmenu";

                // Launch Overwolf & LeagueClient
                Overwolf.Start();
                LeagueClient.Start();
                if (LeagueClient.Responding == true)
                {
                    this.Alert("LeagueClient Launched", Form_Alert.enmType.Success);
                }
                else
                {
                    this.Alert("LeagueClient not Launched", Form_Alert.enmType.Success);
                }
            }
            else if ((Process.GetProcessesByName("LeagueClient").Length == 0 | Process.GetProcessesByName("RiotClientUx").Length == 0) & (Process.GetProcessesByName("Overwolf").Length > 0))
            {
                // Same but Without Launching Overwolf
                this.Alert("Overwolf is already Launched", Form_Alert.enmType.Warning);
                Process LeagueClient = new Process();

                // Preparing the launch of LeagueClient
                LeagueClient.StartInfo.FileName = @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Riot Games\Riot Client.lnk";

                // Launch LeagueClient
                LeagueClient.Start();
                if (LeagueClient.Responding == true)
                {
                    this.Alert("LeagueClient Launched", Form_Alert.enmType.Success);
                }
                else
                {
                    this.Alert("LeagueClient not Launched", Form_Alert.enmType.Success);
                }
            }
        }
        private void buttonCSGO_Click(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName("csgo").Length == 0)
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
                Process csgo = new Process();

                // Preparing the launch of csgo
                csgo.StartInfo.FileName = @"steam://rungameid/730";
                csgo.StartInfo.Arguments = @"+fps_max 165 - high - novid - refresh 165 - nojoy + r_dynamic 0 - console - threads 4 + cl_interp 0 + cl_interp_ratio 1 + cl_updaterate 128 + cl_forcepreload 1";

                // Launch csgo
                csgo.Start();
                if (csgo.Responding == true)
                {
                    this.Alert("CS:GO Launched", Form_Alert.enmType.Success);
                }
                else
                {
                    this.Alert("CS:GO not Launched", Form_Alert.enmType.Success);
                }
            }
            else if (Process.GetProcessesByName("csgo").Length > 0)
            {
                this.Alert("CS:GO is already Launched", Form_Alert.enmType.Warning);
            }
            if (Process.GetProcessesByName("vibranceGUI").Length == 0)
            {
                Process vibranceGUI = new Process();

                // Preparing the launch of VibranceGUI
                vibranceGUI.StartInfo.FileName = @"D:\TOUT\APPLICATIONS\vibranceGUI.exe";
                
                // Launch vibranceGUI
                vibranceGUI.Start();
            }
        }
        private void buttonValorant_Click(object sender, EventArgs e)
        {
            // If Valorant Is already Running Dont do anithing...
            if (Process.GetProcessesByName("Valorant").Length > 0)
            {
                this.Alert("Valorant is already running", Form_Alert.enmType.Warning);
            }
            else if (Process.GetProcessesByName("Valorant").Length == 0 & Process.GetProcessesByName("RiotClientUx").Length == 0 & Process.GetProcessesByName("vibranceGUI").Length == 0)
            {
                Process Valorant = new Process();
                Process vibranceGUI = new Process();

                // Preparing the launch of Valorant
                Valorant.StartInfo.FileName = @"S:\Riot Games\Riot Client\RiotClientServices.exe";
                Valorant.StartInfo.Arguments = @"--launch - product = league_of_legends--launch - patchline = live";

                // Preparing the launch of VibranceGUI
                vibranceGUI.StartInfo.FileName = @"D:\TOUT\APPLICATIONS\vibranceGUI.exe";

                // Launch vibranceGUI & Valorant
                vibranceGUI.Start();
                Valorant.Start();
                this.Alert("Valorant Launched", Form_Alert.enmType.Success);
            }
            else if ((Process.GetProcessesByName("Valorant").Length == 0 | Process.GetProcessesByName("RiotClientUx").Length == 0) & (Process.GetProcessesByName("Overwolf").Length > 0))
            {
                // Same but Without Launching Overwolf
                this.Alert("Overwolf is already Launched", Form_Alert.enmType.Warning);
                Process Valorant = new Process();

                // Preparing the launch of LeagueClient
                Valorant.StartInfo.FileName = @"S:\Riot Games\Riot Client\RiotClientServices.exe";
                Valorant.StartInfo.Arguments = @"--launch - product = valorant--launch - patchline = live";

                // Launch Valorant
                Valorant.Start();
                this.Alert("Valorant Launched", Form_Alert.enmType.Success);
            }
        }

        private void buttonDiablo3_Click(object sender, EventArgs e)
        {
            this.Alert("DiabloIII Launched", Form_Alert.enmType.Success);
        }

        private void buttonMinecraft_Click(object sender, EventArgs e)
        {
            // If Minecraft Is already Running Dont do anithing...
            if (Process.GetProcessesByName("Minecraft").Length > 0)
            {
                this.Alert("Minecraft DE is already running", Form_Alert.enmType.Warning);
            }
            else
            {
                // Preparing the launch of Minecraft
                Process Minecraft = new Process();
                Minecraft.StartInfo.FileName = @"C:\Windows\explorer.exe";
                Minecraft.StartInfo.Arguments = @" shell:appsFolder\Microsoft.4297127D64EC6_8wekyb3d8bbwe!Minecraft";

                // Launch Minecraft
                Minecraft.Start();
                this.Alert("Minecraft Launched", Form_Alert.enmType.Success);
            }
        }

        private void buttonAOE3D_Click(object sender, EventArgs e)
        {
            // If HMM Is already Running Dont do anithing...
            if (Process.GetProcessesByName("AoE3DE_s").Length > 0)
            {
                this.Alert("AoEIII DE is already running", Form_Alert.enmType.Warning);
            }
            else
            {
                // If Steam Is already Running :
                if (Process.GetProcessesByName("Steam").Length == 0)
                {
                    // Preparing the launch of Steam
                    Process Steam = new Process();
                    Steam.StartInfo.FileName = @"S:\Steam\Steam.exe";

                    // Launch Steam
                    Steam.Start();
                }

                // Preparing the launch of AoE3DE_s
                Process AoEIII = new Process();
                AoEIII.StartInfo.FileName = @"steam://rungameid/933110";

                // Launch AoE3DE_s
                AoEIII.Start();
                this.Alert("AoE III DE Launched", Form_Alert.enmType.Success);
            }
        }

        private void buttonHMM_Click(object sender, EventArgs e)
        {
            // If HMM Is already Running Dont do anithing...
            if (Process.GetProcessesByName("HOMM3 2.0").Length > 0)
            {
                this.Alert("HoM&M is already running", Form_Alert.enmType.Warning);
            }
            else
            {
                // If Steam Is already Running :
                if (Process.GetProcessesByName("Steam").Length == 0)
                {
                    // Preparing the launch of Steam
                    Process Steam = new Process();
                    Steam.StartInfo.FileName = @"S:\Steam\Steam.exe";

                    // Launch Steam
                    Steam.Start();
                }

                // Preparing the launch of HMM
                Process HMM = new Process();
                HMM.StartInfo.FileName = @"steam://rungameid/297000";

                // Launch HMM
                HMM.Start();
                this.Alert("HoM&M Launched", Form_Alert.enmType.Success);
            }
        }

        private void buttonOverwatch_Click(object sender, EventArgs e)
        {
            // If Overwatch Is already Running Dont do anithing...
            if (Process.GetProcessesByName("Overwatch").Length > 0)
            {
                this.Alert("Overwatch is already running", Form_Alert.enmType.Warning);
            }
            else
            {
                // If Battle.net Is already Running :
                if (Process.GetProcessesByName("Battle.net").Length == 0)
                {
                    // Preparing the launch of Steam
                    Process Battlenet = new Process();
                    Battlenet.StartInfo.FileName = @"D:\Battle.net\Battle.net Launcher.exe";

                    // Launch Steam
                    Battlenet.Start();
                }

                // Preparing the launch of Overwatch
                Process Overwatch = new Process();
                Overwatch.StartInfo.FileName = @"D:\Overwatch\Overwatch Launcher.exe";
                Overwatch.StartInfo.Arguments = @" --productcode=pro";

                // Launch Overwatch
                Overwatch.Start();
                this.Alert("Overwatch Launched", Form_Alert.enmType.Success);
            }
        }
    }
}
