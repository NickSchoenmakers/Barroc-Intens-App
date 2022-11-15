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
            this.InvoiceGridView = new System.Windows.Forms.DataGridView();
            this.customInvoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TotalPriceData = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.priceProductData = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
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
            this.customInvoiceProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.roundButton2 = new BarrocIntensApp.RoundButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDepartmentPart = new System.Windows.Forms.Label();
            this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paidAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            // InvoiceGridView
            // 
            this.InvoiceGridView.AllowUserToDeleteRows = false;
            this.InvoiceGridView.AutoGenerateColumns = false;
            this.InvoiceGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.InvoiceGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InvoiceGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.paidAtDataGridViewTextBoxColumn,
            this.companyDataGridViewTextBoxColumn});
            this.InvoiceGridView.DataSource = this.customInvoiceBindingSource;
            this.InvoiceGridView.Location = new System.Drawing.Point(163, 58);
            this.InvoiceGridView.Name = "InvoiceGridView";
            this.InvoiceGridView.ReadOnly = true;
            this.InvoiceGridView.RowHeadersVisible = false;
            this.InvoiceGridView.Size = new System.Drawing.Size(554, 260);
            this.InvoiceGridView.TabIndex = 103;
            this.InvoiceGridView.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.InvoiceGridView_RowHeaderMouseDoubleClick);
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
            this.groupBox1.Location = new System.Drawing.Point(760, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 253);
            this.groupBox1.TabIndex = 104;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Facture Info";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // TotalPriceData
            // 
            this.TotalPriceData.AutoSize = true;
            this.TotalPriceData.Location = new System.Drawing.Point(68, 136);
            this.TotalPriceData.Name = "TotalPriceData";
            this.TotalPriceData.Size = new System.Drawing.Size(23, 13);
            this.TotalPriceData.TabIndex = 13;
            this.TotalPriceData.Text = "null";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "total price:";
            // 
            // priceProductData
            // 
            this.priceProductData.AutoSize = true;
            this.priceProductData.Location = new System.Drawing.Point(45, 123);
            this.priceProductData.Name = "priceProductData";
            this.priceProductData.Size = new System.Drawing.Size(23, 13);
            this.priceProductData.TabIndex = 11;
            this.priceProductData.Text = "null";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "price:";
            // 
            // AmountData
            // 
            this.AmountData.AutoSize = true;
            this.AmountData.Location = new System.Drawing.Point(82, 110);
            this.AmountData.Name = "AmountData";
            this.AmountData.Size = new System.Drawing.Size(23, 13);
            this.AmountData.TabIndex = 9;
            this.AmountData.Text = "null";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Hoeveelheid:";
            // 
            // ProductData
            // 
            this.ProductData.AutoSize = true;
            this.ProductData.Location = new System.Drawing.Point(59, 97);
            this.ProductData.Name = "ProductData";
            this.ProductData.Size = new System.Drawing.Size(23, 13);
            this.ProductData.TabIndex = 7;
            this.ProductData.Text = "null";
            // 
            // CompanyData
            // 
            this.CompanyData.AutoSize = true;
            this.CompanyData.Location = new System.Drawing.Point(47, 16);
            this.CompanyData.Name = "CompanyData";
            this.CompanyData.Size = new System.Drawing.Size(23, 13);
            this.CompanyData.TabIndex = 6;
            this.CompanyData.Text = "null";
            // 
            // PaidData
            // 
            this.PaidData.AutoSize = true;
            this.PaidData.Location = new System.Drawing.Point(70, 71);
            this.PaidData.Name = "PaidData";
            this.PaidData.Size = new System.Drawing.Size(23, 13);
            this.PaidData.TabIndex = 5;
            this.PaidData.Text = "null";
            // 
            // DateData
            // 
            this.DateData.AutoSize = true;
            this.DateData.Location = new System.Drawing.Point(47, 43);
            this.DateData.Name = "DateData";
            this.DateData.Size = new System.Drawing.Size(23, 13);
            this.DateData.TabIndex = 4;
            this.DateData.Text = "null";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Product:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bedrijf:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Betaald op:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datum:";
            // 
            // productsDataGridview
            // 
            this.productsDataGridview.AllowUserToDeleteRows = false;
            this.productsDataGridview.AutoGenerateColumns = false;
            this.productsDataGridview.BackgroundColor = System.Drawing.SystemColors.Control;
            this.productsDataGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn});
            this.productsDataGridview.DataSource = this.customInvoiceProductBindingSource;
            this.productsDataGridview.Location = new System.Drawing.Point(163, 324);
            this.productsDataGridview.Name = "productsDataGridview";
            this.productsDataGridview.ReadOnly = true;
            this.productsDataGridview.RowHeadersVisible = false;
            this.productsDataGridview.Size = new System.Drawing.Size(459, 189);
            this.productsDataGridview.TabIndex = 105;
            this.productsDataGridview.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.productsDataGridview_RowHeaderMouseDoubleClick);
            // 
            // customInvoiceProductBindingSource
            // 
            this.customInvoiceProductBindingSource.DataSource = typeof(BarrocIntensApp.Models.CustomInvoiceProduct);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // roundButton2
            // 
            this.roundButton2.BackColor = System.Drawing.Color.Black;
            this.roundButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton2.ForeColor = System.Drawing.Color.White;
            this.roundButton2.Location = new System.Drawing.Point(12, 48);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.Size = new System.Drawing.Size(88, 50);
            this.roundButton2.TabIndex = 106;
            this.roundButton2.Text = "←";
            this.roundButton2.UseVisualStyleBackColor = false;
            this.roundButton2.Click += new System.EventHandler(this.roundButton2_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTitle.BackColor = System.Drawing.Color.Black;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTitle.Location = new System.Drawing.Point(727, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(405, 25);
            this.lblTitle.TabIndex = 107;
            this.lblTitle.Text = "Finance | Name";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDepartmentPart
            // 
            this.lblDepartmentPart.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDepartmentPart.BackColor = System.Drawing.Color.Black;
            this.lblDepartmentPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentPart.ForeColor = System.Drawing.Color.White;
            this.lblDepartmentPart.Location = new System.Drawing.Point(12, 9);
            this.lblDepartmentPart.Name = "lblDepartmentPart";
            this.lblDepartmentPart.Size = new System.Drawing.Size(405, 25);
            this.lblDepartmentPart.TabIndex = 108;
            this.lblDepartmentPart.Text = "Facturatie overzicht";
            this.lblDepartmentPart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // productDataGridViewTextBoxColumn
            // 
            this.productDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productDataGridViewTextBoxColumn.DataPropertyName = "Product";
            this.productDataGridViewTextBoxColumn.HeaderText = "Product";
            this.productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn";
            this.productDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Aantal";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paidAtDataGridViewTextBoxColumn
            // 
            this.paidAtDataGridViewTextBoxColumn.DataPropertyName = "PaidAt";
            this.paidAtDataGridViewTextBoxColumn.HeaderText = "Betaald";
            this.paidAtDataGridViewTextBoxColumn.Name = "paidAtDataGridViewTextBoxColumn";
            this.paidAtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // companyDataGridViewTextBoxColumn
            // 
            this.companyDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.companyDataGridViewTextBoxColumn.DataPropertyName = "Company";
            this.companyDataGridViewTextBoxColumn.HeaderText = "Bedrijf";
            this.companyDataGridViewTextBoxColumn.Name = "companyDataGridViewTextBoxColumn";
            this.companyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FinanceFacturatieOverzichtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 601);
            this.Controls.Add(this.lblDepartmentPart);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.roundButton2);
            this.Controls.Add(this.productsDataGridview);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.InvoiceGridView);
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

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBlack;
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
        private System.Windows.Forms.BindingSource customInvoiceBindingSource;
        private System.Windows.Forms.BindingSource customInvoiceProductBindingSource;
        private System.Windows.Forms.Label priceProductData;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label TotalPriceData;
        private System.Windows.Forms.Label label7;
        private RoundButton roundButton2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDepartmentPart;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paidAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
    }
}