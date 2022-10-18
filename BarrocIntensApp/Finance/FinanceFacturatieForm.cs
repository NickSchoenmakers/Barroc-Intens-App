using BarrocIntensApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
        public int i = 0;
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public new string Name { get; set; }
        public string Street { get; set; }
        public string Housenr { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public bool Period { get; set; }
        public int Amount { get; set; }
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
          Name =  NameTb.Text;
        }

        private void StreetTb_TextChanged(object sender, EventArgs e)
        {
           Street = StreetTb.Text;
        }

        private void HnrTb_TextChanged(object sender, EventArgs e)
        {
          Housenr = HnrTb.Text;
        }

        private void CityTb_TextChanged(object sender, EventArgs e)
        {
          City = CityTb.Text;
        }

        private void ZipTb_TextChanged(object sender, EventArgs e)
        {
          Zip = ZipTb.Text;
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
            //ProductId = (Product)this.productsDataGridView.CurrentRow.DataBoundItem;
            var product = (Product)this.productsDataGridView.CurrentRow?.DataBoundItem;
            Testlabel.Text = product?.Id.ToString();
            ProductId = product.Id;
        }

        public void Cartbtn_Click(object sender, EventArgs e)
        {
            
            i = i+1;
            OrderId = i;
            object[] CartArray = new object[9];
            CartArray[0] = OrderId;
            CartArray[1] = ProductId;
            CartArray[2] = Name;
            CartArray[3] = Street;
            CartArray[4] = Housenr;
            CartArray[5] = City;
            CartArray[6] = Zip;
            CartArray[7] = Amount;
            CartArray[8] = Period;

            CartGv.DataSource = CartArray;

        }
    }
}
