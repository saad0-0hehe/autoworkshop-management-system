namespace WinFormsApp1
{
    partial class Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            btnLogout = new Button();
            btnStockReport = new Button();
            btnInvoice = new Button();
            btnServiceExecution = new Button();
            btnCustomerBookings = new Button();
            lblManagerTitle = new Label();
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
            panel1.Controls.Add(btnStockReport);
            panel1.Controls.Add(btnInvoice);
            panel1.Controls.Add(btnServiceExecution);
            panel1.Controls.Add(btnCustomerBookings);
            panel1.Controls.Add(lblManagerTitle);
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
            // btnStockReport
            // 
            btnStockReport.BackColor = Color.FromArgb(0, 150, 136);
            btnStockReport.FlatAppearance.BorderSize = 0;
            btnStockReport.FlatStyle = FlatStyle.Flat;
            btnStockReport.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStockReport.ForeColor = Color.White;
            btnStockReport.Location = new Point(0, 400);
            btnStockReport.Name = "btnStockReport";
            btnStockReport.Size = new Size(250, 50);
            btnStockReport.TabIndex = 4;
            btnStockReport.Text = "Stock Usage Report";
            btnStockReport.UseVisualStyleBackColor = false;
            btnStockReport.Click += btnStockReport_Click;
            // 
            // btnInvoice
            // 
            btnInvoice.BackColor = Color.FromArgb(0, 150, 136);
            btnInvoice.FlatAppearance.BorderSize = 0;
            btnInvoice.FlatStyle = FlatStyle.Flat;
            btnInvoice.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInvoice.ForeColor = Color.White;
            btnInvoice.Location = new Point(0, 300);
            btnInvoice.Name = "btnInvoice";
            btnInvoice.Size = new Size(250, 50);
            btnInvoice.TabIndex = 3;
            btnInvoice.Text = "Invoice & Payment";
            btnInvoice.UseVisualStyleBackColor = false;
            btnInvoice.Click += btnInvoice_Click;
            // 
            // btnServiceExecution
            // 
            btnServiceExecution.BackColor = Color.FromArgb(0, 150, 136);
            btnServiceExecution.FlatAppearance.BorderSize = 0;
            btnServiceExecution.FlatStyle = FlatStyle.Flat;
            btnServiceExecution.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnServiceExecution.ForeColor = Color.White;
            btnServiceExecution.Location = new Point(0, 200);
            btnServiceExecution.Name = "btnServiceExecution";
            btnServiceExecution.Size = new Size(250, 50);
            btnServiceExecution.TabIndex = 2;
            btnServiceExecution.Text = "Service Execution";
            btnServiceExecution.UseVisualStyleBackColor = false;
            btnServiceExecution.Click += btnServiceExecution_Click;
            // 
            // btnCustomerBookings
            // 
            btnCustomerBookings.BackColor = Color.FromArgb(0, 150, 136);
            btnCustomerBookings.FlatAppearance.BorderSize = 0;
            btnCustomerBookings.FlatStyle = FlatStyle.Flat;
            btnCustomerBookings.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCustomerBookings.ForeColor = Color.White;
            btnCustomerBookings.Location = new Point(0, 100);
            btnCustomerBookings.Name = "btnCustomerBookings";
            btnCustomerBookings.Size = new Size(250, 50);
            btnCustomerBookings.TabIndex = 1;
            btnCustomerBookings.Text = "Customer Bookings";
            btnCustomerBookings.UseVisualStyleBackColor = false;
            btnCustomerBookings.Click += btnCustomerBookings_Click;
            // 
            // lblManagerTitle
            // 
            lblManagerTitle.AutoSize = true;
            lblManagerTitle.Font = new Font("Nirmala UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblManagerTitle.ForeColor = Color.White;
            lblManagerTitle.Location = new Point(50, 30);
            lblManagerTitle.Name = "lblManagerTitle";
            lblManagerTitle.Size = new Size(150, 38);
            lblManagerTitle.TabIndex = 0;
            lblManagerTitle.Text = "Manager";
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
            // Manager
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
            Name = "Manager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manager";
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
        private Label lblManagerTitle;
        private Button btnCustomerBookings;
        private Button btnServiceExecution;
        private Button btnInvoice;
        private Button btnStockReport;
        private Button btnLogout;
    }
}