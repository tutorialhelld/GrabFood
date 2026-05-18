using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace GrabFood
{
    public partial class UserControl : Form
    {
        DataGridView dgvCustomers = new DataGridView();
        DataGridView dgvRiders = new DataGridView();

        public UserControl()
        {
            InitializeComponent();
        }

        private void UserControl_Load(object sender, EventArgs e)
        {
            SetupTables();
            LoadCustomers();
            LoadRiders();
        }

        private void SetupTables()
        {
            dgvCustomers.Location = new System.Drawing.Point(0, 30);
            dgvCustomers.Size = new System.Drawing.Size(568, 190);
            dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomers.ReadOnly = true;
            dgvCustomers.AllowUserToAddRows = false;

            dgvRiders.Location = new System.Drawing.Point(0, 30);
            dgvRiders.Size = new System.Drawing.Size(568, 190);
            dgvRiders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRiders.ReadOnly = true;
            dgvRiders.AllowUserToAddRows = false;

            tabPage2.Controls.Add(dgvCustomers);
            tabPage4.Controls.Add(dgvRiders);
        }


        private void LoadCustomers()
        {
            using (var conn = Database.GetConnection())
            {
                string query = @"
                SELECT 
                    id AS 'ID',
                    username AS 'Username',
                    phone_number AS 'Phone Number',
                    address AS 'Address',
                    user_role AS 'Role'
                FROM users
                WHERE LOWER(user_role) = 'customer'";

                SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dgvCustomers.DataSource = table;
            }
        }

        private void LoadRiders()
        {
            using (var conn = Database.GetConnection())
            {
                string query = @"
                SELECT 
                    RiderID AS 'ID',
                    RiderName AS 'Rider Name',
                    PhoneNumber AS 'Phone Number',
                    VehicleType AS 'Vehicle Type',
                    Status AS 'Status'
                FROM Riders";

                SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dgvRiders.DataSource = table;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LiveOrdersVendor liveOrders = new LiveOrdersVendor();
            liveOrders.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void DeleteCustomer_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select customer first.");
                return;
            }

            int id = Convert.ToInt32(
                dgvCustomers.SelectedRows[0].Cells["ID"].Value
            );

            using (var conn = Database.GetConnection())
            {
                string query =
                    "DELETE FROM users WHERE id=@id";

                SQLiteCommand cmd =
                    new SQLiteCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Customer deleted!");

            LoadCustomers();
        }

        private void DeleteRider_Click(object sender, EventArgs e)
        {
            if (dgvRiders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select rider first.");
                return;
            }

            int id = Convert.ToInt32(
                dgvRiders.SelectedRows[0].Cells["ID"].Value
            );

            using (var conn = Database.GetConnection())
            {
                string query =
                    "DELETE FROM Riders WHERE RiderID=@id";

                SQLiteCommand cmd =
                    new SQLiteCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Rider deleted!");

            LoadRiders();
        }
    }
}