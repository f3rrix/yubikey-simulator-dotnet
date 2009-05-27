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
	public partial class Settings : Form
	{
		SettingsSection _settings;

		public Settings(SettingsSection settings)
		{
			_settings = settings;
			InitializeComponent();

			cbEnterOTP.Checked = _settings.EnterOTP.Enabled;
			cboEnterOTPKey.SelectedItem = _settings.EnterOTP.Key.ToUpper();
			cbEnterOTPShift.Checked = _settings.EnterOTP.Shift;
			cbEnterOTPCtrl.Checked = _settings.EnterOTP.Ctrl;
			cbEnterOTPAlt.Checked = _settings.EnterOTP.Alt;
			cbEnterOTPWin.Checked = _settings.EnterOTP.Win;
			txtEnterOTPEnterKeyDelay.Text = _settings.EnterOTP.EnterKeyDelay.ToString();
			cbIncrementSession.Checked = _settings.IncrementSession.Enabled;
			cboIncrementSessionKey.SelectedItem = _settings.IncrementSession.Key.ToUpper();
			cbIncrementSessionShift.Checked = _settings.IncrementSession.Shift;
			cbIncrementSessionCtrl.Checked = _settings.IncrementSession.Ctrl;
			cbIncrementSessionAlt.Checked = _settings.IncrementSession.Alt;
			cbIncrementSessionWin.Checked = _settings.IncrementSession.Win;
		}

		private void cbEnterOTP_CheckedChanged(object sender, EventArgs e)
		{
			pnlEnterOTP.Visible = cbEnterOTP.Checked;
			pnlEnterOTP.Enabled = cbEnterOTP.Checked;
			_settings.EnterOTP.Enabled = cbEnterOTP.Checked;
		}

		private void cboEnterOTPKey_SelectedIndexChanged(object sender, EventArgs e)
		{
			_settings.EnterOTP.Key = (string)cboEnterOTPKey.SelectedItem;
		}

		private void cbEnterOTPCtrl_CheckedChanged(object sender, EventArgs e)
		{
			_settings.EnterOTP.Ctrl = cbEnterOTPCtrl.Checked;
		}

		private void cbEnterOTPAlt_CheckedChanged(object sender, EventArgs e)
		{
			_settings.EnterOTP.Alt = cbEnterOTPAlt.Checked;
		}

		private void cbEnterOTPShift_CheckedChanged(object sender, EventArgs e)
		{
			_settings.EnterOTP.Shift = cbEnterOTPShift.Checked;
		}

		private void cbEnterOTPWin_CheckedChanged(object sender, EventArgs e)
		{
			_settings.EnterOTP.Win = cbEnterOTPWin.Checked;
		}

		private void txtEnterOTPEnterKeyDelay_TextChanged(object sender, EventArgs e)
		{
			int tmpInt = 0;
			if (!int.TryParse(txtEnterOTPEnterKeyDelay.Text, out tmpInt))
			{
				MessageBox.Show("Invalid delay value");
				txtEnterOTPEnterKeyDelay.Text = "";
			}
			else
			{
				_settings.EnterOTP.EnterKeyDelay = tmpInt;
			}
		}

		private void cbIncrementSession_CheckedChanged(object sender, EventArgs e)
		{
			pnlIncrementSession.Visible = cbIncrementSession.Checked;
			pnlIncrementSession.Enabled = cbIncrementSession.Checked;
			_settings.IncrementSession.Enabled = cbIncrementSession.Checked;
		}

		private void cboIncrementSessionKey_SelectedIndexChanged(object sender, EventArgs e)
		{
			_settings.IncrementSession.Key = (string)cboIncrementSessionKey.SelectedItem;
		}

		private void cbIncrementSessionCtrl_CheckedChanged(object sender, EventArgs e)
		{
			_settings.IncrementSession.Ctrl = cbIncrementSessionCtrl.Checked;
		}

		private void cbIncrementSessionAlt_CheckedChanged(object sender, EventArgs e)
		{
			_settings.IncrementSession.Alt = cbIncrementSessionAlt.Checked;
		}

		private void cbIncrementSessionShift_CheckedChanged(object sender, EventArgs e)
		{
			_settings.IncrementSession.Shift = cbIncrementSessionShift.Checked;
		}

		private void cbIncrementSessionWin_CheckedChanged(object sender, EventArgs e)
		{
			_settings.IncrementSession.Win = cbIncrementSessionWin.Checked;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{

		}
	}
}