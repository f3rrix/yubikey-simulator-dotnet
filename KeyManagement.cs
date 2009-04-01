using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Yubikey.TokenSimulator.Configuration;

namespace Yubikey.TokenSimulator
{
	public partial class KeyManagement : Form
	{
		private StringParsing.ParseString parser;
		private StringEncoding.ParseBytes encoder;

		private const int _expandedWidth = 1017;
		private const int _contractedWidth = 688;

		public KeyManagement(YubikeysCollection keys)
		{
			InitializeComponent();
			this.cboKeyFormat.SelectedIndex = 0;
			this.dataGridView1.AutoGenerateColumns = false;
			this.Width = _contractedWidth;
			this.cboAddKeyFormat.SelectedIndex = 0;
			this.cbPressEnter.Checked = true;
			this.panel1.Enabled = false;

			this.dataGridView1.DataSource = keys;
		}

		void dataGridView1_CellFormatting(object sender, System.Windows.Forms.DataGridViewCellFormattingEventArgs e)
		{
			switch (e.ColumnIndex)
			{
				case 1: // TokenID
				case 2: // Secret
				case 4: // PrivateID
					e.Value = encoder((byte[])e.Value);
					break;
			}
		}

		void dataGridView1_CellParsing(object sender, System.Windows.Forms.DataGridViewCellParsingEventArgs e)
		{
			switch (e.ColumnIndex)
			{
				case 1: // TokenID
				case 2: // Secret
				case 4: // PrivateID
					e.Value = parser((string)e.Value);
					e.ParsingApplied = true;
					break;
			}
		}

		private void btnAddKey_Click(object sender, EventArgs e)
		{
			btnAddKey.Enabled = false;
			panel1.Enabled = true;
			this.Width = _expandedWidth;
			txtName.Clear();
			txtSecret.Clear();
			txtTokenID.Clear();
			txtPrivateID.Clear();
			txtSessionCounter.Text = "0";
			txtName.Focus();
		}

		bool AddKey(string name, byte[] secret, byte[] tokenID, byte[] privateID, int sessionCounter, bool pressEnter)
		{
			YubikeySettings key = new YubikeySettings();
			key.Name = name;
			key.Secret = secret;
			key.TokenID = tokenID;
			key.PrivateID = privateID;
			key.SessionCounter = sessionCounter;
			key.PressEnter = pressEnter;
			YubikeysCollection keys = (YubikeysCollection)dataGridView1.DataSource;
			if (keys.Contains(key))
				return false;
			keys.Add(key);
			dataGridView1.DataSource = null;
			dataGridView1.Invalidate();
			dataGridView1.DataSource = keys;
			return true;
		}

		private void btnDeleteKey_Click(object sender, EventArgs e)
		{
			if (dataGridView1.SelectedRows.Count == 0 && dataGridView1.SelectedCells.Count == 0)
				return;
			YubikeysCollection keys = (YubikeysCollection)dataGridView1.DataSource;
			if (dataGridView1.SelectedRows.Count == 0)
			{
				foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
				{
					keys.Remove((YubikeySettings)dataGridView1.Rows[cell.RowIndex].DataBoundItem);
				}
			}
			else
			{
				foreach (DataGridViewRow row in dataGridView1.SelectedRows)
				{
					keys.Remove((YubikeySettings)row.DataBoundItem);
				}
			}
			dataGridView1.DataSource = null;
			dataGridView1.Invalidate();
			dataGridView1.DataSource = keys;
		}

		private void cboKeyFormat_SelectedIndexChanged(object sender, EventArgs e)
		{
			parser = StringParsing.GetParser((string)cboKeyFormat.SelectedItem);
			encoder = StringEncoding.GetEncoder((string)cboKeyFormat.SelectedItem);
			dataGridView1.Invalidate();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (txtName.Text == "")
			{
				MessageBox.Show("Name is required");
				return;
			}
			byte[] secret;
			byte[] tokenID;
			byte[] privateID;
			StringParsing.ParseString parser;
			try
			{
				parser = StringParsing.GetParser((string)cboAddKeyFormat.SelectedItem);
				secret = parser(txtSecret.Text);
				if (secret.Length != 16)
				{
					MessageBox.Show("Secret must be 16-bytes");
					return;
				}
				tokenID = parser(txtTokenID.Text);
				if (tokenID.Length != 6)
				{
					MessageBox.Show("TokenID must be 6-bytes");
					return;
				}
				privateID = parser(txtPrivateID.Text);
				if (privateID.Length != 6)
				{
					MessageBox.Show("PrivateID must be 6-bytes");
					return;
				}
			}
			catch
			{
				MessageBox.Show("Could not parse key(s)");
				return;
			}
			int sessionCounter = 0;
			if (!int.TryParse(txtSessionCounter.Text, out sessionCounter))
			{
				MessageBox.Show("Session Counter must be a valid number");
				return;
			}
			if (!AddKey(txtName.Text, secret, tokenID, privateID, sessionCounter, cbPressEnter.Checked))
				MessageBox.Show("Duplicate Name");
			else
			{
				txtName.Clear();
				txtSecret.Clear();
				txtTokenID.Clear();
				txtPrivateID.Clear();
				txtSessionCounter.Text = "0";
			}
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Width = _contractedWidth;
			this.panel1.Enabled = false;
			btnAddKey.Enabled = true;
		}
	}
}