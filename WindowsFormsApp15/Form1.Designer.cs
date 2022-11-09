namespace WindowsFormsApp15
{
    partial class Form1
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
            this.Вывод = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Вывод
            // 
            this.Вывод.AutoSize = true;
            this.Вывод.Location = new System.Drawing.Point(149, 114);
            this.Вывод.Name = "Вывод";
            this.Вывод.Size = new System.Drawing.Size(35, 13);
            this.Вывод.TabIndex = 0;
            this.Вывод.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Chartreuse;
            this.panel1.Location = new System.Drawing.Point(383, 254);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 120);
            this.panel1.TabIndex = 1;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Вывод);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Вывод;
        private System.Windows.Forms.Panel panel1;
    }
}

