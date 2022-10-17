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
            lblTitle.Text = $"Maintenance | {Globals.loggedInUser.Name}";
        }

        private void BtnReturnStoringen_Click(object sender, EventArgs e)
        {
            var inkoopForm = new MaintenanceForm();
            this.Hide();
            inkoopForm.Show(this);
        }



        private void MaintenanceStoringenForm_Load(object sender, EventArgs e)
        {
            this.dbContext = new AppDbContext();
            //fetch the appointments in the first appointment
            //var maintenanceAppointment = this.dbContext.MaintenanceAppointments.ToList();
            //var maintenanceAppointments = maintenanceAppointment[0];

            
                

        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.dbContext = new AppDbContext();

            this.dbContext.MaintenanceAppointments.Load();

            this.maintenanceAppointmentBindingSource.DataSource = dbContext.MaintenanceAppointments.Local.ToBindingList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            var inkoopForm = new MaintenanceForm();
            this.Hide();
            inkoopForm.Show(this);
        }
    }
}
