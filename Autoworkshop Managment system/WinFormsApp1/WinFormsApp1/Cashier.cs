using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Cashier : Form
    {
        public Cashier()
        {
            InitializeComponent();
            LoadStockInventory(); // Load initial data
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStockInventory_Click(object sender, EventArgs e)
        {
            LoadStockInventory();
        }

        private void btnStockUsage_Click(object sender, EventArgs e)
        {
            LoadStockUsage();
        }

        private void btnSupplierManagement_Click(object sender, EventArgs e)
        {
            LoadSupplierManagement();
        }

        private void btnStockReports_Click(object sender, EventArgs e)
        {
            LoadStockReports();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
  
             fromLogin fromLogin = new fromLogin();
             this.Hide();
             fromLogin.Show();
        }

        private void LoadStockInventory()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Item ID");
            dt.Columns.Add("Item Name");
            dt.Columns.Add("Category");
            dt.Columns.Add("Quantity");
            dt.Columns.Add("Unit Price");
            dt.Columns.Add("Last Updated");

            // Add dummy data
            dt.Rows.Add("001", "Engine Oil", "Lubricants", "50", "$25.00", "2024-03-15");
            dt.Rows.Add("002", "Brake Pads", "Brake System", "30", "$45.00", "2024-03-14");
            dt.Rows.Add("003", "Air Filter", "Filters", "100", "$15.00", "2024-03-13");

            dataGridView1.DataSource = dt;
        }

        private void LoadStockUsage()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Service ID");
            dt.Columns.Add("Item Used");
            dt.Columns.Add("Quantity Used");
            dt.Columns.Add("Date Used");
            dt.Columns.Add("Service Type");

            // Add dummy data
            dt.Rows.Add("S001", "Engine Oil", "2", "2024-03-15", "Oil Change");
            dt.Rows.Add("S002", "Brake Pads", "1", "2024-03-14", "Brake Service");
            dt.Rows.Add("S003", "Air Filter", "1", "2024-03-13", "Filter Replacement");

            dataGridView1.DataSource = dt;
        }

        private void LoadSupplierManagement()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Supplier ID");
            dt.Columns.Add("Supplier Name");
            dt.Columns.Add("Contact Person");
            dt.Columns.Add("Phone");
            dt.Columns.Add("Email");
            dt.Columns.Add("Last Purchase");

            // Add dummy data
            dt.Rows.Add("SUP001", "Auto Parts Co.", "John Smith", "555-0123", "john@autoparts.com", "2024-03-15");
            dt.Rows.Add("SUP002", "Car Care Supplies", "Jane Doe", "555-0124", "jane@carcare.com", "2024-03-14");
            dt.Rows.Add("SUP003", "Vehicle Tools Inc.", "Mike Johnson", "555-0125", "mike@vehtools.com", "2024-03-13");

            dataGridView1.DataSource = dt;
        }

        private void LoadStockReports()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Item Name");
            dt.Columns.Add("Initial Stock");
            dt.Columns.Add("Current Stock");
            dt.Columns.Add("Used This Month");
            dt.Columns.Add("Reorder Level");

            // Add dummy data
            dt.Rows.Add("Engine Oil", "100", "50", "50", "20");
            dt.Rows.Add("Brake Pads", "50", "30", "20", "15");
            dt.Rows.Add("Air Filter", "200", "100", "100", "40");

            dataGridView1.DataSource = dt;
        }
    }
}
