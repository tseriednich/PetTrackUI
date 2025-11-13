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
    public partial class FrmPlanEkle : ReaLTaiizor.Forms.PoisonForm

    {
        public FrmPlanEkle()
        {
            InitializeComponent();
        }

        private void FrmPlanEkle_Load(object sender, EventArgs e)
        {
            cmbHayvan.Items.AddRange(new string[] { "Milo", "Luna", "Daisy" });
            cmbHayvan.SelectedIndex = 0;

            cmbPlanTuru.Items.AddRange(new string[] { "Aşı", "Tıraş", "Kontrol", "Oyun", "Mama", "Diğer" });
            cmbPlanTuru.SelectedIndex = 0;

            dtTarih.Value = DateTime.Now.AddDays(1);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string mesaj = $"Hayvan: {cmbHayvan.Text}\n" +
                  $"Plan Türü: {cmbPlanTuru.Text}\n" +
                  $"Tarih ve Saat: {dtTarih.Value:dd.MM.yyyy HH:mm}\n" +
                  $"Not: {txtNot.Text}";

            MessageBox.Show(mesaj, "Plan Kaydedildi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
