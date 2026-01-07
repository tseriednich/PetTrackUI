namespace PetTrackUI
{
    partial class HayvanEkleForm
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
            YenıHayvanEkle = new ReaLTaiizor.Controls.Panel();
            btnFotografSec = new ReaLTaiizor.Controls.Button();
            pbHayvanResim = new PictureBox();
            dtpDogumTarihi = new DateTimePicker();
            cmbCinsiyet = new ComboBox();
            cmbTur = new ComboBox();
            txtNotlar = new TextBox();
            txtIrk = new TextBox();
            txtHayvanAdi = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label9 = new Label();
            label2 = new Label();
            btnKaydet = new ReaLTaiizor.Controls.Button();
            btnIptal = new ReaLTaiizor.Controls.Button();
            YenıHayvanEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbHayvanResim).BeginInit();
            SuspendLayout();
            // 
            // YenıHayvanEkle
            // 
            YenıHayvanEkle.BackColor = SystemColors.ButtonFace;
            YenıHayvanEkle.Controls.Add(btnFotografSec);
            YenıHayvanEkle.Controls.Add(pbHayvanResim);
            YenıHayvanEkle.Controls.Add(dtpDogumTarihi);
            YenıHayvanEkle.Controls.Add(cmbCinsiyet);
            YenıHayvanEkle.Controls.Add(cmbTur);
            YenıHayvanEkle.Controls.Add(txtNotlar);
            YenıHayvanEkle.Controls.Add(txtIrk);
            YenıHayvanEkle.Controls.Add(txtHayvanAdi);
            YenıHayvanEkle.Controls.Add(label6);
            YenıHayvanEkle.Controls.Add(label5);
            YenıHayvanEkle.Controls.Add(label4);
            YenıHayvanEkle.Controls.Add(label3);
            YenıHayvanEkle.Controls.Add(label1);
            YenıHayvanEkle.Controls.Add(label9);
            YenıHayvanEkle.Controls.Add(label2);
            YenıHayvanEkle.EdgeColor = Color.White;
            YenıHayvanEkle.Location = new Point(21, 15);
            YenıHayvanEkle.Name = "YenıHayvanEkle";
            YenıHayvanEkle.Padding = new Padding(5, 5, 5, 5);
            YenıHayvanEkle.Size = new Size(610, 429);
            YenıHayvanEkle.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            YenıHayvanEkle.TabIndex = 5;
            YenıHayvanEkle.Text = "panel2";
            // 
            // btnFotografSec
            // 
            btnFotografSec.BackColor = SystemColors.Highlight;
            btnFotografSec.BorderColor = SystemColors.Control;
            btnFotografSec.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnFotografSec.EnteredColor = Color.White;
            btnFotografSec.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnFotografSec.Image = null;
            btnFotografSec.ImageAlign = ContentAlignment.MiddleLeft;
            btnFotografSec.InactiveColor = Color.DodgerBlue;
            btnFotografSec.Location = new Point(459, 171);
            btnFotografSec.Name = "btnFotografSec";
            btnFotografSec.PressedBorderColor = SystemColors.Control;
            btnFotografSec.PressedColor = Color.FromArgb(165, 37, 37);
            btnFotografSec.Size = new Size(120, 40);
            btnFotografSec.TabIndex = 20;
            btnFotografSec.Text = "Fotoğraf Ekle";
            btnFotografSec.TextAlignment = StringAlignment.Center;
            btnFotografSec.Click += btnFotografSec_Click;
            // 
            // pbHayvanResim
            // 
            pbHayvanResim.BackColor = SystemColors.ButtonShadow;
            pbHayvanResim.Location = new Point(459, 28);
            pbHayvanResim.Name = "pbHayvanResim";
            pbHayvanResim.Size = new Size(120, 120);
            pbHayvanResim.TabIndex = 19;
            pbHayvanResim.TabStop = false;
            // 
            // dtpDogumTarihi
            // 
            dtpDogumTarihi.Format = DateTimePickerFormat.Short;
            dtpDogumTarihi.Location = new Point(139, 269);
            dtpDogumTarihi.Name = "dtpDogumTarihi";
            dtpDogumTarihi.Size = new Size(260, 27);
            dtpDogumTarihi.TabIndex = 0;
            dtpDogumTarihi.Value = new DateTime(2025, 11, 21, 2, 44, 0, 0);
            // 
            // cmbCinsiyet
            // 
            cmbCinsiyet.FormattingEnabled = true;
            cmbCinsiyet.Items.AddRange(new object[] { "(Belirtilmedi)", "Dişi", "Erkek" });
            cmbCinsiyet.Location = new Point(139, 219);
            cmbCinsiyet.Name = "cmbCinsiyet";
            cmbCinsiyet.Size = new Size(260, 28);
            cmbCinsiyet.TabIndex = 18;
            // 
            // cmbTur
            // 
            cmbTur.FormattingEnabled = true;
            cmbTur.Items.AddRange(new object[] { "Kedi", "Köpek" });
            cmbTur.Location = new Point(139, 120);
            cmbTur.Name = "cmbTur";
            cmbTur.Size = new Size(260, 28);
            cmbTur.TabIndex = 17;
            // 
            // txtNotlar
            // 
            txtNotlar.Location = new Point(139, 320);
            txtNotlar.Multiline = true;
            txtNotlar.Name = "txtNotlar";
            txtNotlar.PlaceholderText = "Hayvan ile ilgili not ekleyebilirsiniz.";
            txtNotlar.Size = new Size(260, 92);
            txtNotlar.TabIndex = 16;
            // 
            // txtIrk
            // 
            txtIrk.Location = new Point(139, 171);
            txtIrk.Name = "txtIrk";
            txtIrk.PlaceholderText = "Hayvanın ırkını giriniz.";
            txtIrk.Size = new Size(260, 27);
            txtIrk.TabIndex = 15;
            // 
            // txtHayvanAdi
            // 
            txtHayvanAdi.Location = new Point(139, 73);
            txtHayvanAdi.Name = "txtHayvanAdi";
            txtHayvanAdi.PlaceholderText = "Hayvanın adını giriniz.";
            txtHayvanAdi.Size = new Size(260, 27);
            txtHayvanAdi.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(21, 120);
            label6.Name = "label6";
            label6.Size = new Size(39, 23);
            label6.TabIndex = 13;
            label6.Text = "Tür:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(21, 171);
            label5.Name = "label5";
            label5.Size = new Size(35, 23);
            label5.TabIndex = 12;
            label5.Text = "Irk:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(21, 219);
            label4.Name = "label4";
            label4.Size = new Size(74, 23);
            label4.TabIndex = 11;
            label4.Text = "Cinsiyet:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(21, 320);
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
            label1.Location = new Point(21, 269);
            label1.Name = "label1";
            label1.Size = new Size(116, 23);
            label1.TabIndex = 9;
            label1.Text = "Doğum Tarihi:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label9.ForeColor = SystemColors.ControlText;
            label9.Location = new Point(21, 73);
            label9.Name = "label9";
            label9.Size = new Size(103, 23);
            label9.TabIndex = 8;
            label9.Text = "Hayvan Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonFace;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.Location = new Point(21, 20);
            label2.Name = "label2";
            label2.Size = new Size(207, 32);
            label2.TabIndex = 7;
            label2.Text = "Yeni Hayvan Ekle";
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.DodgerBlue;
            btnKaydet.BorderColor = SystemColors.Control;
            btnKaydet.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnKaydet.EnteredColor = Color.White;
            btnKaydet.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnKaydet.Image = null;
            btnKaydet.ImageAlign = ContentAlignment.MiddleLeft;
            btnKaydet.InactiveColor = Color.DodgerBlue;
            btnKaydet.Location = new Point(510, 455);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.PressedBorderColor = SystemColors.Control;
            btnKaydet.PressedColor = Color.FromArgb(165, 37, 37);
            btnKaydet.Size = new Size(120, 40);
            btnKaydet.TabIndex = 21;
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
            btnIptal.TabIndex = 22;
            btnIptal.Text = "İptal";
            btnIptal.TextAlignment = StringAlignment.Center;
            btnIptal.Click += btnIptal_Click;
            // 
            // HayvanEkleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(650, 500);
            Controls.Add(btnIptal);
            Controls.Add(btnKaydet);
            Controls.Add(YenıHayvanEkle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "HayvanEkleForm";
            Text = "Hayvan Ekle";
            Load += HayvanEkleForm_Load;
            YenıHayvanEkle.ResumeLayout(false);
            YenıHayvanEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbHayvanResim).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.Panel YenıHayvanEkle;
        private Label label2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label9;
        private TextBox txtHayvanAdi;
        private TextBox txtNotlar;
        private TextBox txtIrk;
        private ComboBox cmbCinsiyet;
        private ComboBox cmbTur;
        private DateTimePicker dtpDogumTarihi;
        private PictureBox pbHayvanResim;
        private ReaLTaiizor.Controls.Button btnFotografSec;
        private ReaLTaiizor.Controls.Button btnKaydet;
        private ReaLTaiizor.Controls.Button btnIptal;
    }
}