using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarrocIntensApp
{
    public partial class FinanceForm : Form
    {
        public FinanceForm()
        {
            InitializeComponent();
        }

        private void FacturatieBtn_Click(object sender, EventArgs e)
        {
            var Facturatie_Form = new FacturatieForm();
            this.Hide();
            Facturatie_Form.Show(this);
        }

        private void LeaseBtn_Click(object sender, EventArgs e)
        {
            var LeaseForm = new FinanceLeaseForm();
            this.Hide();
            LeaseForm.Show(this);
        }

        private void KostenBtn_Click(object sender, EventArgs e)
        {
            var KostenForm = new FinanceKostenForm();
            this.Hide();
            KostenForm.Show(this);
        }
    }
}
