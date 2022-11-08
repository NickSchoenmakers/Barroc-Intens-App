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
using static BarrocIntensApp.LoginForm;

namespace BarrocIntensApp.Inkoop
{
    public partial class InkoopBestellenForm : Form
    {
        public InkoopBestellenForm()
        {
            InitializeComponent();
            
            lblTitle.Text = $"Inkoop | {Globals.loggedInUser.Name}";
            Program.dbContext.Products.Load();
            Program.dbContext.ProductCategories.Load();
            Program.dbContext.Orders.Load();

            this.dgvOrders.DataSource = Program.dbContext.Orders.Local.ToBindingList();

            this.cbCategories.DataSource  = Program.dbContext.ProductCategories.Local.ToBindingList();
            var productCategory = (ProductCategory)this.cbCategories.SelectedItem;

            dgvProducts.DataSource = productCategory.Products;
            cbFilter.SelectedIndex = 0;

            this.cbProductCategory.DataSource = Program.dbContext.ProductCategories.Local.ToBindingList();
            numProductPrice.Controls[0].Visible = false;
        }

        private void btnReturnDashboard_Click(object sender, EventArgs e)
        {
            var inkoopForm = new InkoopForm();
            this.Hide();
            inkoopForm.Show(this);
        }

        private void cbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Program.dbContext == null)
                return;

            var productCategory = (ProductCategory)this.cbCategories.SelectedItem;

            if (productCategory == null)
                return;

            FilterProducts();
        }

        private void dgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            this.RefreshProductInfo();
            this.groupProductInfo.Show();
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            // calls the method getproduct in order to load the selected row in the datagridview
            Product product = GetProduct();
            // if the user did not select an amount to add it just adds 1 to the stock of the item
            if (String.IsNullOrEmpty(txbAmount.Text))
            {
                
            }
            else
            {
                // converts the amount given by the user into an int so we can actually do math with it
                int aantal = Convert.ToInt32(txbAmount.Text);
                // checks if the order is bigger than 5000
                if (aantal >= 5000)
                {
                    // tells the user that they need permission to do this order
                    lbPermission.Text = "Toestemming vereist voor bestellingen die meer producten kopen dat 5000";
                }
                else
                {
                    // adds the amount of products selected to the stock
                    var order = new Order
                    {
                        Amount = aantal,
                        // puts the product into the order
                        ProductId = product.Id,
                        hasArrived = false,
                    };
                    // saves the changes to the database
                    Program.dbContext.Orders.Update(order);
                    Program.dbContext.SaveChanges();
                    this.RefreshProductInfo();
                }
            }
        }

        private Product GetProduct()
        {
            // gets the selected row in the datagrid view and puts it into a variable
            // this method is called buy typing GetProduct();
            var product = (Product)this.dgvProducts.CurrentRow?.DataBoundItem;
            return product;
        }

        private void RefreshProductInfo()
        {
            Product product = GetProduct();
            lblPrice.Text = $"Prijs: {Decimal.Parse(product?.Price.ToString("0.00"))}";
            lblStock.Text = $"Aantal op voorraad: {product?.Stock.ToString()}";
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterProducts();
        }
        private void FilterProducts()
        {
            // here we filter the products based on if it is avaliable
            // gets the selected filter
            var productCategory = (ProductCategory)this.cbCategories.SelectedItem;
            // if no alles is selected it will do this
            if (cbFilter.SelectedIndex == 0)
            {
                // this shows all products
                dgvProducts.DataSource = productCategory.Products;
            }
            // if the user selects op voorraad it will do this
            else if (cbFilter.SelectedIndex == 1)
            {
                // this show all products that have stock
                dgvProducts.DataSource = productCategory.Products.Where(p => p.Stock > 0).ToList();
            }
            // if the user selects niet op voorraad it will do this
            else if (cbFilter.SelectedIndex == 2)
            {
                // this shows all product that do not have stock
                dgvProducts.DataSource = productCategory.Products.Where(p => p.Stock == 0).ToList();
            }
        }

        private void tbxSearch_Enter(object sender, EventArgs e)
        {
            if (tbxSearch.Text == "Typ hier om te zoeken..")
            {
                tbxSearch.Text = "";

                tbxSearch.ForeColor = Color.Black;
            }
        }

        private void tbxSearch_Leave(object sender, EventArgs e)
        {
            if (tbxSearch.Text == "")
            {
                tbxSearch.Text = "Typ hier om te zoeken..";
                tbxSearch.ForeColor = Color.Gray;
                FilterProducts();
            }
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbxSearch.Text != "Typ hier om te zoeken.." || tbxSearch.Text != "")
            {
                dgvProducts.DataSource = Program.dbContext.Products.Where(p => p.Name.Contains(tbxSearch.Text) && p.ProductCategoryId == (int)cbCategories.SelectedValue).ToList();
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (Globals.loggedInUser.isManager == true)
            {
                var product = GetProduct();
                Program.dbContext.Remove(product);
                Program.dbContext.SaveChanges();
                dgvProducts.ClearSelection();
                groupProductInfo.Hide();
            }
            else
            {
                MessageBox.Show("you are not a manager, you cannot do this");
            }

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            // this adds a product
            Product productToAdd = new Product
            {
                // gives the product a name
                Name = txbProductName.Text,
                // gives the product a discription
                Description = txbProductDescription.Text,
                // gives the product a price
                Price = numProductPrice.Value,
                // gives the product a category
                ProductCategoryId = (int)cbProductCategory.SelectedValue,
                // gives the product a check if it is a part or not. 
                // this does not need to be checked
                isPart = checkPart.Checked
            };
            // adds the product to the database
            Program.dbContext.Products.Add(productToAdd);
            // sabes the database
            Program.dbContext.SaveChanges();
        }

        private void cbProductCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            if ((int)cbProductCategory.SelectedIndex == 1)
            {
                checkPart.Checked = false;
                checkPart.Hide();
            }
            else
            {
                checkPart.Show();
            }
        }

        private void InkoopBestellenForm_Load(object sender, EventArgs e)
        {

        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            var LoginForm = new LoginForm();
            this.Hide();
            LoginForm.Show(this);
        }

        private void dgvOrders_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Program.dbContext.SaveChanges();
        }
    }
}
