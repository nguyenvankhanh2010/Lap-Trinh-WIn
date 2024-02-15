namespace Do_an_LTWin
{
    partial class FCart
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
            this.pnlCartTittle = new System.Windows.Forms.Panel();
            this.lblTittleCart = new System.Windows.Forms.Label();
            this.pnlCartView = new System.Windows.Forms.Panel();
            this.lvCart = new System.Windows.Forms.ListView();
            this.pnlCartSetting = new System.Windows.Forms.Panel();
            this.chbSelectAll = new System.Windows.Forms.CheckBox();
            this.cbVoucher = new System.Windows.Forms.ComboBox();
            this.btnBuy = new System.Windows.Forms.Button();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.btnDelProductInCart = new System.Windows.Forms.Button();
            this.pnlCartTittle.SuspendLayout();
            this.pnlCartView.SuspendLayout();
            this.pnlCartSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCartTittle
            // 
            this.pnlCartTittle.BackColor = System.Drawing.Color.Tomato;
            this.pnlCartTittle.Controls.Add(this.lblTittleCart);
            this.pnlCartTittle.Location = new System.Drawing.Point(3, 4);
            this.pnlCartTittle.Name = "pnlCartTittle";
            this.pnlCartTittle.Size = new System.Drawing.Size(795, 53);
            this.pnlCartTittle.TabIndex = 0;
            // 
            // lblTittleCart
            // 
            this.lblTittleCart.AutoSize = true;
            this.lblTittleCart.BackColor = System.Drawing.Color.Tomato;
            this.lblTittleCart.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittleCart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTittleCart.Location = new System.Drawing.Point(360, 15);
            this.lblTittleCart.Name = "lblTittleCart";
            this.lblTittleCart.Size = new System.Drawing.Size(60, 29);
            this.lblTittleCart.TabIndex = 0;
            this.lblTittleCart.Text = "Cart";
            // 
            // pnlCartView
            // 
            this.pnlCartView.Controls.Add(this.lvCart);
            this.pnlCartView.Location = new System.Drawing.Point(7, 63);
            this.pnlCartView.Name = "pnlCartView";
            this.pnlCartView.Size = new System.Drawing.Size(786, 497);
            this.pnlCartView.TabIndex = 1;
            // 
            // lvCart
            // 
            this.lvCart.HideSelection = false;
            this.lvCart.Location = new System.Drawing.Point(0, 3);
            this.lvCart.Name = "lvCart";
            this.lvCart.Size = new System.Drawing.Size(786, 494);
            this.lvCart.TabIndex = 0;
            this.lvCart.UseCompatibleStateImageBehavior = false;
            // 
            // pnlCartSetting
            // 
            this.pnlCartSetting.BackColor = System.Drawing.Color.White;
            this.pnlCartSetting.Controls.Add(this.chbSelectAll);
            this.pnlCartSetting.Controls.Add(this.cbVoucher);
            this.pnlCartSetting.Controls.Add(this.btnBuy);
            this.pnlCartSetting.Controls.Add(this.lblDiscount);
            this.pnlCartSetting.Controls.Add(this.btnDelProductInCart);
            this.pnlCartSetting.Location = new System.Drawing.Point(24, 563);
            this.pnlCartSetting.Name = "pnlCartSetting";
            this.pnlCartSetting.Size = new System.Drawing.Size(749, 70);
            this.pnlCartSetting.TabIndex = 2;
            // 
            // chbSelectAll
            // 
            this.chbSelectAll.AutoSize = true;
            this.chbSelectAll.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chbSelectAll.Location = new System.Drawing.Point(38, 27);
            this.chbSelectAll.Name = "chbSelectAll";
            this.chbSelectAll.Size = new System.Drawing.Size(86, 21);
            this.chbSelectAll.TabIndex = 5;
            this.chbSelectAll.Text = "Select all";
            this.chbSelectAll.UseVisualStyleBackColor = true;
            // 
            // cbVoucher
            // 
            this.cbVoucher.FormattingEnabled = true;
            this.cbVoucher.Location = new System.Drawing.Point(180, 36);
            this.cbVoucher.Name = "cbVoucher";
            this.cbVoucher.Size = new System.Drawing.Size(180, 21);
            this.cbVoucher.TabIndex = 3;
            // 
            // btnBuy
            // 
            this.btnBuy.BackColor = System.Drawing.Color.Tomato;
            this.btnBuy.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBuy.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuy.Location = new System.Drawing.Point(560, 3);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(164, 64);
            this.btnBuy.TabIndex = 0;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = false;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDiscount.Location = new System.Drawing.Point(217, 16);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(105, 17);
            this.lblDiscount.TabIndex = 2;
            this.lblDiscount.Text = "Select voucher";
            // 
            // btnDelProductInCart
            // 
            this.btnDelProductInCart.BackColor = System.Drawing.Color.Tomato;
            this.btnDelProductInCart.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDelProductInCart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelProductInCart.Location = new System.Drawing.Point(390, 3);
            this.btnDelProductInCart.Name = "btnDelProductInCart";
            this.btnDelProductInCart.Size = new System.Drawing.Size(164, 64);
            this.btnDelProductInCart.TabIndex = 1;
            this.btnDelProductInCart.Text = "Delete";
            this.btnDelProductInCart.UseVisualStyleBackColor = false;
            // 
            // FCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(801, 637);
            this.Controls.Add(this.pnlCartSetting);
            this.Controls.Add(this.pnlCartView);
            this.Controls.Add(this.pnlCartTittle);
            this.Name = "FCart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giỏ hàng";
            this.pnlCartTittle.ResumeLayout(false);
            this.pnlCartTittle.PerformLayout();
            this.pnlCartView.ResumeLayout(false);
            this.pnlCartSetting.ResumeLayout(false);
            this.pnlCartSetting.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCartTittle;
        private System.Windows.Forms.Panel pnlCartView;
        private System.Windows.Forms.Panel pnlCartSetting;
        private System.Windows.Forms.ListView lvCart;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Button btnDelProductInCart;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.ComboBox cbVoucher;
        private System.Windows.Forms.CheckBox chbSelectAll;
        private System.Windows.Forms.Label lblTittleCart;
    }
}