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
    public partial class Finance_mainForm : Form
    {
        public Finance_mainForm()
        {
            InitializeComponent();
        }

        private void FacturatieBtn_Click(object sender, EventArgs e)
        {
            var Facturatie_Form = new Facturatie_Form();
            this.Hide();
            Facturatie_Form.Show(this);
        }

        private void LeaseBtn_Click(object sender, EventArgs e)
        {
            var LeaseForm = new LeaseForm();
            this.Hide();
            LeaseForm.Show(this);
        }

        private void KostenBtn_Click(object sender, EventArgs e)
        {
            var KostenForm = new KostenForm();
            this.Hide();
            KostenForm.Show(this);
        }
    }
}
