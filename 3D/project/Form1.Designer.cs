namespace project
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавитьИлиЗаменитьВидео2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьИлиЗаменитьВидео1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьИлиЗаменитьВидео2ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DimGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьИлиЗаменитьВидео2ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(316, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // добавитьИлиЗаменитьВидео2ToolStripMenuItem
            // 
            this.добавитьИлиЗаменитьВидео2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьИлиЗаменитьВидео1ToolStripMenuItem,
            this.добавитьИлиЗаменитьВидео2ToolStripMenuItem1,
            this.сохранитьКакToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.добавитьИлиЗаменитьВидео2ToolStripMenuItem.Name = "добавитьИлиЗаменитьВидео2ToolStripMenuItem";
            this.добавитьИлиЗаменитьВидео2ToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.добавитьИлиЗаменитьВидео2ToolStripMenuItem.Text = "Файл";
            this.добавитьИлиЗаменитьВидео2ToolStripMenuItem.Click += new System.EventHandler(this.добавитьИлиЗаменитьВидео2ToolStripMenuItem_Click);
            // 
            // добавитьИлиЗаменитьВидео1ToolStripMenuItem
            // 
            this.добавитьИлиЗаменитьВидео1ToolStripMenuItem.Name = "добавитьИлиЗаменитьВидео1ToolStripMenuItem";
            this.добавитьИлиЗаменитьВидео1ToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.добавитьИлиЗаменитьВидео1ToolStripMenuItem.Text = "Добавить или заменить видео №1";
            this.добавитьИлиЗаменитьВидео1ToolStripMenuItem.Click += new System.EventHandler(this.добавитьИлиЗаменитьВидео1ToolStripMenuItem_Click);
            // 
            // добавитьИлиЗаменитьВидео2ToolStripMenuItem1
            // 
            this.добавитьИлиЗаменитьВидео2ToolStripMenuItem1.Name = "добавитьИлиЗаменитьВидео2ToolStripMenuItem1";
            this.добавитьИлиЗаменитьВидео2ToolStripMenuItem1.Size = new System.Drawing.Size(261, 22);
            this.добавитьИлиЗаменитьВидео2ToolStripMenuItem1.Text = "Добавить или заменить видео №2";
            this.добавитьИлиЗаменитьВидео2ToolStripMenuItem1.Click += new System.EventHandler(this.добавитьИлиЗаменитьВидео2ToolStripMenuItem1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 396);
            this.panel1.TabIndex = 2;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(16, 39);
            this.trackBar1.Maximum = 40;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(262, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Value = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Расстояние между камерами (см)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(200, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(39, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(245, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 20);
            this.button1.TabIndex = 3;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(262, 41);
            this.button2.TabIndex = 4;
            this.button2.Text = "Начать преобразование";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(316, 435);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Преобразование Фурье";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьИлиЗаменитьВидео2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьИлиЗаменитьВидео1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьИлиЗаменитьВидео2ToolStripMenuItem1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.Button button2;
    }
}

