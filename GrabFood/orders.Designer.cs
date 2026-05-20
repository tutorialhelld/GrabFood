using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace GrabFood
{
    partial class orders
    {

        
            private System.ComponentModel.IContainer components = null;
            private Label lblTitle;
            private DataGridView dgvorders;
            private Button btnRefresh;
            private Button btnBack;

            protected override void Dispose(bool disposing)
            {
                if (disposing && (components != null))
                    components.Dispose();

                base.Dispose(disposing);
            }

            private void InitializeComponent()
            {
                lblTitle = new Label();
                dgvorders = new DataGridView();
                btnRefresh = new Button();
                btnBack = new Button();

                ((System.ComponentModel.ISupportInitialize)dgvorders).BeginInit();
                SuspendLayout();

                lblTitle.Text = "My Orders";
                lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, FontStyle.Bold);
                lblTitle.ForeColor = Color.Green;
                lblTitle.Location = new Point(20, 20);
                lblTitle.Size = new Size(300, 45);

                dgvorders.Location = new Point(20, 80);
                dgvorders.Size = new Size(850, 330);
                dgvorders.ReadOnly = true;
                dgvorders.AllowUserToAddRows = false;
                dgvorders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                btnRefresh.Text = "Refresh";
                btnRefresh.Location = new Point(20, 425);
                btnRefresh.Size = new Size(120, 35);
                btnRefresh.Click += btnRefresh_Click;

                btnBack.Text = "Back";
                btnBack.Location = new Point(750, 425);
                btnBack.Size = new Size(120, 35);
                btnBack.Click += btnBack_Click;

                ClientSize = new Size(900, 480);
                Controls.Add(lblTitle);
                Controls.Add(dgvorders);
                Controls.Add(btnRefresh);
                Controls.Add(btnBack);
                Name = "orders";
                Text = "My Orders";
                StartPosition = FormStartPosition.CenterScreen;
                Load += orders_Load;

                ((System.ComponentModel.ISupportInitialize)dgvorders).EndInit();
                ResumeLayout(false);
            }
    }
}