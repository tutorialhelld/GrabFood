using System;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Data;

namespace GrabFood
{
    public partial class MAXRES : Form
    {
        // Path mapped directly to the local file generated/modified via DB Browser
        private string connectionString = @"Data Source=C:\Users\User\Desktop\GrabDB.db;Version=3;";

        public MAXRES()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Inserts items to your Cart table using explicit Row IDs from your SQLite DB Browser layout.
        /// </summary>
        private void AddItemToBasket(int productId, int quantity, string customOptions)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();

                    string checkQuery = "SELECT CartId FROM Cart WHERE ProductId = @id";

                    using (SQLiteCommand checkCmd = new SQLiteCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@id", productId);

                        object result = checkCmd.ExecuteScalar();

                        if (result != null)
                        {
                            string updateQuery = "UPDATE Cart SET Quantity = Quantity + @qty WHERE ProductId = @id";

                            using (SQLiteCommand updateCmd = new SQLiteCommand(updateQuery, conn))
                            {
                                updateCmd.Parameters.AddWithValue("@qty", quantity);
                                updateCmd.Parameters.AddWithValue("@id", productId);
                                updateCmd.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            string insertQuery = @"
                    INSERT INTO Cart (ProductId, Quantity, Customizations)
                    VALUES (@id, @qty, @options)";

                            using (SQLiteCommand insertCmd = new SQLiteCommand(insertQuery, conn))
                            {
                                insertCmd.Parameters.AddWithValue("@id", productId);
                                insertCmd.Parameters.AddWithValue("@qty", quantity);
                                insertCmd.Parameters.AddWithValue("@options", customOptions);
                                insertCmd.ExecuteNonQuery();
                            }
                        }
                    }
                }

                MessageBox.Show("Item added to basket!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Write Error: " + ex.Message);
            }
        }

        // --- BACKEND HOOKS FOR FRONTEND DESIGNER BUTTONS ---

        // Tab 1: Bundles Button Click -> Adds Product ID 1
        int qty1 = 1;
        int qty2 = 1;
        int qty3 = 1;
        int qty4 = 1;
        int qty5 = 1;
        int qty6 = 1;
        int qty7 = 1;
        int qty8 = 1;
        int qty9 = 1;
        int qty10 = 1;
        int qty11 = 1;
        int qty12 = 1;
        int qty13 = 1;
        int qty14 = 1;
        int qty15 = 1;
        int qty16 = 1;
        int qty17 = 1;
        int qty18 = 1;
        
        private void button3_Click(object sender, EventArgs e)
        {
            AddItemToBasket(1, qty1,"Whole Chicken");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddItemToBasket(2, qty2, "Chicken Combo");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            AddItemToBasket(4, qty3,"Burger/Fries");
        }

        // Tab 4: YumBurger Button Click -> Adds Product ID 5
        private void button14_Click(object sender, EventArgs e)
        {
            AddItemToBasket(5, qty4, "Upgrade to Large Combo");
        }

        // Tab 5: Desserts Button Click -> Adds Product ID 6
        private void button17_Click(object sender, EventArgs e)
        {
            AddItemToBasket(6, qty5, "Extra Crispy Crust Pie");
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Open the Checkout form (designer wires this event).
            var checkout = new Checkout();
            checkout.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddItemToBasket(12, qty6, "Seafood Platter");
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            AddItemToBasket(7, qty7, "Seafood Platter");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            AddItemToBasket(8, qty8, "Familyfood Combo");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddItemToBasket(9, qty9, "Family Combo Size Pack");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddItemToBasket(10, qty10, "Family Combo Size Pack");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            AddItemToBasket(11, qty11, "Family Combo Size Pack");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AddItemToBasket(13, qty12, "Family Combo Size Pack");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AddItemToBasket(14, qty13, "Family Combo Size Pack");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddItemToBasket(15, qty14, "Family Combo Size Pack");
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            AddItemToBasket(16, qty15, "Family Combo Size Pack");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            AddItemToBasket(17, qty16, "Family Combo Size Pack");
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            AddItemToBasket(18, qty17, "Family Combo Size Pack");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            AddItemToBasket(19, qty18, "Family Combo Size Pack");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void MAXRES_Load(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMinus1_Click(object sender, EventArgs e)
        {
            if (qty1 > 1)
            {
                qty1--;
                lblQty1.Text = qty1.ToString();
            }
        }

        private void btnPlus1_Click(object sender, EventArgs e)
        {
            qty1++;
            lblQty1.Text = qty1.ToString();
        }

    }
}