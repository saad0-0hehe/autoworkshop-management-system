namespace WinFormsApp1
{
    partial class Owner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Owner));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            btnLogout = new Button();
            btnEmployeePerformance = new Button();
            btnStockSummary = new Button();
            btnFinancialReports = new Button();
            btnDashboard = new Button();
            lblOwnerTitle = new Label();
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
            panel1.Controls.Add(btnEmployeePerformance);
            panel1.Controls.Add(btnStockSummary);
            panel1.Controls.Add(btnFinancialReports);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(lblOwnerTitle);
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
            // btnEmployeePerformance
            // 
            btnEmployeePerformance.BackColor = Color.FromArgb(0, 150, 136);
            btnEmployeePerformance.FlatAppearance.BorderSize = 0;
            btnEmployeePerformance.FlatStyle = FlatStyle.Flat;
            btnEmployeePerformance.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEmployeePerformance.ForeColor = Color.White;
            btnEmployeePerformance.Location = new Point(0, 400);
            btnEmployeePerformance.Name = "btnEmployeePerformance";
            btnEmployeePerformance.Size = new Size(250, 50);
            btnEmployeePerformance.TabIndex = 4;
            btnEmployeePerformance.Text = "Employee Performance";
            btnEmployeePerformance.UseVisualStyleBackColor = false;
            btnEmployeePerformance.Click += btnEmployeePerformance_Click;
            // 
            // btnStockSummary
            // 
            btnStockSummary.BackColor = Color.FromArgb(0, 150, 136);
            btnStockSummary.FlatAppearance.BorderSize = 0;
            btnStockSummary.FlatStyle = FlatStyle.Flat;
            btnStockSummary.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStockSummary.ForeColor = Color.White;
            btnStockSummary.Location = new Point(0, 300);
            btnStockSummary.Name = "btnStockSummary";
            btnStockSummary.Size = new Size(250, 50);
            btnStockSummary.TabIndex = 3;
            btnStockSummary.Text = "Stock Summary";
            btnStockSummary.UseVisualStyleBackColor = false;
            btnStockSummary.Click += btnStockSummary_Click;
            // 
            // btnFinancialReports
            // 
            btnFinancialReports.BackColor = Color.FromArgb(0, 150, 136);
            btnFinancialReports.FlatAppearance.BorderSize = 0;
            btnFinancialReports.FlatStyle = FlatStyle.Flat;
            btnFinancialReports.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFinancialReports.ForeColor = Color.White;
            btnFinancialReports.Location = new Point(0, 200);
            btnFinancialReports.Name = "btnFinancialReports";
            btnFinancialReports.Size = new Size(250, 50);
            btnFinancialReports.TabIndex = 2;
            btnFinancialReports.Text = "Financial Reports";
            btnFinancialReports.UseVisualStyleBackColor = false;
            btnFinancialReports.Click += btnFinancialReports_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(0, 150, 136);
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(0, 100);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(250, 50);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // lblOwnerTitle
            // 
            lblOwnerTitle.AutoSize = true;
            lblOwnerTitle.Font = new Font("Nirmala UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOwnerTitle.ForeColor = Color.White;
            lblOwnerTitle.Location = new Point(50, 30);
            lblOwnerTitle.Name = "lblOwnerTitle";
            lblOwnerTitle.Size = new Size(103, 38);
            lblOwnerTitle.TabIndex = 0;
            lblOwnerTitle.Text = "Owner";
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
            // Owner
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
            Name = "Owner";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "5";
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
        private Label lblOwnerTitle;
        private Button btnDashboard;
        private Button btnFinancialReports;
        private Button btnStockSummary;
        private Button btnEmployeePerformance;
        private Button btnLogout;
    }
}