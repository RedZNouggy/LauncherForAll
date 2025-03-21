﻿using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LauncherForAll
{
    public partial class frmWebBrowser : Form
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

        // DefaultMod Colors
        // 46 51 73 Blue
        private readonly Color BackBlueColor = Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
        // 28 37 55 BlackBlue
        private readonly Color BackBlackBlueColor = Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
        // 0 126 249 Blue
        private readonly Color BlueColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));

        public frmWebBrowser()
        {
            InitializeComponent();

            string programData = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);

            // RedMod ?
            if (File.Exists(programData + @"\LauncherForAll\Set_redMod.config"))
            {
                this.BackColor = PurpleColor;
                this.buttonHome.BackgroundImage = Properties.Resources.RedMod_Home;
                this.buttonBackRight.BackgroundImage = Properties.Resources.RedMod_BackRight;
                this.buttonBack.BackgroundImage = Properties.Resources.RedMod_Back;
                this.buttonReload.BackgroundImage = Properties.Resources.reload_red;
            }
            else
            {
                this.BackColor = BackBlueColor;
                this.buttonHome.BackgroundImage = Properties.Resources.Home;
                this.buttonBackRight.BackgroundImage = Properties.Resources.BackRight;
                this.buttonBack.BackgroundImage = Properties.Resources.Back;
                this.buttonReload.BackgroundImage = Properties.Resources.reload1;
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.webBrowser1.GoBack();
        }

        private void buttonBackRight_Click(object sender, EventArgs e)
        {
            this.webBrowser1.GoForward();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate("https://google.com");
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            // Skip refresh if about:blank is loaded to avoid removing
            // content specified by the DocumentText property.
            if (!webBrowser1.Url.Equals("about:blank"))
            {
                webBrowser1.Refresh();
            }
        }
    }
}
