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
			this.Boarder = new System.Windows.Forms.Label();
			this.LogLabel = new System.Windows.Forms.Label();
			this.ActiveLogin = new System.Windows.Forms.Label();
			this.LoginButton = new System.Windows.Forms.Button();
			this.SignUpButton = new System.Windows.Forms.Button();
			this.Soundoo = new System.Windows.Forms.Button();
			this.FundsButton = new System.Windows.Forms.Button();
			this.LoginConfirm = new System.Windows.Forms.Button();
			this.ForgotButton = new System.Windows.Forms.Button();
			this.UPLabel = new System.Windows.Forms.Label();
			this.UPTextBox = new System.Windows.Forms.TextBox();
			this.MenuButton = new System.Windows.Forms.Button();
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
			// Boarder
			// 
			this.Boarder.BackColor = System.Drawing.Color.Transparent;
			this.Boarder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Boarder.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Boarder.ForeColor = System.Drawing.Color.White;
			this.Boarder.Location = new System.Drawing.Point(0, 0);
			this.Boarder.Name = "Boarder";
			this.Boarder.Size = new System.Drawing.Size(300, 375);
			this.Boarder.TabIndex = 8;
			this.Boarder.Visible = false;
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
			// LoginConfirm
			// 
			this.LoginConfirm.BackColor = System.Drawing.Color.Black;
			this.LoginConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.LoginConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LoginConfirm.ForeColor = System.Drawing.Color.White;
			this.LoginConfirm.Location = new System.Drawing.Point(160, 192);
			this.LoginConfirm.Name = "LoginConfirm";
			this.LoginConfirm.Size = new System.Drawing.Size(117, 42);
			this.LoginConfirm.TabIndex = 36;
			this.LoginConfirm.Text = "Next";
			this.LoginConfirm.UseVisualStyleBackColor = false;
			this.LoginConfirm.Visible = false;
			this.LoginConfirm.Click += new System.EventHandler(this.LoginConfirm_Click);
			// 
			// ForgotButton
			// 
			this.ForgotButton.BackColor = System.Drawing.Color.Black;
			this.ForgotButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ForgotButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForgotButton.ForeColor = System.Drawing.Color.White;
			this.ForgotButton.Location = new System.Drawing.Point(23, 192);
			this.ForgotButton.Name = "ForgotButton";
			this.ForgotButton.Size = new System.Drawing.Size(117, 42);
			this.ForgotButton.TabIndex = 35;
			this.ForgotButton.Text = "Forgot";
			this.ForgotButton.UseVisualStyleBackColor = false;
			this.ForgotButton.Visible = false;
			// 
			// UPLabel
			// 
			this.UPLabel.AutoSize = true;
			this.UPLabel.BackColor = System.Drawing.Color.Black;
			this.UPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UPLabel.ForeColor = System.Drawing.Color.White;
			this.UPLabel.Location = new System.Drawing.Point(36, 112);
			this.UPLabel.Name = "UPLabel";
			this.UPLabel.Size = new System.Drawing.Size(45, 20);
			this.UPLabel.TabIndex = 34;
			this.UPLabel.Text = "User";
			this.UPLabel.Visible = false;
			// 
			// UPTextBox
			// 
			this.UPTextBox.Location = new System.Drawing.Point(87, 112);
			this.UPTextBox.Name = "UPTextBox";
			this.UPTextBox.Size = new System.Drawing.Size(160, 20);
			this.UPTextBox.TabIndex = 33;
			this.UPTextBox.Visible = false;
			// 
			// MenuButton
			// 
			this.MenuButton.BackColor = System.Drawing.Color.Black;
			this.MenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.MenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MenuButton.ForeColor = System.Drawing.Color.White;
			this.MenuButton.Location = new System.Drawing.Point(102, 303);
			this.MenuButton.Name = "MenuButton";
			this.MenuButton.Size = new System.Drawing.Size(82, 30);
			this.MenuButton.TabIndex = 32;
			this.MenuButton.Text = "Menu";
			this.MenuButton.UseVisualStyleBackColor = false;
			this.MenuButton.Visible = false;
			// 
			// ProfileInterface
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.InfoText;
			this.ClientSize = new System.Drawing.Size(300, 375);
			this.Controls.Add(this.LoginConfirm);
			this.Controls.Add(this.ForgotButton);
			this.Controls.Add(this.UPLabel);
			this.Controls.Add(this.UPTextBox);
			this.Controls.Add(this.MenuButton);
			this.Controls.Add(this.Boarder);
			this.Controls.Add(this.FundsButton);
			this.Controls.Add(this.Soundoo);
			this.Controls.Add(this.SignUpButton);
			this.Controls.Add(this.LoginButton);
			this.Controls.Add(this.ActiveLogin);
			this.Controls.Add(this.LogLabel);
			this.Controls.Add(this.Close);
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
		private System.Windows.Forms.Button LoginConfirm;
		private System.Windows.Forms.Button ForgotButton;
		private System.Windows.Forms.Label UPLabel;
		private System.Windows.Forms.TextBox UPTextBox;
		private System.Windows.Forms.Button MenuButton;
		public System.Windows.Forms.Label Boarder;
	}
}