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
            this.cbxLeaseContractProduct.DataSource = Program.dbContext.Products.Local.ToBindingList().Where(p => p.IsLeasable).ToList();
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
            LeaseContract leaseContractToAdd = new LeaseContract {
                Monthly = cbxMonthlyPeriodically.SelectedIndex == 0,
                ProductId = (int)cbxLeaseContractProduct.SelectedValue,
                CompanyId = (int)cbxLeaseContractCompany.SelectedValue,
                StartDate = dtLeaseContractStartDate.Value,
                Periods = (int)numPeriods.Value
            };
            Program.dbContext.LeaseContracts.Add(leaseContractToAdd);
            Program.dbContext.SaveChanges();
            RefreshData();
        }

        private void btnDeleteLeaseContract_Click(object sender, EventArgs e)
        {
            Program.dbContext.Remove(GetLeaseContract());
            Program.dbContext.SaveChanges();
            dgvLeaseContracts.ClearSelection();
            RefreshData();
            groupLeaseContractInfo.Hide();
        }

        private LeaseContract GetLeaseContract() {
            var leaseContract = (LeaseContract)this.dgvLeaseContracts.CurrentRow?.DataBoundItem;
            return leaseContract;
        }

        private void RefreshData() {
            this.dgvLeaseContracts.DataSource = Program.dbContext.LeaseContracts.Local.ToBindingList().OrderBy(l => l.Company.Name).ToList();
        }

        private void dgvLeaseContracts_SelectionChanged(object sender, EventArgs e) {
            this.RefreshLeaseContractInfo();
            this.groupLeaseContractInfo.Show();
        }

        private void RefreshLeaseContractInfo() {
            var leaseContract = GetLeaseContract();
            if (leaseContract != null) {
                this.lblLeaseInfoCompany.Text = $"Bedrijf: {leaseContract.Company.Name}";
                this.lblLeaseInfoProduct.Text = $"Product: {leaseContract.Product.Name}";
                this.lblLeaseInfoStartDate.Text = $"Startdatum: {leaseContract.StartDate.ToString("dd-MM-yyyy")}";
                this.lblLeaseInfoPeriods.Text = $"Termijnen: {leaseContract.Periods.ToString()}";
                this.lblMonthlyPeriodically.Text = leaseContract.Monthly ? "Maandelijkse lease" : "Periodieke lease";

                if (leaseContract.Monthly) {
                    this.lblLeaseInfoPriceMonth.Text = $"Prijs per maand: {Decimal.Parse((leaseContract.Product.Price / leaseContract.Periods).ToString("0.00"))}";
                } else {
                    this.lblLeaseInfoPriceMonth.Text = $"Prijs per periode: {Decimal.Parse((leaseContract.Product.Price / leaseContract.Periods).ToString("0.00"))}";
                }
            }
        }

        private void cbxMonthlyPeriodically_SelectedIndexChanged(object sender, EventArgs e) {
            if (cbxMonthlyPeriodically.SelectedIndex == 0) {
                this.numPeriods.Minimum = 12;
                this.numPeriods.Maximum = 36;
            } else {
                this.numPeriods.Minimum = 4;
                this.numPeriods.Maximum = 12;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            groupCreateLeaseContract.Text = "Leasecontract bewerken";
            var leaseContract = GetLeaseContract();
            cbxLeaseContractCompany.SelectedValue = leaseContract.CompanyId;
            cbxLeaseContractProduct.SelectedValue = leaseContract.ProductId;
            dtLeaseContractStartDate.Value = leaseContract.StartDate;
            cbxMonthlyPeriodically.SelectedIndex = leaseContract.Monthly ? 0 : 1;
            numPeriods.Value = leaseContract.Periods;
            btnCreateLeaseContract.Visible = false;
            btnSaveEdit.Visible = true;
        }

        private void btnSaveEdit_Click(object sender, EventArgs e) {
            groupCreateLeaseContract.Text = "Leasecontract aanmaken";
            var leaseContract = GetLeaseContract();
            leaseContract.CompanyId = (int)cbxLeaseContractCompany.SelectedValue;
            leaseContract.ProductId = (int)cbxLeaseContractProduct.SelectedValue;
            leaseContract.StartDate = dtLeaseContractStartDate.Value;
            leaseContract.Monthly = cbxMonthlyPeriodically.SelectedIndex == 0;
            leaseContract.Periods = (int)numPeriods.Value;
            Program.dbContext.SaveChanges();
            RefreshData();
            btnCreateLeaseContract.Visible = true;
            btnSaveEdit.Visible = false;
        }
    }
}
