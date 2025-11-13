using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReaLTaiizor.Forms;

namespace PetTrackUI
{
    public partial class FrmAktiviteEkle : ReaLTaiizor.Forms.PoisonForm

    {
        public FrmAktiviteEkle()
        {
            InitializeComponent();
        }

        private void FrmAktiviteEkle_Load(object sender, EventArgs e)
        {

            // Hayvan listesi (örnek veriler)
            cmbHayvan.Items.AddRange(new string[] { "Milo", "Luna", "Daisy" });
            cmbHayvan.SelectedIndex = 0;

            // Aktivite türleri
            cmbAkTur.Items.AddRange(new string[] { "Yürüyüş", "Oyun", "Mama", "Aşı", "Tuvalet", "Diğer" });
            cmbAkTur.SelectedIndex = 0;

            // Tarihi şimdiye ayarla
            dtTarih.Value = DateTime.Now;

            // Süre aralığı
            numSure.Minimum = 1;
            numSure.Maximum = 300;
            numSure.Value = 30;
        }



        private void poisonLabel2_Click(object sender, EventArgs e)
        {

        }

        private void txtHayvan_Click(object sender, EventArgs e)
        {

        }

        private void poisonComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void poisonLabel3_Click(object sender, EventArgs e)
        {

        }

        private void poisonDateTime1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

        }
    }
}
