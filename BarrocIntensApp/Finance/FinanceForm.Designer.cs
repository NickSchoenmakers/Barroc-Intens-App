namespace BarrocIntensApp
{
    partial class FinanceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinanceForm));
            this.FacturatieBtn = new System.Windows.Forms.Button();
            this.LeaseBtn = new System.Windows.Forms.Button();
            this.KostenBtn = new System.Windows.Forms.Button();
            this.pbBlack = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDepartmentPart = new System.Windows.Forms.Label();
            this.roundButton1 = new BarrocIntensApp.RoundButton();
            this.btnBkrCheck = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlack)).BeginInit();
            this.SuspendLayout();
            // 
            // FacturatieBtn
            // 
            this.FacturatieBtn.Location = new System.Drawing.Point(134, 144);
            this.FacturatieBtn.Margin = new System.Windows.Forms.Padding(2);
            this.FacturatieBtn.Name = "FacturatieBtn";
            this.FacturatieBtn.Size = new System.Drawing.Size(150, 162);
            this.FacturatieBtn.TabIndex = 0;
            this.FacturatieBtn.Text = "Facturatie";
            this.FacturatieBtn.UseVisualStyleBackColor = true;
            this.FacturatieBtn.Click += new System.EventHandler(this.FacturatieBtn_Click);
            // 
            // LeaseBtn
            // 
            this.LeaseBtn.Location = new System.Drawing.Point(328, 144);
            this.LeaseBtn.Margin = new System.Windows.Forms.Padding(2);
            this.LeaseBtn.Name = "LeaseBtn";
            this.LeaseBtn.Size = new System.Drawing.Size(150, 162);
            this.LeaseBtn.TabIndex = 1;
            this.LeaseBtn.Text = "Lease contract";
            this.LeaseBtn.UseVisualStyleBackColor = true;
            this.LeaseBtn.Click += new System.EventHandler(this.LeaseBtn_Click);
            // 
            // KostenBtn
            // 
            this.KostenBtn.Location = new System.Drawing.Point(520, 144);
            this.KostenBtn.Margin = new System.Windows.Forms.Padding(2);
            this.KostenBtn.Name = "KostenBtn";
            this.KostenBtn.Size = new System.Drawing.Size(150, 162);
            this.KostenBtn.TabIndex = 2;
            this.KostenBtn.Text = "Kosten overzicht";
            this.KostenBtn.UseVisualStyleBackColor = true;
            this.KostenBtn.Click += new System.EventHandler(this.KostenBtn_Click);
            // 
            // pbBlack
            // 
            this.pbBlack.BackColor = System.Drawing.SystemColors.WindowText;
            this.pbBlack.Location = new System.Drawing.Point(-289, 0);
            this.pbBlack.Name = "pbBlack";
            this.pbBlack.Size = new System.Drawing.Size(1435, 43);
            this.pbBlack.TabIndex = 7;
            this.pbBlack.TabStop = false;
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
            this.lblTitle.TabIndex = 34;
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
            this.lblDepartmentPart.TabIndex = 35;
            this.lblDepartmentPart.Text = "Dashboard";
            this.lblDepartmentPart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.roundButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.roundButton1.Location = new System.Drawing.Point(964, 49);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(168, 70);
            this.roundButton1.TabIndex = 41;
            this.roundButton1.Text = "Uitloggen";
            this.roundButton1.UseVisualStyleBackColor = false;
            this.roundButton1.Click += new System.EventHandler(this.roundButton1_Click);
            // 
            // btnBkrCheck
            // 
            this.btnBkrCheck.Location = new System.Drawing.Point(709, 144);
            this.btnBkrCheck.Margin = new System.Windows.Forms.Padding(2);
            this.btnBkrCheck.Name = "btnBkrCheck";
            this.btnBkrCheck.Size = new System.Drawing.Size(150, 162);
            this.btnBkrCheck.TabIndex = 42;
            this.btnBkrCheck.Text = "BKR-checks";
            this.btnBkrCheck.UseVisualStyleBackColor = true;
            this.btnBkrCheck.Click += new System.EventHandler(this.btnBkrCheck_Click);
            // 
            // FinanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 601);
            this.Controls.Add(this.btnBkrCheck);
            this.Controls.Add(this.roundButton1);
            this.Controls.Add(this.lblDepartmentPart);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbBlack);
            this.Controls.Add(this.KostenBtn);
            this.Controls.Add(this.LeaseBtn);
            this.Controls.Add(this.FacturatieBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FinanceForm";
            this.Text = "Finance_mainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbBlack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FacturatieBtn;
        private System.Windows.Forms.Button LeaseBtn;
        private System.Windows.Forms.Button KostenBtn;
        private System.Windows.Forms.PictureBox pbBlack;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDepartmentPart;
        private RoundButton roundButton1;
        private System.Windows.Forms.Button btnBkrCheck;
    }
}