namespace GrabFood
{
    partial class History
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private DataGridView dgvHistory;
        private Button btnRefresh;
        private Button btnBack;
        private TextBox txtFeedback;
        private Button btnReport;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            dgvHistory = new DataGridView();
            btnRefresh = new Button();
            btnBack = new Button();

            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
            SuspendLayout();

            lblTitle.Text = "Completed Order History";
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Green;
            lblTitle.Location = new Point(20, 20);
            lblTitle.Size = new Size(400, 40);

            dgvHistory.Location = new Point(20, 75);
            dgvHistory.Size = new Size(850, 330);
            dgvHistory.ReadOnly = true;
            dgvHistory.AllowUserToAddRows = false;
            dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            btnRefresh.Text = "Refresh";
            btnRefresh.Location = new Point(25, 485);
            btnRefresh.Size = new Size(120, 35);
            btnRefresh.Click += btnRefresh_Click;

            btnBack.Text = "Back";
            btnBack.Location = new Point(750, 485);
            btnBack.Size = new Size(120, 35);
            btnBack.Click += btnBack_Click;

            // txtFeedback
            txtFeedback = new TextBox();
            txtFeedback.Location = new Point(25, 445);
            txtFeedback.Size = new Size(560, 30);
            txtFeedback.PlaceholderText = "Enter rider feedback/report here...";

            // btnReport
            btnReport = new Button();
            btnReport.Text = "Report Rider";
            btnReport.Location = new Point(600, 445);
            btnReport.Size = new Size(130, 30);
            btnReport.BackColor = Color.Firebrick;
            btnReport.ForeColor = Color.White;
            btnReport.Click += btnReport_Click;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 530);
            Controls.Add(lblTitle);
            Controls.Add(dgvHistory);
            Controls.Add(btnRefresh);
            Controls.Add(btnBack);
            Controls.Add(txtFeedback);
            Controls.Add(btnReport);
            Name = "History";
            Text = "Order History";
            StartPosition = FormStartPosition.CenterScreen;
            Load += History_Load;

            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
            ResumeLayout(false);


        }
    }
}