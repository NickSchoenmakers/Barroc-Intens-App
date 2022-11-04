using BarrocIntensApp.Maintenance;
using BarrocIntensApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BarrocIntensApp.LoginForm;

namespace BarrocIntensApp
{
    public partial class MaintenanceKalenderForm : Form
    {
        public MaintenanceKalenderForm(){
            InitializeComponent();
            lblTitle.Text = $"Maintenance | {Globals.loggedInUser.Name}";
            Program.dbContext.MaintenanceAppointments.Where(m => m.WorkerId == Globals.loggedInUser.Id).Load();
            Program.dbContext.Companies.Load();
            this.dgvAppointments.DataSource = Program.dbContext.MaintenanceAppointments.Local.ToBindingList();
            Program.dbContext.Products.Where(p => p.ProductCategoryId == 1).Load();
            cbFilter.SelectedIndex = 0;
        }

        private void BtnReturnStoringen_Click(object sender, EventArgs e){
            var inkoopForm = new MaintenanceForm();
            this.Hide();
            inkoopForm.Show(this);
        }

        private void roundButton1_Click(object sender, EventArgs e){
            var inkoopForm = new MaintenanceForm();
            this.Hide();
            inkoopForm.Show(this);
        }

        private MaintenanceAppointment GetMaintenanceAppointment(){
            var maintenanceAppointment = (MaintenanceAppointment)this.dgvAppointments.CurrentRow?.DataBoundItem;
            return maintenanceAppointment;
        }
        private MaintenanceAppointmentWorkOrder GetMaintenanceAppointmentWorkOrder()
        {
            MaintenanceAppointmentWorkOrder maintenanceAppointmentWorkOrder = GetMaintenanceAppointment().MaintenanceAppointmentWorkOrder;
            return maintenanceAppointmentWorkOrder;
        }

        private void dgvAppointments_SelectionChanged(object sender, EventArgs e){
            this.RefreshAppointmentInfo();
            this.groupAppointmentInfo.Show();
            lblWorkOrderFeedback.Visible = false;
        }

        private void RefreshAppointmentInfo() {
            MaintenanceAppointment maintenanceAppointment = GetMaintenanceAppointment();
            if (maintenanceAppointment != null) {
                lblAppointmentDate.Text = $"Datum en tijd: {maintenanceAppointment.NextAppointment}";
                lblAppointmentCompany.Text = $"Bedrijf: {maintenanceAppointment.Company.Name}";
                lblAppointmentRemark.Text = $"Opmerking: {maintenanceAppointment.Remark}";
                lblAppointmentProduct.Text = $"Product: {maintenanceAppointment.Product.Name}";

                lblCompanyStreet.Text = $"Straatnaam: {maintenanceAppointment.Company.Street}";
                lblCompanyNumber.Text = $"Huisnummer: {maintenanceAppointment.Company.HouseNumber}";
                lblCompanyCity.Text = $"Stad: {maintenanceAppointment.Company.City}";
                lblCompanyCountryCode.Text = $"Landcode: {maintenanceAppointment.Company.CountryCode}";

                if (maintenanceAppointment.IsRoutine)
                {
                    lblRoutine.Text = "Type bezoek: routinematig";
                }
                else
                {
                    lblRoutine.Text = "Type bezoek: storingbezoek";
                }
            }
            if (GetMaintenanceAppointmentWorkOrder() is null)
            {
                btnShowCreateWorkOrder.Visible = true;
                btnViewWorkOrder.Visible = false;
            }
            else
            {
                btnViewWorkOrder.Visible = true;
                btnShowCreateWorkOrder.Visible = false;
            }
        }

        private void btnDeleteAppointment_Click(object sender, EventArgs e){
            Program.dbContext.Remove(GetMaintenanceAppointment());
            Program.dbContext.SaveChanges();
            dgvAppointments.ClearSelection();
            groupAppointmentInfo.Hide();
        }

        private void FilterProducts() {
            dgvAppointments.DataSource = Program.dbContext.MaintenanceAppointments.Local.ToBindingList();
            if (cbFilter.SelectedIndex == 0) {
                dgvAppointments.DataSource = Program.dbContext.MaintenanceAppointments.Local.ToBindingList();
            } else if (cbFilter.SelectedIndex == 1) {
                dgvAppointments.DataSource = Program.dbContext.MaintenanceAppointments.Where(m => m.NextAppointment < DateTime.Today.AddDays(1) && m.NextAppointment >= DateTime.Today && m.WorkerId == Globals.loggedInUser.Id).ToList();
            } else if (cbFilter.SelectedIndex == 2) {
                var monday = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Monday);
                var sunday = monday.AddDays(7);
                dgvAppointments.DataSource = Program.dbContext.MaintenanceAppointments.Where(m => m.NextAppointment > monday && m.NextAppointment < sunday && m.WorkerId == Globals.loggedInUser.Id).ToList();
            }
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e) {
            FilterProducts();
        }

        private void btnShowCreateWorkOrder_Click(object sender, EventArgs e)
        {
            var maintenanceCreateWerkbon = new MaintenanceCreateWerkbonForm(GetMaintenanceAppointment());
            maintenanceCreateWerkbon.ShowDialog(this);
            if (maintenanceCreateWerkbon.workOrderCreated != null)
            {
                lblWorkOrderFeedback.Visible = true;
                btnViewWorkOrder.Visible = true;
                btnShowCreateWorkOrder.Visible = false;
            }
        }

        private void btnReturnDashboard_Click(object sender, EventArgs e)
        {
            var maintenanceDashboard = new MaintenanceForm();
            this.Hide();
            maintenanceDashboard.Show(this);
        }

        private void btnViewWorkOrder_Click(object sender, EventArgs e)
        {
            var maintenanceWerkbon = new MaintenanceViewWerkbonForm(GetMaintenanceAppointmentWorkOrder());
            maintenanceWerkbon.ShowDialog(this);

        }

        private void roundButton2_Click(object sender, EventArgs e)
        {
            var LoginForm = new LoginForm();
            this.Hide();
            LoginForm.Show(this);
        }
    }
}
