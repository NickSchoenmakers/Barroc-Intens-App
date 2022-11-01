namespace BarrocIntensApp.Maintenance
{
    partial class MaintenanceViewWerkbonForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupParts = new System.Windows.Forms.GroupBox();
            this.dgvParts = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maintenanceAppointmentWorkOrderProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblDescription = new System.Windows.Forms.Label();
            this.groupParts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceAppointmentWorkOrderProductBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupParts
            // 
            this.groupParts.Controls.Add(this.dgvParts);
            this.groupParts.Location = new System.Drawing.Point(15, 132);
            this.groupParts.Name = "groupParts";
            this.groupParts.Size = new System.Drawing.Size(555, 334);
            this.groupParts.TabIndex = 69;
            this.groupParts.TabStop = false;
            this.groupParts.Text = "Onderdelen";
            // 
            // dgvParts
            // 
            this.dgvParts.AllowUserToAddRows = false;
            this.dgvParts.AllowUserToDeleteRows = false;
            this.dgvParts.AllowUserToResizeColumns = false;
            this.dgvParts.AllowUserToResizeRows = false;
            this.dgvParts.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvParts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParts.ColumnHeadersVisible = false;
            this.dgvParts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.quantity});
            this.dgvParts.GridColor = System.Drawing.SystemColors.Control;
            this.dgvParts.Location = new System.Drawing.Point(5, 16);
            this.dgvParts.Name = "dgvParts";
            this.dgvParts.ReadOnly = true;
            this.dgvParts.RowHeadersVisible = false;
            this.dgvParts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvParts.Size = new System.Drawing.Size(544, 312);
            this.dgvParts.TabIndex = 61;
            // 
            // name
            // 
            this.name.HeaderText = "Naam";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 480;
            // 
            // quantity
            // 
            this.quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.quantity.DefaultCellStyle = dataGridViewCellStyle1;
            this.quantity.HeaderText = "Aantal";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDescription);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(557, 114);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Werkzaamheden";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(BarrocIntensApp.Models.Product);
            // 
            // maintenanceAppointmentWorkOrderProductBindingSource
            // 
            this.maintenanceAppointmentWorkOrderProductBindingSource.DataSource = typeof(BarrocIntensApp.Models.MaintenanceAppointmentWorkOrderProduct);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDescription.Location = new System.Drawing.Point(3, 16);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Description";
            // 
            // MaintenanceViewWerkbonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 478);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupParts);
            this.Name = "MaintenanceViewWerkbonForm";
            this.Text = "MaintenanceViewWerkbonForm";
            this.groupParts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceAppointmentWorkOrderProductBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.GroupBox groupParts;
        private System.Windows.Forms.DataGridView dgvParts;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.BindingSource maintenanceAppointmentWorkOrderProductBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDescription;
    }
}