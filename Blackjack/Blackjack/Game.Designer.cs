﻿namespace BlackjackGame
{
    partial class Blackjack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Blackjack));
            this.Close = new System.Windows.Forms.Button();
            this.Resize = new System.Windows.Forms.Button();
            this.Minimize = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.DealerHand = new System.Windows.Forms.Panel();
            this.DealerCount = new System.Windows.Forms.Label();
            this.DCName = new System.Windows.Forms.Label();
            this.PlayerHand = new System.Windows.Forms.Panel();
            this.SplitCount = new System.Windows.Forms.Label();
            this.SCName = new System.Windows.Forms.Label();
            this.SplitButton = new System.Windows.Forms.Button();
            this.InsuranceButton = new System.Windows.Forms.Button();
            this.PlayerCash = new System.Windows.Forms.Label();
            this.Cash = new System.Windows.Forms.Label();
            this.Stay = new System.Windows.Forms.Button();
            this.Hit = new System.Windows.Forms.Button();
            this.PlayerCount = new System.Windows.Forms.Label();
            this.PCName = new System.Windows.Forms.Label();
            this.TwoPlayerButton = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.TextBox();
            this.BetLabel = new System.Windows.Forms.Label();
            this.BetOne = new System.Windows.Forms.Button();
            this.BetFive = new System.Windows.Forms.Button();
            this.BetTen = new System.Windows.Forms.Button();
            this.BetTwentyFive = new System.Windows.Forms.Button();
            this.BetFifty = new System.Windows.Forms.Button();
            this.BetHundred = new System.Windows.Forms.Button();
            this.BetTwoFifty = new System.Windows.Forms.Button();
            this.BetFiveHundred = new System.Windows.Forms.Button();
            this.BetThousand = new System.Windows.Forms.Button();
            this.BetAll = new System.Windows.Forms.Button();
            this.BettingPanel = new System.Windows.Forms.Panel();
            this.TitleImage = new System.Windows.Forms.PictureBox();
            this.ProfileButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.OnePlayerButton = new System.Windows.Forms.Button();
            this.ThreePlayerButton = new System.Windows.Forms.Button();
            this.DealerHand.SuspendLayout();
            this.PlayerHand.SuspendLayout();
            this.BettingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TitleImage)).BeginInit();
            this.SuspendLayout();
            // 
            // Close
            // 
            this.Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Close.BackColor = System.Drawing.SystemColors.Desktop;
            this.Close.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Close.Location = new System.Drawing.Point(1472, 0);
            this.Close.Margin = new System.Windows.Forms.Padding(0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(33, 42);
            this.Close.TabIndex = 0;
            this.Close.Text = "X";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Resize
            // 
            this.Resize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Resize.BackColor = System.Drawing.SystemColors.Desktop;
            this.Resize.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Resize.FlatAppearance.BorderSize = 0;
            this.Resize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Resize.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resize.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Resize.Location = new System.Drawing.Point(1432, 0);
            this.Resize.Margin = new System.Windows.Forms.Padding(0);
            this.Resize.Name = "Resize";
            this.Resize.Size = new System.Drawing.Size(33, 42);
            this.Resize.TabIndex = 2;
            this.Resize.Text = "❐";
            this.Resize.UseVisualStyleBackColor = false;
            this.Resize.Click += new System.EventHandler(this.Resize_Click);
            // 
            // Minimize
            // 
            this.Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimize.BackColor = System.Drawing.SystemColors.Desktop;
            this.Minimize.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Minimize.FlatAppearance.BorderSize = 0;
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimize.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Minimize.Location = new System.Drawing.Point(1392, 0);
            this.Minimize.Margin = new System.Windows.Forms.Padding(0);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(33, 42);
            this.Minimize.TabIndex = 3;
            this.Minimize.Text = "—";
            this.Minimize.UseVisualStyleBackColor = false;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // StartButton
            // 
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.StartButton.Location = new System.Drawing.Point(39, 33);
            this.StartButton.Margin = new System.Windows.Forms.Padding(4);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(96, 54);
            this.StartButton.TabIndex = 4;
            this.StartButton.Text = "Play!";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Visible = false;
            // 
            // DealerHand
            // 
            this.DealerHand.Controls.Add(this.DealerCount);
            this.DealerHand.Controls.Add(this.DCName);
            this.DealerHand.Location = new System.Drawing.Point(131, 151);
            this.DealerHand.Margin = new System.Windows.Forms.Padding(4);
            this.DealerHand.Name = "DealerHand";
            this.DealerHand.Size = new System.Drawing.Size(600, 504);
            this.DealerHand.TabIndex = 5;
            this.DealerHand.Visible = false;
            // 
            // DealerCount
            // 
            this.DealerCount.AutoSize = true;
            this.DealerCount.BackColor = System.Drawing.Color.Black;
            this.DealerCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DealerCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DealerCount.ForeColor = System.Drawing.Color.White;
            this.DealerCount.Location = new System.Drawing.Point(229, 0);
            this.DealerCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DealerCount.Name = "DealerCount";
            this.DealerCount.Size = new System.Drawing.Size(34, 38);
            this.DealerCount.TabIndex = 1;
            this.DealerCount.Text = "0";
            // 
            // DCName
            // 
            this.DCName.AutoSize = true;
            this.DCName.BackColor = System.Drawing.Color.Black;
            this.DCName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DCName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DCName.ForeColor = System.Drawing.Color.White;
            this.DCName.Location = new System.Drawing.Point(0, 0);
            this.DCName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DCName.Name = "DCName";
            this.DCName.Size = new System.Drawing.Size(207, 38);
            this.DCName.TabIndex = 0;
            this.DCName.Text = "Dealer Count: ";
            // 
            // PlayerHand
            // 
            this.PlayerHand.Controls.Add(this.SplitCount);
            this.PlayerHand.Controls.Add(this.SCName);
            this.PlayerHand.Controls.Add(this.SplitButton);
            this.PlayerHand.Controls.Add(this.InsuranceButton);
            this.PlayerHand.Controls.Add(this.PlayerCash);
            this.PlayerHand.Controls.Add(this.Cash);
            this.PlayerHand.Controls.Add(this.Stay);
            this.PlayerHand.Controls.Add(this.Hit);
            this.PlayerHand.Controls.Add(this.PlayerCount);
            this.PlayerHand.Controls.Add(this.PCName);
            this.PlayerHand.Location = new System.Drawing.Point(815, 151);
            this.PlayerHand.Margin = new System.Windows.Forms.Padding(4);
            this.PlayerHand.Name = "PlayerHand";
            this.PlayerHand.Size = new System.Drawing.Size(698, 586);
            this.PlayerHand.TabIndex = 6;
            this.PlayerHand.Visible = false;
            // 
            // SplitCount
            // 
            this.SplitCount.AutoSize = true;
            this.SplitCount.BackColor = System.Drawing.Color.Black;
            this.SplitCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SplitCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SplitCount.ForeColor = System.Drawing.Color.White;
            this.SplitCount.Location = new System.Drawing.Point(208, 38);
            this.SplitCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SplitCount.Name = "SplitCount";
            this.SplitCount.Size = new System.Drawing.Size(34, 38);
            this.SplitCount.TabIndex = 9;
            this.SplitCount.Text = "0";
            // 
            // SCName
            // 
            this.SCName.AutoSize = true;
            this.SCName.BackColor = System.Drawing.Color.Black;
            this.SCName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SCName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SCName.ForeColor = System.Drawing.Color.White;
            this.SCName.Location = new System.Drawing.Point(0, 38);
            this.SCName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SCName.Name = "SCName";
            this.SCName.Size = new System.Drawing.Size(201, 38);
            this.SCName.TabIndex = 8;
            this.SCName.Text = "Hand 2 Count";
            // 
            // SplitButton
            // 
            this.SplitButton.BackColor = System.Drawing.Color.Black;
            this.SplitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SplitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SplitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SplitButton.ForeColor = System.Drawing.Color.White;
            this.SplitButton.Location = new System.Drawing.Point(371, 428);
            this.SplitButton.Margin = new System.Windows.Forms.Padding(4);
            this.SplitButton.Name = "SplitButton";
            this.SplitButton.Size = new System.Drawing.Size(239, 62);
            this.SplitButton.TabIndex = 7;
            this.SplitButton.Text = "SPLIT";
            this.SplitButton.UseVisualStyleBackColor = false;
            this.SplitButton.Click += new System.EventHandler(this.SplitButton_Click);
            // 
            // InsuranceButton
            // 
            this.InsuranceButton.BackColor = System.Drawing.Color.Black;
            this.InsuranceButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.InsuranceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsuranceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsuranceButton.ForeColor = System.Drawing.Color.White;
            this.InsuranceButton.Location = new System.Drawing.Point(371, 507);
            this.InsuranceButton.Margin = new System.Windows.Forms.Padding(4);
            this.InsuranceButton.Name = "InsuranceButton";
            this.InsuranceButton.Size = new System.Drawing.Size(239, 62);
            this.InsuranceButton.TabIndex = 6;
            this.InsuranceButton.Text = "INSURANCE";
            this.InsuranceButton.UseVisualStyleBackColor = false;
            this.InsuranceButton.Click += new System.EventHandler(this.InsuranceButton_Click);
            // 
            // PlayerCash
            // 
            this.PlayerCash.AutoSize = true;
            this.PlayerCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayerCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerCash.ForeColor = System.Drawing.Color.White;
            this.PlayerCash.Location = new System.Drawing.Point(454, 2);
            this.PlayerCash.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PlayerCash.Name = "PlayerCash";
            this.PlayerCash.Size = new System.Drawing.Size(125, 36);
            this.PlayerCash.TabIndex = 5;
            this.PlayerCash.Text = "$500.00";
            this.PlayerCash.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Cash
            // 
            this.Cash.AutoSize = true;
            this.Cash.BackColor = System.Drawing.Color.Black;
            this.Cash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cash.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cash.ForeColor = System.Drawing.Color.White;
            this.Cash.Location = new System.Drawing.Point(347, 2);
            this.Cash.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Cash.Name = "Cash";
            this.Cash.Size = new System.Drawing.Size(92, 36);
            this.Cash.TabIndex = 4;
            this.Cash.Text = "Cash:";
            this.Cash.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Stay
            // 
            this.Stay.BackColor = System.Drawing.Color.Black;
            this.Stay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Stay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Stay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stay.ForeColor = System.Drawing.Color.White;
            this.Stay.Location = new System.Drawing.Point(217, 507);
            this.Stay.Margin = new System.Windows.Forms.Padding(4);
            this.Stay.Name = "Stay";
            this.Stay.Size = new System.Drawing.Size(133, 62);
            this.Stay.TabIndex = 3;
            this.Stay.Text = "STAY";
            this.Stay.UseVisualStyleBackColor = false;
            this.Stay.Click += new System.EventHandler(this.Stay_Click);
            // 
            // Hit
            // 
            this.Hit.BackColor = System.Drawing.Color.Black;
            this.Hit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Hit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hit.ForeColor = System.Drawing.Color.White;
            this.Hit.Location = new System.Drawing.Point(56, 507);
            this.Hit.Margin = new System.Windows.Forms.Padding(4);
            this.Hit.Name = "Hit";
            this.Hit.Size = new System.Drawing.Size(133, 62);
            this.Hit.TabIndex = 2;
            this.Hit.Text = "HIT";
            this.Hit.UseVisualStyleBackColor = false;
            this.Hit.Click += new System.EventHandler(this.Hit_Click);
            // 
            // PlayerCount
            // 
            this.PlayerCount.AutoSize = true;
            this.PlayerCount.BackColor = System.Drawing.Color.Black;
            this.PlayerCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PlayerCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerCount.ForeColor = System.Drawing.Color.White;
            this.PlayerCount.Location = new System.Drawing.Point(208, 0);
            this.PlayerCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PlayerCount.Name = "PlayerCount";
            this.PlayerCount.Size = new System.Drawing.Size(34, 38);
            this.PlayerCount.TabIndex = 1;
            this.PlayerCount.Text = "0";
            // 
            // PCName
            // 
            this.PCName.AutoSize = true;
            this.PCName.BackColor = System.Drawing.Color.Black;
            this.PCName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PCName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PCName.ForeColor = System.Drawing.Color.White;
            this.PCName.Location = new System.Drawing.Point(0, 0);
            this.PCName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PCName.Name = "PCName";
            this.PCName.Size = new System.Drawing.Size(189, 38);
            this.PCName.TabIndex = 0;
            this.PCName.Text = "Player Count";
            // 
            // TwoPlayerButton
            // 
            this.TwoPlayerButton.BackColor = System.Drawing.Color.Black;
            this.TwoPlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TwoPlayerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TwoPlayerButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TwoPlayerButton.Location = new System.Drawing.Point(13, 26);
            this.TwoPlayerButton.Margin = new System.Windows.Forms.Padding(4);
            this.TwoPlayerButton.Name = "TwoPlayerButton";
            this.TwoPlayerButton.Size = new System.Drawing.Size(275, 62);
            this.TwoPlayerButton.TabIndex = 22;
            this.TwoPlayerButton.Text = "Two Players";
            this.TwoPlayerButton.UseVisualStyleBackColor = false;
            this.TwoPlayerButton.Visible = false;
            this.TwoPlayerButton.Click += new System.EventHandler(this.TwoPlayerButton_Click);
            // 
            // Output
            // 
            this.Output.BackColor = System.Drawing.Color.Black;
            this.Output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Output.ForeColor = System.Drawing.Color.White;
            this.Output.Location = new System.Drawing.Point(892, 62);
            this.Output.Margin = new System.Windows.Forms.Padding(4);
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.Size = new System.Drawing.Size(439, 26);
            this.Output.TabIndex = 7;
            this.Output.Visible = false;
            // 
            // BetLabel
            // 
            this.BetLabel.AutoSize = true;
            this.BetLabel.BackColor = System.Drawing.Color.Black;
            this.BetLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BetLabel.ForeColor = System.Drawing.Color.White;
            this.BetLabel.Location = new System.Drawing.Point(48, 13);
            this.BetLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BetLabel.Name = "BetLabel";
            this.BetLabel.Size = new System.Drawing.Size(68, 39);
            this.BetLabel.TabIndex = 8;
            this.BetLabel.Text = "Bet";
            // 
            // BetOne
            // 
            this.BetOne.BackColor = System.Drawing.Color.Black;
            this.BetOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BetOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BetOne.ForeColor = System.Drawing.Color.White;
            this.BetOne.Location = new System.Drawing.Point(213, 70);
            this.BetOne.Margin = new System.Windows.Forms.Padding(4);
            this.BetOne.Name = "BetOne";
            this.BetOne.Size = new System.Drawing.Size(113, 49);
            this.BetOne.TabIndex = 9;
            this.BetOne.Text = "$1";
            this.BetOne.UseVisualStyleBackColor = false;
            this.BetOne.Click += new System.EventHandler(this.BetOne_Click);
            // 
            // BetFive
            // 
            this.BetFive.BackColor = System.Drawing.Color.Black;
            this.BetFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BetFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BetFive.ForeColor = System.Drawing.Color.White;
            this.BetFive.Location = new System.Drawing.Point(347, 70);
            this.BetFive.Margin = new System.Windows.Forms.Padding(4);
            this.BetFive.Name = "BetFive";
            this.BetFive.Size = new System.Drawing.Size(113, 49);
            this.BetFive.TabIndex = 10;
            this.BetFive.Text = "$5";
            this.BetFive.UseVisualStyleBackColor = false;
            this.BetFive.Click += new System.EventHandler(this.BetFive_Click);
            // 
            // BetTen
            // 
            this.BetTen.BackColor = System.Drawing.Color.Black;
            this.BetTen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BetTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BetTen.ForeColor = System.Drawing.Color.White;
            this.BetTen.Location = new System.Drawing.Point(480, 70);
            this.BetTen.Margin = new System.Windows.Forms.Padding(4);
            this.BetTen.Name = "BetTen";
            this.BetTen.Size = new System.Drawing.Size(113, 49);
            this.BetTen.TabIndex = 11;
            this.BetTen.Text = "$10";
            this.BetTen.UseVisualStyleBackColor = false;
            this.BetTen.Click += new System.EventHandler(this.BetTen_Click);
            // 
            // BetTwentyFive
            // 
            this.BetTwentyFive.BackColor = System.Drawing.Color.Black;
            this.BetTwentyFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BetTwentyFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BetTwentyFive.ForeColor = System.Drawing.Color.White;
            this.BetTwentyFive.Location = new System.Drawing.Point(613, 70);
            this.BetTwentyFive.Margin = new System.Windows.Forms.Padding(4);
            this.BetTwentyFive.Name = "BetTwentyFive";
            this.BetTwentyFive.Size = new System.Drawing.Size(113, 49);
            this.BetTwentyFive.TabIndex = 12;
            this.BetTwentyFive.Text = "$25";
            this.BetTwentyFive.UseVisualStyleBackColor = false;
            this.BetTwentyFive.Click += new System.EventHandler(this.BetTwentyFive_Click);
            // 
            // BetFifty
            // 
            this.BetFifty.BackColor = System.Drawing.Color.Black;
            this.BetFifty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BetFifty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BetFifty.ForeColor = System.Drawing.Color.White;
            this.BetFifty.Location = new System.Drawing.Point(747, 70);
            this.BetFifty.Margin = new System.Windows.Forms.Padding(4);
            this.BetFifty.Name = "BetFifty";
            this.BetFifty.Size = new System.Drawing.Size(113, 49);
            this.BetFifty.TabIndex = 13;
            this.BetFifty.Text = "$50";
            this.BetFifty.UseVisualStyleBackColor = false;
            this.BetFifty.Click += new System.EventHandler(this.BetFifty_Click);
            // 
            // BetHundred
            // 
            this.BetHundred.BackColor = System.Drawing.Color.Black;
            this.BetHundred.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BetHundred.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BetHundred.ForeColor = System.Drawing.Color.White;
            this.BetHundred.Location = new System.Drawing.Point(880, 70);
            this.BetHundred.Margin = new System.Windows.Forms.Padding(4);
            this.BetHundred.Name = "BetHundred";
            this.BetHundred.Size = new System.Drawing.Size(113, 49);
            this.BetHundred.TabIndex = 14;
            this.BetHundred.Text = "$100";
            this.BetHundred.UseVisualStyleBackColor = false;
            this.BetHundred.Click += new System.EventHandler(this.BetHundred_Click);
            // 
            // BetTwoFifty
            // 
            this.BetTwoFifty.BackColor = System.Drawing.Color.Black;
            this.BetTwoFifty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BetTwoFifty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BetTwoFifty.ForeColor = System.Drawing.Color.White;
            this.BetTwoFifty.Location = new System.Drawing.Point(1013, 70);
            this.BetTwoFifty.Margin = new System.Windows.Forms.Padding(4);
            this.BetTwoFifty.Name = "BetTwoFifty";
            this.BetTwoFifty.Size = new System.Drawing.Size(113, 49);
            this.BetTwoFifty.TabIndex = 15;
            this.BetTwoFifty.Text = "$250";
            this.BetTwoFifty.UseVisualStyleBackColor = false;
            this.BetTwoFifty.Click += new System.EventHandler(this.BetTwoFifty_Click);
            // 
            // BetFiveHundred
            // 
            this.BetFiveHundred.BackColor = System.Drawing.Color.Black;
            this.BetFiveHundred.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BetFiveHundred.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BetFiveHundred.ForeColor = System.Drawing.Color.White;
            this.BetFiveHundred.Location = new System.Drawing.Point(1147, 70);
            this.BetFiveHundred.Margin = new System.Windows.Forms.Padding(4);
            this.BetFiveHundred.Name = "BetFiveHundred";
            this.BetFiveHundred.Size = new System.Drawing.Size(113, 49);
            this.BetFiveHundred.TabIndex = 16;
            this.BetFiveHundred.Text = "$500";
            this.BetFiveHundred.UseVisualStyleBackColor = false;
            this.BetFiveHundred.Click += new System.EventHandler(this.BetFiveHundred_Click);
            // 
            // BetThousand
            // 
            this.BetThousand.BackColor = System.Drawing.Color.Black;
            this.BetThousand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BetThousand.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BetThousand.ForeColor = System.Drawing.Color.White;
            this.BetThousand.Location = new System.Drawing.Point(1280, 70);
            this.BetThousand.Margin = new System.Windows.Forms.Padding(4);
            this.BetThousand.Name = "BetThousand";
            this.BetThousand.Size = new System.Drawing.Size(113, 49);
            this.BetThousand.TabIndex = 17;
            this.BetThousand.Text = "$1,000";
            this.BetThousand.UseVisualStyleBackColor = false;
            this.BetThousand.Click += new System.EventHandler(this.BetThousand_Click);
            // 
            // BetAll
            // 
            this.BetAll.BackColor = System.Drawing.Color.Black;
            this.BetAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BetAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BetAll.ForeColor = System.Drawing.Color.White;
            this.BetAll.Location = new System.Drawing.Point(27, 70);
            this.BetAll.Margin = new System.Windows.Forms.Padding(4);
            this.BetAll.Name = "BetAll";
            this.BetAll.Size = new System.Drawing.Size(113, 49);
            this.BetAll.TabIndex = 18;
            this.BetAll.Text = "Bet All";
            this.BetAll.UseVisualStyleBackColor = false;
            this.BetAll.Click += new System.EventHandler(this.BetAll_Click);
            // 
            // BettingPanel
            // 
            this.BettingPanel.Controls.Add(this.BetThousand);
            this.BettingPanel.Controls.Add(this.BetLabel);
            this.BettingPanel.Controls.Add(this.BetAll);
            this.BettingPanel.Controls.Add(this.BetOne);
            this.BettingPanel.Controls.Add(this.BetFive);
            this.BettingPanel.Controls.Add(this.BetFiveHundred);
            this.BettingPanel.Controls.Add(this.BetTen);
            this.BettingPanel.Controls.Add(this.BetTwoFifty);
            this.BettingPanel.Controls.Add(this.BetTwentyFive);
            this.BettingPanel.Controls.Add(this.BetHundred);
            this.BettingPanel.Controls.Add(this.BetFifty);
            this.BettingPanel.Location = new System.Drawing.Point(39, 700);
            this.BettingPanel.Margin = new System.Windows.Forms.Padding(4);
            this.BettingPanel.Name = "BettingPanel";
            this.BettingPanel.Size = new System.Drawing.Size(1411, 154);
            this.BettingPanel.TabIndex = 19;
            this.BettingPanel.Visible = false;
            // 
            // TitleImage
            // 
            this.TitleImage.Image = global::Blackjack.Properties.Resources.BackJack_Title;
            this.TitleImage.Location = new System.Drawing.Point(10, 14);
            this.TitleImage.Margin = new System.Windows.Forms.Padding(4);
            this.TitleImage.Name = "TitleImage";
            this.TitleImage.Size = new System.Drawing.Size(291, 89);
            this.TitleImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TitleImage.TabIndex = 1;
            this.TitleImage.TabStop = false;
            // 
            // ProfileButton
            // 
            this.ProfileButton.BackColor = System.Drawing.Color.Black;
            this.ProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProfileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.ProfileButton.ForeColor = System.Drawing.Color.White;
            this.ProfileButton.Location = new System.Drawing.Point(315, 15);
            this.ProfileButton.Margin = new System.Windows.Forms.Padding(4);
            this.ProfileButton.Name = "ProfileButton";
            this.ProfileButton.Size = new System.Drawing.Size(96, 41);
            this.ProfileButton.TabIndex = 6;
            this.ProfileButton.Text = "Profile";
            this.ProfileButton.UseVisualStyleBackColor = false;
            this.ProfileButton.Visible = false;
            this.ProfileButton.Click += new System.EventHandler(this.ProfileButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.Black;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.Location = new System.Drawing.Point(315, 63);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(96, 41);
            this.SaveButton.TabIndex = 20;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Visible = false;
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.Black;
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.ForeColor = System.Drawing.Color.White;
            this.ResetButton.Location = new System.Drawing.Point(440, 28);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(4);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(238, 62);
            this.ResetButton.TabIndex = 21;
            this.ResetButton.Text = "NEXT TURN";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Visible = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // OnePlayerButton
            // 
            this.OnePlayerButton.BackColor = System.Drawing.Color.Black;
            this.OnePlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OnePlayerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnePlayerButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.OnePlayerButton.Location = new System.Drawing.Point(13, 25);
            this.OnePlayerButton.Margin = new System.Windows.Forms.Padding(4);
            this.OnePlayerButton.Name = "OnePlayerButton";
            this.OnePlayerButton.Size = new System.Drawing.Size(275, 62);
            this.OnePlayerButton.TabIndex = 23;
            this.OnePlayerButton.Text = "One Player";
            this.OnePlayerButton.UseVisualStyleBackColor = false;
            this.OnePlayerButton.Visible = false;
            this.OnePlayerButton.Click += new System.EventHandler(this.OnePlayerButton_Click);
            // 
            // ThreePlayerButton
            // 
            this.ThreePlayerButton.BackColor = System.Drawing.Color.Black;
            this.ThreePlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThreePlayerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThreePlayerButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ThreePlayerButton.Location = new System.Drawing.Point(13, 28);
            this.ThreePlayerButton.Margin = new System.Windows.Forms.Padding(4);
            this.ThreePlayerButton.Name = "ThreePlayerButton";
            this.ThreePlayerButton.Size = new System.Drawing.Size(275, 62);
            this.ThreePlayerButton.TabIndex = 24;
            this.ThreePlayerButton.Text = "Three Players";
            this.ThreePlayerButton.UseVisualStyleBackColor = false;
            this.ThreePlayerButton.Visible = false;
            this.ThreePlayerButton.Click += new System.EventHandler(this.ThreePlayerButton_Click);
            // 
            // Blackjack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1508, 992);
            this.Controls.Add(this.TitleImage);
            this.Controls.Add(this.OnePlayerButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.TwoPlayerButton);
            this.Controls.Add(this.ThreePlayerButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ProfileButton);
            this.Controls.Add(this.BettingPanel);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.PlayerHand);
            this.Controls.Add(this.DealerHand);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.Resize);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.StartButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1067, 554);
            this.Name = "Blackjack";
            this.Text = "z";
            this.Load += new System.EventHandler(this.Blackjack_Load);
            this.SizeChanged += new System.EventHandler(this.Blackjack_SizeChanged);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Blackjack_MouseDown);
            this.DealerHand.ResumeLayout(false);
            this.DealerHand.PerformLayout();
            this.PlayerHand.ResumeLayout(false);
            this.PlayerHand.PerformLayout();
            this.BettingPanel.ResumeLayout(false);
            this.BettingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TitleImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.PictureBox TitleImage;
        private System.Windows.Forms.Button Resize;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Panel DealerHand;
        private System.Windows.Forms.Panel PlayerHand;
        private System.Windows.Forms.Label DCName;
        private System.Windows.Forms.Label PCName;
        private System.Windows.Forms.Label DealerCount;
        private System.Windows.Forms.Label PlayerCount;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.Button Stay;
        private System.Windows.Forms.Button Hit;
        private System.Windows.Forms.Label BetLabel;
        private System.Windows.Forms.Button BetOne;
        private System.Windows.Forms.Button BetFive;
        private System.Windows.Forms.Button BetTen;
        private System.Windows.Forms.Button BetTwentyFive;
        private System.Windows.Forms.Button BetFifty;
        private System.Windows.Forms.Button BetHundred;
        private System.Windows.Forms.Button BetTwoFifty;
        private System.Windows.Forms.Button BetFiveHundred;
        private System.Windows.Forms.Button BetThousand;
        private System.Windows.Forms.Button BetAll;
        private System.Windows.Forms.Panel BettingPanel;
        private System.Windows.Forms.Label PlayerCash;
        private System.Windows.Forms.Label Cash;
        private System.Windows.Forms.Button ProfileButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button InsuranceButton;
        private System.Windows.Forms.Button SplitButton;
        private System.Windows.Forms.Label SplitCount;
        private System.Windows.Forms.Label SCName;
        private System.Windows.Forms.Button TwoPlayerButton;
        private System.Windows.Forms.Button ThreePlayerButton;
        private System.Windows.Forms.Button OnePlayerButton;
    }
}

