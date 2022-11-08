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
        }
    }
}
