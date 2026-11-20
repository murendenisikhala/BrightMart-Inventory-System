using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BrightMartInventorySystems
{
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtProductName.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
            cmbSupplier.SelectedIndex = -1;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            // Check that the product name is entered
            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("Please enter a product name.");
                return;
            }

            // Check that the price is valid
            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price < 0)
            {
                MessageBox.Show("Please enter a valid price.");
                return;
            }

            // Check that the quantity is valid
            if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity < 0)
            {
                MessageBox.Show("Please enter a valid quantity.");
                return;
            }

            // Check that a supplier is selected
            if (string.IsNullOrWhiteSpace(cmbSupplier.Text))
            {
                MessageBox.Show("Please select a supplier.");
                return;
            }

            // Create the next Product ID
            int productId = 1;

            foreach (Product p in ProductData.Products)
            {
                
            }

            // Create the product
            Product product = new Product();

            
            product.ProductName = txtProductName.Text;
            product.Price = price;
            product.Quantity = quantity;
            product.Supplier = cmbSupplier.Text;

            // Add and display the product
            ProductData.Products.Add(product);

            DatabaseManager.AddProduct(product);

            dgvProducts.Rows.Add(
                product.ProductID,
                product.ProductName,
                product.Price,
                product.Quantity,
                product.Supplier
            );

            // Save the product
     
            MessageBox.Show("Product added successfully.");
        }
           
        

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null ||
        dgvProducts.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Please select a product first.");
                return;
            }

            int rowIndex = dgvProducts.CurrentRow.Index;

            if (rowIndex >= ProductData.Products.Count)
                return;

            // Get the product before removing it
            Product product = ProductData.Products[rowIndex];

            // Delete it from SQLite
            DatabaseManager.DeleteProduct(product.ProductID);

            // Remove it from the current list and grid
            ProductData.Products.RemoveAt(rowIndex);
            dgvProducts.Rows.RemoveAt(rowIndex);

            // Keep JSON backup for now

            MessageBox.Show("Product deleted successfully.");
        }
        


        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null ||
                dgvProducts.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Please select a product first.");
                return;
            }

            int rowIndex = dgvProducts.CurrentRow.Index;

            if (rowIndex >= ProductData.Products.Count)
                return;

            Product product = ProductData.Products[rowIndex];

            if (!string.IsNullOrWhiteSpace(txtProductName.Text))
                product.ProductName = txtProductName.Text;

            if (!string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                if (!decimal.TryParse(txtPrice.Text, out decimal price) || price < 0)
                {
                    MessageBox.Show("Please enter a valid price.");
                    return;
                }

                product.Price = price;
            }

            if (!string.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity < 0)
                {
                    MessageBox.Show("Please enter a valid quantity.");
                    return;
                }

                product.Quantity = quantity;
            }

            if (!string.IsNullOrWhiteSpace(cmbSupplier.Text))
                product.Supplier = cmbSupplier.Text;

            dgvProducts.CurrentRow.Cells[1].Value = product.ProductName;
            dgvProducts.CurrentRow.Cells[2].Value = product.Price;
            dgvProducts.CurrentRow.Cells[3].Value = product.Quantity;
            dgvProducts.CurrentRow.Cells[4].Value = product.Supplier;

            DatabaseManager.UpdateProduct(product);


            MessageBox.Show("Product updated successfully.");
        }


        private void ProductsForm_Load(object sender, EventArgs e)
        {
       
            dgvProducts.Rows.Clear();

            // Load saved suppliers into the Supplier dropdown
            cmbSupplier.Items.Clear();

            foreach (Supplier supplier in SupplierData.Suppliers)
            {
                cmbSupplier.Items.Add(supplier.SupplierName);
            }

            // Keep Product IDs in order
           
            foreach (Product product in ProductData.Products)
            {
               
                dgvProducts.Rows.Add(
                    product.ProductID,
                    product.ProductName,
                    product.Price,
                    product.Quantity,
                    product.Supplier
                );
            }
        }
    }
    
}
