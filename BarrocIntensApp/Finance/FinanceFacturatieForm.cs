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
        private Company company;
        private CustomInvoice InvoiceToAdd;
        private CustomInvoiceProduct InvoiceProductToAdd;
        
        public FacturatieForm()
        {
            InitializeComponent();
            lblTitle.Text = $"Finance | {Globals.loggedInUser.Name}";

            InvoiceToAdd = new CustomInvoice();
        }
        
        private void FacturatieForm_Load(object sender, EventArgs e)
        {
            Program.dbContext = new AppDbContext();
            Program.dbContext.Products.Load();
            Program.dbContext.Companies.Load();
            Program.dbContext.CustomInvoiceProducts.Load();
            Program.dbContext.CustomInvoices.Load();
            this.customInvoiceProductBindingSource.DataSource = Program.dbContext.CustomInvoiceProducts.Local.ToBindingList();
            this.productBindingSource.DataSource = Program.dbContext.Products.Local.ToBindingList();
            this.NameCb.DataSource = Program.dbContext.Companies.Local.ToBindingList();
            company = (Company)NameCb.SelectedItem;
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

                    InvoiceProductToAdd = new CustomInvoiceProduct
                    {
                        // puts the product into the order
                        Product = product,
                        // puts the amount of product the user bought into the order
                        Amount = (int)AmountNu.Value
                    };

                    // adds the order to the database
                    InvoiceToAdd.CustomInvoiceProducts.Add(InvoiceProductToAdd);
                    this.CartGv.Rows.Add(InvoiceProductToAdd.Product.Name, InvoiceProductToAdd.Amount);
                    // saves the changes that were made to the database

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

        private void BtnReturnStoringen_Click(object sender, EventArgs e)
        {
            InvoiceToAdd.Date = DateTime.Now;
            InvoiceToAdd.PaidAt = DateTime.Now;
            //InvoiceToAdd.Company = (Company)this.NameCb.SelectedItem;
            company.CustomInvoices.Add(InvoiceToAdd);
            Program.dbContext.SaveChanges();
            this.CartGv.Refresh();
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
    }
}
