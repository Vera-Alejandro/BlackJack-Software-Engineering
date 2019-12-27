using System;
using System.Windows.Forms;
using System.IO;
using SQLite;

namespace Blackjack
{
	public partial class ProfileInterface : Form
	{
		internal string fileLoc = Path.Combine(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName, "GameData.sqlite3");
		public string GlobalUserName { get { return ActiveLogin.Text; } set {  value = TheUsername; } }

		internal string TheUsername;
		private int UsersLoggedIn = 0;

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
			ProfilePanel.Visible = false;

			Main.Visible = false;

			SignUp.Visible = true;
		}

		private void LoginButton_Click(object sender, EventArgs e)
		{
			Main.Visible = false;

			LogIn.Visible = true;
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
			Main.Visible = true;

			LogIn.Visible = false;

			SignUp.Visible = false;

			ProfilePanel.Visible = false;

			ForgotPassword.Visible = false;
		}

		private void LoginConfirm_Click(object sender, EventArgs e)
		{
			Database database = new Database(fileLoc);
			if (UserTextBox.Text != "" && PassTextBox.Text != "")
			{
				bool contains = database.DoesUserExist(TheUsername);

				if (contains)
				{
					database.Connect();

					Storage.ProfileInfo info = database.GetProfileData(TheUsername);

					database.Disconnect();
					string pass = info.GetPassword();

					if (PassTextBox.Text == pass)
					{
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
			if (UserSignUpTextBox.Text != "" && 
				PassSignUpTextBox.Text != "" && 
				NameSignUpTextBox.Text != "" && 
				PhoneSignUpTextBox.Text != "" && 
				AddressSignUpTextBox.Text != "" && 
				CardInfoSignUpTextBox.Text != "")
			{
				Database saveFile = new Database(fileLoc);
				saveFile.Connect();

				Storage.ProfileInfo info = new Storage.ProfileInfo();

				TheUsername = UserSignUpTextBox.Text;
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

				Storage.ProfileInfo info = database.GetProfileData(TheUsername);

				Main.Visible = false;
				
				ProfileInfoUser.Text = info.GetUser();
				ProfileInfoName.Text = info.GetName();
				ProfileInfoPhone.Text = info.GetPhoneNumber();
				ProfileInfoAddress.Text = info.GetAddress();

				ProfilePanel.Visible = true;

				database.Disconnect();
			}

		}

		private void ChangeButton_Click(object sender, EventArgs e)
		{
			SignUpButton_Click(sender, e);
		}

		private void ForgotButton_Click(object sender, EventArgs e)
		{
			ForgotPassword.Visible = true;

			LogIn.Visible = false;
		}

		private void CheckButton_Click(object sender, EventArgs e)
		{
			Database database = new Database(fileLoc);

			bool contains = database.DoesUserExist(TheUsername);

			if (contains)
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
			Database database = new Database(fileLoc);
			bool contains = database.DoesUserExist(TheUsername);

			if (contains)
			{
				database.Connect();

				Storage.ProfileInfo info = database.GetProfileData(UserSignUpTextBox.Text);

				string pphone = info.GetPhoneNumber();

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

			Storage.ProfileInfo info = database.GetProfileData(TheUsername);

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

		private void UserTextBox_TextChanged(object sender, EventArgs e)
		{
			TheUsername = UserTextBox.Text;
		}

		private void PassTextBox_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				LoginConfirm_Click(null, null);
			}
		}

		private void ActiveLogin_TextChanged(object sender, EventArgs e)
		{
			TheUsername = ActiveLogin.Text; 
		}
	}
}
