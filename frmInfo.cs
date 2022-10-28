using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace LauncherForAll
{
    public partial class frmInfo : Form
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

        // DefaultMod Colors
        // 46 51 73 Blue
        private Color BackBlueColor = Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
        // 28 37 55 BlackBlue
        private Color BackBlackBlueColor = Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));

        public frmInfo()
        {
            InitializeComponent();

            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            string programData = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);

            if (File.Exists(programData + @"\LauncherForAll\Set_redMod.config"))
            {
                this.BackColor = BlackPurpleColor;
            }
            else
            {
                this.BackColor = BackBlackBlueColor;
            }
            this.label1.ForeColor = WhiteColor;
            this.buttonExit.ForeColor = WhiteColor;
            this.label1.Text = "This application is programed in C# + .NET and is using some dll imported \n and .png,.ico,.jpg,.jpeg files. Disigned and used first by Samuel PAGES \n alias RedZ_Nouggy, this application is a Launcher of all your games \n and applications which are listed in the Launcher.";
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            frmInfo.ActiveForm.Close();
        }
    }
}
