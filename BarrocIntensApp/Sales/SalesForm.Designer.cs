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
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbBlack = new System.Windows.Forms.PictureBox();
            this.btnOfferte = new BarrocIntensApp.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlack)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Black;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(953, 8);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(175, 31);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Sales | Name";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pbBlack
            // 
            this.pbBlack.BackColor = System.Drawing.SystemColors.WindowText;
            this.pbBlack.Location = new System.Drawing.Point(-6, -1);
            this.pbBlack.Margin = new System.Windows.Forms.Padding(4);
            this.pbBlack.Name = "pbBlack";
            this.pbBlack.Size = new System.Drawing.Size(1148, 53);
            this.pbBlack.TabIndex = 3;
            this.pbBlack.TabStop = false;
            // 
            // btnOfferte
            // 
            this.btnOfferte.BackColor = System.Drawing.Color.Black;
            this.btnOfferte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOfferte.ForeColor = System.Drawing.Color.White;
            this.btnOfferte.Location = new System.Drawing.Point(24, 73);
            this.btnOfferte.Name = "btnOfferte";
            this.btnOfferte.Size = new System.Drawing.Size(226, 207);
            this.btnOfferte.TabIndex = 5;
            this.btnOfferte.Text = "Offerte formulier";
            this.btnOfferte.UseVisualStyleBackColor = false;
            this.btnOfferte.Click += new System.EventHandler(this.btnOfferte_Click);
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 593);
            this.Controls.Add(this.btnOfferte);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbBlack);
            this.Name = "SalesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbBlack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbBlack;
        private RoundButton btnOfferte;
    }
}