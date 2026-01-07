using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PetTrackUI.Helpers; // Oturum sistemi klasörün

namespace PetTrackUI
{
    public partial class AktivitelerForm : Form
    {
        // Veritabanı bağlantı adresin (Standart)
        string baglantiAdresi = "Server=localhost;Port=3306;Database=pettrackdb;Uid=root;Pwd='';";

        public AktivitelerForm()
        {
            InitializeComponent();
        }

        // 1. FORM YÜKLENİRKEN LİSTEYİ GETİR
        private void AktivitelerForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        // 2. LİSTELEME METODU (Verileri çeker ve tabloya işler)
        private void Listele()
        {
            using (MySqlConnection baglanti = new MySqlConnection(baglantiAdresi))
            {
                try
                {
                    baglanti.Open();

                    // Sadece 'Planlandı' olanları ve gerekli detayları çeken sorgu
                    string sorgu = @"SELECT 
                                     a.activity_id, 
                                     p.name as HayvanAd, 
                                     t.name as activity_type,        
                                     a.scheduled_at as activity_date, 
                                     a.status as Durum,
                                     a.duration_min as duration,     
                                     a.notes 
                                     FROM activities a 
                                     JOIN pets p ON a.pet_id = p.pet_id
                                     JOIN activity_types t ON a.activity_type_id = t.activity_type_id
                                     WHERE a.status = 'Planlandı'";

                    MySqlCommand komut = new MySqlCommand(sorgu, baglanti);

                    MySqlDataAdapter da = new MySqlDataAdapter(komut);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // --- SÜTUN EŞLEŞTİRME AYARLARI ---
                    dgvAktiviteler.AutoGenerateColumns = false; // Otomatik sütun oluşturmayı engelle

                    // DataGridView'deki sütunların veritabanındaki karşılıklarını belirtiyoruz
                    if (dgvAktiviteler.Columns.Contains("HayvanAd"))
                        dgvAktiviteler.Columns["HayvanAd"].DataPropertyName = "HayvanAd";

                    if (dgvAktiviteler.Columns.Contains("AktiviteTuru"))
                        dgvAktiviteler.Columns["AktiviteTuru"].DataPropertyName = "activity_type";

                    if (dgvAktiviteler.Columns.Contains("TarihSaat"))
                        dgvAktiviteler.Columns["TarihSaat"].DataPropertyName = "activity_date";

                    if (dgvAktiviteler.Columns.Contains("Durum"))
                        dgvAktiviteler.Columns["Durum"].DataPropertyName = "Durum";

                    if (dgvAktiviteler.Columns.Contains("Sure"))
                        dgvAktiviteler.Columns["Sure"].DataPropertyName = "duration";

                    if (dgvAktiviteler.Columns.Contains("Not"))
                        dgvAktiviteler.Columns["Not"].DataPropertyName = "notes";

                    // Gizli ID sütunu (Silme işlemi için gerekli)
                    if (dgvAktiviteler.Columns.Contains("activity_id"))
                        dgvAktiviteler.Columns["activity_id"].DataPropertyName = "activity_id";

                    // Veriyi tabloya bas
                    dgvAktiviteler.DataSource = dt;

                    // ID sütununu kullanıcıdan gizle
                    if (dgvAktiviteler.Columns["activity_id"] != null)
                        dgvAktiviteler.Columns["activity_id"].Visible = false;

                }
                catch (Exception hata)
                {
                    MessageBox.Show("Listeleme hatası: " + hata.Message);
                }
            }
        }

        // 3. YENİ AKTİVİTE EKLE BUTONU
        private void btnYeniAktivite_Click(object sender, EventArgs e)
        {
            AktiviteEkleForm form = new AktiviteEkleForm();
            form.ShowDialog(); // Form kapanana kadar bekle
            Listele(); // Form kapanınca listeyi yenile
        }

        // 4. TABLOYA TIKLAMA (SİL BUTONU İŞLEMİ)
        private void dgvAktiviteler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Geçersiz bir satıra veya başlığa tıklandıysa işlem yapma
            if (e.RowIndex < 0) return;

            // Tıklanan sütunun adı "Sil" ise (Tasarım ekranındaki sütun adı önemli!)
            // Eğer butonunun adı 'btnSil' ise burayı 'btnSil' yapmalısın.
            if (dgvAktiviteler.Columns[e.ColumnIndex].Name == "Sil" ||
                dgvAktiviteler.Columns[e.ColumnIndex].Name == "btnSil")
            {
                // Silme onayı iste
                DialogResult cevap = MessageBox.Show("Bu aktiviteyi silmek istediğinize emin misiniz?",
                                                     "Silme Onayı",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Warning);

                if (cevap == DialogResult.Yes)
                {
                    // ID hücresinin boş olup olmadığını kontrol et
                    if (dgvAktiviteler.Rows[e.RowIndex].Cells["activity_id"].Value != null)
                    {
                        int secilenId = Convert.ToInt32(dgvAktiviteler.Rows[e.RowIndex].Cells["activity_id"].Value);
                        KaydiSil(secilenId); // Silme metodunu çağır
                    }
                }
            }
        }

        // 5. YARDIMCI SİLME METODU (Veritabanından siler)
        private void KaydiSil(int id)
        {
            using (MySqlConnection baglanti = new MySqlConnection(baglantiAdresi))
            {
                try
                {
                    baglanti.Open();
                    string sorgu = "DELETE FROM activities WHERE activity_id = @id";
                    MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@id", id);

                    int sonuc = komut.ExecuteNonQuery();

                    if (sonuc > 0)
                    {
                        MessageBox.Show("Kayıt başarıyla silindi. 🗑️");
                        Listele(); // Listeyi güncelle
                    }
                    else
                    {
                        MessageBox.Show("Silinecek kayıt bulunamadı.");
                    }
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Silme işlemi sırasında hata: " + hata.Message);
                }
            }
        }

        // 6. MENÜ GEÇİŞ BUTONLARI
        private void btnDboard_Click(object sender, EventArgs e)
        {
            DashboardForm f = new DashboardForm();
            f.Show();
            this.Hide();
        }

        private void btnHayvanlar_Click(object sender, EventArgs e)
        {
            HayvanlarForm f = new HayvanlarForm();
            f.Show();
            this.Hide();
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            AyarlarForm f = new AyarlarForm();
            f.Show();
            this.Hide();
        }

        private void btnYardim_Click(object sender, EventArgs e)
        {
            YardimForm f = new YardimForm();
            f.Show();
            this.Hide();
        }

        private void btnHakkimizda_Click(object sender, EventArgs e)
        {
            HakkimizdaForm f = new HakkimizdaForm();
            f.Show();
            this.Hide();
        }

        // Boş tıklamalar (Tasarım hatası olmasın diye bıraktım)
        private void pictureBox8_Click(object sender, EventArgs e) {
            Oturum.SimdikiKullanici = null;
            GirisFormu giris = new GirisFormu();
            giris.Show();
            this.Close();
        }
        private void label7_Click(object sender, EventArgs e) { }
    }
}