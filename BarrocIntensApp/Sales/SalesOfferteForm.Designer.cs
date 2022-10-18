namespace BarrocIntensApp
{
    partial class SalesOfferteForm
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
            this.lblDepartmentPart = new System.Windows.Forms.Label();
            this.pbBlack = new System.Windows.Forms.PictureBox();
            this.btnBackNotes = new BarrocIntensApp.RoundButton();
            this.BtnSendMail = new BarrocIntensApp.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlack)).BeginInit();
            this.SuspendLayout();
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
            this.lblTitle.TabIndex = 36;
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
            this.lblDepartmentPart.TabIndex = 37;
            this.lblDepartmentPart.Text = "Offerte aanmaken";
            this.lblDepartmentPart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbBlack
            // 
            this.pbBlack.BackColor = System.Drawing.SystemColors.WindowText;
            this.pbBlack.Location = new System.Drawing.Point(0, 0);
            this.pbBlack.Name = "pbBlack";
            this.pbBlack.Size = new System.Drawing.Size(1146, 43);
            this.pbBlack.TabIndex = 5;
            this.pbBlack.TabStop = false;
            // 
            // btnBackNotes
            // 
            this.btnBackNotes.BackColor = System.Drawing.Color.Black;
            this.btnBackNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackNotes.ForeColor = System.Drawing.Color.White;
            this.btnBackNotes.Location = new System.Drawing.Point(12, 49);
            this.btnBackNotes.Name = "btnBackNotes";
            this.btnBackNotes.Size = new System.Drawing.Size(88, 50);
            this.btnBackNotes.TabIndex = 42;
            this.btnBackNotes.Text = "←";
            this.btnBackNotes.UseVisualStyleBackColor = false;
            this.btnBackNotes.Click += new System.EventHandler(this.btnBackNotes_Click);
            // 
            // BtnSendMail
            // 
            this.BtnSendMail.Location = new System.Drawing.Point(784, 388);
            this.BtnSendMail.Name = "BtnSendMail";
            this.BtnSendMail.Size = new System.Drawing.Size(348, 201);
            this.BtnSendMail.TabIndex = 43;
            this.BtnSendMail.Text = "Send mail";
            this.BtnSendMail.UseVisualStyleBackColor = true;
            this.BtnSendMail.Click += new System.EventHandler(this.BtnSendMail_Click);
            // 
            // SalesOfferteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 601);
            this.Controls.Add(this.BtnSendMail);
            this.Controls.Add(this.btnBackNotes);
            this.Controls.Add(this.lblDepartmentPart);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbBlack);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SalesOfferteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesOfferteForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbBlack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbBlack;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDepartmentPart;
        private RoundButton btnBackNotes;
        private RoundButton BtnSendMail;
    }
}