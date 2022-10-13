namespace BarrocIntensApp
{
    partial class InkoopMagazijnForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InkoopMagazijnForm));
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbBlack = new System.Windows.Forms.PictureBox();
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.productCategoriesGridView2 = new System.Windows.Forms.DataGridView();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.lblProducten = new System.Windows.Forms.Label();
            this.lblProductCategories = new System.Windows.Forms.Label();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCategoryIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbBlack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoriesGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Black;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(983, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(149, 25);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Inkoop | Name";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pbBlack
            // 
            this.pbBlack.BackColor = System.Drawing.SystemColors.WindowText;
            this.pbBlack.Location = new System.Drawing.Point(0, 0);
            this.pbBlack.Name = "pbBlack";
            this.pbBlack.Size = new System.Drawing.Size(1145, 43);
            this.pbBlack.TabIndex = 3;
            this.pbBlack.TabStop = false;
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.AutoGenerateColumns = false;
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.productCategoryIdDataGridViewTextBoxColumn});
            this.productsDataGridView.DataSource = this.productsBindingSource1;
            this.productsDataGridView.Location = new System.Drawing.Point(29, 295);
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.Size = new System.Drawing.Size(523, 284);
            this.productsDataGridView.TabIndex = 5;
            this.productsDataGridView.SelectionChanged += new System.EventHandler(this.productsDataGridView_SelectionChanged);
            // 
            // productCategoriesGridView2
            // 
            this.productCategoriesGridView2.AutoGenerateColumns = false;
            this.productCategoriesGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productCategoriesGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1});
            this.productCategoriesGridView2.DataSource = this.productCategoryBindingSource;
            this.productCategoriesGridView2.Location = new System.Drawing.Point(29, 76);
            this.productCategoriesGridView2.Name = "productCategoriesGridView2";
            this.productCategoriesGridView2.Size = new System.Drawing.Size(393, 171);
            this.productCategoriesGridView2.TabIndex = 6;
            this.productCategoriesGridView2.SelectionChanged += new System.EventHandler(this.productCategoriesGridView2_SelectionChanged);
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.productCategoryBindingSource;
            // 
            // productsBindingSource1
            // 
            this.productsBindingSource1.DataMember = "Products";
            this.productsBindingSource1.DataSource = this.productCategoryBindingSource;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(568, 542);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(119, 37);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblProducten
            // 
            this.lblProducten.AutoSize = true;
            this.lblProducten.Location = new System.Drawing.Point(29, 276);
            this.lblProducten.Name = "lblProducten";
            this.lblProducten.Size = new System.Drawing.Size(56, 13);
            this.lblProducten.TabIndex = 8;
            this.lblProducten.Text = "Producten";
            // 
            // lblProductCategories
            // 
            this.lblProductCategories.AutoSize = true;
            this.lblProductCategories.Location = new System.Drawing.Point(29, 57);
            this.lblProductCategories.Name = "lblProductCategories";
            this.lblProductCategories.Size = new System.Drawing.Size(97, 13);
            this.lblProductCategories.TabIndex = 9;
            this.lblProductCategories.Text = "Product categorien";
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Categorie";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.Width = 350;
            // 
            // productCategoryBindingSource
            // 
            this.productCategoryBindingSource.DataSource = typeof(BarrocIntensApp.Models.ProductCategory);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Naam";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Beschrijving";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Prijs";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // productCategoryIdDataGridViewTextBoxColumn
            // 
            this.productCategoryIdDataGridViewTextBoxColumn.DataPropertyName = "ProductCategoryId";
            this.productCategoryIdDataGridViewTextBoxColumn.HeaderText = "Product categorie id";
            this.productCategoryIdDataGridViewTextBoxColumn.Name = "productCategoryIdDataGridViewTextBoxColumn";
            this.productCategoryIdDataGridViewTextBoxColumn.Width = 130;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(BarrocIntensApp.Models.Product);
            // 
            // InkoopMagazijnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 601);
            this.Controls.Add(this.lblProductCategories);
            this.Controls.Add(this.lblProducten);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.productCategoriesGridView2);
            this.Controls.Add(this.productsDataGridView);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbBlack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InkoopMagazijnForm";
            this.Text = "InkoopMagazijnForm";
            this.Load += new System.EventHandler(this.InkoopMagazijnForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBlack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoriesGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbBlack;
        private System.Windows.Forms.DataGridView productsDataGridView;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.DataGridView productCategoriesGridView2;
        private System.Windows.Forms.BindingSource productCategoryBindingSource;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private System.Windows.Forms.BindingSource productsBindingSource1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblProducten;
        private System.Windows.Forms.Label lblProductCategories;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCategoryIdDataGridViewTextBoxColumn;
    }
}