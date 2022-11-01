using BarrocIntensApp.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
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
        private AppDbContext dbContext;
        public FacturatieForm()
        {
            InitializeComponent();
            //lblTitle.Text = $"Finance | {Globals.loggedInUser.Name}";
        }
        public int ProductId { get; set; }
        public int Id = 0;
        public int CustomInvoiceProductId { get; set; }
        public int ProductInCart =0;
        public int testc;
        public int Amount { get; set; }
        public int Date { get; private set; }
        public int PaidAt { get; private set; }
        public int CompanyId { get; private set; }

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

            var CustomInvoicesid = this.dbContext.CustomInvoices.Select(x => x.Id).Max();
            int testc = CustomInvoicesid++;
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
            if (ProductId != 0)
            {
                int[] CartArray = new int[4];
                CartArray[0] = Amount;
                CartArray[1] = ProductId;
                CartArray[2] = Id;
                //CartArray[3] = testc;

                var id = this.dbContext.CustomInvoiceProducts.Select(x => x.Id).Max();
                id++;
                CustomInvoiceProductId = id;
                var ProductToAdd = new CustomInvoiceProduct
                {
                    Amount = (int)AmountNu.Value,
                    ProductId = ProductId,
                    Id = id,
                    //CustomInvoiceId = testc
                };
                this.dbContext.CustomInvoiceProducts.Add(ProductToAdd);
                this.dbContext.SaveChanges();
                this.CartGv.Refresh();
                ProductInCart++;
            }
            else 
            {
                MessageBox.Show("please select a product");
            }
        }

        private void NameCb_SelectedValueChanged(object sender, EventArgs e)
        {
             CompanyId = (int)NameCb.SelectedValue;
        }

        private void pbBlack_Click(object sender, EventArgs e)
        {

        }

        private void CartGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnReturnStoringen_Click(object sender, EventArgs e)
        {
            if (ProductInCart != 0)
            {

                int[] InvoiceArray = new int[3];
                InvoiceArray[0] = Id;
                InvoiceArray[1] = Date;
                InvoiceArray[2] = PaidAt;
                InvoiceArray[3] = CompanyId;

                var id = this.dbContext.CustomInvoices.Select(x => x.Id).Max();
                id++;

                var ProductToBuy = new CustomInvoice
                {
                    Id = id,
                    Date = DateTime.Now,
                    PaidAt = DateTime.Now,
                    CompanyId = CompanyId

                };
                this.dbContext.CustomInvoices.Add(ProductToBuy);
                this.dbContext.SaveChanges();
                this.CartGv.Refresh();
                ProductInCart = 0;
            }
            else
            {
                MessageBox.Show("please select a product");
            }
        }
    }
}
