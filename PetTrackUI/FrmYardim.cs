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
    public partial class FrmYardim : ReaLTaiizor.Forms.PoisonForm
    {
        public FrmYardim()
        {
            InitializeComponent();
        }

        private void btnSoru1_Click(object sender, EventArgs e)
        {
            lblCevap1.Visible = !lblCevap1.Visible;
        }

        private void btnSoru2_Click(object sender, EventArgs e)
        {
            lblCevap2.Visible = !lblCevap2.Visible;
        }

        private void btnSoru3_Click(object sender, EventArgs e)
        {
            lblCevap3.Visible = !lblCevap3.Visible;
        }

        private void btnSoru1_Click_1(object sender, EventArgs e)
        {

        }

        private void poisonButton1_Click(object sender, EventArgs e)
        {

        }

        private void poisonLabel1_Click(object sender, EventArgs e)
        {

        }

        private void poisonLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
