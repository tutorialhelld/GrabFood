namespace GrabFood
{
    partial class LiveOrdersVendor
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnUserManagement = new Button();
            label1 = new Label();
            label2 = new Label();
            dgvOrders = new DataGridView();
            comboStatus = new ComboBox();
            comboRider = new ComboBox();
            btnUpdate = new Button();
            btnAssignRider = new Button();
            btnRefresh = new Button();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnUserManagement);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(184, 450);
            panel1.TabIndex = 0;
            // 
            // btnUserManagement
            // 
            btnUserManagement.Location = new Point(7, 88);
            btnUserManagement.Name = "btnUserManagement";
            btnUserManagement.Size = new Size(174, 28);
            btnUserManagement.TabIndex = 1;
            btnUserManagement.Text = "User Management";
            btnUserManagement.TextAlign = ContentAlignment.MiddleLeft;
            btnUserManagement.UseVisualStyleBackColor = true;
            btnUserManagement.Click += btnUserManagement_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(7, 7);
            label1.Name = "label1";
            label1.Size = new Size(144, 37);
            label1.TabIndex = 0;
            label1.Text = "GrabFood";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label2.Location = new Point(205, 26);
            label2.Name = "label2";
            label2.Size = new Size(131, 30);
            label2.TabIndex = 1;
            label2.Text = "Live Orders";
            // 
            // dgvOrders
            // 
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrders.Location = new Point(205, 90);
            dgvOrders.MultiSelect = false;
            dgvOrders.Name = "dgvOrders";
            dgvOrders.ReadOnly = true;
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.Size = new Size(570, 230);
            dgvOrders.TabIndex = 2;
            // 
            // comboStatus
            // 
            comboStatus.Location = new Point(205, 355);
            comboStatus.Name = "comboStatus";
            comboStatus.Size = new Size(160, 23);
            comboStatus.TabIndex = 4;
            // 
            // comboRider
            // 
            comboRider.Location = new Point(205, 408);
            comboRider.Name = "comboRider";
            comboRider.Size = new Size(160, 23);
            comboRider.TabIndex = 7;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(371, 354);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(120, 25);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update Status";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAssignRider
            // 
            btnAssignRider.Location = new Point(371, 407);
            btnAssignRider.Name = "btnAssignRider";
            btnAssignRider.Size = new Size(120, 25);
            btnAssignRider.TabIndex = 8;
            btnAssignRider.Text = "Assign Rider";
            btnAssignRider.UseVisualStyleBackColor = true;
            btnAssignRider.Click += btnAssignRider_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(655, 354);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(120, 25);
            btnRefresh.TabIndex = 9;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(205, 337);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 3;
            label3.Text = "Status";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(205, 390);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 6;
            label4.Text = "Rider";
            // 
            // button1
            // 
            button1.Location = new Point(655, 406);
            button1.Name = "button1";
            button1.Size = new Size(120, 25);
            button1.TabIndex = 10;
            button1.Text = "Log Out";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(7, 122);
            button2.Name = "button2";
            button2.Size = new Size(174, 28);
            button2.TabIndex = 2;
            button2.Text = "Reports";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // LiveOrdersVendor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnRefresh);
            Controls.Add(btnAssignRider);
            Controls.Add(comboRider);
            Controls.Add(label4);
            Controls.Add(btnUpdate);
            Controls.Add(comboStatus);
            Controls.Add(label3);
            Controls.Add(dgvOrders);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "LiveOrdersVendor";
            Text = "Live Orders";
            Load += LiveOrdersVendor_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Panel panel1;
        private Label label1;
        private Label label2;
        private DataGridView dgvOrders;
        private ComboBox comboStatus;
        private ComboBox comboRider;
        private Button btnUpdate;
        private Button btnAssignRider;
        private Button btnRefresh;
        private Button btnUserManagement;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
    }
}