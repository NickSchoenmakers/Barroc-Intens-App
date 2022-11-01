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
using static Azure.Core.HttpHeader;
using static BarrocIntensApp.LoginForm;

namespace BarrocIntensApp
{
    public partial class MaintenanceStoringenForm : Form
    {
        public MaintenanceStoringenForm()
        {
            InitializeComponent();
            //lblTitle.Text = $"Maintenance | {Globals.loggedInUser.Name}";
        }

        private void BtnReturnStoringen_Click(object sender, EventArgs e)
        {
            var inkoopForm = new MaintenanceForm();
            this.Hide();
            inkoopForm.Show(this);
        }
        private void MaintenanceStoringenForm_Load(object sender, EventArgs e)
        {
            Program.dbContext = new AppDbContext();
            //fetch the appointments in the first appointment
            var maintenanceAppointment = Program.dbContext.MaintenanceAppointments.ToList();
            var maintenanceAppointments = maintenanceAppointment[0];

            Program.dbContext.MaintenanceAppointments.Load();
            Program.dbContext.Companies.Load();

            this.maintenanceAppointmentBindingSource.DataSource = Program.dbContext.MaintenanceAppointments.Local.ToBindingList();
            this.companyBindingSource.DataSource = Program.dbContext.Companies.Local.ToBindingList();

            Program.dbContext.Entry(maintenanceAppointments)
                .Reference(c => c.Company)
                .Load();
        }
        private void roundButton1_Click(object sender, EventArgs e)
        {
            var inkoopForm = new MaintenanceForm();
            this.Hide();
            inkoopForm.Show(this);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
