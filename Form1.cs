using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Windows.Forms;

namespace LauncherForAll
{
    public partial class Form1 : Form
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

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        public Form1()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = buttonGames.Height;
            pnlNav.Top = buttonGames.Top;
            pnlNav.Left = buttonGames.Left;
            this.CenterToScreen();
            label2.Text = Environment.UserName;
        }

        private Image GetUserProfileImage()
        {
            try
            {
                // Open The Key
                using (RegistryKey userKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\AccountPicture\Users\"))
                {
                    // Get SID (Security Identifier) of Current User
                    string currentUserSID = WindowsIdentity.GetCurrent().User.Value;

                    // Open subkey
                    using (RegistryKey currentUserKey = userKey.OpenSubKey(currentUserSID))
                    {
                        // Read Access Path to Image
                        string userProfileImagePath = (string)currentUserKey.GetValue("Image64");

                        // Get data
                        if (!string.IsNullOrEmpty(userProfileImagePath) && File.Exists(userProfileImagePath))
                        {
                            return Image.FromFile(userProfileImagePath);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            siticoneShadowForm1.SetShadowForm(this);

            string programData = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);

            // StartNotification ?
            if (!File.Exists(programData + @"\LauncherForAll\Set_StartNotification.config"))
            {
                // redMod
                if (File.Exists(programData + @"\LauncherForAll\Set_redMod.config"))
                {
                    notifyIcon2.Visible = true;
                    notifyIcon2.ShowBalloonTip(1000);
                    this.notifyIcon2.ContextMenuStrip = this.contextMenuStrip1;
                }
                // Not redMod
                else
                {
                    this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
                    notifyIcon1.Visible = true;
                    notifyIcon1.ShowBalloonTip(1000);
                }
            }

            // RedMod ?
            if (File.Exists(programData + @"\LauncherForAll\Set_redMod.config"))
            {
                this.BackColor = PurpleColor;

                this.panel1.BackColor = BlackPurpleColor;

                // Get User Profile Picture
                Image userProfileImage = GetUserProfileImage();

                if (userProfileImage != null & File.Exists(programData + @"\LauncherForAll\Set_ProfilePict.temp"))
                {
                    pictureBox1.Image = userProfileImage;
                }
                else
                {
                    pictureBox1.Image = Properties.Resources.RedMod_ProfileDefault_2;
                }

                // Title
                this.pictureBox2.Image = Properties.Resources.RedMod_Title;

                this.buttonGames.BackgroundImage = Properties.Resources.Background_Buttons1;
                this.buttonGames.ForeColor = WhiteColor;
                this.buttonGames.Image = Properties.Resources.RedMod_Games;

                this.buttonOtherApps.BackgroundImage = Properties.Resources.Background_Buttons1;
                this.buttonOtherApps.ForeColor = WhiteColor;
                this.buttonOtherApps.Image = Properties.Resources.RedMod_Apps;

                this.buttonSamEnv.BackgroundImage = Properties.Resources.Background_Buttons1;
                this.buttonSamEnv.ForeColor = WhiteColor;
                this.buttonSamEnv.Image = Properties.Resources.Red_samsrv;

                this.buttonSettings.BackgroundImage = Properties.Resources.Background_Buttons1;
                this.buttonSettings.Image = Properties.Resources.RedMod_settings;
                this.buttonSettings.ForeColor = WhiteColor;

                this.buttonWebBrowser.BackgroundImage = Properties.Resources.Background_Buttons1;
                this.buttonWebBrowser.Image = Properties.Resources.RedMod_webBrowser;
                this.buttonWebBrowser.ForeColor = WhiteColor;

                this.label2.ForeColor = RedModColor;
                this.pnlNav.BackColor = RedModColor;

                this.buttonExit.ForeColor = WhiteColor;
                this.buttonMinimize.ForeColor = WhiteColor;

                this.Icon = Properties.Resources.RedMod_Logo;
            }
            else
            {
                this.BackColor = BackBlueColor;

                this.panel1.BackColor = BackBlackBlueColor;

                // Get User Profile Picture
                Image userProfileImage = GetUserProfileImage();

                if (userProfileImage != null & File.Exists(programData + @"\LauncherForAll\Set_ProfilePict.temp"))
                {
                    pictureBox1.Image = userProfileImage;
                }
                else
                {
                    pictureBox1.Image = Properties.Resources.ProfileDefault;
                }

                this.label2.ForeColor = BlueColor;
                this.pnlNav.BackColor = BlueColor;

                // Title
                this.pictureBox2.Image = Properties.Resources.Title1;

                this.buttonGames.BackgroundImage = Properties.Resources.Background_Buttons;
                this.buttonGames.ForeColor = BlueColor;
                this.buttonGames.Image = Properties.Resources.BlueMod_Games;

                this.buttonOtherApps.BackgroundImage = Properties.Resources.Background_Buttons;
                this.buttonOtherApps.ForeColor = BlueColor;
                this.buttonOtherApps.Image = Properties.Resources.BlueMod_Apps;

                this.buttonSamEnv.BackgroundImage = Properties.Resources.Background_Buttons;
                this.buttonSamEnv.ForeColor = BlueColor;
                this.buttonSamEnv.Image = Properties.Resources.Blue_samsrv;

                this.buttonSettings.BackgroundImage = Properties.Resources.Background_Buttons;
                this.buttonSettings.Image = Properties.Resources.settings;
                this.buttonSettings.ForeColor = BlueColor;

                this.buttonWebBrowser.BackgroundImage = Properties.Resources.Background_Buttons;
                this.buttonWebBrowser.Image = Properties.Resources.webBrowser;
                this.buttonWebBrowser.ForeColor = BlueColor;

                this.buttonExit.ForeColor = Color.Black;
                this.buttonMinimize.ForeColor = Color.Black;

                this.Icon = Properties.Resources.LauncherForAll;
            }
        }

        private void buttonGames_Click(object sender, EventArgs e)
        {
            pnlNav.Height = buttonGames.Height;
            pnlNav.Top = buttonGames.Top;
            pnlNav.Left = buttonGames.Left;

            this.pnlFormLoader.Controls.Clear();
            frmGames frmGames_vrb = new frmGames() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmGames_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmGames_vrb);
            frmGames_vrb.Show();
        }

        private void buttonOtherApps_Click(object sender, EventArgs e)
        {
            pnlNav.Height = buttonOtherApps.Height;
            pnlNav.Top = buttonOtherApps.Top;
            pnlNav.Left = buttonOtherApps.Left;

            this.pnlFormLoader.Controls.Clear();
            frmOtherApps frmOtherApps_vrb = new frmOtherApps() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmOtherApps_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmOtherApps_vrb);
            frmOtherApps_vrb.Show();
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            pnlNav.Height = buttonSettings.Height;
            pnlNav.Top = buttonSettings.Top;
            pnlNav.Left = buttonSettings.Left;

            this.pnlFormLoader.Controls.Clear();
            frmSettings frmSettings_vrb = new frmSettings() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmSettings_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmSettings_vrb);
            frmSettings_vrb.Show();
        }

        private void buttonWebBrowser_Click(object sender, EventArgs e)
        {
            pnlNav.Height = buttonWebBrowser.Height;
            pnlNav.Top = buttonWebBrowser.Top;
            pnlNav.Left = buttonWebBrowser.Left;

            this.pnlFormLoader.Controls.Clear();
            frmWebBrowser WebBrowser_vrb = new frmWebBrowser() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            WebBrowser_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(WebBrowser_vrb);
            WebBrowser_vrb.Show();
        }

        private void buttonSamEnv_Click(object sender, EventArgs e)
        {
            pnlNav.Height = buttonSamEnv.Height;
            pnlNav.Top = buttonSamEnv.Top;
            pnlNav.Left = buttonSamEnv.Left;

            this.pnlFormLoader.Controls.Clear();
            frmSamEnv SamEnv_vrb = new frmSamEnv() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            SamEnv_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(SamEnv_vrb);
            SamEnv_vrb.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.WindowState = FormWindowState.Minimized;
        }

        private void toolStripMenuItemRTX_Click(object sender, EventArgs e)
        {
            Process.Start(@"https://www.rueducommerce.fr/rayon/composants-16/nvidia-geforce-rtx-3080-124303");
            Process.Start(@"https://www.ldlc.com/recherche/RTX3080/");
            Process.Start(@"https://www.cybertek.fr/boutique/produit.aspx?q=RTX%2b3080");
            Process.Start(@"https://www.rue-montgallet.com/prix/rechercher?kw=RTX+3080");
            Process.Start(@"https://www.amazon.fr/s?k=RTX+3070&__mk_fr_FR=%C3%85M%C3%85%C5%BD%C3%95%C3%91&ref=nb_sb_noss_2");
            Process.Start(@"https://www.ldlc.com/recherche/RTX3070/");
            Process.Start(@"https://dropreference.com/#/home/gpu");
        }

        private void toolStripMenuItemInfos_Click(object sender, EventArgs e)
        {
            frmInfo frmInfos_vrb = new frmInfo();
            frmInfos_vrb.Show();
        }

        private void toolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}