using BarrocIntensApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarrocIntensApp.Sales
{
    public partial class SalesKlantCreateForm : Form
    {
        public SalesKlantCreateForm()
        {
            InitializeComponent();
            this.cbxCountry.SelectedIndex = 0;
        }

        private void btnCreateCustomer_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txbName.Text) && !string.IsNullOrEmpty(txbCity.Text) && !string.IsNullOrEmpty(txbStreet.Text) && !string.IsNullOrEmpty(txbNameContact.Text) && !string.IsNullOrEmpty(txbPhoneContact.Text))
            {          
                var company = new Company()
                {
                    Name = txbName.Text,
                    Street = txbStreet.Text,
                    HouseNumber = numHouseNumber.Value.ToString(),
                    City = txbCity.Text,
                    CountryCode = cbxCountry.SelectedIndex == 0 ? "NL" : "BE",
                    ContactName = txbNameContact.Text,
                    ContactPhoneNumber = txbPhoneContact.Text
                };
                Program.dbContext.Companies.Add(company);
                Program.dbContext.SaveChanges();
                this.Close();
            }
            else
            {
                MessageBox.Show("U heeft niet alle velden ingevuld");
            }
        }
    }
}
