using BarrocIntensApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BarrocIntensApp.LoginForm;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BarrocIntensApp
{
    public partial class FinanceLeaseForm : Form
    {
        private AppDbContext dbContext;
        public FinanceLeaseForm()
        {
            InitializeComponent();
            lblTitle.Text = $"Finance | {Globals.loggedInUser.Name}";
        }

        private void FinanceLeaseForm_Load(object sender, EventArgs e)
        {
            this.dbContext = new AppDbContext();
            this.dbContext.Companies.Load();
            companyBindingSource.DataSource = this.dbContext.Companies.Local.ToBindingList();
        }

        private void cbCompanies_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnChangeBkr_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            // saves the changes made
            this.dbContext.SaveChanges();
            // refreshes the list
            this.cbCompanies.Refresh();
            // tells the user the changes were saved succesfully
            MessageBox.Show("changes saved succesfully");
        }

        private void cbCompanies_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // if the user gives incorrect information then it shows them this message
            MessageBox.Show("please fill in a correct date. an example of formating: 20/02/2020");
        }

        private void roundButton2_Click(object sender, EventArgs e)
        {
            var maintenanceDashboard = new FinanceForm();
            this.Hide();
            maintenanceDashboard.Show(this);
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            var LoginForm = new LoginForm();
            this.Hide();
            LoginForm.Show(this);
        }
    }
}
