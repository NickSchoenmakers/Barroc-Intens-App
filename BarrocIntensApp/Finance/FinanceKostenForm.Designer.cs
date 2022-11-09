namespace BarrocIntensApp
{
    partial class FinanceKostenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinanceKostenForm));
            this.pbBlack = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDepartmentPart = new System.Windows.Forms.Label();
            this.lblIncome = new System.Windows.Forms.Label();
            this.lblspending = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.roundButton1 = new BarrocIntensApp.RoundButton();
            this.roundButton2 = new BarrocIntensApp.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlack)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBlack
            // 
            this.pbBlack.BackColor = System.Drawing.SystemColors.WindowText;
            this.pbBlack.Location = new System.Drawing.Point(-288, 0);
            this.pbBlack.Name = "pbBlack";
            this.pbBlack.Size = new System.Drawing.Size(1433, 43);
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
            this.lblDepartmentPart.Text = "Kostenoverzicht";
            this.lblDepartmentPart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblIncome
            // 
            this.lblIncome.AutoSize = true;
            this.lblIncome.Location = new System.Drawing.Point(318, 294);
            this.lblIncome.Name = "lblIncome";
            this.lblIncome.Size = new System.Drawing.Size(47, 13);
            this.lblIncome.TabIndex = 45;
            this.lblIncome.Text = "inkomen";
            // 
            // lblspending
            // 
            this.lblspending.AutoSize = true;
            this.lblspending.Location = new System.Drawing.Point(871, 294);
            this.lblspending.Name = "lblspending";
            this.lblspending.Size = new System.Drawing.Size(48, 13);
            this.lblspending.TabIndex = 47;
            this.lblspending.Text = "uitgaven";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(555, 294);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(33, 13);
            this.lblTotal.TabIndex = 48;
            this.lblTotal.Text = "totaal";
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
            // roundButton2
            // 
            this.roundButton2.BackColor = System.Drawing.Color.Black;
            this.roundButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton2.ForeColor = System.Drawing.Color.White;
            this.roundButton2.Location = new System.Drawing.Point(12, 49);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.Size = new System.Drawing.Size(88, 50);
            this.roundButton2.TabIndex = 42;
            this.roundButton2.Text = "←";
            this.roundButton2.UseVisualStyleBackColor = false;
            this.roundButton2.Click += new System.EventHandler(this.roundButton2_Click);
            // 
            // FinanceKostenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 601);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblspending);
            this.Controls.Add(this.lblIncome);
            this.Controls.Add(this.roundButton1);
            this.Controls.Add(this.roundButton2);
            this.Controls.Add(this.lblDepartmentPart);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbBlack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FinanceKostenForm";
            this.Text = "KostenForm1";
            this.Load += new System.EventHandler(this.FinanceKostenForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBlack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbBlack;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDepartmentPart;
        private RoundButton roundButton2;
        private RoundButton roundButton1;
        private System.Windows.Forms.Label lblIncome;
        private System.Windows.Forms.Label lblspending;
        private System.Windows.Forms.Label lblTotal;
    }
}