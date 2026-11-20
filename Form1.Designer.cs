namespace BrightMartInventorySystems
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblBrightMart = new Label();
            btnProducts = new Button();
            btnSuppliers = new Button();
            btnRecordSales = new Button();
            btnReports = new Button();
            btnLowStock = new Button();
            lblSystemTitle = new Label();
            SuspendLayout();
            // 
            // lblBrightMart
            // 
            lblBrightMart.AutoSize = true;
            lblBrightMart.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBrightMart.Location = new Point(321, 9);
            lblBrightMart.Name = "lblBrightMart";
            lblBrightMart.Size = new Size(176, 31);
            lblBrightMart.TabIndex = 1;
            lblBrightMart.Text = "BRIGHTMART  ";
            lblBrightMart.Click += label2_Click;
            // 
            // btnProducts
            // 
            btnProducts.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProducts.Location = new Point(12, 77);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(127, 104);
            btnProducts.TabIndex = 2;
            btnProducts.Text = "Products";
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += button1_Click;
            // 
            // btnSuppliers
            // 
            btnSuppliers.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSuppliers.Location = new Point(168, 77);
            btnSuppliers.Name = "btnSuppliers";
            btnSuppliers.Size = new Size(130, 104);
            btnSuppliers.TabIndex = 3;
            btnSuppliers.Text = "Suppliers";
            btnSuppliers.UseVisualStyleBackColor = true;
            btnSuppliers.Click += button2_Click;
            // 
            // btnRecordSales
            // 
            btnRecordSales.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRecordSales.Location = new Point(321, 77);
            btnRecordSales.Name = "btnRecordSales";
            btnRecordSales.Size = new Size(136, 104);
            btnRecordSales.TabIndex = 4;
            btnRecordSales.Text = "Record Sales";
            btnRecordSales.UseVisualStyleBackColor = true;
            btnRecordSales.Click += button3_Click;
            // 
            // btnReports
            // 
            btnReports.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReports.Location = new Point(483, 77);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(131, 104);
            btnReports.TabIndex = 5;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnReports_Click;
            // 
            // btnLowStock
            // 
            btnLowStock.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLowStock.Location = new Point(631, 77);
            btnLowStock.Name = "btnLowStock";
            btnLowStock.Size = new Size(150, 104);
            btnLowStock.TabIndex = 6;
            btnLowStock.Text = "Low stock";
            btnLowStock.UseVisualStyleBackColor = true;
            btnLowStock.Click += btnLowStock_Click;
            // 
            // lblSystemTitle
            // 
            lblSystemTitle.AutoSize = true;
            lblSystemTitle.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSystemTitle.Location = new Point(291, 40);
            lblSystemTitle.Name = "lblSystemTitle";
            lblSystemTitle.Size = new Size(295, 18);
            lblSystemTitle.TabIndex = 7;
            lblSystemTitle.Text = "Inventory and sales management System";
            lblSystemTitle.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(793, 185);
            Controls.Add(lblSystemTitle);
            Controls.Add(btnLowStock);
            Controls.Add(btnReports);
            Controls.Add(btnRecordSales);
            Controls.Add(btnSuppliers);
            Controls.Add(btnProducts);
            Controls.Add(lblBrightMart);
            Name = "Form1";
            Text = "Bright Inventory System";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblBrightMart;
        private Button btnProducts;
        private Button btnSuppliers;
        private Button btnRecordSales;
        private Button btnReports;
        private Button btnLowStock;
        private Label lblSystemTitle;
    }
}
