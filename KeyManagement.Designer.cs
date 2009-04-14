namespace Yubikey.TokenSimulator
{
	partial class KeyManagement
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.dgColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgColTokenID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgColSecret = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgColSessionCounter = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgColPrivateID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgColPressEnter = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.btnDeleteKey = new System.Windows.Forms.Button();
			this.btnAddKey = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.cboKeyFormat = new System.Windows.Forms.ComboBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label7 = new System.Windows.Forms.Label();
			this.cbPressEnter = new System.Windows.Forms.CheckBox();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.txtSessionCounter = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtPrivateID = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtTokenID = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtSecret = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.cboAddKeyFormat = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToResizeColumns = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)));
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgColName,
            this.dgColTokenID,
            this.dgColSecret,
            this.dgColSessionCounter,
            this.dgColPrivateID,
            this.dgColPressEnter});
			this.dataGridView1.Location = new System.Drawing.Point(12, 41);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(656, 271);
			this.dataGridView1.TabIndex = 1;
			this.dataGridView1.CellParsing += new System.Windows.Forms.DataGridViewCellParsingEventHandler(this.dataGridView1_CellParsing);
			this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
			// 
			// dgColName
			// 
			this.dgColName.DataPropertyName = "Name";
			this.dgColName.HeaderText = "Name";
			this.dgColName.Name = "dgColName";
			// 
			// dgColTokenID
			// 
			this.dgColTokenID.DataPropertyName = "TokenID";
			this.dgColTokenID.HeaderText = "Token ID";
			this.dgColTokenID.Name = "dgColTokenID";
			// 
			// dgColSecret
			// 
			this.dgColSecret.DataPropertyName = "Secret";
			this.dgColSecret.HeaderText = "AES Secret";
			this.dgColSecret.Name = "dgColSecret";
			// 
			// dgColSessionCounter
			// 
			this.dgColSessionCounter.DataPropertyName = "SessionCounter";
			this.dgColSessionCounter.HeaderText = "Session Counter";
			this.dgColSessionCounter.Name = "dgColSessionCounter";
			// 
			// dgColPrivateID
			// 
			this.dgColPrivateID.DataPropertyName = "PrivateID";
			this.dgColPrivateID.HeaderText = "Private ID";
			this.dgColPrivateID.Name = "dgColPrivateID";
			// 
			// dgColPressEnter
			// 
			this.dgColPressEnter.DataPropertyName = "PressEnter";
			this.dgColPressEnter.HeaderText = "Press Enter";
			this.dgColPressEnter.Name = "dgColPressEnter";
			// 
			// btnDeleteKey
			// 
			this.btnDeleteKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnDeleteKey.Location = new System.Drawing.Point(541, 317);
			this.btnDeleteKey.Name = "btnDeleteKey";
			this.btnDeleteKey.Size = new System.Drawing.Size(127, 23);
			this.btnDeleteKey.TabIndex = 3;
			this.btnDeleteKey.Text = "Delete Selected Key";
			this.btnDeleteKey.UseVisualStyleBackColor = true;
			this.btnDeleteKey.Click += new System.EventHandler(this.btnDeleteKey_Click);
			// 
			// btnAddKey
			// 
			this.btnAddKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnAddKey.Location = new System.Drawing.Point(460, 317);
			this.btnAddKey.Name = "btnAddKey";
			this.btnAddKey.Size = new System.Drawing.Size(75, 23);
			this.btnAddKey.TabIndex = 2;
			this.btnAddKey.Text = "Add Key";
			this.btnAddKey.UseVisualStyleBackColor = true;
			this.btnAddKey.Click += new System.EventHandler(this.btnAddKey_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Key Format";
			// 
			// cboKeyFormat
			// 
			this.cboKeyFormat.FormattingEnabled = true;
			this.cboKeyFormat.Items.AddRange(new object[] {
            "Base64",
            "Hex",
            "ModHex"});
			this.cboKeyFormat.Location = new System.Drawing.Point(78, 12);
			this.cboKeyFormat.Name = "cboKeyFormat";
			this.cboKeyFormat.Size = new System.Drawing.Size(121, 21);
			this.cboKeyFormat.TabIndex = 0;
			this.cboKeyFormat.SelectedIndexChanged += new System.EventHandler(this.cboKeyFormat_SelectedIndexChanged);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.cbPressEnter);
			this.panel1.Controls.Add(this.btnClose);
			this.panel1.Controls.Add(this.btnAdd);
			this.panel1.Controls.Add(this.txtSessionCounter);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.txtPrivateID);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.txtTokenID);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.txtName);
			this.panel1.Controls.Add(this.txtSecret);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.cboAddKeyFormat);
			this.panel1.Location = new System.Drawing.Point(706, 41);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(291, 271);
			this.panel1.TabIndex = 5;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(11, 193);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(93, 13);
			this.label7.TabIndex = 49;
			this.label7.Text = "Key Presses Enter";
			// 
			// cbPressEnter
			// 
			this.cbPressEnter.AutoSize = true;
			this.cbPressEnter.Location = new System.Drawing.Point(135, 193);
			this.cbPressEnter.Name = "cbPressEnter";
			this.cbPressEnter.Size = new System.Drawing.Size(15, 14);
			this.cbPressEnter.TabIndex = 46;
			this.cbPressEnter.UseVisualStyleBackColor = true;
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(218, 213);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(61, 23);
			this.btnClose.TabIndex = 48;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(170, 213);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(42, 23);
			this.btnAdd.TabIndex = 47;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// txtSessionCounter
			// 
			this.txtSessionCounter.Location = new System.Drawing.Point(135, 166);
			this.txtSessionCounter.Name = "txtSessionCounter";
			this.txtSessionCounter.Size = new System.Drawing.Size(144, 20);
			this.txtSessionCounter.TabIndex = 45;
			this.txtSessionCounter.Text = "0";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(11, 169);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(84, 13);
			this.label6.TabIndex = 44;
			this.label6.Text = "Session Counter";
			// 
			// txtPrivateID
			// 
			this.txtPrivateID.Location = new System.Drawing.Point(135, 140);
			this.txtPrivateID.Name = "txtPrivateID";
			this.txtPrivateID.Size = new System.Drawing.Size(144, 20);
			this.txtPrivateID.TabIndex = 44;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(11, 143);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(51, 13);
			this.label3.TabIndex = 42;
			this.label3.Text = "PrivateID";
			// 
			// txtTokenID
			// 
			this.txtTokenID.Location = new System.Drawing.Point(135, 114);
			this.txtTokenID.Name = "txtTokenID";
			this.txtTokenID.Size = new System.Drawing.Size(144, 20);
			this.txtTokenID.TabIndex = 43;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(11, 117);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(49, 13);
			this.label4.TabIndex = 38;
			this.label4.Text = "TokenID";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(11, 37);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(35, 13);
			this.label5.TabIndex = 41;
			this.label5.Text = "Name";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(135, 34);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(144, 20);
			this.txtName.TabIndex = 40;
			// 
			// txtSecret
			// 
			this.txtSecret.Location = new System.Drawing.Point(135, 88);
			this.txtSecret.Name = "txtSecret";
			this.txtSecret.Size = new System.Drawing.Size(144, 20);
			this.txtSecret.TabIndex = 42;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(11, 91);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 13);
			this.label2.TabIndex = 36;
			this.label2.Text = "AES Secret";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(11, 63);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(60, 13);
			this.label8.TabIndex = 35;
			this.label8.Text = "Key Format";
			// 
			// cboAddKeyFormat
			// 
			this.cboAddKeyFormat.FormattingEnabled = true;
			this.cboAddKeyFormat.Items.AddRange(new object[] {
            "Base64",
            "Hex",
            "ModHex"});
			this.cboAddKeyFormat.Location = new System.Drawing.Point(135, 60);
			this.cboAddKeyFormat.Name = "cboAddKeyFormat";
			this.cboAddKeyFormat.Size = new System.Drawing.Size(144, 21);
			this.cboAddKeyFormat.TabIndex = 41;
			// 
			// KeyManagement
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1009, 352);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.cboKeyFormat);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnAddKey);
			this.Controls.Add(this.btnDeleteKey);
			this.Controls.Add(this.dataGridView1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "KeyManagement";
			this.Text = "Key Management";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnDeleteKey;
		private System.Windows.Forms.Button btnAddKey;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cboKeyFormat;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgColName;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgColTokenID;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgColSecret;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgColSessionCounter;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgColPrivateID;
		private System.Windows.Forms.DataGridViewCheckBoxColumn dgColPressEnter;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.CheckBox cbPressEnter;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.TextBox txtSessionCounter;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtPrivateID;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtTokenID;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtSecret;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox cboAddKeyFormat;
	}
}