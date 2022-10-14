﻿using BarrocIntensApp.Models;
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
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txbUserName.Text.ToString();
            string password = txbUserPassword.Text.ToString();

            Globals.loggedInUser = this.dbContext.Users.Where(u => u.Username == username && u.Password == password).FirstOrDefault();
            if (Globals.loggedInUser == null)
            {
            }
            else 
            {
                if (Globals.loggedInUser.RoleId == 1)
                {

                    var inkoopForm = new InkoopForm();
                    this.Hide();
                    inkoopForm.Show(this);
                }
                else if (Globals.loggedInUser.RoleId == 4)
                {
                    var financeForm = new FinanceForm();
                    this.Hide();
                    financeForm.Show(this);
                }
                else if (Globals.loggedInUser.RoleId == 2)
                {
                    var maintenanceForm = new MaintenanceForm();
                    this.Hide();
                    maintenanceForm.Show(this);
                }
                else if (Globals.loggedInUser.RoleId == 3)
                {
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
    }
}
