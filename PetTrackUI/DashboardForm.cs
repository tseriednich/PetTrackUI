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
using PetTrackUI.Helpers;

namespace PetTrackUI
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            DashboardVerileriniGetir();
        }
        private void DashboardVerileriniGetir()
        {
            string baglantiAdresi = "Server=localhost;Port=3306;Database=pettrackdb;Uid=root;Pwd='';";

            using (MySqlConnection baglanti = new MySqlConnection(baglantiAdresi))
            {
                try
                {
                    baglanti.Open();
                    string kullaniciMail = Oturum.SimdikiKullanici.Email;

                    // --- 1. KART: TOPLAM HAYVAN SAYISI ---
                    string sorguHayvan = @"
                        SELECT COUNT(*) FROM pets 
                        WHERE user_id = (SELECT user_id FROM users WHERE email=@mail) 
                        AND is_active = 1";

                    MySqlCommand komut1 = new MySqlCommand(sorguHayvan, baglanti);
                    komut1.Parameters.AddWithValue("@mail", kullaniciMail);

                    int hayvanSayisi = Convert.ToInt32(komut1.ExecuteScalar());
                    lblToplamHayvanSayisi.Text = hayvanSayisi.ToString();


                    // --- 2. KART: TOPLAM AKTİVİTE SAYISI ---
                    string sorguAktivite = @"
                        SELECT COUNT(*) FROM activities a
                        JOIN pets p ON a.pet_id = p.pet_id
                        WHERE p.user_id = (SELECT user_id FROM users WHERE email=@mail)";

                    MySqlCommand komut2 = new MySqlCommand(sorguAktivite, baglanti);
                    komut2.Parameters.AddWithValue("@mail", kullaniciMail);

                    int toplamAktivite = Convert.ToInt32(komut2.ExecuteScalar());
                    lblToplamAktivite.Text = toplamAktivite.ToString();


                    // --- 3. KART: YAKLAŞAN AKTİVİTELER ---
                    string sorguYaklasan = @"
                        SELECT COUNT(*) FROM activities a
                        JOIN pets p ON a.pet_id = p.pet_id
                        WHERE p.user_id = (SELECT user_id FROM users WHERE email=@mail)
                        AND a.scheduled_at > NOW() 
                        AND a.status != 'Tamamlandı'";

                    MySqlCommand komut3 = new MySqlCommand(sorguYaklasan, baglanti);
                    komut3.Parameters.AddWithValue("@mail", kullaniciMail);

                    int yaklasanSayisi = Convert.ToInt32(komut3.ExecuteScalar());
                    lblYaklasanAktivite.Text = yaklasanSayisi.ToString();

                    // lblOneriSayisi satırı buradan silindi çünkü o kart artık yok.
                }
                catch (Exception hata)
                {
                    lblToplamHayvanSayisi.Text = "-";
                    MessageBox.Show("Dashboard verisi çekilemedi: " + hata.Message);
                }
            }
        }
        private void poisonPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHayvanlar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void topbar_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click_2(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void parrotLineGraph1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }



        private void btnHakkimizda_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnDboard_Click(object sender, EventArgs e)
        {
            // Eğer zaten Dashboard'daysan tekrar açmana gerek yok (Opsiyonel kontrol)
            if (this.Name == "DashboardForm") return;

            DashboardForm dashboard = new DashboardForm();
            dashboard.Show();
            this.Hide();
        }

        private void btnHayvanlar_Click(object sender, EventArgs e)
        {
            HayvanlarForm hayvanlar = new HayvanlarForm();
            hayvanlar.Show();
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

        private void kart3_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btnHayvanlar_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            // 1. Güvenlik için mevcut kullanıcı bilgisini temizle
            Oturum.SimdikiKullanici = null;

            // 2. Giriş yapma ekranını (GirisForm) yeniden oluştur ve aç
            GirisFormu girisEkrani = new GirisFormu();
            girisEkrani.Show();

            // 3. Şu an açık olan Dashboard ekranını kapat
            this.Close();
        }
    }
}

