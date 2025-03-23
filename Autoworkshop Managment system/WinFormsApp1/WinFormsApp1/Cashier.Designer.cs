namespace WinFormsApp1
{
    partial class Cashier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cashier));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            btnLogout = new Button();
            btnStockReports = new Button();
            btnSupplierManagement = new Button();
            btnStockUsage = new Button();
            btnStockInventory = new Button();
            lblCashierTitle = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1221, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 150, 136);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnStockReports);
            panel1.Controls.Add(btnSupplierManagement);
            panel1.Controls.Add(btnStockUsage);
            panel1.Controls.Add(btnStockInventory);
            panel1.Controls.Add(lblCashierTitle);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 610);
            panel1.TabIndex = 20;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(0, 150, 136);
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(0, 500);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(250, 50);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnStockReports
            // 
            btnStockReports.BackColor = Color.FromArgb(0, 150, 136);
            btnStockReports.FlatAppearance.BorderSize = 0;
            btnStockReports.FlatStyle = FlatStyle.Flat;
            btnStockReports.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStockReports.ForeColor = Color.White;
            btnStockReports.Location = new Point(0, 400);
            btnStockReports.Name = "btnStockReports";
            btnStockReports.Size = new Size(250, 50);
            btnStockReports.TabIndex = 4;
            btnStockReports.Text = "Stock Reports";
            btnStockReports.UseVisualStyleBackColor = false;
            btnStockReports.Click += btnStockReports_Click;
            // 
            // btnSupplierManagement
            // 
            btnSupplierManagement.BackColor = Color.FromArgb(0, 150, 136);
            btnSupplierManagement.FlatAppearance.BorderSize = 0;
            btnSupplierManagement.FlatStyle = FlatStyle.Flat;
            btnSupplierManagement.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSupplierManagement.ForeColor = Color.White;
            btnSupplierManagement.Location = new Point(0, 300);
            btnSupplierManagement.Name = "btnSupplierManagement";
            btnSupplierManagement.Size = new Size(250, 50);
            btnSupplierManagement.TabIndex = 3;
            btnSupplierManagement.Text = "Supplier Management";
            btnSupplierManagement.UseVisualStyleBackColor = false;
            btnSupplierManagement.Click += btnSupplierManagement_Click;
            // 
            // btnStockUsage
            // 
            btnStockUsage.BackColor = Color.FromArgb(0, 150, 136);
            btnStockUsage.FlatAppearance.BorderSize = 0;
            btnStockUsage.FlatStyle = FlatStyle.Flat;
            btnStockUsage.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStockUsage.ForeColor = Color.White;
            btnStockUsage.Location = new Point(0, 200);
            btnStockUsage.Name = "btnStockUsage";
            btnStockUsage.Size = new Size(250, 50);
            btnStockUsage.TabIndex = 2;
            btnStockUsage.Text = "Stock Usage Tracking";
            btnStockUsage.UseVisualStyleBackColor = false;
            btnStockUsage.Click += btnStockUsage_Click;
            // 
            // btnStockInventory
            // 
            btnStockInventory.BackColor = Color.FromArgb(0, 150, 136);
            btnStockInventory.FlatAppearance.BorderSize = 0;
            btnStockInventory.FlatStyle = FlatStyle.Flat;
            btnStockInventory.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStockInventory.ForeColor = Color.White;
            btnStockInventory.Location = new Point(0, 100);
            btnStockInventory.Name = "btnStockInventory";
            btnStockInventory.Size = new Size(250, 50);
            btnStockInventory.TabIndex = 1;
            btnStockInventory.Text = "Stock Inventory";
            btnStockInventory.UseVisualStyleBackColor = false;
            btnStockInventory.Click += btnStockInventory_Click;
            // 
            // lblCashierTitle
            // 
            lblCashierTitle.AutoSize = true;
            lblCashierTitle.Font = new Font("Nirmala UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCashierTitle.ForeColor = Color.White;
            lblCashierTitle.Location = new Point(12, 31);
            lblCashierTitle.Name = "lblCashierTitle";
            lblCashierTitle.Size = new Size(214, 38);
            lblCashierTitle.TabIndex = 0;
            lblCashierTitle.Text = "Stock Manager";
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(250, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1020, 610);
            panel2.TabIndex = 21;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1020, 610);
            dataGridView1.TabIndex = 0;
            // 
            // Cashier
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1270, 610);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Cashier";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cashier";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Label lblCashierTitle;
        private Button btnStockInventory;
        private Button btnStockUsage;
        private Button btnSupplierManagement;
        private Button btnStockReports;
        private Button btnLogout;
    }
}