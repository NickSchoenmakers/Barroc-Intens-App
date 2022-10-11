using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarrocIntensApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnInkoop_Click(object sender, EventArgs e)
        {
            var inkoopForm = new InkoopForm();
            this.Hide();
            inkoopForm.Show(this);
        }

        private void btnfinance_Click(object sender, EventArgs e)
        {
            var inkoopForm = new FinanceForm();
            this.Hide();
            inkoopForm.Show(this);
        }

        private void btnmaintenance_Click(object sender, EventArgs e)
        {
            var inkoopForm = new MaintencanceForm();
            this.Hide();
            inkoopForm.Show(this);
        }

        private void btnsales_Click(object sender, EventArgs e)
        {
            var inkoopForm = new SalesForm();
            this.Hide();
            inkoopForm.Show(this);
        }
    }
}
