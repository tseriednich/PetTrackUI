namespace PetTrackUI
{
    partial class AktiviteDuzenleForm
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
            AktiviteDuzenlePnl = new ReaLTaiizor.Controls.Panel();
            label4 = new Label();
            numericUpDown1 = new NumericUpDown();
            dateTimePicker1 = new DateTimePicker();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            textBox3 = new TextBox();
            label6 = new Label();
            label3 = new Label();
            label1 = new Label();
            label9 = new Label();
            label2 = new Label();
            button3 = new ReaLTaiizor.Controls.Button();
            button1 = new ReaLTaiizor.Controls.Button();
            AktiviteDuzenlePnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // AktiviteDuzenlePnl
            // 
            AktiviteDuzenlePnl.BackColor = SystemColors.ButtonFace;
            AktiviteDuzenlePnl.Controls.Add(label4);
            AktiviteDuzenlePnl.Controls.Add(numericUpDown1);
            AktiviteDuzenlePnl.Controls.Add(dateTimePicker1);
            AktiviteDuzenlePnl.Controls.Add(comboBox2);
            AktiviteDuzenlePnl.Controls.Add(comboBox1);
            AktiviteDuzenlePnl.Controls.Add(textBox3);
            AktiviteDuzenlePnl.Controls.Add(label6);
            AktiviteDuzenlePnl.Controls.Add(label3);
            AktiviteDuzenlePnl.Controls.Add(label1);
            AktiviteDuzenlePnl.Controls.Add(label9);
            AktiviteDuzenlePnl.Controls.Add(label2);
            AktiviteDuzenlePnl.EdgeColor = Color.White;
            AktiviteDuzenlePnl.Location = new Point(18, 11);
            AktiviteDuzenlePnl.Margin = new Padding(3, 2, 3, 2);
            AktiviteDuzenlePnl.Name = "AktiviteDuzenlePnl";
            AktiviteDuzenlePnl.Padding = new Padding(4, 4, 4, 4);
            AktiviteDuzenlePnl.Size = new Size(534, 322);
            AktiviteDuzenlePnl.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            AktiviteDuzenlePnl.TabIndex = 8;
            AktiviteDuzenlePnl.Text = "panel2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(18, 167);
            label4.Name = "label4";
            label4.Size = new Size(40, 19);
            label4.TabIndex = 20;
            label4.Text = "Süre:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(136, 166);
            numericUpDown1.Margin = new Padding(3, 2, 3, 2);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(35, 23);
            numericUpDown1.TabIndex = 19;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Checked = false;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(136, 129);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(228, 23);
            dateTimePicker1.TabIndex = 0;
            dateTimePicker1.Value = new DateTime(2025, 11, 21, 3, 35, 0, 0);
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Yürüyüş", "", "", "Oyun", "", "", "Mama", "İlaç", "Aşı", "Muayene", "", "", "Eğitim" });
            comboBox2.Location = new Point(136, 88);
            comboBox2.Margin = new Padding(3, 2, 3, 2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(228, 23);
            comboBox2.TabIndex = 18;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(136, 54);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(228, 23);
            comboBox1.TabIndex = 17;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(136, 205);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(228, 70);
            textBox3.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(18, 92);
            label6.Name = "label6";
            label6.Size = new Size(92, 19);
            label6.TabIndex = 13;
            label6.Text = "Aktivite Türü:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(18, 205);
            label3.Name = "label3";
            label3.Size = new Size(53, 19);
            label3.TabIndex = 10;
            label3.Text = "Notlar:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(18, 130);
            label1.Name = "label1";
            label1.Size = new Size(92, 19);
            label1.TabIndex = 9;
            label1.Text = "Tarih ve Saat:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label9.ForeColor = SystemColors.ControlText;
            label9.Location = new Point(18, 55);
            label9.Name = "label9";
            label9.Size = new Size(58, 19);
            label9.TabIndex = 8;
            label9.Text = "Hayvan:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonFace;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.Location = new Point(18, 15);
            label2.Name = "label2";
            label2.Size = new Size(157, 25);
            label2.TabIndex = 7;
            label2.Text = "Aktivite Düzenle";
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Highlight;
            button3.BorderColor = SystemColors.Control;
            button3.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            button3.EnteredColor = Color.White;
            button3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            button3.Image = null;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.InactiveColor = Color.DarkGray;
            button3.Location = new Point(326, 341);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.PressedBorderColor = SystemColors.Control;
            button3.PressedColor = Color.FromArgb(165, 37, 37);
            button3.Size = new Size(105, 30);
            button3.TabIndex = 24;
            button3.Text = "İptal";
            button3.TextAlignment = StringAlignment.Center;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.BorderColor = SystemColors.Control;
            button1.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            button1.EnteredColor = Color.White;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            button1.Image = null;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.InactiveColor = SystemColors.MenuHighlight;
            button1.Location = new Point(446, 341);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.PressedBorderColor = SystemColors.Control;
            button1.PressedColor = Color.FromArgb(165, 37, 37);
            button1.Size = new Size(105, 30);
            button1.TabIndex = 25;
            button1.Text = "Güncelle";
            button1.TextAlignment = StringAlignment.Center;
            // 
            // AktiviteDuzenleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(569, 375);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(AktiviteDuzenlePnl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "AktiviteDuzenleForm";
            Text = "AktiviteDuzenleForm";
            AktiviteDuzenlePnl.ResumeLayout(false);
            AktiviteDuzenlePnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.Panel AktiviteDuzenlePnl;
        private Label label4;
        private NumericUpDown numericUpDown1;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private TextBox textBox3;
        private Label label6;
        private Label label3;
        private Label label1;
        private Label label9;
        private Label label2;
        private ReaLTaiizor.Controls.Button button3;
        private ReaLTaiizor.Controls.Button button1;
    }
}