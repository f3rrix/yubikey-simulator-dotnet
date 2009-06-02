namespace Yubikey.TokenSimulator
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
			if (disposing)
			{
				if (_enterOTPHandler != null)
				{
					_enterOTPHandler.Dispose();
				}
				if (_incrementSessionHandler != null)
				{
					_incrementSessionHandler.Dispose();
				}
				if ((components != null))
				{
					components.Dispose();
				}
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.cboKeys = new System.Windows.Forms.ComboBox();
			this.btnCreateOTP = new System.Windows.Forms.Button();
			this.txtOTP = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnIncrementSession = new System.Windows.Forms.Button();
			this.txtSessionCounter = new System.Windows.Forms.TextBox();
			this.txtUseCounter = new System.Windows.Forms.TextBox();
			this.txtTimestamp = new System.Windows.Forms.TextBox();
			this.txtRandom = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.manageKeysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.cmmiRestore = new System.Windows.Forms.ToolStripMenuItem();
			this.cmmiManageKeys = new System.Windows.Forms.ToolStripMenuItem();
			this.cmmiOptions = new System.Windows.Forms.ToolStripMenuItem();
			this.cmcboKeys = new System.Windows.Forms.ToolStripComboBox();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.cmmiExit = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// cboKeys
			// 
			this.cboKeys.FormattingEnabled = true;
			this.cboKeys.Location = new System.Drawing.Point(13, 38);
			this.cboKeys.Name = "cboKeys";
			this.cboKeys.Size = new System.Drawing.Size(121, 21);
			this.cboKeys.TabIndex = 0;
			// 
			// btnCreateOTP
			// 
			this.btnCreateOTP.Location = new System.Drawing.Point(205, 238);
			this.btnCreateOTP.Name = "btnCreateOTP";
			this.btnCreateOTP.Size = new System.Drawing.Size(75, 23);
			this.btnCreateOTP.TabIndex = 1;
			this.btnCreateOTP.Text = "Create OTP";
			this.btnCreateOTP.UseVisualStyleBackColor = true;
			this.btnCreateOTP.Click += new System.EventHandler(this.btnCreateOTP_Click);
			// 
			// txtOTP
			// 
			this.txtOTP.BackColor = System.Drawing.SystemColors.Window;
			this.txtOTP.Location = new System.Drawing.Point(48, 184);
			this.txtOTP.Name = "txtOTP";
			this.txtOTP.ReadOnly = true;
			this.txtOTP.Size = new System.Drawing.Size(232, 20);
			this.txtOTP.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 187);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "OTP";
			// 
			// btnIncrementSession
			// 
			this.btnIncrementSession.Location = new System.Drawing.Point(80, 238);
			this.btnIncrementSession.Name = "btnIncrementSession";
			this.btnIncrementSession.Size = new System.Drawing.Size(119, 23);
			this.btnIncrementSession.TabIndex = 4;
			this.btnIncrementSession.Text = "Increment Session";
			this.btnIncrementSession.UseVisualStyleBackColor = true;
			this.btnIncrementSession.Click += new System.EventHandler(this.btnIncrementSession_Click);
			// 
			// txtSessionCounter
			// 
			this.txtSessionCounter.BackColor = System.Drawing.SystemColors.Window;
			this.txtSessionCounter.Location = new System.Drawing.Point(99, 66);
			this.txtSessionCounter.Name = "txtSessionCounter";
			this.txtSessionCounter.ReadOnly = true;
			this.txtSessionCounter.Size = new System.Drawing.Size(100, 20);
			this.txtSessionCounter.TabIndex = 6;
			// 
			// txtUseCounter
			// 
			this.txtUseCounter.BackColor = System.Drawing.SystemColors.Window;
			this.txtUseCounter.Location = new System.Drawing.Point(99, 93);
			this.txtUseCounter.Name = "txtUseCounter";
			this.txtUseCounter.ReadOnly = true;
			this.txtUseCounter.Size = new System.Drawing.Size(100, 20);
			this.txtUseCounter.TabIndex = 7;
			// 
			// txtTimestamp
			// 
			this.txtTimestamp.BackColor = System.Drawing.SystemColors.Window;
			this.txtTimestamp.Location = new System.Drawing.Point(99, 120);
			this.txtTimestamp.Name = "txtTimestamp";
			this.txtTimestamp.ReadOnly = true;
			this.txtTimestamp.Size = new System.Drawing.Size(100, 20);
			this.txtTimestamp.TabIndex = 8;
			// 
			// txtRandom
			// 
			this.txtRandom.BackColor = System.Drawing.SystemColors.Window;
			this.txtRandom.Location = new System.Drawing.Point(99, 147);
			this.txtRandom.Name = "txtRandom";
			this.txtRandom.ReadOnly = true;
			this.txtRandom.Size = new System.Drawing.Size(100, 20);
			this.txtRandom.TabIndex = 9;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 69);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(84, 13);
			this.label2.TabIndex = 10;
			this.label2.Text = "Session Counter";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 96);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(66, 13);
			this.label3.TabIndex = 11;
			this.label3.Text = "Use Counter";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(13, 123);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(58, 13);
			this.label4.TabIndex = 12;
			this.label4.Text = "Timestamp";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(13, 150);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(47, 13);
			this.label5.TabIndex = 13;
			this.label5.Text = "Random";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(292, 24);
			this.menuStrip1.TabIndex = 14;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageKeysToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
			this.fileToolStripMenuItem.Text = "&Menu";
			// 
			// manageKeysToolStripMenuItem
			// 
			this.manageKeysToolStripMenuItem.Name = "manageKeysToolStripMenuItem";
			this.manageKeysToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
			this.manageKeysToolStripMenuItem.Text = "&Manage Keys...";
			this.manageKeysToolStripMenuItem.Click += new System.EventHandler(this.manageKeysToolStripMenuItem_Click);
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
			this.optionsToolStripMenuItem.Text = "&Options...";
			this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
			this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
			this.notifyIcon1.Text = "Yubikey Token Simulator";
			this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_Restore);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmmiRestore,
            this.cmmiManageKeys,
            this.cmmiOptions,
            this.cmcboKeys,
            this.toolStripSeparator1,
            this.cmmiExit});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(182, 123);
			// 
			// cmmiRestore
			// 
			this.cmmiRestore.Name = "cmmiRestore";
			this.cmmiRestore.Size = new System.Drawing.Size(181, 22);
			this.cmmiRestore.Text = "&Restore";
			this.cmmiRestore.Click += new System.EventHandler(this.notifyIcon1_Restore);
			// 
			// cmmiManageKeys
			// 
			this.cmmiManageKeys.Name = "cmmiManageKeys";
			this.cmmiManageKeys.Size = new System.Drawing.Size(181, 22);
			this.cmmiManageKeys.Text = "&Manage Keys...";
			this.cmmiManageKeys.Click += new System.EventHandler(this.manageKeysToolStripMenuItem_Click);
			// 
			// cmmiOptions
			// 
			this.cmmiOptions.Name = "cmmiOptions";
			this.cmmiOptions.Size = new System.Drawing.Size(181, 22);
			this.cmmiOptions.Text = "&Options...";
			this.cmmiOptions.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
			// 
			// cmcboKeys
			// 
			this.cmcboKeys.Name = "cmcboKeys";
			this.cmcboKeys.Size = new System.Drawing.Size(121, 21);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
			// 
			// cmmiExit
			// 
			this.cmmiExit.Name = "cmmiExit";
			this.cmmiExit.Size = new System.Drawing.Size(181, 22);
			this.cmmiExit.Text = "E&xit";
			this.cmmiExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 273);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtRandom);
			this.Controls.Add(this.txtTimestamp);
			this.Controls.Add(this.txtUseCounter);
			this.Controls.Add(this.txtSessionCounter);
			this.Controls.Add(this.btnIncrementSession);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtOTP);
			this.Controls.Add(this.btnCreateOTP);
			this.Controls.Add(this.cboKeys);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Yubikey Token Simulator";
			this.Resize += new System.EventHandler(this.Form1_Resize);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cboKeys;
		private System.Windows.Forms.Button btnCreateOTP;
		private System.Windows.Forms.TextBox txtOTP;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnIncrementSession;
		private System.Windows.Forms.TextBox txtSessionCounter;
		private System.Windows.Forms.TextBox txtUseCounter;
		private System.Windows.Forms.TextBox txtTimestamp;
		private System.Windows.Forms.TextBox txtRandom;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem manageKeysToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripComboBox cmcboKeys;
		private System.Windows.Forms.ToolStripMenuItem cmmiManageKeys;
		private System.Windows.Forms.ToolStripMenuItem cmmiOptions;
		private System.Windows.Forms.ToolStripMenuItem cmmiRestore;
		private System.Windows.Forms.ToolStripMenuItem cmmiExit;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
	}
}

