namespace PetTrackUI
{
    partial class AktivitelerForm
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            btnYeniAktivite = new ReaLTaiizor.Controls.Panel();
            label8 = new Label();
            pictureBox11 = new PictureBox();
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
            topbar = new ReaLTaiizor.Controls.Panel();
            label7 = new Label();
            pictureBox10 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox1 = new PictureBox();
            dgvAktiviteler = new DataGridView();
            TarihSaat = new DataGridViewTextBoxColumn();
            Durum = new DataGridViewTextBoxColumn();
            HayvanAd = new DataGridViewTextBoxColumn();
            AktiviteTuru = new DataGridViewTextBoxColumn();
            activity_id = new DataGridViewTextBoxColumn();
            Sure = new DataGridViewTextBoxColumn();
            Not = new DataGridViewTextBoxColumn();
            Sil = new DataGridViewButtonColumn();
            btnYeniAktivite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
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
            topbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAktiviteler).BeginInit();
            SuspendLayout();
            // 
            // btnYeniAktivite
            // 
            btnYeniAktivite.BackColor = Color.DodgerBlue;
            btnYeniAktivite.Controls.Add(label8);
            btnYeniAktivite.Controls.Add(pictureBox11);
            btnYeniAktivite.Cursor = Cursors.Hand;
            btnYeniAktivite.EdgeColor = Color.White;
            btnYeniAktivite.Location = new Point(1253, 103);
            btnYeniAktivite.Name = "btnYeniAktivite";
            btnYeniAktivite.Padding = new Padding(5, 5, 5, 5);
            btnYeniAktivite.Size = new Size(247, 60);
            btnYeniAktivite.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnYeniAktivite.TabIndex = 5;
            btnYeniAktivite.Text = "panel2";
            btnYeniAktivite.Click += btnYeniAktivite_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(77, 13);
            label8.Name = "label8";
            label8.Size = new Size(125, 28);
            label8.TabIndex = 11;
            label8.Text = "Yeni Aktivite";
            // 
            // pictureBox11
            // 
            pictureBox11.Image = Properties.Resources.plus;
            pictureBox11.Location = new Point(21, 13);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(30, 29);
            pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox11.TabIndex = 6;
            pictureBox11.TabStop = false;
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
            sidebar.HorizontalScrollbarSize = 11;
            sidebar.Location = new Point(0, 0);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(200, 1024);
            sidebar.TabIndex = 10;
            sidebar.VerticalScrollbarBarColor = true;
            sidebar.VerticalScrollbarHighlightOnWheel = false;
            sidebar.VerticalScrollbarSize = 10;
            // 
            // btnYardim
            // 
            btnYardim.BorderStyle = BorderStyle.FixedSingle;
            btnYardim.Controls.Add(label5);
            btnYardim.Controls.Add(pictureBox6);
            btnYardim.ForeColor = SystemColors.ControlText;
            btnYardim.HorizontalScrollbarBarColor = true;
            btnYardim.HorizontalScrollbarHighlightOnWheel = false;
            btnYardim.HorizontalScrollbarSize = 11;
            btnYardim.Location = new Point(0, 885);
            btnYardim.Name = "btnYardim";
            btnYardim.Size = new Size(200, 70);
            btnYardim.TabIndex = 7;
            btnYardim.VerticalScrollbarBarColor = true;
            btnYardim.VerticalScrollbarHighlightOnWheel = false;
            btnYardim.VerticalScrollbarSize = 10;
            btnYardim.Click += btnYardim_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(78, 24);
            label5.Name = "label5";
            label5.Size = new Size(62, 23);
            label5.TabIndex = 8;
            label5.Text = "Yardım";
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.White;
            pictureBox6.Image = Properties.Resources.help;
            pictureBox6.Location = new Point(24, 21);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(25, 25);
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
            btnHakkimizda.HorizontalScrollbarSize = 11;
            btnHakkimizda.Location = new Point(0, 953);
            btnHakkimizda.Name = "btnHakkimizda";
            btnHakkimizda.Size = new Size(200, 70);
            btnHakkimizda.TabIndex = 6;
            btnHakkimizda.VerticalScrollbarBarColor = true;
            btnHakkimizda.VerticalScrollbarHighlightOnWheel = false;
            btnHakkimizda.VerticalScrollbarSize = 10;
            btnHakkimizda.Click += btnHakkimizda_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(66, 24);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 9;
            label6.Text = "Hakkımızda";
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.White;
            pictureBox7.Image = Properties.Resources.about_us;
            pictureBox7.Location = new Point(24, 21);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(25, 25);
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
            btnAyarlar.HorizontalScrollbarSize = 11;
            btnAyarlar.Location = new Point(0, 295);
            btnAyarlar.Name = "btnAyarlar";
            btnAyarlar.Size = new Size(200, 71);
            btnAyarlar.TabIndex = 5;
            btnAyarlar.VerticalScrollbarBarColor = true;
            btnAyarlar.VerticalScrollbarHighlightOnWheel = false;
            btnAyarlar.VerticalScrollbarSize = 10;
            btnAyarlar.Click += btnAyarlar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(75, 27);
            label4.Name = "label4";
            label4.Size = new Size(64, 23);
            label4.TabIndex = 6;
            label4.Text = "Ayarlar";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.White;
            pictureBox5.Image = Properties.Resources.settings;
            pictureBox5.Location = new Point(24, 24);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(25, 25);
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
            btnDboard.HorizontalScrollbarSize = 11;
            btnDboard.Location = new Point(0, 91);
            btnDboard.Name = "btnDboard";
            btnDboard.Size = new Size(200, 70);
            btnDboard.TabIndex = 4;
            btnDboard.VerticalScrollbarBarColor = true;
            btnDboard.VerticalScrollbarHighlightOnWheel = false;
            btnDboard.VerticalScrollbarSize = 10;
            btnDboard.Click += btnDboard_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(66, 25);
            label1.Name = "label1";
            label1.Size = new Size(93, 23);
            label1.TabIndex = 3;
            label1.Text = "Dashboard";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = Properties.Resources.home;
            pictureBox2.Location = new Point(24, 23);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 25);
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
            btnAktiviteler.HorizontalScrollbarSize = 11;
            btnAktiviteler.Location = new Point(0, 228);
            btnAktiviteler.Name = "btnAktiviteler";
            btnAktiviteler.Size = new Size(200, 70);
            btnAktiviteler.TabIndex = 3;
            btnAktiviteler.VerticalScrollbarBarColor = true;
            btnAktiviteler.VerticalScrollbarHighlightOnWheel = false;
            btnAktiviteler.VerticalScrollbarSize = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(66, 25);
            label3.Name = "label3";
            label3.Size = new Size(87, 23);
            label3.TabIndex = 5;
            label3.Text = "Aktiviteler";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.White;
            pictureBox4.Image = Properties.Resources.activities;
            pictureBox4.Location = new Point(24, 23);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(25, 25);
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
            btnHayvanlar.HorizontalScrollbarSize = 11;
            btnHayvanlar.Location = new Point(0, 159);
            btnHayvanlar.Name = "btnHayvanlar";
            btnHayvanlar.Size = new Size(200, 70);
            btnHayvanlar.TabIndex = 2;
            btnHayvanlar.VerticalScrollbarBarColor = true;
            btnHayvanlar.VerticalScrollbarHighlightOnWheel = false;
            btnHayvanlar.VerticalScrollbarSize = 10;
            btnHayvanlar.Click += btnHayvanlar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(66, 24);
            label2.Name = "label2";
            label2.Size = new Size(88, 23);
            label2.TabIndex = 4;
            label2.Text = "Hayvanlar";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.Image = Properties.Resources.animals;
            pictureBox3.Location = new Point(24, 21);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 25);
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // topbar
            // 
            topbar.BackColor = Color.DodgerBlue;
            topbar.Controls.Add(label7);
            topbar.Controls.Add(pictureBox10);
            topbar.Controls.Add(pictureBox8);
            topbar.Controls.Add(pictureBox1);
            topbar.EdgeColor = SystemColors.Highlight;
            topbar.Location = new Point(0, 0);
            topbar.Name = "topbar";
            topbar.Padding = new Padding(5, 5, 5, 5);
            topbar.Size = new Size(1513, 92);
            topbar.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            topbar.TabIndex = 8;
            topbar.Text = "panel1";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.ForeColor = Color.White;
            label7.Location = new Point(1352, 36);
            label7.Name = "label7";
            label7.Size = new Size(56, 23);
            label7.TabIndex = 4;
            label7.Text = "J. Doe";
            label7.Click += label7_Click;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = Properties.Resources.person;
            pictureBox10.Location = new Point(1320, 36);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(25, 25);
            pictureBox10.TabIndex = 3;
            pictureBox10.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.log_out;
            pictureBox8.Location = new Point(1423, 36);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(25, 25);
            pictureBox8.TabIndex = 1;
            pictureBox8.TabStop = false;
            pictureBox8.Click += pictureBox8_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Enabled = false;
            pictureBox1.Image = Properties.Resources.petrackbeyaz;
            pictureBox1.Location = new Point(21, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(149, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dgvAktiviteler
            // 
            dgvAktiviteler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAktiviteler.Columns.AddRange(new DataGridViewColumn[] { TarihSaat, Durum, HayvanAd, AktiviteTuru, activity_id, Sure, Not, Sil });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Window;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dgvAktiviteler.DefaultCellStyle = dataGridViewCellStyle7;
            dgvAktiviteler.Location = new Point(326, 296);
            dgvAktiviteler.Name = "dgvAktiviteler";
            dgvAktiviteler.RowHeadersWidth = 51;
            dgvAktiviteler.Size = new Size(1034, 557);
            dgvAktiviteler.TabIndex = 0;
            dgvAktiviteler.CellContentClick += dgvAktiviteler_CellContentClick;
            // 
            // TarihSaat
            // 
            TarihSaat.DataPropertyName = "Tarih";
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            TarihSaat.DefaultCellStyle = dataGridViewCellStyle1;
            TarihSaat.HeaderText = "Tarih & Saat";
            TarihSaat.MinimumWidth = 6;
            TarihSaat.Name = "TarihSaat";
            TarihSaat.Width = 125;
            // 
            // Durum
            // 
            Durum.DataPropertyName = "Durum";
            Durum.HeaderText = "Column1";
            Durum.MinimumWidth = 6;
            Durum.Name = "Durum";
            Durum.Visible = false;
            Durum.Width = 125;
            // 
            // HayvanAd
            // 
            HayvanAd.DataPropertyName = "Hayvan";
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            HayvanAd.DefaultCellStyle = dataGridViewCellStyle2;
            HayvanAd.HeaderText = "Hayvan";
            HayvanAd.MinimumWidth = 6;
            HayvanAd.Name = "HayvanAd";
            HayvanAd.Width = 125;
            // 
            // AktiviteTuru
            // 
            AktiviteTuru.DataPropertyName = "Aktivite Türü";
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            AktiviteTuru.DefaultCellStyle = dataGridViewCellStyle3;
            AktiviteTuru.HeaderText = "Aktivite Türü";
            AktiviteTuru.MinimumWidth = 6;
            AktiviteTuru.Name = "AktiviteTuru";
            AktiviteTuru.Width = 125;
            // 
            // activity_id
            // 
            activity_id.DataPropertyName = "activity_id";
            activity_id.HeaderText = "activity_id";
            activity_id.MinimumWidth = 6;
            activity_id.Name = "activity_id";
            activity_id.Width = 125;
            // 
            // Sure
            // 
            Sure.DataPropertyName = "Süre(Dk)";
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Sure.DefaultCellStyle = dataGridViewCellStyle4;
            Sure.HeaderText = "Süre(Dakika)";
            Sure.MinimumWidth = 6;
            Sure.Name = "Sure";
            Sure.Width = 125;
            // 
            // Not
            // 
            Not.DataPropertyName = "Not";
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Not.DefaultCellStyle = dataGridViewCellStyle5;
            Not.HeaderText = "Not";
            Not.MinimumWidth = 6;
            Not.Name = "Not";
            Not.Width = 125;
            // 
            // Sil
            // 
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Sil.DefaultCellStyle = dataGridViewCellStyle6;
            Sil.HeaderText = "Sil";
            Sil.MinimumWidth = 6;
            Sil.Name = "Sil";
            Sil.Width = 125;
            // 
            // AktivitelerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1512, 1024);
            Controls.Add(dgvAktiviteler);
            Controls.Add(topbar);
            Controls.Add(sidebar);
            Controls.Add(btnYeniAktivite);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AktivitelerForm";
            Text = "Aktiviteler";
            Load += AktivitelerForm_Load;
            btnYeniAktivite.ResumeLayout(false);
            btnYeniAktivite.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
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
            topbar.ResumeLayout(false);
            topbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAktiviteler).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.Panel btnYeniAktivite;

        // Add this method to your AktivitelerForm class (e.g., in AktivitelerForm.cs)
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // You can leave this empty if you don't need custom painting logic
        }
        private ReaLTaiizor.Controls.PoisonPanel sidebar;
        private ReaLTaiizor.Controls.PoisonPanel btnYardim;
        private Label label5;
        private PictureBox pictureBox6;
        private ReaLTaiizor.Controls.PoisonPanel btnHakkimizda;
        private Label label6;
        private PictureBox pictureBox7;
        private ReaLTaiizor.Controls.PoisonPanel btnAyarlar;
        private Label label4;
        private PictureBox pictureBox5;
        private ReaLTaiizor.Controls.PoisonPanel btnDboard;
        private Label label1;
        private PictureBox pictureBox2;
        private ReaLTaiizor.Controls.PoisonPanel btnAktiviteler;
        private Label label3;
        private PictureBox pictureBox4;
        private ReaLTaiizor.Controls.PoisonPanel btnHayvanlar;
        private Label label2;
        private PictureBox pictureBox3;
        private ReaLTaiizor.Controls.Panel topbar;
        private Label label7;
        private PictureBox pictureBox10;
        private PictureBox pictureBox8;
        private PictureBox pictureBox1;
        private PictureBox pictureBox11;
        private Label label8;
        private DataGridView dgvAktiviteler;
        private DataGridViewTextBoxColumn TarihSaat;
        private DataGridViewTextBoxColumn Durum;
        private DataGridViewTextBoxColumn HayvanAd;
        private DataGridViewTextBoxColumn AktiviteTuru;
        private DataGridViewTextBoxColumn activity_id;
        private DataGridViewTextBoxColumn Sure;
        private DataGridViewTextBoxColumn Not;
        private DataGridViewButtonColumn Sil;
    }
}