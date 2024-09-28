namespace clock_call
{
    partial class FormMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonClock = new System.Windows.Forms.Button();
            this.ButtonAlClock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonClock
            // 
            this.ButtonClock.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ButtonClock.Location = new System.Drawing.Point(37, 27);
            this.ButtonClock.Name = "ButtonClock";
            this.ButtonClock.Size = new System.Drawing.Size(116, 111);
            this.ButtonClock.TabIndex = 0;
            this.ButtonClock.Text = "Часы";
            this.ButtonClock.UseVisualStyleBackColor = false;
            this.ButtonClock.Click += new System.EventHandler(this.ButtonClock_Click);
            // 
            // ButtonAlClock
            // 
            this.ButtonAlClock.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ButtonAlClock.Location = new System.Drawing.Point(233, 27);
            this.ButtonAlClock.Name = "ButtonAlClock";
            this.ButtonAlClock.Size = new System.Drawing.Size(116, 111);
            this.ButtonAlClock.TabIndex = 0;
            this.ButtonAlClock.Text = "Будильник";
            this.ButtonAlClock.UseVisualStyleBackColor = false;
            this.ButtonAlClock.Click += new System.EventHandler(this.ButtonAlClock_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(387, 164);
            this.Controls.Add(this.ButtonAlClock);
            this.Controls.Add(this.ButtonClock);
            this.Name = "FormMenu";
            this.Text = "Меню будильника";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonClock;
        private System.Windows.Forms.Button ButtonAlClock;
    }
}

