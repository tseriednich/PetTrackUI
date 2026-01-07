using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetTrackUI.Helpers;

namespace PetTrackUI
{
    public partial class YardimForm : Form
    {
        public YardimForm()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnDboard_Click(object sender, EventArgs e)
        {
            DashboardForm dashboard = new DashboardForm();
            dashboard.Show();
            this.Hide();
        }

        private void btnHayvanlar_Click(object sender, EventArgs e)
        {
            // Eğer zaten Hayvanlar sayfasındaysan (HayvanlarForm) bunu yazmana gerek yok veya boş bırakabilirsin.
            // Ama başka sayfadaysan:
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

        private void btnHakkimizda_Click(object sender, EventArgs e)
        {
            HakkimizdaForm hakkimizda = new HakkimizdaForm();
            hakkimizda.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Oturum.SimdikiKullanici = null;
            GirisFormu giris = new GirisFormu();
            giris.Show();
            this.Close();
        }
    }
}
