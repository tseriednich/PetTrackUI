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
using PetTrack.Data;     // Kullanici sinifi için
using PetTrackUI.Helpers; // Oturum sinifi için

namespace PetTrackUI
{
    public partial class GirisFormu : Form
    {
        public GirisFormu()
        {
            InitializeComponent();
        }

        // --- Tasarımda yanlışlıkla oluşturulan boş tıklama alanları (Silme, hata verebilir) ---
        private void label1_Click(object sender, EventArgs e) { }
        private void pictureBox2_Click(object sender, EventArgs e) { }
        private void GirisFormu_Load(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        // -------------------------------------------------------------------------------------

        // GİRİŞ BUTONU (Senin butonunun adı bu şekilde kalmış, sorun yok)
        private void GirisYapTextBox_Click(object sender, EventArgs e)
        {
            string baglantiAdresi = "Server=localhost;Port=3306;Database=pettrackdb;Uid=root;Pwd='';";

            using (MySqlConnection baglanti = new MySqlConnection(baglantiAdresi))
            {
                try
                {
                    baglanti.Open();

                    // E-posta ve Şifre kontrolü
                    string sorgu = "SELECT * FROM users WHERE email=@mail AND password_hash=@sifre";
                    MySqlCommand komut = new MySqlCommand(sorgu, baglanti);

                    // Parametreleri ekle
                    komut.Parameters.AddWithValue("@mail", EpostaTextbox.Text);
                    komut.Parameters.AddWithValue("@sifre", SifreTextBox.Text);

                    MySqlDataReader okuyucu = komut.ExecuteReader();

                    if (okuyucu.Read())
                    {
                        // --- GİRİŞ BAŞARILI ---

                        // 1. Veritabanından gelen veriyi 'Kullanici' nesnesine çeviriyoruz.
                        // Böylece Oturum sınıfı bunu anlayabilecek.
                        Kullanici girisYapan = new Kullanici();

                        // Veritabanındaki 'full_name'i alıp nesnemizin Ad özelliğine atıyoruz
                        girisYapan.AdSoyad = okuyucu["full_name"].ToString(); // DOĞRU (Eğer ismi AdSoyad ise)
                        girisYapan.Email = okuyucu["email"].ToString();
                        // (Veritabanında ID kolonu varsa onu da alabiliriz ama şimdilik isim yeterli)

                        // 2. HAFIZA İŞLEMİ (Session)
                        // Artık programın her yerinde "Oturum.SimdikiKullanici" diyerek bu kişiye ulaşabilirsin.
                        Oturum.SimdikiKullanici = girisYapan;

                        // 3. BENİ HATIRLA İŞLEMİ
                        // Checkbox işaretliyse ayarları kaydeder.
                        Oturum.BilgileriHatirla(EpostaTextbox.Text, SifreTextBox.Text, chkBeniHatirla.Checked);

                        MessageBox.Show("Hoşgeldin " + girisYapan.AdSoyad, "Giriş Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // 4. Dashboard'u aç
                        // Giriş başarılı! Artık Ana Menüye (Dashboard) gidiyoruz.
                        DashboardForm anaMenu = new DashboardForm(); // Formunun adı 'DashboardForm' değilse düzelt
                        anaMenu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("E-posta veya şifre hatalı.", "Giriş Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Bağlantı Hatası: " + hata.Message);
                }
            }
        }

        private void lnkKayitOl_Click(object sender, EventArgs e)
        {
            // 1. Kayıt formunu hazırla
            KayitFormu kayitSayfasi = new KayitFormu();

            // 2. Kayıt formunu aç
            kayitSayfasi.Show();

            // 3. Giriş formunu (şu anki pencereyi) gizle
            this.Hide();
        }
    }
}