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


        private void button3_Click(object sender, EventArgs e)
        {
            AddItemToBasket(1, qty1, "Whole Chicken");
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

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
            var checkout = new Checkout();
            checkout.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            AddItemToBasket(2, qty2, "Chicken Combo");
        }


        private void button12_Click(object sender, EventArgs e)
        {
            AddItemToBasket(3, qty3, "Chicken / Fries");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

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

        private void lblPrice1_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            AddItemToBasket(5, qty4, "Basic Chicken Meal");
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button27_Click(object sender, EventArgs e)
        {
            AddItemToBasket(6, qty5, "Chicken Fiesta Meal");
        }

        private void button28_Click(object sender, EventArgs e)
        {
            AddItemToBasket(7, qty6, "Chicken and Macaroni Meal");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddItemToBasket(8, qty7, "Halo-Halo Dessert");
        }

        private void button30_Click(object sender, EventArgs e)
        {
            AddItemToBasket(9, qty8, "Fries");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            AddItemToBasket(10, qty9, "Leche Flan");
        }

        // PRODUCT 1
        private void btnMinus1_Click(object sender, EventArgs e)
        {
            QuantityHelper.Decrease(ref qty1, lblQty1);
        }

        private void btnPlus1_Click(object sender, EventArgs e)
        {
            QuantityHelper.Increase(ref qty1, lblQty1);
        }

        // PRODUCT 2
        private void button18_Click(object sender, EventArgs e)
        {
            QuantityHelper.Decrease(ref qty2, label6);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            QuantityHelper.Increase(ref qty2, label6);
        }

        // PRODUCT 3
        private void button20_Click(object sender, EventArgs e)
        {
            QuantityHelper.Decrease(ref qty3, label7);
        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        // PRODUCT 4
        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click1(object sender, EventArgs e)
        {
            QuantityHelper.Increase(ref qty4, label11);
        }

        // PRODUCT 5
        private void button1_Click1(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            QuantityHelper.Increase(ref qty5, label12);
        }

        // PRODUCT 6
        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click1(object sender, EventArgs e)
        {

        }

        // PRODUCT 7
        private void button15_Click(object sender, EventArgs e)
        {
            QuantityHelper.Decrease(ref qty7, label14);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            QuantityHelper.Increase(ref qty7, label14);
        }

        // PRODUCT 8
        private void button31_Click(object sender, EventArgs e)
        {

        }

        private void button32_Click(object sender, EventArgs e)
        {

        }

        // PRODUCT 9

        private void button17_Click_1(object sender, EventArgs e)
        {
            QuantityHelper.Decrease(ref qty9, label31);
        }
        private void button29_Click(object sender, EventArgs e)
        {

        }


        private void button21_Click_1(object sender, EventArgs e)
        {
            QuantityHelper.Increase(ref qty3, label7);
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            QuantityHelper.Decrease(ref qty4, label11);
        }

        private void button8_Click_2(object sender, EventArgs e)
        {
            QuantityHelper.Increase(ref qty4, label11);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            QuantityHelper.Decrease(ref qty5, label12);
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            QuantityHelper.Decrease(ref qty6, label13);
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            QuantityHelper.Increase(ref qty6, label13);
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            QuantityHelper.Decrease(ref qty7, label14);
        }

        private void button22_Click_1(object sender, EventArgs e)
        {
            QuantityHelper.Increase(ref qty7, label14);
        }

        private void button31_Click_1(object sender, EventArgs e)
        {
            QuantityHelper.Decrease(ref qty8, label34);
        }

        private void button32_Click_1(object sender, EventArgs e)
        {
            QuantityHelper.Increase(ref qty8, label34);
        }

        private void button29_Click_1(object sender, EventArgs e)
        {
            QuantityHelper.Increase(ref qty9, label31);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }
    }
}