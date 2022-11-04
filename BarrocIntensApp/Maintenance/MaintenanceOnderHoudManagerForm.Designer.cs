namespace BarrocIntensApp.Maintenance {
    partial class MaintenanceOnderHoudManagerForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.groupAppointmentInfo = new System.Windows.Forms.GroupBox();
            this.btnViewWorkOrder = new System.Windows.Forms.Button();
            this.lblRoutine = new System.Windows.Forms.Label();
            this.lblAppointmentWorker = new System.Windows.Forms.Label();
            this.lblAppointmentProduct = new System.Windows.Forms.Label();
            this.groupAppointmentLocation = new System.Windows.Forms.GroupBox();
            this.lblCompanyCountryCode = new System.Windows.Forms.Label();
            this.lblCompanyCity = new System.Windows.Forms.Label();
            this.lblCompanyNumber = new System.Windows.Forms.Label();
            this.lblCompanyStreet = new System.Windows.Forms.Label();
            this.lblAppointmentRemark = new System.Windows.Forms.Label();
            this.lblAppointmentCompany = new System.Windows.Forms.Label();
            this.lblAppointmentDate = new System.Windows.Forms.Label();
            this.btnDeleteAppointment = new System.Windows.Forms.Button();
            this.maintenanceAppointmentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnReturnDashboard = new BarrocIntensApp.RoundButton();
            this.lblDepartmentPart = new System.Windows.Forms.Label();
            this.pbBlack = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maintenanceAppointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupPlanAppointment = new System.Windows.Forms.GroupBox();
            this.cbRoutine = new System.Windows.Forms.CheckBox();
            this.cbWorker = new System.Windows.Forms.ComboBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbAppointmentProduct = new System.Windows.Forms.ComboBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtAppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.txbAppointmentRemark = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbAppointmentCompany = new System.Windows.Forms.ComboBox();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.roundButton1 = new BarrocIntensApp.RoundButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.nextAppointmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupAppointments = new System.Windows.Forms.GroupBox();
            this.dgvAppointments = new System.Windows.Forms.DataGridView();
            this.groupAppointmentInfo.SuspendLayout();
            this.groupAppointmentLocation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceAppointmentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceAppointmentBindingSource)).BeginInit();
            this.groupPlanAppointment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            this.groupAppointments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            this.SuspendLayout();
            // 
            // cbFilter
            // 
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "Alle afspraken",
            "Vandaag",
            "Deze week"});
            this.cbFilter.Location = new System.Drawing.Point(19, 193);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(173, 21);
            this.cbFilter.TabIndex = 75;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // groupAppointmentInfo
            // 
            this.groupAppointmentInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupAppointmentInfo.Controls.Add(this.btnViewWorkOrder);
            this.groupAppointmentInfo.Controls.Add(this.lblRoutine);
            this.groupAppointmentInfo.Controls.Add(this.lblAppointmentWorker);
            this.groupAppointmentInfo.Controls.Add(this.lblAppointmentProduct);
            this.groupAppointmentInfo.Controls.Add(this.groupAppointmentLocation);
            this.groupAppointmentInfo.Controls.Add(this.lblAppointmentRemark);
            this.groupAppointmentInfo.Controls.Add(this.lblAppointmentCompany);
            this.groupAppointmentInfo.Controls.Add(this.lblAppointmentDate);
            this.groupAppointmentInfo.Controls.Add(this.btnDeleteAppointment);
            this.groupAppointmentInfo.Location = new System.Drawing.Point(557, 220);
            this.groupAppointmentInfo.Name = "groupAppointmentInfo";
            this.groupAppointmentInfo.Size = new System.Drawing.Size(574, 370);
            this.groupAppointmentInfo.TabIndex = 72;
            this.groupAppointmentInfo.TabStop = false;
            this.groupAppointmentInfo.Text = "Afspraakinfo";
            // 
            // btnViewWorkOrder
            // 
            this.btnViewWorkOrder.Location = new System.Drawing.Point(442, 289);
            this.btnViewWorkOrder.Name = "btnViewWorkOrder";
            this.btnViewWorkOrder.Size = new System.Drawing.Size(123, 32);
            this.btnViewWorkOrder.TabIndex = 58;
            this.btnViewWorkOrder.Text = "Werkbon openen";
            this.btnViewWorkOrder.UseVisualStyleBackColor = true;
            this.btnViewWorkOrder.Visible = false;
            this.btnViewWorkOrder.Click += new System.EventHandler(this.btnViewWorkOrder_Click);
            // 
            // lblRoutine
            // 
            this.lblRoutine.AutoSize = true;
            this.lblRoutine.Location = new System.Drawing.Point(8, 172);
            this.lblRoutine.Name = "lblRoutine";
            this.lblRoutine.Size = new System.Drawing.Size(44, 13);
            this.lblRoutine.TabIndex = 57;
            this.lblRoutine.Text = "Routine";
            // 
            // lblAppointmentWorker
            // 
            this.lblAppointmentWorker.AutoSize = true;
            this.lblAppointmentWorker.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAppointmentWorker.Location = new System.Drawing.Point(3, 68);
            this.lblAppointmentWorker.Name = "lblAppointmentWorker";
            this.lblAppointmentWorker.Size = new System.Drawing.Size(107, 13);
            this.lblAppointmentWorker.TabIndex = 56;
            this.lblAppointmentWorker.Text = "Maintenance Worker";
            // 
            // lblAppointmentProduct
            // 
            this.lblAppointmentProduct.AutoSize = true;
            this.lblAppointmentProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAppointmentProduct.Location = new System.Drawing.Point(3, 55);
            this.lblAppointmentProduct.Name = "lblAppointmentProduct";
            this.lblAppointmentProduct.Size = new System.Drawing.Size(44, 13);
            this.lblAppointmentProduct.TabIndex = 54;
            this.lblAppointmentProduct.Text = "Product";
            // 
            // groupAppointmentLocation
            // 
            this.groupAppointmentLocation.Controls.Add(this.lblCompanyCountryCode);
            this.groupAppointmentLocation.Controls.Add(this.lblCompanyCity);
            this.groupAppointmentLocation.Controls.Add(this.lblCompanyNumber);
            this.groupAppointmentLocation.Controls.Add(this.lblCompanyStreet);
            this.groupAppointmentLocation.Location = new System.Drawing.Point(6, 93);
            this.groupAppointmentLocation.Name = "groupAppointmentLocation";
            this.groupAppointmentLocation.Size = new System.Drawing.Size(243, 72);
            this.groupAppointmentLocation.TabIndex = 55;
            this.groupAppointmentLocation.TabStop = false;
            this.groupAppointmentLocation.Text = "Locatie";
            // 
            // lblCompanyCountryCode
            // 
            this.lblCompanyCountryCode.AutoSize = true;
            this.lblCompanyCountryCode.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCompanyCountryCode.Location = new System.Drawing.Point(3, 55);
            this.lblCompanyCountryCode.Name = "lblCompanyCountryCode";
            this.lblCompanyCountryCode.Size = new System.Drawing.Size(68, 13);
            this.lblCompanyCountryCode.TabIndex = 3;
            this.lblCompanyCountryCode.Text = "CountryCode";
            // 
            // lblCompanyCity
            // 
            this.lblCompanyCity.AutoSize = true;
            this.lblCompanyCity.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCompanyCity.Location = new System.Drawing.Point(3, 42);
            this.lblCompanyCity.Name = "lblCompanyCity";
            this.lblCompanyCity.Size = new System.Drawing.Size(24, 13);
            this.lblCompanyCity.TabIndex = 2;
            this.lblCompanyCity.Text = "City";
            // 
            // lblCompanyNumber
            // 
            this.lblCompanyNumber.AutoSize = true;
            this.lblCompanyNumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCompanyNumber.Location = new System.Drawing.Point(3, 29);
            this.lblCompanyNumber.Name = "lblCompanyNumber";
            this.lblCompanyNumber.Size = new System.Drawing.Size(75, 13);
            this.lblCompanyNumber.TabIndex = 1;
            this.lblCompanyNumber.Text = "HouseNumber";
            // 
            // lblCompanyStreet
            // 
            this.lblCompanyStreet.AutoSize = true;
            this.lblCompanyStreet.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCompanyStreet.Location = new System.Drawing.Point(3, 16);
            this.lblCompanyStreet.Name = "lblCompanyStreet";
            this.lblCompanyStreet.Size = new System.Drawing.Size(35, 13);
            this.lblCompanyStreet.TabIndex = 0;
            this.lblCompanyStreet.Text = "Street";
            // 
            // lblAppointmentRemark
            // 
            this.lblAppointmentRemark.AutoSize = true;
            this.lblAppointmentRemark.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAppointmentRemark.Location = new System.Drawing.Point(3, 42);
            this.lblAppointmentRemark.Name = "lblAppointmentRemark";
            this.lblAppointmentRemark.Size = new System.Drawing.Size(44, 13);
            this.lblAppointmentRemark.TabIndex = 53;
            this.lblAppointmentRemark.Text = "Remark";
            // 
            // lblAppointmentCompany
            // 
            this.lblAppointmentCompany.AutoSize = true;
            this.lblAppointmentCompany.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAppointmentCompany.Location = new System.Drawing.Point(3, 29);
            this.lblAppointmentCompany.Name = "lblAppointmentCompany";
            this.lblAppointmentCompany.Size = new System.Drawing.Size(51, 13);
            this.lblAppointmentCompany.TabIndex = 52;
            this.lblAppointmentCompany.Text = "Company";
            // 
            // lblAppointmentDate
            // 
            this.lblAppointmentDate.AutoSize = true;
            this.lblAppointmentDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAppointmentDate.Location = new System.Drawing.Point(3, 16);
            this.lblAppointmentDate.Name = "lblAppointmentDate";
            this.lblAppointmentDate.Size = new System.Drawing.Size(38, 13);
            this.lblAppointmentDate.TabIndex = 51;
            this.lblAppointmentDate.Text = "Datum";
            // 
            // btnDeleteAppointment
            // 
            this.btnDeleteAppointment.Location = new System.Drawing.Point(442, 327);
            this.btnDeleteAppointment.Name = "btnDeleteAppointment";
            this.btnDeleteAppointment.Size = new System.Drawing.Size(125, 32);
            this.btnDeleteAppointment.TabIndex = 50;
            this.btnDeleteAppointment.Text = "Afspraak verwijderen";
            this.btnDeleteAppointment.UseVisualStyleBackColor = true;
            this.btnDeleteAppointment.Click += new System.EventHandler(this.btnDeleteAppointment_Click_1);
            // 
            // maintenanceAppointmentBindingSource1
            // 
            this.maintenanceAppointmentBindingSource1.DataSource = typeof(BarrocIntensApp.Models.MaintenanceAppointment);
            // 
            // btnReturnDashboard
            // 
            this.btnReturnDashboard.BackColor = System.Drawing.Color.Black;
            this.btnReturnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnReturnDashboard.Location = new System.Drawing.Point(11, 50);
            this.btnReturnDashboard.Name = "btnReturnDashboard";
            this.btnReturnDashboard.Size = new System.Drawing.Size(88, 50);
            this.btnReturnDashboard.TabIndex = 71;
            this.btnReturnDashboard.Text = "←";
            this.btnReturnDashboard.UseVisualStyleBackColor = false;
            this.btnReturnDashboard.Click += new System.EventHandler(this.BtnReturnStoringen_Click);
            // 
            // lblDepartmentPart
            // 
            this.lblDepartmentPart.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDepartmentPart.BackColor = System.Drawing.Color.Black;
            this.lblDepartmentPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentPart.ForeColor = System.Drawing.Color.White;
            this.lblDepartmentPart.Location = new System.Drawing.Point(11, 9);
            this.lblDepartmentPart.Name = "lblDepartmentPart";
            this.lblDepartmentPart.Size = new System.Drawing.Size(405, 25);
            this.lblDepartmentPart.TabIndex = 69;
            this.lblDepartmentPart.Text = "Onderhoud inplannen";
            this.lblDepartmentPart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbBlack
            // 
            this.pbBlack.BackColor = System.Drawing.SystemColors.WindowText;
            this.pbBlack.Location = new System.Drawing.Point(-1, 0);
            this.pbBlack.Name = "pbBlack";
            this.pbBlack.Size = new System.Drawing.Size(1145, 43);
            this.pbBlack.TabIndex = 67;
            this.pbBlack.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 76;
            this.label2.Text = "Filter";
            // 
            // maintenanceAppointmentBindingSource
            // 
            this.maintenanceAppointmentBindingSource.DataSource = typeof(BarrocIntensApp.Models.MaintenanceAppointment);
            // 
            // groupPlanAppointment
            // 
            this.groupPlanAppointment.Controls.Add(this.cbRoutine);
            this.groupPlanAppointment.Controls.Add(this.cbWorker);
            this.groupPlanAppointment.Controls.Add(this.label5);
            this.groupPlanAppointment.Controls.Add(this.label1);
            this.groupPlanAppointment.Controls.Add(this.cbAppointmentProduct);
            this.groupPlanAppointment.Controls.Add(this.dtAppointmentDate);
            this.groupPlanAppointment.Controls.Add(this.btnAddProduct);
            this.groupPlanAppointment.Controls.Add(this.txbAppointmentRemark);
            this.groupPlanAppointment.Controls.Add(this.label4);
            this.groupPlanAppointment.Controls.Add(this.cbAppointmentCompany);
            this.groupPlanAppointment.Controls.Add(this.label3);
            this.groupPlanAppointment.Controls.Add(this.label6);
            this.groupPlanAppointment.Location = new System.Drawing.Point(557, 51);
            this.groupPlanAppointment.Name = "groupPlanAppointment";
            this.groupPlanAppointment.Size = new System.Drawing.Size(574, 163);
            this.groupPlanAppointment.TabIndex = 74;
            this.groupPlanAppointment.TabStop = false;
            this.groupPlanAppointment.Text = "Afspraak inplannen";
            // 
            // cbRoutine
            // 
            this.cbRoutine.AutoSize = true;
            this.cbRoutine.Location = new System.Drawing.Point(225, 128);
            this.cbRoutine.Name = "cbRoutine";
            this.cbRoutine.Size = new System.Drawing.Size(126, 17);
            this.cbRoutine.TabIndex = 64;
            this.cbRoutine.Text = "Routinematig bezoek";
            this.cbRoutine.UseVisualStyleBackColor = true;
            // 
            // cbWorker
            // 
            this.cbWorker.DataSource = this.userBindingSource;
            this.cbWorker.DisplayMember = "Name";
            this.cbWorker.FormattingEnabled = true;
            this.cbWorker.Location = new System.Drawing.Point(223, 76);
            this.cbWorker.Name = "cbWorker";
            this.cbWorker.Size = new System.Drawing.Size(219, 21);
            this.cbWorker.TabIndex = 62;
            this.cbWorker.ValueMember = "Id";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(BarrocIntensApp.Models.User);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 61;
            this.label5.Text = "Maintenance werknemer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 60;
            this.label1.Text = "Product";
            // 
            // cbAppointmentProduct
            // 
            this.cbAppointmentProduct.DataSource = this.productBindingSource;
            this.cbAppointmentProduct.DisplayMember = "Name";
            this.cbAppointmentProduct.FormattingEnabled = true;
            this.cbAppointmentProduct.Location = new System.Drawing.Point(223, 26);
            this.cbAppointmentProduct.Name = "cbAppointmentProduct";
            this.cbAppointmentProduct.Size = new System.Drawing.Size(219, 21);
            this.cbAppointmentProduct.TabIndex = 59;
            this.cbAppointmentProduct.ValueMember = "Id";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(BarrocIntensApp.Models.Product);
            // 
            // dtAppointmentDate
            // 
            this.dtAppointmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtAppointmentDate.Location = new System.Drawing.Point(8, 27);
            this.dtAppointmentDate.Name = "dtAppointmentDate";
            this.dtAppointmentDate.Size = new System.Drawing.Size(200, 20);
            this.dtAppointmentDate.TabIndex = 58;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(442, 120);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(125, 32);
            this.btnAddProduct.TabIndex = 51;
            this.btnAddProduct.Text = "Afspraak inplannen";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click_1);
            // 
            // txbAppointmentRemark
            // 
            this.txbAppointmentRemark.Location = new System.Drawing.Point(10, 127);
            this.txbAppointmentRemark.Name = "txbAppointmentRemark";
            this.txbAppointmentRemark.Size = new System.Drawing.Size(198, 20);
            this.txbAppointmentRemark.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Opmerking";
            // 
            // cbAppointmentCompany
            // 
            this.cbAppointmentCompany.DataSource = this.companyBindingSource;
            this.cbAppointmentCompany.DisplayMember = "Name";
            this.cbAppointmentCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAppointmentCompany.FormattingEnabled = true;
            this.cbAppointmentCompany.Location = new System.Drawing.Point(10, 77);
            this.cbAppointmentCompany.Name = "cbAppointmentCompany";
            this.cbAppointmentCompany.Size = new System.Drawing.Size(198, 21);
            this.cbAppointmentCompany.TabIndex = 55;
            this.cbAppointmentCompany.ValueMember = "Id";
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataSource = typeof(BarrocIntensApp.Models.Company);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Datum";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Bedrijf";
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.Black;
            this.roundButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton1.ForeColor = System.Drawing.Color.White;
            this.roundButton1.Location = new System.Drawing.Point(11, 49);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(88, 50);
            this.roundButton1.TabIndex = 70;
            this.roundButton1.Text = "←";
            this.roundButton1.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTitle.BackColor = System.Drawing.Color.Black;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTitle.Location = new System.Drawing.Point(726, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(405, 25);
            this.lblTitle.TabIndex = 68;
            this.lblTitle.Text = "Maintenance | Name";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nextAppointmentDataGridViewTextBoxColumn
            // 
            this.nextAppointmentDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nextAppointmentDataGridViewTextBoxColumn.DataPropertyName = "NextAppointment";
            this.nextAppointmentDataGridViewTextBoxColumn.HeaderText = "NextAppointment";
            this.nextAppointmentDataGridViewTextBoxColumn.Name = "nextAppointmentDataGridViewTextBoxColumn";
            this.nextAppointmentDataGridViewTextBoxColumn.ReadOnly = true;
            this.nextAppointmentDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // groupAppointments
            // 
            this.groupAppointments.Controls.Add(this.dgvAppointments);
            this.groupAppointments.Location = new System.Drawing.Point(19, 220);
            this.groupAppointments.Name = "groupAppointments";
            this.groupAppointments.Size = new System.Drawing.Size(522, 370);
            this.groupAppointments.TabIndex = 73;
            this.groupAppointments.TabStop = false;
            this.groupAppointments.Text = "Onderhoudsafspraken";
            // 
            // dgvAppointments
            // 
            this.dgvAppointments.AllowUserToAddRows = false;
            this.dgvAppointments.AllowUserToDeleteRows = false;
            this.dgvAppointments.AllowUserToResizeColumns = false;
            this.dgvAppointments.AllowUserToResizeRows = false;
            this.dgvAppointments.AutoGenerateColumns = false;
            this.dgvAppointments.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAppointments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointments.ColumnHeadersVisible = false;
            this.dgvAppointments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nextAppointmentDataGridViewTextBoxColumn});
            this.dgvAppointments.DataSource = this.maintenanceAppointmentBindingSource;
            this.dgvAppointments.GridColor = System.Drawing.SystemColors.Control;
            this.dgvAppointments.Location = new System.Drawing.Point(3, 12);
            this.dgvAppointments.Name = "dgvAppointments";
            this.dgvAppointments.ReadOnly = true;
            this.dgvAppointments.RowHeadersVisible = false;
            this.dgvAppointments.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAppointments.Size = new System.Drawing.Size(515, 381);
            this.dgvAppointments.TabIndex = 45;
            this.dgvAppointments.SelectionChanged += new System.EventHandler(this.dgvAppointments_SelectionChanged_1);
            // 
            // MaintenanceOnderHoudManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 601);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.groupAppointmentInfo);
            this.Controls.Add(this.btnReturnDashboard);
            this.Controls.Add(this.lblDepartmentPart);
            this.Controls.Add(this.pbBlack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupPlanAppointment);
            this.Controls.Add(this.roundButton1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.groupAppointments);
            this.Name = "MaintenanceOnderHoudManagerForm";
            this.Text = "MaintenanceOnderHoudManagerForm";
            this.groupAppointmentInfo.ResumeLayout(false);
            this.groupAppointmentInfo.PerformLayout();
            this.groupAppointmentLocation.ResumeLayout(false);
            this.groupAppointmentLocation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceAppointmentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceAppointmentBindingSource)).EndInit();
            this.groupPlanAppointment.ResumeLayout(false);
            this.groupPlanAppointment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            this.groupAppointments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.GroupBox groupAppointmentInfo;
        private System.Windows.Forms.Label lblAppointmentProduct;
        private System.Windows.Forms.GroupBox groupAppointmentLocation;
        private System.Windows.Forms.Label lblCompanyCountryCode;
        private System.Windows.Forms.Label lblCompanyCity;
        private System.Windows.Forms.Label lblCompanyNumber;
        private System.Windows.Forms.Label lblCompanyStreet;
        private System.Windows.Forms.Label lblAppointmentRemark;
        private System.Windows.Forms.Label lblAppointmentCompany;
        private System.Windows.Forms.Label lblAppointmentDate;
        private System.Windows.Forms.Button btnDeleteAppointment;
        private System.Windows.Forms.BindingSource maintenanceAppointmentBindingSource1;
        private RoundButton btnReturnDashboard;
        private System.Windows.Forms.Label lblDepartmentPart;
        private System.Windows.Forms.PictureBox pbBlack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource maintenanceAppointmentBindingSource;
        private System.Windows.Forms.GroupBox groupPlanAppointment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbAppointmentProduct;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.DateTimePicker dtAppointmentDate;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.TextBox txbAppointmentRemark;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbAppointmentCompany;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private RoundButton roundButton1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn nextAppointmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupAppointments;
        private System.Windows.Forms.DataGridView dgvAppointments;
        private System.Windows.Forms.Label lblAppointmentWorker;
        private System.Windows.Forms.ComboBox cbWorker;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbRoutine;
        private System.Windows.Forms.Label lblRoutine;
        private System.Windows.Forms.Button btnViewWorkOrder;
    }
}