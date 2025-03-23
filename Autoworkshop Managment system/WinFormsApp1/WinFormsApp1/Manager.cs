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
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
            LoadCustomerBookings(); // Load initial data
        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void btnCustomerBookings_Click(object sender, EventArgs e)
        {
            LoadCustomerBookings();
        }

        public void btnServiceExecution_Click(object sender, EventArgs e)
        {
            LoadServiceExecution();
        }

        public void btnInvoice_Click(object sender, EventArgs e)
        {
            LoadInvoices();
        }

        public void btnStockReport_Click(object sender, EventArgs e)
        {
            LoadStockReport();
        }

        public void btnLogout_Click(object sender, EventArgs e)
        {
            fromLogin fromLogin = new fromLogin();
            this.Hide();
            fromLogin.Show();
        }

        private void LoadCustomerBookings()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("BookingID");
            dt.Columns.Add("CustomerName");
            dt.Columns.Add("PhoneNumber");
            dt.Columns.Add("Service");
            dt.Columns.Add("BookingDate");
            dt.Columns.Add("Status");

            // Add dummy data
            dt.Rows.Add("B001", "John Doe", "123-456-7890", "Oil Change", DateTime.Now, "Pending");
            dt.Rows.Add("B002", "Jane Smith", "098-765-4321", "Brake Service", DateTime.Now.AddDays(1), "Confirmed");
            dt.Rows.Add("B003", "Mike Johnson", "555-555-5555", "Tire Rotation", DateTime.Now.AddDays(2), "Pending");

            dataGridView1.DataSource = dt;
        }

        private void LoadServiceExecution()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("BookingID");
            dt.Columns.Add("CustomerName");
            dt.Columns.Add("Service");
            dt.Columns.Add("BookingDate");
            dt.Columns.Add("Status");
            dt.Columns.Add("Assigned Employee");

            // Add dummy data
            dt.Rows.Add("B001", "John Doe", "Oil Change", DateTime.Now, "In Progress", "Tom Wilson");
            dt.Rows.Add("B002", "Jane Smith", "Brake Service", DateTime.Now.AddDays(1), "Pending", "Sarah Brown");

            dataGridView1.DataSource = dt;
        }

        private void LoadInvoices()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("InvoiceID");
            dt.Columns.Add("CustomerName");
            dt.Columns.Add("Service");
            dt.Columns.Add("InvoiceDate");
            dt.Columns.Add("TotalAmount");
            dt.Columns.Add("PaymentStatus");

            // Add dummy data
            dt.Rows.Add("INV001", "John Doe", "Oil Change", DateTime.Now, "$49.99", "Paid");
            dt.Rows.Add("INV002", "Jane Smith", "Brake Service", DateTime.Now.AddDays(-1), "$299.99", "Pending");
            dt.Rows.Add("INV003", "Mike Johnson", "Tire Rotation", DateTime.Now.AddDays(-2), "$29.99", "Paid");

            dataGridView1.DataSource = dt;
        }

        private void LoadStockReport()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("PartID");
            dt.Columns.Add("PartName");
            dt.Columns.Add("Quantity in Stock");
            dt.Columns.Add("Unit Price");
            dt.Columns.Add("Total Value");

            // Add dummy data
            dt.Rows.Add("P001", "Oil Filter", 50, "$9.99", "$499.50");
            dt.Rows.Add("P002", "Brake Pads", 30, "$49.99", "$1,499.70");
            dt.Rows.Add("P003", "Air Filter", 25, "$19.99", "$499.75");

            dataGridView1.DataSource = dt;
        }
    }
}
