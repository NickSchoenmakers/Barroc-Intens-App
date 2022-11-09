using Aspose.Pdf;
using Aspose.Pdf.Annotations;
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
using static Aspose.Pdf.SaveOptions;
using static BarrocIntensApp.LoginForm;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BarrocIntensApp
{
    public partial class FinanceKostenForm : Form
    {
        public FinanceKostenForm()
        {
            InitializeComponent();
            
        }

        private void roundButton2_Click(object sender, EventArgs e)
        {
            var maintenanceDashboard = new FinanceForm();
            this.Hide();
            maintenanceDashboard.Show(this);
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            var LoginForm = new LoginForm();
            this.Hide();
            LoginForm.Show(this);
        }

        private void FinanceKostenForm_Load(object sender, EventArgs e)
        {
            lblTitle.Text = $"Finance | {Globals.loggedInUser.Name}";
            decimal priceIncome = 0;
            decimal priceIncomesaved = 0;
            decimal priceOutcome = 0;
            Program.dbContext.Products.Load();
            var contracts = Program.dbContext.LeaseContracts.ToList();
            var Order = Program.dbContext.Orders.ToList();
            var Buying = Program.dbContext.CustomInvoiceProducts.ToList();


            foreach (var orderInfo in Order)
            {
                var product = Program.dbContext.Products.Where(u => u.Id == orderInfo.ProductId).FirstOrDefault();
                priceIncomesaved = (product.Price * orderInfo.Amount);
                priceIncome = priceIncome + priceIncomesaved;

                lblIncome.Text = $"Netto; {Decimal.Parse((priceIncome.ToString("0.00")))}";
            }
            foreach (var contract in contracts)
            {
                var product = Program.dbContext.Products.Where(u => u.Id == contract.ProductId).FirstOrDefault();
                priceOutcome = product.Price + priceOutcome;

                lblspending.Text = $"uitgaven: {Decimal.Parse((priceOutcome.ToString("0.00")))}";
            }
            foreach (var Buy in Buying)
            {
                var product = Program.dbContext.Products.Where(u => u.Id == Buy.ProductId).FirstOrDefault();
                priceIncomesaved = (product.Price * Buy.Amount);
                priceOutcome = priceIncome + priceIncomesaved;
                lblspending.Text = $"uitgaven: {Decimal.Parse((priceOutcome.ToString("0.00")))}";
            }
            lblTotal.Text = $"Bruto: {Decimal.Parse((priceOutcome - priceIncome).ToString("0.00"))}";
        }
    }
}
