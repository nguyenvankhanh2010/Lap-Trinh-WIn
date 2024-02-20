namespace Do_an_LTWin
{
    partial class UserControlCategory
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlProductTittle = new System.Windows.Forms.Panel();
            this.lblProductTittle = new System.Windows.Forms.Label();
            this.dgvProductList = new System.Windows.Forms.DataGridView();
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnlProductTittle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).BeginInit();
            this.pnlProductInfor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numProductQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlProductTittle
            // 
            this.pnlProductTittle.BackColor = System.Drawing.Color.Tomato;
            this.pnlProductTittle.Controls.Add(this.lblProductTittle);
            this.pnlProductTittle.Location = new System.Drawing.Point(-72, 8);
            this.pnlProductTittle.Margin = new System.Windows.Forms.Padding(4);
            this.pnlProductTittle.Name = "pnlProductTittle";
            this.pnlProductTittle.Size = new System.Drawing.Size(1044, 63);
            this.pnlProductTittle.TabIndex = 3;
            // 
            // lblProductTittle
            // 
            this.lblProductTittle.AutoSize = true;
            this.lblProductTittle.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductTittle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblProductTittle.Location = new System.Drawing.Point(411, 13);
            this.lblProductTittle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductTittle.Name = "lblProductTittle";
            this.lblProductTittle.Size = new System.Drawing.Size(233, 38);
            this.lblProductTittle.TabIndex = 0;
            this.lblProductTittle.Text = "PRODUCT LIST";
            // 
            // dgvProductList
            // 
            this.dgvProductList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductList.Location = new System.Drawing.Point(0, 71);
            this.dgvProductList.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProductList.Name = "dgvProductList";
            this.dgvProductList.RowHeadersWidth = 51;
            this.dgvProductList.Size = new System.Drawing.Size(953, 422);
            this.dgvProductList.TabIndex = 4;
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
            this.pnlProductInfor.Location = new System.Drawing.Point(5, 194);
            this.pnlProductInfor.Margin = new System.Windows.Forms.Padding(4);
            this.pnlProductInfor.Name = "pnlProductInfor";
            this.pnlProductInfor.Size = new System.Drawing.Size(948, 276);
            this.pnlProductInfor.TabIndex = 5;
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.BackColor = System.Drawing.Color.Tomato;
            this.btnUpdateProduct.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUpdateProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdateProduct.Location = new System.Drawing.Point(793, 30);
            this.btnUpdateProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(125, 209);
            this.btnUpdateProduct.TabIndex = 16;
            this.btnUpdateProduct.Text = "Update";
            this.btnUpdateProduct.UseVisualStyleBackColor = false;
            // 
            // btnDelProduct
            // 
            this.btnDelProduct.BackColor = System.Drawing.Color.Tomato;
            this.btnDelProduct.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDelProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelProduct.Location = new System.Drawing.Point(669, 31);
            this.btnDelProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelProduct.Name = "btnDelProduct";
            this.btnDelProduct.Size = new System.Drawing.Size(100, 209);
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
            this.btnAddProduct.Location = new System.Drawing.Point(536, 30);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(100, 209);
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
            this.cbProductType.Location = new System.Drawing.Point(151, 105);
            this.cbProductType.Margin = new System.Windows.Forms.Padding(4);
            this.cbProductType.Name = "cbProductType";
            this.cbProductType.Size = new System.Drawing.Size(350, 24);
            this.cbProductType.TabIndex = 13;
            // 
            // numProductQuantity
            // 
            this.numProductQuantity.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.numProductQuantity.Location = new System.Drawing.Point(151, 183);
            this.numProductQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.numProductQuantity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numProductQuantity.Name = "numProductQuantity";
            this.numProductQuantity.Size = new System.Drawing.Size(111, 22);
            this.numProductQuantity.TabIndex = 12;
            this.numProductQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbProductPrice
            // 
            this.tbProductPrice.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbProductPrice.Location = new System.Drawing.Point(347, 182);
            this.tbProductPrice.Margin = new System.Windows.Forms.Padding(4);
            this.tbProductPrice.Name = "tbProductPrice";
            this.tbProductPrice.Size = new System.Drawing.Size(154, 22);
            this.tbProductPrice.TabIndex = 11;
            // 
            // tbProductDescribe
            // 
            this.tbProductDescribe.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbProductDescribe.Location = new System.Drawing.Point(151, 218);
            this.tbProductDescribe.Margin = new System.Windows.Forms.Padding(4);
            this.tbProductDescribe.Name = "tbProductDescribe";
            this.tbProductDescribe.Size = new System.Drawing.Size(350, 22);
            this.tbProductDescribe.TabIndex = 10;
            // 
            // tbProductBrand
            // 
            this.tbProductBrand.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbProductBrand.Location = new System.Drawing.Point(151, 142);
            this.tbProductBrand.Margin = new System.Windows.Forms.Padding(4);
            this.tbProductBrand.Name = "tbProductBrand";
            this.tbProductBrand.Size = new System.Drawing.Size(350, 22);
            this.tbProductBrand.TabIndex = 9;
            // 
            // tbProductName
            // 
            this.tbProductName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbProductName.Location = new System.Drawing.Point(151, 69);
            this.tbProductName.Margin = new System.Windows.Forms.Padding(4);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(350, 22);
            this.tbProductName.TabIndex = 8;
            // 
            // tbProductID
            // 
            this.tbProductID.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbProductID.Location = new System.Drawing.Point(151, 30);
            this.tbProductID.Margin = new System.Windows.Forms.Padding(4);
            this.tbProductID.Name = "tbProductID";
            this.tbProductID.Size = new System.Drawing.Size(350, 22);
            this.tbProductID.TabIndex = 7;
            // 
            // lblProductDescribe
            // 
            this.lblProductDescribe.AutoSize = true;
            this.lblProductDescribe.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblProductDescribe.Location = new System.Drawing.Point(53, 222);
            this.lblProductDescribe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductDescribe.Name = "lblProductDescribe";
            this.lblProductDescribe.Size = new System.Drawing.Size(87, 22);
            this.lblProductDescribe.TabIndex = 6;
            this.lblProductDescribe.Text = "Describe";
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblProductPrice.Location = new System.Drawing.Point(283, 186);
            this.lblProductPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(54, 22);
            this.lblProductPrice.TabIndex = 5;
            this.lblProductPrice.Text = "Price";
            // 
            // lblProductQuantity
            // 
            this.lblProductQuantity.AutoSize = true;
            this.lblProductQuantity.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblProductQuantity.Location = new System.Drawing.Point(60, 182);
            this.lblProductQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductQuantity.Name = "lblProductQuantity";
            this.lblProductQuantity.Size = new System.Drawing.Size(78, 22);
            this.lblProductQuantity.TabIndex = 4;
            this.lblProductQuantity.Text = "Quantity";
            // 
            // lblProductBrand
            // 
            this.lblProductBrand.AutoSize = true;
            this.lblProductBrand.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblProductBrand.Location = new System.Drawing.Point(80, 142);
            this.lblProductBrand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductBrand.Name = "lblProductBrand";
            this.lblProductBrand.Size = new System.Drawing.Size(60, 22);
            this.lblProductBrand.TabIndex = 3;
            this.lblProductBrand.Text = "Brand";
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblProductType.Location = new System.Drawing.Point(23, 105);
            this.lblProductType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(117, 22);
            this.lblProductType.TabIndex = 2;
            this.lblProductType.Text = "Product type";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblProductName.Location = new System.Drawing.Point(9, 69);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(128, 22);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "Product name";
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblProductID.Location = new System.Drawing.Point(40, 33);
            this.lblProductID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(101, 22);
            this.lblProductID.TabIndex = 0;
            this.lblProductID.Text = "Product ID";
            // 
            // UserControlCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlProductInfor);
            this.Controls.Add(this.dgvProductList);
            this.Controls.Add(this.pnlProductTittle);
            this.Name = "UserControlCategory";
            this.Size = new System.Drawing.Size(923, 600);
            this.pnlProductTittle.ResumeLayout(false);
            this.pnlProductTittle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).EndInit();
            this.pnlProductInfor.ResumeLayout(false);
            this.pnlProductInfor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numProductQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlProductTittle;
        private System.Windows.Forms.Label lblProductTittle;
        private System.Windows.Forms.DataGridView dgvProductList;
        private System.Windows.Forms.Panel pnlProductInfor;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Button btnDelProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.ComboBox cbProductType;
        private System.Windows.Forms.NumericUpDown numProductQuantity;
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
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductID;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
