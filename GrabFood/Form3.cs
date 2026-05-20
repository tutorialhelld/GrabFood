using System;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace GrabFood
{
    public partial class Form3 : Form
    {
        private string connectionString = "Data Source=GrabFood.db;Version=3;";

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            BuildCategories();
            BuildRestaurants();
        }

        private void BuildCategories()
        {
            categoryFlow.Controls.Clear();

            AddCategory("🍗 Fried Chicken", "Fried Chicken");
            AddCategory("🍝 Palabok", "Palabok");
            AddCategory("🍰 Desserts", "Desserts");
            AddCategory("🍟 Fries", "Fries");
            AddCategory("🍖 Inasal / Lechon", "Inasal/Lechon");
        }

        private void AddCategory(string text, string category)
        {
            Button btn = new Button();
            btn.Text = text;
            btn.Size = new Size(170, 45);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = Color.White;
            btn.ForeColor = Color.SeaGreen;
            btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;
            btn.Click += (s, e) => LoadProductsByCategory(category);

            RoundControl(btn, 18);
            categoryFlow.Controls.Add(btn);
        }

        private void BuildRestaurants()
        {
            restaurantFlow.Controls.Clear();

            AddRestaurantCard("Mang Inasal", "Chicken inasal with unlimited rice", "🍗", () =>
            {
                new MangInasal().Show();
                this.Hide();
            });

            AddRestaurantCard("Max's Restaurant", "The house that fried chicken built", "🍖", () =>
            {
                new MAXS().Show();
                this.Hide();
            });

            AddRestaurantCard("Jollibee", "Chickenjoy and Jolly Spaghetti", "🐝", () =>
            {
                new jollibee().Show();
                this.Hide();
            });
        }

        private void AddRestaurantCard(string name, string description, string emoji, Action openForm)
        {
            Panel card = new Panel();
            card.Size = new Size(300, 230);
            card.BackColor = Color.White;
            card.Margin = new Padding(15);
            card.Cursor = Cursors.Hand;

            Label img = new Label();
            img.Text = emoji;
            img.Font = new Font("Segoe UI Emoji", 52, FontStyle.Regular);
            img.TextAlign = ContentAlignment.MiddleCenter;
            img.Dock = DockStyle.Top;
            img.Height = 110;
            img.BackColor = Color.Honeydew;

            Label title = new Label();
            title.Text = name;
            title.Font = new Font("Segoe UI", 15, FontStyle.Bold);
            title.ForeColor = Color.FromArgb(30, 30, 30);
            title.Location = new Point(18, 125);
            title.AutoSize = true;

            Label desc = new Label();
            desc.Text = description;
            desc.Font = new Font("Segoe UI", 9);
            desc.ForeColor = Color.DimGray;
            desc.Location = new Point(20, 160);
            desc.Size = new Size(250, 40);

            Button orderBtn = new Button();
            orderBtn.Text = "View Menu";
            orderBtn.Size = new Size(110, 34);
            orderBtn.Location = new Point(18, 190);
            orderBtn.BackColor = Color.SeaGreen;
            orderBtn.ForeColor = Color.White;
            orderBtn.FlatStyle = FlatStyle.Flat;
            orderBtn.FlatAppearance.BorderSize = 0;
            orderBtn.Cursor = Cursors.Hand;
            orderBtn.Click += (s, e) => openForm();

            card.Controls.Add(orderBtn);
            card.Controls.Add(desc);
            card.Controls.Add(title);
            card.Controls.Add(img);

            card.Click += (s, e) => openForm();
            img.Click += (s, e) => openForm();
            title.Click += (s, e) => openForm();
            desc.Click += (s, e) => openForm();

            RoundControl(card, 25);
            RoundControl(orderBtn, 15);

            restaurantFlow.Controls.Add(card);
        }

        private void LoadProductsByCategory(string categoryName)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT ProductName, Price, Description FROM Products WHERE Category = @Category";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Category", categoryName);

                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            StringBuilder menu = new StringBuilder();
                            menu.AppendLine($"{categoryName.ToUpper()} ITEMS");
                            menu.AppendLine();

                            bool found = false;

                            while (reader.Read())
                            {
                                found = true;

                                string productName = reader["ProductName"].ToString();
                                decimal price = Convert.ToDecimal(reader["Price"]);
                                string description = reader["Description"] == DBNull.Value
                                    ? "Delicious choice!"
                                    : reader["Description"].ToString();

                                menu.AppendLine($"• {productName} - ₱{price:F2}");
                                menu.AppendLine($"  {description}");
                                menu.AppendLine();
                            }

                            if (!found)
                                menu.AppendLine("No products found in this category.");

                            MessageBox.Show(menu.ToString(), "Menu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void linkHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new History().Show();
            this.Hide();
        }

        private void linkOrders_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new orders().Show();
            this.Hide();
        }

        private void RoundControl(Control control, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            control.Region = new Region(path);
        }
    }
}