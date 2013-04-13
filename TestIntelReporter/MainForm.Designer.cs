﻿namespace TestIntelReporter
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
            this.components = new System.ComponentModel.Container();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.configurationPage = new System.Windows.Forms.TabPage();
            this.configLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.checkAutostart = new System.Windows.Forms.CheckBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textLogDirectory = new System.Windows.Forms.TextBox();
            this.buttonApply = new System.Windows.Forms.Button();
            this.aboutPage = new System.Windows.Forms.TabPage();
            this.aboutLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.aboutImage = new System.Windows.Forms.PictureBox();
            this.labelAppName = new System.Windows.Forms.Label();
            this.labelAppVersion = new System.Windows.Forms.Label();
            this.linkTestMap = new System.Windows.Forms.LinkLabel();
            this.labelMapAuthor = new System.Windows.Forms.Label();
            this.labelAppAuthor = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIconMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.logWatcher = new TestIntelReporter.LogWatcher(this.components);
            this.tabControl.SuspendLayout();
            this.configurationPage.SuspendLayout();
            this.configLayoutPanel.SuspendLayout();
            this.aboutPage.SuspendLayout();
            this.aboutLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aboutImage)).BeginInit();
            this.notifyIconMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.configurationPage);
            this.tabControl.Controls.Add(this.aboutPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(384, 262);
            this.tabControl.TabIndex = 0;
            // 
            // configurationPage
            // 
            this.configurationPage.Controls.Add(this.configLayoutPanel);
            this.configurationPage.Location = new System.Drawing.Point(4, 22);
            this.configurationPage.Name = "configurationPage";
            this.configurationPage.Padding = new System.Windows.Forms.Padding(3);
            this.configurationPage.Size = new System.Drawing.Size(376, 236);
            this.configurationPage.TabIndex = 0;
            this.configurationPage.Text = "Configuration";
            this.configurationPage.UseVisualStyleBackColor = true;
            // 
            // configLayoutPanel
            // 
            this.configLayoutPanel.ColumnCount = 3;
            this.configLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.configLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.configLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.configLayoutPanel.Controls.Add(this.labelUsername, 0, 0);
            this.configLayoutPanel.Controls.Add(this.textUsername, 1, 0);
            this.configLayoutPanel.Controls.Add(this.labelPassword, 0, 1);
            this.configLayoutPanel.Controls.Add(this.textPassword, 1, 1);
            this.configLayoutPanel.Controls.Add(this.checkAutostart, 0, 3);
            this.configLayoutPanel.Controls.Add(this.buttonBrowse, 2, 2);
            this.configLayoutPanel.Controls.Add(this.label2, 0, 2);
            this.configLayoutPanel.Controls.Add(this.textLogDirectory, 1, 2);
            this.configLayoutPanel.Controls.Add(this.buttonApply, 0, 4);
            this.configLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.configLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.configLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.configLayoutPanel.Name = "configLayoutPanel";
            this.configLayoutPanel.RowCount = 5;
            this.configLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.configLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.configLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.configLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.configLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.configLayoutPanel.Size = new System.Drawing.Size(370, 230);
            this.configLayoutPanel.TabIndex = 0;
            // 
            // labelUsername
            // 
            this.labelUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(3, 10);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(3);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(83, 13);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "Auth &Username:";
            // 
            // textUsername
            // 
            this.textUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.configLayoutPanel.SetColumnSpan(this.textUsername, 2);
            this.textUsername.Location = new System.Drawing.Point(109, 3);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(258, 20);
            this.textUsername.TabIndex = 1;
            this.textUsername.TextChanged += new System.EventHandler(this.textUsername_TextChanged);
            // 
            // labelPassword
            // 
            this.labelPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(3, 36);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(3);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(100, 13);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Services &Password:";
            // 
            // textPassword
            // 
            this.textPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.configLayoutPanel.SetColumnSpan(this.textPassword, 2);
            this.textPassword.Location = new System.Drawing.Point(109, 29);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(258, 20);
            this.textPassword.TabIndex = 3;
            this.textPassword.TextChanged += new System.EventHandler(this.textPassword_TextChanged);
            // 
            // checkAutostart
            // 
            this.checkAutostart.AutoSize = true;
            this.configLayoutPanel.SetColumnSpan(this.checkAutostart, 2);
            this.checkAutostart.Location = new System.Drawing.Point(3, 84);
            this.checkAutostart.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.checkAutostart.Name = "checkAutostart";
            this.checkAutostart.Size = new System.Drawing.Size(204, 17);
            this.checkAutostart.TabIndex = 7;
            this.checkAutostart.Text = "Automatically &Start on Windows Login";
            this.checkAutostart.UseVisualStyleBackColor = true;
            this.checkAutostart.CheckedChanged += new System.EventHandler(this.checkAutostart_CheckedChanged);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonBrowse.AutoSize = true;
            this.buttonBrowse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonBrowse.Location = new System.Drawing.Point(344, 53);
            this.buttonBrowse.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(26, 23);
            this.buttonBrowse.TabIndex = 6;
            this.buttonBrowse.Text = "...";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Log &Directory:";
            // 
            // textLogDirectory
            // 
            this.textLogDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textLogDirectory.Location = new System.Drawing.Point(109, 55);
            this.textLogDirectory.Name = "textLogDirectory";
            this.textLogDirectory.ReadOnly = true;
            this.textLogDirectory.Size = new System.Drawing.Size(232, 20);
            this.textLogDirectory.TabIndex = 5;
            // 
            // buttonApply
            // 
            this.buttonApply.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.configLayoutPanel.SetColumnSpan(this.buttonApply, 3);
            this.buttonApply.Enabled = false;
            this.buttonApply.Location = new System.Drawing.Point(147, 107);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 23);
            this.buttonApply.TabIndex = 0;
            this.buttonApply.Text = "&Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // aboutPage
            // 
            this.aboutPage.Controls.Add(this.aboutLayoutPanel);
            this.aboutPage.Location = new System.Drawing.Point(4, 22);
            this.aboutPage.Name = "aboutPage";
            this.aboutPage.Padding = new System.Windows.Forms.Padding(3);
            this.aboutPage.Size = new System.Drawing.Size(376, 236);
            this.aboutPage.TabIndex = 1;
            this.aboutPage.Text = "About";
            this.aboutPage.UseVisualStyleBackColor = true;
            // 
            // aboutLayoutPanel
            // 
            this.aboutLayoutPanel.ColumnCount = 2;
            this.aboutLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.aboutLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.aboutLayoutPanel.Controls.Add(this.aboutImage, 0, 0);
            this.aboutLayoutPanel.Controls.Add(this.labelAppName, 1, 0);
            this.aboutLayoutPanel.Controls.Add(this.labelAppVersion, 1, 1);
            this.aboutLayoutPanel.Controls.Add(this.linkTestMap, 1, 2);
            this.aboutLayoutPanel.Controls.Add(this.labelMapAuthor, 1, 3);
            this.aboutLayoutPanel.Controls.Add(this.labelAppAuthor, 1, 4);
            this.aboutLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aboutLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.aboutLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.aboutLayoutPanel.Name = "aboutLayoutPanel";
            this.aboutLayoutPanel.RowCount = 6;
            this.aboutLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.aboutLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.aboutLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.aboutLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.aboutLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.aboutLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.aboutLayoutPanel.Size = new System.Drawing.Size(370, 230);
            this.aboutLayoutPanel.TabIndex = 0;
            // 
            // aboutImage
            // 
            this.aboutImage.Image = global::TestIntelReporter.Properties.Resources.AboutImage;
            this.aboutImage.Location = new System.Drawing.Point(3, 3);
            this.aboutImage.Name = "aboutImage";
            this.aboutLayoutPanel.SetRowSpan(this.aboutImage, 5);
            this.aboutImage.Size = new System.Drawing.Size(128, 128);
            this.aboutImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.aboutImage.TabIndex = 0;
            this.aboutImage.TabStop = false;
            // 
            // labelAppName
            // 
            this.labelAppName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAppName.AutoSize = true;
            this.labelAppName.Location = new System.Drawing.Point(137, 3);
            this.labelAppName.Margin = new System.Windows.Forms.Padding(3);
            this.labelAppName.Name = "labelAppName";
            this.labelAppName.Size = new System.Drawing.Size(230, 13);
            this.labelAppName.TabIndex = 1;
            this.labelAppName.Text = "{0}";
            // 
            // labelAppVersion
            // 
            this.labelAppVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAppVersion.AutoSize = true;
            this.labelAppVersion.Location = new System.Drawing.Point(137, 22);
            this.labelAppVersion.Margin = new System.Windows.Forms.Padding(3);
            this.labelAppVersion.Name = "labelAppVersion";
            this.labelAppVersion.Size = new System.Drawing.Size(230, 13);
            this.labelAppVersion.TabIndex = 2;
            this.labelAppVersion.Text = "Version {0}";
            // 
            // linkTestMap
            // 
            this.linkTestMap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkTestMap.AutoSize = true;
            this.linkTestMap.Location = new System.Drawing.Point(137, 41);
            this.linkTestMap.Margin = new System.Windows.Forms.Padding(3);
            this.linkTestMap.Name = "linkTestMap";
            this.linkTestMap.Size = new System.Drawing.Size(230, 13);
            this.linkTestMap.TabIndex = 3;
            this.linkTestMap.TabStop = true;
            this.linkTestMap.Text = "TEST Alliance Intel Map";
            this.linkTestMap.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkTestMap_LinkClicked);
            // 
            // labelMapAuthor
            // 
            this.labelMapAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMapAuthor.AutoSize = true;
            this.labelMapAuthor.Location = new System.Drawing.Point(137, 60);
            this.labelMapAuthor.Margin = new System.Windows.Forms.Padding(3);
            this.labelMapAuthor.Name = "labelMapAuthor";
            this.labelMapAuthor.Size = new System.Drawing.Size(230, 13);
            this.labelMapAuthor.TabIndex = 4;
            this.labelMapAuthor.Text = "TEST Map by Awol Aurix";
            // 
            // labelAppAuthor
            // 
            this.labelAppAuthor.AutoSize = true;
            this.labelAppAuthor.Location = new System.Drawing.Point(137, 79);
            this.labelAppAuthor.Margin = new System.Windows.Forms.Padding(3);
            this.labelAppAuthor.Name = "labelAppAuthor";
            this.labelAppAuthor.Size = new System.Drawing.Size(164, 13);
            this.labelAppAuthor.TabIndex = 5;
            this.labelAppAuthor.Text = "Reporting App by Ranisa Kazuko";
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.notifyIconMenu;
            this.notifyIcon.Text = "TEST Intel Reporting Tool";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // notifyIconMenu
            // 
            this.notifyIconMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurationToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.notifyIconMenu.Name = "notifyIconMenu";
            this.notifyIconMenu.Size = new System.Drawing.Size(158, 70);
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.configurationToolStripMenuItem.Text = "&Configuration...";
            this.configurationToolStripMenuItem.Click += new System.EventHandler(this.configurationToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.quitToolStripMenuItem.Text = "&Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 262);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "TEST Intel Reporting Tool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.tabControl.ResumeLayout(false);
            this.configurationPage.ResumeLayout(false);
            this.configLayoutPanel.ResumeLayout(false);
            this.configLayoutPanel.PerformLayout();
            this.aboutPage.ResumeLayout(false);
            this.aboutLayoutPanel.ResumeLayout(false);
            this.aboutLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aboutImage)).EndInit();
            this.notifyIconMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage configurationPage;
        private System.Windows.Forms.TabPage aboutPage;
        private System.Windows.Forms.TableLayoutPanel configLayoutPanel;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.CheckBox checkAutostart;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip notifyIconMenu;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private LogWatcher logWatcher;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textLogDirectory;
        private System.Windows.Forms.TableLayoutPanel aboutLayoutPanel;
        private System.Windows.Forms.PictureBox aboutImage;
        private System.Windows.Forms.Label labelAppName;
        private System.Windows.Forms.Label labelAppVersion;
        private System.Windows.Forms.LinkLabel linkTestMap;
        private System.Windows.Forms.Label labelMapAuthor;
        private System.Windows.Forms.Label labelAppAuthor;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}

