namespace clock_call
{
    partial class FormClock
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ButtonClock1 = new System.Windows.Forms.Button();
            this.ButtonClock2 = new System.Windows.Forms.Button();
            this.ButtonClock3 = new System.Windows.Forms.Button();
            this.ButtonClock4 = new System.Windows.Forms.Button();
            this.ButtonBG1 = new System.Windows.Forms.Button();
            this.ButtonBG2 = new System.Windows.Forms.Button();
            this.ButtonBG3 = new System.Windows.Forms.Button();
            this.ButtonBG4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::clock_call.Properties.Resources.ClockZero;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 350);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ButtonClock1
            // 
            this.ButtonClock1.Location = new System.Drawing.Point(12, 368);
            this.ButtonClock1.Name = "ButtonClock1";
            this.ButtonClock1.Size = new System.Drawing.Size(81, 25);
            this.ButtonClock1.TabIndex = 1;
            this.ButtonClock1.Text = "Стиль 1";
            this.ButtonClock1.UseVisualStyleBackColor = true;
            this.ButtonClock1.Click += new System.EventHandler(this.ButtonClock1_Click);
            // 
            // ButtonClock2
            // 
            this.ButtonClock2.Location = new System.Drawing.Point(99, 368);
            this.ButtonClock2.Name = "ButtonClock2";
            this.ButtonClock2.Size = new System.Drawing.Size(81, 25);
            this.ButtonClock2.TabIndex = 2;
            this.ButtonClock2.Text = "Стиль 2";
            this.ButtonClock2.UseVisualStyleBackColor = true;
            this.ButtonClock2.Click += new System.EventHandler(this.ButtonClock2_Click);
            // 
            // ButtonClock3
            // 
            this.ButtonClock3.Location = new System.Drawing.Point(194, 368);
            this.ButtonClock3.Name = "ButtonClock3";
            this.ButtonClock3.Size = new System.Drawing.Size(81, 25);
            this.ButtonClock3.TabIndex = 3;
            this.ButtonClock3.Text = "Стиль 3";
            this.ButtonClock3.UseVisualStyleBackColor = true;
            this.ButtonClock3.Click += new System.EventHandler(this.ButtonClock3_Click);
            // 
            // ButtonClock4
            // 
            this.ButtonClock4.Location = new System.Drawing.Point(281, 368);
            this.ButtonClock4.Name = "ButtonClock4";
            this.ButtonClock4.Size = new System.Drawing.Size(81, 25);
            this.ButtonClock4.TabIndex = 4;
            this.ButtonClock4.Text = "Стиль 4";
            this.ButtonClock4.UseVisualStyleBackColor = true;
            this.ButtonClock4.Click += new System.EventHandler(this.ButtonClock4_Click);
            // 
            // ButtonBG1
            // 
            this.ButtonBG1.Location = new System.Drawing.Point(12, 402);
            this.ButtonBG1.Name = "ButtonBG1";
            this.ButtonBG1.Size = new System.Drawing.Size(81, 25);
            this.ButtonBG1.TabIndex = 5;
            this.ButtonBG1.Text = "Стиль фона 1";
            this.ButtonBG1.UseVisualStyleBackColor = true;
            this.ButtonBG1.Click += new System.EventHandler(this.ButtonBG1_Click);
            // 
            // ButtonBG2
            // 
            this.ButtonBG2.Location = new System.Drawing.Point(99, 402);
            this.ButtonBG2.Name = "ButtonBG2";
            this.ButtonBG2.Size = new System.Drawing.Size(81, 25);
            this.ButtonBG2.TabIndex = 6;
            this.ButtonBG2.Text = "Стиль фона 2";
            this.ButtonBG2.UseVisualStyleBackColor = true;
            this.ButtonBG2.Click += new System.EventHandler(this.ButtonBG2_Click);
            // 
            // ButtonBG3
            // 
            this.ButtonBG3.Location = new System.Drawing.Point(194, 402);
            this.ButtonBG3.Name = "ButtonBG3";
            this.ButtonBG3.Size = new System.Drawing.Size(81, 25);
            this.ButtonBG3.TabIndex = 7;
            this.ButtonBG3.Text = "Стиль фона 3";
            this.ButtonBG3.UseVisualStyleBackColor = true;
            this.ButtonBG3.Click += new System.EventHandler(this.ButtonBG3_Click);
            // 
            // ButtonBG4
            // 
            this.ButtonBG4.Location = new System.Drawing.Point(281, 402);
            this.ButtonBG4.Name = "ButtonBG4";
            this.ButtonBG4.Size = new System.Drawing.Size(81, 25);
            this.ButtonBG4.TabIndex = 8;
            this.ButtonBG4.Text = "Стиль фона 4";
            this.ButtonBG4.UseVisualStyleBackColor = true;
            this.ButtonBG4.Click += new System.EventHandler(this.ButtonBG4_Click);
            // 
            // FormClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(377, 439);
            this.Controls.Add(this.ButtonBG4);
            this.Controls.Add(this.ButtonBG3);
            this.Controls.Add(this.ButtonBG2);
            this.Controls.Add(this.ButtonBG1);
            this.Controls.Add(this.ButtonClock4);
            this.Controls.Add(this.ButtonClock3);
            this.Controls.Add(this.ButtonClock2);
            this.Controls.Add(this.ButtonClock1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormClock";
            this.Text = "Часы";
            this.Load += new System.EventHandler(this.FormClock_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormClock_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ButtonClock1;
        private System.Windows.Forms.Button ButtonClock2;
        private System.Windows.Forms.Button ButtonClock3;
        private System.Windows.Forms.Button ButtonClock4;
        private System.Windows.Forms.Button ButtonBG1;
        private System.Windows.Forms.Button ButtonBG2;
        private System.Windows.Forms.Button ButtonBG3;
        private System.Windows.Forms.Button ButtonBG4;
    }
}