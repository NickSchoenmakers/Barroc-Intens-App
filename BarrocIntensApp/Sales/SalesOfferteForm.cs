using Aspose.Pdf;
using Aspose.Pdf.Text;
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
using static System.Net.Mime.MediaTypeNames;
using Color = Aspose.Pdf.Color;
using HorizontalAlignment = Aspose.Pdf.HorizontalAlignment;
using Rectangle = Aspose.Pdf.Rectangle;

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
            this.pbLoad.Style = ProgressBarStyle.Marquee;
            pbLoad.Visible = true;
            pbLoad.BringToFront();

            Task.Run(() =>
            {
                // Initialize document object
                Document document = new Document();
                // Add page
                Page page = document.Pages.Add();
                // Add image
                var imageFileName = System.IO.Path.Combine("../../Image", "Logo6_groot.png");
                page.AddImage(imageFileName, new Rectangle(20, 730, 120, 830));
                // Add Header
                var header = new TextFragment("Offerte");
                header.TextState.Font = FontRepository.FindFont("Arial");
                header.TextState.FontSize = 24;
                header.HorizontalAlignment = HorizontalAlignment.Center;
                header.Position = new Position(100, 700);
                page.Paragraphs.Add(header);

                //Aspose.Pdf.Rectangle rect = new Aspose.Pdf.Rectangle(100, 200, 300, 300);
                //Aspose.Pdf.Forms.TextBoxField textBox = new Aspose.Pdf.Forms.TextBoxField(document.Pages[1], rect);
                //textBox.Name = "textbox1";
                //textBox.Multiline = true;
                //textBox.Value = "jemoeder\nok";
                //document.Form.Add(textBox, 1);

                // Add description
                var descriptionText = $"{txbFirstName.Text} {txbLastName.Text}";
                var description = new TextFragment(descriptionText);
                description.TextState.Font = FontRepository.FindFont("Times New Roman");
                description.TextState.FontSize = 14;
                description.Margin = new MarginInfo(0, 50, 0, 50);
                page.Paragraphs.Add(description);


                // Add table
                var table = new Table
                {
                    ColumnWidths = "200",
                    Border = new BorderInfo(BorderSide.Box, 1f, Color.DarkSlateGray),
                    DefaultCellBorder = new BorderInfo(BorderSide.Box, 0.5f, Color.Black),
                    DefaultCellPadding = new MarginInfo(4.5, 4.5, 4.5, 4.5),
                    Margin =
                {
                    Bottom = 10
                },
                    DefaultCellTextState =
                {
                    Font =  FontRepository.FindFont("Helvetica")
                }
                };

                var headerRow = table.Rows.Add();
                headerRow.Cells.Add("Product");
                headerRow.Cells.Add("Prijs");
                foreach (Cell headerRowCell in headerRow.Cells)
                {
                    headerRowCell.BackgroundColor = Color.Gray;
                    headerRowCell.DefaultCellTextState.ForegroundColor = Color.WhiteSmoke;
                }

                var dataRow = table.Rows.Add();
                dataRow.Cells.Add("test1");
                dataRow.Cells.Add("test2");

                page.Paragraphs.Add(table);
                // Save updated PDF
                var outputFileName = System.IO.Path.Combine("Offerte.pdf");
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