using BarrocIntensApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
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
        private AppDbContext dbContext;

        public static class Globals
        {
            public static User loggedInUser;
        }

        public LoginForm()
        {
            InitializeComponent();
            this.dbContext = new AppDbContext();

            // Uncomment the line below to start fresh with a new database.
            // this.dbContext.Database.EnsureDeleted();
            this.dbContext.Database.EnsureCreated();
            
            
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
            // stores the given info from the user
            string username = txbUserName.Text.ToString();
            string password = txbUserPassword.Text.ToString();

            // puts the user info into an object if both exist in the tame table as eachother
            Globals.loggedInUser = this.dbContext.Users.Where(u => u.Username == username && u.Password == password).FirstOrDefault();

            // checks if the user existed in the table
            Globals.loggedInUser = this.dbContext.Users.Where(u => u.Username == username && u.Password == password).FirstOrDefault();

            if (Globals.loggedInUser == null)
            {
                MessageBox.Show("please give correct login info");
            }
            else 
            {
                if (Globals.loggedInUser.RoleId == 1)
                {
                    // sends user to the inkoop form
                    var inkoopForm = new InkoopForm();
                    this.Hide();
                    inkoopForm.Show(this);
                }
                else if (Globals.loggedInUser.RoleId == 4)
                {
                    // sends user to finance form
                    var financeForm = new FinanceForm();
                    this.Hide();
                    financeForm.Show(this);
                }
                else if (Globals.loggedInUser.RoleId == 2)
                {
                    // sends user to the maintenance form
                    var maintenanceForm = new MaintenanceForm();
                    this.Hide();
                    maintenanceForm.Show(this);
                }
                else if (Globals.loggedInUser.RoleId == 3)
                {
                    // sends user to the sales form
                    var salesForm = new SalesForm();
                    this.Hide();
                    salesForm.Show(this);
                }
                else 
                {
                    // tells the user they gave wrong login info
                    MessageBox.Show("invalid inlog info");
                    var salesForm = new SalesForm();
                    this.Hide();
                    salesForm.Show(this);
                }
            }




            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
