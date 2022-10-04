using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LauncherForAll
{
    public partial class frmWebBrowser : Form
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

        // DefaultMod Colors
        // 46 51 73 Blue
        private Color BackBlueColor = Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
        // 28 37 55 BlackBlue
        private Color BackBlackBlueColor = Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
        // 0 126 249 Blue
        private Color BlueColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));

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

            }
            else
            {
                this.BackColor = BackBlueColor;
                this.buttonHome.BackgroundImage = Properties.Resources.Home;
                this.buttonBackRight.BackgroundImage = Properties.Resources.BackRight;
                this.buttonBack.BackgroundImage = Properties.Resources.Back;
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
    }
}
