namespace TPLaba8
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            this.DataListBox = new System.Windows.Forms.ListBox();
            this.NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.FilterTextBox = new System.Windows.Forms.TextBox();
            this.FilterButton = new System.Windows.Forms.Button();
            this.GetDataButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.GreenButton2 = new System.Windows.Forms.Button();
            this.YellowButton2 = new System.Windows.Forms.Button();
            this.RedButton2 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.GreenButton1 = new System.Windows.Forms.Button();
            this.YellowButton1 = new System.Windows.Forms.Button();
            this.RedButton1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CheckBox2 = new System.Windows.Forms.CheckBox();
            this.СheckBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RadioButton2_1 = new System.Windows.Forms.RadioButton();
            this.RadioButton2_2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RadioButton1_1 = new System.Windows.Forms.RadioButton();
            this.RadioButton1_2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataListBox
            // 
            this.DataListBox.FormattingEnabled = true;
            this.DataListBox.ItemHeight = 15;
            this.DataListBox.Location = new System.Drawing.Point(6, 6);
            this.DataListBox.Name = "DataListBox";
            this.DataListBox.Size = new System.Drawing.Size(139, 154);
            this.DataListBox.TabIndex = 0;
            // 
            // NumericUpDown
            // 
            this.NumericUpDown.Location = new System.Drawing.Point(6, 166);
            this.NumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDown.Name = "NumericUpDown";
            this.NumericUpDown.Size = new System.Drawing.Size(139, 23);
            this.NumericUpDown.TabIndex = 3;
            this.NumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(432, 277);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.FilterTextBox);
            this.tabPage1.Controls.Add(this.FilterButton);
            this.tabPage1.Controls.Add(this.DataListBox);
            this.tabPage1.Controls.Add(this.GetDataButton);
            this.tabPage1.Controls.Add(this.NumericUpDown);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(424, 249);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Данные";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // FilterTextBox
            // 
            this.FilterTextBox.Location = new System.Drawing.Point(206, 15);
            this.FilterTextBox.Multiline = true;
            this.FilterTextBox.Name = "FilterTextBox";
            this.FilterTextBox.Size = new System.Drawing.Size(139, 50);
            this.FilterTextBox.TabIndex = 5;
            // 
            // FilterButton
            // 
            this.FilterButton.Location = new System.Drawing.Point(227, 71);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(102, 23);
            this.FilterButton.TabIndex = 4;
            this.FilterButton.Text = "Отфильтровать";
            this.FilterButton.UseVisualStyleBackColor = true;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // GetDataButton
            // 
            this.GetDataButton.Location = new System.Drawing.Point(6, 195);
            this.GetDataButton.Name = "GetDataButton";
            this.GetDataButton.Size = new System.Drawing.Size(139, 23);
            this.GetDataButton.TabIndex = 2;
            this.GetDataButton.Text = "Получить значения";
            this.GetDataButton.UseVisualStyleBackColor = true;
            this.GetDataButton.Click += new System.EventHandler(this.GetDataButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(424, 249);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Фильтр";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.GreenButton2);
            this.groupBox5.Controls.Add(this.YellowButton2);
            this.groupBox5.Controls.Add(this.RedButton2);
            this.groupBox5.Location = new System.Drawing.Point(133, 84);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(116, 114);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Цвет шрифта";
            // 
            // GreenButton2
            // 
            this.GreenButton2.BackColor = System.Drawing.Color.Green;
            this.GreenButton2.Location = new System.Drawing.Point(21, 80);
            this.GreenButton2.Name = "GreenButton2";
            this.GreenButton2.Size = new System.Drawing.Size(75, 23);
            this.GreenButton2.TabIndex = 2;
            this.GreenButton2.Text = "Зеленый";
            this.GreenButton2.UseVisualStyleBackColor = false;
            this.GreenButton2.Click += new System.EventHandler(this.GreenButton2_Click);
            // 
            // YellowButton2
            // 
            this.YellowButton2.BackColor = System.Drawing.Color.Yellow;
            this.YellowButton2.Location = new System.Drawing.Point(21, 51);
            this.YellowButton2.Name = "YellowButton2";
            this.YellowButton2.Size = new System.Drawing.Size(75, 23);
            this.YellowButton2.TabIndex = 1;
            this.YellowButton2.Text = "Желтый";
            this.YellowButton2.UseVisualStyleBackColor = false;
            this.YellowButton2.Click += new System.EventHandler(this.YellowButton2_Click);
            // 
            // RedButton2
            // 
            this.RedButton2.BackColor = System.Drawing.Color.Red;
            this.RedButton2.Location = new System.Drawing.Point(21, 22);
            this.RedButton2.Name = "RedButton2";
            this.RedButton2.Size = new System.Drawing.Size(75, 23);
            this.RedButton2.TabIndex = 0;
            this.RedButton2.Text = "Красный";
            this.RedButton2.UseVisualStyleBackColor = false;
            this.RedButton2.Click += new System.EventHandler(this.RedButton2_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.GreenButton1);
            this.groupBox4.Controls.Add(this.YellowButton1);
            this.groupBox4.Controls.Add(this.RedButton1);
            this.groupBox4.Location = new System.Drawing.Point(6, 84);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(116, 114);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Цвет фона";
            // 
            // GreenButton1
            // 
            this.GreenButton1.BackColor = System.Drawing.Color.Green;
            this.GreenButton1.Location = new System.Drawing.Point(21, 80);
            this.GreenButton1.Name = "GreenButton1";
            this.GreenButton1.Size = new System.Drawing.Size(75, 23);
            this.GreenButton1.TabIndex = 2;
            this.GreenButton1.Text = "Зеленый";
            this.GreenButton1.UseVisualStyleBackColor = false;
            this.GreenButton1.Click += new System.EventHandler(this.GreenButton1_Click);
            // 
            // YellowButton1
            // 
            this.YellowButton1.BackColor = System.Drawing.Color.Yellow;
            this.YellowButton1.Location = new System.Drawing.Point(21, 51);
            this.YellowButton1.Name = "YellowButton1";
            this.YellowButton1.Size = new System.Drawing.Size(75, 23);
            this.YellowButton1.TabIndex = 1;
            this.YellowButton1.Text = "Желтый";
            this.YellowButton1.UseVisualStyleBackColor = false;
            this.YellowButton1.Click += new System.EventHandler(this.YellowButton1_Click);
            // 
            // RedButton1
            // 
            this.RedButton1.BackColor = System.Drawing.Color.Red;
            this.RedButton1.Location = new System.Drawing.Point(21, 22);
            this.RedButton1.Name = "RedButton1";
            this.RedButton1.Size = new System.Drawing.Size(75, 23);
            this.RedButton1.TabIndex = 0;
            this.RedButton1.Text = "Красный";
            this.RedButton1.UseVisualStyleBackColor = false;
            this.RedButton1.Click += new System.EventHandler(this.RedButton1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CheckBox2);
            this.groupBox3.Controls.Add(this.СheckBox1);
            this.groupBox3.Location = new System.Drawing.Point(255, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(112, 72);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // CheckBox2
            // 
            this.CheckBox2.AutoSize = true;
            this.CheckBox2.Location = new System.Drawing.Point(15, 43);
            this.CheckBox2.Name = "CheckBox2";
            this.CheckBox2.Size = new System.Drawing.Size(81, 19);
            this.CheckBox2.TabIndex = 5;
            this.CheckBox2.Text = "Все числа";
            this.CheckBox2.UseVisualStyleBackColor = true;
            this.CheckBox2.CheckedChanged += new System.EventHandler(this.CheckBox2_CheckedChanged);
            // 
            // СheckBox1
            // 
            this.СheckBox1.AutoSize = true;
            this.СheckBox1.Location = new System.Drawing.Point(15, 18);
            this.СheckBox1.Name = "СheckBox1";
            this.СheckBox1.Size = new System.Drawing.Size(75, 19);
            this.СheckBox1.TabIndex = 6;
            this.СheckBox1.Text = "Нулевые";
            this.СheckBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RadioButton2_1);
            this.groupBox2.Controls.Add(this.RadioButton2_2);
            this.groupBox2.Location = new System.Drawing.Point(112, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(137, 72);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // RadioButton2_1
            // 
            this.RadioButton2_1.AutoSize = true;
            this.RadioButton2_1.Checked = true;
            this.RadioButton2_1.Location = new System.Drawing.Point(12, 18);
            this.RadioButton2_1.Name = "RadioButton2_1";
            this.RadioButton2_1.Size = new System.Drawing.Size(117, 19);
            this.RadioButton2_1.TabIndex = 0;
            this.RadioButton2_1.TabStop = true;
            this.RadioButton2_1.Text = "Положительные";
            this.RadioButton2_1.UseVisualStyleBackColor = true;
            // 
            // RadioButton2_2
            // 
            this.RadioButton2_2.AutoSize = true;
            this.RadioButton2_2.Location = new System.Drawing.Point(12, 43);
            this.RadioButton2_2.Name = "RadioButton2_2";
            this.RadioButton2_2.Size = new System.Drawing.Size(112, 19);
            this.RadioButton2_2.TabIndex = 1;
            this.RadioButton2_2.Text = "Отрицательные";
            this.RadioButton2_2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadioButton1_1);
            this.groupBox1.Controls.Add(this.RadioButton1_2);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(100, 72);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // RadioButton1_1
            // 
            this.RadioButton1_1.AutoSize = true;
            this.RadioButton1_1.Checked = true;
            this.RadioButton1_1.Location = new System.Drawing.Point(12, 18);
            this.RadioButton1_1.Name = "RadioButton1_1";
            this.RadioButton1_1.Size = new System.Drawing.Size(62, 19);
            this.RadioButton1_1.TabIndex = 0;
            this.RadioButton1_1.TabStop = true;
            this.RadioButton1_1.Text = "Целые";
            this.RadioButton1_1.UseVisualStyleBackColor = true;
            // 
            // RadioButton1_2
            // 
            this.RadioButton1_2.AutoSize = true;
            this.RadioButton1_2.Location = new System.Drawing.Point(12, 43);
            this.RadioButton1_2.Name = "RadioButton1_2";
            this.RadioButton1_2.Size = new System.Drawing.Size(75, 19);
            this.RadioButton1_2.TabIndex = 1;
            this.RadioButton1_2.Text = "Нецелые";
            this.RadioButton1_2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 298);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Фильтромашина";
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox DataListBox;
        private NumericUpDown NumericUpDown;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox groupBox1;
        private RadioButton RadioButton1_1;
        private RadioButton RadioButton1_2;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private RadioButton RadioButton2_1;
        private RadioButton RadioButton2_2;
        private CheckBox CheckBox2;
        private CheckBox СheckBox1;
        private Button FilterButton;
        private GroupBox groupBox5;
        private Button GreenButton2;
        private Button YellowButton2;
        private Button RedButton2;
        private GroupBox groupBox4;
        private Button GreenButton1;
        private Button YellowButton1;
        private Button RedButton1;
        private TextBox FilterTextBox;
        private Button GetDataButton;
    }
}