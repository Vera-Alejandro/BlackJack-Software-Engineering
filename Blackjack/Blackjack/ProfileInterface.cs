using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using SQLite;

namespace Blackjack
{
	public partial class ProfileInterface : Form
	{
		string fileLoc = Path.Combine(Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName).FullName, "GameData.sqlite3");

		public ProfileInterface()
		{
			InitializeComponent();
		}
		private void ProfileInterface_Load(object sender, EventArgs e)
		{
			BringToFront();
			CenterToScreen();
		}

		private void Close_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void SignUpButton_Click(object sender, EventArgs e)
		{
			InfoUserLabel.Visible = false;
			ProfileInfoUser.Visible = false;
			NameInfoLabel.Visible = false;
			ProfileInfoName.Visible = false;
			PhoneInfoLabel.Visible = false;
			ProfileInfoPhone.Visible = false;
			AddressInfoLabel.Visible = false;
			ProfileInfoAddress.Visible = false;
			ChangeButton.Visible = false;

			LoginButton.Visible = false;
			SignUpButton.Visible = false;
			Soundoo.Visible = false;
			LogLabel.Visible = false;
			ActiveLogin.Visible = false;
			FundsButton.Visible = false;
			ProfileInfo.Visible = false;

			MenuButton.Visible = true;
			SignUpConfirmButton.Visible = true;
			UserSignUpLabel.Visible = true;
			UserSignUpTextBox.Visible = true;
			PassSignUpLabel.Visible = true;
			PassSignUpTextBox.Visible = true;
			NameSignUpLabel.Visible = true;
			NameSignUpTextBox.Visible = true;
			PhoneSignUpLabel.Visible = true;
			PhoneSignUpTextBox.Visible = true;
			AddressSignUpLabel.Visible = true;
			AddressSignUpTextBox.Visible = true;
			CardInfoSignUpLabel.Visible = true;
			CardInfoSignUpTextBox.Visible = true;
		}

		private void LoginButton_Click(object sender, EventArgs e)
		{
			LoginButton.Visible = false;
			SignUpButton.Visible = false;
			Soundoo.Visible = false;
			LogLabel.Visible = false;
			ActiveLogin.Visible = false;
			FundsButton.Visible = false;
			ProfileInfo.Visible = false;

			ForgotButton.Visible = true;
			MenuButton.Visible = true;
			LoginConfirm.Visible = true;
			UserLabel.Visible = true;
			UserTextBox.Visible = true;
			PassLabel.Visible = true;
			PassTextBox.Visible = true;
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
			ProfileInfo.Visible = true;


			MenuButton.Visible = false;
			LoginConfirm.Visible = false;
			UserLabel.Visible = false;
			UserTextBox.Visible = false;
			PassLabel.Visible = false;
			PassTextBox.Visible = false;

			SignUpConfirmButton.Visible = false;
			UserSignUpLabel.Visible = false;
			UserSignUpTextBox.Visible = false;
			PassSignUpLabel.Visible = false;
			PassSignUpTextBox.Visible = false;
			NameSignUpLabel.Visible = false;
			NameSignUpTextBox.Visible = false;
			PhoneSignUpLabel.Visible = false;
			PhoneSignUpTextBox.Visible = false;
			AddressSignUpLabel.Visible = false;
			AddressSignUpTextBox.Visible = false;
			CardInfoSignUpLabel.Visible = false;
			CardInfoSignUpTextBox.Visible = false;

			StatusLabel.Visible = false;

			LogStatusLabel.Visible = false;

			InfoUserLabel.Visible = false;
			ProfileInfoUser.Visible = false;
			NameInfoLabel.Visible = false;
			ProfileInfoName.Visible = false;
			PhoneInfoLabel.Visible = false;
			ProfileInfoPhone.Visible = false;
			AddressInfoLabel.Visible = false;
			ProfileInfoAddress.Visible = false;
			ChangeButton.Visible = false;

			CheckButton.Visible = false;
			ForgotUserTextBox.Visible = false;
			ForgotUserLabel.Visible = false;
			ForgotButton.Visible = false;
			ChangePasswordLabel.Visible = false;
			ChangePasswordTextBox.Visible = false;
			ConfirmNewPasswordLabel.Visible = false;
			ConfirmNewPasswordTextBox.Visible = false;
			NewPasswordButton.Visible = false;

		}

