using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace GrabFood
{
    public partial class Checkout : Form
    {
        private string connectionString = @"Data Source=C:\Users\User\Desktop\GrabDB.db;Version=3;";
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
            try
            {
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
            catch (Exception ex)
            {
                MessageBox.Show("Clear Cart Error: " + ex.Message);
            }
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (cartGrid.Rows.Count == 0)
            {
                MessageBox.Show("Your cart is empty.");
                return;
            }

            MessageBox.Show("Order placed successfully!");

            btnClearCart_Click(sender, e);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }
    }
}