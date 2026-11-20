namespace BrightMartInventorySystems
{
    partial class ProductsForm
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
            label1 = new Label();
            IbIProductName = new Label();
            lblPrice = new Label();
            lblQuantity = new Label();
            lblSupplier = new Label();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            txtProductName = new TextBox();
            btnAddProduct = new Button();
            btnUpdateProduct = new Button();
            btnDeleteProduct = new Button();
            btnClear = new Button();
            cmbSupplier = new ComboBox();
            dgvProducts = new DataGridView();
            colProductID = new DataGridViewTextBoxColumn();
            colProductName = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            colQuantity = new DataGridViewTextBoxColumn();
            colSupplier = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(100, 9);
            label1.Name = "label1";
            label1.Size = new Size(217, 23);
            label1.TabIndex = 0;
            label1.Text = "PRODUCT MANAGEMENT";
            // 
            // IbIProductName
            // 
            IbIProductName.AutoSize = true;
            IbIProductName.Location = new Point(100, 47);
            IbIProductName.Name = "IbIProductName";
            IbIProductName.Size = new Size(107, 20);
            IbIProductName.TabIndex = 1;
            IbIProductName.Text = "Product Name:";
            IbIProductName.Click += label2_Click;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(100, 92);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(44, 20);
            lblPrice.TabIndex = 2;
            lblPrice.Text = "Price:";
            lblPrice.Click += lblPrice_Click;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(100, 138);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(68, 20);
            lblQuantity.TabIndex = 3;
            lblQuantity.Text = "Quantity:";
            // 
            // lblSupplier
            // 
            lblSupplier.AutoSize = true;
            lblSupplier.Location = new Point(100, 180);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Size = new Size(67, 20);
            lblSupplier.TabIndex = 4;
            lblSupplier.Text = "Supplier:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(204, 85);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(151, 27);
            txtPrice.TabIndex = 5;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(204, 131);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(151, 27);
            txtQuantity.TabIndex = 6;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(213, 44);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(142, 27);
            txtProductName.TabIndex = 8;
            txtProductName.TextChanged += textBox4_TextChanged;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(12, 229);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(132, 29);
            btnAddProduct.TabIndex = 9;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // btnUpdateProduct
            // 
            btnUpdateProduct.Location = new Point(150, 229);
            btnUpdateProduct.Name = "btnUpdateProduct";
            btnUpdateProduct.Size = new Size(94, 29);
            btnUpdateProduct.TabIndex = 10;
            btnUpdateProduct.Text = "Update Product";
            btnUpdateProduct.UseVisualStyleBackColor = true;
            btnUpdateProduct.Click += btnUpdateProduct_Click;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.Location = new Point(250, 229);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(94, 29);
            btnDeleteProduct.TabIndex = 11;
            btnDeleteProduct.Text = "Delete Product";
            btnDeleteProduct.UseVisualStyleBackColor = true;
            btnDeleteProduct.Click += btnDeleteProduct_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(362, 229);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += button4_Click;
            // 
            // cmbSupplier
            // 
            cmbSupplier.FormattingEnabled = true;
            cmbSupplier.Items.AddRange(new object[] { "Fresh Foods Supplier", "BrightMart Wholesale ", "Local Supplier ", "General Supplier" });
            cmbSupplier.Location = new Point(204, 172);
            cmbSupplier.Name = "cmbSupplier";
            cmbSupplier.Size = new Size(151, 28);
            cmbSupplier.TabIndex = 13;
            cmbSupplier.SelectedIndexChanged += cmbSupplier_SelectedIndexChanged;
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { colProductID, colProductName, colPrice, colQuantity, colSupplier });
            dgvProducts.Location = new Point(7, 262);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.Size = new Size(653, 157);
            dgvProducts.TabIndex = 14;
            dgvProducts.CellContentClick += dgvProducts_CellContentClick;
            // 
            // colProductID
            // 
            colProductID.HeaderText = "Product ID";
            colProductID.MinimumWidth = 6;
            colProductID.Name = "colProductID";
            colProductID.Width = 125;
            // 
            // colProductName
            // 
            colProductName.HeaderText = "Product Name";
            colProductName.MinimumWidth = 6;
            colProductName.Name = "colProductName";
            colProductName.Width = 125;
            // 
            // colPrice
            // 
            colPrice.HeaderText = "Price";
            colPrice.MinimumWidth = 6;
            colPrice.Name = "colPrice";
            colPrice.Width = 125;
            // 
            // colQuantity
            // 
            colQuantity.HeaderText = "Quantity";
            colQuantity.MinimumWidth = 6;
            colQuantity.Name = "colQuantity";
            colQuantity.Width = 125;
            // 
            // colSupplier
            // 
            colSupplier.HeaderText = "Supplier";
            colSupplier.MinimumWidth = 6;
            colSupplier.Name = "colSupplier";
            colSupplier.Width = 125;
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(672, 431);
            Controls.Add(dgvProducts);
            Controls.Add(cmbSupplier);
            Controls.Add(btnClear);
            Controls.Add(btnDeleteProduct);
            Controls.Add(btnUpdateProduct);
            Controls.Add(btnAddProduct);
            Controls.Add(txtProductName);
            Controls.Add(txtQuantity);
            Controls.Add(txtPrice);
            Controls.Add(lblSupplier);
            Controls.Add(lblQuantity);
            Controls.Add(lblPrice);
            Controls.Add(IbIProductName);
            Controls.Add(label1);
            Name = "ProductsForm";
            Text = "Product Management";
            Load += ProductsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label IbIProductName;
        private Label lblPrice;
        private Label lblQuantity;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private TextBox txtProductName;
        private Button btnAddProduct;
        private Button btnUpdateProduct;
        private Button btnDeleteProduct;
        private Button btnClear;
        private ComboBox comboBox1;
        private DataGridView dgvProducts;
        private DataGridViewTextBoxColumn colProductID;
        private DataGridViewTextBoxColumn colProductName;
        private DataGridViewTextBoxColumn colPrice;
        private DataGridViewTextBoxColumn colQuantity;
        private DataGridViewTextBoxColumn colSupplier;
        private Label lblSupplier;
        private ComboBox cmbSupplier;
    }
}