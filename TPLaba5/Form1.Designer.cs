using System.Windows.Forms;

namespace TP5_2
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
            this.NumTrackBar = new System.Windows.Forms.TrackBar();
            this.NumLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.N5GroupBox = new System.Windows.Forms.GroupBox();
            this.Ny5TB = new System.Windows.Forms.TextBox();
            this.Hy5TB = new System.Windows.Forms.TextBox();
            this.Y05TB = new System.Windows.Forms.TextBox();
            this.Nx5TB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.N4GroupBox = new System.Windows.Forms.GroupBox();
            this.Ny4TB = new System.Windows.Forms.TextBox();
            this.Hy4TB = new System.Windows.Forms.TextBox();
            this.Y04TB = new System.Windows.Forms.TextBox();
            this.Nx4TB = new System.Windows.Forms.TextBox();
            this.N3GroupBox = new System.Windows.Forms.GroupBox();
            this.Ny3TB = new System.Windows.Forms.TextBox();
            this.Hy3TB = new System.Windows.Forms.TextBox();
            this.Y03TB = new System.Windows.Forms.TextBox();
            this.Nx3TB = new System.Windows.Forms.TextBox();
            this.N2GroupBox = new System.Windows.Forms.GroupBox();
            this.Ny2TB = new System.Windows.Forms.TextBox();
            this.Hy2TB = new System.Windows.Forms.TextBox();
            this.Y02TB = new System.Windows.Forms.TextBox();
            this.Nx2TB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.N1GroupBox = new System.Windows.Forms.GroupBox();
            this.Ny1TB = new System.Windows.Forms.TextBox();
            this.Hy1TB = new System.Windows.Forms.TextBox();
            this.Y01TB = new System.Windows.Forms.TextBox();
            this.Nx1TB = new System.Windows.Forms.TextBox();
            this.EquButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ReadButton = new System.Windows.Forms.Button();
            this.MonitorListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumTrackBar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.N5GroupBox.SuspendLayout();
            this.N4GroupBox.SuspendLayout();
            this.N3GroupBox.SuspendLayout();
            this.N2GroupBox.SuspendLayout();
            this.N1GroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // NumTrackBar
            // 
            this.NumTrackBar.BackColor = System.Drawing.Color.LemonChiffon;
            this.NumTrackBar.Location = new System.Drawing.Point(10, 28);
            this.NumTrackBar.Maximum = 5;
            this.NumTrackBar.Minimum = 1;
            this.NumTrackBar.Name = "NumTrackBar";
            this.NumTrackBar.Size = new System.Drawing.Size(161, 45);
            this.NumTrackBar.TabIndex = 0;
            this.NumTrackBar.Value = 1;
            this.NumTrackBar.ValueChanged += new System.EventHandler(this.NumTrackBar_ValueChanged);
            // 
            // NumLabel
            // 
            this.NumLabel.AutoSize = true;
            this.NumLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumLabel.Location = new System.Drawing.Point(177, 29);
            this.NumLabel.Name = "NumLabel";
            this.NumLabel.Size = new System.Drawing.Size(23, 28);
            this.NumLabel.TabIndex = 1;
            this.NumLabel.Text = "1";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.N5GroupBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.N4GroupBox);
            this.groupBox1.Controls.Add(this.N3GroupBox);
            this.groupBox1.Controls.Add(this.N2GroupBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.N1GroupBox);
            this.groupBox1.Location = new System.Drawing.Point(224, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 201);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Исходные данные";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nx";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ny";
            // 
            // N5GroupBox
            // 
            this.N5GroupBox.Controls.Add(this.Ny5TB);
            this.N5GroupBox.Controls.Add(this.Hy5TB);
            this.N5GroupBox.Controls.Add(this.Y05TB);
            this.N5GroupBox.Controls.Add(this.Nx5TB);
            this.N5GroupBox.Location = new System.Drawing.Point(317, 32);
            this.N5GroupBox.Name = "N5GroupBox";
            this.N5GroupBox.Size = new System.Drawing.Size(66, 147);
            this.N5GroupBox.TabIndex = 12;
            this.N5GroupBox.TabStop = false;
            this.N5GroupBox.Text = "Набор 5";
            this.N5GroupBox.Visible = false;
            // 
            // Ny5TB
            // 
            this.Ny5TB.BackColor = System.Drawing.Color.LightCyan;
            this.Ny5TB.Location = new System.Drawing.Point(15, 55);
            this.Ny5TB.Name = "Ny5TB";
            this.Ny5TB.Size = new System.Drawing.Size(36, 23);
            this.Ny5TB.TabIndex = 8;
            // 
            // Hy5TB
            // 
            this.Hy5TB.BackColor = System.Drawing.Color.LightCyan;
            this.Hy5TB.Location = new System.Drawing.Point(15, 84);
            this.Hy5TB.Name = "Hy5TB";
            this.Hy5TB.Size = new System.Drawing.Size(36, 23);
            this.Hy5TB.TabIndex = 7;
            // 
            // Y05TB
            // 
            this.Y05TB.BackColor = System.Drawing.Color.LightCyan;
            this.Y05TB.Location = new System.Drawing.Point(15, 113);
            this.Y05TB.Name = "Y05TB";
            this.Y05TB.Size = new System.Drawing.Size(36, 23);
            this.Y05TB.TabIndex = 6;
            // 
            // Nx5TB
            // 
            this.Nx5TB.BackColor = System.Drawing.Color.LightCyan;
            this.Nx5TB.Location = new System.Drawing.Point(15, 26);
            this.Nx5TB.Name = "Nx5TB";
            this.Nx5TB.Size = new System.Drawing.Size(36, 23);
            this.Nx5TB.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Y0";
            // 
            // N4GroupBox
            // 
            this.N4GroupBox.Controls.Add(this.Ny4TB);
            this.N4GroupBox.Controls.Add(this.Hy4TB);
            this.N4GroupBox.Controls.Add(this.Y04TB);
            this.N4GroupBox.Controls.Add(this.Nx4TB);
            this.N4GroupBox.Location = new System.Drawing.Point(245, 32);
            this.N4GroupBox.Name = "N4GroupBox";
            this.N4GroupBox.Size = new System.Drawing.Size(66, 147);
            this.N4GroupBox.TabIndex = 14;
            this.N4GroupBox.TabStop = false;
            this.N4GroupBox.Text = "Набор 4";
            this.N4GroupBox.Visible = false;
            // 
            // Ny4TB
            // 
            this.Ny4TB.BackColor = System.Drawing.Color.LightCyan;
            this.Ny4TB.Location = new System.Drawing.Point(15, 55);
            this.Ny4TB.Name = "Ny4TB";
            this.Ny4TB.Size = new System.Drawing.Size(36, 23);
            this.Ny4TB.TabIndex = 8;
            // 
            // Hy4TB
            // 
            this.Hy4TB.BackColor = System.Drawing.Color.LightCyan;
            this.Hy4TB.Location = new System.Drawing.Point(15, 84);
            this.Hy4TB.Name = "Hy4TB";
            this.Hy4TB.Size = new System.Drawing.Size(36, 23);
            this.Hy4TB.TabIndex = 7;
            // 
            // Y04TB
            // 
            this.Y04TB.BackColor = System.Drawing.Color.LightCyan;
            this.Y04TB.Location = new System.Drawing.Point(15, 113);
            this.Y04TB.Name = "Y04TB";
            this.Y04TB.Size = new System.Drawing.Size(36, 23);
            this.Y04TB.TabIndex = 6;
            // 
            // Nx4TB
            // 
            this.Nx4TB.BackColor = System.Drawing.Color.LightCyan;
            this.Nx4TB.Location = new System.Drawing.Point(15, 26);
            this.Nx4TB.Name = "Nx4TB";
            this.Nx4TB.Size = new System.Drawing.Size(36, 23);
            this.Nx4TB.TabIndex = 5;
            // 
            // N3GroupBox
            // 
            this.N3GroupBox.Controls.Add(this.Ny3TB);
            this.N3GroupBox.Controls.Add(this.Hy3TB);
            this.N3GroupBox.Controls.Add(this.Y03TB);
            this.N3GroupBox.Controls.Add(this.Nx3TB);
            this.N3GroupBox.Location = new System.Drawing.Point(173, 32);
            this.N3GroupBox.Name = "N3GroupBox";
            this.N3GroupBox.Size = new System.Drawing.Size(66, 147);
            this.N3GroupBox.TabIndex = 13;
            this.N3GroupBox.TabStop = false;
            this.N3GroupBox.Text = "Набор 3";
            this.N3GroupBox.Visible = false;
            // 
            // Ny3TB
            // 
            this.Ny3TB.BackColor = System.Drawing.Color.LightCyan;
            this.Ny3TB.Location = new System.Drawing.Point(15, 55);
            this.Ny3TB.Name = "Ny3TB";
            this.Ny3TB.Size = new System.Drawing.Size(36, 23);
            this.Ny3TB.TabIndex = 8;
            // 
            // Hy3TB
            // 
            this.Hy3TB.BackColor = System.Drawing.Color.LightCyan;
            this.Hy3TB.Location = new System.Drawing.Point(15, 84);
            this.Hy3TB.Name = "Hy3TB";
            this.Hy3TB.Size = new System.Drawing.Size(36, 23);
            this.Hy3TB.TabIndex = 7;
            // 
            // Y03TB
            // 
            this.Y03TB.BackColor = System.Drawing.Color.LightCyan;
            this.Y03TB.Location = new System.Drawing.Point(15, 113);
            this.Y03TB.Name = "Y03TB";
            this.Y03TB.Size = new System.Drawing.Size(36, 23);
            this.Y03TB.TabIndex = 6;
            // 
            // Nx3TB
            // 
            this.Nx3TB.BackColor = System.Drawing.Color.LightCyan;
            this.Nx3TB.Location = new System.Drawing.Point(15, 26);
            this.Nx3TB.Name = "Nx3TB";
            this.Nx3TB.Size = new System.Drawing.Size(36, 23);
            this.Nx3TB.TabIndex = 5;
            // 
            // N2GroupBox
            // 
            this.N2GroupBox.Controls.Add(this.Ny2TB);
            this.N2GroupBox.Controls.Add(this.Hy2TB);
            this.N2GroupBox.Controls.Add(this.Y02TB);
            this.N2GroupBox.Controls.Add(this.Nx2TB);
            this.N2GroupBox.Location = new System.Drawing.Point(101, 32);
            this.N2GroupBox.Name = "N2GroupBox";
            this.N2GroupBox.Size = new System.Drawing.Size(66, 147);
            this.N2GroupBox.TabIndex = 12;
            this.N2GroupBox.TabStop = false;
            this.N2GroupBox.Text = "Набор 2";
            this.N2GroupBox.Visible = false;
            // 
            // Ny2TB
            // 
            this.Ny2TB.BackColor = System.Drawing.Color.LightCyan;
            this.Ny2TB.Location = new System.Drawing.Point(15, 55);
            this.Ny2TB.Name = "Ny2TB";
            this.Ny2TB.Size = new System.Drawing.Size(36, 23);
            this.Ny2TB.TabIndex = 8;
            // 
            // Hy2TB
            // 
            this.Hy2TB.BackColor = System.Drawing.Color.LightCyan;
            this.Hy2TB.Location = new System.Drawing.Point(15, 84);
            this.Hy2TB.Name = "Hy2TB";
            this.Hy2TB.Size = new System.Drawing.Size(36, 23);
            this.Hy2TB.TabIndex = 7;
            // 
            // Y02TB
            // 
            this.Y02TB.BackColor = System.Drawing.Color.LightCyan;
            this.Y02TB.Location = new System.Drawing.Point(15, 113);
            this.Y02TB.Name = "Y02TB";
            this.Y02TB.Size = new System.Drawing.Size(36, 23);
            this.Y02TB.TabIndex = 6;
            // 
            // Nx2TB
            // 
            this.Nx2TB.BackColor = System.Drawing.Color.LightCyan;
            this.Nx2TB.Location = new System.Drawing.Point(15, 26);
            this.Nx2TB.Name = "Nx2TB";
            this.Nx2TB.Size = new System.Drawing.Size(36, 23);
            this.Nx2TB.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hy";
            // 
            // N1GroupBox
            // 
            this.N1GroupBox.Controls.Add(this.Ny1TB);
            this.N1GroupBox.Controls.Add(this.Hy1TB);
            this.N1GroupBox.Controls.Add(this.Y01TB);
            this.N1GroupBox.Controls.Add(this.Nx1TB);
            this.N1GroupBox.Location = new System.Drawing.Point(32, 32);
            this.N1GroupBox.Name = "N1GroupBox";
            this.N1GroupBox.Size = new System.Drawing.Size(66, 147);
            this.N1GroupBox.TabIndex = 11;
            this.N1GroupBox.TabStop = false;
            this.N1GroupBox.Text = "Набор 1";
            // 
            // Ny1TB
            // 
            this.Ny1TB.BackColor = System.Drawing.Color.LightCyan;
            this.Ny1TB.Location = new System.Drawing.Point(15, 55);
            this.Ny1TB.Name = "Ny1TB";
            this.Ny1TB.Size = new System.Drawing.Size(36, 23);
            this.Ny1TB.TabIndex = 8;
            // 
            // Hy1TB
            // 
            this.Hy1TB.BackColor = System.Drawing.Color.LightCyan;
            this.Hy1TB.Location = new System.Drawing.Point(15, 84);
            this.Hy1TB.Name = "Hy1TB";
            this.Hy1TB.Size = new System.Drawing.Size(36, 23);
            this.Hy1TB.TabIndex = 7;
            // 
            // Y01TB
            // 
            this.Y01TB.BackColor = System.Drawing.Color.LightCyan;
            this.Y01TB.Location = new System.Drawing.Point(15, 113);
            this.Y01TB.Name = "Y01TB";
            this.Y01TB.Size = new System.Drawing.Size(36, 23);
            this.Y01TB.TabIndex = 6;
            // 
            // Nx1TB
            // 
            this.Nx1TB.BackColor = System.Drawing.Color.LightCyan;
            this.Nx1TB.Location = new System.Drawing.Point(15, 26);
            this.Nx1TB.Name = "Nx1TB";
            this.Nx1TB.Size = new System.Drawing.Size(36, 23);
            this.Nx1TB.TabIndex = 5;
            // 
            // EquButton
            // 
            this.EquButton.BackColor = System.Drawing.Color.Pink;
            this.EquButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EquButton.Location = new System.Drawing.Point(12, 94);
            this.EquButton.Name = "EquButton";
            this.EquButton.Size = new System.Drawing.Size(95, 28);
            this.EquButton.TabIndex = 4;
            this.EquButton.Text = "Рассчитать ";
            this.EquButton.UseVisualStyleBackColor = false;
            this.EquButton.Click += new System.EventHandler(this.EquButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NumTrackBar);
            this.groupBox2.Controls.Add(this.NumLabel);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(205, 76);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Количество наборов";
            // 
            // ReadButton
            // 
            this.ReadButton.BackColor = System.Drawing.Color.Pink;
            this.ReadButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ReadButton.Location = new System.Drawing.Point(122, 94);
            this.ReadButton.Name = "ReadButton";
            this.ReadButton.Size = new System.Drawing.Size(95, 28);
            this.ReadButton.TabIndex = 6;
            this.ReadButton.Text = "Из файла";
            this.ReadButton.UseVisualStyleBackColor = false;
            this.ReadButton.Click += new System.EventHandler(this.ReadButton_Click);
            // 
            // MonitorListBox
            // 
            this.MonitorListBox.BackColor = System.Drawing.Color.LightCyan;
            this.MonitorListBox.FormattingEnabled = true;
            this.MonitorListBox.ItemHeight = 15;
            this.MonitorListBox.Location = new System.Drawing.Point(12, 219);
            this.MonitorListBox.Name = "MonitorListBox";
            this.MonitorListBox.Size = new System.Drawing.Size(614, 169);
            this.MonitorListBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(638, 405);
            this.Controls.Add(this.MonitorListBox);
            this.Controls.Add(this.ReadButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.EquButton);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Лаба 5";
            ((System.ComponentModel.ISupportInitialize)(this.NumTrackBar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.N5GroupBox.ResumeLayout(false);
            this.N5GroupBox.PerformLayout();
            this.N4GroupBox.ResumeLayout(false);
            this.N4GroupBox.PerformLayout();
            this.N3GroupBox.ResumeLayout(false);
            this.N3GroupBox.PerformLayout();
            this.N2GroupBox.ResumeLayout(false);
            this.N2GroupBox.PerformLayout();
            this.N1GroupBox.ResumeLayout(false);
            this.N1GroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TrackBar NumTrackBar;
        private Label NumLabel;
        private GroupBox groupBox1;
        private GroupBox N5GroupBox;
        private TextBox Ny5TB;
        private TextBox Hy5TB;
        private TextBox Y05TB;
        private TextBox Nx5TB;
        private GroupBox N4GroupBox;
        private TextBox Ny4TB;
        private TextBox Hy4TB;
        private TextBox Y04TB;
        private TextBox Nx4TB;
        private GroupBox N3GroupBox;
        private TextBox Ny3TB;
        private TextBox Hy3TB;
        private TextBox Y03TB;
        private TextBox Nx3TB;
        private GroupBox N2GroupBox;
        private TextBox Ny2TB;
        private TextBox Hy2TB;
        private TextBox Y02TB;
        private TextBox Nx2TB;
        private GroupBox N1GroupBox;
        private Label label1;
        private Label label2;
        private TextBox Ny1TB;
        private Label label3;
        private TextBox Hy1TB;
        private TextBox Y01TB;
        private Label label5;
        private TextBox Nx1TB;
        private Button EquButton;
        private GroupBox groupBox2;
        private Button ReadButton;
        private ListBox MonitorListBox;
    }
}