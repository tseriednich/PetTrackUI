namespace PetTrackUI
{
    partial class AktiviteEkleForm
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
            AktiviteEklePnl = new ReaLTaiizor.Controls.Panel();
            label4 = new Label();
            nudSure = new NumericUpDown();
            dtpTarih = new DateTimePicker();
            cmbAktiviteTuru = new ComboBox();
            cmbHayvan = new ComboBox();
            txtNotlar = new TextBox();
            label6 = new Label();
            label3 = new Label();
            label1 = new Label();
            label9 = new Label();
            label2 = new Label();
            btnKaydet = new ReaLTaiizor.Controls.Button();
            btnIptal = new ReaLTaiizor.Controls.Button();
            AktiviteEklePnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSure).BeginInit();
            SuspendLayout();
            // 
            // AktiviteEklePnl
            // 
            AktiviteEklePnl.BackColor = SystemColors.ButtonFace;
            AktiviteEklePnl.Controls.Add(label4);
            AktiviteEklePnl.Controls.Add(nudSure);
            AktiviteEklePnl.Controls.Add(dtpTarih);
            AktiviteEklePnl.Controls.Add(cmbAktiviteTuru);
            AktiviteEklePnl.Controls.Add(cmbHayvan);
            AktiviteEklePnl.Controls.Add(txtNotlar);
            AktiviteEklePnl.Controls.Add(label6);
            AktiviteEklePnl.Controls.Add(label3);
            AktiviteEklePnl.Controls.Add(label1);
            AktiviteEklePnl.Controls.Add(label9);
            AktiviteEklePnl.Controls.Add(label2);
            AktiviteEklePnl.EdgeColor = Color.White;
            AktiviteEklePnl.Location = new Point(21, 15);
            AktiviteEklePnl.Name = "AktiviteEklePnl";
            AktiviteEklePnl.Padding = new Padding(5, 5, 5, 5);
            AktiviteEklePnl.Size = new Size(610, 429);
            AktiviteEklePnl.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            AktiviteEklePnl.TabIndex = 7;
            AktiviteEklePnl.Text = "panel2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(21, 221);
            label4.Name = "label4";
            label4.Size = new Size(110, 23);
            label4.TabIndex = 20;
            label4.Text = "Süre(dakika):";
            // 
            // nudSure
            // 
            nudSure.Location = new Point(155, 221);
            nudSure.Name = "nudSure";
            nudSure.Size = new Size(40, 27);
            nudSure.TabIndex = 19;
            // 
            // dtpTarih
            // 
            dtpTarih.Checked = false;
            dtpTarih.Format = DateTimePickerFormat.Short;
            dtpTarih.Location = new Point(155, 172);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(260, 27);
            dtpTarih.TabIndex = 0;
            dtpTarih.Value = new DateTime(2025, 11, 21, 3, 35, 0, 0);
            // 
            // cmbAktiviteTuru
            // 
            cmbAktiviteTuru.FormattingEnabled = true;
            cmbAktiviteTuru.Items.AddRange(new object[] { "Yürüyüş", "", "", "Oyun", "", "", "Mama", "İlaç", "Aşı", "Muayene", "", "", "Eğitim" });
            cmbAktiviteTuru.Location = new Point(155, 117);
            cmbAktiviteTuru.Name = "cmbAktiviteTuru";
            cmbAktiviteTuru.Size = new Size(260, 28);
            cmbAktiviteTuru.TabIndex = 18;
            // 
            // cmbHayvan
            // 
            cmbHayvan.FormattingEnabled = true;
            cmbHayvan.Location = new Point(155, 72);
            cmbHayvan.Name = "cmbHayvan";
            cmbHayvan.Size = new Size(260, 28);
            cmbHayvan.TabIndex = 17;
            // 
            // txtNotlar
            // 
            txtNotlar.Location = new Point(155, 273);
            txtNotlar.Multiline = true;
            txtNotlar.Name = "txtNotlar";
            txtNotlar.Size = new Size(260, 92);
            txtNotlar.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(21, 123);
            label6.Name = "label6";
            label6.Size = new Size(111, 23);
            label6.TabIndex = 13;
            label6.Text = "Aktivite Türü:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(21, 273);
            label3.Name = "label3";
            label3.Size = new Size(63, 23);
            label3.TabIndex = 10;
            label3.Text = "Notlar:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(21, 173);
            label1.Name = "label1";
            label1.Size = new Size(111, 23);
            label1.TabIndex = 9;
            label1.Text = "Tarih ve Saat:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label9.ForeColor = SystemColors.ControlText;
            label9.Location = new Point(21, 73);
            label9.Name = "label9";
            label9.Size = new Size(73, 23);
            label9.TabIndex = 8;
            label9.Text = "Hayvan:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonFace;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.Location = new Point(21, 20);
            label2.Name = "label2";
            label2.Size = new Size(155, 32);
            label2.TabIndex = 7;
            label2.Text = "Aktivite Ekle";
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = SystemColors.Highlight;
            btnKaydet.BorderColor = SystemColors.Control;
            btnKaydet.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnKaydet.EnteredColor = Color.White;
            btnKaydet.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnKaydet.Image = null;
            btnKaydet.ImageAlign = ContentAlignment.MiddleLeft;
            btnKaydet.InactiveColor = SystemColors.MenuHighlight;
            btnKaydet.Location = new Point(510, 455);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.PressedBorderColor = SystemColors.Control;
            btnKaydet.PressedColor = Color.FromArgb(165, 37, 37);
            btnKaydet.Size = new Size(120, 40);
            btnKaydet.TabIndex = 22;
            btnKaydet.Text = "Kaydet";
            btnKaydet.TextAlignment = StringAlignment.Center;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnIptal
            // 
            btnIptal.BackColor = SystemColors.Highlight;
            btnIptal.BorderColor = SystemColors.Control;
            btnIptal.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnIptal.EnteredColor = Color.White;
            btnIptal.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnIptal.Image = null;
            btnIptal.ImageAlign = ContentAlignment.MiddleLeft;
            btnIptal.InactiveColor = Color.DarkGray;
            btnIptal.Location = new Point(373, 455);
            btnIptal.Name = "btnIptal";
            btnIptal.PressedBorderColor = SystemColors.Control;
            btnIptal.PressedColor = Color.FromArgb(165, 37, 37);
            btnIptal.Size = new Size(120, 40);
            btnIptal.TabIndex = 23;
            btnIptal.Text = "İptal";
            btnIptal.TextAlignment = StringAlignment.Center;
            btnIptal.Click += btnIptal_Click;
            // 
            // AktiviteEkleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(650, 500);
            Controls.Add(btnIptal);
            Controls.Add(btnKaydet);
            Controls.Add(AktiviteEklePnl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AktiviteEkleForm";
            Text = "AktiviteEkleForm";
            Load += AktiviteEkleForm_Load;
            AktiviteEklePnl.ResumeLayout(false);
            AktiviteEklePnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSure).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.Panel AktiviteEklePnl;
        private DateTimePicker dtpTarih;
        private ComboBox cmbHayvan;
        private TextBox txtNotlar;
        private Label label6;
        private Label label3;
        private Label label1;
        private Label label9;
        private Label label2;
        private Label label4;
        private NumericUpDown nudSure;
        private ReaLTaiizor.Controls.Button btnKaydet;
        private ReaLTaiizor.Controls.Button btnIptal;
        private ComboBox cmbAktiviteTuru;
    }
}