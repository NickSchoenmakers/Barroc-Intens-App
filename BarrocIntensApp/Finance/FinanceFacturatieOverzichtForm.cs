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

namespace BarrocIntensApp.Finance
{
    public partial class FinanceFacturatieOverzichtForm : Form
    {
        public FinanceFacturatieOverzichtForm()
        {
            InitializeComponent();
            Program.dbContext.Products.Load();
            Program.dbContext.Companies.Load();
            Program.dbContext.CustomInvoiceProducts.Load();
            Program.dbContext.CustomInvoices.Load();

            this.InvoiceGridView.DataSource = Program.dbContext.CustomInvoices.Local.ToBindingList();
            this.productsDataGridview.DataSource = Program.dbContext.CustomInvoiceProducts.Local.ToBindingList();
        }
        private void FinanceFacturatieOverzichtForm_Load_1(object sender, EventArgs e)
        {

        }
        private void FinanceFacturatieOverzichtForm_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void InvoiceGridView_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void InvoiceGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            var Invoice = (CustomInvoice)this.InvoiceGridView.CurrentRow.DataBoundItem;


            Program.dbContext.Entry(Invoice)
                .Collection(I => I.CustomInvoiceProducts)
                .Load();
            DateData.Text = Invoice?.Date.ToString();
            CompanyData.Text = Invoice?.Company.ToString();
            PaidData.Text = Invoice?.PaidAt.ToString();

            productsDataGridview.DataSource = Invoice.CustomInvoiceProducts;
        }

        private void productsDataGridview_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var product = (CustomInvoiceProduct)this.productsDataGridview.CurrentRow.DataBoundItem;
            
            ProductData.Text = product.Product.Name;
            AmountData.Text = product.Amount.ToString();
            priceProductData.Text = product.Product.Price.ToString();
            int test = product.Amount * ((int)product.Product.Price);
            TotalPriceData.Text = test.ToString();
        }
    }
}
