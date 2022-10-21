namespace BarrocIntensApp
{
    partial class FacturatieForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacturatieForm));
            this.pbBlack = new System.Windows.Forms.PictureBox();
            this.NameLbl = new System.Windows.Forms.Label();
            this.Street_numberLbl = new System.Windows.Forms.Label();
            this.ZipcodeLbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AmountNu = new System.Windows.Forms.NumericUpDown();
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.InvoiceProductsdgv = new System.Windows.Forms.DataGridView();
            this.customInvoiceProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Cartbtn = new BarrocIntensApp.RoundButton();
            this.BtnReturnStoringen = new BarrocIntensApp.RoundButton();
            this.NameCb = new System.Windows.Forms.ComboBox();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Streetlbl = new System.Windows.Forms.Label();
            this.Houselbl = new System.Windows.Forms.Label();
            this.citylbl = new System.Windows.Forms.Label();
            this.ziplbl = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountNu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceProductsdgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customInvoiceProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBlack
            // 
            this.pbBlack.BackColor = System.Drawing.SystemColors.WindowText;
            this.pbBlack.Location = new System.Drawing.Point(-289, 0);
            this.pbBlack.Name = "pbBlack";
            this.pbBlack.Size = new System.Drawing.Size(1434, 43);
            this.pbBlack.TabIndex = 5;
            this.pbBlack.TabStop = false;
            this.pbBlack.Click += new System.EventHandler(this.pbBlack_Click);
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(90, 95);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(35, 13);
            this.NameLbl.TabIndex = 15;
            this.NameLbl.Text = "Naam";
            this.NameLbl.Click += new System.EventHandler(this.NameLbl_Click);
            // 
            // Street_numberLbl
            // 
            this.Street_numberLbl.AutoSize = true;
            this.Street_numberLbl.Location = new System.Drawing.Point(90, 121);
            this.Street_numberLbl.Name = "Street_numberLbl";
            this.Street_numberLbl.Size = new System.Drawing.Size(35, 13);
            this.Street_numberLbl.TabIndex = 16;
            this.Street_numberLbl.Text = "Straat";
            // 
            // ZipcodeLbl
            // 
            this.ZipcodeLbl.AutoSize = true;
            this.ZipcodeLbl.Location = new System.Drawing.Point(73, 199);
            this.ZipcodeLbl.Name = "ZipcodeLbl";
            this.ZipcodeLbl.Size = new System.Drawing.Size(52, 13);
            this.ZipcodeLbl.TabIndex = 17;
            this.ZipcodeLbl.Text = "Postcode";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(81, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Product";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Huis nummer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Stad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Hoeveelheid";
            // 
            // AmountNu
            // 
            this.AmountNu.Location = new System.Drawing.Point(132, 378);
            this.AmountNu.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.AmountNu.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AmountNu.Name = "AmountNu";
            this.AmountNu.Size = new System.Drawing.Size(50, 20);
            this.AmountNu.TabIndex = 30;
            this.AmountNu.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AmountNu.ValueChanged += new System.EventHandler(this.AmountNu_ValueChanged);
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.AutoGenerateColumns = false;
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.productsDataGridView.DataSource = this.productBindingSource;
            this.productsDataGridView.Location = new System.Drawing.Point(131, 222);
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productsDataGridView.Size = new System.Drawing.Size(345, 150);
            this.productsDataGridView.TabIndex = 33;
            this.productsDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.productsDataGridView_RowHeaderMouseClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(BarrocIntensApp.Models.Product);
            // 
            // InvoiceProductsdgv
            // 
            this.InvoiceProductsdgv.AutoGenerateColumns = false;
            this.InvoiceProductsdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InvoiceProductsdgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.Product});
            this.InvoiceProductsdgv.DataSource = this.customInvoiceProductBindingSource;
            this.InvoiceProductsdgv.Location = new System.Drawing.Point(611, 75);
            this.InvoiceProductsdgv.Name = "InvoiceProductsdgv";
            this.InvoiceProductsdgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.InvoiceProductsdgv.Size = new System.Drawing.Size(534, 272);
            this.InvoiceProductsdgv.TabIndex = 36;
            this.InvoiceProductsdgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CartGv_CellContentClick);
            this.InvoiceProductsdgv.SelectionChanged += new System.EventHandler(this.InvoiceProductsdgv_SelectionChanged);
            // 
            // customInvoiceProductBindingSource
            // 
            this.customInvoiceProductBindingSource.DataSource = typeof(BarrocIntensApp.Models.CustomInvoiceProduct);
            // 
            // Cartbtn
            // 
            this.Cartbtn.BackColor = System.Drawing.Color.Black;
            this.Cartbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cartbtn.ForeColor = System.Drawing.Color.White;
            this.Cartbtn.Location = new System.Drawing.Point(388, 384);
            this.Cartbtn.Name = "Cartbtn";
            this.Cartbtn.Size = new System.Drawing.Size(88, 50);
            this.Cartbtn.TabIndex = 34;
            this.Cartbtn.Text = "add to cart";
            this.Cartbtn.UseVisualStyleBackColor = false;
            this.Cartbtn.Click += new System.EventHandler(this.Cartbtn_Click);
            // 
            // BtnReturnStoringen
            // 
            this.BtnReturnStoringen.BackColor = System.Drawing.Color.Black;
            this.BtnReturnStoringen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReturnStoringen.ForeColor = System.Drawing.Color.White;
            this.BtnReturnStoringen.Location = new System.Drawing.Point(1044, 539);
            this.BtnReturnStoringen.Name = "BtnReturnStoringen";
            this.BtnReturnStoringen.Size = new System.Drawing.Size(88, 50);
            this.BtnReturnStoringen.TabIndex = 32;
            this.BtnReturnStoringen.Text = "Bestel";
            this.BtnReturnStoringen.UseVisualStyleBackColor = false;
            // 
            // NameCb
            // 
            this.NameCb.DataSource = this.companyBindingSource;
            this.NameCb.DisplayMember = "Name";
            this.NameCb.FormattingEnabled = true;
            this.NameCb.Location = new System.Drawing.Point(132, 95);
            this.NameCb.Name = "NameCb";
            this.NameCb.Size = new System.Drawing.Size(170, 21);
            this.NameCb.TabIndex = 37;
            this.NameCb.ValueMember = "Id";
            this.NameCb.SelectedValueChanged += new System.EventHandler(this.NameCb_SelectedValueChanged);
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataSource = typeof(BarrocIntensApp.Models.Company);
            // 
            // Streetlbl
            // 
            this.Streetlbl.AutoSize = true;
            this.Streetlbl.Location = new System.Drawing.Point(132, 123);
            this.Streetlbl.Name = "Streetlbl";
            this.Streetlbl.Size = new System.Drawing.Size(35, 13);
            this.Streetlbl.TabIndex = 38;
            this.Streetlbl.Text = "label4";
            // 
            // Houselbl
            // 
            this.Houselbl.AutoSize = true;
            this.Houselbl.Location = new System.Drawing.Point(132, 147);
            this.Houselbl.Name = "Houselbl";
            this.Houselbl.Size = new System.Drawing.Size(35, 13);
            this.Houselbl.TabIndex = 39;
            this.Houselbl.Text = "label5";
            // 
            // citylbl
            // 
            this.citylbl.AutoSize = true;
            this.citylbl.Location = new System.Drawing.Point(132, 173);
            this.citylbl.Name = "citylbl";
            this.citylbl.Size = new System.Drawing.Size(35, 13);
            this.citylbl.TabIndex = 40;
            this.citylbl.Text = "label6";
            // 
            // ziplbl
            // 
            this.ziplbl.AutoSize = true;
            this.ziplbl.Location = new System.Drawing.Point(132, 199);
            this.ziplbl.Name = "ziplbl";
            this.ziplbl.Size = new System.Drawing.Size(35, 13);
            this.ziplbl.TabIndex = 41;
            this.ziplbl.Text = "label7";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(608, 359);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(35, 13);
            this.lblPrice.TabIndex = 42;
            this.lblPrice.Text = "label4";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // Product
            // 
            this.Product.DataPropertyName = "Product";
            this.Product.HeaderText = "Product";
            this.Product.MinimumWidth = 50;
            this.Product.Name = "Product";
            this.Product.Width = 500;
            // 
            // FacturatieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 601);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.ziplbl);
            this.Controls.Add(this.citylbl);
            this.Controls.Add(this.Houselbl);
            this.Controls.Add(this.Streetlbl);
            this.Controls.Add(this.NameCb);
            this.Controls.Add(this.InvoiceProductsdgv);
            this.Controls.Add(this.Cartbtn);
            this.Controls.Add(this.productsDataGridView);
            this.Controls.Add(this.BtnReturnStoringen);
            this.Controls.Add(this.AmountNu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ZipcodeLbl);
            this.Controls.Add(this.Street_numberLbl);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.pbBlack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FacturatieForm";
            this.Text = "Facturatie_Form";
            this.Load += new System.EventHandler(this.FacturatieForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBlack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountNu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceProductsdgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customInvoiceProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbBlack;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label Street_numberLbl;
        private System.Windows.Forms.Label ZipcodeLbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown AmountNu;
        private RoundButton BtnReturnStoringen;
        private System.Windows.Forms.DataGridView productsDataGridView;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private RoundButton Cartbtn;
        private System.Windows.Forms.DataGridView InvoiceProductsdgv;
        private System.Windows.Forms.ComboBox NameCb;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private System.Windows.Forms.Label Streetlbl;
        private System.Windows.Forms.Label Houselbl;
        private System.Windows.Forms.Label citylbl;
        private System.Windows.Forms.Label ziplbl;
        private System.Windows.Forms.BindingSource customInvoiceProductBindingSource;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
    }
}