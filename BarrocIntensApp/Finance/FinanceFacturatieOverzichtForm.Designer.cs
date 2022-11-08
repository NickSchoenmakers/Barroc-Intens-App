namespace BarrocIntensApp.Finance
{
    partial class FinanceFacturatieOverzichtForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pbBlack = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.InvoiceGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paidAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customInvoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AmountData = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ProductData = new System.Windows.Forms.Label();
            this.CompanyData = new System.Windows.Forms.Label();
            this.PaidData = new System.Windows.Forms.Label();
            this.DateData = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.productsDataGridview = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customInvoiceProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.priceProductData = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TotalPriceData = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customInvoiceBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customInvoiceProductBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBlack
            // 
            this.pbBlack.BackColor = System.Drawing.SystemColors.WindowText;
            this.pbBlack.Location = new System.Drawing.Point(-282, -1);
            this.pbBlack.Name = "pbBlack";
            this.pbBlack.Size = new System.Drawing.Size(1434, 43);
            this.pbBlack.TabIndex = 6;
            this.pbBlack.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Black;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(954, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(178, 25);
            this.lblTitle.TabIndex = 102;
            this.lblTitle.Text = "Factuur overzicht";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // InvoiceGridView
            // 
            this.InvoiceGridView.AllowUserToDeleteRows = false;
            this.InvoiceGridView.AutoGenerateColumns = false;
            this.InvoiceGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InvoiceGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.paidAtDataGridViewTextBoxColumn,
            this.companyIdDataGridViewTextBoxColumn,
            this.companyDataGridViewTextBoxColumn});
            this.InvoiceGridView.DataSource = this.customInvoiceBindingSource;
            this.InvoiceGridView.Location = new System.Drawing.Point(12, 48);
            this.InvoiceGridView.Name = "InvoiceGridView";
            this.InvoiceGridView.ReadOnly = true;
            this.InvoiceGridView.Size = new System.Drawing.Size(554, 260);
            this.InvoiceGridView.TabIndex = 103;
            this.InvoiceGridView.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.InvoiceGridView_RowHeaderMouseDoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paidAtDataGridViewTextBoxColumn
            // 
            this.paidAtDataGridViewTextBoxColumn.DataPropertyName = "PaidAt";
            this.paidAtDataGridViewTextBoxColumn.HeaderText = "PaidAt";
            this.paidAtDataGridViewTextBoxColumn.Name = "paidAtDataGridViewTextBoxColumn";
            this.paidAtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // companyIdDataGridViewTextBoxColumn
            // 
            this.companyIdDataGridViewTextBoxColumn.DataPropertyName = "CompanyId";
            this.companyIdDataGridViewTextBoxColumn.HeaderText = "CompanyId";
            this.companyIdDataGridViewTextBoxColumn.Name = "companyIdDataGridViewTextBoxColumn";
            this.companyIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // companyDataGridViewTextBoxColumn
            // 
            this.companyDataGridViewTextBoxColumn.DataPropertyName = "Company";
            this.companyDataGridViewTextBoxColumn.HeaderText = "Company";
            this.companyDataGridViewTextBoxColumn.Name = "companyDataGridViewTextBoxColumn";
            this.companyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customInvoiceBindingSource
            // 
            this.customInvoiceBindingSource.DataSource = typeof(BarrocIntensApp.Models.CustomInvoice);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TotalPriceData);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.priceProductData);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.AmountData);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.ProductData);
            this.groupBox1.Controls.Add(this.CompanyData);
            this.groupBox1.Controls.Add(this.PaidData);
            this.groupBox1.Controls.Add(this.DateData);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(609, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 253);
            this.groupBox1.TabIndex = 104;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Facture Info";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // AmountData
            // 
            this.AmountData.AutoSize = true;
            this.AmountData.Location = new System.Drawing.Point(94, 150);
            this.AmountData.Name = "AmountData";
            this.AmountData.Size = new System.Drawing.Size(23, 13);
            this.AmountData.TabIndex = 9;
            this.AmountData.Text = "null";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Hoeveelheid:";
            // 
            // ProductData
            // 
            this.ProductData.AutoSize = true;
            this.ProductData.Location = new System.Drawing.Point(71, 137);
            this.ProductData.Name = "ProductData";
            this.ProductData.Size = new System.Drawing.Size(23, 13);
            this.ProductData.TabIndex = 7;
            this.ProductData.Text = "null";
            // 
            // CompanyData
            // 
            this.CompanyData.AutoSize = true;
            this.CompanyData.Location = new System.Drawing.Point(59, 30);
            this.CompanyData.Name = "CompanyData";
            this.CompanyData.Size = new System.Drawing.Size(23, 13);
            this.CompanyData.TabIndex = 6;
            this.CompanyData.Text = "null";
            // 
            // PaidData
            // 
            this.PaidData.AutoSize = true;
            this.PaidData.Location = new System.Drawing.Point(82, 89);
            this.PaidData.Name = "PaidData";
            this.PaidData.Size = new System.Drawing.Size(23, 13);
            this.PaidData.TabIndex = 5;
            this.PaidData.Text = "null";
            // 
            // DateData
            // 
            this.DateData.AutoSize = true;
            this.DateData.Location = new System.Drawing.Point(59, 57);
            this.DateData.Name = "DateData";
            this.DateData.Size = new System.Drawing.Size(23, 13);
            this.DateData.TabIndex = 4;
            this.DateData.Text = "null";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Product:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bedrijf:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Betaald op:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datum:";
            // 
            // productsDataGridview
            // 
            this.productsDataGridview.AllowUserToDeleteRows = false;
            this.productsDataGridview.AutoGenerateColumns = false;
            this.productsDataGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.productIdDataGridViewTextBoxColumn,
            this.productDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn});
            this.productsDataGridview.DataSource = this.customInvoiceProductBindingSource;
            this.productsDataGridview.Location = new System.Drawing.Point(12, 314);
            this.productsDataGridview.Name = "productsDataGridview";
            this.productsDataGridview.ReadOnly = true;
            this.productsDataGridview.Size = new System.Drawing.Size(459, 189);
            this.productsDataGridview.TabIndex = 105;
            this.productsDataGridview.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.productsDataGridview_RowHeaderMouseDoubleClick);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            this.productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            this.productIdDataGridViewTextBoxColumn.HeaderText = "ProductId";
            this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            this.productIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productDataGridViewTextBoxColumn
            // 
            this.productDataGridViewTextBoxColumn.DataPropertyName = "Product";
            this.productDataGridViewTextBoxColumn.HeaderText = "Product";
            this.productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn";
            this.productDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customInvoiceProductBindingSource
            // 
            this.customInvoiceProductBindingSource.DataSource = typeof(BarrocIntensApp.Models.CustomInvoiceProduct);
            // 
            // priceProductData
            // 
            this.priceProductData.AutoSize = true;
            this.priceProductData.Location = new System.Drawing.Point(57, 163);
            this.priceProductData.Name = "priceProductData";
            this.priceProductData.Size = new System.Drawing.Size(23, 13);
            this.priceProductData.TabIndex = 11;
            this.priceProductData.Text = "null";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "price:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // TotalPriceData
            // 
            this.TotalPriceData.AutoSize = true;
            this.TotalPriceData.Location = new System.Drawing.Point(80, 176);
            this.TotalPriceData.Name = "TotalPriceData";
            this.TotalPriceData.Size = new System.Drawing.Size(23, 13);
            this.TotalPriceData.TabIndex = 13;
            this.TotalPriceData.Text = "null";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "total price:";
            // 
            // FinanceFacturatieOverzichtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 601);
            this.Controls.Add(this.productsDataGridview);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.InvoiceGridView);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbBlack);
            this.Name = "FinanceFacturatieOverzichtForm";
            this.Text = "FinanceFacturatieOverzichtForm";
            this.Load += new System.EventHandler(this.FinanceFacturatieOverzichtForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pbBlack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customInvoiceBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customInvoiceProductBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBlack;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView InvoiceGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label ProductData;
        private System.Windows.Forms.Label CompanyData;
        private System.Windows.Forms.Label PaidData;
        private System.Windows.Forms.Label DateData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label AmountData;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView productsDataGridview;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paidAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource customInvoiceBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource customInvoiceProductBindingSource;
        private System.Windows.Forms.Label priceProductData;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label TotalPriceData;
        private System.Windows.Forms.Label label7;
    }
}