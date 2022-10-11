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
            this.btnMagazijn = new System.Windows.Forms.Button();
            this.pbBlack = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
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
            this.btnMagazijn.Click += new System.EventHandler(this.btnMagazijn_Click);
            // 
            // pbBlack
            // 
            this.pbBlack.BackColor = System.Drawing.SystemColors.WindowText;
            this.pbBlack.Location = new System.Drawing.Point(-2, -1);
            this.pbBlack.Name = "pbBlack";
            this.pbBlack.Size = new System.Drawing.Size(1145, 43);
            this.pbBlack.TabIndex = 1;
            this.pbBlack.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Black;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(983, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(149, 25);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Inkoop | Name";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // InkoopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 601);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbBlack);
            this.Controls.Add(this.btnMagazijn);
            this.Name = "InkoopForm";
            this.Text = "Inkoop";
            ((System.ComponentModel.ISupportInitialize)(this.pbBlack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMagazijn;
        private PictureBox pbBlack;
        private Label lblTitle;
    }
}