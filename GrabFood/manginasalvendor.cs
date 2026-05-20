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
    public partial class manginasalvendor : Form
    {
        private string connectionString =
        @"Data Source=C:\Users\User\source\repos\GrabFood\GrabFood\bin\x64\Debug\net8.0-windows\GrabDB.db;Version=3;";

        public manginasalvendor()
        {
            InitializeComponent();
        }

        private void manginasalvendor_Load(object sender, EventArgs e)
        {
            cmbCategory.Items.Add("Mang Bundles");
            cmbCategory.Items.Add("Chicken Inasals");
            cmbCategory.Items.Add("Mang Desserts");

            LoadProducts();
        }

        private void LoadProducts()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = @"
                SELECT ProductID, ProductName, Price, Category, ImagePath
                FROM Products
                WHERE Category IN ('Mang Bundles', 'Chicken Inasals', 'Mang Desserts')
                AND IsDeleted = 0";

                SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dgvProducts.DataSource = table;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtPrice.Text == "" || cmbCategory.Text == "")
            {
                MessageBox.Show("Please fill Product Name, Price, and Category.");
                return;
            }

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = @"
                INSERT INTO Products
                (ProductName, Price, Category, Description, ImagePath, RestaurantName)
                VALUES
                (@name, @price, @category, @description, @image, @restaurant)";

                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@price", Convert.ToDouble(txtPrice.Text));
                cmd.Parameters.AddWithValue("@category", cmbCategory.Text);
                cmd.Parameters.AddWithValue("@description", txtDescription.Text);
                cmd.Parameters.AddWithValue("@image", txtImagePath.Text);
                cmd.Parameters.AddWithValue("@restaurant", "Jollibee");

                cmd.ExecuteNonQuery();

                MessageBox.Show("New ProductID: " + conn.LastInsertRowId);
            }

            MessageBox.Show("Product added!");
            ClearFields();
            LoadProducts();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null)
            {
                MessageBox.Show("Select a product first.");
                return;
            }

            int productId = Convert.ToInt32(
                dgvProducts.CurrentRow.Cells["ProductID"].Value
            );

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string deleteCartQuery =
                    "DELETE FROM Cart WHERE ProductId = @id";

                SQLiteCommand cartCmd =
                    new SQLiteCommand(deleteCartQuery, conn);

                cartCmd.Parameters.AddWithValue("@id", productId);
                cartCmd.ExecuteNonQuery();

                string deleteProductQuery = @"
                    UPDATE Products
                    SET IsDeleted = 1
                    WHERE ProductID = @id";

                SQLiteCommand productCmd =
                    new SQLiteCommand(deleteProductQuery, conn);

                productCmd.Parameters.AddWithValue("@id", productId);
                productCmd.ExecuteNonQuery();
            }

            MessageBox.Show("Product deleted!");
            LoadProducts();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 logout = new Form1();
            logout.Show();
            this.Hide();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null)
            {
                MessageBox.Show("Please select a product first.");
                return;
            }

            if (txtName.Text == "" || txtPrice.Text == "" || cmbCategory.Text == "")
            {
                MessageBox.Show("Please fill Product Name, Price, and Category.");
                return;
            }

            int productId = Convert.ToInt32(
                dgvProducts.CurrentRow.Cells["ProductID"].Value
            );

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = @"
                UPDATE Products
                SET ProductName = @name,
                Price = @price,
                Category = @category,
                Description = @description,
                ImagePath = @image
                WHERE ProductID = @id";

                SQLiteCommand cmd = new SQLiteCommand(query, conn);

                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@price", Convert.ToDouble(txtPrice.Text));
                cmd.Parameters.AddWithValue("@category", cmbCategory.Text);
                cmd.Parameters.AddWithValue("@description", txtDescription.Text);
                cmd.Parameters.AddWithValue("@image", txtImagePath.Text);
                cmd.Parameters.AddWithValue("@id", productId);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Product updated!");
            ClearFields();
            LoadProducts();
        }

        private void ClearFields()
        {
            txtName.Clear();
            txtPrice.Clear();
            txtDescription.Clear();
            txtImagePath.Clear();
            cmbCategory.SelectedIndex = -1;
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allow numbers
            if (char.IsDigit(e.KeyChar))
            {
                return;
            }

            // allow backspace
            if (e.KeyChar == (char)8)
            {
                return;
            }

            // allow one decimal point
            if (e.KeyChar == '.' && !txtPrice.Text.Contains("."))
            {
                return;
            }

            // block everything else
            e.Handled = true;
        }
        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string imagesFolder =
                    Path.Combine(Application.StartupPath, "images");

                if (!Directory.Exists(imagesFolder))
                {
                    Directory.CreateDirectory(imagesFolder);
                }

                string uniqueFileName =
                    Path.GetFileNameWithoutExtension(ofd.FileName)
                    + "_" + DateTime.Now.Ticks
                    + Path.GetExtension(ofd.FileName);

                string destinationPath =
                    Path.Combine(imagesFolder, uniqueFileName);

                File.Copy(ofd.FileName, destinationPath);

                txtImagePath.Text = @"images\" + uniqueFileName;
            }
        }
    }
}
