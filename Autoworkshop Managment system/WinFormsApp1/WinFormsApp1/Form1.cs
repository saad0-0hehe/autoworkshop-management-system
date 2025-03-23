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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            Owner ownerForm = new Owner();
            ownerForm.Show(); // Opens the Owner form
        }

        private void label2_Click_2(object sender, EventArgs e)
        {
            Manager managerForm = new Manager();
            managerForm.Show(); // Opens the Manager form
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Cashier cashierForm = new Cashier();
            cashierForm.Show(); // Opens the Cashier form
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.MouseClick += (sender, e) => Application.Exit();
        }
    }
}
