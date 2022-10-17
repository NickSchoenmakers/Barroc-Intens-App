using BarrocIntensApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace BarrocIntensApp
{
    public partial class FacturatieForm : Form
    {
        private AppDbContext dbContext;
        public FacturatieForm()
        {
            InitializeComponent();
        }
        public new string Name;
        public string Street;
        public string Housenr;
        public string City;
        public string Zip;
        public bool Period;
        public string Product;
        public int Amount;
        private void FacturatieForm_Load(object sender, EventArgs e)
        {
            this.dbContext = new AppDbContext();
            this.dbContext.Products.Load();
            this.productBindingSource.DataSource = dbContext.Products.Local.ToBindingList();
        }
        private void NameLbl_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void NameTb_TextChanged(object sender, EventArgs e)
        {
            NameTb.Text = Name;
        }

        private void StreetTb_TextChanged(object sender, EventArgs e)
        {
            StreetTb.Text = Street;
        }

        private void HnrTb_TextChanged(object sender, EventArgs e)
        {
            HnrTb.Text = Housenr;
        }

        private void CityTb_TextChanged(object sender, EventArgs e)
        {
            CityTb.Text = City; 
        }

        private void ZipTb_TextChanged(object sender, EventArgs e)
        {
            ZipTb.Text = Zip;
        }

        private void PeriodRb_CheckedChanged(object sender, EventArgs e)
        {
            Period = true;
            if (radioButton1.Checked)
            {
                Period = false;
                radioButton1.Checked = false;
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Period = false;
            if (PeriodRb.Checked)
            {
                Period = true;
                PeriodRb.Checked = false;
            }
        }

        private void ProductCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void AmountNu_ValueChanged(object sender, EventArgs e)
        {
            Amount = (int)AmountNu.Value;
        }

        private void productsDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}
