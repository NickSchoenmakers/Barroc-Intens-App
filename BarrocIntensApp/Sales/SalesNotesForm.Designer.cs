namespace BarrocIntensApp.Sales
{
    partial class SalesNotesForm
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
            this.btnBackNotes = new BarrocIntensApp.RoundButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lvNotes = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlack)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Black;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(993, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(139, 25);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Sales | Name";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pbBlack
            // 
            this.pbBlack.BackColor = System.Drawing.SystemColors.WindowText;
            this.pbBlack.Location = new System.Drawing.Point(0, 0);
            this.pbBlack.Name = "pbBlack";
            this.pbBlack.Size = new System.Drawing.Size(1146, 43);
            this.pbBlack.TabIndex = 7;
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
            this.btnBackNotes.TabIndex = 9;
            this.btnBackNotes.Text = "←";
            this.btnBackNotes.UseVisualStyleBackColor = false;
            this.btnBackNotes.Click += new System.EventHandler(this.btnBackNotes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 33);
            this.label1.TabIndex = 10;
            this.label1.Text = "Notes";
            // 
            // lvNotes
            // 
            this.lvNotes.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.lvNotes.AutoArrange = false;
            this.lvNotes.HideSelection = false;
            this.lvNotes.Location = new System.Drawing.Point(30, 164);
            this.lvNotes.Name = "lvNotes";
            this.lvNotes.Size = new System.Drawing.Size(472, 410);
            this.lvNotes.TabIndex = 11;
            this.lvNotes.TileSize = new System.Drawing.Size(100, 10);
            this.lvNotes.UseCompatibleStateImageBehavior = false;
            // 
            // SalesNotesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 601);
            this.Controls.Add(this.lvNotes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBackNotes);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbBlack);
            this.Name = "SalesNotesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesNotesForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbBlack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbBlack;
        private RoundButton btnBackNotes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvNotes;
    }
}