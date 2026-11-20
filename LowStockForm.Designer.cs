namespace BrightMartInventorySystems
{
    partial class LowStockForm
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
            lblLowStock = new Label();
            dgvLowStock = new DataGridView();
            btnRefresh = new Button();
            ProductID = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvLowStock).BeginInit();
            SuspendLayout();
            // 
            // lblLowStock
            // 
            lblLowStock.AutoSize = true;
            lblLowStock.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLowStock.Location = new Point(207, 9);
            lblLowStock.Name = "lblLowStock";
            lblLowStock.Size = new Size(141, 20);
            lblLowStock.TabIndex = 0;
            lblLowStock.Text = "LOW STOCK ITEMS";
            // 
            // dgvLowStock
            // 
            dgvLowStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLowStock.Columns.AddRange(new DataGridViewColumn[] { ProductID, ProductName, Quantity, Status });
            dgvLowStock.Location = new Point(12, 44);
            dgvLowStock.Name = "dgvLowStock";
            dgvLowStock.RowHeadersWidth = 51;
            dgvLowStock.Size = new Size(555, 95);
            dgvLowStock.TabIndex = 1;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(216, 158);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(110, 29);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // ProductID
            // 
            ProductID.HeaderText = "Product ID";
            ProductID.MinimumWidth = 6;
            ProductID.Name = "ProductID";
            ProductID.Width = 125;
            // 
            // ProductName
            // 
            ProductName.HeaderText = "Product Name";
            ProductName.MinimumWidth = 6;
            ProductName.Name = "ProductName";
            ProductName.Width = 125;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.Width = 125;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.Width = 125;
            // 
            // LowStockForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 191);
            Controls.Add(btnRefresh);
            Controls.Add(dgvLowStock);
            Controls.Add(lblLowStock);
            Name = "LowStockForm";
            Text = "Low Stock Alert";
            ((System.ComponentModel.ISupportInitialize)dgvLowStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLowStock;
        private DataGridView dgvLowStock;
        private Button btnRefresh;
        private DataGridViewTextBoxColumn ProductID;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Status;
    }
}