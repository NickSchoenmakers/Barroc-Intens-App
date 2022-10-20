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

namespace BarrocIntensApp
{
    public partial class MaintenanceOnderhoudForm : Form
    {
        public MaintenanceOnderhoudForm()
        {
            InitializeComponent();
            lblTitle.Text = $"Maintenance | {Globals.loggedInUser.Name}";
            Program.dbContext.MaintenanceAppointments.Where(m => m.WorkerId == Globals.loggedInUser.Id).Load();
            Program.dbContext.Companies.Load();
            this.dgvAppointments.DataSource = Program.dbContext.MaintenanceAppointments.Local.ToBindingList();
            this.cbAppointmentCompany.DataSource = Program.dbContext.Companies.Local.ToBindingList();
            dtAppointmentDate.CustomFormat = "dd/MM/yyyy hh:mm";
        }

        private void BtnReturnStoringen_Click(object sender, EventArgs e)
        {
            var inkoopForm = new MaintenanceForm();
            this.Hide();
            inkoopForm.Show(this);
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            var inkoopForm = new MaintenanceForm();
            this.Hide();
            inkoopForm.Show(this);
        }

        private void RefreshAppointmentInfo()
        {
            MaintenanceAppointment maintenanceAppointment = GetMaintenanceAppointment();
            lblAppointmentDate.Text = $"Datum en tijd: {maintenanceAppointment.NextAppointment}";
            lblAppointmentCompany.Text = $"Bedrijf: {maintenanceAppointment.Company.Name}";
            lblAppointmentRemark.Text = $"Opmerking: {maintenanceAppointment.Remark}";
        }

        private MaintenanceAppointment GetMaintenanceAppointment()
        {
            var maintenanceAppointment = (MaintenanceAppointment)this.dgvAppointments.CurrentRow?.DataBoundItem;
            return maintenanceAppointment;
        }

        private void dgvAppointments_SelectionChanged(object sender, EventArgs e)
        {
            this.RefreshAppointmentInfo();
            this.groupAppointmentInfo.Show();
        }

        private void btnDeleteAppointment_Click(object sender, EventArgs e)
        {
            Program.dbContext.Remove(GetMaintenanceAppointment());
            Program.dbContext.SaveChanges();
            dgvAppointments.ClearSelection();
            groupAppointmentInfo.Hide();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            MaintenanceAppointment maintenanceAppointmentToAdd = new MaintenanceAppointment()
            {
                NextAppointment = Convert.ToDateTime(dtAppointmentDate.Text),
                CompanyId = (int)cbAppointmentCompany.SelectedValue,
                Remark = txbAppointmentRemark.Text,
                WorkerId = Globals.loggedInUser.Id
            };

            Program.dbContext.MaintenanceAppointments.Add(maintenanceAppointmentToAdd);
            Program.dbContext.SaveChanges();
        }
    }
}
