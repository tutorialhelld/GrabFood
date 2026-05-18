using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace GrabFood
{
    public partial class LiveOrdersVendor : Form
    {
        public LiveOrdersVendor()
        {
            InitializeComponent();
        }

        private void LiveOrdersVendor_Load(object sender, EventArgs e)
        {
            LoadOrders();
            LoadRiders();
            comboStatus.Items.Add("New Order");
            comboStatus.Items.Add("Preparing");
            comboStatus.Items.Add("Ready for Pickup");
            comboStatus.Items.Add("Out for Delivery");
            comboStatus.Items.Add("Completed");
            comboStatus.Items.Add("Cancelled");
        }

        private void LoadOrders()
        {
            using (var conn = Database.GetConnection())
            {
                string query = @"
                SELECT 
                    OrderID,
                    CustomerName,
                    ProductName,
                    Quantity,
                    Total,
                    Status,
                    RiderName,
                    Address,
                    OrderDate
                FROM Orders";

                SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dgvOrders.DataSource = table;
            }
        }

        private void LoadRiders()
        {
            using (var conn = Database.GetConnection())
            {
                string query = "SELECT RiderName FROM Riders";

                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                SQLiteDataReader reader = cmd.ExecuteReader();

                comboRider.Items.Clear();

                while (reader.Read())
                {
                    comboRider.Items.Add(reader["RiderName"].ToString());
                }

                reader.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order first.");
                return;
            }

            if (comboStatus.Text == "")
            {
                MessageBox.Show("Please select a status.");
                return;
            }

            int orderID = Convert.ToInt32(dgvOrders.SelectedRows[0].Cells["OrderID"].Value);

            using (var conn = Database.GetConnection())
            {
                string query = @"
                UPDATE Orders
                SET Status = @status
                WHERE OrderID = @id";

                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@status", comboStatus.Text);
                cmd.Parameters.AddWithValue("@id", orderID);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Order status updated!");
            LoadOrders();
        }

        private void btnAssignRider_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order first.");
                return;
            }

            if (comboRider.Text == "")
            {
                MessageBox.Show("Please select a rider.");
                return;
            }

            int orderID = Convert.ToInt32(dgvOrders.SelectedRows[0].Cells["OrderID"].Value);

            using (var conn = Database.GetConnection())
            {
                string query = @"
                UPDATE Orders
                SET RiderName = @rider,
                    Status = 'Out for Delivery'
                WHERE OrderID = @id";

                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@rider", comboRider.Text);
                cmd.Parameters.AddWithValue("@id", orderID);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Rider assigned!");
            LoadOrders();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadOrders();
            LoadRiders();
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            UserControl userControl = new UserControl();
            userControl.Show();
            this.Hide();
        }
    }
}