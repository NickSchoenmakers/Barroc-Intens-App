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
    public partial class InkoopForm : Form
    {
        public InkoopForm()
        {
            InitializeComponent();
        }

        private void btnMagazijn_Click_1(object sender, EventArgs e)
        {
            var inkoopMagazijnForm = new InkoopMagazijnForm();
            this.Hide();
            inkoopMagazijnForm.Show(this);
        }
    }
}
