using BarrocIntensApp.Models;
using Microsoft.EntityFrameworkCore;
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

namespace BarrocIntensApp.Finance
{
    public partial class FinanceLeaseForm : Form
    {
        public FinanceLeaseForm()
        {
            InitializeComponent();
            Program.dbContext.LeaseContracts.Load();
            Program.dbContext.Companies.Load();
            Program.dbContext.Products.Load();
            this.dgvLeaseContracts.DataSource = Program.dbContext.LeaseContracts.Local.ToBindingList().OrderBy(l => l.Company.Name).ToList();
            this.cbxLeaseContractCompany.DataSource = Program.dbContext.Companies.Local.ToBindingList().OrderBy(c => c.Name).ToList();
            this.cbxLeaseContractProduct.DataSource = Program.dbContext.Products.Local.ToBindingList();
            this.cbxMonthlyPeriodically.SelectedIndex = 0;
            lblTitle.Text = $"Finance | {Globals.loggedInUser.Name}";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var maintenanceDashboard = new FinanceForm();
            this.Hide();
            maintenanceDashboard.Show(this);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var LoginForm = new LoginForm();
            this.Hide();
            LoginForm.Show(this);
        }

        private void btnCreateLeaseContract_Click(object sender, EventArgs e)
        {
            LeaseContract leaseContractToAdd = new LeaseContract
            {
                Monthly = cbxMonthlyPeriodically.SelectedIndex == 0,
                ProductId = (int)cbxLeaseContractProduct.SelectedValue,
                CompanyId = (int)cbxLeaseContractCompany.SelectedValue,
                StartDate = dtLeaseContractStartDate.Value,
                Periods = 12
            };
            Program.dbContext.LeaseContracts.Add(leaseContractToAdd);
            Program.dbContext.SaveChanges();
            this.dgvLeaseContracts.DataSource = Program.dbContext.LeaseContracts.Local.ToBindingList().OrderBy(l => l.Company.Name).ToList();
        }

        private void btnDeleteLeaseContract_Click(object sender, EventArgs e)
        {

        }
    }
}
