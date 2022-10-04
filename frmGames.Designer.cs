namespace LauncherForAll
{
    partial class frmGames
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGames));
            this.pnlFormLoader = new System.Windows.Forms.Panel();
            this.buttonNext1 = new Siticone.Desktop.UI.WinForms.SiticoneRoundedButton();
            this.buttonHMM = new System.Windows.Forms.Button();
            this.buttonAOE3D = new System.Windows.Forms.Button();
            this.buttonMinecraft = new System.Windows.Forms.Button();
            this.buttonOverwatch = new System.Windows.Forms.Button();
            this.buttonValorant = new System.Windows.Forms.Button();
            this.buttonDiablo3 = new System.Windows.Forms.Button();
            this.buttonCSGO = new System.Windows.Forms.Button();
            this.buttonLeagueOfLegends = new System.Windows.Forms.Button();
            this.buttonRocketLeague = new System.Windows.Forms.Button();
            this.pnlFormLoader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFormLoader
            // 
            this.pnlFormLoader.Controls.Add(this.buttonNext1);
            this.pnlFormLoader.Controls.Add(this.buttonHMM);
            this.pnlFormLoader.Controls.Add(this.buttonAOE3D);
            this.pnlFormLoader.Controls.Add(this.buttonMinecraft);
            this.pnlFormLoader.Controls.Add(this.buttonOverwatch);
            this.pnlFormLoader.Controls.Add(this.buttonValorant);
            this.pnlFormLoader.Controls.Add(this.buttonDiablo3);
            this.pnlFormLoader.Controls.Add(this.buttonCSGO);
            this.pnlFormLoader.Controls.Add(this.buttonLeagueOfLegends);
            this.pnlFormLoader.Controls.Add(this.buttonRocketLeague);
            this.pnlFormLoader.Location = new System.Drawing.Point(0, 0);
            this.pnlFormLoader.Name = "pnlFormLoader";
            this.pnlFormLoader.Size = new System.Drawing.Size(1000, 625);
            this.pnlFormLoader.TabIndex = 0;
            // 
            // buttonNext1
            // 
            this.buttonNext1.BackColor = System.Drawing.Color.Transparent;
            this.buttonNext1.BorderColor = System.Drawing.Color.Transparent;
            this.buttonNext1.BorderRadius = 23;
            this.buttonNext1.CheckedState.Parent = this.buttonNext1;
            this.buttonNext1.CustomImages.Parent = this.buttonNext1;
            this.buttonNext1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonNext1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonNext1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonNext1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonNext1.DisabledState.Parent = this.buttonNext1;
            this.buttonNext1.FillColor = System.Drawing.Color.Transparent;
            this.buttonNext1.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext1.ForeColor = System.Drawing.Color.Black;
            this.buttonNext1.HoverState.Parent = this.buttonNext1;
            this.buttonNext1.Location = new System.Drawing.Point(940, 561);
            this.buttonNext1.Name = "buttonNext1";
            this.buttonNext1.ShadowDecoration.Parent = this.buttonNext1;
            this.buttonNext1.Size = new System.Drawing.Size(48, 56);
            this.buttonNext1.TabIndex = 68;
            this.buttonNext1.Text = "➔";
            this.buttonNext1.Click += new System.EventHandler(this.buttonNext1_Click);
            // 
            // buttonHMM
            // 
            this.buttonHMM.BackgroundImage = global::LauncherForAll.Properties.Resources.HMM;
            this.buttonHMM.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonHMM.Location = new System.Drawing.Point(625, 417);
            this.buttonHMM.Name = "buttonHMM";
            this.buttonHMM.Size = new System.Drawing.Size(300, 200);
            this.buttonHMM.TabIndex = 66;
            this.buttonHMM.UseVisualStyleBackColor = true;
            this.buttonHMM.Click += new System.EventHandler(this.buttonHMM_Click);
            // 
            // buttonAOE3D
            // 
            this.buttonAOE3D.BackgroundImage = global::LauncherForAll.Properties.Resources.AOE3D;
            this.buttonAOE3D.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAOE3D.Location = new System.Drawing.Point(319, 417);
            this.buttonAOE3D.Name = "buttonAOE3D";
            this.buttonAOE3D.Size = new System.Drawing.Size(300, 200);
            this.buttonAOE3D.TabIndex = 65;
            this.buttonAOE3D.UseVisualStyleBackColor = true;
            this.buttonAOE3D.Click += new System.EventHandler(this.buttonAOE3D_Click);
            // 
            // buttonMinecraft
            // 
            this.buttonMinecraft.BackgroundImage = global::LauncherForAll.Properties.Resources.Minecraft;
            this.buttonMinecraft.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMinecraft.Location = new System.Drawing.Point(15, 417);
            this.buttonMinecraft.Name = "buttonMinecraft";
            this.buttonMinecraft.Size = new System.Drawing.Size(300, 200);
            this.buttonMinecraft.TabIndex = 64;
            this.buttonMinecraft.UseVisualStyleBackColor = true;
            this.buttonMinecraft.Click += new System.EventHandler(this.buttonMinecraft_Click);
            // 
            // buttonOverwatch
            // 
            this.buttonOverwatch.BackgroundImage = global::LauncherForAll.Properties.Resources.Overwatch;
            this.buttonOverwatch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOverwatch.Location = new System.Drawing.Point(627, 213);
            this.buttonOverwatch.Name = "buttonOverwatch";
            this.buttonOverwatch.Size = new System.Drawing.Size(300, 200);
            this.buttonOverwatch.TabIndex = 63;
            this.buttonOverwatch.UseVisualStyleBackColor = true;
            this.buttonOverwatch.Click += new System.EventHandler(this.buttonOverwatch_Click);
            // 
            // buttonValorant
            // 
            this.buttonValorant.BackgroundImage = global::LauncherForAll.Properties.Resources.Valorant;
            this.buttonValorant.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonValorant.Location = new System.Drawing.Point(321, 213);
            this.buttonValorant.Name = "buttonValorant";
            this.buttonValorant.Size = new System.Drawing.Size(300, 200);
            this.buttonValorant.TabIndex = 62;
            this.buttonValorant.UseVisualStyleBackColor = true;
            this.buttonValorant.Click += new System.EventHandler(this.buttonValorant_Click);
            // 
            // buttonDiablo3
            // 
            this.buttonDiablo3.BackgroundImage = global::LauncherForAll.Properties.Resources.Diablo3;
            this.buttonDiablo3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDiablo3.Location = new System.Drawing.Point(15, 213);
            this.buttonDiablo3.Name = "buttonDiablo3";
            this.buttonDiablo3.Size = new System.Drawing.Size(300, 200);
            this.buttonDiablo3.TabIndex = 61;
            this.buttonDiablo3.UseVisualStyleBackColor = true;
            this.buttonDiablo3.Click += new System.EventHandler(this.buttonDiablo3_Click);
            // 
            // buttonCSGO
            // 
            this.buttonCSGO.BackgroundImage = global::LauncherForAll.Properties.Resources.CSGO;
            this.buttonCSGO.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCSGO.Location = new System.Drawing.Point(625, 7);
            this.buttonCSGO.Name = "buttonCSGO";
            this.buttonCSGO.Size = new System.Drawing.Size(300, 200);
            this.buttonCSGO.TabIndex = 60;
            this.buttonCSGO.UseVisualStyleBackColor = true;
            this.buttonCSGO.Click += new System.EventHandler(this.buttonCSGO_Click);
            // 
            // buttonLeagueOfLegends
            // 
            this.buttonLeagueOfLegends.BackgroundImage = global::LauncherForAll.Properties.Resources.LeagueOfLegends;
            this.buttonLeagueOfLegends.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLeagueOfLegends.Location = new System.Drawing.Point(319, 7);
            this.buttonLeagueOfLegends.Name = "buttonLeagueOfLegends";
            this.buttonLeagueOfLegends.Size = new System.Drawing.Size(300, 200);
            this.buttonLeagueOfLegends.TabIndex = 59;
            this.buttonLeagueOfLegends.UseVisualStyleBackColor = true;
            this.buttonLeagueOfLegends.Click += new System.EventHandler(this.buttonLeagueOfLegends_Click);
            // 
            // buttonRocketLeague
            // 
            this.buttonRocketLeague.BackgroundImage = global::LauncherForAll.Properties.Resources.RocketLeague;
            this.buttonRocketLeague.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRocketLeague.Location = new System.Drawing.Point(15, 7);
            this.buttonRocketLeague.Name = "buttonRocketLeague";
            this.buttonRocketLeague.Size = new System.Drawing.Size(300, 200);
            this.buttonRocketLeague.TabIndex = 58;
            this.buttonRocketLeague.UseVisualStyleBackColor = true;
            this.buttonRocketLeague.Click += new System.EventHandler(this.buttonRocketLeague_Click);
            // 
            // frmGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1000, 625);
            this.Controls.Add(this.pnlFormLoader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGames";
            this.Text = "frmGames";
            this.pnlFormLoader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFormLoader;
        private System.Windows.Forms.Button buttonHMM;
        private System.Windows.Forms.Button buttonAOE3D;
        private System.Windows.Forms.Button buttonMinecraft;
        private System.Windows.Forms.Button buttonOverwatch;
        private System.Windows.Forms.Button buttonValorant;
        private System.Windows.Forms.Button buttonDiablo3;
        private System.Windows.Forms.Button buttonCSGO;
        private System.Windows.Forms.Button buttonLeagueOfLegends;
        private System.Windows.Forms.Button buttonRocketLeague;
        private Siticone.Desktop.UI.WinForms.SiticoneRoundedButton buttonNext1;
    }
}