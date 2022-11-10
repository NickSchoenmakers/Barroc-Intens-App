namespace BarrocIntensApp.Sales
{
    partial class SalesKlantCreateForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbStreet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numHouseNumber = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txbCity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxCountry = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbNameContact = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbPhoneContact = new System.Windows.Forms.TextBox();
            this.btnCreateCustomer = new System.Windows.Forms.Button();
            this.noteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numHouseNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naam";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(13, 30);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(179, 20);
            this.txbName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Straatnaam";
            // 
            // txbStreet
            // 
            this.txbStreet.Location = new System.Drawing.Point(13, 74);
            this.txbStreet.Name = "txbStreet";
            this.txbStreet.Size = new System.Drawing.Size(179, 20);
            this.txbStreet.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Huisnummer";
            // 
            // numHouseNumber
            // 
            this.numHouseNumber.Location = new System.Drawing.Point(202, 73);
            this.numHouseNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numHouseNumber.Name = "numHouseNumber";
            this.numHouseNumber.Size = new System.Drawing.Size(62, 20);
            this.numHouseNumber.TabIndex = 5;
            this.numHouseNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Stad";
            // 
            // txbCity
            // 
            this.txbCity.Location = new System.Drawing.Point(13, 118);
            this.txbCity.Name = "txbCity";
            this.txbCity.Size = new System.Drawing.Size(179, 20);
            this.txbCity.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Land";
            // 
            // cbxCountry
            // 
            this.cbxCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCountry.FormattingEnabled = true;
            this.cbxCountry.Items.AddRange(new object[] {
            "Nederland\t",
            "Belgie"});
            this.cbxCountry.Location = new System.Drawing.Point(13, 162);
            this.cbxCountry.Name = "cbxCountry";
            this.cbxCountry.Size = new System.Drawing.Size(179, 21);
            this.cbxCountry.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Naam contactpersoon";
            // 
            // txbNameContact
            // 
            this.txbNameContact.Location = new System.Drawing.Point(13, 207);
            this.txbNameContact.Name = "txbNameContact";
            this.txbNameContact.Size = new System.Drawing.Size(179, 20);
            this.txbNameContact.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Telefoonnummer contractpersoon";
            // 
            // txbPhoneContact
            // 
            this.txbPhoneContact.Location = new System.Drawing.Point(13, 251);
            this.txbPhoneContact.Name = "txbPhoneContact";
            this.txbPhoneContact.Size = new System.Drawing.Size(179, 20);
            this.txbPhoneContact.TabIndex = 13;
            // 
            // btnCreateCustomer
            // 
            this.btnCreateCustomer.Location = new System.Drawing.Point(16, 287);
            this.btnCreateCustomer.Name = "btnCreateCustomer";
            this.btnCreateCustomer.Size = new System.Drawing.Size(316, 52);
            this.btnCreateCustomer.TabIndex = 14;
            this.btnCreateCustomer.Text = "Klant aanmaken";
            this.btnCreateCustomer.UseVisualStyleBackColor = true;
            this.btnCreateCustomer.Click += new System.EventHandler(this.btnCreateCustomer_Click);
            // 
            // noteBindingSource
            // 
            this.noteBindingSource.DataSource = typeof(BarrocIntensApp.Models.Note);
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataSource = typeof(BarrocIntensApp.Models.Company);
            // 
            // SalesKlantCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 352);
            this.Controls.Add(this.btnCreateCustomer);
            this.Controls.Add(this.txbPhoneContact);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbNameContact);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxCountry);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbCity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numHouseNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbStreet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.label1);
            this.Name = "SalesKlantCreateForm";
            this.Text = "SalesKlantCreateForm";
            ((System.ComponentModel.ISupportInitialize)(this.numHouseNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource noteBindingSource;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbStreet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numHouseNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbCity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxCountry;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbNameContact;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbPhoneContact;
        private System.Windows.Forms.Button btnCreateCustomer;
    }
}