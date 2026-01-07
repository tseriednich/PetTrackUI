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
    public partial class HakkimizdaForm : Form
    {
        public HakkimizdaForm()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void topbar_Click(object sender, EventArgs e)
        {

        }

        private void btnDboard_Paint(object sender, PaintEventArgs e)
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
            YardimForm yardim = new YardimForm(); // Form ismin farklıysa düzelt
            yardim.Show();
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
