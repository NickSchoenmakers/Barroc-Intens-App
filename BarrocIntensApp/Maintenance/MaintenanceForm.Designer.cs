namespace BarrocIntensApp
{
    partial class MaintenanceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaintenanceForm));
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pbBlack = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.BtnCalendar = new BarrocIntensApp.RoundButton();
            this.BtnStoringen = new BarrocIntensApp.RoundButton();
            this.BtnOnderdelen = new BarrocIntensApp.RoundButton();
            this.btnOfferte = new BarrocIntensApp.RoundButton();
            this.lblDepartmentPart = new System.Windows.Forms.Label();
            this.BtnManager = new BarrocIntensApp.RoundButton();
            this.roundButton1 = new BarrocIntensApp.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlack)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBlack
            // 
            this.pbBlack.BackColor = System.Drawing.SystemColors.WindowText;
            this.pbBlack.Location = new System.Drawing.Point(0, 0);
            this.pbBlack.Name = "pbBlack";
            this.pbBlack.Size = new System.Drawing.Size(1145, 43);
            this.pbBlack.TabIndex = 6;
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
            this.lblTitle.Text = "Maintenance | Name";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtnCalendar
            // 
            this.BtnCalendar.BackColor = System.Drawing.Color.Black;
            this.BtnCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalendar.ForeColor = System.Drawing.Color.White;
            this.BtnCalendar.Location = new System.Drawing.Point(467, 63);
            this.BtnCalendar.Name = "BtnCalendar";
            this.BtnCalendar.Size = new System.Drawing.Size(200, 200);
            this.BtnCalendar.TabIndex = 5;
            this.BtnCalendar.Text = "Onderhoud";
            this.BtnCalendar.UseVisualStyleBackColor = false;
            this.BtnCalendar.Click += new System.EventHandler(this.BtnOnderhoud_Click_1);
            // 
            // BtnStoringen
            // 
            this.BtnStoringen.BackColor = System.Drawing.Color.Black;
            this.BtnStoringen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStoringen.ForeColor = System.Drawing.Color.White;
            this.BtnStoringen.Location = new System.Drawing.Point(237, 63);
            this.BtnStoringen.Name = "BtnStoringen";
            this.BtnStoringen.Size = new System.Drawing.Size(200, 200);
            this.BtnStoringen.TabIndex = 4;
            this.BtnStoringen.Text = "Storing";
            this.BtnStoringen.UseVisualStyleBackColor = false;
            this.BtnStoringen.Click += new System.EventHandler(this.BtnStoringen_Click);
            // 
            // BtnOnderdelen
            // 
            this.BtnOnderdelen.BackColor = System.Drawing.Color.Black;
            this.BtnOnderdelen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOnderdelen.ForeColor = System.Drawing.Color.White;
            this.BtnOnderdelen.Location = new System.Drawing.Point(12, 63);
            this.BtnOnderdelen.Name = "BtnOnderdelen";
            this.BtnOnderdelen.Size = new System.Drawing.Size(200, 200);
            this.BtnOnderdelen.TabIndex = 3;
            this.BtnOnderdelen.Text = "Onderdelen";
            this.BtnOnderdelen.UseVisualStyleBackColor = false;
            this.BtnOnderdelen.Click += new System.EventHandler(this.BtnOnderdelen_Click);
            // 
            // btnOfferte
            // 
            this.btnOfferte.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnOfferte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOfferte.ForeColor = System.Drawing.Color.White;
            this.btnOfferte.Location = new System.Drawing.Point(301, 207);
            this.btnOfferte.Margin = new System.Windows.Forms.Padding(2);
            this.btnOfferte.Name = "btnOfferte";
            this.btnOfferte.Size = new System.Drawing.Size(170, 168);
            this.btnOfferte.TabIndex = 6;
            this.btnOfferte.Text = "Offerte formulier";
            this.btnOfferte.UseVisualStyleBackColor = false;
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
            // BtnManager
            // 
            this.BtnManager.BackColor = System.Drawing.Color.Black;
            this.BtnManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnManager.ForeColor = System.Drawing.Color.White;
            this.BtnManager.Location = new System.Drawing.Point(694, 63);
            this.BtnManager.Name = "BtnManager";
            this.BtnManager.Size = new System.Drawing.Size(200, 200);
            this.BtnManager.TabIndex = 36;
            this.BtnManager.Text = "Onderhoud inplannen";
            this.BtnManager.UseVisualStyleBackColor = false;
            this.BtnManager.Visible = false;
            this.BtnManager.Click += new System.EventHandler(this.BtnManager_Click);
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.roundButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.roundButton1.Location = new System.Drawing.Point(964, 63);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(168, 70);
            this.roundButton1.TabIndex = 42;
            this.roundButton1.Text = "Logout";
            this.roundButton1.UseVisualStyleBackColor = false;
            this.roundButton1.Click += new System.EventHandler(this.roundButton1_Click);
            // 
            // MaintenanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1144, 601);
            this.Controls.Add(this.roundButton1);
            this.Controls.Add(this.BtnManager);
            this.Controls.Add(this.lblDepartmentPart);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbBlack);
            this.Controls.Add(this.BtnCalendar);
            this.Controls.Add(this.BtnStoringen);
            this.Controls.Add(this.BtnOnderdelen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MaintenanceForm";
            this.Text = "MaintencanceForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbBlack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private RoundButton btnOfferte;
        private RoundButton BtnOnderdelen;
        private RoundButton BtnStoringen;
        private RoundButton BtnCalendar;
        private System.Windows.Forms.PictureBox pbBlack;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDepartmentPart;
        private RoundButton BtnManager;
        private RoundButton roundButton1;
    }
}