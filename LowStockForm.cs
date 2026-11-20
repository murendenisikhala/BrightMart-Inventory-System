 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BrightMartInventorySystems
{
    public partial class LowStockForm : Form
    {
        public LowStockForm()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvLowStock.Rows.Clear();

            foreach (Product product in ProductData.Products)
            {
                if (product.Quantity <= 5)
                {
                    dgvLowStock.Rows.Add(
                        product.ProductID,
                        product.ProductName,
                        product.Quantity,
                        "Low Stock"
                    );
                }
            }


        }
    }
}
