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
            this.cbCategories.DataSource  = Program.dbContext.ProductCategories.Local.ToBindingList();
            var productCategory = (ProductCategory)this.cbCategories.SelectedItem;
            dgvProducts.DataSource = productCategory.Products;
            cbFilter.SelectedIndex = 0;
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
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            Product product = GetProduct();
            product.Stock++;
            Program.dbContext.Products.Update(product);
            Program.dbContext.SaveChanges();
            this.RefreshProductInfo();
        }

        private Product GetProduct()
        {
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
            var productCategory = (ProductCategory)this.cbCategories.SelectedItem;
            dgvProducts.DataSource = productCategory.Products;
            if (cbFilter.SelectedIndex == 0)
            {
                dgvProducts.DataSource = productCategory.Products;
            }
            else if (cbFilter.SelectedIndex == 1)
            {
                dgvProducts.DataSource = productCategory.Products.Where(p => p.Stock > 0).ToList();
            }
            else if (cbFilter.SelectedIndex == 2)
            {
                dgvProducts.DataSource = productCategory.Products.Where(p => p.Stock == 0).ToList();
            }
        }
    }
}
