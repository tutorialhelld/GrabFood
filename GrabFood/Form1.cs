using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace GrabFood
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var conn = Database.GetConnection())
            {
                string query = @"
        SELECT * FROM users
        WHERE TRIM(username) = @u
        AND TRIM(password) = @p";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@u", textBox1.Text.Trim());
                    cmd.Parameters.AddWithValue("@p", textBox2.Text.Trim());

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string role =
                                reader["user_role"]
                                .ToString()
                                .Trim()
                                .ToLower();

                            MessageBox.Show(
                                "Login successful! Role: " + role
                            );

                            if (role == "admin")
                            {
                                UserControl admin =
                                    new UserControl();

                                admin.Show();
                            }
                            else if (role == "rider")
                            {
                                ActiveDelivery rider =
                                    new ActiveDelivery();

                                rider.Show();
                            }
                            else
                            {
                                Form3 user =
                                    new Form3();

                                user.Show();
                            }

                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show(
                                "Invalid username or password."
                            );
                        }
                    }
                }
            }
        }

        private void linkLabel2_LinkClicked(
            object sender,
            LinkLabelLinkClickedEventArgs e)
        {
            Form4 register = new Form4();
            register.Show();

            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}