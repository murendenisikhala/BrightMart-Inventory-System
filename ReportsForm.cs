using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BrightMartInventorySystems
{
    public partial class lblReports : Form
    {
        public lblReports()
        {
            InitializeComponent();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            dgvReports.Rows.Clear();

            decimal totalSales = 0;

            foreach (Sale sale in SalesData.Sales)
            {
                {
                    bool showSale = false;

                    if (cmbReportType.Text == "Daily Reports")
                    {
                        showSale = sale.SaleDate.Date == DateTime.Today;
                    }
                    else if (cmbReportType.Text == "Weekly Reports")
                    {
                        showSale = sale.SaleDate.Date >= DateTime.Today.AddDays(-6);
                    }

                    if (showSale)
                    {
                        dgvReports.Rows.Add(
                            sale.SaleID,
                            sale.ProductName,
                            sale.QuantitySold,
                            sale.TotalPrice
                        );

                        totalSales = totalSales + sale.TotalPrice;
                    }
                }

                txtTotalSales.Text = "R " + totalSales.ToString();
              
            }
        }
    }
}
