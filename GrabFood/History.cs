using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace GrabFood
{
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
        }

        private void History_Load(object sender, EventArgs e)
        {
            LoadCompletedOrders();
        }

        private void LoadCompletedOrders()
        {
            using (var conn = Database.GetConnection())
            {
                string query = @"
                SELECT 
                    Orders.OrderID,
                    Orders.CustomerName,
                    Orders.ProductName,
                    Orders.Quantity,
                    Orders.Total,
                    Orders.Status,
                    Orders.RiderName,
                    Riders.PhoneNumber AS RiderNumber,
                    Riders.VehicleType,
                    Orders.Address,
                    Orders.OrderDate
                FROM Orders
                LEFT JOIN Riders
                ON Orders.RiderName = Riders.RiderName
                WHERE Orders.CustomerName = @customer
                AND Orders.Status = 'Completed'
                ORDER BY Orders.OrderDate DESC";

                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@customer", Session.Username);

                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);

                DataTable table = new DataTable();
                adapter.Fill(table);

                dgvHistory.DataSource = table;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadCompletedOrders();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form3 dashboard = new Form3();
            dashboard.Show();
            this.Hide();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (dgvHistory.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order first.");
                return;
            }

            if (txtFeedback.Text.Trim() == "")
            {
                MessageBox.Show("Please enter feedback.");
                return;
            }

            int orderID = Convert.ToInt32(
                dgvHistory.SelectedRows[0].Cells["OrderID"].Value
            );

            string customerName =
                dgvHistory.SelectedRows[0]
                .Cells["CustomerName"]
                .Value
                .ToString();

            string riderName =
                dgvHistory.SelectedRows[0]
                .Cells["RiderName"]
                .Value
                .ToString();

            using (var conn = Database.GetConnection())
            {
                string query = @"
                INSERT INTO RiderReports
                (OrderID, CustomerName, RiderName, Feedback, ReportDate)

                VALUES
                (@id, @customer, @rider, @feedback, datetime('now'))";

                SQLiteCommand cmd = new SQLiteCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", orderID);
                cmd.Parameters.AddWithValue("@customer", customerName);
                cmd.Parameters.AddWithValue("@rider", riderName);
                cmd.Parameters.AddWithValue("@feedback", txtFeedback.Text);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Report submitted to admin.");

            txtFeedback.Clear();
        }
    }
}