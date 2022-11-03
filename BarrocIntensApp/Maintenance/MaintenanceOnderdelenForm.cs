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
    public partial class MaintenanceOnderdelenForm : Form
    {
        public MaintenanceOnderdelenForm()
        {
            InitializeComponent();
            lblTitle.Text = $"Maintenance | {Globals.loggedInUser.Name}";
        }

        private void BtnReturnStoringen_Click(object sender, EventArgs e)
        {
            var maintenanceDashboard = new MaintenanceForm();
            this.Hide();
            maintenanceDashboard.Show(this);
        }

        private void MaintenanceOnderdelenForm_Load(object sender, EventArgs e)
        {
            Program.dbContext.Products.Load();
            this.dataGridView1.DataSource = Program.dbContext.Products.Local.ToList();
            Program.dbContext = new Models.AppDbContext();

            var product = Program.dbContext.Products.ToList();
            var products = product[0];

            Program.dbContext.MaintenanceAppointments.Load();
        }
    }
}
