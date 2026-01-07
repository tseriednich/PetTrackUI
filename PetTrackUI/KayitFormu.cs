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
using PetTrack.Data; // Eğer namespace farklıysa burayı kendi projene göre düzenle

namespace PetTrackUI
{
    public partial class KayitFormu : Form
    {
        // Veritabanı bağlantı cümlen (Kendi ayarına göre kontrol et)
        string baglantiAdresi = "Server=localhost;Port=3306;Database=pettrackdb;Uid=root;Pwd='';";

        public KayitFormu()
        {
            InitializeComponent();
        }

        // --- 1. VALIDATION (Doğrulama) KURALLARI ---
        private bool ValidasyonKontrol()
        {
            // Kural 1: Boş Alan Kontrolü
            if (string.IsNullOrWhiteSpace(AdTextBox.Text) ||
                string.IsNullOrWhiteSpace(SoyadTextBox.Text) ||
                string.IsNullOrWhiteSpace(epostaTextBox.Text) ||
                string.IsNullOrWhiteSpace(sifreTextBox.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Kural 2: E-posta Format Kontrolü
            if (!epostaTextBox.Text.Contains("@") || !epostaTextBox.Text.Contains("."))
            {
                MessageBox.Show("Lütfen geçerli bir e-posta adresi giriniz (Örn: isim@mail.com).", "Format Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Kural 3: Şifre Uzunluğu (En az 6 karakter)
            if (sifreTextBox.Text.Length < 6)
            {
                MessageBox.Show("Güvenliğiniz için şifreniz en az 6 karakter olmalıdır.", "Zayıf Şifre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Kural 4: Şifre Eşleşmesi
            if (sifreTextBox.Text != sifre_tekrarTextBox.Text)
            {
                MessageBox.Show("Girdiğiniz şifreler birbiriyle uyuşmuyor.", "Şifre Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true; // Her şey yolunda
        }

        private void KayitOlBtn_Click(object sender, EventArgs e)
        {
            // Önce kuralları kontrol et, hata varsa dur.
            if (ValidasyonKontrol() == false) return;

            // --- 2. VERİ HAZIRLAMA ---

            // İsim ve Soyismi birleştirip "Full Name" yapıyoruz
            string tamIsim = AdTextBox.Text.Trim() + " " + SoyadTextBox.Text.Trim();

            // OTOMATİK USERNAME: E-postanın baş kısmını alıyoruz
            // Örnek: samet@gmail.com -> samet
            string otomatikKullaniciAdi = epostaTextBox.Text.Split('@')[0];

            // Eğer çok uzunsa veritabanı patlamasın diye ilk 50 karakteri al
            if (otomatikKullaniciAdi.Length > 50)
                otomatikKullaniciAdi = otomatikKullaniciAdi.Substring(0, 50);

            // --- 3. VERİTABANI İŞLEMİ ---
            using (MySqlConnection baglanti = new MySqlConnection(baglantiAdresi))
            {
                try
                {
                    baglanti.Open();

                    // A) E-posta daha önce kayıtlı mı?
                    string kontrolSorgusu = "SELECT COUNT(*) FROM users WHERE email = @mail";
                    MySqlCommand kontrolKomut = new MySqlCommand(kontrolSorgusu, baglanti);
                    kontrolKomut.Parameters.AddWithValue("@mail", epostaTextBox.Text.Trim());

                    int kayitSayisi = Convert.ToInt32(kontrolKomut.ExecuteScalar());

                    if (kayitSayisi > 0)
                    {
                        MessageBox.Show("Bu E-posta adresi zaten sistemde kayıtlı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }

                    // B) Yeni Kayıt Ekleme
                    // NOT: 'username' alanını ekledik çünkü veritabanına geri getirdin.
                    string eklemeSorgusu = "INSERT INTO users (full_name, email, username, password_hash) VALUES (@tamAd, @email, @kullaniciAdi, @sifre)";

                    MySqlCommand ekleKomut = new MySqlCommand(eklemeSorgusu, baglanti);
                    ekleKomut.Parameters.AddWithValue("@tamAd", tamIsim);
                    ekleKomut.Parameters.AddWithValue("@email", epostaTextBox.Text.Trim());
                    ekleKomut.Parameters.AddWithValue("@kullaniciAdi", otomatikKullaniciAdi);
                    ekleKomut.Parameters.AddWithValue("@sifre", sifreTextBox.Text); // Şifreleme yapmadan kaydediyoruz (Şimdilik)

                    int sonuc = ekleKomut.ExecuteNonQuery();

                    if (sonuc > 0)
                    {
                        MessageBox.Show("Kayıt Başarılı! Giriş ekranına yönlendiriliyorsunuz.", "Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Giriş Formuna Git
                        GirisFormu giris = new GirisFormu();
                        giris.Show();
                        this.Hide();
                    }
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Veritabanı hatası: " + hata.Message, "Kritik Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Bu metot sende boştu, şimdilik boş kalabilir veya silebilirsin.
        private void AdTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void lnkGirisYap_Click(object sender, EventArgs e)
        {
            GirisFormu giris = new GirisFormu();
            giris.Show();
            this.Hide();
        }
    }
}