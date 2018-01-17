﻿namespace STFU.AutoUploader
{
	partial class MainForm
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
			this.tlpSettings = new System.Windows.Forms.TableLayoutPanel();
			this.btnStart = new System.Windows.Forms.Button();
			this.lvSelectedPaths = new System.Windows.Forms.ListView();
			this.chPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chFilter = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chRecursive = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chTemplate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lblCurrentLoggedIn = new System.Windows.Forms.Label();
			this.lnklblCurrentLoggedIn = new System.Windows.Forms.LinkLabel();
			this.mainMenu = new System.Windows.Forms.MenuStrip();
			this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.youtubeAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.verbindenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.verbindungTrennenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.templatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.templatesVerwaltenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.alleTemplatesLöschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pfadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pfadeVerwaltenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.allePfadeLöschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.abgebrochenerUploadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.abgebrochenenUploadAnzeigenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.abgebrochenenUploadLöschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lblFinishAction = new System.Windows.Forms.Label();
			this.cmbbxFinishAction = new System.Windows.Forms.ComboBox();
			this.chbChoseProcesses = new System.Windows.Forms.CheckBox();
			this.btnChoseProcs = new System.Windows.Forms.Button();
			this.bgwCreateUploader = new System.ComponentModel.BackgroundWorker();
			this.tlpSettings.SuspendLayout();
			this.mainMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// tlpSettings
			// 
			this.tlpSettings.AutoSize = true;
			this.tlpSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tlpSettings.ColumnCount = 15;
			this.tlpSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
			this.tlpSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tlpSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
			this.tlpSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
			this.tlpSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tlpSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 4F));
			this.tlpSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 4F));
			this.tlpSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tlpSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 4F));
			this.tlpSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tlpSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
			this.tlpSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tlpSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
			this.tlpSettings.Controls.Add(this.btnStart, 13, 4);
			this.tlpSettings.Controls.Add(this.lvSelectedPaths, 1, 2);
			this.tlpSettings.Controls.Add(this.lblCurrentLoggedIn, 1, 4);
			this.tlpSettings.Controls.Add(this.lnklblCurrentLoggedIn, 3, 4);
			this.tlpSettings.Controls.Add(this.mainMenu, 0, 0);
			this.tlpSettings.Controls.Add(this.lblFinishAction, 5, 4);
			this.tlpSettings.Controls.Add(this.cmbbxFinishAction, 7, 4);
			this.tlpSettings.Controls.Add(this.chbChoseProcesses, 9, 4);
			this.tlpSettings.Controls.Add(this.btnChoseProcs, 11, 4);
			this.tlpSettings.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlpSettings.Enabled = false;
			this.tlpSettings.Location = new System.Drawing.Point(0, 0);
			this.tlpSettings.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tlpSettings.Name = "tlpSettings";
			this.tlpSettings.RowCount = 6;
			this.tlpSettings.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tlpSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
			this.tlpSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlpSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
			this.tlpSettings.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tlpSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
			this.tlpSettings.Size = new System.Drawing.Size(843, 323);
			this.tlpSettings.TabIndex = 0;
			// 
			// btnStart
			// 
			this.btnStart.AutoSize = true;
			this.btnStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnStart.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnStart.Enabled = false;
			this.btnStart.Location = new System.Drawing.Point(769, 288);
			this.btnStart.Margin = new System.Windows.Forms.Padding(0);
			this.btnStart.Name = "btnStart";
			this.btnStart.Padding = new System.Windows.Forms.Padding(11, 2, 11, 2);
			this.btnStart.Size = new System.Drawing.Size(64, 27);
			this.btnStart.TabIndex = 7;
			this.btnStart.Text = "Start!";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStartClick);
			// 
			// lvSelectedPaths
			// 
			this.lvSelectedPaths.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chPath,
            this.chFilter,
            this.chRecursive,
            this.chTemplate});
			this.tlpSettings.SetColumnSpan(this.lvSelectedPaths, 13);
			this.lvSelectedPaths.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvSelectedPaths.FullRowSelect = true;
			this.lvSelectedPaths.GridLines = true;
			this.lvSelectedPaths.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lvSelectedPaths.Location = new System.Drawing.Point(8, 32);
			this.lvSelectedPaths.Margin = new System.Windows.Forms.Padding(0);
			this.lvSelectedPaths.Name = "lvSelectedPaths";
			this.lvSelectedPaths.ShowGroups = false;
			this.lvSelectedPaths.Size = new System.Drawing.Size(825, 248);
			this.lvSelectedPaths.TabIndex = 9;
			this.lvSelectedPaths.UseCompatibleStateImageBehavior = false;
			this.lvSelectedPaths.View = System.Windows.Forms.View.Details;
			// 
			// chPath
			// 
			this.chPath.Text = "Pfad";
			this.chPath.Width = 350;
			// 
			// chFilter
			// 
			this.chFilter.Text = "Filter";
			this.chFilter.Width = 150;
			// 
			// chRecursive
			// 
			this.chRecursive.Text = "Unterverzeichnisse";
			this.chRecursive.Width = 150;
			// 
			// chTemplate
			// 
			this.chTemplate.Text = "Template";
			this.chTemplate.Width = 150;
			// 
			// lblCurrentLoggedIn
			// 
			this.lblCurrentLoggedIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.lblCurrentLoggedIn.AutoSize = true;
			this.lblCurrentLoggedIn.Location = new System.Drawing.Point(8, 295);
			this.lblCurrentLoggedIn.Margin = new System.Windows.Forms.Padding(0);
			this.lblCurrentLoggedIn.Name = "lblCurrentLoggedIn";
			this.lblCurrentLoggedIn.Size = new System.Drawing.Size(66, 13);
			this.lblCurrentLoggedIn.TabIndex = 10;
			this.lblCurrentLoggedIn.Text = "Angemeldet:";
			this.lblCurrentLoggedIn.Visible = false;
			// 
			// lnklblCurrentLoggedIn
			// 
			this.lnklblCurrentLoggedIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.lnklblCurrentLoggedIn.AutoSize = true;
			this.lnklblCurrentLoggedIn.Location = new System.Drawing.Point(82, 295);
			this.lnklblCurrentLoggedIn.Margin = new System.Windows.Forms.Padding(0);
			this.lnklblCurrentLoggedIn.Name = "lnklblCurrentLoggedIn";
			this.lnklblCurrentLoggedIn.Size = new System.Drawing.Size(210, 13);
			this.lnklblCurrentLoggedIn.TabIndex = 11;
			this.lnklblCurrentLoggedIn.TabStop = true;
			this.lnklblCurrentLoggedIn.Text = "link";
			this.lnklblCurrentLoggedIn.Visible = false;
			this.lnklblCurrentLoggedIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblCurrentLoggedInLinkClicked);
			// 
			// mainMenu
			// 
			this.mainMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.tlpSettings.SetColumnSpan(this.mainMenu, 15);
			this.mainMenu.Dock = System.Windows.Forms.DockStyle.None;
			this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.youtubeAccountToolStripMenuItem,
            this.templatesToolStripMenuItem,
            this.pfadeToolStripMenuItem,
            this.abgebrochenerUploadToolStripMenuItem});
			this.mainMenu.Location = new System.Drawing.Point(0, 0);
			this.mainMenu.Name = "mainMenu";
			this.mainMenu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
			this.mainMenu.Size = new System.Drawing.Size(843, 24);
			this.mainMenu.TabIndex = 13;
			this.mainMenu.Text = "menuStrip1";
			// 
			// dateiToolStripMenuItem
			// 
			this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beendenToolStripMenuItem});
			this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
			this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
			this.dateiToolStripMenuItem.Text = "Datei";
			// 
			// beendenToolStripMenuItem
			// 
			this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
			this.beendenToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
			this.beendenToolStripMenuItem.Text = "Beenden";
			this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItemClick);
			// 
			// youtubeAccountToolStripMenuItem
			// 
			this.youtubeAccountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verbindenToolStripMenuItem,
            this.verbindungTrennenToolStripMenuItem});
			this.youtubeAccountToolStripMenuItem.Name = "youtubeAccountToolStripMenuItem";
			this.youtubeAccountToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
			this.youtubeAccountToolStripMenuItem.Text = "Youtube-Account";
			// 
			// verbindenToolStripMenuItem
			// 
			this.verbindenToolStripMenuItem.Name = "verbindenToolStripMenuItem";
			this.verbindenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.verbindenToolStripMenuItem.Text = "Verbinden";
			this.verbindenToolStripMenuItem.Click += new System.EventHandler(this.verbindenToolStripMenuItemClick);
			// 
			// verbindungTrennenToolStripMenuItem
			// 
			this.verbindungTrennenToolStripMenuItem.Name = "verbindungTrennenToolStripMenuItem";
			this.verbindungTrennenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.verbindungTrennenToolStripMenuItem.Text = "Verbindung trennen";
			this.verbindungTrennenToolStripMenuItem.Click += new System.EventHandler(this.verbindungTrennenToolStripMenuItemClick);
			// 
			// templatesToolStripMenuItem
			// 
			this.templatesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.templatesVerwaltenToolStripMenuItem,
            this.alleTemplatesLöschenToolStripMenuItem});
			this.templatesToolStripMenuItem.Name = "templatesToolStripMenuItem";
			this.templatesToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
			this.templatesToolStripMenuItem.Text = "Templates";
			// 
			// templatesVerwaltenToolStripMenuItem
			// 
			this.templatesVerwaltenToolStripMenuItem.Name = "templatesVerwaltenToolStripMenuItem";
			this.templatesVerwaltenToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
			this.templatesVerwaltenToolStripMenuItem.Text = "Templates verwalten";
			this.templatesVerwaltenToolStripMenuItem.Click += new System.EventHandler(this.templatesVerwaltenToolStripMenuItemClick);
			// 
			// alleTemplatesLöschenToolStripMenuItem
			// 
			this.alleTemplatesLöschenToolStripMenuItem.Name = "alleTemplatesLöschenToolStripMenuItem";
			this.alleTemplatesLöschenToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
			this.alleTemplatesLöschenToolStripMenuItem.Text = "Alle Templates löschen";
			// 
			// pfadeToolStripMenuItem
			// 
			this.pfadeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pfadeVerwaltenToolStripMenuItem,
            this.allePfadeLöschenToolStripMenuItem});
			this.pfadeToolStripMenuItem.Name = "pfadeToolStripMenuItem";
			this.pfadeToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
			this.pfadeToolStripMenuItem.Text = "Pfade";
			// 
			// pfadeVerwaltenToolStripMenuItem
			// 
			this.pfadeVerwaltenToolStripMenuItem.Name = "pfadeVerwaltenToolStripMenuItem";
			this.pfadeVerwaltenToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
			this.pfadeVerwaltenToolStripMenuItem.Text = "Pfade verwalten";
			this.pfadeVerwaltenToolStripMenuItem.Click += new System.EventHandler(this.pfadeVerwaltenToolStripMenuItemClick);
			// 
			// allePfadeLöschenToolStripMenuItem
			// 
			this.allePfadeLöschenToolStripMenuItem.Name = "allePfadeLöschenToolStripMenuItem";
			this.allePfadeLöschenToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
			this.allePfadeLöschenToolStripMenuItem.Text = "Alle Pfade löschen";
			this.allePfadeLöschenToolStripMenuItem.Click += new System.EventHandler(this.allePfadeLöschenToolStripMenuItemClick);
			// 
			// abgebrochenerUploadToolStripMenuItem
			// 
			this.abgebrochenerUploadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abgebrochenenUploadAnzeigenToolStripMenuItem,
            this.abgebrochenenUploadLöschenToolStripMenuItem});
			this.abgebrochenerUploadToolStripMenuItem.Name = "abgebrochenerUploadToolStripMenuItem";
			this.abgebrochenerUploadToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
			this.abgebrochenerUploadToolStripMenuItem.Text = "Unvollendeter Upload";
			// 
			// abgebrochenenUploadAnzeigenToolStripMenuItem
			// 
			this.abgebrochenenUploadAnzeigenToolStripMenuItem.Name = "abgebrochenenUploadAnzeigenToolStripMenuItem";
			this.abgebrochenenUploadAnzeigenToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
			this.abgebrochenenUploadAnzeigenToolStripMenuItem.Text = "Unvollendeten Upload anzeigen";
			this.abgebrochenenUploadAnzeigenToolStripMenuItem.Click += new System.EventHandler(this.abgebrochenenUploadAnzeigenToolStripMenuItemClick);
			// 
			// abgebrochenenUploadLöschenToolStripMenuItem
			// 
			this.abgebrochenenUploadLöschenToolStripMenuItem.Name = "abgebrochenenUploadLöschenToolStripMenuItem";
			this.abgebrochenenUploadLöschenToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
			this.abgebrochenenUploadLöschenToolStripMenuItem.Text = "Unvollendeten Upload löschen";
			this.abgebrochenenUploadLöschenToolStripMenuItem.Click += new System.EventHandler(this.abgebrochenenUploadLöschenToolStripMenuItemClick);
			// 
			// lblFinishAction
			// 
			this.lblFinishAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.lblFinishAction.AutoSize = true;
			this.lblFinishAction.Location = new System.Drawing.Point(300, 295);
			this.lblFinishAction.Margin = new System.Windows.Forms.Padding(0);
			this.lblFinishAction.Name = "lblFinishAction";
			this.lblFinishAction.Size = new System.Drawing.Size(53, 13);
			this.lblFinishAction.TabIndex = 14;
			this.lblFinishAction.Text = "Am Ende:";
			// 
			// cmbbxFinishAction
			// 
			this.cmbbxFinishAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.cmbbxFinishAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbbxFinishAction.FormattingEnabled = true;
			this.cmbbxFinishAction.Items.AddRange(new object[] {
            "Nichts tun",
            "Programm schließen",
            "Herunterfahren"});
			this.cmbbxFinishAction.Location = new System.Drawing.Point(357, 291);
			this.cmbbxFinishAction.Margin = new System.Windows.Forms.Padding(0);
			this.cmbbxFinishAction.Name = "cmbbxFinishAction";
			this.cmbbxFinishAction.Size = new System.Drawing.Size(210, 21);
			this.cmbbxFinishAction.TabIndex = 15;
			this.cmbbxFinishAction.SelectedIndexChanged += new System.EventHandler(this.cmbbxFinishActionSelectedIndexChanged);
			// 
			// chbChoseProcesses
			// 
			this.chbChoseProcesses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.chbChoseProcesses.AutoSize = true;
			this.chbChoseProcesses.Enabled = false;
			this.chbChoseProcesses.Location = new System.Drawing.Point(571, 293);
			this.chbChoseProcesses.Margin = new System.Windows.Forms.Padding(0);
			this.chbChoseProcesses.Name = "chbChoseProcesses";
			this.chbChoseProcesses.Size = new System.Drawing.Size(150, 17);
			this.chbChoseProcesses.TabIndex = 16;
			this.chbChoseProcesses.Text = "Programmenden abwarten";
			this.chbChoseProcesses.UseVisualStyleBackColor = true;
			this.chbChoseProcesses.CheckedChanged += new System.EventHandler(this.chbChoseProcessesCheckedChanged);
			// 
			// btnChoseProcs
			// 
			this.btnChoseProcs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.btnChoseProcs.AutoSize = true;
			this.btnChoseProcs.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnChoseProcs.Enabled = false;
			this.btnChoseProcs.Location = new System.Drawing.Point(725, 288);
			this.btnChoseProcs.Margin = new System.Windows.Forms.Padding(0);
			this.btnChoseProcs.Name = "btnChoseProcs";
			this.btnChoseProcs.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnChoseProcs.Size = new System.Drawing.Size(36, 27);
			this.btnChoseProcs.TabIndex = 17;
			this.btnChoseProcs.Text = "[...]";
			this.btnChoseProcs.UseVisualStyleBackColor = true;
			this.btnChoseProcs.Click += new System.EventHandler(this.btnChoseProcsClick);
			// 
			// bgwCreateUploader
			// 
			this.bgwCreateUploader.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwCreateUploaderDoWork);
			this.bgwCreateUploader.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwCreateUploaderRunWorkerCompleted);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(843, 323);
			this.Controls.Add(this.tlpSettings);
			this.MainMenuStrip = this.mainMenu;
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Strohis Toolset Für Uploads - AutoUploader";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.tlpSettings.ResumeLayout(false);
			this.tlpSettings.PerformLayout();
			this.mainMenu.ResumeLayout(false);
			this.mainMenu.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tlpSettings;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.ListView lvSelectedPaths;
		private System.Windows.Forms.ColumnHeader chPath;
		private System.Windows.Forms.ColumnHeader chFilter;
		private System.ComponentModel.BackgroundWorker bgwCreateUploader;
		private System.Windows.Forms.Label lblCurrentLoggedIn;
		private System.Windows.Forms.LinkLabel lnklblCurrentLoggedIn;
		private System.Windows.Forms.ColumnHeader chRecursive;
		private System.Windows.Forms.MenuStrip mainMenu;
		private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem templatesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem templatesVerwaltenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem alleTemplatesLöschenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem abgebrochenerUploadToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem abgebrochenenUploadAnzeigenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem abgebrochenenUploadLöschenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem youtubeAccountToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem verbindenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem verbindungTrennenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pfadeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pfadeVerwaltenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem allePfadeLöschenToolStripMenuItem;
		private System.Windows.Forms.Label lblFinishAction;
		private System.Windows.Forms.ComboBox cmbbxFinishAction;
		private System.Windows.Forms.CheckBox chbChoseProcesses;
		private System.Windows.Forms.Button btnChoseProcs;
		private System.Windows.Forms.ColumnHeader chTemplate;
	}
}

