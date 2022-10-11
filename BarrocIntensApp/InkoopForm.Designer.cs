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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlack)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMagazijn
            // 
            this.btnMagazijn.Location = new System.Drawing.Point(16, 78);
            this.btnMagazijn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMagazijn.Name = "btnMagazijn";
            this.btnMagazijn.Size = new System.Drawing.Size(236, 209);
            this.btnMagazijn.TabIndex = 0;
            this.btnMagazijn.Text = "Magazijn";
            this.btnMagazijn.UseVisualStyleBackColor = true;
            // 
            // pbBlack
            // 
            this.pbBlack.BackColor = System.Drawing.SystemColors.WindowText;
            this.pbBlack.Location = new System.Drawing.Point(-3, -1);
            this.pbBlack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbBlack.Name = "pbBlack";
            this.pbBlack.Size = new System.Drawing.Size(1069, 53);
            this.pbBlack.TabIndex = 1;
            this.pbBlack.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Black;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(852, 10);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(189, 31);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Inkoop | Name";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // InkoopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbBlack);
            this.Controls.Add(this.btnMagazijn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}