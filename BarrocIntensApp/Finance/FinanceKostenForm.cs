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
    public partial class FinanceKostenForm : Form
    {
        public FinanceKostenForm()
        {
            InitializeComponent();
            lblTitle.Text = $"Finance | {Globals.loggedInUser.Name}";
        }
    }
}
