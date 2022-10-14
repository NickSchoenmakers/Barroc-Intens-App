namespace BarrocIntensApp
{
    partial class MaintenanceOnderhoudForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaintenanceOnderhoudForm));
            this.pbBlack = new System.Windows.Forms.PictureBox();
            this.BtnReturnStoringen = new BarrocIntensApp.RoundButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDepartmentPart = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlack)).BeginInit();
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
            // BtnReturnStoringen
            // 
            this.BtnReturnStoringen.BackColor = System.Drawing.Color.Black;
            this.BtnReturnStoringen.ForeColor = System.Drawing.Color.White;
            this.BtnReturnStoringen.Location = new System.Drawing.Point(1, 48);
            this.BtnReturnStoringen.Name = "BtnReturnStoringen";
            this.BtnReturnStoringen.Size = new System.Drawing.Size(124, 37);
            this.BtnReturnStoringen.TabIndex = 8;
            this.BtnReturnStoringen.Text = "Terug";
            this.BtnReturnStoringen.UseVisualStyleBackColor = false;
            this.BtnReturnStoringen.Click += new System.EventHandler(this.BtnReturnStoringen_Click);
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
            this.lblTitle.TabIndex = 35;
            this.lblTitle.Text = "Maintenance | Name";
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
            this.lblDepartmentPart.TabIndex = 36;
            this.lblDepartmentPart.Text = "Onderhoud inplannen";
            this.lblDepartmentPart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MaintenanceOnderhoudForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 601);
            this.Controls.Add(this.lblDepartmentPart);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.BtnReturnStoringen);
            this.Controls.Add(this.pbBlack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MaintenanceOnderhoudForm";
            this.Text = "MaintenanceOnderhoudForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbBlack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbBlack;
        private RoundButton BtnReturnStoringen;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDepartmentPart;
    }
}