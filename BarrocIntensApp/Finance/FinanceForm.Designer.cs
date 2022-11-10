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
            this.pbBlack = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDepartmentPart = new System.Windows.Forms.Label();
            this.roundButton1 = new BarrocIntensApp.RoundButton();
            this.btnFacturatie = new BarrocIntensApp.RoundButton();
            this.btnLease = new BarrocIntensApp.RoundButton();
            this.btnKosten = new BarrocIntensApp.RoundButton();
            this.btnBKR = new BarrocIntensApp.RoundButton();
            this.btnFacturatieOverzicht = new BarrocIntensApp.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlack)).BeginInit();
            this.SuspendLayout();
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
            // btnFacturatie
            // 
            this.btnFacturatie.BackColor = System.Drawing.Color.Black;
            this.btnFacturatie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturatie.ForeColor = System.Drawing.Color.White;
            this.btnFacturatie.Location = new System.Drawing.Point(17, 67);
            this.btnFacturatie.Name = "btnFacturatie";
            this.btnFacturatie.Size = new System.Drawing.Size(200, 200);
            this.btnFacturatie.TabIndex = 44;
            this.btnFacturatie.Text = "Facturatie";
            this.btnFacturatie.UseVisualStyleBackColor = false;
            this.btnFacturatie.Click += new System.EventHandler(this.btnFacturatie_Click);
            // 
            // btnLease
            // 
            this.btnLease.BackColor = System.Drawing.Color.Black;
            this.btnLease.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLease.ForeColor = System.Drawing.Color.White;
            this.btnLease.Location = new System.Drawing.Point(240, 67);
            this.btnLease.Name = "btnLease";
            this.btnLease.Size = new System.Drawing.Size(200, 200);
            this.btnLease.TabIndex = 45;
            this.btnLease.Text = "Lease contract";
            this.btnLease.UseVisualStyleBackColor = false;
            this.btnLease.Click += new System.EventHandler(this.btnLease_Click);
            // 
            // btnKosten
            // 
            this.btnKosten.BackColor = System.Drawing.Color.Black;
            this.btnKosten.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKosten.ForeColor = System.Drawing.Color.White;
            this.btnKosten.Location = new System.Drawing.Point(469, 67);
            this.btnKosten.Name = "btnKosten";
            this.btnKosten.Size = new System.Drawing.Size(200, 200);
            this.btnKosten.TabIndex = 46;
            this.btnKosten.Text = "Kostenoverzicht";
            this.btnKosten.UseVisualStyleBackColor = false;
            this.btnKosten.Click += new System.EventHandler(this.btnKosten_Click);
            // 
            // btnBKR
            // 
            this.btnBKR.BackColor = System.Drawing.Color.Black;
            this.btnBKR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBKR.ForeColor = System.Drawing.Color.White;
            this.btnBKR.Location = new System.Drawing.Point(702, 67);
            this.btnBKR.Name = "btnBKR";
            this.btnBKR.Size = new System.Drawing.Size(200, 200);
            this.btnBKR.TabIndex = 47;
            this.btnBKR.Text = "BKR-checks";
            this.btnBKR.UseVisualStyleBackColor = false;
            this.btnBKR.Click += new System.EventHandler(this.btnBKR_Click);
            // 
            // btnFacturatieOverzicht
            // 
            this.btnFacturatieOverzicht.BackColor = System.Drawing.Color.Black;
            this.btnFacturatieOverzicht.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturatieOverzicht.ForeColor = System.Drawing.Color.White;
            this.btnFacturatieOverzicht.Location = new System.Drawing.Point(17, 300);
            this.btnFacturatieOverzicht.Name = "btnFacturatieOverzicht";
            this.btnFacturatieOverzicht.Size = new System.Drawing.Size(200, 200);
            this.btnFacturatieOverzicht.TabIndex = 48;
            this.btnFacturatieOverzicht.Text = "Facturatie overzicht";
            this.btnFacturatieOverzicht.UseVisualStyleBackColor = false;
            this.btnFacturatieOverzicht.Click += new System.EventHandler(this.btnFacturatieOverzicht_Click);
            // 
            // FinanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 601);
            this.Controls.Add(this.btnFacturatieOverzicht);
            this.Controls.Add(this.btnBKR);
            this.Controls.Add(this.btnKosten);
            this.Controls.Add(this.btnLease);
            this.Controls.Add(this.btnFacturatie);
            this.Controls.Add(this.roundButton1);
            this.Controls.Add(this.lblDepartmentPart);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbBlack);
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
        private System.Windows.Forms.PictureBox pbBlack;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDepartmentPart;
        private RoundButton roundButton1;
        private RoundButton btnFacturatie;
        private RoundButton btnLease;
        private RoundButton btnKosten;
        private RoundButton btnBKR;
        private RoundButton btnFacturatieOverzicht;
    }
}