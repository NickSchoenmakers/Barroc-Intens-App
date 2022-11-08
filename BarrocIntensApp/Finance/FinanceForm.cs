using BarrocIntensApp.Finance;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BarrocIntensApp.LoginForm;

namespace BarrocIntensApp
{
    public partial class FinanceForm : Form
    {
        public FinanceForm()
        {
            InitializeComponent();
            lblTitle.Text = $"Finance | {Globals.loggedInUser.Name}";
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

        private void roundButton1_Click(object sender, EventArgs e)
        {
            var LoginForm = new LoginForm();
            this.Hide();
            LoginForm.Show(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var OverzichtForm = new FinanceFacturatieOverzichtForm();
            this.Hide();
            OverzichtForm.Show(this);
        }
    }
}
