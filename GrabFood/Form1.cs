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
            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "")
            {
                MessageBox.Show("No account detected. Please enter username and password.");
                return;
            }

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
                            string username = reader["username"].ToString().Trim();

                            string role = reader["user_role"]
                                .ToString()
                                .Trim()
                                .ToLower();

                            Session.Username = username;
                            Session.Address = reader["address"].ToString();

                            if (role == "admin")
                            {
                                new UserControl().Show();
                            }
                            else if (role == "rider")
                            {
                                new ActiveDelivery().Show();
                            }
                            else if (role == "jollibeevendor")
                            {
                                new jollibeevendor().Show();
                            }
                            else if (role == "maxvendor")
                            {
                                new maxvendor().Show();
                            }
                            else if (role == "manginasalvendor")
                            {
                                new manginasalvendor().Show();
                            }
                            else if (role == "customer")
                            {
                                new Form3().Show();
                            }
                            else
                            {
                                MessageBox.Show("Unknown role.");
                                return;
                            }

                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect username or password.");
                        }
                    }
                }
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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