namespace Blackjack
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
            this.TitleImage = new System.Windows.Forms.PictureBox();
            this.Resize = new System.Windows.Forms.Button();
            this.Minimize = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
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
            this.Close.Location = new System.Drawing.Point(773, 0);
            this.Close.Margin = new System.Windows.Forms.Padding(0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(25, 34);
            this.Close.TabIndex = 0;
            this.Close.Text = "X";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // TitleImage
            // 
            this.TitleImage.Image = global::Blackjack.Properties.Resources.GameTitle;
            this.TitleImage.Location = new System.Drawing.Point(12, 12);
            this.TitleImage.Name = "TitleImage";
            this.TitleImage.Size = new System.Drawing.Size(218, 72);
            this.TitleImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TitleImage.TabIndex = 1;
            this.TitleImage.TabStop = false;
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
            this.Resize.Location = new System.Drawing.Point(743, 0);
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
            this.Minimize.Location = new System.Drawing.Point(713, 0);
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
            this.StartButton.Location = new System.Drawing.Point(361, 219);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(72, 44);
            this.StartButton.TabIndex = 4;
            this.StartButton.Text = "Play!";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // Blackjack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.Resize);
            this.Controls.Add(this.TitleImage);
            this.Controls.Add(this.Close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "Blackjack";
            this.Text = "Blackjack";
            this.Load += new System.EventHandler(this.Blackjack_Load);
            this.SizeChanged += new System.EventHandler(this.Blackjack_SizeChanged);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Blackjack_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.TitleImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.PictureBox TitleImage;
        private System.Windows.Forms.Button Resize;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.Button StartButton;
    }
}

