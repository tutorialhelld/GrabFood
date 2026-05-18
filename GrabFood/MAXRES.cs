using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace GrabFood
{
    public partial class MAXRES : Form
    {
        // Path mapped directly to the local file generated/modified via DB Browser
        private string connectionString = "Data Source=GrabFood.db;Version=3;";

        public MAXRES()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Inserts items to your Cart table using explicit Row IDs from your SQLite DB Browser layout.
        /// </summary>
        private void AddItemToBasket(int productId, string customOptions)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Cart (ProductId, Quantity, Customizations) VALUES (@id, 1, @options)";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", productId);
                        cmd.Parameters.AddWithValue("@options", customOptions);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Item added to basket!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Write Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- BACKEND HOOKS FOR FRONTEND DESIGNER BUTTONS ---

        // Tab 1: Bundles Button Click -> Adds Product ID 1
        private void button3_Click(object sender, EventArgs e)
        {
            AddItemToBasket(1, "Family Combo Size Pack");
        }

        // Tab 2: ChickenJoy Button Click -> Adds Product ID 2
        private void button8_Click(object sender, EventArgs e)
        {
            AddItemToBasket(2, "Regular Fries / Pineapple Juice");
        }

        // Tab 3: Jolly Spaghetti Button Click -> Adds Product ID 4
        private void button11_Click(object sender, EventArgs e)
        {
            AddItemToBasket(4, "Double Sauce Portion");
        }

        // Tab 4: YumBurger Button Click -> Adds Product ID 5
        private void button14_Click(object sender, EventArgs e)
        {
            AddItemToBasket(5, "Upgrade to Large Combo");
        }

        // Tab 5: Desserts Button Click -> Adds Product ID 6
        private void button17_Click(object sender, EventArgs e)
        {
            AddItemToBasket(6, "Extra Crispy Crust Pie");
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }
    }
}