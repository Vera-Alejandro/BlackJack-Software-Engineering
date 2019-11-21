using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack
{
	public partial class ProfileInterface : Form
	{
		public ProfileInterface()
		{
			InitializeComponent();
		}
		private void ProfileInterface_Load(object sender, EventArgs e)
		{
			CenterToScreen();
		}

		private void Close_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void SignUpButton_Click(object sender, EventArgs e)
		{
			LoginButton.Visible = false;
			SignUpButton.Visible = false;
			Soundoo.Visible = false;
			LogLabel.Visible = false;
			ActiveLogin.Visible = false;
			FundsButton.Visible = false;

			MenuButton.Visible = true;
			UPLabel.Visible = true;
			UPTextBox.Visible = true;
		}

		private void LoginButton_Click(object sender, EventArgs e)
		{
			LoginButton.Visible = false;
			SignUpButton.Visible = false;
			Soundoo.Visible = false;
			LogLabel.Visible = false;
			ActiveLogin.Visible = false;
			FundsButton.Visible = false;

			MenuButton.Visible = true;
			LoginConfirm.Visible = true;
			UPLabel.Visible = true;
			UPTextBox.Visible = true;
		}

		private void Soundoo_Click(object sender, EventArgs e)
		{
			if (Soundoo.Text == "Sound On")
				Soundoo.Text = "Sound Off";
			else if (Soundoo.Text == "Sound Off")
				Soundoo.Text = "Sound On";
		}

		private void MenuButton_Click(object sender, EventArgs e)
		{
			LoginButton.Visible = true;
			SignUpButton.Visible = true;
			Soundoo.Visible = true;
			LogLabel.Visible = true;
			ActiveLogin.Visible = true;
			FundsButton.Visible = true;

			MenuButton.Visible = false;
			LoginConfirm.Visible = false;
			UPLabel.Visible = false;
			UPTextBox.Visible = false;
		}

		private void LoginConfirm_Click(object sender, EventArgs e)
		{
			ForgotButton.Visible = true;

			UPLabel.Text = "Pass";
			LoginConfirm.Text = "Log in";
		}
	}
}
