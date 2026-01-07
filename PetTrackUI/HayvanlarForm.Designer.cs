namespace PetTrackUI
{
    partial class HayvanlarForm
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
            btnYeniHayvan = new ReaLTaiizor.Controls.Panel();
            pictureBox11 = new PictureBox();
            label8 = new Label();
            topbar = new ReaLTaiizor.Controls.Panel();
            label7 = new Label();
            UserIcon = new PictureBox();
            LogOutIcon = new PictureBox();
            pictureBox1 = new PictureBox();
            dgvHayvanlar = new DataGridView();
            btnSil = new DataGridViewButtonColumn();
            sidebar = new ReaLTaiizor.Controls.PoisonPanel();
            btnYardim = new ReaLTaiizor.Controls.PoisonPanel();
            label5 = new Label();
            pictureBox6 = new PictureBox();
            btnHakkimizda = new ReaLTaiizor.Controls.PoisonPanel();
            label6 = new Label();
            pictureBox7 = new PictureBox();
            btnAyarlar = new ReaLTaiizor.Controls.PoisonPanel();
            label4 = new Label();
            pictureBox5 = new PictureBox();
            btnDboard = new ReaLTaiizor.Controls.PoisonPanel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            btnAktiviteler = new ReaLTaiizor.Controls.PoisonPanel();
            label3 = new Label();
            pictureBox4 = new PictureBox();
            btnHayvanlar = new ReaLTaiizor.Controls.PoisonPanel();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            btnYeniHayvan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            topbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UserIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LogOutIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvHayvanlar).BeginInit();
            sidebar.SuspendLayout();
            btnYardim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            btnHakkimizda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            btnAyarlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            btnDboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            btnAktiviteler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            btnHayvanlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btnYeniHayvan
            // 
            btnYeniHayvan.BackColor = Color.DodgerBlue;
            btnYeniHayvan.Controls.Add(pictureBox11);
            btnYeniHayvan.Controls.Add(label8);
            btnYeniHayvan.Cursor = Cursors.Hand;
            btnYeniHayvan.EdgeColor = Color.White;
            btnYeniHayvan.Location = new Point(980, 90);
            btnYeniHayvan.Margin = new Padding(3, 2, 3, 2);
            btnYeniHayvan.Name = "btnYeniHayvan";
            btnYeniHayvan.Padding = new Padding(4);
            btnYeniHayvan.Size = new Size(228, 45);
            btnYeniHayvan.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnYeniHayvan.TabIndex = 4;
            btnYeniHayvan.Text = "panel2";
            btnYeniHayvan.Click += btnYeniHayvan_Click;
            // 
            // pictureBox11
            // 
            pictureBox11.Image = Properties.Resources.plus;
            pictureBox11.Location = new Point(18, 10);
            pictureBox11.Margin = new Padding(3, 2, 3, 2);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(26, 22);
            pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox11.TabIndex = 5;
            pictureBox11.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(61, 11);
            label8.Name = "label8";
            label8.Size = new Size(130, 21);
            label8.TabIndex = 4;
            label8.Text = "Yeni Hayvan Ekle";
            label8.Click += label8_Click;
            // 
            // topbar
            // 
            topbar.BackColor = Color.DodgerBlue;
            topbar.Controls.Add(label7);
            topbar.Controls.Add(UserIcon);
            topbar.Controls.Add(LogOutIcon);
            topbar.Controls.Add(pictureBox1);
            topbar.EdgeColor = SystemColors.Highlight;
            topbar.Location = new Point(0, 0);
            topbar.Margin = new Padding(3, 2, 3, 2);
            topbar.Name = "topbar";
            topbar.Padding = new Padding(4);
            topbar.Size = new Size(1260, 69);
            topbar.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            topbar.TabIndex = 6;
            topbar.Text = "panel1";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.ForeColor = Color.White;
            label7.Location = new Point(1089, 27);
            label7.Name = "label7";
            label7.Size = new Size(46, 19);
            label7.TabIndex = 4;
            label7.Text = "J. Doe";
            // 
            // UserIcon
            // 
            UserIcon.Image = Properties.Resources.person;
            UserIcon.Location = new Point(1062, 26);
            UserIcon.Margin = new Padding(3, 2, 3, 2);
            UserIcon.Name = "UserIcon";
            UserIcon.Size = new Size(22, 19);
            UserIcon.TabIndex = 3;
            UserIcon.TabStop = false;
            // 
            // LogOutIcon
            // 
            LogOutIcon.Image = Properties.Resources.log_out;
            LogOutIcon.Location = new Point(1196, 26);
            LogOutIcon.Margin = new Padding(3, 2, 3, 2);
            LogOutIcon.Name = "LogOutIcon";
            LogOutIcon.Size = new Size(22, 19);
            LogOutIcon.TabIndex = 1;
            LogOutIcon.TabStop = false;
            LogOutIcon.Click += LogOutIcon_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Enabled = false;
            pictureBox1.Image = Properties.Resources.petrackbeyaz;
            pictureBox1.Location = new Point(18, 6);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dgvHayvanlar
            // 
            dgvHayvanlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHayvanlar.Columns.AddRange(new DataGridViewColumn[] { btnSil });
            dgvHayvanlar.Location = new Point(234, 356);
            dgvHayvanlar.Name = "dgvHayvanlar";
            dgvHayvanlar.RowHeadersWidth = 51;
            dgvHayvanlar.Size = new Size(974, 254);
            dgvHayvanlar.TabIndex = 14;
            // 
            // btnSil
            // 
            btnSil.HeaderText = "Sil";
            btnSil.Name = "btnSil";
            btnSil.Text = "Sil";
            btnSil.UseColumnTextForButtonValue = true;
            // 
            // sidebar
            // 
            sidebar.BackColor = SystemColors.Control;
            sidebar.BorderStyle = BorderStyle.FixedSingle;
            sidebar.Controls.Add(btnYardim);
            sidebar.Controls.Add(btnHakkimizda);
            sidebar.Controls.Add(btnAyarlar);
            sidebar.Controls.Add(btnDboard);
            sidebar.Controls.Add(btnAktiviteler);
            sidebar.Controls.Add(btnHayvanlar);
            sidebar.Dock = DockStyle.Left;
            sidebar.ForeColor = SystemColors.ControlText;
            sidebar.HorizontalScrollbarBarColor = true;
            sidebar.HorizontalScrollbarHighlightOnWheel = false;
            sidebar.HorizontalScrollbarSize = 8;
            sidebar.Location = new Point(0, 0);
            sidebar.Margin = new Padding(3, 2, 3, 2);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(175, 768);
            sidebar.TabIndex = 25;
            sidebar.VerticalScrollbarBarColor = true;
            sidebar.VerticalScrollbarHighlightOnWheel = false;
            sidebar.VerticalScrollbarSize = 9;
            // 
            // btnYardim
            // 
            btnYardim.BorderStyle = BorderStyle.FixedSingle;
            btnYardim.Controls.Add(label5);
            btnYardim.Controls.Add(pictureBox6);
            btnYardim.ForeColor = SystemColors.ControlText;
            btnYardim.HorizontalScrollbarBarColor = true;
            btnYardim.HorizontalScrollbarHighlightOnWheel = false;
            btnYardim.HorizontalScrollbarSize = 8;
            btnYardim.Location = new Point(0, 664);
            btnYardim.Margin = new Padding(3, 2, 3, 2);
            btnYardim.Name = "btnYardim";
            btnYardim.Size = new Size(175, 53);
            btnYardim.TabIndex = 7;
            btnYardim.VerticalScrollbarBarColor = true;
            btnYardim.VerticalScrollbarHighlightOnWheel = false;
            btnYardim.VerticalScrollbarSize = 9;
            btnYardim.Click += btnYardim_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(68, 18);
            label5.Name = "label5";
            label5.Size = new Size(52, 19);
            label5.TabIndex = 8;
            label5.Text = "Yardım";
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.White;
            pictureBox6.Image = Properties.Resources.help;
            pictureBox6.Location = new Point(21, 16);
            pictureBox6.Margin = new Padding(3, 2, 3, 2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(22, 19);
            pictureBox6.TabIndex = 6;
            pictureBox6.TabStop = false;
            // 
            // btnHakkimizda
            // 
            btnHakkimizda.BackColor = Color.Chartreuse;
            btnHakkimizda.BorderStyle = BorderStyle.FixedSingle;
            btnHakkimizda.Controls.Add(label6);
            btnHakkimizda.Controls.Add(pictureBox7);
            btnHakkimizda.HorizontalScrollbarBarColor = true;
            btnHakkimizda.HorizontalScrollbarHighlightOnWheel = false;
            btnHakkimizda.HorizontalScrollbarSize = 8;
            btnHakkimizda.Location = new Point(0, 715);
            btnHakkimizda.Margin = new Padding(3, 2, 3, 2);
            btnHakkimizda.Name = "btnHakkimizda";
            btnHakkimizda.Size = new Size(175, 53);
            btnHakkimizda.TabIndex = 6;
            btnHakkimizda.VerticalScrollbarBarColor = true;
            btnHakkimizda.VerticalScrollbarHighlightOnWheel = false;
            btnHakkimizda.VerticalScrollbarSize = 9;
            btnHakkimizda.Click += btnHakkimizda_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(58, 18);
            label6.Name = "label6";
            label6.Size = new Size(82, 19);
            label6.TabIndex = 9;
            label6.Text = "Hakkımızda";
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.White;
            pictureBox7.Image = Properties.Resources.about_us;
            pictureBox7.Location = new Point(21, 16);
            pictureBox7.Margin = new Padding(3, 2, 3, 2);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(22, 19);
            pictureBox7.TabIndex = 8;
            pictureBox7.TabStop = false;
            // 
            // btnAyarlar
            // 
            btnAyarlar.BorderStyle = BorderStyle.FixedSingle;
            btnAyarlar.Controls.Add(label4);
            btnAyarlar.Controls.Add(pictureBox5);
            btnAyarlar.Cursor = Cursors.Hand;
            btnAyarlar.HorizontalScrollbarBarColor = true;
            btnAyarlar.HorizontalScrollbarHighlightOnWheel = false;
            btnAyarlar.HorizontalScrollbarSize = 8;
            btnAyarlar.Location = new Point(0, 221);
            btnAyarlar.Margin = new Padding(3, 2, 3, 2);
            btnAyarlar.Name = "btnAyarlar";
            btnAyarlar.Size = new Size(175, 54);
            btnAyarlar.TabIndex = 5;
            btnAyarlar.VerticalScrollbarBarColor = true;
            btnAyarlar.VerticalScrollbarHighlightOnWheel = false;
            btnAyarlar.VerticalScrollbarSize = 9;
            btnAyarlar.Click += btnAyarlar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(66, 20);
            label4.Name = "label4";
            label4.Size = new Size(53, 19);
            label4.TabIndex = 6;
            label4.Text = "Ayarlar";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.White;
            pictureBox5.Image = Properties.Resources.settings;
            pictureBox5.Location = new Point(21, 18);
            pictureBox5.Margin = new Padding(3, 2, 3, 2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(22, 19);
            pictureBox5.TabIndex = 5;
            pictureBox5.TabStop = false;
            // 
            // btnDboard
            // 
            btnDboard.BorderStyle = BorderStyle.FixedSingle;
            btnDboard.Controls.Add(label1);
            btnDboard.Controls.Add(pictureBox2);
            btnDboard.Cursor = Cursors.Hand;
            btnDboard.HorizontalScrollbarBarColor = true;
            btnDboard.HorizontalScrollbarHighlightOnWheel = false;
            btnDboard.HorizontalScrollbarSize = 8;
            btnDboard.Location = new Point(0, 68);
            btnDboard.Margin = new Padding(3, 2, 3, 2);
            btnDboard.Name = "btnDboard";
            btnDboard.Size = new Size(175, 53);
            btnDboard.TabIndex = 4;
            btnDboard.VerticalScrollbarBarColor = true;
            btnDboard.VerticalScrollbarHighlightOnWheel = false;
            btnDboard.VerticalScrollbarSize = 9;
            btnDboard.Click += btnDboard_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(58, 19);
            label1.Name = "label1";
            label1.Size = new Size(76, 19);
            label1.TabIndex = 3;
            label1.Text = "Dashboard";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = Properties.Resources.home;
            pictureBox2.Location = new Point(21, 17);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(22, 19);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // btnAktiviteler
            // 
            btnAktiviteler.BorderStyle = BorderStyle.FixedSingle;
            btnAktiviteler.Controls.Add(label3);
            btnAktiviteler.Controls.Add(pictureBox4);
            btnAktiviteler.Cursor = Cursors.Hand;
            btnAktiviteler.HorizontalScrollbarBarColor = true;
            btnAktiviteler.HorizontalScrollbarHighlightOnWheel = false;
            btnAktiviteler.HorizontalScrollbarSize = 8;
            btnAktiviteler.Location = new Point(0, 171);
            btnAktiviteler.Margin = new Padding(3, 2, 3, 2);
            btnAktiviteler.Name = "btnAktiviteler";
            btnAktiviteler.Size = new Size(175, 53);
            btnAktiviteler.TabIndex = 3;
            btnAktiviteler.VerticalScrollbarBarColor = true;
            btnAktiviteler.VerticalScrollbarHighlightOnWheel = false;
            btnAktiviteler.VerticalScrollbarSize = 9;
            btnAktiviteler.Click += btnAktiviteler_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(58, 19);
            label3.Name = "label3";
            label3.Size = new Size(73, 19);
            label3.TabIndex = 5;
            label3.Text = "Aktiviteler";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.White;
            pictureBox4.Image = Properties.Resources.activities;
            pictureBox4.Location = new Point(21, 17);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(22, 19);
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // btnHayvanlar
            // 
            btnHayvanlar.BorderStyle = BorderStyle.FixedSingle;
            btnHayvanlar.Controls.Add(label2);
            btnHayvanlar.Controls.Add(pictureBox3);
            btnHayvanlar.Cursor = Cursors.Hand;
            btnHayvanlar.HorizontalScrollbarBarColor = true;
            btnHayvanlar.HorizontalScrollbarHighlightOnWheel = false;
            btnHayvanlar.HorizontalScrollbarSize = 8;
            btnHayvanlar.Location = new Point(0, 119);
            btnHayvanlar.Margin = new Padding(3, 2, 3, 2);
            btnHayvanlar.Name = "btnHayvanlar";
            btnHayvanlar.Size = new Size(175, 53);
            btnHayvanlar.TabIndex = 2;
            btnHayvanlar.VerticalScrollbarBarColor = true;
            btnHayvanlar.VerticalScrollbarHighlightOnWheel = false;
            btnHayvanlar.VerticalScrollbarSize = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(58, 18);
            label2.Name = "label2";
            label2.Size = new Size(71, 19);
            label2.TabIndex = 4;
            label2.Text = "Hayvanlar";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.Image = Properties.Resources.animals;
            pictureBox3.Location = new Point(21, 16);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(22, 19);
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // HayvanlarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1260, 768);
            Controls.Add(topbar);
            Controls.Add(sidebar);
            Controls.Add(dgvHayvanlar);
            Controls.Add(btnYeniHayvan);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "HayvanlarForm";
            Text = "Hayvanlar";
            Load += HayvanlarForm_Load;
            btnYeniHayvan.ResumeLayout(false);
            btnYeniHayvan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            topbar.ResumeLayout(false);
            topbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UserIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)LogOutIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvHayvanlar).EndInit();
            sidebar.ResumeLayout(false);
            btnYardim.ResumeLayout(false);
            btnYardim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            btnHakkimizda.ResumeLayout(false);
            btnHakkimizda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            btnAyarlar.ResumeLayout(false);
            btnAyarlar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            btnDboard.ResumeLayout(false);
            btnDboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            btnAktiviteler.ResumeLayout(false);
            btnAktiviteler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            btnHayvanlar.ResumeLayout(false);
            btnHayvanlar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.Panel btnYeniHayvan;
        private ReaLTaiizor.Controls.PoisonPanel btnHayvanlar;
        private ReaLTaiizor.Controls.PoisonPanel btnAktiviteler;
        private ReaLTaiizor.Controls.PoisonPanel btnDboard;
        private ReaLTaiizor.Controls.PoisonPanel btnAyarlar;
        private ReaLTaiizor.Controls.PoisonPanel btnYardim;
        private ReaLTaiizor.Controls.Panel topbar;
        private Label label7;
        private PictureBox pictureBox10;
        private PictureBox pictureBox9;
        private PictureBox LogOutIcon;
        private PictureBox pictureBox1;
        private PictureBox pictureBox11;
        private Label label8;
        // HayvanlarForm.Designer.cs dosyanızda, alan bildirimlerine şunu ekleyin:
        private PictureBox UserIcon;
        private DataGridView dgvHayvanlar;
        private ReaLTaiizor.Controls.PoisonPanel sidebar;
        private Label label5;
        private PictureBox pictureBox6;
        private ReaLTaiizor.Controls.PoisonPanel btnHakkimizda;
        private Label label6;
        private PictureBox pictureBox7;
        private Label label4;
        private PictureBox pictureBox5;
        private Label label1;
        private PictureBox pictureBox2;
        private Label label3;
        private PictureBox pictureBox4;
        private Label label2;
        private PictureBox pictureBox3;
        private DataGridViewButtonColumn btnSil;
    }
}