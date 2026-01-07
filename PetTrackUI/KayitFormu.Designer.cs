using MySql.Data.MySqlClient;
namespace PetTrackUI

{
    partial class KayitFormu
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
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            KayıtOlPnl = new ReaLTaiizor.Controls.Panel();
            lnkGirisYap = new Label();
            sifre_tekrarTextBox = new TextBox();
            AdTextBox = new TextBox();
            SoyadTextBox = new TextBox();
            KayitOlBtn = new ReaLTaiizor.Controls.Button();
            sifreTextBox = new TextBox();
            epostaTextBox = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            KayıtOlPnl.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(725, 1027);
            panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.undraw_petting_xclp_removebg_preview;
            pictureBox2.Location = new Point(121, 500);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(455, 365);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(67, 344);
            label1.Name = "label1";
            label1.Size = new Size(575, 91);
            label1.TabIndex = 1;
            label1.Text = "Evcil Hayvanların Sağlığını ve Aktivitelerini Tek Yerden Takip Edin.";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.petrackbeyaz2;
            pictureBox1.Location = new Point(199, 145);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(268, 141);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // KayıtOlPnl
            // 
            KayıtOlPnl.BackColor = SystemColors.ButtonFace;
            KayıtOlPnl.Controls.Add(lnkGirisYap);
            KayıtOlPnl.Controls.Add(sifre_tekrarTextBox);
            KayıtOlPnl.Controls.Add(AdTextBox);
            KayıtOlPnl.Controls.Add(SoyadTextBox);
            KayıtOlPnl.Controls.Add(KayitOlBtn);
            KayıtOlPnl.Controls.Add(sifreTextBox);
            KayıtOlPnl.Controls.Add(epostaTextBox);
            KayıtOlPnl.EdgeColor = Color.White;
            KayıtOlPnl.Location = new Point(759, 267);
            KayıtOlPnl.Name = "KayıtOlPnl";
            KayıtOlPnl.Padding = new Padding(5);
            KayıtOlPnl.Size = new Size(650, 549);
            KayıtOlPnl.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            KayıtOlPnl.TabIndex = 7;
            KayıtOlPnl.Text = "panel2";
            // 
            // lnkGirisYap
            // 
            lnkGirisYap.AutoSize = true;
            lnkGirisYap.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Underline, GraphicsUnit.Point, 162);
            lnkGirisYap.ForeColor = SystemColors.ControlDarkDark;
            lnkGirisYap.Location = new Point(289, 361);
            lnkGirisYap.Name = "lnkGirisYap";
            lnkGirisYap.Size = new Size(212, 17);
            lnkGirisYap.TabIndex = 9;
            lnkGirisYap.Text = "Zaten hesabınız var mı? Giriş Yapın.";
            lnkGirisYap.Click += lnkGirisYap_Click;
            // 
            // sifre_tekrarTextBox
            // 
            sifre_tekrarTextBox.Location = new Point(175, 331);
            sifre_tekrarTextBox.Name = "sifre_tekrarTextBox";
            sifre_tekrarTextBox.PlaceholderText = "Şifre(Tekrar)";
            sifre_tekrarTextBox.Size = new Size(311, 27);
            sifre_tekrarTextBox.TabIndex = 5;
            // 
            // AdTextBox
            // 
            AdTextBox.Location = new Point(175, 91);
            AdTextBox.Name = "AdTextBox";
            AdTextBox.PlaceholderText = "Ad";
            AdTextBox.Size = new Size(311, 27);
            AdTextBox.TabIndex = 4;
            AdTextBox.TextChanged += AdTextBox_TextChanged;
            // 
            // SoyadTextBox
            // 
            SoyadTextBox.Location = new Point(175, 149);
            SoyadTextBox.Name = "SoyadTextBox";
            SoyadTextBox.PlaceholderText = "Soyad";
            SoyadTextBox.Size = new Size(311, 27);
            SoyadTextBox.TabIndex = 3;
            // 
            // KayitOlBtn
            // 
            KayitOlBtn.BackColor = Color.DodgerBlue;
            KayitOlBtn.BorderColor = SystemColors.Control;
            KayitOlBtn.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            KayitOlBtn.EnteredColor = Color.White;
            KayitOlBtn.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            KayitOlBtn.Image = null;
            KayitOlBtn.ImageAlign = ContentAlignment.MiddleLeft;
            KayitOlBtn.InactiveColor = Color.DodgerBlue;
            KayitOlBtn.Location = new Point(175, 389);
            KayitOlBtn.Name = "KayitOlBtn";
            KayitOlBtn.PressedBorderColor = SystemColors.Control;
            KayitOlBtn.PressedColor = SystemColors.HotTrack;
            KayitOlBtn.Size = new Size(311, 51);
            KayitOlBtn.TabIndex = 2;
            KayitOlBtn.Text = "Kayıt Ol";
            KayitOlBtn.TextAlignment = StringAlignment.Center;
            KayitOlBtn.Click += KayitOlBtn_Click;
            // 
            // sifreTextBox
            // 
            sifreTextBox.Location = new Point(175, 269);
            sifreTextBox.Name = "sifreTextBox";
            sifreTextBox.PlaceholderText = "Şifre";
            sifreTextBox.Size = new Size(311, 27);
            sifreTextBox.TabIndex = 1;
            // 
            // epostaTextBox
            // 
            epostaTextBox.Location = new Point(175, 211);
            epostaTextBox.Name = "epostaTextBox";
            epostaTextBox.PlaceholderText = "E-posta ";
            epostaTextBox.Size = new Size(311, 27);
            epostaTextBox.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(759, 213);
            label2.Name = "label2";
            label2.Size = new Size(121, 38);
            label2.TabIndex = 8;
            label2.Text = "Kayıt Ol";
            // 
            // KayitFormu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1440, 1024);
            Controls.Add(label2);
            Controls.Add(KayıtOlPnl);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "KayitFormu";
            Text = " ";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            KayıtOlPnl.ResumeLayout(false);
            KayıtOlPnl.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox2;
        private Label label1;
        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.Panel KayıtOlPnl;
        private TextBox sifre_tekrarTextBox;
        private TextBox AdTextBox;
        private TextBox SoyadTextBox;
        private ReaLTaiizor.Controls.Button KayitOlBtn;
        private TextBox sifreTextBox;
        private TextBox epostaTextBox;
        private Label label2;
        private Label lnkGirisYap;
    }
}