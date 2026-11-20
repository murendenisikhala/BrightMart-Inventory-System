namespace BrightMartInventorySystems
{
    partial class lblReports
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
            lblSalesReports = new Label();
            lblReportType = new Label();
            lblTotalSales = new Label();
            cmbReportType = new ComboBox();
            dgvReports = new DataGridView();
            SaleID = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            QuantitySold = new DataGridViewTextBoxColumn();
            TotalPrice = new DataGridViewTextBoxColumn();
            btnGenerateReport = new Button();
            txtTotalSales = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvReports).BeginInit();
            SuspendLayout();
            // 
            // lblSalesReports
            // 
            lblSalesReports.AutoSize = true;
            lblSalesReports.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSalesReports.Location = new Point(175, 9);
            lblSalesReports.Name = "lblSalesReports";
            lblSalesReports.Size = new Size(139, 23);
            lblSalesReports.TabIndex = 0;
            lblSalesReports.Text = "SALES REPORTS";
            // 
            // lblReportType
            // 
            lblReportType.AutoSize = true;
            lblReportType.Location = new Point(110, 45);
            lblReportType.Name = "lblReportType";
            lblReportType.Size = new Size(92, 20);
            lblReportType.TabIndex = 1;
            lblReportType.Text = "Report Type:";
            // 
            // lblTotalSales
            // 
            lblTotalSales.AutoSize = true;
            lblTotalSales.Location = new Point(110, 225);
            lblTotalSales.Name = "lblTotalSales";
            lblTotalSales.Size = new Size(83, 20);
            lblTotalSales.TabIndex = 2;
            lblTotalSales.Text = "Total Sales:";
            // 
            // cmbReportType
            // 
            cmbReportType.FormattingEnabled = true;
            cmbReportType.Items.AddRange(new object[] { "Daily Reports", "Weekly Reports" });
            cmbReportType.Location = new Point(208, 45);
            cmbReportType.Name = "cmbReportType";
            cmbReportType.Size = new Size(151, 28);
            cmbReportType.TabIndex = 3;
            // 
            // dgvReports
            // 
            dgvReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReports.Columns.AddRange(new DataGridViewColumn[] { SaleID, ProductName, QuantitySold, TotalPrice });
            dgvReports.Location = new Point(0, 115);
            dgvReports.Name = "dgvReports";
            dgvReports.RowHeadersWidth = 51;
            dgvReports.Size = new Size(550, 100);
            dgvReports.TabIndex = 4;
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
            // btnGenerateReport
            // 
            btnGenerateReport.Location = new Point(208, 79);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(151, 30);
            btnGenerateReport.TabIndex = 5;
            btnGenerateReport.Text = "Generate Report";
            btnGenerateReport.UseVisualStyleBackColor = true;
            btnGenerateReport.Click += btnGenerateReport_Click;
            // 
            // txtTotalSales
            // 
            txtTotalSales.Location = new Point(208, 221);
            txtTotalSales.Name = "txtTotalSales";
            txtTotalSales.Size = new Size(151, 27);
            txtTotalSales.TabIndex = 6;
            // 
            // lblReports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 254);
            Controls.Add(txtTotalSales);
            Controls.Add(btnGenerateReport);
            Controls.Add(dgvReports);
            Controls.Add(cmbReportType);
            Controls.Add(lblTotalSales);
            Controls.Add(lblReportType);
            Controls.Add(lblSalesReports);
            Name = "lblReports";
            Text = "SALES REPORTS";
            ((System.ComponentModel.ISupportInitialize)dgvReports).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSalesReports;
        private Label lblReportType;
        private Label lblTotalSales;
        private ComboBox cmbReportType;
        private DataGridView dgvReports;
        private Button btnGenerateReport;
        private TextBox txtTotalSales;
        private DataGridViewTextBoxColumn SaleID;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn QuantitySold;
        private DataGridViewTextBoxColumn TotalPrice;
    }
}