namespace PetTrackUI
{
    partial class FrmHayvanKayitWizard
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
        /// Required method for Designer support - do not modify the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelStep1 = new ReaLTaiizor.Controls.PoisonPanel();
            cmbIrk = new ReaLTaiizor.Controls.PoisonComboBox();
            lblirk = new ReaLTaiizor.Controls.PoisonLabel();
            cmbTur = new ReaLTaiizor.Controls.PoisonComboBox();
            lblTur = new ReaLTaiizor.Controls.PoisonLabel();
            txtHayvanAdi = new ReaLTaiizor.Controls.PoisonTextBox();
            lblAd = new ReaLTaiizor.Controls.PoisonLabel();
            panelStep2 = new ReaLTaiizor.Controls.PoisonPanel();
            lblDogumTarihi = new ReaLTaiizor.Controls.PoisonLabel();
            dtpDogumTarihi = new ReaLTaiizor.Controls.PoisonDateTime();
            lblCins = new ReaLTaiizor.Controls.PoisonLabel();
            cmbCins = new ReaLTaiizor.Controls.PoisonComboBox();
            panelStep3 = new ReaLTaiizor.Controls.PoisonPanel();
            lblSahipAd = new ReaLTaiizor.Controls.PoisonLabel();
            txtSahipAd = new ReaLTaiizor.Controls.PoisonTextBox();
            lblNot = new ReaLTaiizor.Controls.PoisonLabel();
            txtNot = new ReaLTaiizor.Controls.PoisonTextBox();
            btnGeri = new ReaLTaiizor.Controls.PoisonButton();
            btnIleri = new ReaLTaiizor.Controls.PoisonButton();
            btnKaydet = new ReaLTaiizor.Controls.PoisonButton();
            panelStep1.SuspendLayout();
            panelStep2.SuspendLayout();
            panelStep3.SuspendLayout();
            SuspendLayout();
            // 
            // panelStep1
            // 
            panelStep1.Controls.Add(cmbIrk);
            panelStep1.Controls.Add(lblirk);
            panelStep1.Controls.Add(cmbTur);
            panelStep1.Controls.Add(lblTur);
            panelStep1.Controls.Add(txtHayvanAdi);
            panelStep1.Controls.Add(lblAd);
            panelStep1.HorizontalScrollbarBarColor = true;
            panelStep1.HorizontalScrollbarHighlightOnWheel = false;
            panelStep1.HorizontalScrollbarSize = 10;
            panelStep1.Location = new Point(50, 60);
            panelStep1.Name = "panelStep1";
            panelStep1.Size = new Size(700, 400);
            panelStep1.TabIndex = 0;
            panelStep1.VerticalScrollbarBarColor = true;
            panelStep1.VerticalScrollbarHighlightOnWheel = false;
            panelStep1.VerticalScrollbarSize = 10;
            panelStep1.Paint += panelStep1_Paint;
            // 
            // cmbIrk
            // 
            cmbIrk.FormattingEnabled = true;
            cmbIrk.ItemHeight = 24;
            cmbIrk.Location = new Point(210, 240);
            cmbIrk.Name = "cmbIrk";
            cmbIrk.Size = new Size(250, 30);
            cmbIrk.TabIndex = 7;
            cmbIrk.UseSelectable = true;
            // 
            // lblirk
            // 
            lblirk.AutoSize = true;
            lblirk.Location = new Point(70, 250);
            lblirk.Name = "lblirk";
            lblirk.Size = new Size(27, 20);
            lblirk.TabIndex = 6;
            lblirk.Text = "Irk:";
            lblirk.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbTur
            // 
            cmbTur.FormattingEnabled = true;
            cmbTur.ItemHeight = 24;
            cmbTur.Location = new Point(210, 160);
            cmbTur.Name = "cmbTur";
            cmbTur.Size = new Size(250, 30);
            cmbTur.TabIndex = 5;
            cmbTur.UseSelectable = true;
            cmbTur.SelectedIndexChanged += cmbTur_SelectedIndexChanged;
            // 
            // lblTur
            // 
            lblTur.AutoSize = true;
            lblTur.Location = new Point(70, 160);
            lblTur.Name = "lblTur";
            lblTur.Size = new Size(32, 20);
            lblTur.TabIndex = 4;
            lblTur.Text = "Tür:";
            lblTur.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtHayvanAdi
            // 
            // 
            // 
            // 
            txtHayvanAdi.CustomButton.Image = null;
            txtHayvanAdi.CustomButton.Location = new Point(222, 2);
            txtHayvanAdi.CustomButton.Name = "";
            txtHayvanAdi.CustomButton.Size = new Size(25, 25);
            txtHayvanAdi.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            txtHayvanAdi.CustomButton.TabIndex = 1;
            txtHayvanAdi.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            txtHayvanAdi.CustomButton.UseSelectable = true;
            txtHayvanAdi.CustomButton.Visible = false;
            txtHayvanAdi.Location = new Point(210, 80);
            txtHayvanAdi.MaxLength = 32767;
            txtHayvanAdi.Name = "txtHayvanAdi";
            txtHayvanAdi.PasswordChar = '\0';
            txtHayvanAdi.ScrollBars = ScrollBars.None;
            txtHayvanAdi.SelectedText = "";
            txtHayvanAdi.SelectionLength = 0;
            txtHayvanAdi.SelectionStart = 0;
            txtHayvanAdi.ShortcutsEnabled = true;
            txtHayvanAdi.Size = new Size(250, 30);
            txtHayvanAdi.TabIndex = 3;
            txtHayvanAdi.UseSelectable = true;
            txtHayvanAdi.WaterMarkColor = Color.FromArgb(109, 109, 109);
            txtHayvanAdi.WaterMarkFont = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new Point(70, 80);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(82, 20);
            lblAd.TabIndex = 2;
            lblAd.Text = "Hayvan Adı:";
            lblAd.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelStep2
            // 
            panelStep2.Controls.Add(lblDogumTarihi);
            panelStep2.Controls.Add(dtpDogumTarihi);
            panelStep2.Controls.Add(lblCins);
            panelStep2.Controls.Add(cmbCins);
            panelStep2.HorizontalScrollbarBarColor = true;
            panelStep2.HorizontalScrollbarHighlightOnWheel = false;
            panelStep2.HorizontalScrollbarSize = 10;
            panelStep2.Location = new Point(50, 60);
            panelStep2.Name = "panelStep2";
            panelStep2.Size = new Size(700, 400);
            panelStep2.TabIndex = 1;
            panelStep2.VerticalScrollbarBarColor = true;
            panelStep2.VerticalScrollbarHighlightOnWheel = false;
            panelStep2.VerticalScrollbarSize = 10;
            panelStep2.Visible = false;
            // 
            // lblDogumTarihi
            // 
            lblDogumTarihi.AutoSize = true;
            lblDogumTarihi.Location = new Point(64, 80);
            lblDogumTarihi.Name = "lblDogumTarihi";
            lblDogumTarihi.Size = new Size(94, 20);
            lblDogumTarihi.TabIndex = 8;
            lblDogumTarihi.Text = "Doğum Tarihi:";
            // 
            // dtpDogumTarihi
            // 
            dtpDogumTarihi.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Medium;
            dtpDogumTarihi.Format = DateTimePickerFormat.Short;
            dtpDogumTarihi.Location = new Point(210, 80);
            dtpDogumTarihi.MaxDate = new DateTime(2025, 11, 13, 0, 0, 0, 0);
            dtpDogumTarihi.MinDate = new DateTime(1990, 1, 1, 0, 0, 0, 0);
            dtpDogumTarihi.MinimumSize = new Size(0, 30);
            dtpDogumTarihi.Name = "dtpDogumTarihi";
            dtpDogumTarihi.Size = new Size(250, 30);
            dtpDogumTarihi.TabIndex = 9;
            dtpDogumTarihi.Value = new DateTime(2025, 11, 13, 0, 0, 0, 0);
            // 
            // lblCins
            // 
            lblCins.AutoSize = true;
            lblCins.Location = new Point(64, 160);
            lblCins.Name = "lblCins";
            lblCins.Size = new Size(60, 20);
            lblCins.TabIndex = 8;
            lblCins.Text = "Cinsiyet:";
            lblCins.Click += poisonLabel1_Click;
            // 
            // cmbCins
            // 
            cmbCins.FormattingEnabled = true;
            cmbCins.ItemHeight = 24;
            cmbCins.Location = new Point(210, 160);
            cmbCins.Name = "cmbCins";
            cmbCins.Size = new Size(250, 30);
            cmbCins.TabIndex = 8;
            cmbCins.UseSelectable = true;
            // 
            // panelStep3
            // 
            panelStep3.Controls.Add(lblSahipAd);
            panelStep3.Controls.Add(txtSahipAd);
            panelStep3.Controls.Add(lblNot);
            panelStep3.Controls.Add(txtNot);
            panelStep3.HorizontalScrollbarBarColor = true;
            panelStep3.HorizontalScrollbarHighlightOnWheel = false;
            panelStep3.HorizontalScrollbarSize = 10;
            panelStep3.Location = new Point(50, 60);
            panelStep3.Name = "panelStep3";
            panelStep3.Size = new Size(700, 400);
            panelStep3.TabIndex = 2;
            panelStep3.VerticalScrollbarBarColor = true;
            panelStep3.VerticalScrollbarHighlightOnWheel = false;
            panelStep3.VerticalScrollbarSize = 10;
            panelStep3.Visible = false;
            // 
            // lblSahipAd
            // 
            lblSahipAd.AutoSize = true;
            lblSahipAd.Location = new Point(70, 80);
            lblSahipAd.Name = "lblSahipAd";
            lblSahipAd.Size = new Size(69, 20);
            lblSahipAd.TabIndex = 8;
            lblSahipAd.Text = "Sahip Adı:";
            // 
            // txtSahipAd
            // 
            // 
            // 
            // 
            txtSahipAd.CustomButton.Image = null;
            txtSahipAd.CustomButton.Location = new Point(222, 1);
            txtSahipAd.CustomButton.Name = "";
            txtSahipAd.CustomButton.Size = new Size(27, 27);
            txtSahipAd.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            txtSahipAd.CustomButton.TabIndex = 1;
            txtSahipAd.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            txtSahipAd.CustomButton.UseSelectable = true;
            txtSahipAd.CustomButton.Visible = false;
            txtSahipAd.Location = new Point(210, 80);
            txtSahipAd.MaxLength = 32767;
            txtSahipAd.Name = "txtSahipAd";
            txtSahipAd.PasswordChar = '\0';
            txtSahipAd.PromptText = "Hayvan sahibinin adını giriniz...";
            txtSahipAd.ScrollBars = ScrollBars.None;
            txtSahipAd.SelectedText = "";
            txtSahipAd.SelectionLength = 0;
            txtSahipAd.SelectionStart = 0;
            txtSahipAd.ShortcutsEnabled = true;
            txtSahipAd.Size = new Size(250, 29);
            txtSahipAd.TabIndex = 9;
            txtSahipAd.UseSelectable = true;
            txtSahipAd.WaterMark = "Hayvan sahibinin adını giriniz...";
            txtSahipAd.WaterMarkColor = Color.FromArgb(109, 109, 109);
            txtSahipAd.WaterMarkFont = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            // 
            // lblNot
            // 
            lblNot.AutoSize = true;
            lblNot.Location = new Point(70, 160);
            lblNot.Name = "lblNot";
            lblNot.Size = new Size(35, 20);
            lblNot.TabIndex = 3;
            lblNot.Text = "Not:";
            // 
            // txtNot
            // 
            // 
            // 
            // 
            txtNot.CustomButton.Image = null;
            txtNot.CustomButton.Location = new Point(252, 2);
            txtNot.CustomButton.Name = "";
            txtNot.CustomButton.Size = new Size(145, 145);
            txtNot.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            txtNot.CustomButton.TabIndex = 1;
            txtNot.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            txtNot.CustomButton.UseSelectable = true;
            txtNot.CustomButton.Visible = false;
            txtNot.Location = new Point(210, 161);
            txtNot.MaxLength = 32767;
            txtNot.Multiline = true;
            txtNot.Name = "txtNot";
            txtNot.PasswordChar = '\0';
            txtNot.ScrollBars = ScrollBars.Vertical;
            txtNot.SelectedText = "";
            txtNot.SelectionLength = 0;
            txtNot.SelectionStart = 0;
            txtNot.ShortcutsEnabled = true;
            txtNot.Size = new Size(400, 150);
            txtNot.TabIndex = 8;
            txtNot.UseSelectable = true;
            txtNot.WaterMarkColor = Color.FromArgb(109, 109, 109);
            txtNot.WaterMarkFont = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            // 
            // btnGeri
            // 
            btnGeri.Location = new Point(430, 491);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(80, 35);
            btnGeri.TabIndex = 3;
            btnGeri.Text = "Geri";
            btnGeri.UseSelectable = true;
            btnGeri.Click += btnGeri_Click;
            // 
            // btnIleri
            // 
            btnIleri.Location = new Point(547, 491);
            btnIleri.Name = "btnIleri";
            btnIleri.Size = new Size(80, 35);
            btnIleri.TabIndex = 4;
            btnIleri.Text = "İleri";
            btnIleri.UseSelectable = true;
            btnIleri.Click += btnIleri_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(660, 491);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(90, 35);
            btnKaydet.TabIndex = 5;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseSelectable = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // FrmHayvanKayitWizard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 600);
            Controls.Add(btnKaydet);
            Controls.Add(btnIleri);
            Controls.Add(btnGeri);
            Controls.Add(panelStep1);
            Controls.Add(panelStep2);
            Controls.Add(panelStep3);
            MaximizeBox = false;
            Name = "FrmHayvanKayitWizard";
            PoisonBorderStyle = ReaLTaiizor.Enum.Poison.FormBorderStyle.FixedSingle;
            Text = "Hayvan Kayıt Formu";
            Load += FrmHayvanKayitWizard_Load;
            panelStep1.ResumeLayout(false);
            panelStep1.PerformLayout();
            panelStep2.ResumeLayout(false);
            panelStep2.PerformLayout();
            panelStep3.ResumeLayout(false);
            panelStep3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.PoisonPanel panelStep1;
        private ReaLTaiizor.Controls.PoisonPanel panelStep2;
        private ReaLTaiizor.Controls.PoisonPanel panelStep3;
        private ReaLTaiizor.Controls.PoisonLabel lblirk;
        private ReaLTaiizor.Controls.PoisonComboBox cmbTur;
        private ReaLTaiizor.Controls.PoisonLabel lblTur;
        private ReaLTaiizor.Controls.PoisonTextBox txtHayvanAdi;
        private ReaLTaiizor.Controls.PoisonLabel lblAd;
        private ReaLTaiizor.Controls.PoisonComboBox cmbIrk;
        private ReaLTaiizor.Controls.PoisonLabel lblDogumTarihi;
        private ReaLTaiizor.Controls.PoisonDateTime dtpDogumTarihi;
        private ReaLTaiizor.Controls.PoisonLabel lblCins;
        private ReaLTaiizor.Controls.PoisonComboBox cmbCins;
        private ReaLTaiizor.Controls.PoisonLabel lblSahipAd;
        private ReaLTaiizor.Controls.PoisonTextBox txtSahipAd;
        private ReaLTaiizor.Controls.PoisonLabel lblNot;
        private ReaLTaiizor.Controls.PoisonTextBox txtNot;
        private ReaLTaiizor.Controls.PoisonButton btnGeri;
        private ReaLTaiizor.Controls.PoisonButton btnIleri;
        private ReaLTaiizor.Controls.PoisonButton btnKaydet;
    }
}