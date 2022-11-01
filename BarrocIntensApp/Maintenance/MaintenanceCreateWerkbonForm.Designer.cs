namespace BarrocIntensApp.Maintenance
{
    partial class MaintenanceCreateWerkbonForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbDescription = new System.Windows.Forms.TextBox();
            this.lblOnderdelen = new System.Windows.Forms.Label();
            this.cboParts = new System.Windows.Forms.ComboBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddPart = new System.Windows.Forms.Button();
            this.btnAddWorkOrder = new System.Windows.Forms.Button();
            this.groupParts = new System.Windows.Forms.GroupBox();
            this.dgvParts = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.numAmount = new System.Windows.Forms.NumericUpDown();
            this.maintenanceAppointmentWorkOrderProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.groupParts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceAppointmentWorkOrderProductBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Werkzaamheden";
            // 
            // txbDescription
            // 
            this.txbDescription.Location = new System.Drawing.Point(13, 30);
            this.txbDescription.Multiline = true;
            this.txbDescription.Name = "txbDescription";
            this.txbDescription.Size = new System.Drawing.Size(554, 104);
            this.txbDescription.TabIndex = 1;
            // 
            // lblOnderdelen
            // 
            this.lblOnderdelen.AutoSize = true;
            this.lblOnderdelen.Location = new System.Drawing.Point(16, 141);
            this.lblOnderdelen.Name = "lblOnderdelen";
            this.lblOnderdelen.Size = new System.Drawing.Size(116, 13);
            this.lblOnderdelen.TabIndex = 2;
            this.lblOnderdelen.Text = "Onderdelen toevoegen";
            // 
            // cboParts
            // 
            this.cboParts.DataSource = this.productBindingSource;
            this.cboParts.DisplayMember = "Name";
            this.cboParts.FormattingEnabled = true;
            this.cboParts.Location = new System.Drawing.Point(19, 158);
            this.cboParts.Name = "cboParts";
            this.cboParts.Size = new System.Drawing.Size(198, 21);
            this.cboParts.TabIndex = 3;
            this.cboParts.ValueMember = "Id";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(BarrocIntensApp.Models.Product);
            // 
            // btnAddPart
            // 
            this.btnAddPart.Location = new System.Drawing.Point(277, 156);
            this.btnAddPart.Name = "btnAddPart";
            this.btnAddPart.Size = new System.Drawing.Size(122, 23);
            this.btnAddPart.TabIndex = 4;
            this.btnAddPart.Text = "Onderdeel toevoegen";
            this.btnAddPart.UseVisualStyleBackColor = true;
            this.btnAddPart.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnAddWorkOrder
            // 
            this.btnAddWorkOrder.Location = new System.Drawing.Point(445, 437);
            this.btnAddWorkOrder.Name = "btnAddWorkOrder";
            this.btnAddWorkOrder.Size = new System.Drawing.Size(122, 35);
            this.btnAddWorkOrder.TabIndex = 5;
            this.btnAddWorkOrder.Text = "Werkbon aanmaken";
            this.btnAddWorkOrder.UseVisualStyleBackColor = true;
            this.btnAddWorkOrder.Click += new System.EventHandler(this.btnAddWorkOrder_Click);
            // 
            // groupParts
            // 
            this.groupParts.Controls.Add(this.dgvParts);
            this.groupParts.Location = new System.Drawing.Point(19, 187);
            this.groupParts.Name = "groupParts";
            this.groupParts.Size = new System.Drawing.Size(548, 244);
            this.groupParts.TabIndex = 60;
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
            this.dgvParts.Size = new System.Drawing.Size(537, 222);
            this.dgvParts.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 61;
            this.label2.Text = "Aantal";
            // 
            // numAmount
            // 
            this.numAmount.Location = new System.Drawing.Point(226, 158);
            this.numAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAmount.Name = "numAmount";
            this.numAmount.Size = new System.Drawing.Size(45, 20);
            this.numAmount.TabIndex = 62;
            this.numAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // maintenanceAppointmentWorkOrderProductBindingSource
            // 
            this.maintenanceAppointmentWorkOrderProductBindingSource.DataSource = typeof(BarrocIntensApp.Models.MaintenanceAppointmentWorkOrderProduct);
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
            // MaintenanceWerkbonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 484);
            this.Controls.Add(this.numAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupParts);
            this.Controls.Add(this.btnAddWorkOrder);
            this.Controls.Add(this.btnAddPart);
            this.Controls.Add(this.cboParts);
            this.Controls.Add(this.lblOnderdelen);
            this.Controls.Add(this.txbDescription);
            this.Controls.Add(this.label1);
            this.Name = "MaintenanceWerkbonForm";
            this.Text = "MaintenanceWerkbon";
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.groupParts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceAppointmentWorkOrderProductBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbDescription;
        private System.Windows.Forms.Label lblOnderdelen;
        private System.Windows.Forms.ComboBox cboParts;
        private System.Windows.Forms.Button btnAddPart;
        private System.Windows.Forms.Button btnAddWorkOrder;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.GroupBox groupParts;
        private System.Windows.Forms.DataGridView dgvParts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numAmount;
        private System.Windows.Forms.BindingSource maintenanceAppointmentWorkOrderProductBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
    }
}