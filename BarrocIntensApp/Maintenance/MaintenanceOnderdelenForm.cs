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
    public partial class MaintenanceOnderdelenForm : Form
    {
        public MaintenanceOnderdelenForm()
        {
            InitializeComponent();
        }

        private void BtnReturnStoringen_Click(object sender, EventArgs e)
        {
            var inkoopForm = new MaintencanceForm();
            this.Hide();
            inkoopForm.Show(this);
        }
    }
}
