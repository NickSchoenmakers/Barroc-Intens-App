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
            this.dbContext.Companies.Load();
            this.productBindingSource.DataSource = dbContext.Products.Local.ToBindingList();
            this.NameCb.DataSource = dbContext.Companies.Local.ToBindingList();

        }
        private void NameLbl_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }


        private void StreetTb_TextChanged(object sender, EventArgs e)
        {
          // Street = StreetTb.Text;
        }

        private void HnrTb_TextChanged(object sender, EventArgs e)
        {
         // Housenr = HnrTb.Text;
        }

        private void CityTb_TextChanged(object sender, EventArgs e)
        {
          //City = CityTb.Text;
        }

        private void ZipTb_TextChanged(object sender, EventArgs e)
        {
          //Zip = ZipTb.Text;
        }

        private void ProductCbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AmountNu_ValueChanged(object sender, EventArgs e)
        {
           // Amount = (int)AmountNu.Value;
        }

        private void productsDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //ProductId = (Product)this.productsDataGridView.CurrentRow.DataBoundItem;
            var product = (Product)this.productsDataGridView.CurrentRow?.DataBoundItem;
            ProductId = product.Id;
        }

        public void Cartbtn_Click(object sender, EventArgs e)
        {
            var CompanyName = (string) NameCb.SelectedValue;
            i = i+1;
            OrderId = i;
            object[] CartArray = new object[8];
            CartArray[0] = OrderId;
            CartArray[1] = ProductId;
            CartArray[2] = CompanyName;
            CartArray[3] = StreetTb.Text;
            CartArray[4] = HnrTb.Text;
            CartArray[5] = CityTb.Text;
            CartArray[6] = ZipTb.Text;
            CartArray[7] = (int)AmountNu.Value;
            CartArray[8] = Period;
            CartGv.DataSource = CartArray;

        }
    }
}
