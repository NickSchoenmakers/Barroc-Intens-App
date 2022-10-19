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

        DateTime Date = DateTime.Now;
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
            this.productBindingSource.DataSource = dbContext.Products.Local.ToBindingList();
            this.NameCb.DataSource = dbContext.Companies.Local.ToBindingList();

            MessageBox.Show("test");
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
            //int[] CartArray = new int[3];
            //CartArray[0] = Amount;
            //CartArray[1] = ProductId;
            //CartArray[2] = Id;

            //CartGv.DataSource = CartArray;
            //while (true) {
            //var id = this.dbContext.CustomInvoiceProducts.Where(u => u.Id != Id).FirstOrDefault();
            //    if (id != null)
            //    {
            //        Id++;
            //        MessageBox.Show(Id.ToString(), "is niet uniek");
            //        MessageBox.Show("is niet uniek");
            //    }
            //    else {
            //        MessageBox.Show(Id.ToString(), "is uniek");
            //        MessageBox.Show("is uniek");
            //        break;
            //    }
            //}
            int counter = 0;
            while (true) {
                counter++;
                var idcheck = this.dbContext.CustomInvoiceProducts.Where(u => u.Id != Id).FirstOrDefault();
                if (idcheck != null)
                {
                    MessageBox.Show(counter.ToString(), "is uniek");
                    MessageBox.Show("is uniek");
                    break;
                }
                
            }

            //    var ProductToAdd = new CustomInvoiceProduct {
            //        Amount = (int)AmountNu.Value,
            //        ProductId = ProductId,

            //};

        }

        private void NameCb_SelectedValueChanged(object sender, EventArgs e)
        {
            var CompanyId = (String)NameCb.SelectedText;
        }
    }
}
