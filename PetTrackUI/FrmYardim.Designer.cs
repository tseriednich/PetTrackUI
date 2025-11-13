namespace PetTrackUI
{
    partial class FrmYardim
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
            lblCevap1 = new ReaLTaiizor.Controls.PoisonLabel();
            btnSoru1 = new ReaLTaiizor.Controls.PoisonButton();
            poisonButton1 = new ReaLTaiizor.Controls.PoisonButton();
            poisonLabel1 = new ReaLTaiizor.Controls.PoisonLabel();
            poisonButton2 = new ReaLTaiizor.Controls.PoisonButton();
            poisonLabel2 = new ReaLTaiizor.Controls.PoisonLabel();
            poisonButton3 = new ReaLTaiizor.Controls.PoisonButton();
            poisonLabel3 = new ReaLTaiizor.Controls.PoisonLabel();
            SuspendLayout();
            // 
            // lblCevap1
            // 
            lblCevap1.AutoSize = true;
            lblCevap1.Location = new Point(40, 103);
            lblCevap1.Name = "lblCevap1";
            lblCevap1.Size = new Size(462, 20);
            lblCevap1.TabIndex = 0;
            lblCevap1.Text = "Dashboard > Hayvanlar > Ekle yolunu takip edin. Bilgileri adım adım girin.";
            lblCevap1.Click += btnSoru1_Click_1;
            // 
            // btnSoru1
            // 
            btnSoru1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnSoru1.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Tall;
            btnSoru1.FontWeight = ReaLTaiizor.Extension.Poison.PoisonButtonWeight.Regular;
            btnSoru1.Location = new Point(40, 70);
            btnSoru1.Name = "btnSoru1";
            btnSoru1.Size = new Size(720, 30);
            btnSoru1.TabIndex = 1;
            btnSoru1.Text = "Yeni bir hayvan kaydederken hangi adımları izlemeliyim?\n\n";
            btnSoru1.UseSelectable = true;
            // 
            // poisonButton1
            // 
            poisonButton1.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Tall;
            poisonButton1.FontWeight = ReaLTaiizor.Extension.Poison.PoisonButtonWeight.Regular;
            poisonButton1.Location = new Point(40, 147);
            poisonButton1.Name = "poisonButton1";
            poisonButton1.Size = new Size(720, 29);
            poisonButton1.TabIndex = 2;
            poisonButton1.Text = "Yanlışlıkla girdiğim aktiviteyi nasıl silebilirim?";
            poisonButton1.UseSelectable = true;
            poisonButton1.Click += poisonButton1_Click;
            // 
            // poisonLabel1
            // 
            poisonLabel1.AutoSize = true;
            poisonLabel1.Location = new Point(40, 179);
            poisonLabel1.Name = "poisonLabel1";
            poisonLabel1.Size = new Size(373, 20);
            poisonLabel1.TabIndex = 3;
            poisonLabel1.Text = "Aktiviteler sayfasında ilgili satırı seçip 'Sil' butonunu kullanın.";
            poisonLabel1.Click += poisonLabel1_Click;
            // 
            // poisonButton2
            // 
            poisonButton2.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Tall;
            poisonButton2.FontWeight = ReaLTaiizor.Extension.Poison.PoisonButtonWeight.Regular;
            poisonButton2.Location = new Point(40, 224);
            poisonButton2.Name = "poisonButton2";
            poisonButton2.Size = new Size(720, 29);
            poisonButton2.TabIndex = 4;
            poisonButton2.Text = "Kayıt sırasında yanlış bilgi girersem nasıl düzeltebilirim?";
            poisonButton2.UseSelectable = true;
            // 
            // poisonLabel2
            // 
            poisonLabel2.AutoSize = true;
            poisonLabel2.Location = new Point(40, 256);
            poisonLabel2.Name = "poisonLabel2";
            poisonLabel2.Size = new Size(606, 20);
            poisonLabel2.TabIndex = 5;
            poisonLabel2.Text = "Hayvanlar sayfasından ilgili kaydı seçip “Düzenle” butonuna tıklayarak bilgileri güncelleyebilirsiniz.";
            poisonLabel2.Click += poisonLabel2_Click;
            // 
            // poisonButton3
            // 
            poisonButton3.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Tall;
            poisonButton3.FontWeight = ReaLTaiizor.Extension.Poison.PoisonButtonWeight.Regular;
            poisonButton3.Location = new Point(40, 298);
            poisonButton3.Name = "poisonButton3";
            poisonButton3.Size = new Size(720, 29);
            poisonButton3.TabIndex = 6;
            poisonButton3.Text = "Aynı isimde birden fazla hayvan kaydedebilir miyim?";
            poisonButton3.UseSelectable = true;
            // 
            // poisonLabel3
            // 
            poisonLabel3.AutoSize = true;
            poisonLabel3.Location = new Point(40, 330);
            poisonLabel3.Name = "poisonLabel3";
            poisonLabel3.Size = new Size(682, 20);
            poisonLabel3.TabIndex = 7;
            poisonLabel3.Text = "Evet, sistem isimleri benzersiz kılmaya zorlamaz. Ancak karışıklık yaşamamak için not bilgisi eklemeniz önerilir.";
            // 
            // FrmYardim
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(800, 450);
            Controls.Add(poisonLabel3);
            Controls.Add(poisonButton3);
            Controls.Add(poisonLabel2);
            Controls.Add(poisonButton2);
            Controls.Add(poisonLabel1);
            Controls.Add(poisonButton1);
            Controls.Add(btnSoru1);
            Controls.Add(lblCevap1);
            Name = "FrmYardim";
            Text = "Yardım";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.PoisonLabel lblCevap1;
        private ReaLTaiizor.Controls.PoisonButton btnSoru1;
        private ReaLTaiizor.Controls.PoisonButton poisonButton1;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel1;
        private ReaLTaiizor.Controls.PoisonButton poisonButton2;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel2;
        private ReaLTaiizor.Controls.PoisonButton poisonButton3;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel3;
    }
}