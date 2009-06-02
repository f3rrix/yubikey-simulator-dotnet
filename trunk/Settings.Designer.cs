namespace Yubikey.TokenSimulator
{
	partial class Settings
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
			this.gbHotkeys = new System.Windows.Forms.GroupBox();
			this.cbIncrementSession = new System.Windows.Forms.CheckBox();
			this.pnlIncrementSession = new System.Windows.Forms.Panel();
			this.cbIncrementSessionWin = new System.Windows.Forms.CheckBox();
			this.cbIncrementSessionAlt = new System.Windows.Forms.CheckBox();
			this.cbIncrementSessionCtrl = new System.Windows.Forms.CheckBox();
			this.cboIncrementSessionKey = new System.Windows.Forms.ComboBox();
			this.cbEnterOTP = new System.Windows.Forms.CheckBox();
			this.pnlEnterOTP = new System.Windows.Forms.Panel();
			this.lblEnterOTPEnterKeyDelay = new System.Windows.Forms.Label();
			this.txtEnterOTPEnterKeyDelay = new System.Windows.Forms.TextBox();
			this.cbEnterOTPWin = new System.Windows.Forms.CheckBox();
			this.cbEnterOTPAlt = new System.Windows.Forms.CheckBox();
			this.cbEnterOTPCtrl = new System.Windows.Forms.CheckBox();
			this.cboEnterOTPKey = new System.Windows.Forms.ComboBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.cbMinimizeToSysTray = new System.Windows.Forms.CheckBox();
			this.cbStartMinimized = new System.Windows.Forms.CheckBox();
			this.gbHotkeys.SuspendLayout();
			this.pnlIncrementSession.SuspendLayout();
			this.pnlEnterOTP.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbHotkeys
			// 
			this.gbHotkeys.Controls.Add(this.cbIncrementSession);
			this.gbHotkeys.Controls.Add(this.pnlIncrementSession);
			this.gbHotkeys.Controls.Add(this.cbEnterOTP);
			this.gbHotkeys.Controls.Add(this.pnlEnterOTP);
			this.gbHotkeys.Location = new System.Drawing.Point(13, 13);
			this.gbHotkeys.Name = "gbHotkeys";
			this.gbHotkeys.Size = new System.Drawing.Size(337, 132);
			this.gbHotkeys.TabIndex = 0;
			this.gbHotkeys.TabStop = false;
			this.gbHotkeys.Text = "Hotkeys";
			// 
			// cbIncrementSession
			// 
			this.cbIncrementSession.AutoSize = true;
			this.cbIncrementSession.Location = new System.Drawing.Point(7, 85);
			this.cbIncrementSession.Name = "cbIncrementSession";
			this.cbIncrementSession.Size = new System.Drawing.Size(113, 17);
			this.cbIncrementSession.TabIndex = 7;
			this.cbIncrementSession.Text = "Increment Session";
			this.cbIncrementSession.UseVisualStyleBackColor = true;
			this.cbIncrementSession.CheckedChanged += new System.EventHandler(this.cbIncrementSession_CheckedChanged);
			// 
			// pnlIncrementSession
			// 
			this.pnlIncrementSession.Controls.Add(this.cbIncrementSessionWin);
			this.pnlIncrementSession.Controls.Add(this.cbIncrementSessionAlt);
			this.pnlIncrementSession.Controls.Add(this.cbIncrementSessionCtrl);
			this.pnlIncrementSession.Controls.Add(this.cboIncrementSessionKey);
			this.pnlIncrementSession.Enabled = false;
			this.pnlIncrementSession.Location = new System.Drawing.Point(7, 85);
			this.pnlIncrementSession.Name = "pnlIncrementSession";
			this.pnlIncrementSession.Size = new System.Drawing.Size(324, 29);
			this.pnlIncrementSession.TabIndex = 8;
			this.pnlIncrementSession.Visible = false;
			// 
			// cbIncrementSessionWin
			// 
			this.cbIncrementSessionWin.AutoSize = true;
			this.cbIncrementSessionWin.Location = new System.Drawing.Point(258, 4);
			this.cbIncrementSessionWin.Name = "cbIncrementSessionWin";
			this.cbIncrementSessionWin.Size = new System.Drawing.Size(45, 17);
			this.cbIncrementSessionWin.TabIndex = 4;
			this.cbIncrementSessionWin.Text = "Win";
			this.cbIncrementSessionWin.UseVisualStyleBackColor = true;
			this.cbIncrementSessionWin.CheckedChanged += new System.EventHandler(this.cbIncrementSessionWin_CheckedChanged);
			// 
			// cbIncrementSessionAlt
			// 
			this.cbIncrementSessionAlt.AutoSize = true;
			this.cbIncrementSessionAlt.Location = new System.Drawing.Point(214, 4);
			this.cbIncrementSessionAlt.Name = "cbIncrementSessionAlt";
			this.cbIncrementSessionAlt.Size = new System.Drawing.Size(38, 17);
			this.cbIncrementSessionAlt.TabIndex = 2;
			this.cbIncrementSessionAlt.Text = "Alt";
			this.cbIncrementSessionAlt.UseVisualStyleBackColor = true;
			this.cbIncrementSessionAlt.CheckedChanged += new System.EventHandler(this.cbIncrementSessionAlt_CheckedChanged);
			// 
			// cbIncrementSessionCtrl
			// 
			this.cbIncrementSessionCtrl.AutoSize = true;
			this.cbIncrementSessionCtrl.Location = new System.Drawing.Point(167, 4);
			this.cbIncrementSessionCtrl.Name = "cbIncrementSessionCtrl";
			this.cbIncrementSessionCtrl.Size = new System.Drawing.Size(41, 17);
			this.cbIncrementSessionCtrl.TabIndex = 1;
			this.cbIncrementSessionCtrl.Text = "Ctrl";
			this.cbIncrementSessionCtrl.UseVisualStyleBackColor = true;
			this.cbIncrementSessionCtrl.CheckedChanged += new System.EventHandler(this.cbIncrementSessionCtrl_CheckedChanged);
			// 
			// cboIncrementSessionKey
			// 
			this.cboIncrementSessionKey.FormattingEnabled = true;
			this.cboIncrementSessionKey.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
			this.cboIncrementSessionKey.Location = new System.Drawing.Point(119, 0);
			this.cboIncrementSessionKey.Name = "cboIncrementSessionKey";
			this.cboIncrementSessionKey.Size = new System.Drawing.Size(42, 21);
			this.cboIncrementSessionKey.TabIndex = 0;
			this.cboIncrementSessionKey.SelectedIndexChanged += new System.EventHandler(this.cboIncrementSessionKey_SelectedIndexChanged);
			// 
			// cbEnterOTP
			// 
			this.cbEnterOTP.AutoSize = true;
			this.cbEnterOTP.Location = new System.Drawing.Point(7, 20);
			this.cbEnterOTP.Name = "cbEnterOTP";
			this.cbEnterOTP.Size = new System.Drawing.Size(76, 17);
			this.cbEnterOTP.TabIndex = 0;
			this.cbEnterOTP.Text = "Enter OTP";
			this.cbEnterOTP.UseVisualStyleBackColor = true;
			this.cbEnterOTP.CheckedChanged += new System.EventHandler(this.cbEnterOTP_CheckedChanged);
			// 
			// pnlEnterOTP
			// 
			this.pnlEnterOTP.Controls.Add(this.lblEnterOTPEnterKeyDelay);
			this.pnlEnterOTP.Controls.Add(this.txtEnterOTPEnterKeyDelay);
			this.pnlEnterOTP.Controls.Add(this.cbEnterOTPWin);
			this.pnlEnterOTP.Controls.Add(this.cbEnterOTPAlt);
			this.pnlEnterOTP.Controls.Add(this.cbEnterOTPCtrl);
			this.pnlEnterOTP.Controls.Add(this.cboEnterOTPKey);
			this.pnlEnterOTP.Enabled = false;
			this.pnlEnterOTP.Location = new System.Drawing.Point(7, 20);
			this.pnlEnterOTP.Name = "pnlEnterOTP";
			this.pnlEnterOTP.Size = new System.Drawing.Size(324, 59);
			this.pnlEnterOTP.TabIndex = 1;
			this.pnlEnterOTP.Visible = false;
			// 
			// lblEnterOTPEnterKeyDelay
			// 
			this.lblEnterOTPEnterKeyDelay.AutoSize = true;
			this.lblEnterOTPEnterKeyDelay.Location = new System.Drawing.Point(195, 31);
			this.lblEnterOTPEnterKeyDelay.Name = "lblEnterOTPEnterKeyDelay";
			this.lblEnterOTPEnterKeyDelay.Size = new System.Drawing.Size(83, 13);
			this.lblEnterOTPEnterKeyDelay.TabIndex = 6;
			this.lblEnterOTPEnterKeyDelay.Text = "Enter Key Delay";
			// 
			// txtEnterOTPEnterKeyDelay
			// 
			this.txtEnterOTPEnterKeyDelay.Location = new System.Drawing.Point(119, 28);
			this.txtEnterOTPEnterKeyDelay.Name = "txtEnterOTPEnterKeyDelay";
			this.txtEnterOTPEnterKeyDelay.Size = new System.Drawing.Size(70, 20);
			this.txtEnterOTPEnterKeyDelay.TabIndex = 5;
			this.txtEnterOTPEnterKeyDelay.TextChanged += new System.EventHandler(this.txtEnterOTPEnterKeyDelay_TextChanged);
			// 
			// cbEnterOTPWin
			// 
			this.cbEnterOTPWin.AutoSize = true;
			this.cbEnterOTPWin.Location = new System.Drawing.Point(258, 4);
			this.cbEnterOTPWin.Name = "cbEnterOTPWin";
			this.cbEnterOTPWin.Size = new System.Drawing.Size(45, 17);
			this.cbEnterOTPWin.TabIndex = 4;
			this.cbEnterOTPWin.Text = "Win";
			this.cbEnterOTPWin.UseVisualStyleBackColor = true;
			this.cbEnterOTPWin.CheckedChanged += new System.EventHandler(this.cbEnterOTPWin_CheckedChanged);
			// 
			// cbEnterOTPAlt
			// 
			this.cbEnterOTPAlt.AutoSize = true;
			this.cbEnterOTPAlt.Location = new System.Drawing.Point(214, 4);
			this.cbEnterOTPAlt.Name = "cbEnterOTPAlt";
			this.cbEnterOTPAlt.Size = new System.Drawing.Size(38, 17);
			this.cbEnterOTPAlt.TabIndex = 2;
			this.cbEnterOTPAlt.Text = "Alt";
			this.cbEnterOTPAlt.UseVisualStyleBackColor = true;
			this.cbEnterOTPAlt.CheckedChanged += new System.EventHandler(this.cbEnterOTPAlt_CheckedChanged);
			// 
			// cbEnterOTPCtrl
			// 
			this.cbEnterOTPCtrl.AutoSize = true;
			this.cbEnterOTPCtrl.Location = new System.Drawing.Point(167, 4);
			this.cbEnterOTPCtrl.Name = "cbEnterOTPCtrl";
			this.cbEnterOTPCtrl.Size = new System.Drawing.Size(41, 17);
			this.cbEnterOTPCtrl.TabIndex = 1;
			this.cbEnterOTPCtrl.Text = "Ctrl";
			this.cbEnterOTPCtrl.UseVisualStyleBackColor = true;
			this.cbEnterOTPCtrl.CheckedChanged += new System.EventHandler(this.cbEnterOTPCtrl_CheckedChanged);
			// 
			// cboEnterOTPKey
			// 
			this.cboEnterOTPKey.FormattingEnabled = true;
			this.cboEnterOTPKey.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
			this.cboEnterOTPKey.Location = new System.Drawing.Point(119, 0);
			this.cboEnterOTPKey.Name = "cboEnterOTPKey";
			this.cboEnterOTPKey.Size = new System.Drawing.Size(42, 21);
			this.cboEnterOTPKey.TabIndex = 0;
			this.cboEnterOTPKey.SelectedIndexChanged += new System.EventHandler(this.cboEnterOTPKey_SelectedIndexChanged);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(275, 238);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(194, 238);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 2;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// cbMinimizeToSysTray
			// 
			this.cbMinimizeToSysTray.AutoSize = true;
			this.cbMinimizeToSysTray.Location = new System.Drawing.Point(20, 152);
			this.cbMinimizeToSysTray.Name = "cbMinimizeToSysTray";
			this.cbMinimizeToSysTray.Size = new System.Drawing.Size(139, 17);
			this.cbMinimizeToSysTray.TabIndex = 3;
			this.cbMinimizeToSysTray.Text = "Minimize to System Tray";
			this.cbMinimizeToSysTray.UseVisualStyleBackColor = true;
			this.cbMinimizeToSysTray.CheckedChanged += new System.EventHandler(this.cbMinimizeToSysTray_CheckedChanged);
			// 
			// cbStartMinimized
			// 
			this.cbStartMinimized.AutoSize = true;
			this.cbStartMinimized.Location = new System.Drawing.Point(38, 175);
			this.cbStartMinimized.Name = "cbStartMinimized";
			this.cbStartMinimized.Size = new System.Drawing.Size(97, 17);
			this.cbStartMinimized.TabIndex = 4;
			this.cbStartMinimized.Text = "Start Minimized";
			this.cbStartMinimized.UseVisualStyleBackColor = true;
			this.cbStartMinimized.CheckedChanged += new System.EventHandler(this.cbStartMinimized_CheckedChanged);
			// 
			// Settings
			// 
			this.AcceptButton = this.btnSave;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(362, 273);
			this.ControlBox = false;
			this.Controls.Add(this.cbStartMinimized);
			this.Controls.Add(this.cbMinimizeToSysTray);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.gbHotkeys);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Settings";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "Yubikey Token Simulator - Settings";
			this.gbHotkeys.ResumeLayout(false);
			this.gbHotkeys.PerformLayout();
			this.pnlIncrementSession.ResumeLayout(false);
			this.pnlIncrementSession.PerformLayout();
			this.pnlEnterOTP.ResumeLayout(false);
			this.pnlEnterOTP.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox gbHotkeys;
		private System.Windows.Forms.CheckBox cbEnterOTP;
		private System.Windows.Forms.Panel pnlEnterOTP;
		private System.Windows.Forms.ComboBox cboEnterOTPKey;
		private System.Windows.Forms.CheckBox cbEnterOTPAlt;
		private System.Windows.Forms.CheckBox cbEnterOTPCtrl;
		private System.Windows.Forms.CheckBox cbEnterOTPWin;
		private System.Windows.Forms.TextBox txtEnterOTPEnterKeyDelay;
		private System.Windows.Forms.Label lblEnterOTPEnterKeyDelay;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.CheckBox cbIncrementSession;
		private System.Windows.Forms.Panel pnlIncrementSession;
		private System.Windows.Forms.CheckBox cbIncrementSessionWin;
		private System.Windows.Forms.CheckBox cbIncrementSessionAlt;
		private System.Windows.Forms.CheckBox cbIncrementSessionCtrl;
		private System.Windows.Forms.ComboBox cboIncrementSessionKey;
		private System.Windows.Forms.CheckBox cbMinimizeToSysTray;
		private System.Windows.Forms.CheckBox cbStartMinimized;
	}
}