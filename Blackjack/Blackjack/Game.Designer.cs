namespace BlackjackGame
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
            this.Stay = new System.Windows.Forms.Button();
            this.Hit = new System.Windows.Forms.Button();
            this.PlayerCount = new System.Windows.Forms.Label();
            this.PCName = new System.Windows.Forms.Label();
            this.Output = new System.Windows.Forms.TextBox();
            this.TitleImage = new System.Windows.Forms.PictureBox();
            this.BetLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.DealerHand.SuspendLayout();
            this.PlayerHand.SuspendLayout();
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
            this.Close.Location = new System.Drawing.Point(1104, 0);
            this.Close.Margin = new System.Windows.Forms.Padding(0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(25, 34);
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
            this.Resize.Location = new System.Drawing.Point(1074, 0);
            this.Resize.Margin = new System.Windows.Forms.Padding(0);
            this.Resize.Name = "Resize";
            this.Resize.Size = new System.Drawing.Size(25, 34);
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
            this.Minimize.Location = new System.Drawing.Point(1044, 0);
            this.Minimize.Margin = new System.Windows.Forms.Padding(0);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(25, 34);
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
            this.StartButton.Location = new System.Drawing.Point(29, 27);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(72, 44);
            this.StartButton.TabIndex = 4;
            this.StartButton.Text = "Play!";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Visible = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // DealerHand
            // 
            this.DealerHand.Controls.Add(this.DealerCount);
            this.DealerHand.Controls.Add(this.DCName);
            this.DealerHand.Location = new System.Drawing.Point(98, 163);
            this.DealerHand.Name = "DealerHand";
            this.DealerHand.Size = new System.Drawing.Size(450, 500);
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
            this.DealerCount.Location = new System.Drawing.Point(172, 0);
            this.DealerCount.Name = "DealerCount";
            this.DealerCount.Size = new System.Drawing.Size(28, 31);
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
            this.DCName.Name = "DCName";
            this.DCName.Size = new System.Drawing.Size(168, 31);
            this.DCName.TabIndex = 0;
            this.DCName.Text = "Dealer Count: ";
            // 
            // PlayerHand
            // 
            this.PlayerHand.Controls.Add(this.Stay);
            this.PlayerHand.Controls.Add(this.Hit);
            this.PlayerHand.Controls.Add(this.PlayerCount);
            this.PlayerHand.Controls.Add(this.PCName);
            this.PlayerHand.Location = new System.Drawing.Point(611, 163);
            this.PlayerHand.Name = "PlayerHand";
            this.PlayerHand.Size = new System.Drawing.Size(450, 500);
            this.PlayerHand.TabIndex = 6;
            this.PlayerHand.Visible = false;
            // 
            // Stay
            // 
            this.Stay.BackColor = System.Drawing.Color.Black;
            this.Stay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Stay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Stay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stay.ForeColor = System.Drawing.Color.White;
            this.Stay.Location = new System.Drawing.Point(265, 58);
            this.Stay.Name = "Stay";
            this.Stay.Size = new System.Drawing.Size(100, 50);
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
            this.Hit.Location = new System.Drawing.Point(84, 58);
            this.Hit.Name = "Hit";
            this.Hit.Size = new System.Drawing.Size(100, 50);
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
            this.PlayerCount.Location = new System.Drawing.Point(156, 0);
            this.PlayerCount.Name = "PlayerCount";
            this.PlayerCount.Size = new System.Drawing.Size(28, 31);
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
            this.PCName.Name = "PCName";
            this.PCName.Size = new System.Drawing.Size(152, 31);
            this.PCName.TabIndex = 0;
            this.PCName.Text = "Player Count";
            // 
            // Output
            // 
            this.Output.BackColor = System.Drawing.Color.Black;
            this.Output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Output.ForeColor = System.Drawing.Color.White;
            this.Output.Location = new System.Drawing.Point(669, 50);
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.Size = new System.Drawing.Size(330, 23);
            this.Output.TabIndex = 7;
            this.Output.Visible = false;
            // 
            // TitleImage
            // 
            this.TitleImage.Image = global::Blackjack.Properties.Resources.BackJack_Title;
            this.TitleImage.Location = new System.Drawing.Point(12, 12);
            this.TitleImage.Name = "TitleImage";
            this.TitleImage.Size = new System.Drawing.Size(218, 72);
            this.TitleImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TitleImage.TabIndex = 1;
            this.TitleImage.TabStop = false;
            // 
            // BetLabel
            // 
            this.BetLabel.AutoSize = true;
            this.BetLabel.BackColor = System.Drawing.Color.Black;
            this.BetLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BetLabel.ForeColor = System.Drawing.Color.White;
            this.BetLabel.Location = new System.Drawing.Point(118, 679);
            this.BetLabel.Name = "BetLabel";
            this.BetLabel.Size = new System.Drawing.Size(55, 31);
            this.BetLabel.TabIndex = 8;
            this.BetLabel.Text = "Bet";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(180, 745);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(280, 745);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(385, 745);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(486, 745);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(587, 745);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 13;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Black;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(688, 745);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 14;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Black;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(788, 745);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 15;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Black;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(887, 745);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 16;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Black;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(994, 745);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 17;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Black;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(26, 745);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 18;
            this.button10.Text = "button10";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // Blackjack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1131, 806);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BetLabel);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.PlayerHand);
            this.Controls.Add(this.DealerHand);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.Resize);
            this.Controls.Add(this.TitleImage);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.StartButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "Blackjack";
            this.Text = "z";
            this.Load += new System.EventHandler(this.Blackjack_Load);
            this.SizeChanged += new System.EventHandler(this.Blackjack_SizeChanged);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Blackjack_MouseDown);
            this.DealerHand.ResumeLayout(false);
            this.DealerHand.PerformLayout();
            this.PlayerHand.ResumeLayout(false);
            this.PlayerHand.PerformLayout();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
    }
}

