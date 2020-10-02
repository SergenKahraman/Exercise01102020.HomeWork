namespace Exercise01102020.HomeWork.App
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstTeams = new System.Windows.Forms.ListBox();
            this.ctxTeam = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.oyuncuEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yöneticiEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.koçEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstPlayers = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstCoaches = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lstManagers = new System.Windows.Forms.ListBox();
            this.grbDetails = new System.Windows.Forms.GroupBox();
            this.txtCoachName = new System.Windows.Forms.TextBox();
            this.txtManagerName = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lstPlayersForATeam = new System.Windows.Forms.ListBox();
            this.lblCoachName = new System.Windows.Forms.Label();
            this.lblManagerName = new System.Windows.Forms.Label();
            this.lblTeamName = new System.Windows.Forms.Label();
            this.ctxPlayerAndCoachesAndManagers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.takımEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniOyuncuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniKoçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniYöneticiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniTakımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.ctxTeam.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.grbDetails.SuspendLayout();
            this.ctxPlayerAndCoachesAndManagers.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstTeams);
            this.groupBox1.Location = new System.Drawing.Point(63, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Takımlar";
            // 
            // lstTeams
            // 
            this.lstTeams.ContextMenuStrip = this.ctxTeam;
            this.lstTeams.FormattingEnabled = true;
            this.lstTeams.Location = new System.Drawing.Point(34, 30);
            this.lstTeams.Name = "lstTeams";
            this.lstTeams.Size = new System.Drawing.Size(158, 147);
            this.lstTeams.TabIndex = 0;
            this.lstTeams.SelectedIndexChanged += new System.EventHandler(this.lstTeams_SelectedIndexChanged);
            // 
            // ctxTeam
            // 
            this.ctxTeam.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oyuncuEkleToolStripMenuItem,
            this.yöneticiEkleToolStripMenuItem,
            this.koçEkleToolStripMenuItem});
            this.ctxTeam.Name = "ctxTeam";
            this.ctxTeam.Size = new System.Drawing.Size(141, 70);
            // 
            // oyuncuEkleToolStripMenuItem
            // 
            this.oyuncuEkleToolStripMenuItem.Name = "oyuncuEkleToolStripMenuItem";
            this.oyuncuEkleToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.oyuncuEkleToolStripMenuItem.Text = "Oyuncu Ekle";
            this.oyuncuEkleToolStripMenuItem.Click += new System.EventHandler(this.oyuncuEkleToolStripMenuItem_Click);
            // 
            // yöneticiEkleToolStripMenuItem
            // 
            this.yöneticiEkleToolStripMenuItem.Name = "yöneticiEkleToolStripMenuItem";
            this.yöneticiEkleToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.yöneticiEkleToolStripMenuItem.Text = "Yönetici Ekle";
            this.yöneticiEkleToolStripMenuItem.Click += new System.EventHandler(this.yöneticiEkleToolStripMenuItem_Click);
            // 
            // koçEkleToolStripMenuItem
            // 
            this.koçEkleToolStripMenuItem.Name = "koçEkleToolStripMenuItem";
            this.koçEkleToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.koçEkleToolStripMenuItem.Text = "Koç Ekle";
            this.koçEkleToolStripMenuItem.Click += new System.EventHandler(this.koçEkleToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstPlayers);
            this.groupBox2.Location = new System.Drawing.Point(298, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 200);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Oyuncular";
            // 
            // lstPlayers
            // 
            this.lstPlayers.ContextMenuStrip = this.ctxPlayerAndCoachesAndManagers;
            this.lstPlayers.FormattingEnabled = true;
            this.lstPlayers.Location = new System.Drawing.Point(34, 30);
            this.lstPlayers.Name = "lstPlayers";
            this.lstPlayers.Size = new System.Drawing.Size(158, 147);
            this.lstPlayers.TabIndex = 0;
            this.lstPlayers.SelectedIndexChanged += new System.EventHandler(this.lstPlayers_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstCoaches);
            this.groupBox3.Location = new System.Drawing.Point(63, 250);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(229, 200);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Koçlar";
            // 
            // lstCoaches
            // 
            this.lstCoaches.ContextMenuStrip = this.ctxPlayerAndCoachesAndManagers;
            this.lstCoaches.FormattingEnabled = true;
            this.lstCoaches.Location = new System.Drawing.Point(34, 30);
            this.lstCoaches.Name = "lstCoaches";
            this.lstCoaches.Size = new System.Drawing.Size(158, 147);
            this.lstCoaches.TabIndex = 0;
            this.lstCoaches.SelectedIndexChanged += new System.EventHandler(this.lstCoaches_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lstManagers);
            this.groupBox4.Location = new System.Drawing.Point(298, 250);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(229, 200);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Yöneticiler";
            // 
            // lstManagers
            // 
            this.lstManagers.ContextMenuStrip = this.ctxPlayerAndCoachesAndManagers;
            this.lstManagers.FormattingEnabled = true;
            this.lstManagers.Location = new System.Drawing.Point(34, 30);
            this.lstManagers.Name = "lstManagers";
            this.lstManagers.Size = new System.Drawing.Size(158, 147);
            this.lstManagers.TabIndex = 0;
            this.lstManagers.SelectedIndexChanged += new System.EventHandler(this.lstManagers_SelectedIndexChanged);
            // 
            // grbDetails
            // 
            this.grbDetails.Controls.Add(this.txtCoachName);
            this.grbDetails.Controls.Add(this.txtManagerName);
            this.grbDetails.Controls.Add(this.txtName);
            this.grbDetails.Controls.Add(this.lstPlayersForATeam);
            this.grbDetails.Controls.Add(this.lblCoachName);
            this.grbDetails.Controls.Add(this.lblManagerName);
            this.grbDetails.Controls.Add(this.lblTeamName);
            this.grbDetails.Location = new System.Drawing.Point(573, 32);
            this.grbDetails.Name = "grbDetails";
            this.grbDetails.Size = new System.Drawing.Size(502, 394);
            this.grbDetails.TabIndex = 1;
            this.grbDetails.TabStop = false;
            this.grbDetails.Text = "Detaylar";
            // 
            // txtCoachName
            // 
            this.txtCoachName.Location = new System.Drawing.Point(117, 139);
            this.txtCoachName.Name = "txtCoachName";
            this.txtCoachName.ReadOnly = true;
            this.txtCoachName.Size = new System.Drawing.Size(129, 20);
            this.txtCoachName.TabIndex = 2;
            // 
            // txtManagerName
            // 
            this.txtManagerName.Location = new System.Drawing.Point(117, 96);
            this.txtManagerName.Name = "txtManagerName";
            this.txtManagerName.ReadOnly = true;
            this.txtManagerName.Size = new System.Drawing.Size(129, 20);
            this.txtManagerName.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(117, 53);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(129, 20);
            this.txtName.TabIndex = 2;
            // 
            // lstPlayersForATeam
            // 
            this.lstPlayersForATeam.BackColor = System.Drawing.SystemColors.Menu;
            this.lstPlayersForATeam.FormattingEnabled = true;
            this.lstPlayersForATeam.Location = new System.Drawing.Point(287, 39);
            this.lstPlayersForATeam.Name = "lstPlayersForATeam";
            this.lstPlayersForATeam.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstPlayersForATeam.Size = new System.Drawing.Size(191, 303);
            this.lstPlayersForATeam.TabIndex = 1;
            // 
            // lblCoachName
            // 
            this.lblCoachName.AutoSize = true;
            this.lblCoachName.Location = new System.Drawing.Point(66, 142);
            this.lblCoachName.Name = "lblCoachName";
            this.lblCoachName.Size = new System.Drawing.Size(32, 13);
            this.lblCoachName.TabIndex = 0;
            this.lblCoachName.Text = "Koçu";
            // 
            // lblManagerName
            // 
            this.lblManagerName.AutoSize = true;
            this.lblManagerName.Location = new System.Drawing.Point(46, 99);
            this.lblManagerName.Name = "lblManagerName";
            this.lblManagerName.Size = new System.Drawing.Size(52, 13);
            this.lblManagerName.TabIndex = 0;
            this.lblManagerName.Text = "Yöneticisi";
            // 
            // lblTeamName
            // 
            this.lblTeamName.AutoSize = true;
            this.lblTeamName.Location = new System.Drawing.Point(44, 56);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(54, 13);
            this.lblTeamName.TabIndex = 0;
            this.lblTeamName.Text = "Takım Adı";
            // 
            // ctxPlayerAndCoachesAndManagers
            // 
            this.ctxPlayerAndCoachesAndManagers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.takımEkleToolStripMenuItem});
            this.ctxPlayerAndCoachesAndManagers.Name = "ctxPlayerAndCoachesAndManagers";
            this.ctxPlayerAndCoachesAndManagers.Size = new System.Drawing.Size(130, 26);
            // 
            // takımEkleToolStripMenuItem
            // 
            this.takımEkleToolStripMenuItem.Name = "takımEkleToolStripMenuItem";
            this.takımEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.takımEkleToolStripMenuItem.Text = "Takım Ekle";
            this.takımEkleToolStripMenuItem.Click += new System.EventHandler(this.takımEkleToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1148, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniOyuncuToolStripMenuItem,
            this.yeniKoçToolStripMenuItem,
            this.yeniYöneticiToolStripMenuItem,
            this.yeniTakımToolStripMenuItem});
            this.ekleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.ekleToolStripMenuItem.Text = "Ekle";
            // 
            // yeniOyuncuToolStripMenuItem
            // 
            this.yeniOyuncuToolStripMenuItem.Name = "yeniOyuncuToolStripMenuItem";
            this.yeniOyuncuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yeniOyuncuToolStripMenuItem.Text = "Yeni Oyuncu";
            this.yeniOyuncuToolStripMenuItem.Click += new System.EventHandler(this.yeniOyuncuToolStripMenuItem_Click);
            // 
            // yeniKoçToolStripMenuItem
            // 
            this.yeniKoçToolStripMenuItem.Name = "yeniKoçToolStripMenuItem";
            this.yeniKoçToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yeniKoçToolStripMenuItem.Text = "Yeni Koç";
            this.yeniKoçToolStripMenuItem.Click += new System.EventHandler(this.yeniKoçToolStripMenuItem_Click);
            // 
            // yeniYöneticiToolStripMenuItem
            // 
            this.yeniYöneticiToolStripMenuItem.Name = "yeniYöneticiToolStripMenuItem";
            this.yeniYöneticiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yeniYöneticiToolStripMenuItem.Text = "Yeni Yönetici";
            this.yeniYöneticiToolStripMenuItem.Click += new System.EventHandler(this.yeniYöneticiToolStripMenuItem_Click);
            // 
            // yeniTakımToolStripMenuItem
            // 
            this.yeniTakımToolStripMenuItem.Name = "yeniTakımToolStripMenuItem";
            this.yeniTakımToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yeniTakımToolStripMenuItem.Text = "Yeni Takım";
            this.yeniTakımToolStripMenuItem.Click += new System.EventHandler(this.yeniTakımToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 483);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.grbDetails);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SporManager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ctxTeam.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.grbDetails.ResumeLayout(false);
            this.grbDetails.PerformLayout();
            this.ctxPlayerAndCoachesAndManagers.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstTeams;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstPlayers;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lstCoaches;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lstManagers;
        private System.Windows.Forms.GroupBox grbDetails;
        private System.Windows.Forms.TextBox txtCoachName;
        private System.Windows.Forms.TextBox txtManagerName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ListBox lstPlayersForATeam;
        private System.Windows.Forms.Label lblCoachName;
        private System.Windows.Forms.Label lblManagerName;
        private System.Windows.Forms.Label lblTeamName;
        private System.Windows.Forms.ContextMenuStrip ctxTeam;
        private System.Windows.Forms.ToolStripMenuItem oyuncuEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yöneticiEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem koçEkleToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ctxPlayerAndCoachesAndManagers;
        private System.Windows.Forms.ToolStripMenuItem takımEkleToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniOyuncuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniKoçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniYöneticiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniTakımToolStripMenuItem;
    }
}

