namespace clock_call
{
    partial class FormAlClock
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
            this.components = new System.ComponentModel.Container();
            this.LabelAlClock = new System.Windows.Forms.Label();
            this.LabelInfo = new System.Windows.Forms.Label();
            this.ButtonOn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonMusic = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backGroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.type1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.type2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.type3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.type4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.type5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelAlClock
            // 
            this.LabelAlClock.AutoSize = true;
            this.LabelAlClock.BackColor = System.Drawing.Color.DarkGray;
            this.LabelAlClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelAlClock.Location = new System.Drawing.Point(189, 101);
            this.LabelAlClock.Name = "LabelAlClock";
            this.LabelAlClock.Size = new System.Drawing.Size(150, 31);
            this.LabelAlClock.TabIndex = 0;
            this.LabelAlClock.Text = "Будильник";
            // 
            // LabelInfo
            // 
            this.LabelInfo.AutoSize = true;
            this.LabelInfo.BackColor = System.Drawing.Color.DarkGray;
            this.LabelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelInfo.Location = new System.Drawing.Point(162, 132);
            this.LabelInfo.Name = "LabelInfo";
            this.LabelInfo.Size = new System.Drawing.Size(196, 31);
            this.LabelInfo.TabIndex = 1;
            this.LabelInfo.Text = "Выбери время";
            // 
            // ButtonOn
            // 
            this.ButtonOn.Location = new System.Drawing.Point(165, 287);
            this.ButtonOn.Name = "ButtonOn";
            this.ButtonOn.Size = new System.Drawing.Size(190, 30);
            this.ButtonOn.TabIndex = 2;
            this.ButtonOn.Text = "Запуск";
            this.ButtonOn.UseVisualStyleBackColor = true;
            this.ButtonOn.Click += new System.EventHandler(this.ButtonOn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(63, 196);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(44, 39);
            this.textBox1.TabIndex = 4;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(219, 196);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(44, 39);
            this.textBox2.TabIndex = 5;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(377, 196);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(44, 39);
            this.textBox3.TabIndex = 6;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            this.textBox3.Leave += new System.EventHandler(this.textBox3_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(113, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ч";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(269, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 39);
            this.label2.TabIndex = 8;
            this.label2.Text = "М";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(427, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 39);
            this.label3.TabIndex = 9;
            this.label3.Text = "С";
            // 
            // ButtonMusic
            // 
            this.ButtonMusic.Location = new System.Drawing.Point(165, 335);
            this.ButtonMusic.Name = "ButtonMusic";
            this.ButtonMusic.Size = new System.Drawing.Size(190, 30);
            this.ButtonMusic.TabIndex = 10;
            this.ButtonMusic.Text = "Выбрать музыку";
            this.ButtonMusic.UseVisualStyleBackColor = true;
            this.ButtonMusic.Click += new System.EventHandler(this.ButtonMusic_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backGroundToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(512, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backGroundToolStripMenuItem
            // 
            this.backGroundToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.type1ToolStripMenuItem,
            this.type2ToolStripMenuItem,
            this.type3ToolStripMenuItem,
            this.type4ToolStripMenuItem,
            this.type5ToolStripMenuItem});
            this.backGroundToolStripMenuItem.Name = "backGroundToolStripMenuItem";
            this.backGroundToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.backGroundToolStripMenuItem.Text = "BackGround";
            // 
            // type1ToolStripMenuItem
            // 
            this.type1ToolStripMenuItem.Name = "type1ToolStripMenuItem";
            this.type1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.type1ToolStripMenuItem.Text = "type 1";
            this.type1ToolStripMenuItem.Click += new System.EventHandler(this.type1ToolStripMenuItem_Click);
            // 
            // type2ToolStripMenuItem
            // 
            this.type2ToolStripMenuItem.Name = "type2ToolStripMenuItem";
            this.type2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.type2ToolStripMenuItem.Text = "type 2";
            this.type2ToolStripMenuItem.Click += new System.EventHandler(this.type2ToolStripMenuItem_Click);
            // 
            // type3ToolStripMenuItem
            // 
            this.type3ToolStripMenuItem.Name = "type3ToolStripMenuItem";
            this.type3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.type3ToolStripMenuItem.Text = "type 3";
            this.type3ToolStripMenuItem.Click += new System.EventHandler(this.type3ToolStripMenuItem_Click);
            // 
            // type4ToolStripMenuItem
            // 
            this.type4ToolStripMenuItem.Name = "type4ToolStripMenuItem";
            this.type4ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.type4ToolStripMenuItem.Text = "type 4";
            this.type4ToolStripMenuItem.Click += new System.EventHandler(this.type4ToolStripMenuItem_Click);
            // 
            // type5ToolStripMenuItem
            // 
            this.type5ToolStripMenuItem.Name = "type5ToolStripMenuItem";
            this.type5ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.type5ToolStripMenuItem.Text = "type 5";
            this.type5ToolStripMenuItem.Click += new System.EventHandler(this.type5ToolStripMenuItem_Click);
            // 
            // FormAlClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(512, 390);
            this.Controls.Add(this.ButtonMusic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ButtonOn);
            this.Controls.Add(this.LabelInfo);
            this.Controls.Add(this.LabelAlClock);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormAlClock";
            this.Text = "FormAlClock";
            this.Load += new System.EventHandler(this.FormAlClock_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelAlClock;
        private System.Windows.Forms.Label LabelInfo;
        private System.Windows.Forms.Button ButtonOn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ButtonMusic;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backGroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem type1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem type2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem type3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem type4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem type5ToolStripMenuItem;
    }
}