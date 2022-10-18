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
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbBlack = new System.Windows.Forms.PictureBox();
            this.StreetTb = new System.Windows.Forms.TextBox();
            this.ZipTb = new System.Windows.Forms.TextBox();
            this.NameLbl = new System.Windows.Forms.Label();
            this.Street_numberLbl = new System.Windows.Forms.Label();
            this.ZipcodeLbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.HnrTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CityTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AmountNu = new System.Windows.Forms.NumericUpDown();
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CartGv = new System.Windows.Forms.DataGridView();
            this.Cartbtn = new BarrocIntensApp.RoundButton();
            this.BtnReturnStoringen = new BarrocIntensApp.RoundButton();
            this.NameCb = new System.Windows.Forms.ComboBox();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbBlack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountNu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CartGv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Black;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(930, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(202, 25);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Finance | Facturatie";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pbBlack
            // 
            this.pbBlack.BackColor = System.Drawing.SystemColors.WindowText;
            this.pbBlack.Location = new System.Drawing.Point(-289, 0);
            this.pbBlack.Name = "pbBlack";
            this.pbBlack.Size = new System.Drawing.Size(1434, 43);
            this.pbBlack.TabIndex = 5;
            this.pbBlack.TabStop = false;
            // 
            // StreetTb
            // 
            this.StreetTb.Location = new System.Drawing.Point(131, 118);
            this.StreetTb.Name = "StreetTb";
            this.StreetTb.Size = new System.Drawing.Size(173, 20);
            this.StreetTb.TabIndex = 9;
            this.StreetTb.TextChanged += new System.EventHandler(this.StreetTb_TextChanged);
            // 
            // ZipTb
            // 
            this.ZipTb.Location = new System.Drawing.Point(131, 196);
            this.ZipTb.Name = "ZipTb";
            this.ZipTb.Size = new System.Drawing.Size(173, 20);
            this.ZipTb.TabIndex = 10;
            this.ZipTb.TextChanged += new System.EventHandler(this.ZipTb_TextChanged);
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
            // HnrTb
            // 
            this.HnrTb.Location = new System.Drawing.Point(131, 144);
            this.HnrTb.Name = "HnrTb";
            this.HnrTb.Size = new System.Drawing.Size(173, 20);
            this.HnrTb.TabIndex = 23;
            this.HnrTb.TextChanged += new System.EventHandler(this.HnrTb_TextChanged);
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
            // CityTb
            // 
            this.CityTb.Location = new System.Drawing.Point(131, 170);
            this.CityTb.Name = "CityTb";
            this.CityTb.Size = new System.Drawing.Size(173, 20);
            this.CityTb.TabIndex = 25;
            this.CityTb.TextChanged += new System.EventHandler(this.CityTb_TextChanged);
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
            // CartGv
            // 
            this.CartGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CartGv.Location = new System.Drawing.Point(680, 75);
            this.CartGv.Name = "CartGv";
            this.CartGv.Size = new System.Drawing.Size(465, 272);
            this.CartGv.TabIndex = 36;
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
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataSource = typeof(BarrocIntensApp.Models.Company);
            // 
            // FacturatieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 601);
            this.Controls.Add(this.NameCb);
            this.Controls.Add(this.CartGv);
            this.Controls.Add(this.Cartbtn);
            this.Controls.Add(this.productsDataGridView);
            this.Controls.Add(this.BtnReturnStoringen);
            this.Controls.Add(this.AmountNu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CityTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HnrTb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ZipcodeLbl);
            this.Controls.Add(this.Street_numberLbl);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.ZipTb);
            this.Controls.Add(this.StreetTb);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbBlack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FacturatieForm";
            this.Text = "Facturatie_Form";
            this.Load += new System.EventHandler(this.FacturatieForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBlack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountNu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CartGv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbBlack;
        private System.Windows.Forms.TextBox StreetTb;
        private System.Windows.Forms.TextBox ZipTb;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label Street_numberLbl;
        private System.Windows.Forms.Label ZipcodeLbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox HnrTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CityTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown AmountNu;
        private RoundButton BtnReturnStoringen;
        private System.Windows.Forms.DataGridView productsDataGridView;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private RoundButton Cartbtn;
        private System.Windows.Forms.DataGridView CartGv;
        private System.Windows.Forms.ComboBox NameCb;
        private System.Windows.Forms.BindingSource companyBindingSource;
    }
}