		private void LoginConfirm_Click(object sender, EventArgs e)
		{
			if (UserTextBox.Text != "" && PassTextBox.Text != "")
			{
				//ANOTHER DA BING DA DING DA DONG ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------
				bool contains = Directory.EnumerateFiles(Path.Combine(Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName).FullName, "GameData.sqlite3")).Any(f => f.Contains(UserTextBox.Text));

				if (contains == true)
				{
					Database database = new Database(fileLoc);
					database.Connect();

					Storage.ProfileInfo info = database.GetProfileData(UserTextBox.Text);

					database.Disconnect();
					string pass = info.GetPassword();

					if (PassTextBox.Text == pass)
					{//THIS IS WHERE YOU WOULD LOAD THE GAME STATE
						ActiveLogin.Text = UserTextBox.Text;
						MenuButton_Click(sender, e);
					}
				}
				else
				{
					LogStatusLabel.Visible = true;
				}
			}
			else
			{
				LogStatusLabel.Visible = true;
			}
		}

		private void SignUpConfirmButton_Click(object sender, EventArgs e)
		{
			if (UserSignUpTextBox.Text != "" && PassSignUpTextBox.Text != "" && NameSignUpTextBox.Text != "" && PhoneSignUpTextBox.Text != "" && AddressSignUpTextBox.Text != "" && CardInfoSignUpTextBox.Text != "")
			{
				Database saveFile = new Database(fileLoc);
				saveFile.Connect();

				Storage.ProfileInfo info = new Storage.ProfileInfo();

				info.SetUser(UserSignUpTextBox.Text);
				info.SetPassword(PassSignUpTextBox.Text);
				info.SetName(NameSignUpTextBox.Text);
				info.SetPhone(PhoneSignUpTextBox.Text);
				info.SetAddress(AddressSignUpTextBox.Text);
				info.SetCardNumber(CardInfoSignUpTextBox.Text);

				saveFile.SaveProfile(info);

				StatusLabel.Text = "Confirmed";
				StatusLabel.Visible = true;

				UserSignUpTextBox.Text = "";
				PassSignUpTextBox.Text = "";
				NameSignUpTextBox.Text = "";
				PhoneSignUpTextBox.Text = "";
				AddressSignUpTextBox.Text = "";
				CardInfoSignUpTextBox.Text = "";
				saveFile.Disconnect();
			}

			else
			{
				StatusLabel.Visible = true;
			}


		}

		private void ProfileInfo_Click(object sender, EventArgs e)
		{
			Database database = new Database(fileLoc);

			if (ActiveLogin.Text != "Guest")
			{
				database.Connect();

				Storage.ProfileInfo info = database.GetProfileData(UserSignUpTextBox.Text);

				LoginButton.Visible = false;
				SignUpButton.Visible = false;
				Soundoo.Visible = false;
				LogLabel.Visible = false;
				ActiveLogin.Visible = false;
				FundsButton.Visible = false;
				ProfileInfo.Visible = false;

				MenuButton.Visible = true;
				ChangeButton.Visible = true;


				ProfileInfoUser.Text = info.GetUser();
				ProfileInfoName.Text = info.GetName();
				ProfileInfoPhone.Text = info.GetPhone();
				ProfileInfoAddress.Text = info.GetAddress();

				InfoUserLabel.Visible = true;
				ProfileInfoUser.Visible = true;
				NameInfoLabel.Visible = true;
				ProfileInfoName.Visible = true;
				PhoneInfoLabel.Visible = true;
				ProfileInfoPhone.Visible = true;
				AddressInfoLabel.Visible = true;
				ProfileInfoAddress.Visible = true;

				database.Disconnect();
			}

		}

		private void ChangeButton_Click(object sender, EventArgs e)
		{
			SignUpButton_Click(sender, e);
		}

		private void ForgotButton_Click(object sender, EventArgs e)
		{	
			MenuButton.Visible = true;
			CheckButton.Visible = true;
			ForgotUserTextBox.Visible = true;
			ForgotUserLabel.Visible = true;

			ForgotButton.Visible = false;
			LoginConfirm.Visible = false;
			UserLabel.Visible = false;
			UserTextBox.Visible = false;
			PassLabel.Visible = false;
			PassTextBox.Visible = false;
		}

		private void CheckButton_Click(object sender, EventArgs e)
		{
			//THIS IS THE BA DING DA DING DONG-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
			bool contains = Directory.EnumerateFiles(Path.Combine(Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName).FullName, "GameData.sqlite3")).Any(f => f.Contains(UserTextBox.Text));

			if (contains == true)
			{
				CheckButton.Visible = false;
				ForgotUserTextBox.Visible = false;
				ForgotUserLabel.Visible = false;
				LogStatusLabel.Visible = false;

				ForgotPhoneLabel.Visible = true;
				ForgotPhoneTextBox.Visible = true;
				ForgotPhoneButton.Visible = true;
			}
			else
			{
				LogStatusLabel.Visible = true;
			}
		}

		private void ForgotPhoneButton_Click(object sender, EventArgs e)
		{
			//THIS ONE TOO ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
			bool contains = Directory.EnumerateFiles(Path.Combine(Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName).FullName, "GameData.sqlite3")).Any(f => f.Contains(UserTextBox.Text));

			if (contains == true)
			{
				Database database = new Database(fileLoc);
				database.Connect();

				Storage.ProfileInfo info = database.GetProfileData(UserSignUpTextBox.Text);

				string pphone = info.GetPhone();

				CheckButton.Visible = false;
				ForgotUserTextBox.Visible = false;
				ForgotUserLabel.Visible = false;
				LogStatusLabel.Visible = false;

				ForgotPhoneLabel.Visible = true;
				ForgotPhoneTextBox.Visible = true;
				ForgotPhoneButton.Visible = true;

				if (ForgotPhoneTextBox.Text == pphone)
				{
					ForgotPhoneLabel.Visible = false;
					ForgotPhoneTextBox.Visible = false;
					ForgotPhoneButton.Visible = false;

					ChangePasswordLabel.Visible = true;
					ChangePasswordTextBox.Visible = true;
					ConfirmNewPasswordLabel.Visible = true;
					ConfirmNewPasswordTextBox.Visible = true;
					NewPasswordButton.Visible = true;
				}
				else
				{
					LogStatusLabel.Visible = true;
				}
				database.Disconnect();
			}
			else
			{
				LogStatusLabel.Visible = true;
			}
		}

		private void NewPasswordButton_Click(object sender, EventArgs e)
		{
			Database database = new Database(fileLoc);
			database.Connect();

			Storage.ProfileInfo info = database.GetProfileData(UserSignUpTextBox.Text);

			if (ChangePasswordTextBox.Text == ConfirmNewPasswordTextBox.Text)
			{
				info.SetPassword(ConfirmNewPasswordTextBox.Text);
				MenuButton_Click(sender, e);
			}
			else
			{
				LogStatusLabel.Visible = true;
			}
			database.Disconnect();
		}
	}
}
