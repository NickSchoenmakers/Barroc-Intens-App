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

namespace BarrocIntensApp.Maintenance {
    public partial class MaintenanceOnderHoudManagerForm : Form {
        public MaintenanceOnderHoudManagerForm() {
            InitializeComponent();
            lblTitle.Text = $"Maintenance | {Globals.loggedInUser.Name}";
            Program.dbContext.MaintenanceAppointments.Load();
            Program.dbContext.MaintenanceAppointmentWorkOrders.Load();
            Program.dbContext.Companies.Load();
            Program.dbContext.Users.Load();
            this.dgvAppointments.DataSource = Program.dbContext.MaintenanceAppointments.Local.ToBindingList();          
            this.cbAppointmentCompany.DataSource = Program.dbContext.Companies.Local.ToBindingList();
            this.cbWorker.DataSource = Program.dbContext.Users.Where(u => u.isManager == false && u.RoleId == 2).ToList();
            dtAppointmentDate.CustomFormat = "dd/MM/yyyy hh:mm";
            cbFilter.SelectedIndex = 0;
        }

        private void BtnReturnStoringen_Click(object sender, EventArgs e) {
            var maintenanceDashboard = new MaintenanceForm();
            this.Hide();
            maintenanceDashboard.Show(this);
        }

        private void roundButton1_Click(object sender, EventArgs e) {
            var inkoopForm = new MaintenanceForm();
            this.Hide();
            inkoopForm.Show(this);
        }

        private MaintenanceAppointment GetMaintenanceAppointment() {
            var maintenanceAppointment = (MaintenanceAppointment)this.dgvAppointments.CurrentRow?.DataBoundItem;
            return maintenanceAppointment;
        }

        private void RefreshAppointmentInfo() {
            MaintenanceAppointment maintenanceAppointment = GetMaintenanceAppointment();
            if (maintenanceAppointment != null) {
                lblAppointmentDate.Text = $"Datum en tijd: {maintenanceAppointment.NextAppointment}";
                lblAppointmentCompany.Text = $"Bedrijf: {maintenanceAppointment.Company.Name}";
                lblAppointmentRemark.Text = $"Opmerking: {maintenanceAppointment.Remark}";
                lblAppointmentWorker.Text = $"Maintenance werknemer: {maintenanceAppointment.Worker.Name}";

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

                if (maintenanceAppointment.MaintenanceAppointmentWorkOrderId != null)
                {
                    btnViewWorkOrder.Visible = true;
                }
                else
                {
                    btnViewWorkOrder.Visible = false;
                }
            }
        }

        private void FilterProducts() {
            dgvAppointments.DataSource = Program.dbContext.MaintenanceAppointments.Local.ToBindingList();
            if (cbFilter.SelectedIndex == 0) {
                dgvAppointments.DataSource = Program.dbContext.MaintenanceAppointments.Local.ToBindingList();
            } else if (cbFilter.SelectedIndex == 1) {
                dgvAppointments.DataSource = Program.dbContext.MaintenanceAppointments.Where(m => m.NextAppointment < DateTime.Today.AddDays(1) && m.NextAppointment >= DateTime.Today).ToList();
            } else if (cbFilter.SelectedIndex == 2) {
                var monday = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Monday);
                var sunday = monday.AddDays(7);
                dgvAppointments.DataSource = Program.dbContext.MaintenanceAppointments.Where(m => m.NextAppointment > monday && m.NextAppointment < sunday).ToList();
            }
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e) {
            FilterProducts();
        }

        private void dgvAppointments_SelectionChanged_1(object sender, EventArgs e) {
            this.RefreshAppointmentInfo();
            this.groupAppointmentInfo.Show();
        }

        private void btnAddProduct_Click_1(object sender, EventArgs e) {
            MaintenanceAppointment maintenanceAppointmentToAdd = new MaintenanceAppointment() {
                NextAppointment = Convert.ToDateTime(dtAppointmentDate.Text),
                CompanyId = (int)cbAppointmentCompany.SelectedValue,
                Remark = txbAppointmentRemark.Text,
                WorkerId = (int)cbWorker.SelectedValue,
                IsRoutine = cbRoutine.Checked
            };

            Program.dbContext.MaintenanceAppointments.Add(maintenanceAppointmentToAdd);
            Program.dbContext.SaveChanges();
            FilterProducts();
        }

        private MaintenanceAppointmentWorkOrder GetMaintenanceAppointmentWorkOrder()
        {
            MaintenanceAppointmentWorkOrder maintenanceAppointmentWorkOrder = GetMaintenanceAppointment().MaintenanceAppointmentWorkOrder;
            return maintenanceAppointmentWorkOrder;
        }

        private void btnDeleteAppointment_Click_1(object sender, EventArgs e) {
            Program.dbContext.Remove(GetMaintenanceAppointment());
            Program.dbContext.SaveChanges();
            dgvAppointments.ClearSelection();
            groupAppointmentInfo.Hide();
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
