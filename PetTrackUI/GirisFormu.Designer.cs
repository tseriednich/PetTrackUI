namespace PetTrackUI
{
    partial class GirisFormu
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
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            GirisYapPnl = new ReaLTaiizor.Controls.Panel();
            chkBeniHatirla = new CheckBox();
            lnkKayitOl = new Label();
            label3 = new Label();
            GirisYapTextBox = new ReaLTaiizor.Controls.Button();
            SifreTextBox = new TextBox();
            EpostaTextbox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            GirisYapPnl.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(664, 162);
            label2.Name = "label2";
            label2.Size = new Size(103, 30);
            label2.TabIndex = 6;
            label2.Text = "Giriş Yap";
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.petrackbeyaz2;
            pictureBox1.Location = new Point(174, 109);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(234, 106);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(59, 258);
            label1.Name = "label1";
            label1.Size = new Size(503, 68);
            label1.TabIndex = 1;
            label1.Text = "Evcil Hayvanların Sağlığını ve Aktivitelerini Tek Yerden Takip Edin.";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.undraw_petting_xclp_removebg_preview;
            pictureBox2.Location = new Point(114, 374);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(384, 274);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-1, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(634, 770);
            panel1.TabIndex = 0;
            // 
            // GirisYapPnl
            // 
            GirisYapPnl.BackColor = SystemColors.ButtonFace;
            GirisYapPnl.Controls.Add(chkBeniHatirla);
            GirisYapPnl.Controls.Add(lnkKayitOl);
            GirisYapPnl.Controls.Add(label3);
            GirisYapPnl.Controls.Add(GirisYapTextBox);
            GirisYapPnl.Controls.Add(SifreTextBox);
            GirisYapPnl.Controls.Add(EpostaTextbox);
            GirisYapPnl.EdgeColor = Color.White;
            GirisYapPnl.Location = new Point(664, 200);
            GirisYapPnl.Margin = new Padding(3, 2, 3, 2);
            GirisYapPnl.Name = "GirisYapPnl";
            GirisYapPnl.Padding = new Padding(4, 4, 4, 4);
            GirisYapPnl.Size = new Size(569, 315);
            GirisYapPnl.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            GirisYapPnl.TabIndex = 7;
            GirisYapPnl.Text = "panel2";
            // 
            // chkBeniHatirla
            // 
            chkBeniHatirla.AutoSize = true;
            chkBeniHatirla.Location = new Point(154, 174);
            chkBeniHatirla.Name = "chkBeniHatirla";
            chkBeniHatirla.Size = new Size(87, 19);
            chkBeniHatirla.TabIndex = 5;
            chkBeniHatirla.Text = "Beni Hatırla";
            chkBeniHatirla.UseVisualStyleBackColor = true;
            // 
            // lnkKayitOl
            // 
            lnkKayitOl.AutoSize = true;
            lnkKayitOl.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Underline, GraphicsUnit.Point, 162);
            lnkKayitOl.ForeColor = SystemColors.ControlDarkDark;
            lnkKayitOl.Location = new Point(282, 233);
            lnkKayitOl.Name = "lnkKayitOl";
            lnkKayitOl.Size = new Size(137, 12);
            lnkKayitOl.TabIndex = 4;
            lnkKayitOl.Text = "Hesabınız yok mu? Kayıt Olun";
            lnkKayitOl.Click += lnkKayitOl_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Underline, GraphicsUnit.Point, 162);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(342, 171);
            label3.Name = "label3";
            label3.Size = new Size(77, 12);
            label3.TabIndex = 3;
            label3.Text = "Şifremi Unuttum";
            // 
            // GirisYapTextBox
            // 
            GirisYapTextBox.BackColor = Color.DodgerBlue;
            GirisYapTextBox.BorderColor = SystemColors.Control;
            GirisYapTextBox.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            GirisYapTextBox.EnteredColor = Color.White;
            GirisYapTextBox.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            GirisYapTextBox.Image = null;
            GirisYapTextBox.ImageAlign = ContentAlignment.MiddleLeft;
            GirisYapTextBox.InactiveColor = Color.DodgerBlue;
            GirisYapTextBox.Location = new Point(153, 194);
            GirisYapTextBox.Margin = new Padding(3, 2, 3, 2);
            GirisYapTextBox.Name = "GirisYapTextBox";
            GirisYapTextBox.PressedBorderColor = SystemColors.Control;
            GirisYapTextBox.PressedColor = SystemColors.MenuHighlight;
            GirisYapTextBox.Size = new Size(272, 38);
            GirisYapTextBox.TabIndex = 2;
            GirisYapTextBox.Text = "Giriş Yap";
            GirisYapTextBox.TextAlignment = StringAlignment.Center;
            GirisYapTextBox.Click += GirisYapTextBox_Click;
            // 
            // SifreTextBox
            // 
            SifreTextBox.Location = new Point(153, 148);
            SifreTextBox.Margin = new Padding(3, 2, 3, 2);
            SifreTextBox.Name = "SifreTextBox";
            SifreTextBox.PlaceholderText = "Şifre";
            SifreTextBox.Size = new Size(273, 23);
            SifreTextBox.TabIndex = 1;
            // 
            // EpostaTextbox
            // 
            EpostaTextbox.Location = new Point(153, 100);
            EpostaTextbox.Margin = new Padding(3, 2, 3, 2);
            EpostaTextbox.Name = "EpostaTextbox";
            EpostaTextbox.PlaceholderText = "E-posta ";
            EpostaTextbox.Size = new Size(273, 23);
            EpostaTextbox.TabIndex = 0;
            // 
            // GirisFormu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1260, 768);
            Controls.Add(GirisYapPnl);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "GirisFormu";
            Text = "Giriş Yap";
            Load += GirisFormu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            GirisYapPnl.ResumeLayout(false);
            GirisYapPnl.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private ReaLTaiizor.Controls.Panel GirisYapPnl;
        private Label lnkKayitOl;
        private Label label3;
        private ReaLTaiizor.Controls.Button GirisYapTextBox;
        private TextBox SifreTextBox;
        private TextBox EpostaTextbox;
        private CheckBox chkBeniHatirla;
    }
}