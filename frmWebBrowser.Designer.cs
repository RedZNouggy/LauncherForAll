namespace LauncherForAll
{
    partial class frmWebBrowser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWebBrowser));
            this.pnlFormLoader = new System.Windows.Forms.Panel();
            this.buttonReload = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonBackRight = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.pnlFormLoader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFormLoader
            // 
            this.pnlFormLoader.Controls.Add(this.buttonReload);
            this.pnlFormLoader.Controls.Add(this.buttonBack);
            this.pnlFormLoader.Controls.Add(this.buttonBackRight);
            this.pnlFormLoader.Controls.Add(this.buttonHome);
            this.pnlFormLoader.Controls.Add(this.webBrowser1);
            this.pnlFormLoader.Location = new System.Drawing.Point(0, 0);
            this.pnlFormLoader.Name = "pnlFormLoader";
            this.pnlFormLoader.Size = new System.Drawing.Size(1000, 625);
            this.pnlFormLoader.TabIndex = 1;
            // 
            // buttonReload
            // 
            this.buttonReload.BackgroundImage = global::LauncherForAll.Properties.Resources.reload1;
            this.buttonReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonReload.FlatAppearance.BorderSize = 0;
            this.buttonReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReload.Location = new System.Drawing.Point(12, 193);
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(45, 45);
            this.buttonReload.TabIndex = 4;
            this.buttonReload.UseVisualStyleBackColor = true;
            this.buttonReload.Click += new System.EventHandler(this.buttonReload_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackgroundImage = global::LauncherForAll.Properties.Resources.Back;
            this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Location = new System.Drawing.Point(12, 82);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(45, 45);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonBackRight
            // 
            this.buttonBackRight.BackgroundImage = global::LauncherForAll.Properties.Resources.BackRight;
            this.buttonBackRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonBackRight.FlatAppearance.BorderSize = 0;
            this.buttonBackRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackRight.Location = new System.Drawing.Point(12, 142);
            this.buttonBackRight.Name = "buttonBackRight";
            this.buttonBackRight.Size = new System.Drawing.Size(45, 45);
            this.buttonBackRight.TabIndex = 2;
            this.buttonBackRight.UseVisualStyleBackColor = true;
            this.buttonBackRight.Click += new System.EventHandler(this.buttonBackRight_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.BackgroundImage = global::LauncherForAll.Properties.Resources.Home;
            this.buttonHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Location = new System.Drawing.Point(12, 21);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(45, 45);
            this.buttonHome.TabIndex = 1;
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(63, 12);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(925, 601);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("https://google.com", System.UriKind.Absolute);
            // 
            // frmWebBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1000, 625);
            this.Controls.Add(this.pnlFormLoader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmWebBrowser";
            this.Text = "frmWebBrowser";
            this.pnlFormLoader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFormLoader;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonBackRight;
        private System.Windows.Forms.Button buttonReload;
    }
}