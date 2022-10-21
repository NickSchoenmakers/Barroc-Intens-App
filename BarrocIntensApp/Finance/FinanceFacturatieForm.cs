using BarrocIntensApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
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
using static BarrocIntensApp.LoginForm;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BarrocIntensApp
{
    public partial class FacturatieForm : Form
    {
        private AppDbContext dbContext;
        public FacturatieForm()
        {
            InitializeComponent();
        }
        float ProductPriceDouble = 0;
        float price = 0;
        public int ProductId { get; set; }
        public int Id = 0;
        public bool Idtest { get; set; }
        public int Amount { get; set; }
        private void FacturatieForm_Load(object sender, EventArgs e)
        {
            this.dbContext = new AppDbContext();
            this.dbContext.Products.Load();
            this.dbContext.Companies.Load();
            this.dbContext.CustomInvoiceProducts.Load();

            this.customInvoiceProductBindingSource.DataSource = dbContext.CustomInvoiceProducts.Local.ToBindingList();

            this.productBindingSource.DataSource = dbContext.Products.Local.ToBindingList();
            this.NameCb.DataSource = dbContext.Companies.Local.ToBindingList();
        }
        private void NameLbl_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

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
            ProductId = product.Id;
        }

        public void Cartbtn_Click(object sender, EventArgs e)
        {
            if (ProductId == 0)
            {
                MessageBox.Show("please select a product");
                return;
            }
            int[] CartArray = new int[3];
            CartArray[0] = Amount;
            CartArray[1] = ProductId;
            CartArray[2] = Id;

            var id = this.dbContext.CustomInvoiceProducts.Select(x => x.Id).Max();
            id++;
            MessageBox.Show(id.ToString());
            var ProductToAdd = new CustomInvoiceProduct
            {
                Amount = (int)AmountNu.Value,
                ProductId = ProductId,
                Id = id
            };
            this.dbContext.CustomInvoiceProducts.Add(ProductToAdd);
            this.dbContext.SaveChanges();
            this.InvoiceProductsdgv.Refresh();
        }

        private void NameCb_SelectedValueChanged(object sender, EventArgs e)
        {
            var CompanyId = (String)NameCb.SelectedText;
        }

        private void pbBlack_Click(object sender, EventArgs e)
        {

        }

        private void CartGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void InvoiceProductsdgv_SelectionChanged(object sender, EventArgs e)
        {
            // gets the row from the designer
            var ProductPrice = (CustomInvoiceProduct)this.InvoiceProductsdgv.CurrentRow?.DataBoundItem;

            // checks if something was selected in the datagrid
            if (ProductPrice == null)
                return;

            // puts the price of a product into a variable
            ProductPriceDouble = (float)ProductPrice.Product.Price;

            // round up the price
            ProductPriceDouble = (float)Math.Round(ProductPriceDouble * 100f) / 100f;
            // calculates the total price of everything
            price = ProductPrice.Amount * ProductPriceDouble;

            // shows the user what the price is
            lblPrice.Text = price.ToString();
        }
    }
}
