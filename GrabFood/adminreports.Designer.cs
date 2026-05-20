namespace GrabFood
{
    partial class adminreports
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private DataGridView dgvReports;
        private Button btnRefresh;
        private Button btnBack;

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
            lblTitle = new Label();
            dgvReports = new DataGridView();
            btnRefresh = new Button();
            btnBack = new Button();

            ((System.ComponentModel.ISupportInitialize)dgvReports).BeginInit();
            SuspendLayout();

            // lblTitle
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Firebrick;
            lblTitle.Location = new Point(25, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(290, 37);
            lblTitle.Text = "Rider Scam Reports";

            // dgvReports
            dgvReports.AllowUserToAddRows = false;
            dgvReports.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvReports.Location = new Point(25, 80);
            dgvReports.MultiSelect = false;
            dgvReports.Name = "dgvReports";
            dgvReports.ReadOnly = true;
            dgvReports.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvReports.Size = new Size(850, 320);

            // btnRefresh
            btnRefresh.BackColor = Color.ForestGreen;
            btnRefresh.ForeColor = Color.White;
            btnRefresh.FlatStyle = FlatStyle.Flat;

            btnRefresh.Location = new Point(25, 420);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(120, 35);
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;

            // btnBack
            btnBack.BackColor = Color.Gray;
            btnBack.ForeColor = Color.White;
            btnBack.FlatStyle = FlatStyle.Flat;

            btnBack.Location = new Point(755, 420);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(120, 35);
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;

            btnBack.Click += btnBack_Click;

            // adminreports
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;

            ClientSize = new Size(900, 480);

            Controls.Add(lblTitle);
            Controls.Add(dgvReports);
            Controls.Add(btnRefresh);
            Controls.Add(btnBack);

            Name = "adminreports";
            Text = "adminreports";

            Load += adminreports_Load;

            ((System.ComponentModel.ISupportInitialize)dgvReports).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}