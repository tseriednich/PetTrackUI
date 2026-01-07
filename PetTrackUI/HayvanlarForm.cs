using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PetTrackUI.Helpers; // Oturum sistemi için

namespace PetTrackUI
{
    public partial class HayvanlarForm : Form
    {
        // Veritabanı bağlantı adresi
        string baglantiAdresi = "Server=localhost;Port=3306;Database=pettrackdb;Uid=root;Pwd='';";

        public HayvanlarForm()
        {
            InitializeComponent();

            // SİLME BUTONU İÇİN GÜVENLİK ÖNLEMİ:
            // Tasarım ekranında "Sil" butonunun tıklama olayını bağlamayı unutursan diye,
            // burada kod ile elle bağlıyoruz. Garanti çalışması için.
            this.dgvHayvanlar.CellContentClick += new DataGridViewCellEventHandler(this.dgvHayvanlar_CellContentClick);
        }

        // --- 1. FORM YÜKLENİNCE ÇALIŞACAK ---
        private void HayvanlarForm_Load(object sender, EventArgs e)
        {
            Listele(); // Form açılır açılmaz listeyi getir
        }

        // --- 2. LİSTELEME METODU ---
        private void Listele()
        {
            using (MySqlConnection baglanti = new MySqlConnection(baglantiAdresi))
            {
                try
                {
                    baglanti.Open();

                    // Sadece giriş yapan kullanıcının (user_id) hayvanlarını getir
                    // is_active = 1 olanları (yani silinmemişleri) çekiyoruz.
                    string sorgu = @"
                        SELECT 
                            pet_id AS ID,
                            name AS İsim,
                            species AS Tür,
                            breed AS Irk,
                            gender AS Cinsiyet,
                            birth_date AS 'Doğum Tarihi',
                            notes AS Notlar
                        FROM pets 
                        WHERE user_id = (SELECT user_id FROM users WHERE email=@mail) 
                        AND is_active = 1";

                    MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@mail", Oturum.SimdikiKullanici.Email);

                    // Verileri tabloya dökmek için 'DataAdapter' kullanıyoruz
                    MySqlDataAdapter da = new MySqlDataAdapter(komut);
                    DataTable dt = new DataTable();
                    da.Fill(dt); // Verileri sanal tabloya (dt) doldur

                    // Sanal tabloyu ekrandaki Grid'e bağla
                    dgvHayvanlar.DataSource = dt;

                    // Görsel Ayarlar
                    dgvHayvanlar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Sütunları ekrana yay

                    // ID sütununu gizle (Kullanıcı görmesin ama biz silerken kullanacağız)
                    if (dgvHayvanlar.Columns["ID"] != null)
                    {
                        dgvHayvanlar.Columns["ID"].Visible = false;
                    }
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Listeleme hatası: " + hata.Message);
                }
            }
        }

        // --- 3. TABLOYA TIKLAMA (SİLME İŞLEMİ) ---
        private void dgvHayvanlar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Eğer başlık satırına veya geçersiz bir yere tıklandıysa işlem yapma
            if (e.RowIndex < 0) return;

            // Tıklanan sütunun adı "Sil" veya "btnSil" mi?
            // (Tasarımda verdiğin isme göre ikisini de kontrol ediyoruz)
            string sutunAdi = dgvHayvanlar.Columns[e.ColumnIndex].Name;

            if (sutunAdi == "Sil" || sutunAdi == "btnSil")
            {
                // Kullanıcıya soralım
                DialogResult cevap = MessageBox.Show("Bu kaydı silmek istediğinize emin misiniz?",
                                                     "Silme Onayı",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);

                if (cevap == DialogResult.Yes)
                {
                    // Seçilen satırdaki "ID" değerini al
                    if (dgvHayvanlar.Rows[e.RowIndex].Cells["ID"].Value != null)
                    {
                        int secilenId = Convert.ToInt32(dgvHayvanlar.Rows[e.RowIndex].Cells["ID"].Value);

                        // Silme metodunu çağır
                        HayvanSil(secilenId);
                    }
                }
            }
        }

        // --- 4. VERİTABANINDAN SİLME (SOFT DELETE) ---
        private void HayvanSil(int id)
        {
            using (MySqlConnection baglanti = new MySqlConnection(baglantiAdresi))
            {
                try
                {
                    baglanti.Open();

                    // Kaydı tamamen silmek yerine 'is_active' değerini 0 yapıyoruz.
                    // Böylece veri kaybolmuyor ama listede görünmüyor.
                    string sorgu = "UPDATE pets SET is_active = 0 WHERE pet_id = @id";

                    MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@id", id);

                    int sonuc = komut.ExecuteNonQuery();

                    if (sonuc > 0)
                    {
                        MessageBox.Show("Kayıt başarıyla silindi. 🗑️");
                        Listele(); // Listeyi yenile ki silinen satır ekrandan gitsin
                    }
                    else
                    {
                        MessageBox.Show("Silme işlemi yapılamadı.");
                    }
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Silme sırasında hata oluştu: " + hata.Message);
                }
            }
        }

        // --- 5. YENİ HAYVAN EKLEME BUTONU ---
        private void btnYeniHayvan_Click(object sender, EventArgs e)
        {
            HayvanEkleForm ekleFormu = new HayvanEkleForm();
            ekleFormu.ShowDialog(); // Form kapanana kadar bekle
            Listele(); // Form kapandıktan sonra listeyi yenile
        }

        // --- 6. MENÜ GEÇİŞ BUTONLARI ---
        private void btnDboard_Click(object sender, EventArgs e)
        {
            DashboardForm dashboard = new DashboardForm();
            dashboard.Show();
            this.Hide();
        }

        private void btnAktiviteler_Click(object sender, EventArgs e)
        {
            AktivitelerForm aktiviteler = new AktivitelerForm();
            aktiviteler.Show();
            this.Hide();
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            AyarlarForm ayarlar = new AyarlarForm();
            ayarlar.Show();
            this.Hide();
        }

        private void btnYardim_Click(object sender, EventArgs e)
        {
            YardimForm yardim = new YardimForm();
            yardim.Show();
            this.Hide();
        }

        private void btnHakkimizda_Click(object sender, EventArgs e)
        {
            HakkimizdaForm hakkimizda = new HakkimizdaForm();
            hakkimizda.Show();
            this.Hide();
        }

        // Tasarımda yanlışlıkla oluşturulmuş boş tıklama olayları (Hata vermemesi için kalsın)
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void LogOutIcon_Click(object sender, EventArgs e)
        {
            Oturum.SimdikiKullanici = null;
            GirisFormu giris = new GirisFormu();
            giris.Show();
            this.Close();
        }
    }
}