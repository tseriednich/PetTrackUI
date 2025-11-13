namespace PetTrackUI
{
    partial class FrmPlanEkle
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
            cmbPlanTuru = new ReaLTaiizor.Controls.PoisonComboBox();
            cmbHayvan = new ReaLTaiizor.Controls.PoisonComboBox();
            dtTarih = new ReaLTaiizor.Controls.PoisonDateTime();
            txtNot = new ReaLTaiizor.Controls.PoisonTextBox();
            btnKaydet = new ReaLTaiizor.Controls.PoisonButton();
            btnIptal = new ReaLTaiizor.Controls.PoisonButton();
            lblHayvan = new ReaLTaiizor.Controls.PoisonLabel();
            lblPlan = new ReaLTaiizor.Controls.PoisonLabel();
            lblTarih = new ReaLTaiizor.Controls.PoisonLabel();
            lblNot = new ReaLTaiizor.Controls.PoisonLabel();
            SuspendLayout();
            // 
            // cmbPlanTuru
            // 
            cmbPlanTuru.FormattingEnabled = true;
            cmbPlanTuru.ItemHeight = 24;
            cmbPlanTuru.Location = new Point(209, 152);
            cmbPlanTuru.Name = "cmbPlanTuru";
            cmbPlanTuru.Size = new Size(250, 30);
            cmbPlanTuru.TabIndex = 0;
            cmbPlanTuru.UseSelectable = true;
            // 
            // cmbHayvan
            // 
            cmbHayvan.FormattingEnabled = true;
            cmbHayvan.ItemHeight = 24;
            cmbHayvan.Location = new Point(209, 92);
            cmbHayvan.Name = "cmbHayvan";
            cmbHayvan.Size = new Size(250, 30);
            cmbHayvan.TabIndex = 1;
            cmbHayvan.UseSelectable = true;
            // 
            // dtTarih
            // 
            dtTarih.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Medium;
            dtTarih.Location = new Point(209, 212);
            dtTarih.MinimumSize = new Size(0, 30);
            dtTarih.Name = "dtTarih";
            dtTarih.Size = new Size(250, 30);
            dtTarih.TabIndex = 2;
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
            txtNot.Location = new Point(209, 271);
            txtNot.MaxLength = 32767;
            txtNot.Name = "txtNot";
            txtNot.PasswordChar = '\0';
            txtNot.ScrollBars = ScrollBars.None;
            txtNot.SelectedText = "";
            txtNot.SelectionLength = 0;
            txtNot.SelectionStart = 0;
            txtNot.ShortcutsEnabled = true;
            txtNot.Size = new Size(250, 54);
            txtNot.TabIndex = 3;
            txtNot.UseSelectable = true;
            txtNot.WaterMarkColor = Color.FromArgb(109, 109, 109);
            txtNot.WaterMarkFont = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(529, 385);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(94, 29);
            btnKaydet.TabIndex = 1;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseSelectable = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnIptal
            // 
            btnIptal.Location = new Point(651, 385);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(94, 29);
            btnIptal.TabIndex = 2;
            btnIptal.Text = "İptal";
            btnIptal.UseSelectable = true;
            btnIptal.Click += btnIptal_Click;
            // 
            // lblHayvan
            // 
            lblHayvan.AutoSize = true;
            lblHayvan.Location = new Point(98, 92);
            lblHayvan.Name = "lblHayvan";
            lblHayvan.Size = new Size(58, 20);
            lblHayvan.TabIndex = 6;
            lblHayvan.Text = "Hayvan:";
            // 
            // lblPlan
            // 
            lblPlan.AutoSize = true;
            lblPlan.Location = new Point(98, 152);
            lblPlan.Name = "lblPlan";
            lblPlan.Size = new Size(69, 20);
            lblPlan.TabIndex = 7;
            lblPlan.Text = "Plan Türü:";
            // 
            // lblTarih
            // 
            lblTarih.AutoSize = true;
            lblTarih.Location = new Point(98, 212);
            lblTarih.Name = "lblTarih";
            lblTarih.Size = new Size(89, 20);
            lblTarih.TabIndex = 8;
            lblTarih.Text = "Tarih ve Saat:";
            // 
            // lblNot
            // 
            lblNot.AutoSize = true;
            lblNot.Location = new Point(98, 271);
            lblNot.Name = "lblNot";
            lblNot.Size = new Size(35, 20);
            lblNot.TabIndex = 9;
            lblNot.Text = "Not:";
            // 
            // FrmPlanEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblNot);
            Controls.Add(lblTarih);
            Controls.Add(lblPlan);
            Controls.Add(lblHayvan);
            Controls.Add(btnIptal);
            Controls.Add(btnKaydet);
            Controls.Add(txtNot);
            Controls.Add(dtTarih);
            Controls.Add(cmbHayvan);
            Controls.Add(cmbPlanTuru);
            Name = "FrmPlanEkle";
            Text = "Yeni bir plan oluşturun.";
            Load += FrmPlanEkle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.PoisonComboBox cmbPlanTuru;
        private ReaLTaiizor.Controls.PoisonComboBox cmbHayvan;
        private ReaLTaiizor.Controls.PoisonDateTime dtTarih;
        private ReaLTaiizor.Controls.PoisonTextBox txtNot;
        private ReaLTaiizor.Controls.PoisonButton btnKaydet;
        private ReaLTaiizor.Controls.PoisonButton btnIptal;
        private ReaLTaiizor.Controls.PoisonLabel lblHayvan;
        private ReaLTaiizor.Controls.PoisonLabel lblPlan;
        private ReaLTaiizor.Controls.PoisonLabel lblTarih;
        private ReaLTaiizor.Controls.PoisonLabel lblNot;
    }
}