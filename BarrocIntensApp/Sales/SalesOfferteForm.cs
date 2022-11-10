using Aspose.Pdf;
using Aspose.Pdf.Text;
using BarrocIntensApp.Models;
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
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Xml.Linq;
using static BarrocIntensApp.LoginForm;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Color = Aspose.Pdf.Color;
using HorizontalAlignment = Aspose.Pdf.HorizontalAlignment;
using Rectangle = Aspose.Pdf.Rectangle;

namespace BarrocIntensApp
{
    public partial class SalesOfferteForm : Form
    {
        string fileLocation;
        Product selectedProduct;
        decimal total = 0;
        List<decimal> prodAmounts = new List<decimal>();
        int i = 0;
        public SalesOfferteForm()
        {
            InitializeComponent();

            // C:\Users\Username:
            string userRoot = System.Environment.GetEnvironmentVariable("USERPROFILE");
            // C:\Users\Username\Downloads:
            fileLocation = Path.Combine(userRoot, "Downloads");
            lbFolder.Text = fileLocation;

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

        private void BtnSendMail_Click_1(object sender, EventArgs e)
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
                Aspose.Pdf.Page page = document.Pages.Add();
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

                // Add description
                var descriptionText = $"{txbFirstName.Text} {txbLastName.Text}";
                var description = new TextFragment(descriptionText);
                description.TextState.Font = FontRepository.FindFont("Times New Roman");
                description.TextState.FontSize = 14;
                description.Margin = new MarginInfo(0, 50, 0, 50);
                page.Paragraphs.Add(description);


                // Add table
                var table = new Aspose.Pdf.Table
                {
                    ColumnWidths = "150",
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
                headerRow.Cells.Add("Aantal");
                headerRow.Cells.Add("Product");
                headerRow.Cells.Add("Prijs");
                foreach (Cell headerRowCell in headerRow.Cells)
                {
                    headerRowCell.BackgroundColor = Color.Gray;
                    headerRowCell.DefaultCellTextState.ForegroundColor = Color.WhiteSmoke;
                }

                foreach(var addedProduct in addedProducts)
                {
                    var price = Math.Round(addedProduct.Price, 2);
                    var dataRow = table.Rows.Add();
                    dataRow.Cells.Add(Convert.ToString(prodAmounts[i]));
                    dataRow.Cells.Add(addedProduct.Name);
                    dataRow.Cells.Add(" \u20AC" + Convert.ToString(price));
                    price = price * prodAmounts[i];
                    total += price;
                    i++;
                }

                page.Paragraphs.Add(table);

                var totalPrice = new TextFragment("Totaal:  \u20AC" + total);
                totalPrice.HorizontalAlignment = HorizontalAlignment.Right;
                page.Paragraphs.Add(totalPrice);

                // Save updated PDF
                var outputFileName = System.IO.Path.Combine(fileLocation, "Offerte.pdf");
                document.Save(outputFileName);

                Process.Start(outputFileName);

                this.Invoke((MethodInvoker)delegate {
                    this.Enabled = true;
                    pbLoad.Visible = false;
                });
            });
        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            DialogResult location = folderBrowserDialog1.ShowDialog();
            if (location == DialogResult.OK)
            {
                fileLocation = folderBrowserDialog1.SelectedPath;
                lbFolder.Text = fileLocation;
            }
        }
        List<Product> addedProducts = new List<Product>();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            selectedProduct = (Product)this.dgvProducts.CurrentRow?.DataBoundItem;

            prodAmounts.Add(nudAmount.Value);
            
            addedProducts.Add(selectedProduct);

            dgvAdded.DataSource = new BindingList<Product>(addedProducts);

            dgvAdded.Refresh();
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            var LoginForm = new LoginForm();
            this.Hide();
            LoginForm.Show(this);
        }
    }
}