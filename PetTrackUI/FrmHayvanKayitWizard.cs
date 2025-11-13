using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetTrackUI
{
    public partial class FrmHayvanKayitWizard : ReaLTaiizor.Forms.PoisonForm
    {
        int currentStep = 1;
        public FrmHayvanKayitWizard()
        {
            InitializeComponent();
        }

        private void FrmHayvanKayitWizard_Load(object sender, EventArgs e)
        {
            cmbTur.Items.Clear();
            cmbTur.Items.AddRange(new string[] { "Kedi", "Köpek" });
            cmbTur.SelectedIndex = 0;

            cmbCins.Items.Clear();
            cmbCins.Items.AddRange(new string[] { "Dişi", "Erkek" });
            cmbCins.SelectedIndex = 0;

            GuncellePanelGorunumu();
        }


        private void panelStep1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbTur_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbIrk.Items.Clear();

            if (cmbTur.SelectedItem.ToString() == "Kedi")
            {
                cmbIrk.Items.AddRange(new string[] { "Tekir", "British Shorthair", "Van Kedisi", "İran Kedisi" });
            }
            else if (cmbTur.SelectedItem.ToString() == "Köpek")
            {
                cmbIrk.Items.AddRange(new string[] { "Golden Retriever", "Pomeranian", "Alman Kurdu", "Kangal" });
            }

            if (cmbIrk.Items.Count > 0)
                cmbIrk.SelectedIndex = 0;
        }

        private void poisonLabel1_Click(object sender, EventArgs e)
        {

        }

        private void poisonButton1_Click(object sender, EventArgs e)
        {

        }
        private void GuncellePanelGorunumu()
        {
            // Panel görünürlüğü
            panelStep1.Visible = (currentStep == 1);
            panelStep2.Visible = (currentStep == 2);
            panelStep3.Visible = (currentStep == 3);

            // Buton görünürlüğü
            btnGeri.Enabled = (currentStep > 1);
            btnIleri.Visible = (currentStep < 3);
            btnKaydet.Visible = (currentStep == 3);
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            if (currentStep > 1)
            {
                currentStep--;
                GuncellePanelGorunumu();
            }
        }
        private void btnIleri_Click(object sender, EventArgs e)
        {
            if (currentStep < 3)
            {
                currentStep++;
                GuncellePanelGorunumu();
            }
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string bilgi =
                $"Ad: {txtHayvanAdi.Text}\n" +
                $"Tür: {cmbTur.Text}\n" +
                $"Irk: {cmbIrk.Text}\n" +
                $"Doğum Tarihi: {dtpDogumTarihi.Value.ToShortDateString()}\n" +
                $"Cinsiyet: {cmbCins.Text}\n" +
                $"Sahip: {txtSahipAd.Text}\n" +
                $"Not: {txtNot.Text}";

            MessageBox.Show(bilgi, "Kaydedilen Bilgiler", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Gerekirse formu kapat veya temizle
            this.Close();
        }

        private void btnKaydet_Click_1(object sender, EventArgs e)
        {

        }
    }
}
