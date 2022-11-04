using BarrocIntensApp.Maintenance;
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
    public partial class MaintenanceForm : Form
    {
        public MaintenanceForm()
        {
            InitializeComponent();
            lblTitle.Text = $"Maintenance | {Globals.loggedInUser.Name}";
            if (Globals.loggedInUser.isManager == true) {
                BtnManager.Visible = true;
                BtnCalendar.Visible = false;
                BtnManager.Location = new Point(467, 63);
            }
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
            var inkoopForm = new MaintenanceStoringenForm();
            this.Hide();
            inkoopForm.Show(this);
        }

        private void BtnOnderdelen_Click(object sender, EventArgs e)
        {
            var inkoopForm = new MaintenanceOnderdelenForm();
            this.Hide();
            inkoopForm.Show(this);
        }

        private void BtnOnderhoud_Click_1(object sender, EventArgs e)
        {
            var inkoopForm = new MaintenanceKalenderForm();
            this.Hide();
            inkoopForm.Show(this);
        }

        private void BtnStoringen_Click(object sender, EventArgs e)
        {
            var inkoopForm = new MaintenanceStoringenForm();
            this.Hide();
            inkoopForm.Show(this);
        }

        private void BtnManager_Click(object sender, EventArgs e) {
            if (Globals.loggedInUser.isManager == true) {
                var maintenanceOnderhoudManagerForm = new MaintenanceOnderHoudManagerForm();
                this.Hide();
                maintenanceOnderhoudManagerForm.Show(this);
            }
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            var LoginForm = new LoginForm();
            this.Hide();
            LoginForm.Show(this);
        }
    }
}
