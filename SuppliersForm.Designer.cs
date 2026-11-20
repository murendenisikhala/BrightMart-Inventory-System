namespace BrightMartInventorySystems
{
    partial class SuppliersForm
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
            txtSupplierName = new TextBox();
            lblContact = new Label();
            txtContact = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            btnAddSupplier = new Button();
            btnUpdateSupplier = new Button();
            btnDeleteSupplier = new Button();
            btnClearSupplier = new Button();
            dgvSuppliers = new DataGridView();
            SupplierID = new DataGridViewTextBoxColumn();
            SupplierName = new DataGridViewTextBoxColumn();
            Contact = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(145, 55);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 0;
            label1.Text = "Supplier Name:";
            // 
            // txtSupplierName
            // 
            txtSupplierName.Location = new Point(262, 52);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(125, 27);
            txtSupplierName.TabIndex = 1;
            txtSupplierName.TextChanged += txtSupplierName_TextChanged;
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Location = new Point(145, 90);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(63, 20);
            lblContact.TabIndex = 2;
            lblContact.Text = "Contact:";
            // 
            // txtContact
            // 
            txtContact.Location = new Point(262, 128);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(125, 27);
            txtContact.TabIndex = 3;
            txtContact.TextChanged += txtContact_TextChanged;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(150, 131);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 20);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(262, 90);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 6;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // btnAddSupplier
            // 
            btnAddSupplier.Location = new Point(79, 195);
            btnAddSupplier.Name = "btnAddSupplier";
            btnAddSupplier.Size = new Size(105, 29);
            btnAddSupplier.TabIndex = 7;
            btnAddSupplier.Text = "Add Supplier";
            btnAddSupplier.UseVisualStyleBackColor = true;
            btnAddSupplier.Click += btnAddSupplier_Click;
            // 
            // btnUpdateSupplier
            // 
            btnUpdateSupplier.Location = new Point(190, 195);
            btnUpdateSupplier.Name = "btnUpdateSupplier";
            btnUpdateSupplier.Size = new Size(94, 29);
            btnUpdateSupplier.TabIndex = 8;
            btnUpdateSupplier.Text = "Update";
            btnUpdateSupplier.UseVisualStyleBackColor = true;
            btnUpdateSupplier.Click += btnUpdateSupplier_Click;
            // 
            // btnDeleteSupplier
            // 
            btnDeleteSupplier.Location = new Point(293, 195);
            btnDeleteSupplier.Name = "btnDeleteSupplier";
            btnDeleteSupplier.Size = new Size(94, 29);
            btnDeleteSupplier.TabIndex = 9;
            btnDeleteSupplier.Text = "Delete";
            btnDeleteSupplier.UseVisualStyleBackColor = true;
            btnDeleteSupplier.Click += btnDeleteSupplier_Click;
            // 
            // btnClearSupplier
            // 
            btnClearSupplier.Location = new Point(393, 195);
            btnClearSupplier.Name = "btnClearSupplier";
            btnClearSupplier.Size = new Size(94, 29);
            btnClearSupplier.TabIndex = 10;
            btnClearSupplier.Text = "Clear";
            btnClearSupplier.UseVisualStyleBackColor = true;
            btnClearSupplier.Click += btnClearSupplier_Click;
            // 
            // dgvSuppliers
            // 
            dgvSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSuppliers.Columns.AddRange(new DataGridViewColumn[] { SupplierID, SupplierName, Contact, Email });
            dgvSuppliers.Location = new Point(12, 230);
            dgvSuppliers.Name = "dgvSuppliers";
            dgvSuppliers.RowHeadersWidth = 51;
            dgvSuppliers.Size = new Size(552, 112);
            dgvSuppliers.TabIndex = 11;
            // 
            // SupplierID
            // 
            SupplierID.HeaderText = "Supplier ID";
            SupplierID.MinimumWidth = 6;
            SupplierID.Name = "SupplierID";
            SupplierID.Width = 125;
            // 
            // SupplierName
            // 
            SupplierName.HeaderText = "Supplier Name";
            SupplierName.MinimumWidth = 6;
            SupplierName.Name = "SupplierName";
            SupplierName.Width = 125;
            // 
            // Contact
            // 
            Contact.HeaderText = "Contact";
            Contact.MinimumWidth = 6;
            Contact.Name = "Contact";
            Contact.Width = 125;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.Width = 125;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(166, 9);
            label2.Name = "label2";
            label2.Size = new Size(221, 28);
            label2.TabIndex = 12;
            label2.Text = "Supplier Management";
            // 
            // SuppliersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 354);
            Controls.Add(label2);
            Controls.Add(dgvSuppliers);
            Controls.Add(btnClearSupplier);
            Controls.Add(btnDeleteSupplier);
            Controls.Add(btnUpdateSupplier);
            Controls.Add(btnAddSupplier);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtContact);
            Controls.Add(lblContact);
            Controls.Add(txtSupplierName);
            Controls.Add(label1);
            Name = "SuppliersForm";
            Text = "SuppliersForm.cs";
            Load += SuppliersForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSupplierName;
        private Label lblContact;
        private TextBox txtContact;
        private Label lblEmail;
        private TextBox txtEmail;
        private Button btnAddSupplier;
        private Button btnUpdateSupplier;
        private Button btnDeleteSupplier;
        private Button btnClearSupplier;
        private DataGridView dgvSuppliers;
        private Label label2;
        private DataGridViewTextBoxColumn SupplierID;
        private DataGridViewTextBoxColumn SupplierName;
        private DataGridViewTextBoxColumn Contact;
        private DataGridViewTextBoxColumn Email;
    }
}