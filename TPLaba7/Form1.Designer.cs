namespace TP_Laba7
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
            this.PhotoListBox = new System.Windows.Forms.ListBox();
            this.SumTextBox = new System.Windows.Forms.TextBox();
            this.NameComboBox = new System.Windows.Forms.ComboBox();
            this.LoadPhotoButton = new System.Windows.Forms.Button();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.PhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.SafeToFileButton = new System.Windows.Forms.Button();
            this.ReadFromFileButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CountLabel = new System.Windows.Forms.Label();
            this.OpenPhotoDialog = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ClearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PhotoListBox
            // 
            this.PhotoListBox.FormattingEnabled = true;
            this.PhotoListBox.HorizontalScrollbar = true;
            this.PhotoListBox.ItemHeight = 15;
            this.PhotoListBox.Location = new System.Drawing.Point(12, 117);
            this.PhotoListBox.Name = "PhotoListBox";
            this.PhotoListBox.Size = new System.Drawing.Size(120, 94);
            this.PhotoListBox.TabIndex = 0;
            this.PhotoListBox.Click += new System.EventHandler(this.PhotoListBox_Click);
            // 
            // SumTextBox
            // 
            this.SumTextBox.Location = new System.Drawing.Point(12, 71);
            this.SumTextBox.Name = "SumTextBox";
            this.SumTextBox.Size = new System.Drawing.Size(121, 23);
            this.SumTextBox.TabIndex = 1;
            this.SumTextBox.TextChanged += new System.EventHandler(this.SumTextBox_TextChanged);
            // 
            // NameComboBox
            // 
            this.NameComboBox.FormattingEnabled = true;
            this.NameComboBox.Location = new System.Drawing.Point(12, 27);
            this.NameComboBox.Name = "NameComboBox";
            this.NameComboBox.Size = new System.Drawing.Size(121, 23);
            this.NameComboBox.TabIndex = 2;
            this.NameComboBox.SelectedIndexChanged += new System.EventHandler(this.NameComboBox_SelectedIndexChanged);
            this.NameComboBox.TextChanged += new System.EventHandler(this.NameComboBox_TextChanged);
            // 
            // LoadPhotoButton
            // 
            this.LoadPhotoButton.Location = new System.Drawing.Point(12, 225);
            this.LoadPhotoButton.Name = "LoadPhotoButton";
            this.LoadPhotoButton.Size = new System.Drawing.Size(120, 23);
            this.LoadPhotoButton.TabIndex = 3;
            this.LoadPhotoButton.Text = "Загрузить фото";
            this.LoadPhotoButton.UseVisualStyleBackColor = true;
            this.LoadPhotoButton.Click += new System.EventHandler(this.LoadPhotoButton_Click);
            // 
            // AcceptButton
            // 
            this.AcceptButton.Enabled = false;
            this.AcceptButton.Location = new System.Drawing.Point(373, 27);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(140, 23);
            this.AcceptButton.TabIndex = 4;
            this.AcceptButton.Text = "Принять";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // PhotoPictureBox
            // 
            this.PhotoPictureBox.Location = new System.Drawing.Point(168, 27);
            this.PhotoPictureBox.Name = "PhotoPictureBox";
            this.PhotoPictureBox.Size = new System.Drawing.Size(175, 172);
            this.PhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PhotoPictureBox.TabIndex = 5;
            this.PhotoPictureBox.TabStop = false;
            // 
            // SafeToFileButton
            // 
            this.SafeToFileButton.Enabled = false;
            this.SafeToFileButton.Location = new System.Drawing.Point(373, 66);
            this.SafeToFileButton.Name = "SafeToFileButton";
            this.SafeToFileButton.Size = new System.Drawing.Size(140, 23);
            this.SafeToFileButton.TabIndex = 6;
            this.SafeToFileButton.Text = "Сохранить в файл";
            this.SafeToFileButton.UseVisualStyleBackColor = true;
            this.SafeToFileButton.Click += new System.EventHandler(this.SafeToFileButton_Click);
            // 
            // ReadFromFileButton
            // 
            this.ReadFromFileButton.Location = new System.Drawing.Point(373, 132);
            this.ReadFromFileButton.Name = "ReadFromFileButton";
            this.ReadFromFileButton.Size = new System.Drawing.Size(140, 23);
            this.ReadFromFileButton.TabIndex = 7;
            this.ReadFromFileButton.Text = "Считать из файла";
            this.ReadFromFileButton.UseVisualStyleBackColor = true;
            this.ReadFromFileButton.Click += new System.EventHandler(this.ReadFromFileButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Записей в базе:";
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Location = new System.Drawing.Point(256, 211);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(13, 15);
            this.CountLabel.TabIndex = 9;
            this.CountLabel.Text = "0";
            // 
            // OpenPhotoDialog
            // 
            this.OpenPhotoDialog.FileName = "OpenPhotoDialog";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Фотографии:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Сумма:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "ФИО:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(380, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "*примечание - ФИО необходимо вводить полностью через пробел";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(373, 95);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(134, 19);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Перезаписать файл";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(404, 176);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 15;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(530, 278);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReadFromFileButton);
            this.Controls.Add(this.SafeToFileButton);
            this.Controls.Add(this.PhotoPictureBox);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.LoadPhotoButton);
            this.Controls.Add(this.NameComboBox);
            this.Controls.Add(this.SumTextBox);
            this.Controls.Add(this.PhotoListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox PhotoListBox;
        private TextBox SumTextBox;
        private ComboBox NameComboBox;
        private Button LoadPhotoButton;
        private Button AcceptButton;
        private PictureBox PhotoPictureBox;
        private Button SafeToFileButton;
        private Button ReadFromFileButton;
        private Label label1;
        private Label CountLabel;
        private OpenFileDialog OpenPhotoDialog;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private CheckBox checkBox1;
        private Button ClearButton;
    }
}