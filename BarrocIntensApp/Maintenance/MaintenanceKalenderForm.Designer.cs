namespace BarrocIntensApp
{
    partial class MaintenanceKalenderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaintenanceKalenderForm));
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupAppointments = new System.Windows.Forms.GroupBox();
            this.dgvAppointments = new System.Windows.Forms.DataGridView();
            this.nextAppointmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maintenanceAppointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupAppointmentInfo = new System.Windows.Forms.GroupBox();
            this.btnViewWorkOrder = new System.Windows.Forms.Button();
            this.btnShowCreateWorkOrder = new System.Windows.Forms.Button();
            this.lblAppointmentProduct = new System.Windows.Forms.Label();
            this.groupAppointmentLocation = new System.Windows.Forms.GroupBox();
            this.lblCompanyCountryCode = new System.Windows.Forms.Label();
            this.lblCompanyCity = new System.Windows.Forms.Label();
            this.lblCompanyNumber = new System.Windows.Forms.Label();
            this.lblCompanyStreet = new System.Windows.Forms.Label();
            this.lblAppointmentRemark = new System.Windows.Forms.Label();
            this.lblAppointmentCompany = new System.Windows.Forms.Label();
            this.lblAppointmentDate = new System.Windows.Forms.Label();
            this.pbBlack = new System.Windows.Forms.PictureBox();
            this.lblDepartmentPart = new System.Windows.Forms.Label();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWorkOrderFeedback = new System.Windows.Forms.Label();
            this.btnReturnDashboard = new BarrocIntensApp.RoundButton();
            this.roundButton1 = new BarrocIntensApp.RoundButton();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maintenanceAppointmentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupAppointments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceAppointmentBindingSource)).BeginInit();
            this.groupAppointmentInfo.SuspendLayout();
            this.groupAppointmentLocation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceAppointmentBindingSource1)).BeginInit();
            this.SuspendLayout();
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
            this.lblTitle.TabIndex = 35;
            this.lblTitle.Text = "Maintenance | Name";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupAppointments
            // 
            this.groupAppointments.Controls.Add(this.dgvAppointments);
            this.groupAppointments.Location = new System.Drawing.Point(20, 156);
            this.groupAppointments.Name = "groupAppointments";
            this.groupAppointments.Size = new System.Drawing.Size(522, 434);
            this.groupAppointments.TabIndex = 59;
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
            this.dgvAppointments.Location = new System.Drawing.Point(1, 17);
            this.dgvAppointments.Name = "dgvAppointments";
            this.dgvAppointments.ReadOnly = true;
            this.dgvAppointments.RowHeadersVisible = false;
            this.dgvAppointments.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAppointments.Size = new System.Drawing.Size(518, 381);
            this.dgvAppointments.TabIndex = 45;
            this.dgvAppointments.SelectionChanged += new System.EventHandler(this.dgvAppointments_SelectionChanged);
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
            // maintenanceAppointmentBindingSource
            // 
            this.maintenanceAppointmentBindingSource.DataSource = typeof(BarrocIntensApp.Models.MaintenanceAppointment);
            // 
            // groupAppointmentInfo
            // 
            this.groupAppointmentInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupAppointmentInfo.Controls.Add(this.btnViewWorkOrder);
            this.groupAppointmentInfo.Controls.Add(this.btnShowCreateWorkOrder);
            this.groupAppointmentInfo.Controls.Add(this.lblAppointmentProduct);
            this.groupAppointmentInfo.Controls.Add(this.groupAppointmentLocation);
            this.groupAppointmentInfo.Controls.Add(this.lblAppointmentRemark);
            this.groupAppointmentInfo.Controls.Add(this.lblAppointmentCompany);
            this.groupAppointmentInfo.Controls.Add(this.lblAppointmentDate);
            this.groupAppointmentInfo.Location = new System.Drawing.Point(558, 156);
            this.groupAppointmentInfo.Name = "groupAppointmentInfo";
            this.groupAppointmentInfo.Size = new System.Drawing.Size(574, 434);
            this.groupAppointmentInfo.TabIndex = 58;
            this.groupAppointmentInfo.TabStop = false;
            this.groupAppointmentInfo.Text = "Afspraakinfo";
            // 
            // btnViewWorkOrder
            // 
            this.btnViewWorkOrder.Location = new System.Drawing.Point(445, 390);
            this.btnViewWorkOrder.Name = "btnViewWorkOrder";
            this.btnViewWorkOrder.Size = new System.Drawing.Size(123, 38);
            this.btnViewWorkOrder.TabIndex = 57;
            this.btnViewWorkOrder.Text = "Werkbon openen";
            this.btnViewWorkOrder.UseVisualStyleBackColor = true;
            this.btnViewWorkOrder.Visible = false;
            this.btnViewWorkOrder.Click += new System.EventHandler(this.btnViewWorkOrder_Click);
            // 
            // btnShowCreateWorkOrder
            // 
            this.btnShowCreateWorkOrder.Location = new System.Drawing.Point(445, 390);
            this.btnShowCreateWorkOrder.Name = "btnShowCreateWorkOrder";
            this.btnShowCreateWorkOrder.Size = new System.Drawing.Size(123, 38);
            this.btnShowCreateWorkOrder.TabIndex = 56;
            this.btnShowCreateWorkOrder.Text = "Werkbon invullen";
            this.btnShowCreateWorkOrder.UseVisualStyleBackColor = true;
            this.btnShowCreateWorkOrder.Visible = false;
            this.btnShowCreateWorkOrder.Click += new System.EventHandler(this.btnShowCreateWorkOrder_Click);
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
            this.groupAppointmentLocation.Location = new System.Drawing.Point(6, 71);
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
            // pbBlack
            // 
            this.pbBlack.BackColor = System.Drawing.SystemColors.WindowText;
            this.pbBlack.Location = new System.Drawing.Point(0, 0);
            this.pbBlack.Name = "pbBlack";
            this.pbBlack.Size = new System.Drawing.Size(1145, 43);
            this.pbBlack.TabIndex = 5;
            this.pbBlack.TabStop = false;
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
            this.lblDepartmentPart.TabIndex = 36;
            this.lblDepartmentPart.Text = "Onderhoud kalender";
            this.lblDepartmentPart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbFilter
            // 
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "Alle afspraken",
            "Vandaag",
            "Deze week"});
            this.cbFilter.Location = new System.Drawing.Point(17, 129);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(173, 21);
            this.cbFilter.TabIndex = 65;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 66;
            this.label2.Text = "Filter";
            // 
            // lblWorkOrderFeedback
            // 
            this.lblWorkOrderFeedback.AutoSize = true;
            this.lblWorkOrderFeedback.ForeColor = System.Drawing.Color.Green;
            this.lblWorkOrderFeedback.Location = new System.Drawing.Point(1019, 140);
            this.lblWorkOrderFeedback.Name = "lblWorkOrderFeedback";
            this.lblWorkOrderFeedback.Size = new System.Drawing.Size(113, 13);
            this.lblWorkOrderFeedback.TabIndex = 67;
            this.lblWorkOrderFeedback.Text = "Werkbon aangemaakt";
            this.lblWorkOrderFeedback.Visible = false;
            // 
            // btnReturnDashboard
            // 
            this.btnReturnDashboard.BackColor = System.Drawing.Color.Black;
            this.btnReturnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnReturnDashboard.Location = new System.Drawing.Point(12, 50);
            this.btnReturnDashboard.Name = "btnReturnDashboard";
            this.btnReturnDashboard.Size = new System.Drawing.Size(88, 50);
            this.btnReturnDashboard.TabIndex = 55;
            this.btnReturnDashboard.Text = "←";
            this.btnReturnDashboard.UseVisualStyleBackColor = false;
            this.btnReturnDashboard.Click += new System.EventHandler(this.btnReturnDashboard_Click);
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.Black;
            this.roundButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton1.ForeColor = System.Drawing.Color.White;
            this.roundButton1.Location = new System.Drawing.Point(12, 49);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(88, 50);
            this.roundButton1.TabIndex = 37;
            this.roundButton1.Text = "←";
            this.roundButton1.UseVisualStyleBackColor = false;
            this.roundButton1.Click += new System.EventHandler(this.roundButton1_Click);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(BarrocIntensApp.Models.Product);
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataSource = typeof(BarrocIntensApp.Models.Company);
            // 
            // maintenanceAppointmentBindingSource1
            // 
            this.maintenanceAppointmentBindingSource1.DataSource = typeof(BarrocIntensApp.Models.MaintenanceAppointment);
            // 
            // MaintenanceKalenderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 601);
            this.Controls.Add(this.lblWorkOrderFeedback);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.groupAppointments);
            this.Controls.Add(this.groupAppointmentInfo);
            this.Controls.Add(this.btnReturnDashboard);
            this.Controls.Add(this.roundButton1);
            this.Controls.Add(this.lblDepartmentPart);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbBlack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MaintenanceKalenderForm";
            this.Text = "MaintenanceOnderhoudForm";
            this.groupAppointments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceAppointmentBindingSource)).EndInit();
            this.groupAppointmentInfo.ResumeLayout(false);
            this.groupAppointmentInfo.PerformLayout();
            this.groupAppointmentLocation.ResumeLayout(false);
            this.groupAppointmentLocation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceAppointmentBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private RoundButton roundButton1;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private System.Windows.Forms.GroupBox groupAppointments;
        private System.Windows.Forms.BindingSource maintenanceAppointmentBindingSource;
        private System.Windows.Forms.GroupBox groupAppointmentInfo;
        private RoundButton btnReturnDashboard;
        private System.Windows.Forms.PictureBox pbBlack;
        private System.Windows.Forms.Label lblDepartmentPart;
        private System.Windows.Forms.BindingSource maintenanceAppointmentBindingSource1;
        private System.Windows.Forms.DataGridView dgvAppointments;
        private System.Windows.Forms.DataGridViewTextBoxColumn nextAppointmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblAppointmentDate;
        private System.Windows.Forms.Label lblAppointmentCompany;
        private System.Windows.Forms.Label lblAppointmentRemark;
        private System.Windows.Forms.GroupBox groupAppointmentLocation;
        private System.Windows.Forms.Label lblCompanyCountryCode;
        private System.Windows.Forms.Label lblCompanyCity;
        private System.Windows.Forms.Label lblCompanyNumber;
        private System.Windows.Forms.Label lblCompanyStreet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.Label lblAppointmentProduct;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnShowCreateWorkOrder;
        private System.Windows.Forms.Label lblWorkOrderFeedback;
        private System.Windows.Forms.Button btnViewWorkOrder;
    }
}