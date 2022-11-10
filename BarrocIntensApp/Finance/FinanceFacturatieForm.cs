using BarrocIntensApp.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BarrocIntensApp.LoginForm;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BarrocIntensApp
{
    public partial class FacturatieForm : Form
    {
        float ProductPriceDouble = 0;
        float price = 0;
        private AppDbContext dbContext;
        public FacturatieForm()
        {
            InitializeComponent();
            lblTitle.Text = $"Finance | {Globals.loggedInUser.Name}";
        }
        public int ProductId { get; set; }
        public int Id = 0;
        public int CustomInvoiceProductId { get; set; }
        public int ProductInCart =0;
        public int testc;
        public int Amount { get; set; }
        public int Date { get;  set; }
        public int PaidAt { get;  set; }
        public Company Company { get;  set; }
        public CustomInvoice ProductToBuy { get; set; }
        private void FacturatieForm_Load(object sender, EventArgs e)
        {
            this.dbContext = new AppDbContext();
            this.dbContext.Products.Load();
            this.dbContext.Companies.Load();
            this.dbContext.CustomInvoiceProducts.Load();
            this.dbContext.CustomInvoices.Load();
            

            this.customInvoiceProductBindingSource.DataSource = dbContext.CustomInvoiceProducts.Local.ToBindingList();

            this.productBindingSource.DataSource = dbContext.Products.Local.ToBindingList();
            this.NameCb.DataSource = dbContext.Companies.Local.ToBindingList();


                ProductToBuy = new CustomInvoice
                {
                    Date = DateTime.Now,
                    PaidAt = DateTime.Now,

                };
                Company.CustomInvoices.Add(ProductToBuy);

            //var CustomInvoiceProducts = Program.dbContext.CustomInvoiceProducts.ToList();
            //var CustomInvoiceProduct = CustomInvoiceProducts[0];

            //Program.dbContext.Entry(CustomInvoiceProduct)
            //                 .Reference(c => c.Id)
            //                 .Load();


        }
        private void NameLbl_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void CartGv_SelectionChanged(object sender, EventArgs e)
        {
            
        }


        private void ProductCbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AmountNu_ValueChanged(object sender, EventArgs e)
        {
            // gets the amount of products the user want to buy
            Amount = (int)AmountNu.Value;
        }

        private void productsDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        public void Cartbtn_Click(object sender, EventArgs e)
        {
            // loads the selected product into a usable variable
            var product = (Product)this.productsDataGridView.CurrentRow?.DataBoundItem;
            // checks if the user choose a product
            if (product != null)
            {
                // checks if there is enough stock for the user to buy
                if (product.Stock >= (int)AmountNu.Value)
                {
                    // subtracts the amount of products bought from the stock
                    product.Stock = product.Stock - (int)AmountNu.Value;
                    // creates a new order
                    var ProductToAdd = new CustomInvoiceProduct
                    {
                        // puts the amount of product the user bought into the order
                        Amount = (int)AmountNu.Value,
                        // puts the product into the order
                        Product = product,
                    };
                    // adds the order to the database
                    ProductToBuy.CustomInvoiceProducts.Add(ProductToAdd);
                    // saves the changes that were made to the database
                    this.dbContext.SaveChanges();
                    // refreshes the orders datagrid
                    this.CartGv.Refresh();
                    // refreshes the product datagrid
                    this.productsDataGridView.Refresh();
                }
                else 
                {
                    // this message gets shows if there is not enough stock for the order
                    MessageBox.Show("er zijn niet genoeg producten in voorraad om aan deze bestelling te voldoen, neem contact op met inkoop om eventueel meer producten te kopen om aan de bestelling te voldoen");
                }

            }
            else 
            {
                // this message is shows if the user did not select a product
                MessageBox.Show("please select a product");
            }
        }

        private void NameCb_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(NameCb.ValueMember)) { 
                Company = (Company)NameCb.SelectedItem;
            }
             
        }

        private void pbBlack_Click(object sender, EventArgs e)
        {

        }

        private void CartGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void BtnReturnStoringen_Click(object sender, EventArgs e)
        {

                this.dbContext.SaveChanges();
                this.CartGv.Refresh();
        }
        private void lblPrice_Click(object sender, EventArgs e)
        {

        }

        private void CartGv_SelectionChanged_1(object sender, EventArgs e)
        {
            // gets the row from the designer
            var ProductPrice = (CustomInvoiceProduct)this.CartGv.CurrentRow?.DataBoundItem;

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

        private void roundButton1_Click(object sender, EventArgs e)
        {
            // logs the user out
            var LoginForm = new LoginForm();
            this.Hide();
            LoginForm.Show(this);
        }

        private void roundButton2_Click(object sender, EventArgs e)
        {
            // sends the user back to the maintenance dashboard
            var maintenanceDashboard = new FinanceForm();
            this.Hide();
            maintenanceDashboard.Show(this);
        }

        private void productsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void NameCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
