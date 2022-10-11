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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.BtnOnderdelen = new System.Windows.Forms.Button();
            this.BtnStoringen = new System.Windows.Forms.Button();
            this.BtnOnderhoud = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnOnderdelen
            // 
            this.BtnOnderdelen.Location = new System.Drawing.Point(82, 192);
            this.BtnOnderdelen.Name = "BtnOnderdelen";
            this.BtnOnderdelen.Size = new System.Drawing.Size(200, 200);
            this.BtnOnderdelen.TabIndex = 0;
            this.BtnOnderdelen.Text = "Onderdelen";
            this.BtnOnderdelen.UseVisualStyleBackColor = true;
            this.BtnOnderdelen.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnStoringen
            // 
            this.BtnStoringen.Location = new System.Drawing.Point(476, 192);
            this.BtnStoringen.Name = "BtnStoringen";
            this.BtnStoringen.Size = new System.Drawing.Size(200, 200);
            this.BtnStoringen.TabIndex = 1;
            this.BtnStoringen.Text = "Storingen";
            this.BtnStoringen.UseVisualStyleBackColor = true;
            this.BtnStoringen.Click += new System.EventHandler(this.BtnStoringen_Click);
            // 
            // BtnOnderhoud
            // 
            this.BtnOnderhoud.Location = new System.Drawing.Point(860, 192);
            this.BtnOnderhoud.Name = "BtnOnderhoud";
            this.BtnOnderhoud.Size = new System.Drawing.Size(200, 200);
            this.BtnOnderhoud.TabIndex = 2;
            this.BtnOnderhoud.Text = "Onderhoud";
            this.BtnOnderhoud.UseVisualStyleBackColor = true;
            this.BtnOnderhoud.Click += new System.EventHandler(this.BtnOnderhoud_Click);
            // 
            // MaintencanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 601);
            this.Controls.Add(this.BtnOnderhoud);
            this.Controls.Add(this.BtnStoringen);
            this.Controls.Add(this.BtnOnderdelen);
            this.Name = "MaintencanceForm";
            this.Text = "MaintencanceForm";
            this.Load += new System.EventHandler(this.MaintencanceForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button BtnOnderdelen;
        private System.Windows.Forms.Button BtnStoringen;
        private System.Windows.Forms.Button BtnOnderhoud;
    }
}