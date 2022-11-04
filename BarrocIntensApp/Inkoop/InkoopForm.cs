using BarrocIntensApp.Inkoop;
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
    public partial class InkoopForm : Form
    {
        public InkoopForm()
        {
            InitializeComponent();
            lblTitle.Text = $"Inkoop | {Globals.loggedInUser.Name}";
        }

        private void btnBestellen_Click(object sender, EventArgs e)
        {
            var inkoopBestellenForm = new InkoopBestellenForm();
            this.Hide();
            inkoopBestellenForm.Show(this);
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            var LoginForm = new LoginForm();
            this.Hide();
            LoginForm.Show(this);
        }
    }
}
