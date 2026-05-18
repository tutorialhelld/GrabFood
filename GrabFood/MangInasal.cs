using System;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Data;

namespace GrabFood
{
    public partial class MangInasal : Form
    {
        private string connectionString = "Data Source=GrabFood.db;Version=3;";

        public MangInasal()
        {
            InitializeComponent();
        }

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

        private void MangInasal_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }



       
        // Example buttons for Mang Inasal products

        private void button3_Click(object sender, EventArgs e)
        {
            AddItemToBasket(7, "Chicken Inasal Regular");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddItemToBasket(8, "Paa Large with Rice");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            AddItemToBasket(9, "Pecho with Unlimited Rice");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            AddItemToBasket(10, "Pork BBQ Meal");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            AddItemToBasket(11, "Palabok with Chicken Oil");
        }

            

    }
}