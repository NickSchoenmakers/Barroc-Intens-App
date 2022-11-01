namespace BarrocIntensApp
{
    partial class MaintenanceStoringenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaintenanceStoringenForm));
            this.pbBlack = new System.Windows.Forms.PictureBox();
            this.maintenanceAppointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roundButton1 = new BarrocIntensApp.RoundButton();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CompanyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NextAppointment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRemarks = new System.Windows.Forms.DataGridView();
            this.Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceAppointmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRemarks)).BeginInit();
            this.SuspendLayout();
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
            // maintenanceAppointmentBindingSource
            // 
            this.maintenanceAppointmentBindingSource.DataSource = typeof(BarrocIntensApp.Models.MaintenanceAppointment);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Company";
            this.dataGridViewTextBoxColumn2.HeaderText = "Company";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Company";
            this.dataGridViewTextBoxColumn3.HeaderText = "Company";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 76;
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.Black;
            this.roundButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton1.ForeColor = System.Drawing.Color.White;
            this.roundButton1.Location = new System.Drawing.Point(12, 49);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(88, 50);
            this.roundButton1.TabIndex = 9;
            this.roundButton1.Text = "←";
            this.roundButton1.UseVisualStyleBackColor = false;
            this.roundButton1.Click += new System.EventHandler(this.roundButton1_Click);
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataSource = typeof(BarrocIntensApp.Models.Company);
            // 
            // CompanyId
            // 
            this.CompanyId.DataPropertyName = "CompanyId";
            this.CompanyId.HeaderText = "CompanyId";
            this.CompanyId.Name = "CompanyId";
            this.CompanyId.Width = 85;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NextAppointment";
            this.dataGridViewTextBoxColumn1.HeaderText = "NextAppointment";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 113;
            // 
            // NextAppointment
            // 
            this.NextAppointment.DataPropertyName = "NextAppointment";
            this.NextAppointment.HeaderText = "NextAppointment";
            this.NextAppointment.Name = "NextAppointment";
            this.NextAppointment.Width = 113;
            // 
            // Remark
            // 
            this.Remark.DataPropertyName = "Remark";
            this.Remark.HeaderText = "Remark";
            this.Remark.Name = "Remark";
            this.Remark.Width = 69;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 41;
            // 
            // dgvRemarks
            // 
            this.dgvRemarks.AutoGenerateColumns = false;
            this.dgvRemarks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRemarks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRemarks.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvRemarks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRemarks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.Remark,
            this.NextAppointment,
            this.dataGridViewTextBoxColumn1,
            this.CompanyId,
            this.Company});
            this.dgvRemarks.DataSource = this.maintenanceAppointmentBindingSource;
            this.dgvRemarks.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dgvRemarks.Location = new System.Drawing.Point(379, 49);
            this.dgvRemarks.Name = "dgvRemarks";
            this.dgvRemarks.Size = new System.Drawing.Size(753, 438);
            this.dgvRemarks.TabIndex = 8;
            this.dgvRemarks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Company
            // 
            this.Company.DataPropertyName = "Company";
            this.Company.HeaderText = "Company";
            this.Company.Name = "Company";
            this.Company.Width = 76;
            // 
            // MaintenanceStoringenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 601);
            this.Controls.Add(this.roundButton1);
            this.Controls.Add(this.dgvRemarks);
            this.Controls.Add(this.pbBlack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MaintenanceStoringenForm";
            this.Text = "MaintenanceStoringenForm";
            this.Load += new System.EventHandler(this.MaintenanceStoringenForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBlack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceAppointmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRemarks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbBlack;
        private RoundButton roundButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAddedDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource maintenanceAppointmentBindingSource;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NextAppointment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvRemarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company;
    }
}