using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Messaging;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Reflection;
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
        }

        private void btnBackNotes_Click(object sender, EventArgs e)
        {
            var sales = new SalesForm();
            this.Hide();
            sales.Show(this);
        }

        private void BtnSendMail_Click(object sender, EventArgs e)
        {
            SendMailWithMailTo(
                "D279851@edu.curio.nl",
                "testing subject",
                "testing body",
                "C:/xampp/htdocs/Barroc-Intens-App/BarrocIntensApp/text.txt");
            MessageBox.Show("email sent");
        }
        public static void SendMailWithMailTo(
            string address,
            string subject,
            string body,
            string attachment)
        {
            //Don't use this - just an example
            string mailto =
                string.Format(
                    "mailto:{0}?Subject={1}&Body={2}&Attachment={3}",
                    address, subject, body, attachment);
            System.Diagnostics.Process.Start(mailto);
        }
    }
}
// C:/xampp/htdocs/Barroc-Intens-App/BarrocIntensApp/text.txt