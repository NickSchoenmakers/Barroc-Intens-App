using System.Drawing;
using System.Windows.Forms;

namespace BarrocIntensApp
{
    partial class InkoopForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InkoopForm));
            this.btnMagazijn = new System.Windows.Forms.Button();
            this.pbBlack = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDepartmentPart = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlack)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMagazijn
            // 
            this.btnMagazijn.Location = new System.Drawing.Point(12, 63);
            this.btnMagazijn.Name = "btnMagazijn";
            this.btnMagazijn.Size = new System.Drawing.Size(177, 170);
            this.btnMagazijn.TabIndex = 0;
            this.btnMagazijn.Text = "Magazijn";
            this.btnMagazijn.UseVisualStyleBackColor = true;
            this.btnMagazijn.Click += new System.EventHandler(this.btnMagazijn_Click_1);
            // 
            // pbBlack
            // 
            this.pbBlack.BackColor = System.Drawing.SystemColors.WindowText;
            this.pbBlack.Location = new System.Drawing.Point(0, -1);
            this.pbBlack.Name = "pbBlack";
            this.pbBlack.Size = new System.Drawing.Size(1144, 43);
            this.pbBlack.TabIndex = 1;
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
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Inkoop | Name";
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
            // InkoopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 601);
            this.Controls.Add(this.lblDepartmentPart);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbBlack);
            this.Controls.Add(this.btnMagazijn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InkoopForm";
            this.Text = "Inkoop";
            ((System.ComponentModel.ISupportInitialize)(this.pbBlack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMagazijn;
        private PictureBox pbBlack;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label lblTitle;
        private Label lblDepartmentPart;
    }
}