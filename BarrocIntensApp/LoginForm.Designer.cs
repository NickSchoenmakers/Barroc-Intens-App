﻿namespace BarrocIntensApp
{
    partial class LoginForm
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
            this.btnInkoop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInkoop
            // 
            this.btnInkoop.Location = new System.Drawing.Point(25, 320);
            this.btnInkoop.Name = "btnInkoop";
            this.btnInkoop.Size = new System.Drawing.Size(75, 23);
            this.btnInkoop.TabIndex = 0;
            this.btnInkoop.Text = "Inkoop";
            this.btnInkoop.UseVisualStyleBackColor = true;
            this.btnInkoop.Click += new System.EventHandler(this.btnInkoop_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnInkoop);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInkoop;
    }
}

