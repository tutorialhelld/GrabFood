using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace GrabFood
{
    public partial class Checkout : Form
    {
        private string connectionString =
        @"Data Source=C:\Users\User\source\repos\GrabFood\GrabFood\bin\x64\Debug\net8.0-windows\GrabDB.db;Version=3;";
        private decimal deliveryFee = 49.00m;

        public Checkout()
        {
            InitializeComponent();
        }

        private void Checkout_Load(object sender, EventArgs e)
        {
            LoadCart();
        }

        private void LoadCart()
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                    SELECT 
                        Cart.CartId,
                        Products.ProductName,
                        Products.Price,
                        Cart.Quantity,
                        Cart.Customizations,
                        (Products.Price * Cart.Quantity) AS Total
                    FROM Cart
                    INNER JOIN Products ON Cart.ProductId = Products.ProductId;";

                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        cartGrid.DataSource = dt;
                    }
                }

                CalculateTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Read Error: " + ex.Message);
            }
        }

        private void CalculateTotal()
        {
            decimal subtotal = 0;

            foreach (DataGridViewRow row in cartGrid.Rows)
            {
                if (row.Cells["Total"].Value != null)
                {
                    subtotal += Convert.ToDecimal(row.Cells["Total"].Value);
                }
            }

            decimal finalTotal = subtotal + deliveryFee;

            lblSubtotal.Text = "₱" + subtotal.ToString("0.00");
            lblDeliveryFee.Text = "₱" + deliveryFee.ToString("0.00");
            lblTotal.Text = "₱" + finalTotal.ToString("0.00");
        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            if (cartGrid.Rows.Count == 0 || cartGrid.Rows[0].IsNewRow)
            {
                MessageBox.Show("Cart is already empty.");
                return;
            }

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "DELETE FROM Cart";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Cart cleared!");
            LoadCart();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (cartGrid.Rows.Count == 0 || cartGrid.Rows[0].IsNewRow)
            {
                MessageBox.Show("Your cart is empty.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Place this order?",
                "Confirm Order",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.No)
                return;

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();

                    string insertOrder = @"
                    INSERT INTO Orders
                    (CustomerName, ProductName, Quantity, Total, Status, RiderName, Address, OrderDate)
                    SELECT
                    @customerName,
                    Products.ProductName,
                    Cart.Quantity,
                    (Products.Price * Cart.Quantity),
                    'Still Cooking',
                    '',
                    @address,
                    datetime('now')
                    FROM Cart
                    INNER JOIN Products
                    ON Cart.ProductId = Products.ProductId";

                    using (SQLiteCommand orderCmd = new SQLiteCommand(insertOrder, conn))
                    {
                        orderCmd.Parameters.AddWithValue("@customerName", Session.Username);

                        // THIS LINE
                        orderCmd.Parameters.AddWithValue("@address", Session.Address);

                        orderCmd.ExecuteNonQuery();
                    }

                    string clearCart = "DELETE FROM Cart";

                    using (SQLiteCommand clearCmd = new SQLiteCommand(clearCart, conn))
                    {
                        clearCmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Order placed successfully!");
                LoadCart();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Place Order Error: " + ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void cartGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}