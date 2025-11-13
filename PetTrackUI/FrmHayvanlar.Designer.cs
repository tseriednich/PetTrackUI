namespace PetTrackUI
{
    partial class FrmHayvanlar
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            txtAra = new ReaLTaiizor.Controls.PoisonTextBox();
            cmbTur = new ReaLTaiizor.Controls.PoisonComboBox();
            gridHayvanlar = new ReaLTaiizor.Controls.PoisonDataGridView();
            btnEkle = new ReaLTaiizor.Controls.PoisonButton();
            btnDuzenle = new ReaLTaiizor.Controls.PoisonButton();
            btnSil = new ReaLTaiizor.Controls.PoisonButton();
            colAd = new DataGridViewTextBoxColumn();
            colTur = new DataGridViewTextBoxColumn();
            colIrk = new DataGridViewTextBoxColumn();
            colDogum = new DataGridViewTextBoxColumn();
            colCinsiyet = new DataGridViewTextBoxColumn();
            colSahip = new DataGridViewTextBoxColumn();
            colNot = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)gridHayvanlar).BeginInit();
            SuspendLayout();
            // 
            // txtAra
            // 
            // 
            // 
            // 
            txtAra.CustomButton.Image = null;
            txtAra.CustomButton.Location = new Point(142, 2);
            txtAra.CustomButton.Name = "";
            txtAra.CustomButton.Size = new Size(25, 25);
            txtAra.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            txtAra.CustomButton.TabIndex = 1;
            txtAra.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            txtAra.CustomButton.UseSelectable = true;
            txtAra.CustomButton.Visible = false;
            txtAra.Location = new Point(30, 106);
            txtAra.MaxLength = 32767;
            txtAra.Name = "txtAra";
            txtAra.PasswordChar = '\0';
            txtAra.PromptText = "Hayvanın adını giriniz...";
            txtAra.ScrollBars = ScrollBars.None;
            txtAra.SelectedText = "";
            txtAra.SelectionLength = 0;
            txtAra.SelectionStart = 0;
            txtAra.ShortcutsEnabled = true;
            txtAra.Size = new Size(170, 30);
            txtAra.TabIndex = 0;
            txtAra.UseSelectable = true;
            txtAra.WaterMark = "Hayvanın adını giriniz...";
            txtAra.WaterMarkColor = Color.FromArgb(109, 109, 109);
            txtAra.WaterMarkFont = new Font("Segoe UI", 13F, FontStyle.Italic, GraphicsUnit.Pixel);
            txtAra.Click += txtAra_Click;
            // 
            // cmbTur
            // 
            cmbTur.FormattingEnabled = true;
            cmbTur.ItemHeight = 24;
            cmbTur.Location = new Point(300, 106);
            cmbTur.Name = "cmbTur";
            cmbTur.Size = new Size(170, 30);
            cmbTur.TabIndex = 1;
            cmbTur.UseSelectable = true;
            // 
            // gridHayvanlar
            // 
            gridHayvanlar.AllowUserToResizeRows = false;
            gridHayvanlar.BackgroundColor = Color.FromArgb(255, 255, 255);
            gridHayvanlar.BorderStyle = BorderStyle.None;
            gridHayvanlar.CellBorderStyle = DataGridViewCellBorderStyle.None;
            gridHayvanlar.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            gridHayvanlar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            gridHayvanlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridHayvanlar.Columns.AddRange(new DataGridViewColumn[] { colAd, colTur, colIrk, colDogum, colCinsiyet, colSahip, colNot });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            gridHayvanlar.DefaultCellStyle = dataGridViewCellStyle2;
            gridHayvanlar.EnableHeadersVisualStyles = false;
            gridHayvanlar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            gridHayvanlar.GridColor = Color.FromArgb(255, 255, 255);
            gridHayvanlar.Location = new Point(39, 170);
            gridHayvanlar.Name = "gridHayvanlar";
            gridHayvanlar.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            gridHayvanlar.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            gridHayvanlar.RowHeadersWidth = 51;
            gridHayvanlar.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            gridHayvanlar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridHayvanlar.Size = new Size(920, 380);
            gridHayvanlar.TabIndex = 2;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(547, 500);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(94, 29);
            btnEkle.TabIndex = 3;
            btnEkle.Text = "Ekle";
            btnEkle.UseSelectable = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnDuzenle
            // 
            btnDuzenle.Location = new Point(669, 500);
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new Size(94, 29);
            btnDuzenle.TabIndex = 4;
            btnDuzenle.Text = "Düzenle";
            btnDuzenle.UseSelectable = true;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(844, 500);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(94, 29);
            btnSil.TabIndex = 5;
            btnSil.Text = "Sil";
            btnSil.UseSelectable = true;
            btnSil.Click += poisonButton3_Click;
            // 
            // colAd
            // 
            colAd.HeaderText = "Ad";
            colAd.MinimumWidth = 6;
            colAd.Name = "colAd";
            colAd.Width = 125;
            // 
            // colTur
            // 
            colTur.HeaderText = "Tür";
            colTur.MinimumWidth = 6;
            colTur.Name = "colTur";
            colTur.Width = 125;
            // 
            // colIrk
            // 
            colIrk.HeaderText = "Irk";
            colIrk.MinimumWidth = 6;
            colIrk.Name = "colIrk";
            colIrk.Width = 125;
            // 
            // colDogum
            // 
            colDogum.HeaderText = "Doğum Tarihi";
            colDogum.MinimumWidth = 6;
            colDogum.Name = "colDogum";
            colDogum.Width = 125;
            // 
            // colCinsiyet
            // 
            colCinsiyet.HeaderText = "Cinsiyet";
            colCinsiyet.MinimumWidth = 6;
            colCinsiyet.Name = "colCinsiyet";
            colCinsiyet.Width = 125;
            // 
            // colSahip
            // 
            colSahip.HeaderText = "Sahip";
            colSahip.MinimumWidth = 6;
            colSahip.Name = "colSahip";
            colSahip.Width = 125;
            // 
            // colNot
            // 
            colNot.HeaderText = "Not";
            colNot.MinimumWidth = 6;
            colNot.Name = "colNot";
            colNot.Width = 125;
            // 
            // FrmHayvanlar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 600);
            Controls.Add(btnSil);
            Controls.Add(btnDuzenle);
            Controls.Add(btnEkle);
            Controls.Add(gridHayvanlar);
            Controls.Add(cmbTur);
            Controls.Add(txtAra);
            MaximizeBox = false;
            Name = "FrmHayvanlar";
            Text = "Hayvanlar";
            Load += FrmHayvanlar_Load;
            ((System.ComponentModel.ISupportInitialize)gridHayvanlar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.PoisonTextBox txtAra;
        private ReaLTaiizor.Controls.PoisonComboBox cmbTur;
        private ReaLTaiizor.Controls.PoisonDataGridView gridHayvanlar;
        private ReaLTaiizor.Controls.PoisonButton btnEkle;
        private ReaLTaiizor.Controls.PoisonButton btnDuzenle;
        private ReaLTaiizor.Controls.PoisonButton btnSil;
        private DataGridViewTextBoxColumn colAd;
        private DataGridViewTextBoxColumn colTur;
        private DataGridViewTextBoxColumn colIrk;
        private DataGridViewTextBoxColumn colDogum;
        private DataGridViewTextBoxColumn colCinsiyet;
        private DataGridViewTextBoxColumn colSahip;
        private DataGridViewTextBoxColumn colNot;
    }
}