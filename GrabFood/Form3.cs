using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite; // Swapped to use your installed provider!

namespace GrabFood
{
    public partial class Form3 : Form
    {
        // Connection string configured for System.Data.SQLite
        private string connectionString = "Data Source=GrabFood.db;Version=3;";

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // Dashboard loaded successfully
        }

        /// <summary>
        /// Reads data from your existing SQLite database using System.Data.SQLite
        /// </summary>
        private void LoadProductsByCategory(string categoryName)
        {
            try
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT ProductName, Price, Description FROM Products WHERE Category = @Category";

                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Category", categoryName);

                        using (var reader = command.ExecuteReader())
                        {
                            StringBuilder menuBuilder = new StringBuilder();
                            menuBuilder.AppendLine($"--- {categoryName.ToUpper()} ITEMS ---\n");

                            bool itemsFound = false;
                            while (reader.Read())
                            {
                                itemsFound = true;
                                string productName = reader.GetString(0);
                                double price = reader.GetDouble(1);
                                string description = reader.IsDBNull(2) ? "Delicious choice!" : reader.GetString(2);

                                menuBuilder.AppendLine($"🍗 {productName} - ₱{price:F2}");
                                menuBuilder.AppendLine($"   Description: {description}\n");
                            }

                            if (!itemsFound)
                            {
                                menuBuilder.AppendLine("No dishes found under this category right now.");
                            }

                            MessageBox.Show(menuBuilder.ToString(), $"{categoryName} Menu Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database read error: {ex.Message}", "SQLite Core Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- Category Event Mappings ---

        private void button4_Click(object sender, EventArgs e)
        {
            LoadProductsByCategory("Fried Chicken");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadProductsByCategory("Palabok");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoadProductsByCategory("Desserts");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LoadProductsByCategory("Fries");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            LoadProductsByCategory("Inasal/Lechon");
        }

        // --- Navigation Actions ---

        private void button10_Click(object sender, EventArgs e)
        {
            MAXS max = new MAXS();
            max.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            jollibee jabee = new jollibee();
            jabee.Show();
            this.Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Loading Mang Inasal restaurant profile details...", "Mang Inasal Selection");
        }

        // --- Graphical Canvas Operations ---

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            RoundPanel(panel2, 25);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        // --- Structural UI Stub Safety Measures ---
        private void pictureBox1_Click(object sender, System.EventArgs e)
        {

        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            History history = new History();
            history.Show();
            this.Hide();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void label13_Click(object sender, EventArgs e)
        {

        }
        private void label12_Click(object sender, EventArgs e)
        {

        }
        private void label15_Click(object sender, EventArgs e)
        {

        }
        private void label18_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            MangInasal mang = new MangInasal();
            mang.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 logout = new Form1();
            logout.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            orders orders = new orders();
            orders.Show();
            this.Hide();
        }
    }
}