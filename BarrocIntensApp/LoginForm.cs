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

        public LoginForm()
        {
            InitializeComponent();
            this.dbContext = new AppDbContext();

            // Uncomment the line below to start fresh with a new database.
            // this.dbContext.Database.EnsureDeleted();
            this.dbContext.Database.EnsureCreated();
            
            
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txbUserName.Text.ToString();
            string password = txbUserPassword.Text.ToString();

            User loggedinUser = this.dbContext.Users.Where(u => u.Username == username && u.Password == password).FirstOrDefault();





            if (loggedinUser == null)
            {
            }
            else 
            {
                if (loggedinUser.RoleId == 1)
                {
                    var inkoopForm = new InkoopForm();
                    this.Hide();
                    inkoopForm.Show(this);
                }
                else if (loggedinUser.RoleId == 4)
                {
                    var inkoopForm = new FinanceForm();
                    this.Hide();
                    inkoopForm.Show(this);
                }
                else if (loggedinUser.RoleId == 2)
                {
                    var inkoopForm = new MaintenanceForm();
                    this.Hide();
                    inkoopForm.Show(this);
                }
                else if (loggedinUser.RoleId == 3)
                {
                    var inkoopForm = new SalesForm();
                    this.Hide();
                    inkoopForm.Show(this);
                }
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
