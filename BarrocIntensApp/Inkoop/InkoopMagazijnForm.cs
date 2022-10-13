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

namespace BarrocIntensApp
{
    public partial class InkoopMagazijnForm : Form
    {
        public InkoopMagazijnForm()
        {
            InitializeComponent();
            lblTitle.Text = $"Inkoop | {Globals.loggedInUser.Name}";
        }

        private void InkoopMagazijnForm_Load(object sender, EventArgs e)
        {
            Program.dbContext.Products.Load();
            Program.dbContext.ProductCategories.Load();

            this.productCategoriesGridView2.DataSource = Program.dbContext.ProductCategories.Local.ToBindingList();
        }

        private void productCategoriesGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (Program.dbContext == null)
                return;

            var productCategory = (ProductCategory)this.productCategoriesGridView2.CurrentRow?.DataBoundItem;

            if (productCategory == null)
                return;

            productsDataGridView.DataSource = productCategory.Products;
        }

        private void productsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (Program.dbContext == null)
                return;

            var product = (Product)this.productsDataGridView.CurrentRow?.DataBoundItem;

            if (product == null)
                return;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Program.dbContext == null)
                return;

            Program.dbContext.SaveChanges();

            this.productCategoriesGridView2.Refresh();
            this.productsDataGridView.Refresh();
        }
    }
}
