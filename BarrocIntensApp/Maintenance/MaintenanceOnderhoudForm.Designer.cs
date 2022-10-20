namespace BarrocIntensApp
{
    partial class MaintenanceOnderhoudForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaintenanceOnderhoudForm));
            this.lblTitle = new System.Windows.Forms.Label();
            this.roundButton1 = new BarrocIntensApp.RoundButton();
            this.groupPlanAppointment = new System.Windows.Forms.GroupBox();
            this.dtAppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.txbAppointmentRemark = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbAppointmentCompany = new System.Windows.Forms.ComboBox();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupAppointments = new System.Windows.Forms.GroupBox();
            this.dgvAppointments = new System.Windows.Forms.DataGridView();
            this.nextAppointmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maintenanceAppointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maintenanceAppointmentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupAppointmentInfo = new System.Windows.Forms.GroupBox();
            this.lblAppointmentRemark = new System.Windows.Forms.Label();
            this.lblAppointmentCompany = new System.Windows.Forms.Label();
            this.lblAppointmentDate = new System.Windows.Forms.Label();
            this.btnDeleteAppointment = new System.Windows.Forms.Button();
            this.btnReturnDashboard = new BarrocIntensApp.RoundButton();
            this.pbBlack = new System.Windows.Forms.PictureBox();
            this.lblDepartmentPart = new System.Windows.Forms.Label();
            this.groupPlanAppointment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            this.groupAppointments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceAppointmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceAppointmentBindingSource1)).BeginInit();
            this.groupAppointmentInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlack)).BeginInit();
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
            // groupPlanAppointment
            // 
            this.groupPlanAppointment.Controls.Add(this.dtAppointmentDate);
            this.groupPlanAppointment.Controls.Add(this.btnAddProduct);
            this.groupPlanAppointment.Controls.Add(this.txbAppointmentRemark);
            this.groupPlanAppointment.Controls.Add(this.label4);
            this.groupPlanAppointment.Controls.Add(this.cbAppointmentCompany);
            this.groupPlanAppointment.Controls.Add(this.label3);
            this.groupPlanAppointment.Controls.Add(this.label6);
            this.groupPlanAppointment.Location = new System.Drawing.Point(558, 51);
            this.groupPlanAppointment.Name = "groupPlanAppointment";
            this.groupPlanAppointment.Size = new System.Drawing.Size(574, 163);
            this.groupPlanAppointment.TabIndex = 64;
            this.groupPlanAppointment.TabStop = false;
            this.groupPlanAppointment.Text = "Afspraak inplannen";
            // 
            // dtAppointmentDate
            // 
            this.dtAppointmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtAppointmentDate.Location = new System.Drawing.Point(9, 32);
            this.dtAppointmentDate.Name = "dtAppointmentDate";
            this.dtAppointmentDate.Size = new System.Drawing.Size(200, 20);
            this.dtAppointmentDate.TabIndex = 58;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(455, 125);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(113, 32);
            this.btnAddProduct.TabIndex = 51;
            this.btnAddProduct.Text = "Afspraak inplannen";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // txbAppointmentRemark
            // 
            this.txbAppointmentRemark.Location = new System.Drawing.Point(11, 132);
            this.txbAppointmentRemark.Name = "txbAppointmentRemark";
            this.txbAppointmentRemark.Size = new System.Drawing.Size(198, 20);
            this.txbAppointmentRemark.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 116);
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
            this.cbAppointmentCompany.Location = new System.Drawing.Point(11, 82);
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
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Datum";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Bedrijf";
            // 
            // groupAppointments
            // 
            this.groupAppointments.Controls.Add(this.dgvAppointments);
            this.groupAppointments.Location = new System.Drawing.Point(20, 220);
            this.groupAppointments.Name = "groupAppointments";
            this.groupAppointments.Size = new System.Drawing.Size(522, 370);
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
            // maintenanceAppointmentBindingSource1
            // 
            this.maintenanceAppointmentBindingSource1.DataSource = typeof(BarrocIntensApp.Models.MaintenanceAppointment);
            // 
            // groupAppointmentInfo
            // 
            this.groupAppointmentInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupAppointmentInfo.Controls.Add(this.lblAppointmentRemark);
            this.groupAppointmentInfo.Controls.Add(this.lblAppointmentCompany);
            this.groupAppointmentInfo.Controls.Add(this.lblAppointmentDate);
            this.groupAppointmentInfo.Controls.Add(this.btnDeleteAppointment);
            this.groupAppointmentInfo.Location = new System.Drawing.Point(558, 220);
            this.groupAppointmentInfo.Name = "groupAppointmentInfo";
            this.groupAppointmentInfo.Size = new System.Drawing.Size(574, 370);
            this.groupAppointmentInfo.TabIndex = 58;
            this.groupAppointmentInfo.TabStop = false;
            this.groupAppointmentInfo.Text = "Afspraakinfo";
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
            this.btnDeleteAppointment.Location = new System.Drawing.Point(443, 332);
            this.btnDeleteAppointment.Name = "btnDeleteAppointment";
            this.btnDeleteAppointment.Size = new System.Drawing.Size(125, 32);
            this.btnDeleteAppointment.TabIndex = 50;
            this.btnDeleteAppointment.Text = "Afspraak verwijderen";
            this.btnDeleteAppointment.UseVisualStyleBackColor = true;
            this.btnDeleteAppointment.Click += new System.EventHandler(this.btnDeleteAppointment_Click);
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
            this.lblDepartmentPart.Text = "Onderhoud inplannen";
            this.lblDepartmentPart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MaintenanceOnderhoudForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 601);
            this.Controls.Add(this.groupPlanAppointment);
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
            this.Name = "MaintenanceOnderhoudForm";
            this.Text = "MaintenanceOnderhoudForm";
            this.groupPlanAppointment.ResumeLayout(false);
            this.groupPlanAppointment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            this.groupAppointments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceAppointmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceAppointmentBindingSource1)).EndInit();
            this.groupAppointmentInfo.ResumeLayout(false);
            this.groupAppointmentInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private RoundButton roundButton1;
        private System.Windows.Forms.GroupBox groupPlanAppointment;
        private System.Windows.Forms.DateTimePicker dtAppointmentDate;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.TextBox txbAppointmentRemark;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbAppointmentCompany;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupAppointments;
        private System.Windows.Forms.BindingSource maintenanceAppointmentBindingSource;
        private System.Windows.Forms.GroupBox groupAppointmentInfo;
        private System.Windows.Forms.Button btnDeleteAppointment;
        private RoundButton btnReturnDashboard;
        private System.Windows.Forms.PictureBox pbBlack;
        private System.Windows.Forms.Label lblDepartmentPart;
        private System.Windows.Forms.BindingSource maintenanceAppointmentBindingSource1;
        private System.Windows.Forms.DataGridView dgvAppointments;
        private System.Windows.Forms.DataGridViewTextBoxColumn nextAppointmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblAppointmentDate;
        private System.Windows.Forms.Label lblAppointmentCompany;
        private System.Windows.Forms.Label lblAppointmentRemark;
    }
}