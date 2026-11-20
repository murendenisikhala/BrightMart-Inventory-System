namespace BrightMartInventorySystems
{
    partial class SalesForm
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
            lblProduct = new Label();
            cmbProduct = new ComboBox();
            lblQuantity = new Label();
            txtSaleQuantity = new TextBox();
            lblPrice = new Label();
            txtSalePrice = new TextBox();
            btnRecordSale = new Button();
            dgvSales = new DataGridView();
            SaleID = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            QuantitySold = new DataGridViewTextBoxColumn();
            TotalPrice = new DataGridViewTextBoxColumn();
            btnClearSale = new Button();
            btnRecordSales = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSales).BeginInit();
            SuspendLayout();
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Location = new Point(95, 54);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(67, 20);
            lblProduct.TabIndex = 0;
            lblProduct.Text = "Product :";
            lblProduct.Click += lblProduct_Click;
            // 
            // cmbProduct
            // 
            cmbProduct.AutoCompleteCustomSource.AddRange(new string[] { "Laptop" });
            cmbProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProduct.FormattingEnabled = true;
            cmbProduct.Items.AddRange(new object[] { "Laptop" });
            cmbProduct.Location = new Point(168, 53);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new Size(151, 28);
            cmbProduct.TabIndex = 1;
            cmbProduct.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(90, 87);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(72, 20);
            lblQuantity.TabIndex = 2;
            lblQuantity.Text = "Quantity :";
            lblQuantity.Click += lblQuantity_Click;
            // 
            // txtSaleQuantity
            // 
            txtSaleQuantity.Location = new Point(168, 87);
            txtSaleQuantity.Name = "txtSaleQuantity";
            txtSaleQuantity.Size = new Size(151, 27);
            txtSaleQuantity.TabIndex = 4;
            txtSaleQuantity.TextChanged += textBox2_TextChanged;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(95, 121);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(48, 20);
            lblPrice.TabIndex = 5;
            lblPrice.Text = "Price :";
            // 
            // txtSalePrice
            // 
            txtSalePrice.Location = new Point(168, 121);
            txtSalePrice.Name = "txtSalePrice";
            txtSalePrice.Size = new Size(151, 27);
            txtSalePrice.TabIndex = 6;
            txtSalePrice.TextChanged += textBox3_TextChanged;
            // 
            // btnRecordSale
            // 
            btnRecordSale.Location = new Point(95, 166);
            btnRecordSale.Name = "btnRecordSale";
            btnRecordSale.Size = new Size(113, 29);
            btnRecordSale.TabIndex = 7;
            btnRecordSale.Text = "Record Sale";
            btnRecordSale.UseVisualStyleBackColor = true;
            btnRecordSale.Click += btnRecordSale_Click;
            // 
            // dgvSales
            // 
            dgvSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSales.Columns.AddRange(new DataGridViewColumn[] { SaleID, ProductName, QuantitySold, TotalPrice });
            dgvSales.Location = new Point(12, 201);
            dgvSales.Name = "dgvSales";
            dgvSales.RowHeadersWidth = 51;
            dgvSales.Size = new Size(545, 105);
            dgvSales.TabIndex = 8;
            dgvSales.CellContentClick += cmbProduct_CellContentClick;
            // 
            // SaleID
            // 
            SaleID.HeaderText = "Sale ID";
            SaleID.MinimumWidth = 6;
            SaleID.Name = "SaleID";
            SaleID.Width = 125;
            // 
            // ProductName
            // 
            ProductName.HeaderText = "Product";
            ProductName.MinimumWidth = 6;
            ProductName.Name = "ProductName";
            ProductName.Width = 125;
            // 
            // QuantitySold
            // 
            QuantitySold.HeaderText = "Quantity Sold";
            QuantitySold.MinimumWidth = 6;
            QuantitySold.Name = "QuantitySold";
            QuantitySold.Width = 125;
            // 
            // TotalPrice
            // 
            TotalPrice.HeaderText = "Total Price";
            TotalPrice.MinimumWidth = 6;
            TotalPrice.Name = "TotalPrice";
            TotalPrice.Width = 125;
            // 
            // btnClearSale
            // 
            btnClearSale.Location = new Point(228, 166);
            btnClearSale.Name = "btnClearSale";
            btnClearSale.Size = new Size(114, 29);
            btnClearSale.TabIndex = 9;
            btnClearSale.Text = "Clear";
            btnClearSale.UseVisualStyleBackColor = true;
            btnClearSale.Click += btnClearSale_Click;
            // 
            // btnRecordSales
            // 
            btnRecordSales.AutoSize = true;
            btnRecordSales.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRecordSales.Location = new Point(180, 9);
            btnRecordSales.Name = "btnRecordSales";
            btnRecordSales.Size = new Size(120, 25);
            btnRecordSales.TabIndex = 10;
            btnRecordSales.Text = "Record Sales";
            // 
            // SalesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 316);
            Controls.Add(btnRecordSales);
            Controls.Add(btnClearSale);
            Controls.Add(dgvSales);
            Controls.Add(btnRecordSale);
            Controls.Add(txtSalePrice);
            Controls.Add(lblPrice);
            Controls.Add(txtSaleQuantity);
            Controls.Add(lblQuantity);
            Controls.Add(cmbProduct);
            Controls.Add(lblProduct);
            Name = "SalesForm";
            Text = "Record Sales";
            Load += SalesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSales).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProduct;
        private ComboBox cmbProduct;
        private Label lblQuantity;
        private TextBox textBox1;
        private TextBox txtSaleQuantity;
        private Label lblPrice;
        private TextBox txtSalePrice;
        private Button btnRecordSale;
        private DataGridView dgvSales;
        private Button btnClearSale;
        private Label btnRecordSales;
        private DataGridViewTextBoxColumn SaleID;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn QuantitySold;
        private DataGridViewTextBoxColumn TotalPrice;
    }
}