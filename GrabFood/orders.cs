using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrabFood
{
    public partial class orders : Form
    {
        public orders()
        {
            InitializeComponent();
        }

        private void orders_Load(object sender, EventArgs e)
        {
            Loadorders();
        }

        private void Loadorders()
        {
            using (var conn = Database.GetConnection())
            {
                string query = @"
                SELECT
                    OrderID,
                    ProductName,
                    Quantity,
                    Total,
                    Status,
                    RiderName,
                    Address,
                    OrderDate
                FROM Orders
                WHERE CustomerName = @customer
                AND Status != 'Completed'
                ORDER BY OrderDate DESC";

                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@customer", Session.Username);

                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dgvorders.DataSource = table;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Loadorders();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form3 dashboard = new Form3();
            dashboard.Show();
            this.Hide();
        }

    }
}
