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
            this.btnInkoop = new System.Windows.Forms.Button();
            this.btnfinance = new System.Windows.Forms.Button();
            this.btnmaintenance = new System.Windows.Forms.Button();
            this.btnsales = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txbUserPassword = new System.Windows.Forms.TextBox();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.pbBlack = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlack)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInkoop
            // 
            this.btnInkoop.Location = new System.Drawing.Point(13, 172);
            this.btnInkoop.Margin = new System.Windows.Forms.Padding(4);
            this.btnInkoop.Name = "btnInkoop";
            this.btnInkoop.Size = new System.Drawing.Size(200, 200);
            this.btnInkoop.TabIndex = 0;
            this.btnInkoop.Text = "Inkoop";
            this.btnInkoop.UseVisualStyleBackColor = true;
            this.btnInkoop.Click += new System.EventHandler(this.btnInkoop_Click);
            // 
            // btnfinance
            // 
            this.btnfinance.Location = new System.Drawing.Point(221, 171);
            this.btnfinance.Margin = new System.Windows.Forms.Padding(4);
            this.btnfinance.Name = "btnfinance";
            this.btnfinance.Size = new System.Drawing.Size(200, 200);
            this.btnfinance.TabIndex = 1;
            this.btnfinance.Text = "Finance";
            this.btnfinance.UseVisualStyleBackColor = true;
            this.btnfinance.Click += new System.EventHandler(this.btnfinance_Click);
            // 
            // btnmaintenance
            // 
            this.btnmaintenance.Location = new System.Drawing.Point(13, 380);
            this.btnmaintenance.Margin = new System.Windows.Forms.Padding(4);
            this.btnmaintenance.Name = "btnmaintenance";
            this.btnmaintenance.Size = new System.Drawing.Size(200, 200);
            this.btnmaintenance.TabIndex = 2;
            this.btnmaintenance.Text = "maintenance";
            this.btnmaintenance.UseVisualStyleBackColor = true;
            this.btnmaintenance.Click += new System.EventHandler(this.btnmaintenance_Click);
            // 
            // btnsales
            // 
            this.btnsales.Location = new System.Drawing.Point(221, 380);
            this.btnsales.Margin = new System.Windows.Forms.Padding(4);
            this.btnsales.Name = "btnsales";
            this.btnsales.Size = new System.Drawing.Size(200, 200);
            this.btnsales.TabIndex = 3;
            this.btnsales.Text = "sales";
            this.btnsales.UseVisualStyleBackColor = true;
            this.btnsales.Click += new System.EventHandler(this.btnsales_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(435, 227);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(170, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txbUserPassword
            // 
            this.txbUserPassword.Location = new System.Drawing.Point(505, 199);
            this.txbUserPassword.Name = "txbUserPassword";
            this.txbUserPassword.Size = new System.Drawing.Size(100, 22);
            this.txbUserPassword.TabIndex = 99;
            // 
            // txbUserName
            // 
            this.txbUserName.Location = new System.Drawing.Point(505, 171);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(100, 22);
            this.txbUserName.TabIndex = 98;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(432, 202);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(66, 16);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "password";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(432, 174);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(67, 16);
            this.lblUserName.TabIndex = 8;
            this.lblUserName.Text = "username";
            // 
            // pbBlack
            // 
            this.pbBlack.BackColor = System.Drawing.SystemColors.WindowText;
            this.pbBlack.Location = new System.Drawing.Point(-3, -1);
            this.pbBlack.Margin = new System.Windows.Forms.Padding(4);
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
            this.lblTitle.Location = new System.Drawing.Point(1058, 9);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(71, 31);
            this.lblTitle.TabIndex = 101;
            this.lblTitle.Text = "login";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 593);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbBlack);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txbUserName);
            this.Controls.Add(this.txbUserPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnsales);
            this.Controls.Add(this.btnmaintenance);
            this.Controls.Add(this.btnfinance);
            this.Controls.Add(this.btnInkoop);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBlack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInkoop;
        private System.Windows.Forms.Button btnfinance;
        private System.Windows.Forms.Button btnmaintenance;
        private System.Windows.Forms.Button btnsales;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txbUserPassword;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.PictureBox pbBlack;
        private System.Windows.Forms.Label lblTitle;
    }
}

