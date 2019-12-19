namespace Formatting
{
    partial class Form1
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Batching1 = new System.Windows.Forms.Button();
            this.Batching2 = new System.Windows.Forms.Button();
            this.Download1Count = new System.Windows.Forms.TextBox();
            this.Download2Count = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Batching1
            // 
            this.Batching1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Batching1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Batching1.Location = new System.Drawing.Point(32, 49);
            this.Batching1.Name = "Batching1";
            this.Batching1.Size = new System.Drawing.Size(136, 63);
            this.Batching1.TabIndex = 0;
            this.Batching1.Text = "Download Batching 1";
            this.Batching1.UseVisualStyleBackColor = true;
            this.Batching1.Click += new System.EventHandler(this.Batching1_Click);
            // 
            // Batching2
            // 
            this.Batching2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Batching2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Batching2.Location = new System.Drawing.Point(231, 49);
            this.Batching2.Name = "Batching2";
            this.Batching2.Size = new System.Drawing.Size(136, 63);
            this.Batching2.TabIndex = 1;
            this.Batching2.Text = "Download Batching 2";
            this.Batching2.UseVisualStyleBackColor = true;
            this.Batching2.Click += new System.EventHandler(this.Batching2_Click);
            // 
            // Download1Count
            // 
            this.Download1Count.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Download1Count.Location = new System.Drawing.Point(83, 22);
            this.Download1Count.Name = "Download1Count";
            this.Download1Count.Size = new System.Drawing.Size(34, 21);
            this.Download1Count.TabIndex = 2;
            this.Download1Count.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Download2Count
            // 
            this.Download2Count.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Download2Count.Location = new System.Drawing.Point(282, 22);
            this.Download2Count.Name = "Download2Count";
            this.Download2Count.Size = new System.Drawing.Size(34, 21);
            this.Download2Count.TabIndex = 3;
            this.Download2Count.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(404, 138);
            this.Controls.Add(this.Download2Count);
            this.Controls.Add(this.Download1Count);
            this.Controls.Add(this.Batching2);
            this.Controls.Add(this.Batching1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Producer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Button Batching1;
        private System.Windows.Forms.Button Batching2;
        private System.Windows.Forms.TextBox Download1Count;
        private System.Windows.Forms.TextBox Download2Count;
    }
}

