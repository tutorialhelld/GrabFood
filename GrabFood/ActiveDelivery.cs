using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace GrabFood
{
    public partial class ActiveDelivery : Form
    {
        public ActiveDelivery()
        {
            InitializeComponent();
        }

        private void ActiveDelivery_Load(object sender, EventArgs e)
        {
            comboStatus.Items.Clear();

            comboStatus.Items.Add("Ongoing Delivery");
            comboStatus.Items.Add("Completed");

            LoadDeliveries();
        }

        private void LoadDeliveries()
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
                FROM Orders
                WHERE Status = 'Ready for Pickup'
                OR Status = 'Ongoing Delivery'";

                SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dgvDeliveries.DataSource = table;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvDeliveries.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a delivery first.");
                return;
            }

            if (comboStatus.Text == "")
            {
                MessageBox.Show("Please select a status.");
                return;
            }

            string currentStatus = dgvDeliveries.SelectedRows[0]
                .Cells["Status"]
                .Value
                .ToString();

            if (currentStatus == "Ongoing Delivery" &&
                comboStatus.Text == "Ready for Pickup")
            {
                MessageBox.Show("This order is already being delivered. You cannot set it back to Ready for Pickup.");
                return;
            }

            if (currentStatus == "Completed")
            {
                MessageBox.Show("Completed orders cannot be changed.");
                return;
            }

            int orderID = Convert.ToInt32(
                dgvDeliveries.SelectedRows[0].Cells["OrderID"].Value
            );

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

            MessageBox.Show("Delivery updated!");
            LoadDeliveries();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadDeliveries();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void btnDeliver_Click(object sender, EventArgs e)
        {
            if (dgvDeliveries.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order first.");
                return;
            }

            string currentStatus = dgvDeliveries.SelectedRows[0]
                .Cells["Status"]
                .Value
                .ToString();

            if (currentStatus != "Ready for Pickup")
            {
                MessageBox.Show("You can only take orders that are Ready for Pickup.");
                return;
            }

            int orderID = Convert.ToInt32(
                dgvDeliveries.SelectedRows[0].Cells["OrderID"].Value
            );

            using (var conn = Database.GetConnection())
            {
                string query = @"
                UPDATE Orders
                SET Status = 'Ongoing Delivery',
                 RiderName = @rider
                WHERE OrderID = @id";

                SQLiteCommand cmd = new SQLiteCommand(query, conn);

                cmd.Parameters.AddWithValue("@rider", Session.Username);
                cmd.Parameters.AddWithValue("@id", orderID);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Delivery accepted!");
            LoadDeliveries();
        }
    }
}