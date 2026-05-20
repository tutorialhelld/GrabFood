using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace GrabFood
{
    public partial class adminreports : Form
    {
        public adminreports()
        {
            InitializeComponent();
        }

        private void adminreports_Load(object sender, EventArgs e)
        {
            LoadReports();
        }

        private void LoadReports()
        {
            using (var conn = Database.GetConnection())
            {
                string query = @"
                SELECT
                    ReportID,
                    OrderID,
                    CustomerName,
                    RiderName,
                    Feedback,
                    ReportDate
                FROM RiderReports
                ORDER BY ReportDate DESC";

                SQLiteDataAdapter adapter =
                    new SQLiteDataAdapter(query, conn);

                DataTable table = new DataTable();
                adapter.Fill(table);

                dgvReports.DataSource = table;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            UserControl admin = new UserControl();
            admin.Show();

            this.Hide();
        }
    }
}