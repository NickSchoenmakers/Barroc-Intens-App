namespace BarrocIntensApp
{
    partial class SalesForm
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
            this.btnOfferte = new BarrocIntensApp.RoundButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDepartmentPart = new System.Windows.Forms.Label();
            this.btnNotities = new BarrocIntensApp.RoundButton();
            this.roundButton1 = new BarrocIntensApp.RoundButton();
            this.pbBlack = new System.Windows.Forms.PictureBox();
            this.btnCreateCustomerform = new BarrocIntensApp.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlack)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOfferte
            // 
            this.btnOfferte.BackColor = System.Drawing.Color.Black;
            this.btnOfferte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOfferte.ForeColor = System.Drawing.Color.White;
            this.btnOfferte.Location = new System.Drawing.Point(18, 59);
            this.btnOfferte.Margin = new System.Windows.Forms.Padding(2);
            this.btnOfferte.Name = "btnOfferte";
            this.btnOfferte.Size = new System.Drawing.Size(170, 168);
            this.btnOfferte.TabIndex = 5;
            this.btnOfferte.Text = "Offerte formulier";
            this.btnOfferte.UseVisualStyleBackColor = false;
            this.btnOfferte.Click += new System.EventHandler(this.btnOfferte_Click);
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
            this.lblTitle.Text = "Sales | Name";
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
            this.lblDepartmentPart.Text = "Dashboard";
            this.lblDepartmentPart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnNotities
            // 
            this.btnNotities.BackColor = System.Drawing.Color.Black;
            this.btnNotities.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotities.ForeColor = System.Drawing.Color.White;
            this.btnNotities.Location = new System.Drawing.Point(218, 59);
            this.btnNotities.Margin = new System.Windows.Forms.Padding(2);
            this.btnNotities.Name = "btnNotities";
            this.btnNotities.Size = new System.Drawing.Size(170, 168);
            this.btnNotities.TabIndex = 37;
            this.btnNotities.Text = "Notities";
            this.btnNotities.UseVisualStyleBackColor = false;
            this.btnNotities.Click += new System.EventHandler(this.btnNotities_Click);
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.roundButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.roundButton1.Location = new System.Drawing.Point(964, 49);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(168, 70);
            this.roundButton1.TabIndex = 43;
            this.roundButton1.Text = "Uitloggen";
            this.roundButton1.UseVisualStyleBackColor = false;
            this.roundButton1.Click += new System.EventHandler(this.roundButton1_Click);
            // 
            // pbBlack
            // 
            this.pbBlack.BackColor = System.Drawing.SystemColors.WindowText;
            this.pbBlack.Location = new System.Drawing.Point(-1, 0);
            this.pbBlack.Name = "pbBlack";
            this.pbBlack.Size = new System.Drawing.Size(1146, 43);
            this.pbBlack.TabIndex = 3;
            this.pbBlack.TabStop = false;
            // 
            // btnCreateCustomerform
            // 
            this.btnCreateCustomerform.BackColor = System.Drawing.Color.Black;
            this.btnCreateCustomerform.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateCustomerform.ForeColor = System.Drawing.Color.White;
            this.btnCreateCustomerform.Location = new System.Drawing.Point(414, 59);
            this.btnCreateCustomerform.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateCustomerform.Name = "btnCreateCustomerform";
            this.btnCreateCustomerform.Size = new System.Drawing.Size(170, 168);
            this.btnCreateCustomerform.TabIndex = 44;
            this.btnCreateCustomerform.Text = "Klant aanmaken";
            this.btnCreateCustomerform.UseVisualStyleBackColor = false;
            this.btnCreateCustomerform.Click += new System.EventHandler(this.btnCreateCustomerform_Click);
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 601);
            this.Controls.Add(this.btnCreateCustomerform);
            this.Controls.Add(this.roundButton1);
            this.Controls.Add(this.btnNotities);
            this.Controls.Add(this.lblDepartmentPart);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnOfferte);
            this.Controls.Add(this.pbBlack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "SalesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbBlack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbBlack;
        private RoundButton btnOfferte;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDepartmentPart;
        private RoundButton btnNotities;
        private RoundButton roundButton1;
        private RoundButton btnCreateCustomerform;
    }
}