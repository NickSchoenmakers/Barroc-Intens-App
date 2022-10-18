﻿namespace BarrocIntensApp.Sales
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
            this.lblDepartmentPart = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lvNotes = new System.Windows.Forms.ListView();
            this.pbBlack = new System.Windows.Forms.PictureBox();
            this.btnBackNotes = new BarrocIntensApp.RoundButton();
            this.txbNote = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbNoteSelected = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlack)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDepartmentPart
            // 
            this.lblDepartmentPart.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDepartmentPart.BackColor = System.Drawing.Color.Black;
            this.lblDepartmentPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentPart.ForeColor = System.Drawing.Color.White;
            this.lblDepartmentPart.Location = new System.Drawing.Point(12, 8);
            this.lblDepartmentPart.Name = "lblDepartmentPart";
            this.lblDepartmentPart.Size = new System.Drawing.Size(405, 25);
            this.lblDepartmentPart.TabIndex = 39;
            this.lblDepartmentPart.Text = "Notities";
            this.lblDepartmentPart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTitle.BackColor = System.Drawing.Color.Black;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTitle.Location = new System.Drawing.Point(727, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(405, 25);
            this.lblTitle.TabIndex = 38;
            this.lblTitle.Text = "Sales | Name";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lvNotes
            // 
            this.lvNotes.GridLines = true;
            this.lvNotes.HideSelection = false;
            this.lvNotes.Location = new System.Drawing.Point(17, 104);
            this.lvNotes.MultiSelect = false;
            this.lvNotes.Name = "lvNotes";
            this.lvNotes.ShowItemToolTips = true;
            this.lvNotes.Size = new System.Drawing.Size(483, 485);
            this.lvNotes.TabIndex = 40;
            this.lvNotes.UseCompatibleStateImageBehavior = false;
            this.lvNotes.View = System.Windows.Forms.View.Tile;
            this.lvNotes.SelectedIndexChanged += new System.EventHandler(this.lvNotes_SelectedIndexChanged);
            // 
            // pbBlack
            // 
            this.pbBlack.BackColor = System.Drawing.SystemColors.WindowText;
            this.pbBlack.Location = new System.Drawing.Point(-1, -1);
            this.pbBlack.Name = "pbBlack";
            this.pbBlack.Size = new System.Drawing.Size(1146, 43);
            this.pbBlack.TabIndex = 37;
            this.pbBlack.TabStop = false;
            // 
            // btnBackNotes
            // 
            this.btnBackNotes.BackColor = System.Drawing.Color.Black;
            this.btnBackNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackNotes.ForeColor = System.Drawing.Color.White;
            this.btnBackNotes.Location = new System.Drawing.Point(12, 48);
            this.btnBackNotes.Name = "btnBackNotes";
            this.btnBackNotes.Size = new System.Drawing.Size(88, 50);
            this.btnBackNotes.TabIndex = 41;
            this.btnBackNotes.Text = "←";
            this.btnBackNotes.UseVisualStyleBackColor = false;
            this.btnBackNotes.Click += new System.EventHandler(this.btnBackNotes_Click);
            // 
            // txbNote
            // 
            this.txbNote.Location = new System.Drawing.Point(525, 104);
            this.txbNote.Multiline = true;
            this.txbNote.Name = "txbNote";
            this.txbNote.Size = new System.Drawing.Size(594, 140);
            this.txbNote.TabIndex = 42;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1019, 250);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 46);
            this.btnSave.TabIndex = 43;
            this.btnSave.Text = "Opslaan";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbNoteSelected
            // 
            this.lbNoteSelected.Location = new System.Drawing.Point(525, 370);
            this.lbNoteSelected.Name = "lbNoteSelected";
            this.lbNoteSelected.Size = new System.Drawing.Size(594, 192);
            this.lbNoteSelected.TabIndex = 44;
            this.lbNoteSelected.Text = "Selecteer een notitie";
            // 
            // SalesNotesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 601);
            this.Controls.Add(this.lbNoteSelected);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txbNote);
            this.Controls.Add(this.btnBackNotes);
            this.Controls.Add(this.lvNotes);
            this.Controls.Add(this.lblDepartmentPart);
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

        private System.Windows.Forms.Label lblDepartmentPart;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbBlack;
        private System.Windows.Forms.ListView lvNotes;
        private RoundButton btnBackNotes;
        private System.Windows.Forms.TextBox txbNote;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbNoteSelected;
    }
}