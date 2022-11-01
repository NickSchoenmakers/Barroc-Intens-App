using Aspose.Pdf;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Messaging;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BarrocIntensApp.LoginForm;

namespace BarrocIntensApp
{
    public partial class SalesOfferteForm : Form
    {
        public SalesOfferteForm()
        {
            InitializeComponent();

            lblTitle.Text = $"Sales | {Globals.loggedInUser.Name}";

            Program.dbContext.Products.Load();
            this.dgvProducts.DataSource = Program.dbContext.Products.Local.ToBindingList();
        }

        private void btnBackNotes_Click(object sender, EventArgs e)
        {
            var sales = new SalesForm();
            this.Hide();
            sales.Show(this);
        }

        private void BtnSendMail_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            pbLoad.Visible = true;
            pbLoad.BringToFront();

            Task.Run(() =>
            {
                // Initialize document object
                Document document = new Document();
                // Add page
                Page page = document.Pages.Add();
                // Add text to new page
                page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("Hello World!"));
                // Save updated PDF
                var outputFileName = System.IO.Path.Combine("HelloWorld_out.pdf");
                document.Save(outputFileName);

                Process.Start(outputFileName);

                this.Invoke((MethodInvoker)delegate {
                    this.Enabled = true;
                    pbLoad.Visible = false;
                });
            });
        }
    }
}
// C:/xampp/htdocs/Barroc-Intens-App/BarrocIntensApp/text.txt