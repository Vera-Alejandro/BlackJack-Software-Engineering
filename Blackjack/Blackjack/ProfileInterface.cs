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

namespace Blackjack
{
	public partial class ProfileInterface : Form
	{
		string Fullname;

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

		}

		private void LoginConfirm_Click(object sender, EventArgs e)
		{
			if (UserTextBox.Text != "" && PassTextBox.Text != "")
			{
				bool contains = Directory.EnumerateFiles(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "BlackJackGame")).Any(f => f.Contains(UserTextBox.Text));
				if (contains == true)
				{
					ActiveLogin.Text = UserTextBox.Text;
					MenuButton_Click(sender, e);

					//this needs to read the username and password, it is only reading the username right now
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
			if (UserSignUpTextBox.Text != "" && PassSignUpTextBox.Text != "" && NameSignUpTextBox.Text != "" && PhoneSignUpTextBox.Text != "" && AddressSignUpTextBox.Text != "" && CardInfoSignUpTextBox.Text != "") {

				bool exists = Directory.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "BlackJackGame"));

				if (!exists)
					Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "BlackJackGame"));

				Fullname = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "BlackJackGame/") + UserSignUpTextBox.Text + NameSignUpTextBox.Text + "info.txt";

				if(File.Exists(Fullname))
					File.Delete(Fullname);

				FileStream fs = File.Create(Fullname);
				fs.Close();

				StreamWriter write = new StreamWriter(Fullname);

				write.WriteLine("////////////////////////////////////");
				write.WriteLine(UserSignUpTextBox.Text);
				write.WriteLine(PassSignUpTextBox.Text);
				write.WriteLine(NameSignUpTextBox.Text); 
				write.WriteLine(PhoneSignUpTextBox.Text);
				write.WriteLine(AddressSignUpTextBox.Text);
				write.WriteLine(CardInfoSignUpTextBox.Text);
				write.WriteLine("////////////////////////////////////");
				write.Close();

				StatusLabel.Text = "Confirmed";
				StatusLabel.Visible = true;

                UserSignUpTextBox.Text = "";
                PassSignUpTextBox.Text = "";
                NameSignUpTextBox.Text = "";
                PhoneSignUpTextBox.Text = "";
                AddressSignUpTextBox.Text = "";
                CardInfoSignUpTextBox.Text = "";
            }

            else
			{
				StatusLabel.Visible = true;
			}


		}

		private void ProfileInfo_Click(object sender, EventArgs e)
		{

			string[] info = Directory.GetFiles(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "BlackJackGame"));

			string reader = "";

			if (ActiveLogin.Text != "Guest"){
				LoginButton.Visible = false;
				SignUpButton.Visible = false;
				Soundoo.Visible = false;
				LogLabel.Visible = false;
				ActiveLogin.Visible = false;
				FundsButton.Visible = false;
				ProfileInfo.Visible = false;

				MenuButton.Visible = true;
				ChangeButton.Visible = true;

				foreach (string fileName in info)
				{
					if (fileName.Contains(UserTextBox.Text) == true)
					{
						reader = fileName;
					}
				}

				StreamReader read = new StreamReader(reader);

				for(int i = 0; i < 7; i++)
				{
					string[] fileInfo = new string[7];
					fileInfo[i] = read.ReadLine();
					if (i == 1)
						ProfileInfoUser.Text = fileInfo[i];
					if (i == 3)
						ProfileInfoName.Text = fileInfo[i];
					if (i == 4)
						ProfileInfoPhone.Text = fileInfo[i];
					if (i == 5)
						ProfileInfoAddress.Text = fileInfo[i];

				}

				InfoUserLabel.Visible = true;
				ProfileInfoUser.Visible = true;
				NameInfoLabel.Visible = true;
				ProfileInfoName.Visible = true;
				PhoneInfoLabel.Visible = true;
				ProfileInfoPhone.Visible = true;
				AddressInfoLabel.Visible = true;
				ProfileInfoAddress.Visible = true;
			}

		}

		private void ChangeButton_Click(object sender, EventArgs e)
		{
			SignUpButton_Click(sender, e);
		}
	}
}
