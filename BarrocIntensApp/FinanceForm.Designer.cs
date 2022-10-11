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
            this.FacturatieBtn.Location = new System.Drawing.Point(179, 177);
            this.FacturatieBtn.Name = "FacturatieBtn";
            this.FacturatieBtn.Size = new System.Drawing.Size(200, 200);
            this.FacturatieBtn.TabIndex = 0;
            this.FacturatieBtn.Text = "Facturatie";
            this.FacturatieBtn.UseVisualStyleBackColor = true;
            this.FacturatieBtn.Click += new System.EventHandler(this.FacturatieBtn_Click);
            // 
            // LeaseBtn
            // 
            this.LeaseBtn.Location = new System.Drawing.Point(437, 177);
            this.LeaseBtn.Name = "LeaseBtn";
            this.LeaseBtn.Size = new System.Drawing.Size(200, 200);
            this.LeaseBtn.TabIndex = 1;
            this.LeaseBtn.Text = "Lease contract";
            this.LeaseBtn.UseVisualStyleBackColor = true;
            this.LeaseBtn.Click += new System.EventHandler(this.LeaseBtn_Click);
            // 
            // KostenBtn
            // 
            this.KostenBtn.Location = new System.Drawing.Point(693, 177);
            this.KostenBtn.Name = "KostenBtn";
            this.KostenBtn.Size = new System.Drawing.Size(200, 200);
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
            this.lblTitle.Location = new System.Drawing.Point(875, 9);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(190, 31);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Finance | Main";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pbBlack
            // 
            this.pbBlack.BackColor = System.Drawing.SystemColors.WindowText;
            this.pbBlack.Location = new System.Drawing.Point(-385, 0);
            this.pbBlack.Margin = new System.Windows.Forms.Padding(4);
            this.pbBlack.Name = "pbBlack";
            this.pbBlack.Size = new System.Drawing.Size(1527, 53);
            this.pbBlack.TabIndex = 7;
            this.pbBlack.TabStop = false;
            // 
            // FinanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 593);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbBlack);
            this.Controls.Add(this.KostenBtn);
            this.Controls.Add(this.LeaseBtn);
            this.Controls.Add(this.FacturatieBtn);
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