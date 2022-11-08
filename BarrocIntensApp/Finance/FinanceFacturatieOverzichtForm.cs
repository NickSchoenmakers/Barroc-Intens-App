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
        private AppDbContext dbContext;
        public FinanceFacturatieOverzichtForm()
        {
            InitializeComponent();
        }

        private void FinanceFacturatieOverzichtForm_Load(object sender, EventArgs e)
        {
            this.dbContext = new AppDbContext();
            this.dbContext.Products.Load();
            this.dbContext.Companies.Load();
            this.dbContext.CustomInvoiceProducts.Load();
            this.dbContext.CustomInvoices.Load();

            this.InvoiceGridView.DataSource = dbContext.CustomInvoices.Local.ToBindingList();
            this.productsDataGridview.DataSource = dbContext.CustomInvoiceProducts.Local.ToBindingList();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void InvoiceGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dbContext == null)
                return;

            var Invoice = (CustomInvoice)this.InvoiceGridView.CurrentRow.DataBoundItem;

            if (Invoice == null)
                return;

            this.dbContext.Entry(Invoice)
                .Collection(I => I.CustomInvoiceProducts)
                .Load();
            DateData.Text = Invoice?.Date.ToString();
            CompanyData.Text = Invoice?.Company.ToString();
            PaidData.Text = Invoice?.PaidAt.ToString();

            productsDataGridview.DataSource = Invoice.CustomInvoiceProducts;
        }
    }
}
