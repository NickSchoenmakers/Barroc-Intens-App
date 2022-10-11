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
            this.SuspendLayout();
            // 
            // btnMagazijn
            // 
            this.btnMagazijn.Location = new System.Drawing.Point(12, 74);
            this.btnMagazijn.Name = "btnMagazijn";
            this.btnMagazijn.Size = new System.Drawing.Size(177, 170);
            this.btnMagazijn.TabIndex = 0;
            this.btnMagazijn.Text = "Magazijn";
            this.btnMagazijn.UseVisualStyleBackColor = true;
            this.btnMagazijn.Click += new System.EventHandler(this.button1_Click);
            // 
            // InkoopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMagazijn);
            this.Name = "InkoopForm";
            this.Text = "Inkoop";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMagazijn;
    }
}