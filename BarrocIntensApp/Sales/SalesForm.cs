using BarrocIntensApp.Maintenance;
using BarrocIntensApp.Sales;
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
    public partial class SalesForm : Form
    {
        public SalesForm()
        {
            InitializeComponent();
            lblTitle.Text = $"Sales | {Globals.loggedInUser.Name}";
        }

        private void btnOfferte_Click(object sender, EventArgs e)
        {
            var salesOfferte = new SalesOfferteForm();
            this.Hide();
            salesOfferte.Show(this);
        }

        private void btnNotities_Click(object sender, EventArgs e)
        {
            var salesNotes = new SalesNotesForm();
            this.Hide();
            salesNotes.Show(this);
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            var LoginForm = new LoginForm();
            this.Hide();
            LoginForm.Show(this);
        }

        private void btnCreateCustomerform_Click(object sender, EventArgs e)
        {
            var createCustomerForm = new SalesKlantCreateForm();
            createCustomerForm.ShowDialog(this);
            MessageBox.Show("Klant aangemaakt");
        }
    }
}
