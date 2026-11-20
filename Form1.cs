namespace BrightMartInventorySystems
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductsForm productsForm = new ProductsForm();
            productsForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SuppliersForm suppliersForm = new SuppliersForm();
            suppliersForm.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SalesForm salesForm = new SalesForm();
            salesForm.ShowDialog();
        }

        private void btnLowStock_Click(object sender, EventArgs e)
        {
            LowStockForm lowStockForm = new LowStockForm();
            lowStockForm.ShowDialog();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            lblReports reportsForm = new lblReports();
            reportsForm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
