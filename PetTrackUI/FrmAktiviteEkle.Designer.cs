namespace PetTrackUI
{
    partial class FrmAktiviteEkle
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
            lblHayvan = new ReaLTaiizor.Controls.PoisonLabel();
            cmbHayvan = new ReaLTaiizor.Controls.PoisonComboBox();
            cmbAkTur = new ReaLTaiizor.Controls.PoisonComboBox();
            lblAkTur = new ReaLTaiizor.Controls.PoisonLabel();
            lblTarih = new ReaLTaiizor.Controls.PoisonLabel();
            dtTarih = new ReaLTaiizor.Controls.PoisonDateTime();
            lblSure = new ReaLTaiizor.Controls.PoisonLabel();
            numSure = new NumericUpDown();
            lblNot = new ReaLTaiizor.Controls.PoisonLabel();
            txtNot = new ReaLTaiizor.Controls.PoisonTextBox();
            btnIptal = new ReaLTaiizor.Controls.PoisonButton();
            btnKaydet = new ReaLTaiizor.Controls.PoisonButton();
            ((System.ComponentModel.ISupportInitialize)numSure).BeginInit();
            SuspendLayout();
            // 
            // lblHayvan
            // 
            lblHayvan.AutoSize = true;
            lblHayvan.Location = new Point(127, 88);
            lblHayvan.Name = "lblHayvan";
            lblHayvan.Size = new Size(58, 20);
            lblHayvan.TabIndex = 0;
            lblHayvan.Text = "Hayvan:";
            lblHayvan.TextAlign = ContentAlignment.MiddleLeft;
            lblHayvan.Click += txtHayvan_Click;
            // 
            // cmbHayvan
            // 
            cmbHayvan.FormattingEnabled = true;
            cmbHayvan.ItemHeight = 24;
            cmbHayvan.Location = new Point(275, 88);
            cmbHayvan.Name = "cmbHayvan";
            cmbHayvan.Size = new Size(250, 30);
            cmbHayvan.TabIndex = 1;
            cmbHayvan.UseSelectable = true;
            // 
            // cmbAkTur
            // 
            cmbAkTur.FormattingEnabled = true;
            cmbAkTur.ItemHeight = 24;
            cmbAkTur.Location = new Point(275, 157);
            cmbAkTur.Name = "cmbAkTur";
            cmbAkTur.Size = new Size(250, 30);
            cmbAkTur.TabIndex = 2;
            cmbAkTur.UseSelectable = true;
            cmbAkTur.SelectedIndexChanged += poisonComboBox2_SelectedIndexChanged;
            // 
            // lblAkTur
            // 
            lblAkTur.AutoSize = true;
            lblAkTur.Location = new Point(127, 157);
            lblAkTur.Name = "lblAkTur";
            lblAkTur.Size = new Size(88, 20);
            lblAkTur.TabIndex = 3;
            lblAkTur.Text = "Aktivite Türü:";
            lblAkTur.TextAlign = ContentAlignment.MiddleLeft;
            lblAkTur.Click += poisonLabel2_Click;
            // 
            // lblTarih
            // 
            lblTarih.AutoSize = true;
            lblTarih.Location = new Point(126, 228);
            lblTarih.Name = "lblTarih";
            lblTarih.Size = new Size(89, 20);
            lblTarih.TabIndex = 4;
            lblTarih.Text = "Tarih ve Saat:";
            lblTarih.TextAlign = ContentAlignment.MiddleLeft;
            lblTarih.Click += poisonLabel3_Click;
            // 
            // dtTarih
            // 
            dtTarih.CustomFormat = "dd.MM.yyyy H:mm";
            dtTarih.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Medium;
            dtTarih.Format = DateTimePickerFormat.Custom;
            dtTarih.Location = new Point(275, 228);
            dtTarih.MinimumSize = new Size(0, 30);
            dtTarih.Name = "dtTarih";
            dtTarih.Size = new Size(250, 30);
            dtTarih.TabIndex = 5;
            dtTarih.ValueChanged += poisonDateTime1_ValueChanged;
            // 
            // lblSure
            // 
            lblSure.AutoSize = true;
            lblSure.Location = new Point(126, 301);
            lblSure.Name = "lblSure";
            lblSure.Size = new Size(40, 20);
            lblSure.TabIndex = 6;
            lblSure.Text = "Süre:";
            lblSure.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // numSure
            // 
            numSure.Location = new Point(275, 301);
            numSure.Name = "numSure";
            numSure.Size = new Size(250, 27);
            numSure.TabIndex = 7;
            // 
            // lblNot
            // 
            lblNot.AutoSize = true;
            lblNot.Location = new Point(126, 367);
            lblNot.Name = "lblNot";
            lblNot.Size = new Size(35, 20);
            lblNot.TabIndex = 8;
            lblNot.Text = "Not:";
            // 
            // txtNot
            // 
            // 
            // 
            // 
            txtNot.CustomButton.Image = null;
            txtNot.CustomButton.Location = new Point(198, 2);
            txtNot.CustomButton.Name = "";
            txtNot.CustomButton.Size = new Size(49, 49);
            txtNot.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            txtNot.CustomButton.TabIndex = 1;
            txtNot.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            txtNot.CustomButton.UseSelectable = true;
            txtNot.CustomButton.Visible = false;
            txtNot.Location = new Point(275, 367);
            txtNot.MaxLength = 32767;
            txtNot.Multiline = true;
            txtNot.Name = "txtNot";
            txtNot.PasswordChar = '\0';
            txtNot.ScrollBars = ScrollBars.Vertical;
            txtNot.SelectedText = "";
            txtNot.SelectionLength = 0;
            txtNot.SelectionStart = 0;
            txtNot.ShortcutsEnabled = true;
            txtNot.Size = new Size(250, 54);
            txtNot.TabIndex = 9;
            txtNot.UseSelectable = true;
            txtNot.WaterMarkColor = Color.FromArgb(109, 109, 109);
            txtNot.WaterMarkFont = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            // 
            // btnIptal
            // 
            btnIptal.Location = new Point(474, 486);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(120, 40);
            btnIptal.TabIndex = 10;
            btnIptal.Text = "İptal";
            btnIptal.UseSelectable = true;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(633, 486);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(120, 40);
            btnKaydet.TabIndex = 11;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseSelectable = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // FrmAktiviteEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 600);
            Controls.Add(btnKaydet);
            Controls.Add(btnIptal);
            Controls.Add(txtNot);
            Controls.Add(lblNot);
            Controls.Add(numSure);
            Controls.Add(lblSure);
            Controls.Add(dtTarih);
            Controls.Add(lblTarih);
            Controls.Add(lblAkTur);
            Controls.Add(cmbAkTur);
            Controls.Add(cmbHayvan);
            Controls.Add(lblHayvan);
            MaximizeBox = false;
            Name = "FrmAktiviteEkle";
            Text = "Aktivite Ekle";
            Load += FrmAktiviteEkle_Load;
            ((System.ComponentModel.ISupportInitialize)numSure).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.PoisonLabel lblHayvan;
        private ReaLTaiizor.Controls.PoisonComboBox cmbHayvan;
        private ReaLTaiizor.Controls.PoisonComboBox cmbAkTur;
        private ReaLTaiizor.Controls.PoisonLabel lblAkTur;
        private ReaLTaiizor.Controls.PoisonLabel lblTarih;
        private ReaLTaiizor.Controls.PoisonDateTime dtTarih;
        private ReaLTaiizor.Controls.PoisonLabel lblSure;
        private NumericUpDown numSure;
        private ReaLTaiizor.Controls.PoisonLabel lblNot;
        private ReaLTaiizor.Controls.PoisonTextBox txtNot;
        private ReaLTaiizor.Controls.PoisonButton btnIptal;
        private ReaLTaiizor.Controls.PoisonButton btnKaydet;
    }
}