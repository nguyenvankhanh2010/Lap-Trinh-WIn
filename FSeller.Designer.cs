namespace Do_an_LTWin
{
    partial class FSeller
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
            this.pnlProductInfor = new System.Windows.Forms.Panel();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.btnDelProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.cbProductType = new System.Windows.Forms.ComboBox();
            this.numProductQuantity = new System.Windows.Forms.NumericUpDown();
            this.tbProductPrice = new System.Windows.Forms.TextBox();
            this.tbProductDescribe = new System.Windows.Forms.TextBox();
            this.tbProductBrand = new System.Windows.Forms.TextBox();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.tbProductID = new System.Windows.Forms.TextBox();
            this.lblProductDescribe = new System.Windows.Forms.Label();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.lblProductQuantity = new System.Windows.Forms.Label();
            this.lblProductBrand = new System.Windows.Forms.Label();
            this.lblProductType = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductID = new System.Windows.Forms.Label();
            this.dgvProductList = new System.Windows.Forms.DataGridView();
            this.pnlProductTittle = new System.Windows.Forms.Panel();
            this.lblProductTittle = new System.Windows.Forms.Label();
            this.pnlProductInfor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numProductQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).BeginInit();
            this.pnlProductTittle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlProductInfor
            // 
            this.pnlProductInfor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlProductInfor.Controls.Add(this.btnUpdateProduct);
            this.pnlProductInfor.Controls.Add(this.btnDelProduct);
            this.pnlProductInfor.Controls.Add(this.btnAddProduct);
            this.pnlProductInfor.Controls.Add(this.cbProductType);
            this.pnlProductInfor.Controls.Add(this.numProductQuantity);
            this.pnlProductInfor.Controls.Add(this.tbProductPrice);
            this.pnlProductInfor.Controls.Add(this.tbProductDescribe);
            this.pnlProductInfor.Controls.Add(this.tbProductBrand);
            this.pnlProductInfor.Controls.Add(this.tbProductName);
            this.pnlProductInfor.Controls.Add(this.tbProductID);
            this.pnlProductInfor.Controls.Add(this.lblProductDescribe);
            this.pnlProductInfor.Controls.Add(this.lblProductPrice);
            this.pnlProductInfor.Controls.Add(this.lblProductQuantity);
            this.pnlProductInfor.Controls.Add(this.lblProductBrand);
            this.pnlProductInfor.Controls.Add(this.lblProductType);
            this.pnlProductInfor.Controls.Add(this.lblProductName);
            this.pnlProductInfor.Controls.Add(this.lblProductID);
            this.pnlProductInfor.Location = new System.Drawing.Point(8, 419);
            this.pnlProductInfor.Name = "pnlProductInfor";
            this.pnlProductInfor.Size = new System.Drawing.Size(753, 213);
            this.pnlProductInfor.TabIndex = 0;
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.BackColor = System.Drawing.Color.Tomato;
            this.btnUpdateProduct.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUpdateProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdateProduct.Location = new System.Drawing.Point(662, 24);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(88, 170);
            this.btnUpdateProduct.TabIndex = 16;
            this.btnUpdateProduct.Text = "Update";
            this.btnUpdateProduct.UseVisualStyleBackColor = false;
            // 
            // btnDelProduct
            // 
            this.btnDelProduct.BackColor = System.Drawing.Color.Tomato;
            this.btnDelProduct.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDelProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelProduct.Location = new System.Drawing.Point(581, 23);
            this.btnDelProduct.Name = "btnDelProduct";
            this.btnDelProduct.Size = new System.Drawing.Size(75, 170);
            this.btnDelProduct.TabIndex = 15;
            this.btnDelProduct.Text = "Del";
            this.btnDelProduct.UseVisualStyleBackColor = false;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.Tomato;
            this.btnAddProduct.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAddProduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddProduct.Location = new System.Drawing.Point(500, 23);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(75, 170);
            this.btnAddProduct.TabIndex = 14;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            // 
            // cbProductType
            // 
            this.cbProductType.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cbProductType.FormattingEnabled = true;
            this.cbProductType.Items.AddRange(new object[] {
            "Phone",
            "TV",
            "Earphone"});
            this.cbProductType.Location = new System.Drawing.Point(113, 85);
            this.cbProductType.Name = "cbProductType";
            this.cbProductType.Size = new System.Drawing.Size(381, 21);
            this.cbProductType.TabIndex = 13;
            // 
            // numProductQuantity
            // 
            this.numProductQuantity.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.numProductQuantity.Location = new System.Drawing.Point(113, 149);
            this.numProductQuantity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numProductQuantity.Name = "numProductQuantity";
            this.numProductQuantity.Size = new System.Drawing.Size(83, 20);
            this.numProductQuantity.TabIndex = 12;
            this.numProductQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbProductPrice
            // 
            this.tbProductPrice.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbProductPrice.Location = new System.Drawing.Point(260, 148);
            this.tbProductPrice.Name = "tbProductPrice";
            this.tbProductPrice.Size = new System.Drawing.Size(234, 20);
            this.tbProductPrice.TabIndex = 11;
            // 
            // tbProductDescribe
            // 
            this.tbProductDescribe.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbProductDescribe.Location = new System.Drawing.Point(113, 177);
            this.tbProductDescribe.Name = "tbProductDescribe";
            this.tbProductDescribe.Size = new System.Drawing.Size(381, 20);
            this.tbProductDescribe.TabIndex = 10;
            // 
            // tbProductBrand
            // 
            this.tbProductBrand.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbProductBrand.Location = new System.Drawing.Point(113, 115);
            this.tbProductBrand.Name = "tbProductBrand";
            this.tbProductBrand.Size = new System.Drawing.Size(381, 20);
            this.tbProductBrand.TabIndex = 9;
            // 
            // tbProductName
            // 
            this.tbProductName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbProductName.Location = new System.Drawing.Point(113, 56);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(381, 20);
            this.tbProductName.TabIndex = 8;
            // 
            // tbProductID
            // 
            this.tbProductID.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbProductID.Location = new System.Drawing.Point(113, 24);
            this.tbProductID.Name = "tbProductID";
            this.tbProductID.Size = new System.Drawing.Size(381, 20);
            this.tbProductID.TabIndex = 7;
            // 
            // lblProductDescribe
            // 
            this.lblProductDescribe.AutoSize = true;
            this.lblProductDescribe.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblProductDescribe.Location = new System.Drawing.Point(40, 180);
            this.lblProductDescribe.Name = "lblProductDescribe";
            this.lblProductDescribe.Size = new System.Drawing.Size(67, 17);
            this.lblProductDescribe.TabIndex = 6;
            this.lblProductDescribe.Text = "Describe";
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblProductPrice.Location = new System.Drawing.Point(212, 151);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(42, 17);
            this.lblProductPrice.TabIndex = 5;
            this.lblProductPrice.Text = "Price";
            // 
            // lblProductQuantity
            // 
            this.lblProductQuantity.AutoSize = true;
            this.lblProductQuantity.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblProductQuantity.Location = new System.Drawing.Point(45, 148);
            this.lblProductQuantity.Name = "lblProductQuantity";
            this.lblProductQuantity.Size = new System.Drawing.Size(62, 17);
            this.lblProductQuantity.TabIndex = 4;
            this.lblProductQuantity.Text = "Quantity";
            // 
            // lblProductBrand
            // 
            this.lblProductBrand.AutoSize = true;
            this.lblProductBrand.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblProductBrand.Location = new System.Drawing.Point(60, 115);
            this.lblProductBrand.Name = "lblProductBrand";
            this.lblProductBrand.Size = new System.Drawing.Size(47, 17);
            this.lblProductBrand.TabIndex = 3;
            this.lblProductBrand.Text = "Brand";
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblProductType.Location = new System.Drawing.Point(17, 85);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(90, 17);
            this.lblProductType.TabIndex = 2;
            this.lblProductType.Text = "Product type";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblProductName.Location = new System.Drawing.Point(7, 56);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(100, 17);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "Product name";
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblProductID.Location = new System.Drawing.Point(30, 27);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(77, 17);
            this.lblProductID.TabIndex = 0;
            this.lblProductID.Text = "Product ID";
            // 
            // dgvProductList
            // 
            this.dgvProductList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductList.Location = new System.Drawing.Point(6, 55);
            this.dgvProductList.Name = "dgvProductList";
            this.dgvProductList.Size = new System.Drawing.Size(759, 358);
            this.dgvProductList.TabIndex = 1;
            // 
            // pnlProductTittle
            // 
            this.pnlProductTittle.BackColor = System.Drawing.Color.Tomato;
            this.pnlProductTittle.Controls.Add(this.lblProductTittle);
            this.pnlProductTittle.Location = new System.Drawing.Point(-7, -2);
            this.pnlProductTittle.Name = "pnlProductTittle";
            this.pnlProductTittle.Size = new System.Drawing.Size(783, 51);
            this.pnlProductTittle.TabIndex = 2;
            // 
            // lblProductTittle
            // 
            this.lblProductTittle.AutoSize = true;
            this.lblProductTittle.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductTittle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblProductTittle.Location = new System.Drawing.Point(297, 11);
            this.lblProductTittle.Name = "lblProductTittle";
            this.lblProductTittle.Size = new System.Drawing.Size(186, 31);
            this.lblProductTittle.TabIndex = 0;
            this.lblProductTittle.Text = "PRODUCT LIST";
            // 
            // FSeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(773, 655);
            this.Controls.Add(this.pnlProductTittle);
            this.Controls.Add(this.dgvProductList);
            this.Controls.Add(this.pnlProductInfor);
            this.Name = "FSeller";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seller";
            this.pnlProductInfor.ResumeLayout(false);
            this.pnlProductInfor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numProductQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).EndInit();
            this.pnlProductTittle.ResumeLayout(false);
            this.pnlProductTittle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlProductInfor;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.TextBox tbProductPrice;
        private System.Windows.Forms.TextBox tbProductDescribe;
        private System.Windows.Forms.TextBox tbProductBrand;
        private System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.TextBox tbProductID;
        private System.Windows.Forms.Label lblProductDescribe;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Label lblProductQuantity;
        private System.Windows.Forms.Label lblProductBrand;
        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Button btnDelProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.ComboBox cbProductType;
        private System.Windows.Forms.NumericUpDown numProductQuantity;
        private System.Windows.Forms.DataGridView dgvProductList;
        private System.Windows.Forms.Panel pnlProductTittle;
        private System.Windows.Forms.Label lblProductTittle;
    }
}