namespace BarrocIntensApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.btnLogin = new System.Windows.Forms.Button();
            this.txbUserPassword = new System.Windows.Forms.TextBox();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.pbBlack = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pxbBigLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxbBigLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(14, 113);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(229, 55);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txbUserPassword
            // 
            this.txbUserPassword.Location = new System.Drawing.Point(84, 86);
            this.txbUserPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbUserPassword.Name = "txbUserPassword";
            this.txbUserPassword.Size = new System.Drawing.Size(159, 22);
            this.txbUserPassword.TabIndex = 99;
            // 
            // txbUserName
            // 
            this.txbUserName.Location = new System.Drawing.Point(84, 58);
            this.txbUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(159, 22);
            this.txbUserName.TabIndex = 98;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(11, 89);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(66, 16);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "password";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(11, 61);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(67, 16);
            this.lblUserName.TabIndex = 8;
            this.lblUserName.Text = "username";
            // 
            // pbBlack
            // 
            this.pbBlack.BackColor = System.Drawing.SystemColors.WindowText;
            this.pbBlack.Location = new System.Drawing.Point(-3, -1);
            this.pbBlack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbBlack.Name = "pbBlack";
            this.pbBlack.Size = new System.Drawing.Size(1527, 53);
            this.pbBlack.TabIndex = 100;
            this.pbBlack.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Black;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(352, 9);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(123, 25);
            this.lblTitle.TabIndex = 101;
            this.lblTitle.Text = "Inlogpagina";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pxbBigLogo
            // 
            this.pxbBigLogo.Image = global::BarrocIntensApp.Properties.Resources.Logo6_groot;
            this.pxbBigLogo.Location = new System.Drawing.Point(249, 61);
            this.pxbBigLogo.Name = "pxbBigLogo";
            this.pxbBigLogo.Size = new System.Drawing.Size(235, 179);
            this.pxbBigLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pxbBigLogo.TabIndex = 102;
            this.pxbBigLogo.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 246);
            this.Controls.Add(this.pxbBigLogo);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbBlack);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txbUserName);
            this.Controls.Add(this.txbUserPassword);
            this.Controls.Add(this.btnLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBlack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxbBigLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txbUserPassword;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.PictureBox pbBlack;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pxbBigLogo;
    }
}

