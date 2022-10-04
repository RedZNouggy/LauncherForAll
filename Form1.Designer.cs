namespace LauncherForAll
{ 
    public partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonExit = new System.Windows.Forms.Button();
            this.pnlFormLoader = new System.Windows.Forms.Panel();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticoneShadowForm1 = new Siticone.Desktop.UI.WinForms.SiticoneShadowForm(this.components);
            this.siticoneDragControl1 = new Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemRTX = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemInfos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonOtherApps = new System.Windows.Forms.Button();
            this.buttonGames = new System.Windows.Forms.Button();
            this.buttonWebBrowser = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.notifyIcon2 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Transparent;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonExit.Location = new System.Drawing.Point(1263, 12);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(25, 25);
            this.buttonExit.TabIndex = 13;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // pnlFormLoader
            // 
            this.pnlFormLoader.Location = new System.Drawing.Point(300, 168);
            this.pnlFormLoader.Name = "pnlFormLoader";
            this.pnlFormLoader.Size = new System.Drawing.Size(1000, 625);
            this.pnlFormLoader.TabIndex = 14;
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.BackColor = System.Drawing.Color.Transparent;
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinimize.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonMinimize.Location = new System.Drawing.Point(1233, 12);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(25, 25);
            this.buttonMinimize.TabIndex = 15;
            this.buttonMinimize.Text = "_";
            this.buttonMinimize.UseVisualStyleBackColor = false;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.BackColor = System.Drawing.Color.Transparent;
            this.siticonePanel1.Location = new System.Drawing.Point(300, 0);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.ShadowDecoration.Parent = this.siticonePanel1;
            this.siticonePanel1.Size = new System.Drawing.Size(927, 40);
            this.siticonePanel1.TabIndex = 16;
            // 
            // siticoneShadowForm1
            // 
            this.siticoneShadowForm1.TargetForm = this;
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.TargetControl = this.siticonePanel1;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "LauncherForAll has been launched successfully";
            this.notifyIcon1.BalloonTipTitle = "Launched Successfull";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "LauncherForAll";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemRTX,
            this.toolStripMenuItemInfos,
            this.toolStripMenuItemExit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(146, 70);
            // 
            // toolStripMenuItemRTX
            // 
            this.toolStripMenuItemRTX.Image = global::LauncherForAll.Properties.Resources.RTX;
            this.toolStripMenuItemRTX.Name = "toolStripMenuItemRTX";
            this.toolStripMenuItemRTX.Size = new System.Drawing.Size(145, 22);
            this.toolStripMenuItemRTX.Text = "RTX";
            this.toolStripMenuItemRTX.Click += new System.EventHandler(this.toolStripMenuItemRTX_Click);
            // 
            // toolStripMenuItemInfos
            // 
            this.toolStripMenuItemInfos.Image = global::LauncherForAll.Properties.Resources.infos;
            this.toolStripMenuItemInfos.Name = "toolStripMenuItemInfos";
            this.toolStripMenuItemInfos.Size = new System.Drawing.Size(145, 22);
            this.toolStripMenuItemInfos.Text = "Informations";
            this.toolStripMenuItemInfos.Click += new System.EventHandler(this.toolStripMenuItemInfos_Click);
            // 
            // toolStripMenuItemExit
            // 
            this.toolStripMenuItemExit.Image = global::LauncherForAll.Properties.Resources.PowerOff;
            this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            this.toolStripMenuItemExit.Size = new System.Drawing.Size(145, 22);
            this.toolStripMenuItemExit.Text = "Exit Launcher";
            this.toolStripMenuItemExit.Click += new System.EventHandler(this.toolStripMenuItemExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.panel1.Controls.Add(this.pnlNav);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.buttonSettings);
            this.panel1.Controls.Add(this.buttonOtherApps);
            this.panel1.Controls.Add(this.buttonGames);
            this.panel1.Controls.Add(this.buttonWebBrowser);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 795);
            this.panel1.TabIndex = 0;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnlNav.Location = new System.Drawing.Point(0, 273);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(3, 250);
            this.pnlNav.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label2.Location = new System.Drawing.Point(116, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "UserName";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::LauncherForAll.Properties.Resources.ProfileDefault;
            this.pictureBox1.Location = new System.Drawing.Point(115, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // buttonSettings
            // 
            this.buttonSettings.FlatAppearance.BorderSize = 0;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.buttonSettings.Image = global::LauncherForAll.Properties.Resources.settings;
            this.buttonSettings.Location = new System.Drawing.Point(0, 603);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(300, 90);
            this.buttonSettings.TabIndex = 1;
            this.buttonSettings.Text = "      Settings";
            this.buttonSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // buttonOtherApps
            // 
            this.buttonOtherApps.FlatAppearance.BorderSize = 0;
            this.buttonOtherApps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOtherApps.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOtherApps.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.buttonOtherApps.Image = global::LauncherForAll.Properties.Resources.BlueMod_Apps;
            this.buttonOtherApps.Location = new System.Drawing.Point(0, 283);
            this.buttonOtherApps.Name = "buttonOtherApps";
            this.buttonOtherApps.Size = new System.Drawing.Size(300, 71);
            this.buttonOtherApps.TabIndex = 1;
            this.buttonOtherApps.Text = "    Other Apps   ";
            this.buttonOtherApps.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonOtherApps.UseVisualStyleBackColor = true;
            this.buttonOtherApps.Click += new System.EventHandler(this.buttonOtherApps_Click);
            // 
            // buttonGames
            // 
            this.buttonGames.FlatAppearance.BorderSize = 0;
            this.buttonGames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGames.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGames.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.buttonGames.Image = global::LauncherForAll.Properties.Resources.BlueMod_Games;
            this.buttonGames.Location = new System.Drawing.Point(0, 202);
            this.buttonGames.Name = "buttonGames";
            this.buttonGames.Size = new System.Drawing.Size(301, 75);
            this.buttonGames.TabIndex = 1;
            this.buttonGames.Text = "     Games          ";
            this.buttonGames.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonGames.UseVisualStyleBackColor = true;
            this.buttonGames.Click += new System.EventHandler(this.buttonGames_Click);
            // 
            // buttonWebBrowser
            // 
            this.buttonWebBrowser.FlatAppearance.BorderSize = 0;
            this.buttonWebBrowser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWebBrowser.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWebBrowser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.buttonWebBrowser.Image = global::LauncherForAll.Properties.Resources.webBrowser;
            this.buttonWebBrowser.Location = new System.Drawing.Point(0, 360);
            this.buttonWebBrowser.Name = "buttonWebBrowser";
            this.buttonWebBrowser.Size = new System.Drawing.Size(300, 71);
            this.buttonWebBrowser.TabIndex = 1;
            this.buttonWebBrowser.Text = "     Web Browser";
            this.buttonWebBrowser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonWebBrowser.UseVisualStyleBackColor = true;
            this.buttonWebBrowser.Click += new System.EventHandler(this.buttonWebBrowser_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::LauncherForAll.Properties.Resources.Title1;
            this.pictureBox2.Location = new System.Drawing.Point(533, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(600, 173);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // notifyIcon2
            // 
            this.notifyIcon2.BalloonTipText = "LauncherForAll has been launched successfully";
            this.notifyIcon2.BalloonTipTitle = "Launched Successfull";
            this.notifyIcon2.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon2.Icon")));
            this.notifyIcon2.Text = "LauncherForAll";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1300, 795);
            this.Controls.Add(this.siticonePanel1);
            this.Controls.Add(this.buttonMinimize);
            this.Controls.Add(this.pnlFormLoader);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1920, 1040);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LauncherrForAll";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonOtherApps;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button buttonGames;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonMinimize;
        internal Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneShadowForm siticoneShadowForm1;
        private Siticone.Desktop.UI.WinForms.SiticoneDragControl siticoneDragControl1;
        public System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRTX;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemInfos;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
        private System.Windows.Forms.Panel pnlFormLoader;
        public System.Windows.Forms.NotifyIcon notifyIcon2;
        private System.Windows.Forms.Button buttonWebBrowser;
    }
}

