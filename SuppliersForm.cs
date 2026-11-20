using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BrightMartInventorySystems
{
    public partial class SuppliersForm : Form
    {
        public SuppliersForm()
        {
            InitializeComponent();
        }

        private void SuppliersForm_Load(object sender, EventArgs e)
        {
            dgvSuppliers.Rows.Clear();

            foreach (Supplier supplier in SupplierData.Suppliers)
            {
                dgvSuppliers.Rows.Add(
                    supplier.SupplierID,
                    supplier.SupplierName,
                    supplier.Email,
                    supplier.Contact
                );
            }
        
        }

        private void txtSupplierName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSupplierName.Text))
            {
                MessageBox.Show("Please enter a supplier name.");
                return;
            }

            

            Supplier supplier = new Supplier();

            
            supplier.SupplierName = txtSupplierName.Text;
            supplier.Email = txtEmail.Text;
            supplier.Contact = txtContact.Text;

            SupplierData.Suppliers.Add(supplier);

            DatabaseManager.AddSupplier(supplier);

            dgvSuppliers.Rows.Add(
                supplier.SupplierID,
                supplier.SupplierName,
                supplier.Email,
                supplier.Contact
            );

   

            MessageBox.Show("Supplier added successfully.");
        }

        

        private void btnUpdateSupplier_Click(object sender, EventArgs e)
        {
            if (dgvSuppliers.CurrentRow == null ||
       dgvSuppliers.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Please select a supplier first.");
                return;
            }

            int rowIndex = dgvSuppliers.CurrentRow.Index;

            if (rowIndex >= SupplierData.Suppliers.Count)
                return;

            Supplier supplier = SupplierData.Suppliers[rowIndex];

            if (!string.IsNullOrWhiteSpace(txtSupplierName.Text))
                supplier.SupplierName = txtSupplierName.Text;

            if (!string.IsNullOrWhiteSpace(txtEmail.Text))
                supplier.Email = txtEmail.Text;

            if (!string.IsNullOrWhiteSpace(txtContact.Text))
                supplier.Contact = txtContact.Text;

            dgvSuppliers.CurrentRow.Cells[1].Value = supplier.SupplierName;
            dgvSuppliers.CurrentRow.Cells[2].Value = supplier.Email;
            dgvSuppliers.CurrentRow.Cells[3].Value = supplier.Contact;

            DatabaseManager.UpdateSupplier(supplier);


            MessageBox.Show("Supplier updated successfully.");
        }


        private void btnDeleteSupplier_Click(object sender, EventArgs e)
        {
            if (dgvSuppliers.CurrentRow == null ||
                dgvSuppliers.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Please select a supplier first.");
                return;
            }

            int rowIndex = dgvSuppliers.CurrentRow.Index;

            if (rowIndex >= SupplierData.Suppliers.Count)
                return;
            Supplier supplier = SupplierData.Suppliers[rowIndex];

            DatabaseManager.DeleteSupplier(supplier.SupplierID);
            SupplierData.Suppliers.RemoveAt(rowIndex);
            dgvSuppliers.Rows.RemoveAt(rowIndex);


            MessageBox.Show("Supplier deleted successfully.");
        }




        private void btnClearSupplier_Click(object sender, EventArgs e)
        {
            txtSupplierName.Clear();
            txtContact.Clear();
            txtEmail.Clear();
        }
    }

}
