using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Security.Principal;
using System.Windows.Forms;

namespace LauncherForAll
{
    public partial class frmSettings : Form
    {
        // RedMod Colors
        // 255 255 255 White
        private Color WhiteColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));

        // 19 12 29 BlackPurple 
        private Color PurpleColor = Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(12)))), ((int)(((byte)(29)))));
        // 235 42 83 RedMod

        // DefaultMod Colors
        // 46 51 73 Blue
        private Color BackBlueColor = Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
        public frmSettings()
        {
            InitializeComponent();

            string programData = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);

            // RedMod ?
            if (File.Exists(programData + @"\LauncherForAll\Set_redMod.config"))
            {
                this.rjToggleButton2.CheckState = CheckState.Checked;
                this.BackColor = PurpleColor;

                this.pictureBox1.BackgroundImage = Properties.Resources.RedMod_DisableNotifIcon;
                this.buttonSettingsWifi.Image = Properties.Resources.RedMod_Ethernet;
                this.pictureBox3.BackgroundImage = Properties.Resources.RedMod_NoBorder;
                this.pictureBox4.BackgroundImage = Properties.Resources.RedMod_Apps_Icon;
                this.pictureBox5.BackgroundImage = Properties.Resources.defaut_use_white;
                this.pictureBox6.BackgroundImage = Properties.Resources.StartupWhite;

                this.label1.ForeColor = WhiteColor;
                this.label2.ForeColor = WhiteColor;
                this.label3.ForeColor = WhiteColor;
                this.label4.ForeColor = WhiteColor;
                this.label5.ForeColor = WhiteColor;
                this.label6.ForeColor = WhiteColor;

                this.buttonSettingsWifi.FlatAppearance.BorderColor = WhiteColor;

                this.buttonSettingsWifi.ForeColor = WhiteColor;
                this.buttonSettingsWifi.BackColor = PurpleColor;

                this.button1.FlatAppearance.BorderColor = WhiteColor;
                this.button1.ForeColor = WhiteColor;
                this.button1.BackColor = PurpleColor;
                this.button1.Image = Properties.Resources.RedMod_Wupdate;

            }
            else
            {
                this.rjToggleButton2.CheckState = CheckState.Unchecked;
                this.BackColor = BackBlueColor;

                this.pictureBox1.BackgroundImage = Properties.Resources.DisableNotifIcon;
                this.buttonSettingsWifi.Image = Properties.Resources.Ethernet;
                this.pictureBox3.BackgroundImage = Properties.Resources.NoBorder;
                this.pictureBox4.BackgroundImage = Properties.Resources.Apps_Icon;
                this.pictureBox5.BackgroundImage = Properties.Resources.defaut_user;
                this.pictureBox6.BackgroundImage = Properties.Resources.Startup;

                this.label1.ForeColor = Color.Black;
                this.label2.ForeColor = Color.Black;
                this.label3.ForeColor = Color.Black;
                this.label4.ForeColor = Color.Black;
                this.label5.ForeColor = Color.Black;
                this.label6.ForeColor = Color.Black;

                this.buttonSettingsWifi.ForeColor = Color.Black;
                this.buttonSettingsWifi.FlatAppearance.BorderColor = Color.Black;

                this.button1.ForeColor = Color.Black;
                this.button1.FlatAppearance.BorderColor = Color.Black;
                this.button1.Image = Properties.Resources.Wupdate;
            }

            // StartNotif ?
            if (File.Exists(programData + @"\LauncherForAll\Set_StartNotification.config"))
            {
                this.rjToggleButton1.CheckState = CheckState.Checked;
            }
            else
            {
                this.rjToggleButton1.CheckState = CheckState.Unchecked;
            }

            // ButtonsFlat ?
            if (File.Exists(programData + @"\LauncherForAll\Set_AppsFlat.config"))
            {
                this.rjToggleButton3.CheckState = CheckState.Checked;
            }
            else
            {
                this.rjToggleButton3.CheckState = CheckState.Unchecked;
            }

            // BrowseApps ?
            if (File.Exists(programData + @"\LauncherForAll\Set_BrowseApps.config"))
            {
                this.rjToggleButton4.CheckState = CheckState.Checked;
            }
            else
            {
                this.rjToggleButton4.CheckState = CheckState.Unchecked;
            }

            // ProfilePicture ?
            if (File.Exists(programData + @"\LauncherForAll\Set_ProfilePict.temp"))
            {
                this.rjToggleButton5.CheckState = CheckState.Checked;

            }
            else
            {
                this.rjToggleButton5.CheckState = CheckState.Unchecked;
            }

            // Startup ?
            string regPath = @"Software\Microsoft\Windows\CurrentVersion\Run";
            string keyName = "LauncherForAll";
            string keyValue = @"C:\Program Files\LauncherForAll\LauncherForAll.exe";

            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(regPath, true) ?? Registry.CurrentUser.CreateSubKey(regPath, true))
            {
                object existKeyValue = key.GetValue(keyName);

                if (existKeyValue != null && existKeyValue.ToString() == keyValue)
                {
                     this.rjToggleButton6.CheckState = CheckState.Checked;
                }
                else
                {
                    this.rjToggleButton6.CheckState = CheckState.Unchecked;
                }
            }
        }

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        private void buttonSettingsWifi_Click(object sender, EventArgs e)
        {
            Process.Start("ms-settings:network");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("ms-settings:windowsupdate-action");
        }
        [STAThread]
        private void rjToggleButton1_CheckedChanged(object sender, EventArgs e)
        {
            string programData = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);

            if (this.rjToggleButton1.Checked)
            {
                if (!File.Exists(programData + @"\LauncherForAll\Set_StartNotification.config"))
                {
                    File.WriteAllText(programData + @"\LauncherForAll\Set_StartNotification.config", "1");
                }
            }
            else
            {
                // Not redMod
                if (File.Exists(programData + @"\LauncherForAll\Set_StartNotification.config"))
                {
                    File.Delete(programData + @"\LauncherForAll\Set_StartNotification.config");
                }
                else
                {
                    try
                    {
                        File.Delete(programData + @"\LauncherForAll\Set_StartNotification.config");
                        File.WriteAllText(programData + @"\LauncherForAll\Set_StartNotification.config", "1");
                    }
                    catch (Exception)
                    {
                        File.WriteAllText(programData + @"\LauncherForAll\Set_StartNotification.config", "1");
                    }
                }
            }
        }

        private void rjToggleButton2_CheckedChanged(object sender, EventArgs e)
        {
            string programData = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);

            if (this.rjToggleButton2.Checked)
            {
                if (!File.Exists(programData + @"\LauncherForAll\Set_redMod.config"))
                {
                    File.WriteAllText(programData + @"\LauncherForAll\Set_redMod.config", "1");
                    Application.Restart();
                }
            }
            else
            {
                // Not redMod
                if (File.Exists(programData + @"\LauncherForAll\Set_redMod.config"))
                {
                    File.Delete(programData + @"\LauncherForAll\Set_redMod.config");

                    Application.Restart();
                }
                else
                {
                    try
                    {
                        File.Delete(programData + @"\LauncherForAll\Set_redMod.config");
                        File.WriteAllText(programData + @"\LauncherForAll\Set_redMod.config", "1");
                    }
                    catch (Exception)
                    {
                        File.WriteAllText(programData + @"\LauncherForAll\Set_redMod.config", "1");
                    }
                }
            }
        }

        private void rjToggleButton3_CheckedChanged(object sender, EventArgs e)
        {
            string programData = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);

            if (this.rjToggleButton3.Checked)
            {
                if (!File.Exists(programData + @"\LauncherForAll\Set_AppsFlat.config"))
                {
                    File.WriteAllText(programData + @"\LauncherForAll\Set_AppsFlat.config", "1");
                }
            }
            else
            {
                if (File.Exists(programData + @"\LauncherForAll\Set_AppsFlat.config"))
                {
                    File.Delete(programData + @"\LauncherForAll\Set_AppsFlat.config");
                }
                else
                {
                    try
                    {
                        File.Delete(programData + @"\LauncherForAll\Set_AppsFlat.config");
                        File.WriteAllText(programData + @"\LauncherForAll\Set_AppsFlat.config", "1");
                    }
                    catch (Exception)
                    {
                        File.WriteAllText(programData + @"\LauncherForAll\Set_AppsFlat.config", "1");
                    }
                }
            }
        }

        private void rjToggleButton4_CheckedChanged(object sender, EventArgs e)
        {
            string programData = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);

            if (this.rjToggleButton4.Checked)
            {
                if (!File.Exists(programData + @"\LauncherForAll\Set_BrowseApps.config"))
                {
                    File.WriteAllText(programData + @"\LauncherForAll\Set_BrowseApps.config", "1");
                }
            }
            else
            {
                if (File.Exists(programData + @"\LauncherForAll\Set_BrowseApps.config"))
                {
                    File.Delete(programData + @"\LauncherForAll\Set_BrowseApps.config");

                }
                else
                {
                    try
                    {
                        File.Delete(programData + @"\LauncherForAll\Set_BrowseApps.config");
                        File.WriteAllText(programData + @"\LauncherForAll\Set_BrowseApps.config", "1");
                    }
                    catch (Exception)
                    {
                        File.WriteAllText(programData + @"\LauncherForAll\Set_BrowseApps.config", "1");
                    }
                }
            }
        }

        private void rjToggleButton5_CheckedChanged(object sender, EventArgs e)
        {
            string programData = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            if (this.rjToggleButton5.Checked)
            {
                if (!File.Exists(programData + @"\LauncherForAll\Set_ProfilePict.temp"))
                {
                    File.WriteAllText(programData + @"\LauncherForAll\Set_ProfilePict.temp", "1");
                    Application.Restart();
                }
            }
            else
            {
                if (File.Exists(programData + @"\LauncherForAll\Set_ProfilePict.temp"))
                {
                    File.Delete(programData + @"\LauncherForAll\Set_ProfilePict.temp");
                    Application.Restart();
                }
                else
                {
                    try
                    {
                        File.Delete(programData + @"\LauncherForAll\Set_ProfilePict.temp");
                        File.WriteAllText(programData + @"\LauncherForAll\Set_ProfilePict.temp", "1");
                        Application.Restart();
                    }
                    catch (Exception)
                    {
                        File.WriteAllText(programData + @"\LauncherForAll\Set_ProfilePict.temp", "1");
                        Application.Restart();
                    }
                }
            }
        }
        private void rjToggleButton6_CheckedChanged(object sender, EventArgs e)
        {
            string regPath = @"Software\Microsoft\Windows\CurrentVersion\Run";
            string keyName = "LauncherForAll";
            string keyValue = @"C:\Program Files\LauncherForAll\LauncherForAll.exe";

            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(regPath, true) ?? Registry.CurrentUser.CreateSubKey(regPath, true))
            {
                object existKeyValue = key.GetValue(keyName);
                if (this.rjToggleButton6.Checked)
                {
                    key.SetValue(keyName, keyValue, RegistryValueKind.String);
                }
                else 
                { 
                    key.DeleteValue(keyName);
                }
            }
        }
    }
}
