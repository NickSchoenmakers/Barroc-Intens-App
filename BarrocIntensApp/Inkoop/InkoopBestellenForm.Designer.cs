namespace BarrocIntensApp.Inkoop
{
    partial class InkoopBestellenForm
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
            this.lblDepartmentPart = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbBlack = new System.Windows.Forms.PictureBox();
            this.lblProductCategories = new System.Windows.Forms.Label();
            this.cbCategories = new System.Windows.Forms.ComboBox();
            this.productCategoryBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblStock = new System.Windows.Forms.Label();
            this.groupProductInfo = new System.Windows.Forms.GroupBox();
            this.nrAmount = new System.Windows.Forms.NumericUpDown();
            this.lbAmount = new System.Windows.Forms.Label();
            this.lbPermission = new System.Windows.Forms.Label();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.groupAddProduct = new System.Windows.Forms.GroupBox();
            this.cbLeasable = new System.Windows.Forms.CheckBox();
            this.numProductPrice = new System.Windows.Forms.NumericUpDown();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.checkPart = new System.Windows.Forms.CheckBox();
            this.cbProductCategory = new System.Windows.Forms.ComboBox();
            this.productCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbProductDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbProductName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roundButton1 = new BarrocIntensApp.RoundButton();
            this.btnReturnDashboard = new BarrocIntensApp.RoundButton();
            this.productCategoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hasArrivedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.groupProductInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrAmount)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupAddProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numProductPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDepartmentPart
            // 
            this.lblDepartmentPart.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDepartmentPart.BackColor = System.Drawing.Color.Black;
            this.lblDepartmentPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentPart.ForeColor = System.Drawing.Color.White;
            this.lblDepartmentPart.Location = new System.Drawing.Point(12, 10);
            this.lblDepartmentPart.Name = "lblDepartmentPart";
            this.lblDepartmentPart.Size = new System.Drawing.Size(405, 25);
            this.lblDepartmentPart.TabIndex = 38;
            this.lblDepartmentPart.Text = "Bestellen";
            this.lblDepartmentPart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTitle.BackColor = System.Drawing.Color.Black;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTitle.Location = new System.Drawing.Point(727, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(405, 25);
            this.lblTitle.TabIndex = 37;
            this.lblTitle.Text = "Inkoop | Name";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pbBlack
            // 
            this.pbBlack.BackColor = System.Drawing.SystemColors.WindowText;
            this.pbBlack.Location = new System.Drawing.Point(0, 0);
            this.pbBlack.Name = "pbBlack";
            this.pbBlack.Size = new System.Drawing.Size(1144, 43);
            this.pbBlack.TabIndex = 36;
            this.pbBlack.TabStop = false;
            // 
            // lblProductCategories
            // 
            this.lblProductCategories.AutoSize = true;
            this.lblProductCategories.Location = new System.Drawing.Point(18, 129);
            this.lblProductCategories.Name = "lblProductCategories";
            this.lblProductCategories.Size = new System.Drawing.Size(52, 13);
            this.lblProductCategories.TabIndex = 41;
            this.lblProductCategories.Text = "Categorie";
            // 
            // cbCategories
            // 
            this.cbCategories.DataSource = this.productCategoryBindingSource2;
            this.cbCategories.DisplayMember = "Name";
            this.cbCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategories.FormattingEnabled = true;
            this.cbCategories.Location = new System.Drawing.Point(20, 145);
            this.cbCategories.Name = "cbCategories";
            this.cbCategories.Size = new System.Drawing.Size(173, 21);
            this.cbCategories.TabIndex = 42;
            this.cbCategories.ValueMember = "Id";
            this.cbCategories.SelectedIndexChanged += new System.EventHandler(this.cbCategories_SelectedIndexChanged);
            // 
            // productCategoryBindingSource2
            // 
            this.productCategoryBindingSource2.DataSource = typeof(BarrocIntensApp.Models.ProductCategory);
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AllowUserToResizeColumns = false;
            this.dgvProducts.AllowUserToResizeRows = false;
            this.dgvProducts.AutoGenerateColumns = false;
            this.dgvProducts.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.ColumnHeadersVisible = false;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn});
            this.dgvProducts.DataSource = this.productBindingSource;
            this.dgvProducts.GridColor = System.Drawing.SystemColors.Control;
            this.dgvProducts.Location = new System.Drawing.Point(1, 13);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProducts.Size = new System.Drawing.Size(339, 378);
            this.dgvProducts.TabIndex = 44;
            this.dgvProducts.SelectionChanged += new System.EventHandler(this.dgvProducts_SelectionChanged);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(BarrocIntensApp.Models.Product);
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStock.Location = new System.Drawing.Point(3, 16);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(97, 13);
            this.lblStock.TabIndex = 47;
            this.lblStock.Text = "Aantal op voorraad";
            // 
            // groupProductInfo
            // 
            this.groupProductInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupProductInfo.Controls.Add(this.nrAmount);
            this.groupProductInfo.Controls.Add(this.lbAmount);
            this.groupProductInfo.Controls.Add(this.lbPermission);
            this.groupProductInfo.Controls.Add(this.btnDeleteProduct);
            this.groupProductInfo.Controls.Add(this.lblPrice);
            this.groupProductInfo.Controls.Add(this.btnOrder);
            this.groupProductInfo.Controls.Add(this.lblStock);
            this.groupProductInfo.Location = new System.Drawing.Point(732, 219);
            this.groupProductInfo.Name = "groupProductInfo";
            this.groupProductInfo.Size = new System.Drawing.Size(400, 370);
            this.groupProductInfo.TabIndex = 48;
            this.groupProductInfo.TabStop = false;
            this.groupProductInfo.Text = "Product info";
            // 
            // nrAmount
            // 
            this.nrAmount.Location = new System.Drawing.Point(197, 339);
            this.nrAmount.Name = "nrAmount";
            this.nrAmount.Size = new System.Drawing.Size(77, 20);
            this.nrAmount.TabIndex = 54;
            // 
            // lbAmount
            // 
            this.lbAmount.AutoSize = true;
            this.lbAmount.Location = new System.Drawing.Point(118, 347);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(37, 13);
            this.lbAmount.TabIndex = 53;
            this.lbAmount.Text = "Aantal";
            // 
            // lbPermission
            // 
            this.lbPermission.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPermission.AutoSize = true;
            this.lbPermission.Location = new System.Drawing.Point(118, 59);
            this.lbPermission.Name = "lbPermission";
            this.lbPermission.Size = new System.Drawing.Size(0, 13);
            this.lbPermission.TabIndex = 51;
            this.lbPermission.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(281, 294);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(113, 32);
            this.btnDeleteProduct.TabIndex = 50;
            this.btnDeleteProduct.Text = "Product verwijderen";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPrice.Location = new System.Drawing.Point(3, 29);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(26, 13);
            this.lblPrice.TabIndex = 49;
            this.lblPrice.Text = "Prijs";
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(281, 332);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(113, 32);
            this.btnOrder.TabIndex = 48;
            this.btnOrder.Text = "Bestellen";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnAddStock_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStatus.Location = new System.Drawing.Point(3, 42);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(26, 13);
            this.lblStatus.TabIndex = 54;
            this.lblStatus.Text = "Prijs";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvProducts);
            this.groupBox2.Location = new System.Drawing.Point(20, 219);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 379);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Producten";
            // 
            // cbFilter
            // 
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "Alles",
            "Op voorraad",
            "Niet op vooraad"});
            this.cbFilter.Location = new System.Drawing.Point(201, 189);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(173, 21);
            this.cbFilter.TabIndex = 50;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "Filter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Zoeken";
            // 
            // tbxSearch
            // 
            this.tbxSearch.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbxSearch.Location = new System.Drawing.Point(20, 190);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(173, 20);
            this.tbxSearch.TabIndex = 53;
            this.tbxSearch.Text = "Typ hier om te zoeken..";
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            this.tbxSearch.Enter += new System.EventHandler(this.tbxSearch_Enter);
            this.tbxSearch.Leave += new System.EventHandler(this.tbxSearch_Leave);
            // 
            // groupAddProduct
            // 
            this.groupAddProduct.Controls.Add(this.cbLeasable);
            this.groupAddProduct.Controls.Add(this.numProductPrice);
            this.groupAddProduct.Controls.Add(this.btnAddProduct);
            this.groupAddProduct.Controls.Add(this.checkPart);
            this.groupAddProduct.Controls.Add(this.cbProductCategory);
            this.groupAddProduct.Controls.Add(this.label6);
            this.groupAddProduct.Controls.Add(this.label5);
            this.groupAddProduct.Controls.Add(this.txbProductDescription);
            this.groupAddProduct.Controls.Add(this.label4);
            this.groupAddProduct.Controls.Add(this.txbProductName);
            this.groupAddProduct.Controls.Add(this.label3);
            this.groupAddProduct.Location = new System.Drawing.Point(732, 50);
            this.groupAddProduct.Name = "groupAddProduct";
            this.groupAddProduct.Size = new System.Drawing.Size(400, 160);
            this.groupAddProduct.TabIndex = 54;
            this.groupAddProduct.TabStop = false;
            this.groupAddProduct.Text = "Product aanmaken";
            // 
            // cbLeasable
            // 
            this.cbLeasable.AutoSize = true;
            this.cbLeasable.Location = new System.Drawing.Point(174, 79);
            this.cbLeasable.Name = "cbLeasable";
            this.cbLeasable.Size = new System.Drawing.Size(79, 17);
            this.cbLeasable.TabIndex = 59;
            this.cbLeasable.Text = "Kan leasen";
            this.cbLeasable.UseVisualStyleBackColor = true;
            // 
            // numProductPrice
            // 
            this.numProductPrice.DecimalPlaces = 2;
            this.numProductPrice.Location = new System.Drawing.Point(12, 123);
            this.numProductPrice.Name = "numProductPrice";
            this.numProductPrice.Size = new System.Drawing.Size(58, 20);
            this.numProductPrice.TabIndex = 58;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(273, 122);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(113, 32);
            this.btnAddProduct.TabIndex = 51;
            this.btnAddProduct.Text = "Product aanmaken";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // checkPart
            // 
            this.checkPart.AutoSize = true;
            this.checkPart.Location = new System.Drawing.Point(311, 33);
            this.checkPart.Name = "checkPart";
            this.checkPart.Size = new System.Drawing.Size(75, 17);
            this.checkPart.TabIndex = 57;
            this.checkPart.Text = "Onderdeel";
            this.checkPart.UseVisualStyleBackColor = true;
            // 
            // cbProductCategory
            // 
            this.cbProductCategory.DataSource = this.productCategoryBindingSource;
            this.cbProductCategory.DisplayMember = "Name";
            this.cbProductCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProductCategory.FormattingEnabled = true;
            this.cbProductCategory.Location = new System.Drawing.Point(174, 31);
            this.cbProductCategory.Name = "cbProductCategory";
            this.cbProductCategory.Size = new System.Drawing.Size(131, 21);
            this.cbProductCategory.TabIndex = 55;
            this.cbProductCategory.ValueMember = "Id";
            this.cbProductCategory.SelectedValueChanged += new System.EventHandler(this.cbProductCategory_SelectedValueChanged);
            // 
            // productCategoryBindingSource
            // 
            this.productCategoryBindingSource.DataSource = typeof(BarrocIntensApp.Models.ProductCategory);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(174, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Categorie";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Prijs";
            // 
            // txbProductDescription
            // 
            this.txbProductDescription.Location = new System.Drawing.Point(9, 79);
            this.txbProductDescription.Name = "txbProductDescription";
            this.txbProductDescription.Size = new System.Drawing.Size(143, 20);
            this.txbProductDescription.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Beschrijving";
            // 
            // txbProductName
            // 
            this.txbProductName.Location = new System.Drawing.Point(9, 32);
            this.txbProductName.Name = "txbProductName";
            this.txbProductName.Size = new System.Drawing.Size(143, 20);
            this.txbProductName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Naam";
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.AutoGenerateColumns = false;
            this.dgvOrders.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.hasArrivedDataGridViewCheckBoxColumn});
            this.dgvOrders.DataSource = this.orderBindingSource;
            this.dgvOrders.Location = new System.Drawing.Point(380, 219);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.RowHeadersVisible = false;
            this.dgvOrders.Size = new System.Drawing.Size(349, 370);
            this.dgvOrders.TabIndex = 56;
            this.dgvOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrders_CellContentClick);
            this.dgvOrders.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrders_CellEndEdit);
            this.dgvOrders.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvOrders_CellFormatting);
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(BarrocIntensApp.Models.Order);
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.roundButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.roundButton1.Location = new System.Drawing.Point(384, 50);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(168, 70);
            this.roundButton1.TabIndex = 55;
            this.roundButton1.Text = "Logout";
            this.roundButton1.UseVisualStyleBackColor = false;
            this.roundButton1.Click += new System.EventHandler(this.roundButton1_Click);
            // 
            // btnReturnDashboard
            // 
            this.btnReturnDashboard.BackColor = System.Drawing.Color.Black;
            this.btnReturnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnReturnDashboard.Location = new System.Drawing.Point(12, 49);
            this.btnReturnDashboard.Name = "btnReturnDashboard";
            this.btnReturnDashboard.Size = new System.Drawing.Size(88, 50);
            this.btnReturnDashboard.TabIndex = 39;
            this.btnReturnDashboard.Text = "←";
            this.btnReturnDashboard.UseVisualStyleBackColor = false;
            this.btnReturnDashboard.Click += new System.EventHandler(this.btnReturnDashboard_Click);
            // 
            // productCategoryBindingSource1
            // 
            this.productCategoryBindingSource1.DataSource = typeof(BarrocIntensApp.Models.ProductCategory);
            // 
            // productDataGridViewTextBoxColumn
            // 
            this.productDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productDataGridViewTextBoxColumn.DataPropertyName = "Product";
            this.productDataGridViewTextBoxColumn.HeaderText = "Product";
            this.productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.Width = 62;
            // 
            // hasArrivedDataGridViewCheckBoxColumn
            // 
            this.hasArrivedDataGridViewCheckBoxColumn.DataPropertyName = "hasArrived";
            this.hasArrivedDataGridViewCheckBoxColumn.HeaderText = "hasArrived";
            this.hasArrivedDataGridViewCheckBoxColumn.Name = "hasArrivedDataGridViewCheckBoxColumn";
            this.hasArrivedDataGridViewCheckBoxColumn.Width = 60;
            // 
            // InkoopBestellenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1144, 601);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.roundButton1);
            this.Controls.Add(this.groupAddProduct);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupProductInfo);
            this.Controls.Add(this.cbCategories);
            this.Controls.Add(this.lblProductCategories);
            this.Controls.Add(this.btnReturnDashboard);
            this.Controls.Add(this.lblDepartmentPart);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbBlack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "InkoopBestellenForm";
            this.Text = "Bestellen";
            this.Load += new System.EventHandler(this.InkoopBestellenForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBlack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.groupProductInfo.ResumeLayout(false);
            this.groupProductInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrAmount)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupAddProduct.ResumeLayout(false);
            this.groupAddProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numProductPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDepartmentPart;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbBlack;
        private RoundButton btnReturnDashboard;
        private System.Windows.Forms.Label lblProductCategories;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingSource productCategoryBindingSource;
        private System.Windows.Forms.ComboBox cbCategories;
        private System.Windows.Forms.BindingSource productCategoryBindingSource1;
        private System.Windows.Forms.BindingSource productCategoryBindingSource2;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.GroupBox groupProductInfo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.GroupBox groupAddProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.CheckBox checkPart;
        private System.Windows.Forms.ComboBox cbProductCategory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbProductDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbProductName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numProductPrice;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.Label lbPermission;
        private RoundButton roundButton1;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.CheckBox cbLeasable;
        private System.Windows.Forms.NumericUpDown nrAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn hasArrivedDataGridViewCheckBoxColumn;
    }
}