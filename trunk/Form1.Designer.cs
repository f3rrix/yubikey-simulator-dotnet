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
			this.comboBox1 = new System.Windows.Forms.ComboBox();
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
			this.SuspendLayout();
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(13, 13);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 0;
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
			this.txtOTP.Location = new System.Drawing.Point(48, 159);
			this.txtOTP.Name = "txtOTP";
			this.txtOTP.ReadOnly = true;
			this.txtOTP.Size = new System.Drawing.Size(232, 20);
			this.txtOTP.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 162);
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
			this.txtSessionCounter.Location = new System.Drawing.Point(99, 41);
			this.txtSessionCounter.Name = "txtSessionCounter";
			this.txtSessionCounter.ReadOnly = true;
			this.txtSessionCounter.Size = new System.Drawing.Size(100, 20);
			this.txtSessionCounter.TabIndex = 6;
			// 
			// txtUseCounter
			// 
			this.txtUseCounter.BackColor = System.Drawing.SystemColors.Window;
			this.txtUseCounter.Location = new System.Drawing.Point(99, 68);
			this.txtUseCounter.Name = "txtUseCounter";
			this.txtUseCounter.ReadOnly = true;
			this.txtUseCounter.Size = new System.Drawing.Size(100, 20);
			this.txtUseCounter.TabIndex = 7;
			// 
			// txtTimestamp
			// 
			this.txtTimestamp.BackColor = System.Drawing.SystemColors.Window;
			this.txtTimestamp.Location = new System.Drawing.Point(99, 95);
			this.txtTimestamp.Name = "txtTimestamp";
			this.txtTimestamp.ReadOnly = true;
			this.txtTimestamp.Size = new System.Drawing.Size(100, 20);
			this.txtTimestamp.TabIndex = 8;
			// 
			// txtRandom
			// 
			this.txtRandom.BackColor = System.Drawing.SystemColors.Window;
			this.txtRandom.Location = new System.Drawing.Point(99, 122);
			this.txtRandom.Name = "txtRandom";
			this.txtRandom.ReadOnly = true;
			this.txtRandom.Size = new System.Drawing.Size(100, 20);
			this.txtRandom.TabIndex = 9;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 44);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(84, 13);
			this.label2.TabIndex = 10;
			this.label2.Text = "Session Counter";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 71);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(66, 13);
			this.label3.TabIndex = 11;
			this.label3.Text = "Use Counter";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(13, 98);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(58, 13);
			this.label4.TabIndex = 12;
			this.label4.Text = "Timestamp";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(13, 125);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(47, 13);
			this.label5.TabIndex = 13;
			this.label5.Text = "Random";
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
			this.Controls.Add(this.comboBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBox1;
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
	}
}

