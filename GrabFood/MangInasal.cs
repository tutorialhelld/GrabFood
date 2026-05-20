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
    public partial class MangInasal : Form
    {
        private string connectionString =
            @"Data Source=C:\Users\User\source\repos\GrabFood\GrabFood\bin\x64\Debug\net8.0-windows\GrabDB.db;Version=3;";

        public MangInasal()
        {
            InitializeComponent();
        }

        private void MangInasal_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            flowFaves.Controls.Clear();
            flowChicken.Controls.Clear();
            flowDesserts.Controls.Clear();

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = @"
                SELECT ProductID, ProductName, Price, Category, ImagePath, Description
                FROM Products
                WHERE Category IN ('Mang Bundles', 'Chicken Inasals', 'Mang Desserts')
                AND IsDeleted = 0";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["ProductID"]);
                        string name = reader["ProductName"].ToString();
                        double price = Convert.ToDouble(reader["Price"]);
                        string description = reader["Description"].ToString();
                        string category = reader["Category"].ToString();
                        
                        string imagePath = reader["ImagePath"] == DBNull.Value
                            ? ""
                            : reader["ImagePath"].ToString();


                        if (category == "Mang Bundles" || category == "Mang Bundles")
                        {
                            AddProduct(flowFaves, id, name, price, category, imagePath, description);
                        }
                        else if (category == "Chicken Inasals" || category == "Chicken Inasals")
                        {
                            AddProduct(flowChicken, id, name, price, category, imagePath, description);
                        }
                        else if (category == "Mang Desserts" || category == "Mang Dessert")
                        {
                            AddProduct(flowDesserts, id, name, price, category, imagePath, description);
                        }
                    }
                }
            }
        }

        private void AddProduct(
        FlowLayoutPanel flow,
        int productId,
        string productName,
        double price,
        string category,
        string imagePath,
        string description)
        {
            int qty = 1;

            Panel card = new Panel();
            card.Width = 860;
            card.Height = 130;
            card.BorderStyle = BorderStyle.FixedSingle;
            card.Margin = new Padding(5, 5, 5, 15);
            card.BackColor = Color.White;

            Label lblName = new Label();
            lblName.Text = productName;
            lblName.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblName.Location = new Point(160, 20);
            lblName.Size = new Size(350, 30);

            Label lblCategory = new Label();
            lblCategory.Text = category;
            lblCategory.Font = new Font("Segoe UI", 10);
            lblCategory.ForeColor = Color.Gray;
            lblCategory.Location = new Point(160, 55);
            lblCategory.Size = new Size(250, 25);

            Label lblDescription = new Label();
            lblDescription.Text = description;
            lblDescription.Font = new Font("Segoe UI", 9);
            lblDescription.ForeColor = Color.DimGray;
            lblDescription.Location = new Point(160, 80);
            lblDescription.Size = new Size(330, 25);

            Label lblPrice = new Label();
            lblPrice.Text = "₱" + price.ToString("0.00");
            lblPrice.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblPrice.ForeColor = Color.Green;
            lblPrice.Location = new Point(160, 105);
            lblPrice.Size = new Size(120, 25);

            Button btnMinus = new Button();
            btnMinus.Text = "-";
            btnMinus.Location = new Point(520, 50);
            btnMinus.Size = new Size(35, 30);

            Label lblQty = new Label();
            lblQty.Text = qty.ToString();
            lblQty.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            lblQty.TextAlign = ContentAlignment.MiddleCenter;
            lblQty.Location = new Point(560, 50);
            lblQty.Size = new Size(35, 30);

            Button btnPlus = new Button();
            btnPlus.Text = "+";
            btnPlus.Location = new Point(600, 50);
            btnPlus.Size = new Size(35, 30);

            Button btnAdd = new Button();
            btnAdd.Text = "Add To Basket";
            btnAdd.BackColor = Color.ForestGreen;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(680, 45);
            btnAdd.Size = new Size(150, 40);
            btnAdd.UseVisualStyleBackColor = false;

            PictureBox pic = new PictureBox();
            pic.Location = new Point(20, 20);
            pic.Size = new Size(120, 90);
            pic.SizeMode = PictureBoxSizeMode.StretchImage;

            if (!string.IsNullOrWhiteSpace(imagePath))
            {
                string fullImagePath =
                    Path.Combine(Application.StartupPath, imagePath);

                if (File.Exists(fullImagePath))
                {
                    pic.Image = Image.FromFile(fullImagePath);
                }
            }

            card.Controls.Add(pic);

            btnMinus.Click += (s, e) =>
            {
                if (qty > 1
                )
                {
                    qty--;
                    lblQty.Text = qty.ToString();
                }
            };

            btnPlus.Click += (s, e) =>
            {
                qty++;
                lblQty.Text = qty.ToString();
            };

            btnAdd.Click += (s, e) =>
            {
                AddItemToBasket(productId, qty, productName);
            };

            card.Controls.Add(lblName);
            card.Controls.Add(lblCategory);
            card.Controls.Add(lblPrice);
            card.Controls.Add(btnMinus);
            card.Controls.Add(lblQty);
            card.Controls.Add(btnPlus);
            card.Controls.Add(btnAdd);
            card.Controls.Add(lblDescription);

            flow.Controls.Add(card);
        }

        private void AddItemToBasket(int productId, int quantity, string customOptions)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();

                    string checkQuery =
                        "SELECT CartId FROM Cart WHERE ProductId = @id";

                    using (SQLiteCommand checkCmd =
                           new SQLiteCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@id", productId);

                        object result = checkCmd.ExecuteScalar();

                        if (result != null)
                        {
                            string updateQuery =
                                "UPDATE Cart SET Quantity = Quantity + @qty WHERE ProductId = @id";

                            using (SQLiteCommand updateCmd =
                                   new SQLiteCommand(updateQuery, conn))
                            {
                                updateCmd.Parameters.AddWithValue("@qty", quantity);
                                updateCmd.Parameters.AddWithValue("@id", productId);
                                updateCmd.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            string insertQuery = @"
                            INSERT INTO Cart
                            (ProductId, Quantity, Customizations)
                            VALUES
                            (@id, @qty, @options)";

                            using (SQLiteCommand insertCmd =
                                   new SQLiteCommand(insertQuery, conn))
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
        private void btnCart_Click(object sender, EventArgs e)
        {
            Checkout checkout = new Checkout();
            checkout.Show();
            this.Hide();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Form3 dashboard = new Form3();
            dashboard.Show();
            this.Hide();
        }
    }
}
