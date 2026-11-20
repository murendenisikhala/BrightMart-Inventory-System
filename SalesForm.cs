using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BrightMartInventorySystems
{
    public partial class SalesForm : Form
    {
        public SalesForm()
        {
            InitializeComponent();
        }

        private void SalesForm_Load(object sender, EventArgs e)
        {
            cmbProduct.Items.Clear();

            foreach (Product product in ProductData.Products)
            {
                cmbProduct.Items.Add(product.ProductName);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProduct.SelectedItem != null)
            {
                Product selectedProduct = ProductData.Products
                    .FirstOrDefault(p => p.ProductName == cmbProduct.SelectedItem.ToString());

                if (selectedProduct != null)
                {
                    txtSalePrice.Text = selectedProduct.Price.ToString();
                }
            }
        }
        private void lblProduct_Click(object sender, EventArgs e)
        {

        }

        private void lblQuantity_Click(object sender, EventArgs e)
        {

        }

        private void btnRecordSale_Click(object sender, EventArgs e)
        {
            // Check that a product is selected first
            if (cmbProduct.SelectedItem == null)
            {
                MessageBox.Show("Please select a product.");
                return;
            }

     

            // Check sale price
            if (!decimal.TryParse(txtSalePrice.Text, out decimal price) || price < 0)
            {
                MessageBox.Show("Please enter a valid sale price.");
                return;
            }

            // Check quantity
            if (!int.TryParse(txtSaleQuantity.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.");
                return;
            }

            Product selectedProduct = ProductData.Products
                .FirstOrDefault(p => p.ProductName == cmbProduct.SelectedItem.ToString());

            if (selectedProduct == null)
            {
                MessageBox.Show("Please select a valid product.");
                return;
            }

            // Check available stock
            if (quantity > selectedProduct.Quantity)
            {
                MessageBox.Show("Not enough stock available.");
                return;
            }

            decimal totalPrice = price * quantity;

            // Reduce product stock
            selectedProduct.Quantity = selectedProduct.Quantity - quantity;

            // Create the sale
            Sale sale = new Sale();

            sale.ProductName = cmbProduct.SelectedItem.ToString();
            sale.QuantitySold = quantity;
            sale.TotalPrice = totalPrice;
            sale.SaleDate = DateTime.Now;

            SalesData.Sales.Add(sale);
            DatabaseManager.AddSale(sale);
            DatabaseManager.UpdateProduct(selectedProduct);

            // Display sale
            dgvSales.Rows.Add(
                sale.SaleID,
                sale.ProductName,
                sale.QuantitySold,
                sale.TotalPrice
            );

            // Save change 

            MessageBox.Show("Sale recorded successfully.");
        
        }

        private void cmbProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void btnClearSale_Click(object sender, EventArgs e)
        {
            cmbProduct.SelectedIndex = -1;
            txtSaleQuantity.Clear();
            txtSalePrice.Clear();
        }
    }
}
