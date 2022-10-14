﻿using System;
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
        }

        private void MaintencanceForm_Load(object sender, EventArgs e)
        {

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
            var inkoopForm = new MaintenanceOnderhoudForm();
            this.Hide();
            inkoopForm.Show(this);
        }

        private void lblTitle_Click_1(object sender, EventArgs e)
        {

        }

        private void pbBlack_Click(object sender, EventArgs e)
        {

        }

        private void BtnStoringen_Click(object sender, EventArgs e)
        {
            var inkoopForm = new MaintenanceStoringenForm();
            this.Hide();
            inkoopForm.Show(this);
        }
    }
}
