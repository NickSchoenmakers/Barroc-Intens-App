﻿using System;
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
    public partial class SalesOfferteForm : Form
    {
        public SalesOfferteForm()
        {
            InitializeComponent();
        }

        private void btnBackOfferte_Click(object sender, EventArgs e)
        {
            var sales = new SalesForm();
            this.Hide();
            sales.Show(this);
        }
    }
}
