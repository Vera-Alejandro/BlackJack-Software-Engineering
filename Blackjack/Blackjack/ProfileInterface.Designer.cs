namespace Blackjack
{
	partial class ProfileInterface
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
			this.Close = new System.Windows.Forms.Button();
			this.LogLabel = new System.Windows.Forms.Label();
			this.ActiveLogin = new System.Windows.Forms.Label();
			this.LoginButton = new System.Windows.Forms.Button();
			this.SignUpButton = new System.Windows.Forms.Button();
			this.Soundoo = new System.Windows.Forms.Button();
			this.FundsButton = new System.Windows.Forms.Button();
			this.PassSignUpLabel = new System.Windows.Forms.Label();
			this.PassSignUpTextBox = new System.Windows.Forms.TextBox();
			this.UserSignUpLabel = new System.Windows.Forms.Label();
			this.UserSignUpTextBox = new System.Windows.Forms.TextBox();
			this.PhoneSignUpLabel = new System.Windows.Forms.Label();
			this.PhoneSignUpTextBox = new System.Windows.Forms.TextBox();
			this.CardInfoSignUpLabel = new System.Windows.Forms.Label();
			this.CardInfoSignUpTextBox = new System.Windows.Forms.TextBox();
			this.NameSignUpTextBox = new System.Windows.Forms.TextBox();
			this.NameSignUpLabel = new System.Windows.Forms.Label();
			this.AddressSignUpLabel = new System.Windows.Forms.Label();
			this.AddressSignUpTextBox = new System.Windows.Forms.TextBox();
			this.SignUpConfirmButton = new System.Windows.Forms.Button();
			this.StatusLabel = new System.Windows.Forms.Label();
			this.MenuButton = new System.Windows.Forms.Button();
			this.UserTextBox = new System.Windows.Forms.TextBox();
			this.UserLabel = new System.Windows.Forms.Label();
			this.PassTextBox = new System.Windows.Forms.TextBox();
			this.PassLabel = new System.Windows.Forms.Label();
			this.LoginConfirm = new System.Windows.Forms.Button();
			this.Boarder = new System.Windows.Forms.Label();
			this.LogStatusLabel = new System.Windows.Forms.Label();
			this.ProfileInfo = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Close
			// 
			this.Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Close.BackColor = System.Drawing.SystemColors.InfoText;
			this.Close.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.Close.FlatAppearance.BorderSize = 0;
			this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Close.ForeColor = System.Drawing.Color.DodgerBlue;
			this.Close.Location = new System.Drawing.Point(266, 9);
			this.Close.Margin = new System.Windows.Forms.Padding(0);
			this.Close.Name = "Close";
			this.Close.Size = new System.Drawing.Size(25, 34);
			this.Close.TabIndex = 4;
			this.Close.Text = "X";
			this.Close.UseVisualStyleBackColor = false;
			this.Close.Click += new System.EventHandler(this.Close_Click);
			// 
			// LogLabel
			// 
			this.LogLabel.BackColor = System.Drawing.Color.Black;
			this.LogLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.LogLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LogLabel.ForeColor = System.Drawing.Color.White;
			this.LogLabel.Location = new System.Drawing.Point(12, 48);
			this.LogLabel.Name = "LogLabel";
			this.LogLabel.Size = new System.Drawing.Size(186, 24);
			this.LogLabel.TabIndex = 10;
			this.LogLabel.Text = "Currently Logged in as:";
			this.LogLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// ActiveLogin
			// 
			this.ActiveLogin.AutoSize = true;
			this.ActiveLogin.BackColor = System.Drawing.Color.Black;
			this.ActiveLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ActiveLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ActiveLogin.ForeColor = System.Drawing.Color.White;
			this.ActiveLogin.Location = new System.Drawing.Point(204, 49);
			this.ActiveLogin.Name = "ActiveLogin";
			this.ActiveLogin.Size = new System.Drawing.Size(56, 22);
			this.ActiveLogin.TabIndex = 11;
			this.ActiveLogin.Text = "Guest";
			// 
			// LoginButton
			// 
			this.LoginButton.BackColor = System.Drawing.Color.Black;
			this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LoginButton.ForeColor = System.Drawing.Color.White;
			this.LoginButton.Location = new System.Drawing.Point(24, 157);
			this.LoginButton.Name = "LoginButton";
			this.LoginButton.Size = new System.Drawing.Size(117, 42);
			this.LoginButton.TabIndex = 12;
			this.LoginButton.Text = "Log in";
			this.LoginButton.UseVisualStyleBackColor = false;
			this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
			// 
			// SignUpButton
			// 
			this.SignUpButton.BackColor = System.Drawing.Color.Black;
			this.SignUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SignUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SignUpButton.ForeColor = System.Drawing.Color.White;
			this.SignUpButton.Location = new System.Drawing.Point(161, 157);
			this.SignUpButton.Name = "SignUpButton";
			this.SignUpButton.Size = new System.Drawing.Size(117, 42);
			this.SignUpButton.TabIndex = 13;
			this.SignUpButton.Text = "Sign up";
			this.SignUpButton.UseVisualStyleBackColor = false;
			this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
			// 
			// Soundoo
			// 
			this.Soundoo.BackColor = System.Drawing.Color.Black;
			this.Soundoo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Soundoo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Soundoo.ForeColor = System.Drawing.Color.White;
			this.Soundoo.Location = new System.Drawing.Point(24, 309);
			this.Soundoo.Name = "Soundoo";
			this.Soundoo.Size = new System.Drawing.Size(117, 42);
			this.Soundoo.TabIndex = 15;
			this.Soundoo.Text = "Sound On";
			this.Soundoo.UseVisualStyleBackColor = false;
			this.Soundoo.Click += new System.EventHandler(this.Soundoo_Click);
			// 
			// FundsButton
			// 
			this.FundsButton.BackColor = System.Drawing.Color.Black;
			this.FundsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.FundsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FundsButton.ForeColor = System.Drawing.Color.White;
			this.FundsButton.Location = new System.Drawing.Point(24, 248);
			this.FundsButton.Name = "FundsButton";
			this.FundsButton.Size = new System.Drawing.Size(117, 42);
			this.FundsButton.TabIndex = 16;
			this.FundsButton.Text = "Funds";
			this.FundsButton.UseVisualStyleBackColor = false;
			// 
			// PassSignUpLabel
			// 
			this.PassSignUpLabel.AutoSize = true;
			this.PassSignUpLabel.BackColor = System.Drawing.Color.Black;
			this.PassSignUpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PassSignUpLabel.ForeColor = System.Drawing.Color.White;
			this.PassSignUpLabel.Location = new System.Drawing.Point(43, 74);
			this.PassSignUpLabel.Name = "PassSignUpLabel";
			this.PassSignUpLabel.Size = new System.Drawing.Size(47, 20);
			this.PassSignUpLabel.TabIndex = 57;
			this.PassSignUpLabel.Text = "Pass";
			this.PassSignUpLabel.Visible = false;
			// 
			// PassSignUpTextBox
			// 
			this.PassSignUpTextBox.Location = new System.Drawing.Point(96, 73);
			this.PassSignUpTextBox.Name = "PassSignUpTextBox";
			this.PassSignUpTextBox.Size = new System.Drawing.Size(160, 20);
			this.PassSignUpTextBox.TabIndex = 40;
			this.PassSignUpTextBox.Visible = false;
			// 
			// UserSignUpLabel
			// 
			this.UserSignUpLabel.AutoSize = true;
			this.UserSignUpLabel.BackColor = System.Drawing.Color.Black;
			this.UserSignUpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UserSignUpLabel.ForeColor = System.Drawing.Color.White;
			this.UserSignUpLabel.Location = new System.Drawing.Point(45, 27);
			this.UserSignUpLabel.Name = "UserSignUpLabel";
			this.UserSignUpLabel.Size = new System.Drawing.Size(45, 20);
			this.UserSignUpLabel.TabIndex = 58;
			this.UserSignUpLabel.Text = "User";
			this.UserSignUpLabel.Visible = false;
			// 
			// UserSignUpTextBox
			// 
			this.UserSignUpTextBox.Location = new System.Drawing.Point(96, 27);
			this.UserSignUpTextBox.Name = "UserSignUpTextBox";
			this.UserSignUpTextBox.Size = new System.Drawing.Size(160, 20);
			this.UserSignUpTextBox.TabIndex = 39;
			this.UserSignUpTextBox.Visible = false;
			// 
			// PhoneSignUpLabel
			// 
			this.PhoneSignUpLabel.AutoSize = true;
			this.PhoneSignUpLabel.BackColor = System.Drawing.Color.Black;
			this.PhoneSignUpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PhoneSignUpLabel.ForeColor = System.Drawing.Color.White;
			this.PhoneSignUpLabel.Location = new System.Drawing.Point(34, 169);
			this.PhoneSignUpLabel.Name = "PhoneSignUpLabel";
			this.PhoneSignUpLabel.Size = new System.Drawing.Size(56, 20);
			this.PhoneSignUpLabel.TabIndex = 55;
			this.PhoneSignUpLabel.Text = "Phone";
			this.PhoneSignUpLabel.Visible = false;
			// 
			// PhoneSignUpTextBox
			// 
			this.PhoneSignUpTextBox.Location = new System.Drawing.Point(96, 169);
			this.PhoneSignUpTextBox.Name = "PhoneSignUpTextBox";
			this.PhoneSignUpTextBox.Size = new System.Drawing.Size(160, 20);
			this.PhoneSignUpTextBox.TabIndex = 43;
			this.PhoneSignUpTextBox.Visible = false;
			// 
			// CardInfoSignUpLabel
			// 
			this.CardInfoSignUpLabel.AutoSize = true;
			this.CardInfoSignUpLabel.BackColor = System.Drawing.Color.Black;
			this.CardInfoSignUpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CardInfoSignUpLabel.ForeColor = System.Drawing.Color.White;
			this.CardInfoSignUpLabel.Location = new System.Drawing.Point(45, 260);
			this.CardInfoSignUpLabel.Name = "CardInfoSignUpLabel";
			this.CardInfoSignUpLabel.Size = new System.Drawing.Size(45, 20);
			this.CardInfoSignUpLabel.TabIndex = 54;
			this.CardInfoSignUpLabel.Text = "Card";
			this.CardInfoSignUpLabel.Visible = false;
			// 
			// CardInfoSignUpTextBox
			// 
			this.CardInfoSignUpTextBox.Location = new System.Drawing.Point(96, 260);
			this.CardInfoSignUpTextBox.Name = "CardInfoSignUpTextBox";
			this.CardInfoSignUpTextBox.Size = new System.Drawing.Size(160, 20);
			this.CardInfoSignUpTextBox.TabIndex = 45;
			this.CardInfoSignUpTextBox.Visible = false;
			// 
			// NameSignUpTextBox
			// 
			this.NameSignUpTextBox.Location = new System.Drawing.Point(96, 121);
			this.NameSignUpTextBox.Name = "NameSignUpTextBox";
			this.NameSignUpTextBox.Size = new System.Drawing.Size(160, 20);
			this.NameSignUpTextBox.TabIndex = 42;
			this.NameSignUpTextBox.Visible = false;
			// 
			// NameSignUpLabel
			// 
			this.NameSignUpLabel.AutoSize = true;
			this.NameSignUpLabel.BackColor = System.Drawing.Color.Black;
			this.NameSignUpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NameSignUpLabel.ForeColor = System.Drawing.Color.White;
			this.NameSignUpLabel.Location = new System.Drawing.Point(37, 121);
			this.NameSignUpLabel.Name = "NameSignUpLabel";
			this.NameSignUpLabel.Size = new System.Drawing.Size(53, 20);
			this.NameSignUpLabel.TabIndex = 56;
			this.NameSignUpLabel.Text = "Name";
			this.NameSignUpLabel.Visible = false;
			// 
			// AddressSignUpLabel
			// 
			this.AddressSignUpLabel.AutoSize = true;
			this.AddressSignUpLabel.BackColor = System.Drawing.Color.Black;
			this.AddressSignUpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AddressSignUpLabel.ForeColor = System.Drawing.Color.White;
			this.AddressSignUpLabel.Location = new System.Drawing.Point(19, 212);
			this.AddressSignUpLabel.Name = "AddressSignUpLabel";
			this.AddressSignUpLabel.Size = new System.Drawing.Size(71, 20);
			this.AddressSignUpLabel.TabIndex = 53;
			this.AddressSignUpLabel.Text = "Address";
			this.AddressSignUpLabel.Visible = false;
			// 
			// AddressSignUpTextBox
			// 
			this.AddressSignUpTextBox.Location = new System.Drawing.Point(96, 212);
			this.AddressSignUpTextBox.Name = "AddressSignUpTextBox";
			this.AddressSignUpTextBox.Size = new System.Drawing.Size(160, 20);
			this.AddressSignUpTextBox.TabIndex = 44;
			this.AddressSignUpTextBox.Visible = false;
			// 
			// SignUpConfirmButton
			// 
			this.SignUpConfirmButton.BackColor = System.Drawing.Color.Black;
			this.SignUpConfirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SignUpConfirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SignUpConfirmButton.ForeColor = System.Drawing.Color.White;
			this.SignUpConfirmButton.Location = new System.Drawing.Point(161, 316);
			this.SignUpConfirmButton.Name = "SignUpConfirmButton";
			this.SignUpConfirmButton.Size = new System.Drawing.Size(117, 42);
			this.SignUpConfirmButton.TabIndex = 52;
			this.SignUpConfirmButton.Text = "Sign up";
			this.SignUpConfirmButton.UseVisualStyleBackColor = false;
			this.SignUpConfirmButton.Visible = false;
			this.SignUpConfirmButton.Click += new System.EventHandler(this.SignUpConfirmButton_Click);
			// 
			// StatusLabel
			// 
			this.StatusLabel.AutoSize = true;
			this.StatusLabel.BackColor = System.Drawing.Color.Black;
			this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.StatusLabel.ForeColor = System.Drawing.Color.White;
			this.StatusLabel.Location = new System.Drawing.Point(131, 293);
			this.StatusLabel.Name = "StatusLabel";
			this.StatusLabel.Size = new System.Drawing.Size(38, 13);
			this.StatusLabel.TabIndex = 59;
			this.StatusLabel.Text = "Invalid";
			this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.StatusLabel.Visible = false;
			// 
			// MenuButton
			// 
			this.MenuButton.BackColor = System.Drawing.Color.Black;
			this.MenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.MenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MenuButton.ForeColor = System.Drawing.Color.White;
			this.MenuButton.Location = new System.Drawing.Point(49, 325);
			this.MenuButton.Name = "MenuButton";
			this.MenuButton.Size = new System.Drawing.Size(82, 30);
			this.MenuButton.TabIndex = 32;
			this.MenuButton.Text = "Menu";
			this.MenuButton.UseVisualStyleBackColor = false;
			this.MenuButton.Visible = false;
			this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
			// 
			// UserTextBox
			// 
			this.UserTextBox.Location = new System.Drawing.Point(87, 74);
			this.UserTextBox.Name = "UserTextBox";
			this.UserTextBox.Size = new System.Drawing.Size(160, 20);
			this.UserTextBox.TabIndex = 33;
			this.UserTextBox.Visible = false;
			// 
			// UserLabel
			// 
			this.UserLabel.AutoSize = true;
			this.UserLabel.BackColor = System.Drawing.Color.Black;
			this.UserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UserLabel.ForeColor = System.Drawing.Color.White;
			this.UserLabel.Location = new System.Drawing.Point(36, 74);
			this.UserLabel.Name = "UserLabel";
			this.UserLabel.Size = new System.Drawing.Size(45, 20);
			this.UserLabel.TabIndex = 34;
			this.UserLabel.Text = "User";
			this.UserLabel.Visible = false;
			// 
			// PassTextBox
			// 
			this.PassTextBox.Location = new System.Drawing.Point(87, 119);
			this.PassTextBox.Name = "PassTextBox";
			this.PassTextBox.Size = new System.Drawing.Size(160, 20);
			this.PassTextBox.TabIndex = 37;
			this.PassTextBox.Visible = false;
			// 
			// PassLabel
			// 
			this.PassLabel.AutoSize = true;
			this.PassLabel.BackColor = System.Drawing.Color.Black;
			this.PassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PassLabel.ForeColor = System.Drawing.Color.White;
			this.PassLabel.Location = new System.Drawing.Point(36, 119);
			this.PassLabel.Name = "PassLabel";
			this.PassLabel.Size = new System.Drawing.Size(47, 20);
			this.PassLabel.TabIndex = 38;
			this.PassLabel.Text = "Pass";
			this.PassLabel.Visible = false;
			// 
			// LoginConfirm
			// 
			this.LoginConfirm.BackColor = System.Drawing.Color.Black;
			this.LoginConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.LoginConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LoginConfirm.ForeColor = System.Drawing.Color.White;
			this.LoginConfirm.Location = new System.Drawing.Point(161, 316);
			this.LoginConfirm.Name = "LoginConfirm";
			this.LoginConfirm.Size = new System.Drawing.Size(117, 42);
			this.LoginConfirm.TabIndex = 36;
			this.LoginConfirm.Text = "Log in";
			this.LoginConfirm.UseVisualStyleBackColor = false;
			this.LoginConfirm.Visible = false;
			this.LoginConfirm.Click += new System.EventHandler(this.LoginConfirm_Click);
			// 
			// Boarder
			// 
			this.Boarder.BackColor = System.Drawing.Color.Transparent;
			this.Boarder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Boarder.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Boarder.ForeColor = System.Drawing.Color.White;
			this.Boarder.Location = new System.Drawing.Point(1, -1);
			this.Boarder.Name = "Boarder";
			this.Boarder.Size = new System.Drawing.Size(300, 377);
			this.Boarder.TabIndex = 8;
			this.Boarder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Boarder.Visible = false;
			// 
			// LogStatusLabel
			// 
			this.LogStatusLabel.AutoSize = true;
			this.LogStatusLabel.BackColor = System.Drawing.Color.Black;
			this.LogStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LogStatusLabel.ForeColor = System.Drawing.Color.White;
			this.LogStatusLabel.Location = new System.Drawing.Point(131, 157);
			this.LogStatusLabel.Name = "LogStatusLabel";
			this.LogStatusLabel.Size = new System.Drawing.Size(38, 13);
			this.LogStatusLabel.TabIndex = 60;
			this.LogStatusLabel.Text = "Invalid";
			this.LogStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.LogStatusLabel.Visible = false;
			// 
			// ProfileInfo
			// 
			this.ProfileInfo.BackColor = System.Drawing.Color.Black;
			this.ProfileInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ProfileInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ProfileInfo.ForeColor = System.Drawing.Color.White;
			this.ProfileInfo.Location = new System.Drawing.Point(161, 248);
			this.ProfileInfo.Name = "ProfileInfo";
			this.ProfileInfo.Size = new System.Drawing.Size(117, 42);
			this.ProfileInfo.TabIndex = 61;
			this.ProfileInfo.Text = "Info";
			this.ProfileInfo.UseVisualStyleBackColor = false;
			this.ProfileInfo.Click += new System.EventHandler(this.ProfileInfo_Click);
			// 
			// ProfileInterface
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.InfoText;
			this.ClientSize = new System.Drawing.Size(300, 375);
			this.Controls.Add(this.ProfileInfo);
			this.Controls.Add(this.FundsButton);
			this.Controls.Add(this.Soundoo);
			this.Controls.Add(this.SignUpButton);
			this.Controls.Add(this.LoginButton);
			this.Controls.Add(this.ActiveLogin);
			this.Controls.Add(this.LogLabel);
			this.Controls.Add(this.Close);
			this.Controls.Add(this.Boarder);
			this.Controls.Add(this.PassSignUpLabel);
			this.Controls.Add(this.UserLabel);
			this.Controls.Add(this.PassSignUpTextBox);
			this.Controls.Add(this.UserTextBox);
			this.Controls.Add(this.UserSignUpTextBox);
			this.Controls.Add(this.UserSignUpLabel);
			this.Controls.Add(this.NameSignUpLabel);
			this.Controls.Add(this.NameSignUpTextBox);
			this.Controls.Add(this.PassLabel);
			this.Controls.Add(this.PassTextBox);
			this.Controls.Add(this.PhoneSignUpLabel);
			this.Controls.Add(this.PhoneSignUpTextBox);
			this.Controls.Add(this.LogStatusLabel);
			this.Controls.Add(this.StatusLabel);
			this.Controls.Add(this.AddressSignUpLabel);
			this.Controls.Add(this.AddressSignUpTextBox);
			this.Controls.Add(this.CardInfoSignUpLabel);
			this.Controls.Add(this.CardInfoSignUpTextBox);
			this.Controls.Add(this.SignUpConfirmButton);
			this.Controls.Add(this.LoginConfirm);
			this.Controls.Add(this.MenuButton);
			this.ForeColor = System.Drawing.Color.White;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ProfileInterface";
			this.Load += new System.EventHandler(this.ProfileInterface_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button Close;
		private System.Windows.Forms.Label LogLabel;
		private System.Windows.Forms.Label ActiveLogin;
		private System.Windows.Forms.Button LoginButton;
		private System.Windows.Forms.Button SignUpButton;
		private System.Windows.Forms.Button Soundoo;
		private System.Windows.Forms.Button FundsButton;
		private System.Windows.Forms.Label PassSignUpLabel;
		private System.Windows.Forms.TextBox PassSignUpTextBox;
		private System.Windows.Forms.Label UserSignUpLabel;
		private System.Windows.Forms.TextBox UserSignUpTextBox;
		private System.Windows.Forms.Label PhoneSignUpLabel;
		private System.Windows.Forms.TextBox PhoneSignUpTextBox;
		private System.Windows.Forms.Label CardInfoSignUpLabel;
		private System.Windows.Forms.TextBox CardInfoSignUpTextBox;
		private System.Windows.Forms.TextBox NameSignUpTextBox;
		private System.Windows.Forms.Label NameSignUpLabel;
		private System.Windows.Forms.Label AddressSignUpLabel;
		private System.Windows.Forms.TextBox AddressSignUpTextBox;
		private System.Windows.Forms.Button SignUpConfirmButton;
		private System.Windows.Forms.Label StatusLabel;
		private System.Windows.Forms.Button MenuButton;
		private System.Windows.Forms.TextBox UserTextBox;
		private System.Windows.Forms.Label UserLabel;
		private System.Windows.Forms.TextBox PassTextBox;
		private System.Windows.Forms.Label PassLabel;
		private System.Windows.Forms.Button LoginConfirm;
		public System.Windows.Forms.Label Boarder;
		private System.Windows.Forms.Label LogStatusLabel;
		private System.Windows.Forms.Button ProfileInfo;
	}
}