using BarrocIntensApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarrocIntensApp
{
    public partial class LoginForm : Form
    {
        public static class Globals
        {
            public static User loggedInUser;
        }

        public LoginForm()
        {
            InitializeComponent();
            txbUserPassword.PasswordChar = '●';

            // Uncomment the line below to start fresh with a new database.
            // this.dbContext.Database.EnsureDeleted();
            Program.dbContext.Database.EnsureCreated();            
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();
        }

        private void txbUserPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
        }
        private void login()
        {
            // saves the user given data
            string username = txbUserName.Text.ToString();
            string password = txbUserPassword.Text.ToString();

            // checks if the username and password exist and if they are in the same table
            Globals.loggedInUser = Program.dbContext.Users.Where(u => u.Username == username && u.Password == password).FirstOrDefault();
            if (Globals.loggedInUser == null)
            {
                // if the user gives a wrong account it gives this message
                MessageBox.Show("vul een correct user in");
            }
            else
            {
                // checks for the role id
                if (Globals.loggedInUser.RoleId == 1)
                {
                    // sends user to the inkoop page
                    var inkoopForm = new InkoopForm();
                    this.Hide();
                    inkoopForm.Show(this);
                }
                // checks for the role id
                else if (Globals.loggedInUser.RoleId == 4)
                {
                    // sends user to the finance form
                    var financeForm = new FinanceForm();
                    this.Hide();
                    financeForm.Show(this);
                }
                // checks for the role id
                else if (Globals.loggedInUser.RoleId == 2)
                {
                    // sends user to the maintenance form
                    var maintenanceForm = new MaintenanceForm();
                    this.Hide();
                    maintenanceForm.Show(this);
                }
                // checks for the role id
                else if (Globals.loggedInUser.RoleId == 3)
                {
                    // sends user to the sales form
                    var salesForm = new SalesForm();
                    this.Hide();
                    salesForm.Show(this);
                }
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
