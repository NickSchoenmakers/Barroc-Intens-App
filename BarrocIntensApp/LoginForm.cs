using BarrocIntensApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarrocIntensApp
{
    public partial class LoginForm : Form
    {
        
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnInkoop_Click(object sender, EventArgs e)
        {
            var inkoopForm = new InkoopForm();
            this.Hide();
            inkoopForm.Show(this);
        }

        private void btnfinance_Click(object sender, EventArgs e)
        {
            var inkoopForm = new FinanceForm();
            this.Hide();
            inkoopForm.Show(this);
        }

        private void btnmaintenance_Click(object sender, EventArgs e)
        {
            var inkoopForm = new MaintenanceForm();
            this.Hide();
            inkoopForm.Show(this);
        }

        private void btnsales_Click(object sender, EventArgs e)
        {
            var inkoopForm = new SalesForm();
            this.Hide();
            inkoopForm.Show(this);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txbUserName.Text.ToString();
            
            string password = txbUserPassword.Text.ToString();
            if (username == "inkoop" && password == "inkoop")
            {
                var inkoopForm = new InkoopForm();
                this.Hide();
                inkoopForm.Show(this);
            }
            else if(username == "finance" && password == "finance")
            {
                var inkoopForm = new FinanceForm();
                this.Hide();
                inkoopForm.Show(this);
            }
            else if (username == "maintenance" && password == "maintenance")
            {
                var inkoopForm = new MaintenanceForm();
                this.Hide();
                inkoopForm.Show(this);
            }
            else if (username == "sales" && password == "sales")
            {
                var inkoopForm = new SalesForm();
                this.Hide();
                inkoopForm.Show(this);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
