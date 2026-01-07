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
    public partial class AktiviteEkleForm : Form
    {
        public AktiviteEkleForm()
        {
            InitializeComponent();
        }

        // --- FORM YÜKLENİRKEN (Verileri Doldur) ---
        private void AktiviteEkleForm_Load(object sender, EventArgs e)
        {
            VerileriYukle();
        }

        private void VerileriYukle()
        {
            string baglantiAdresi = "Server=localhost;Port=3306;Database=pettrackdb;Uid=root;Pwd='';";

            using (MySqlConnection baglanti = new MySqlConnection(baglantiAdresi))
            {
                try
                {
                    baglanti.Open();

                    // 1. HAYVANLARI DOLDUR (Sadece bu kullanıcının hayvanları)
                    MySqlCommand komutHayvan = new MySqlCommand("SELECT pet_id, name FROM pets WHERE user_id = (SELECT user_id FROM users WHERE email=@mail) AND is_active=1", baglanti);
                    komutHayvan.Parameters.AddWithValue("@mail", Oturum.SimdikiKullanici.Email);

                    MySqlDataAdapter daHayvan = new MySqlDataAdapter(komutHayvan);
                    DataTable dtHayvan = new DataTable();
                    daHayvan.Fill(dtHayvan);

                    cmbHayvan.DataSource = dtHayvan;
                    cmbHayvan.DisplayMember = "name";   // Ekranda görünen isim
                    cmbHayvan.ValueMember = "pet_id";   // Arka plandaki ID

                    // 2. AKTİVİTE TÜRLERİNİ DOLDUR (Yürüyüş, Oyun vs.)
                    MySqlCommand komutTur = new MySqlCommand("SELECT activity_type_id, name FROM activity_types", baglanti);
                    MySqlDataAdapter daTur = new MySqlDataAdapter(komutTur);
                    DataTable dtTur = new DataTable();
                    daTur.Fill(dtTur);

                    cmbAktiviteTuru.DataSource = dtTur;
                    cmbAktiviteTuru.DisplayMember = "name";
                    cmbAktiviteTuru.ValueMember = "activity_type_id";

                }
                catch (Exception hata)
                {
                    MessageBox.Show("Veriler yüklenirken hata: " + hata.Message);
                }
            }
        }

        // --- KAYDET BUTONU ---
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cmbHayvan.SelectedIndex == -1 || cmbAktiviteTuru.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen hayvan ve aktivite türü seçiniz.");
                return;
            }

            string baglantiAdresi = "Server=localhost;Port=3306;Database=pettrackdb;Uid=root;Pwd='';";

            using (MySqlConnection baglanti = new MySqlConnection(baglantiAdresi))
            {
                try
                {
                    baglanti.Open();

                    // --- DÜZELTİLEN KISIM BURASI ---
                    // 'Tamamlandı' yerine 'Planlandı' yazdık.
                    string sorgu = @"
                INSERT INTO activities 
                (pet_id, activity_type_id, scheduled_at, duration_min, notes, status, created_at) 
                VALUES 
                (@petId, @typeId, @tarih, @sure, @not, 'Planlandı', NOW())";
                    // -------------------------------

                    MySqlCommand komut = new MySqlCommand(sorgu, baglanti);

                    komut.Parameters.AddWithValue("@petId", cmbHayvan.SelectedValue);
                    komut.Parameters.AddWithValue("@typeId", cmbAktiviteTuru.SelectedValue);
                    komut.Parameters.AddWithValue("@tarih", dtpTarih.Value);
                    komut.Parameters.AddWithValue("@sure", nudSure.Value);
                    komut.Parameters.AddWithValue("@not", txtNotlar.Text);

                    komut.ExecuteNonQuery();

                    MessageBox.Show("Aktivite planlandı ve listeye eklendi! 📅");
                    this.Close();
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Kaydetme hatası: " + hata.Message);
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