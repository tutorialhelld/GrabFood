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
            comboStatus.Items.Add("Out for Delivery");
            comboStatus.Items.Add("Completed");
            comboStatus.Items.Add("Cancelled");

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
                WHERE Status = 'Out for Delivery'
                OR Status = 'Completed'
                OR Status = 'Cancelled'";

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
    }
}