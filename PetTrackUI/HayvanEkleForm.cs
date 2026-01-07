using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO; // Dosya işlemleri için gerekli
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PetTrackUI.Helpers; // Oturum sistemi için

namespace PetTrackUI
{
    public partial class HayvanEkleForm : Form
    {
        // Seçilen resmin dosya yolunu tutacak değişken
        string secilenResimYolu = "";
        string hedefDosyaYolu = ""; // Veritabanına kaydedilecek yol

        public HayvanEkleForm()
        {
            InitializeComponent();
        }

        // --- FORM YÜKLENİRKEN ---
        private void HayvanEkleForm_Load(object sender, EventArgs e)
        {
            // Tür listesini dolduralım (Eğer özelliklerden eklemediysen)
            if (cmbTur.Items.Count == 0)
            {
                cmbTur.Items.AddRange(new object[] { "Kedi", "Köpek", "Kuş", "Balık", "Diğer" });
                cmbTur.SelectedIndex = 0; // İlkini seçili yap
            }

            // Cinsiyet listesini dolduralım
            if (cmbCinsiyet.Items.Count == 0)
            {
                cmbCinsiyet.Items.AddRange(new object[] { "Erkek", "Dişi" });
                cmbCinsiyet.SelectedIndex = 0;
            }
        }

        // --- FOTOĞRAF EKLE BUTONU ---
        private void btnFotografSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosyaSec = new OpenFileDialog();
            dosyaSec.Title = "Hayvanınızın Fotoğrafını Seçin";
            dosyaSec.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp";

            if (dosyaSec.ShowDialog() == DialogResult.OK)
            {
                // 1. Resmi PictureBox'ta göster
                pbHayvanResim.ImageLocation = dosyaSec.FileName;
                pbHayvanResim.SizeMode = PictureBoxSizeMode.StretchImage;

                // 2. Dosya yolunu değişkene al (Kaydet butonu için lazım olacak)
                secilenResimYolu = dosyaSec.FileName;
            }
        }

        // --- KAYDET BUTONU ---
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // 1. Boş alan kontrolü
            if (txtHayvanAdi.Text == "" || cmbTur.Text == "")
            {
                MessageBox.Show("Lütfen Hayvan Adı ve Türünü giriniz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Resmi Proje Klasörüne Kopyalama İşlemi
            // (Kullanıcı bilgisayarından silse bile programda kalsın diye)
            if (secilenResimYolu != "")
            {
                // Resimler için klasör oluştur (Yoksa)
                string klasorYolu = Application.StartupPath + "\\HayvanResimleri";
                if (!Directory.Exists(klasorYolu))
                {
                    Directory.CreateDirectory(klasorYolu);
                }

                // Resme benzersiz bir isim ver (Çakışma olmasın diye UUID kullanıyoruz)
                string yeniDosyaAdi = Guid.NewGuid().ToString() + Path.GetExtension(secilenResimYolu);
                hedefDosyaYolu = Path.Combine(klasorYolu, yeniDosyaAdi);

                // Resmi kopyala
                File.Copy(secilenResimYolu, hedefDosyaYolu);
            }
            else
            {
                hedefDosyaYolu = "Yok"; // Resim seçmediyse
            }

            // 3. VERİTABANI KAYIT İŞLEMİ
            string baglantiAdresi = "Server=localhost;Port=3306;Database=pettrackdb;Uid=root;Pwd='';";

            using (MySqlConnection baglanti = new MySqlConnection(baglantiAdresi))
            {
                try
                {
                    baglanti.Open();

                    // SQL Sorgusu: user_id'yi E-posta'dan bulup alıyoruz (Subquery ile)
                    // Böylece ID hatası alma riskimiz kalmıyor.
                    string sorgu = @"
                        INSERT INTO pets 
                        (user_id, name, species, breed, gender, birth_date, notes, photo_path, is_active, created_at) 
                        VALUES 
                        (
                            (SELECT user_id FROM users WHERE email=@mail LIMIT 1),
                            @ad, @tur, @irk, @cinsiyet, @dtarih, @not, @resim, 1, NOW()
                        )";

                    MySqlCommand komut = new MySqlCommand(sorgu, baglanti);

                    // Parametreleri Eşleştir (SQL Injection önlemi)
                    // Oturumdan gelen E-postayı kullanıyoruz:
                    komut.Parameters.AddWithValue("@mail", Oturum.SimdikiKullanici.Email);

                    komut.Parameters.AddWithValue("@ad", txtHayvanAdi.Text);
                    komut.Parameters.AddWithValue("@tur", cmbTur.Text);
                    komut.Parameters.AddWithValue("@irk", txtIrk.Text);
                    komut.Parameters.AddWithValue("@cinsiyet", cmbCinsiyet.Text);
                    komut.Parameters.AddWithValue("@dtarih", dtpDogumTarihi.Value); // DateTimePicker değeri
                    komut.Parameters.AddWithValue("@not", txtNotlar.Text);

                    // Resim yolu veritabanına sadece dosya adı olarak veya tam yol olarak kaydedilebilir.
                    // Biz tam yolu kaydediyoruz ki geri yüklerken kolay olsun.
                    if (hedefDosyaYolu == "Yok")
                        komut.Parameters.AddWithValue("@resim", DBNull.Value);
                    else
                        komut.Parameters.AddWithValue("@resim", hedefDosyaYolu);

                    // Komutu çalıştır
                    komut.ExecuteNonQuery();

                    MessageBox.Show("Hayvan başarıyla kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Formu kapat (İstersen kapatmayıp alanları temizleyebilirsin)
                    this.Close();
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Kayıt sırasında hata oluştu: " + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // --- İPTAL BUTONU ---
        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
