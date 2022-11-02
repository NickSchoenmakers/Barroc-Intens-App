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
    public partial class FinanceLeaseForm : Form
    {
        public FinanceLeaseForm()
        {
            InitializeComponent();
            lblTitle.Text = $"Finance | {Globals.loggedInUser.Name}";
        }

        private void FinanceLeaseForm_Load(object sender, EventArgs e)
        {
            Program.dbContext.Companies.Load();
            companyBindingSource.DataSource = Program.dbContext.Companies.Local.ToBindingList();
        }

        private void cbCompanies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbCompanies.ValueMember == null)
            {
                lbCheckedResult.Text = "nee";
            }
            else
            {
                lbCheckedResult.Text = "ja";
            }
        }
    }
}
