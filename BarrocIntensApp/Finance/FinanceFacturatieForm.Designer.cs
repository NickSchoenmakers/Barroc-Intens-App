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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacturatieForm));
            this.pbBlack = new System.Windows.Forms.PictureBox();
            this.ProductCbx = new System.Windows.Forms.ComboBox();
            this.NameTb = new System.Windows.Forms.TextBox();
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.PeriodRb = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.AmountNu = new System.Windows.Forms.NumericUpDown();
            this.listView1 = new System.Windows.Forms.ListView();
            this.BtnReturnStoringen = new BarrocIntensApp.RoundButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDepartmentPart = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountNu)).BeginInit();
            this.SuspendLayout();
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
            // ProductCbx
            // 
            this.ProductCbx.FormattingEnabled = true;
            this.ProductCbx.Location = new System.Drawing.Point(131, 222);
            this.ProductCbx.Name = "ProductCbx";
            this.ProductCbx.Size = new System.Drawing.Size(121, 21);
            this.ProductCbx.TabIndex = 7;
            this.ProductCbx.SelectedIndexChanged += new System.EventHandler(this.ProductCbx_SelectedIndexChanged);
            // 
            // NameTb
            // 
            this.NameTb.Location = new System.Drawing.Point(131, 92);
            this.NameTb.Name = "NameTb";
            this.NameTb.Size = new System.Drawing.Size(173, 20);
            this.NameTb.TabIndex = 8;
            this.NameTb.TextChanged += new System.EventHandler(this.NameTb_TextChanged);
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
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(133, 249);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(81, 17);
            this.radioButton1.TabIndex = 27;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Maandelijks";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // PeriodRb
            // 
            this.PeriodRb.AutoSize = true;
            this.PeriodRb.Location = new System.Drawing.Point(235, 249);
            this.PeriodRb.Name = "PeriodRb";
            this.PeriodRb.Size = new System.Drawing.Size(69, 17);
            this.PeriodRb.TabIndex = 28;
            this.PeriodRb.TabStop = true;
            this.PeriodRb.Text = "Periodiek";
            this.PeriodRb.UseVisualStyleBackColor = true;
            this.PeriodRb.CheckedChanged += new System.EventHandler(this.PeriodRb_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Hoeveelheid";
            // 
            // AmountNu
            // 
            this.AmountNu.Location = new System.Drawing.Point(331, 222);
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
            // listView1
            // 
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "listViewGroup1";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(741, 49);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(391, 427);
            this.listView1.TabIndex = 31;
            this.listView1.UseCompatibleStateImageBehavior = false;
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
            this.lblTitle.TabIndex = 33;
            this.lblTitle.Text = "Finance | Name";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.lblDepartmentPart.TabIndex = 34;
            this.lblDepartmentPart.Text = "Factuur aanmaken";
            this.lblDepartmentPart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FacturatieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 601);
            this.Controls.Add(this.lblDepartmentPart);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.BtnReturnStoringen);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.AmountNu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PeriodRb);
            this.Controls.Add(this.radioButton1);
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
            this.Controls.Add(this.NameTb);
            this.Controls.Add(this.ProductCbx);
            this.Controls.Add(this.pbBlack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FacturatieForm";
            this.Text = "Facturatie_Form";
            this.Load += new System.EventHandler(this.FacturatieForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBlack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountNu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbBlack;
        private System.Windows.Forms.ComboBox ProductCbx;
        private System.Windows.Forms.TextBox NameTb;
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
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton PeriodRb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown AmountNu;
        private System.Windows.Forms.ListView listView1;
        private RoundButton BtnReturnStoringen;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDepartmentPart;
    }
}