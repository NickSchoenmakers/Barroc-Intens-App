namespace BarrocIntensApp.Finance
{
    partial class FinanceLeaseForm
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
            this.btnBack = new BarrocIntensApp.RoundButton();
            this.lblDepartmentPart = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbBlack = new System.Windows.Forms.PictureBox();
            this.btnLogout = new BarrocIntensApp.RoundButton();
            this.groupLeaseContractInfo = new System.Windows.Forms.GroupBox();
            this.lblLeaseInfoProduct = new System.Windows.Forms.Label();
            this.lblLeaseInfoCompany = new System.Windows.Forms.Label();
            this.lblMonthlyPeriodically = new System.Windows.Forms.Label();
            this.lblLeaseInfoPriceMonth = new System.Windows.Forms.Label();
            this.lblLeaseInfoPeriods = new System.Windows.Forms.Label();
            this.lblLeaseInfoStartDate = new System.Windows.Forms.Label();
            this.btnDeleteLeaseContract = new System.Windows.Forms.Button();
            this.groupCreateLeaseContract = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numPeriods = new System.Windows.Forms.NumericUpDown();
            this.lblMonthly = new System.Windows.Forms.Label();
            this.cbxMonthlyPeriodically = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxLeaseContractProduct = new System.Windows.Forms.ComboBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtLeaseContractStartDate = new System.Windows.Forms.DateTimePicker();
            this.btnCreateLeaseContract = new System.Windows.Forms.Button();
            this.cbxLeaseContractCompany = new System.Windows.Forms.ComboBox();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupLeaseContracts = new System.Windows.Forms.GroupBox();
            this.dgvLeaseContracts = new System.Windows.Forms.DataGridView();
            this.companyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leaseContractBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSaveEdit = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlack)).BeginInit();
            this.groupLeaseContractInfo.SuspendLayout();
            this.groupCreateLeaseContract.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPeriods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            this.groupLeaseContracts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaseContracts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaseContractBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Black;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(15, 49);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(88, 50);
            this.btnBack.TabIndex = 48;
            this.btnBack.Text = "←";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblDepartmentPart
            // 
            this.lblDepartmentPart.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDepartmentPart.BackColor = System.Drawing.Color.Black;
            this.lblDepartmentPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentPart.ForeColor = System.Drawing.Color.White;
            this.lblDepartmentPart.Location = new System.Drawing.Point(10, 10);
            this.lblDepartmentPart.Name = "lblDepartmentPart";
            this.lblDepartmentPart.Size = new System.Drawing.Size(405, 25);
            this.lblDepartmentPart.TabIndex = 47;
            this.lblDepartmentPart.Text = "Leasecontracten";
            this.lblDepartmentPart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTitle.BackColor = System.Drawing.Color.Black;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTitle.Location = new System.Drawing.Point(725, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(405, 25);
            this.lblTitle.TabIndex = 46;
            this.lblTitle.Text = "Finance | Name";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pbBlack
            // 
            this.pbBlack.BackColor = System.Drawing.SystemColors.WindowText;
            this.pbBlack.Location = new System.Drawing.Point(-291, 0);
            this.pbBlack.Name = "pbBlack";
            this.pbBlack.Size = new System.Drawing.Size(1435, 43);
            this.pbBlack.TabIndex = 45;
            this.pbBlack.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.Location = new System.Drawing.Point(384, 45);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(168, 70);
            this.btnLogout.TabIndex = 85;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // groupLeaseContractInfo
            // 
            this.groupLeaseContractInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupLeaseContractInfo.Controls.Add(this.btnEdit);
            this.groupLeaseContractInfo.Controls.Add(this.lblLeaseInfoProduct);
            this.groupLeaseContractInfo.Controls.Add(this.lblLeaseInfoCompany);
            this.groupLeaseContractInfo.Controls.Add(this.lblMonthlyPeriodically);
            this.groupLeaseContractInfo.Controls.Add(this.lblLeaseInfoPriceMonth);
            this.groupLeaseContractInfo.Controls.Add(this.lblLeaseInfoPeriods);
            this.groupLeaseContractInfo.Controls.Add(this.lblLeaseInfoStartDate);
            this.groupLeaseContractInfo.Controls.Add(this.btnDeleteLeaseContract);
            this.groupLeaseContractInfo.Location = new System.Drawing.Point(558, 220);
            this.groupLeaseContractInfo.Name = "groupLeaseContractInfo";
            this.groupLeaseContractInfo.Size = new System.Drawing.Size(574, 370);
            this.groupLeaseContractInfo.TabIndex = 80;
            this.groupLeaseContractInfo.TabStop = false;
            this.groupLeaseContractInfo.Text = "Leasecontract info";
            // 
            // lblLeaseInfoProduct
            // 
            this.lblLeaseInfoProduct.AutoSize = true;
            this.lblLeaseInfoProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLeaseInfoProduct.Location = new System.Drawing.Point(3, 81);
            this.lblLeaseInfoProduct.Name = "lblLeaseInfoProduct";
            this.lblLeaseInfoProduct.Size = new System.Drawing.Size(44, 13);
            this.lblLeaseInfoProduct.TabIndex = 52;
            this.lblLeaseInfoProduct.Text = "Product";
            // 
            // lblLeaseInfoCompany
            // 
            this.lblLeaseInfoCompany.AutoSize = true;
            this.lblLeaseInfoCompany.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLeaseInfoCompany.Location = new System.Drawing.Point(3, 68);
            this.lblLeaseInfoCompany.Name = "lblLeaseInfoCompany";
            this.lblLeaseInfoCompany.Size = new System.Drawing.Size(36, 13);
            this.lblLeaseInfoCompany.TabIndex = 51;
            this.lblLeaseInfoCompany.Text = "Bedrijf";
            // 
            // lblMonthlyPeriodically
            // 
            this.lblMonthlyPeriodically.AutoSize = true;
            this.lblMonthlyPeriodically.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMonthlyPeriodically.Location = new System.Drawing.Point(3, 55);
            this.lblMonthlyPeriodically.Name = "lblMonthlyPeriodically";
            this.lblMonthlyPeriodically.Size = new System.Drawing.Size(121, 13);
            this.lblMonthlyPeriodically.TabIndex = 54;
            this.lblMonthlyPeriodically.Text = "Maandelijks of periodiek";
            // 
            // lblLeaseInfoPriceMonth
            // 
            this.lblLeaseInfoPriceMonth.AutoSize = true;
            this.lblLeaseInfoPriceMonth.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLeaseInfoPriceMonth.Location = new System.Drawing.Point(3, 42);
            this.lblLeaseInfoPriceMonth.Name = "lblLeaseInfoPriceMonth";
            this.lblLeaseInfoPriceMonth.Size = new System.Drawing.Size(82, 13);
            this.lblLeaseInfoPriceMonth.TabIndex = 56;
            this.lblLeaseInfoPriceMonth.Text = "Prijs per periode";
            // 
            // lblLeaseInfoPeriods
            // 
            this.lblLeaseInfoPeriods.AutoSize = true;
            this.lblLeaseInfoPeriods.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLeaseInfoPeriods.Location = new System.Drawing.Point(3, 29);
            this.lblLeaseInfoPeriods.Name = "lblLeaseInfoPeriods";
            this.lblLeaseInfoPeriods.Size = new System.Drawing.Size(53, 13);
            this.lblLeaseInfoPeriods.TabIndex = 53;
            this.lblLeaseInfoPeriods.Text = "Termijnen";
            // 
            // lblLeaseInfoStartDate
            // 
            this.lblLeaseInfoStartDate.AutoSize = true;
            this.lblLeaseInfoStartDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLeaseInfoStartDate.Location = new System.Drawing.Point(3, 16);
            this.lblLeaseInfoStartDate.Name = "lblLeaseInfoStartDate";
            this.lblLeaseInfoStartDate.Size = new System.Drawing.Size(58, 13);
            this.lblLeaseInfoStartDate.TabIndex = 55;
            this.lblLeaseInfoStartDate.Text = "Startdatum";
            // 
            // btnDeleteLeaseContract
            // 
            this.btnDeleteLeaseContract.Location = new System.Drawing.Point(423, 323);
            this.btnDeleteLeaseContract.Name = "btnDeleteLeaseContract";
            this.btnDeleteLeaseContract.Size = new System.Drawing.Size(144, 36);
            this.btnDeleteLeaseContract.TabIndex = 50;
            this.btnDeleteLeaseContract.Text = "Leasecontract verwijderen";
            this.btnDeleteLeaseContract.UseVisualStyleBackColor = true;
            this.btnDeleteLeaseContract.Click += new System.EventHandler(this.btnDeleteLeaseContract_Click);
            // 
            // groupCreateLeaseContract
            // 
            this.groupCreateLeaseContract.Controls.Add(this.btnSaveEdit);
            this.groupCreateLeaseContract.Controls.Add(this.label2);
            this.groupCreateLeaseContract.Controls.Add(this.numPeriods);
            this.groupCreateLeaseContract.Controls.Add(this.lblMonthly);
            this.groupCreateLeaseContract.Controls.Add(this.cbxMonthlyPeriodically);
            this.groupCreateLeaseContract.Controls.Add(this.label1);
            this.groupCreateLeaseContract.Controls.Add(this.cbxLeaseContractProduct);
            this.groupCreateLeaseContract.Controls.Add(this.dtLeaseContractStartDate);
            this.groupCreateLeaseContract.Controls.Add(this.btnCreateLeaseContract);
            this.groupCreateLeaseContract.Controls.Add(this.cbxLeaseContractCompany);
            this.groupCreateLeaseContract.Controls.Add(this.label3);
            this.groupCreateLeaseContract.Controls.Add(this.label6);
            this.groupCreateLeaseContract.Location = new System.Drawing.Point(558, 51);
            this.groupCreateLeaseContract.Name = "groupCreateLeaseContract";
            this.groupCreateLeaseContract.Size = new System.Drawing.Size(574, 163);
            this.groupCreateLeaseContract.TabIndex = 82;
            this.groupCreateLeaseContract.TabStop = false;
            this.groupCreateLeaseContract.Text = "Leasecontract aanmaken";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 87;
            this.label2.Text = "Aantal termijnen";
            // 
            // numPeriods
            // 
            this.numPeriods.Location = new System.Drawing.Point(224, 81);
            this.numPeriods.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPeriods.Name = "numPeriods";
            this.numPeriods.Size = new System.Drawing.Size(45, 20);
            this.numPeriods.TabIndex = 86;
            this.numPeriods.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblMonthly
            // 
            this.lblMonthly.AutoSize = true;
            this.lblMonthly.Location = new System.Drawing.Point(8, 111);
            this.lblMonthly.Name = "lblMonthly";
            this.lblMonthly.Size = new System.Drawing.Size(121, 13);
            this.lblMonthly.TabIndex = 62;
            this.lblMonthly.Text = "Maandelijks of periodiek";
            // 
            // cbxMonthlyPeriodically
            // 
            this.cbxMonthlyPeriodically.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMonthlyPeriodically.FormattingEnabled = true;
            this.cbxMonthlyPeriodically.Items.AddRange(new object[] {
            "Maandelijks",
            "Periodiek"});
            this.cbxMonthlyPeriodically.Location = new System.Drawing.Point(10, 128);
            this.cbxMonthlyPeriodically.Name = "cbxMonthlyPeriodically";
            this.cbxMonthlyPeriodically.Size = new System.Drawing.Size(198, 21);
            this.cbxMonthlyPeriodically.TabIndex = 61;
            this.cbxMonthlyPeriodically.SelectedIndexChanged += new System.EventHandler(this.cbxMonthlyPeriodically_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 60;
            this.label1.Text = "Product";
            // 
            // cbxLeaseContractProduct
            // 
            this.cbxLeaseContractProduct.DataSource = this.productBindingSource;
            this.cbxLeaseContractProduct.DisplayMember = "Name";
            this.cbxLeaseContractProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLeaseContractProduct.FormattingEnabled = true;
            this.cbxLeaseContractProduct.Location = new System.Drawing.Point(223, 34);
            this.cbxLeaseContractProduct.Name = "cbxLeaseContractProduct";
            this.cbxLeaseContractProduct.Size = new System.Drawing.Size(199, 21);
            this.cbxLeaseContractProduct.TabIndex = 59;
            this.cbxLeaseContractProduct.ValueMember = "Id";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(BarrocIntensApp.Models.Product);
            // 
            // dtLeaseContractStartDate
            // 
            this.dtLeaseContractStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtLeaseContractStartDate.Location = new System.Drawing.Point(8, 35);
            this.dtLeaseContractStartDate.Name = "dtLeaseContractStartDate";
            this.dtLeaseContractStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtLeaseContractStartDate.TabIndex = 58;
            // 
            // btnCreateLeaseContract
            // 
            this.btnCreateLeaseContract.Location = new System.Drawing.Point(423, 111);
            this.btnCreateLeaseContract.Name = "btnCreateLeaseContract";
            this.btnCreateLeaseContract.Size = new System.Drawing.Size(144, 41);
            this.btnCreateLeaseContract.TabIndex = 51;
            this.btnCreateLeaseContract.Text = "Leasecontract aanmaken";
            this.btnCreateLeaseContract.UseVisualStyleBackColor = true;
            this.btnCreateLeaseContract.Click += new System.EventHandler(this.btnCreateLeaseContract_Click);
            // 
            // cbxLeaseContractCompany
            // 
            this.cbxLeaseContractCompany.DataSource = this.companyBindingSource;
            this.cbxLeaseContractCompany.DisplayMember = "Name";
            this.cbxLeaseContractCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLeaseContractCompany.FormattingEnabled = true;
            this.cbxLeaseContractCompany.Location = new System.Drawing.Point(10, 81);
            this.cbxLeaseContractCompany.Name = "cbxLeaseContractCompany";
            this.cbxLeaseContractCompany.Size = new System.Drawing.Size(198, 21);
            this.cbxLeaseContractCompany.TabIndex = 55;
            this.cbxLeaseContractCompany.ValueMember = "Id";
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataSource = typeof(BarrocIntensApp.Models.Company);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Startdatum";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Bedrijf";
            // 
            // groupLeaseContracts
            // 
            this.groupLeaseContracts.Controls.Add(this.dgvLeaseContracts);
            this.groupLeaseContracts.Location = new System.Drawing.Point(20, 220);
            this.groupLeaseContracts.Name = "groupLeaseContracts";
            this.groupLeaseContracts.Size = new System.Drawing.Size(522, 370);
            this.groupLeaseContracts.TabIndex = 81;
            this.groupLeaseContracts.TabStop = false;
            this.groupLeaseContracts.Text = "Leasecontracten";
            // 
            // dgvLeaseContracts
            // 
            this.dgvLeaseContracts.AllowUserToAddRows = false;
            this.dgvLeaseContracts.AllowUserToDeleteRows = false;
            this.dgvLeaseContracts.AllowUserToResizeColumns = false;
            this.dgvLeaseContracts.AllowUserToResizeRows = false;
            this.dgvLeaseContracts.AutoGenerateColumns = false;
            this.dgvLeaseContracts.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvLeaseContracts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLeaseContracts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeaseContracts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.companyDataGridViewTextBoxColumn,
            this.productDataGridViewTextBoxColumn});
            this.dgvLeaseContracts.DataSource = this.leaseContractBindingSource;
            this.dgvLeaseContracts.GridColor = System.Drawing.SystemColors.Control;
            this.dgvLeaseContracts.Location = new System.Drawing.Point(0, 15);
            this.dgvLeaseContracts.Name = "dgvLeaseContracts";
            this.dgvLeaseContracts.ReadOnly = true;
            this.dgvLeaseContracts.RowHeadersVisible = false;
            this.dgvLeaseContracts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvLeaseContracts.Size = new System.Drawing.Size(518, 349);
            this.dgvLeaseContracts.TabIndex = 45;
            this.dgvLeaseContracts.SelectionChanged += new System.EventHandler(this.dgvLeaseContracts_SelectionChanged);
            // 
            // companyDataGridViewTextBoxColumn
            // 
            this.companyDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.companyDataGridViewTextBoxColumn.DataPropertyName = "Company";
            this.companyDataGridViewTextBoxColumn.HeaderText = "Bedrijf";
            this.companyDataGridViewTextBoxColumn.Name = "companyDataGridViewTextBoxColumn";
            this.companyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productDataGridViewTextBoxColumn
            // 
            this.productDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productDataGridViewTextBoxColumn.DataPropertyName = "Product";
            this.productDataGridViewTextBoxColumn.HeaderText = "Product";
            this.productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn";
            this.productDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // leaseContractBindingSource
            // 
            this.leaseContractBindingSource.DataSource = typeof(BarrocIntensApp.Models.LeaseContract);
            // 
            // btnSaveEdit
            // 
            this.btnSaveEdit.Location = new System.Drawing.Point(423, 111);
            this.btnSaveEdit.Name = "btnSaveEdit";
            this.btnSaveEdit.Size = new System.Drawing.Size(144, 41);
            this.btnSaveEdit.TabIndex = 88;
            this.btnSaveEdit.Text = "Bewerkingen opslaan";
            this.btnSaveEdit.UseVisualStyleBackColor = true;
            this.btnSaveEdit.Visible = false;
            this.btnSaveEdit.Click += new System.EventHandler(this.btnSaveEdit_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(423, 281);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(144, 36);
            this.btnEdit.TabIndex = 57;
            this.btnEdit.Text = "Leasecontract bewerken";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // FinanceLeaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 601);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.groupLeaseContractInfo);
            this.Controls.Add(this.groupCreateLeaseContract);
            this.Controls.Add(this.groupLeaseContracts);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblDepartmentPart);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbBlack);
            this.Name = "FinanceLeaseForm";
            this.Text = "FinanceLeaseForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbBlack)).EndInit();
            this.groupLeaseContractInfo.ResumeLayout(false);
            this.groupLeaseContractInfo.PerformLayout();
            this.groupCreateLeaseContract.ResumeLayout(false);
            this.groupCreateLeaseContract.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPeriods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            this.groupLeaseContracts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaseContracts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaseContractBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private RoundButton btnBack;
        private System.Windows.Forms.Label lblDepartmentPart;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbBlack;
        private RoundButton btnLogout;
        private System.Windows.Forms.GroupBox groupLeaseContractInfo;
        private System.Windows.Forms.Button btnDeleteLeaseContract;
        private System.Windows.Forms.GroupBox groupCreateLeaseContract;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxLeaseContractProduct;
        private System.Windows.Forms.DateTimePicker dtLeaseContractStartDate;
        private System.Windows.Forms.Button btnCreateLeaseContract;
        private System.Windows.Forms.ComboBox cbxLeaseContractCompany;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupLeaseContracts;
        private System.Windows.Forms.DataGridView dgvLeaseContracts;
        private System.Windows.Forms.BindingSource leaseContractBindingSource;
        private System.Windows.Forms.Label lblMonthly;
        private System.Windows.Forms.ComboBox cbxMonthlyPeriodically;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblLeaseInfoStartDate;
        private System.Windows.Forms.Label lblMonthlyPeriodically;
        private System.Windows.Forms.Label lblLeaseInfoPeriods;
        private System.Windows.Forms.Label lblLeaseInfoProduct;
        private System.Windows.Forms.Label lblLeaseInfoCompany;
        private System.Windows.Forms.Label lblLeaseInfoPriceMonth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numPeriods;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSaveEdit;
    }
}