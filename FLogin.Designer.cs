namespace Do_an_LTWin
{
    partial class FLogin
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
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.lblLoginTitle = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pbUserName = new System.Windows.Forms.PictureBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.pbPassword = new System.Windows.Forms.PictureBox();
            this.cbShowPassword = new System.Windows.Forms.CheckBox();
            this.tbIDLogin = new System.Windows.Forms.TextBox();
            this.lblShoppingTitle = new System.Windows.Forms.Label();
            this.lblSystemManagementTitle = new System.Windows.Forms.Label();
            this.pbShadowBackground = new System.Windows.Forms.PictureBox();
            this.pbBackground = new System.Windows.Forms.PictureBox();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShadowBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.White;
            this.pnlLogin.Controls.Add(this.lblLoginTitle);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.pbUserName);
            this.pnlLogin.Controls.Add(this.tbPassword);
            this.pnlLogin.Controls.Add(this.pbPassword);
            this.pnlLogin.Controls.Add(this.cbShowPassword);
            this.pnlLogin.Controls.Add(this.tbIDLogin);
            this.pnlLogin.Location = new System.Drawing.Point(40, 41);
            this.pnlLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(419, 457);
            this.pnlLogin.TabIndex = 5;
            this.pnlLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblLoginTitle
            // 
            this.lblLoginTitle.AutoSize = true;
            this.lblLoginTitle.Font = new System.Drawing.Font("Bookman Old Style", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginTitle.Location = new System.Drawing.Point(144, 69);
            this.lblLoginTitle.Name = "lblLoginTitle";
            this.lblLoginTitle.Size = new System.Drawing.Size(111, 40);
            this.lblLoginTitle.TabIndex = 6;
            this.lblLoginTitle.Text = "Login";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Tomato;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft YaHei", 11.8F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(121, 332);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(145, 42);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Log in";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbUserName
            // 
            this.pbUserName.Image = global::Do_an_LTWin.Properties.Resources.login_account;
            this.pbUserName.Location = new System.Drawing.Point(56, 155);
            this.pbUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbUserName.Name = "pbUserName";
            this.pbUserName.Size = new System.Drawing.Size(47, 28);
            this.pbUserName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUserName.TabIndex = 4;
            this.pbUserName.TabStop = false;
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbPassword.Location = new System.Drawing.Point(99, 236);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(253, 28);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // pbPassword
            // 
            this.pbPassword.Image = global::Do_an_LTWin.Properties.Resources.login_lock;
            this.pbPassword.Location = new System.Drawing.Point(53, 231);
            this.pbPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbPassword.Name = "pbPassword";
            this.pbPassword.Size = new System.Drawing.Size(47, 33);
            this.pbPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPassword.TabIndex = 3;
            this.pbPassword.TabStop = false;
            // 
            // cbShowPassword
            // 
            this.cbShowPassword.AutoSize = true;
            this.cbShowPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbShowPassword.Location = new System.Drawing.Point(227, 284);
            this.cbShowPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbShowPassword.Name = "cbShowPassword";
            this.cbShowPassword.Size = new System.Drawing.Size(138, 20);
            this.cbShowPassword.TabIndex = 2;
            this.cbShowPassword.Text = "Show Password";
            this.cbShowPassword.UseVisualStyleBackColor = true;
            this.cbShowPassword.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tbIDLogin
            // 
            this.tbIDLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbIDLogin.Location = new System.Drawing.Point(99, 155);
            this.tbIDLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbIDLogin.Name = "tbIDLogin";
            this.tbIDLogin.Size = new System.Drawing.Size(253, 28);
            this.tbIDLogin.TabIndex = 0;
            this.tbIDLogin.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblShoppingTitle
            // 
            this.lblShoppingTitle.AutoSize = true;
            this.lblShoppingTitle.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShoppingTitle.Location = new System.Drawing.Point(625, 62);
            this.lblShoppingTitle.Name = "lblShoppingTitle";
            this.lblShoppingTitle.Size = new System.Drawing.Size(165, 32);
            this.lblShoppingTitle.TabIndex = 7;
            this.lblShoppingTitle.Text = "SHOPPING";
            this.lblShoppingTitle.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblSystemManagementTitle
            // 
            this.lblSystemManagementTitle.AutoSize = true;
            this.lblSystemManagementTitle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemManagementTitle.Location = new System.Drawing.Point(596, 101);
            this.lblSystemManagementTitle.Name = "lblSystemManagementTitle";
            this.lblSystemManagementTitle.Size = new System.Drawing.Size(222, 24);
            this.lblSystemManagementTitle.TabIndex = 8;
            this.lblSystemManagementTitle.Text = "System Management";
            // 
            // pbShadowBackground
            // 
            this.pbShadowBackground.Image = global::Do_an_LTWin.Properties.Resources.login_Shadow;
            this.pbShadowBackground.Location = new System.Drawing.Point(80, 58);
            this.pbShadowBackground.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbShadowBackground.Name = "pbShadowBackground";
            this.pbShadowBackground.Size = new System.Drawing.Size(431, 484);
            this.pbShadowBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbShadowBackground.TabIndex = 4;
            this.pbShadowBackground.TabStop = false;
            this.pbShadowBackground.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pbBackground
            // 
            this.pbBackground.Image = global::Do_an_LTWin.Properties.Resources.supermarket_female_cashier_working_checkout_260nw_1924425839_removebg_preview;
            this.pbBackground.Location = new System.Drawing.Point(369, 127);
            this.pbBackground.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbBackground.Name = "pbBackground";
            this.pbBackground.Size = new System.Drawing.Size(605, 469);
            this.pbBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBackground.TabIndex = 0;
            this.pbBackground.TabStop = false;
            // 
            // FLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(972, 532);
            this.Controls.Add(this.lblSystemManagementTitle);
            this.Controls.Add(this.lblShoppingTitle);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.pbShadowBackground);
            this.Controls.Add(this.pbBackground);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShadowBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBackground;
        private System.Windows.Forms.PictureBox pbShadowBackground;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.CheckBox cbShowPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbIDLogin;
        private System.Windows.Forms.PictureBox pbPassword;
        private System.Windows.Forms.PictureBox pbUserName;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblLoginTitle;
        private System.Windows.Forms.Label lblShoppingTitle;
        private System.Windows.Forms.Label lblSystemManagementTitle;
    }
}

