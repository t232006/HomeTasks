namespace homeTask9
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.NN1 = new System.Windows.Forms.ToolStripMenuItem();
            this.N1 = new System.Windows.Forms.ToolStripMenuItem();
            this.N2 = new System.Windows.Forms.ToolStripMenuItem();
            this.N3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.N4 = new System.Windows.Forms.ToolStripMenuItem();
            this.режимToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.N5 = new System.Windows.Forms.ToolStripMenuItem();
            this.N6 = new System.Windows.Forms.ToolStripMenuItem();
            this.About = new System.Windows.Forms.ToolStripMenuItem();
            this.N8 = new System.Windows.Forms.ToolStripMenuItem();
            this.N9 = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UpDown2 = new System.Windows.Forms.NumericUpDown();
            this.UpDown1 = new System.Windows.Forms.NumericUpDown();
            this.cb2 = new System.Windows.Forms.CheckBox();
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.DelBut = new System.Windows.Forms.Button();
            this.AddBut = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.FinBut = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.cb3 = new System.Windows.Forms.RadioButton();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(0, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(238, 304);
            this.listBox1.TabIndex = 0;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NN1,
            this.режимToolStripMenuItem,
            this.About});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // NN1
            // 
            this.NN1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.N1,
            this.N2,
            this.N3,
            this.toolStripMenuItem1,
            this.N4});
            this.NN1.Name = "NN1";
            this.NN1.Size = new System.Drawing.Size(48, 20);
            this.NN1.Text = "Файл";
            // 
            // N1
            // 
            this.N1.Name = "N1";
            this.N1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.N1.Size = new System.Drawing.Size(182, 22);
            this.N1.Text = "Новый...";
            this.N1.Click += new System.EventHandler(this.N1_Click);
            // 
            // N2
            // 
            this.N2.Name = "N2";
            this.N2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.N2.Size = new System.Drawing.Size(182, 22);
            this.N2.Text = "Сохранить...";
            this.N2.Click += new System.EventHandler(this.N2_Click);
            // 
            // N3
            // 
            this.N3.Name = "N3";
            this.N3.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.N3.Size = new System.Drawing.Size(182, 22);
            this.N3.Text = "Открыть...";
            this.N3.Click += new System.EventHandler(this.N3_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(179, 6);
            // 
            // N4
            // 
            this.N4.Name = "N4";
            this.N4.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4)));
            this.N4.Size = new System.Drawing.Size(182, 22);
            this.N4.Text = "Закрыть";
            this.N4.Click += new System.EventHandler(this.N4_Click);
            // 
            // режимToolStripMenuItem
            // 
            this.режимToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.N5,
            this.N6});
            this.режимToolStripMenuItem.Name = "режимToolStripMenuItem";
            this.режимToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.режимToolStripMenuItem.Text = "Режим";
            // 
            // N5
            // 
            this.N5.Name = "N5";
            this.N5.Size = new System.Drawing.Size(154, 22);
            this.N5.Text = "Режим правки";
            this.N5.Click += new System.EventHandler(this.N5_Click);
            // 
            // N6
            // 
            this.N6.Checked = true;
            this.N6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.N6.Name = "N6";
            this.N6.Size = new System.Drawing.Size(154, 22);
            this.N6.Text = "Режим тестов";
            this.N6.Click += new System.EventHandler(this.N6_Click);
            // 
            // About
            // 
            this.About.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.N8,
            this.N9});
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(65, 20);
            this.About.Text = "Справка";
            // 
            // N8
            // 
            this.N8.Name = "N8";
            this.N8.Size = new System.Drawing.Size(180, 22);
            this.N8.Text = "Помощь";
            this.N8.Click += new System.EventHandler(this.N8_Click);
            // 
            // N9
            // 
            this.N9.Name = "N9";
            this.N9.Size = new System.Drawing.Size(180, 22);
            this.N9.Text = "О программе";
            this.N9.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(244, 27);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(556, 303);
            this.textBox1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.UpDown2);
            this.panel1.Controls.Add(this.UpDown1);
            this.panel1.Controls.Add(this.cb2);
            this.panel1.Controls.Add(this.cb1);
            this.panel1.Controls.Add(this.DelBut);
            this.panel1.Controls.Add(this.AddBut);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 336);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 114);
            this.panel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(540, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "порог сдачи, %";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(506, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "количество вопросов";
            // 
            // UpDown2
            // 
            this.UpDown2.Location = new System.Drawing.Point(633, 67);
            this.UpDown2.Name = "UpDown2";
            this.UpDown2.Size = new System.Drawing.Size(53, 20);
            this.UpDown2.TabIndex = 8;
            this.UpDown2.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            // 
            // UpDown1
            // 
            this.UpDown1.Location = new System.Drawing.Point(633, 30);
            this.UpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UpDown1.Name = "UpDown1";
            this.UpDown1.Size = new System.Drawing.Size(53, 20);
            this.UpDown1.TabIndex = 7;
            this.UpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // cb2
            // 
            this.cb2.Appearance = System.Windows.Forms.Appearance.Button;
            this.cb2.BackColor = System.Drawing.Color.White;
            this.cb2.Location = new System.Drawing.Point(284, 42);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(92, 44);
            this.cb2.TabIndex = 4;
            this.cb2.Text = "Редактировать вопрос";
            this.cb2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb2.UseVisualStyleBackColor = false;
            this.cb2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // cb1
            // 
            this.cb1.AutoSize = true;
            this.cb1.Location = new System.Drawing.Point(412, 49);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(64, 17);
            this.cb1.TabIndex = 3;
            this.cb1.Text = "Правда";
            this.cb1.UseVisualStyleBackColor = true;
            // 
            // DelBut
            // 
            this.DelBut.BackColor = System.Drawing.Color.White;
            this.DelBut.Location = new System.Drawing.Point(161, 42);
            this.DelBut.Name = "DelBut";
            this.DelBut.Size = new System.Drawing.Size(94, 45);
            this.DelBut.TabIndex = 1;
            this.DelBut.Text = "Удалить вопрос";
            this.DelBut.UseVisualStyleBackColor = false;
            this.DelBut.Click += new System.EventHandler(this.DelBut_Click);
            // 
            // AddBut
            // 
            this.AddBut.BackColor = System.Drawing.Color.White;
            this.AddBut.Location = new System.Drawing.Point(43, 42);
            this.AddBut.Name = "AddBut";
            this.AddBut.Size = new System.Drawing.Size(94, 45);
            this.AddBut.TabIndex = 0;
            this.AddBut.Text = "Добавить вопрос";
            this.AddBut.UseVisualStyleBackColor = false;
            this.AddBut.Click += new System.EventHandler(this.AddBut_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.FinBut);
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Controls.Add(this.cb3);
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(0, 334);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 113);
            this.panel2.TabIndex = 5;
            // 
            // FinBut
            // 
            this.FinBut.BackColor = System.Drawing.Color.Red;
            this.FinBut.Location = new System.Drawing.Point(680, 35);
            this.FinBut.Name = "FinBut";
            this.FinBut.Size = new System.Drawing.Size(75, 46);
            this.FinBut.TabIndex = 8;
            this.FinBut.Text = "Закончить";
            this.FinBut.UseVisualStyleBackColor = false;
            this.FinBut.Visible = false;
            this.FinBut.Click += new System.EventHandler(this.FinBut_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2.Location = new System.Drawing.Point(416, 57);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(79, 20);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "не верю";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Click += new System.EventHandler(this.AnsBut_Click);
            // 
            // cb3
            // 
            this.cb3.AutoSize = true;
            this.cb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb3.Location = new System.Drawing.Point(416, 34);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(60, 20);
            this.cb3.TabIndex = 6;
            this.cb3.TabStop = true;
            this.cb3.Text = "верю";
            this.cb3.UseVisualStyleBackColor = true;
            this.cb3.Click += new System.EventHandler(this.AnsBut_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 90);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(800, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(40, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(362, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 53);
            this.button2.TabIndex = 1;
            this.button2.Text = "<==";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(515, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "==>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Верю-не верю";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem NN1;
        private System.Windows.Forms.ToolStripMenuItem N1;
        private System.Windows.Forms.ToolStripMenuItem N2;
        private System.Windows.Forms.ToolStripMenuItem N3;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem N4;
        private System.Windows.Forms.ToolStripMenuItem режимToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem N5;
        private System.Windows.Forms.ToolStripMenuItem N6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cb1;
        private System.Windows.Forms.Button DelBut;
        private System.Windows.Forms.Button AddBut;
        private System.Windows.Forms.CheckBox cb2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown UpDown2;
        private System.Windows.Forms.NumericUpDown UpDown1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton cb3;
        private System.Windows.Forms.Button FinBut;
        private System.Windows.Forms.ToolStripMenuItem About;
        private System.Windows.Forms.ToolStripMenuItem N8;
        private System.Windows.Forms.ToolStripMenuItem N9;
    }
}

