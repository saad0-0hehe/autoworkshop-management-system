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
    public partial class Owner : Form
    {
        public Owner()
        {
            InitializeComponent();
            LoadDashboard(); // Load initial data
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadDashboard();
        }

        private void btnFinancialReports_Click(object sender, EventArgs e)
        {
            LoadFinancialReports();
        }

        private void btnStockSummary_Click(object sender, EventArgs e)
        {
            LoadStockSummary();
        }

        private void btnEmployeePerformance_Click(object sender, EventArgs e)
        {
            LoadEmployeePerformance();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            fromLogin fromLogin = new fromLogin();
            this.Hide();
            fromLogin.Show();
        }

        private void LoadDashboard()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Metric");
            dt.Columns.Add("Value");

            // Add dummy data
            dt.Rows.Add("Total Revenue (This Month)", "$15,750.00");
            dt.Rows.Add("Completed Services", "45");
            dt.Rows.Add("Pending Services", "12");
            dt.Rows.Add("Total Customers", "57");
            dt.Rows.Add("Average Service Time", "2.5 hours");

            dataGridView1.DataSource = dt;
        }

        private void LoadFinancialReports()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Month");
            dt.Columns.Add("Revenue");
            dt.Columns.Add("Expenses");
            dt.Columns.Add("Profit");

            // Add dummy data
            dt.Rows.Add("January", "$12,500.00", "$8,750.00", "$3,750.00");
            dt.Rows.Add("February", "$13,250.00", "$9,100.00", "$4,150.00");
            dt.Rows.Add("March", "$14,800.00", "$9,500.00", "$5,300.00");
            dt.Rows.Add("April", "$15,750.00", "$10,200.00", "$5,550.00");

            dataGridView1.DataSource = dt;
        }

        private void LoadStockSummary()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Part Name");
            dt.Columns.Add("Quantity in Stock");
            dt.Columns.Add("Unit Price");
            dt.Columns.Add("Total Value");
            dt.Columns.Add("Reorder Level");

            // Add dummy data
            dt.Rows.Add("Oil Filters", 50, "$9.99", "$499.50", 20);
            dt.Rows.Add("Brake Pads", 30, "$49.99", "$1,499.70", 15);
            dt.Rows.Add("Air Filters", 25, "$19.99", "$499.75", 10);
            dt.Rows.Add("Spark Plugs", 40, "$12.99", "$519.60", 25);

            dataGridView1.DataSource = dt;
        }

        private void LoadEmployeePerformance()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Employee Name");
            dt.Columns.Add("Services Completed");
            dt.Columns.Add("Average Rating");
            dt.Columns.Add("Efficiency Rate");
            dt.Columns.Add("Customer Satisfaction");

            // Add dummy data
            dt.Rows.Add("Tom Wilson", 25, "4.8/5", "92%", "95%");
            dt.Rows.Add("Sarah Brown", 20, "4.6/5", "88%", "92%");
            dt.Rows.Add("Mike Johnson", 18, "4.7/5", "90%", "94%");
            dt.Rows.Add("Emily Davis", 22, "4.9/5", "95%", "96%");

            dataGridView1.DataSource = dt;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Owner_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
