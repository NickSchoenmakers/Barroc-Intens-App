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
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbBlack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlack)).BeginInit();
            this.SuspendLayout();
            // 
            // FacturatieBtn
            // 
            this.FacturatieBtn.Location = new System.Drawing.Point(134, 144);
            this.FacturatieBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.LeaseBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.KostenBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.KostenBtn.Name = "KostenBtn";
            this.KostenBtn.Size = new System.Drawing.Size(150, 162);
            this.KostenBtn.TabIndex = 2;
            this.KostenBtn.Text = "Kosten overzicht";
            this.KostenBtn.UseVisualStyleBackColor = true;
            this.KostenBtn.Click += new System.EventHandler(this.KostenBtn_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Black;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(656, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(153, 25);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Finance | Main";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pbBlack
            // 
            this.pbBlack.BackColor = System.Drawing.SystemColors.WindowText;
            this.pbBlack.Location = new System.Drawing.Point(-289, 0);
            this.pbBlack.Name = "pbBlack";
            this.pbBlack.Size = new System.Drawing.Size(1145, 43);
            this.pbBlack.TabIndex = 7;
            this.pbBlack.TabStop = false;
            // 
            // FinanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 482);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbBlack);
            this.Controls.Add(this.KostenBtn);
            this.Controls.Add(this.LeaseBtn);
            this.Controls.Add(this.FacturatieBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FinanceForm";
            this.Text = "Finance_mainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbBlack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FacturatieBtn;
        private System.Windows.Forms.Button LeaseBtn;
        private System.Windows.Forms.Button KostenBtn;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbBlack;
    }
}