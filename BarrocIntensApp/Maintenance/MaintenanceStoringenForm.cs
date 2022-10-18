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

            this.maintenanceAppointmentBindingSource1.DataSource = Program.dbContext.MaintenanceAppointments.Local.ToBindingList();


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
    }
}
