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
                string query =
                    "SELECT * FROM users WHERE username=@u AND password=@p";

                SQLiteCommand cmd =
                    new SQLiteCommand(query, conn);

                cmd.Parameters.AddWithValue("@u", textBox1.Text);
                cmd.Parameters.AddWithValue("@p", textBox2.Text);

                SQLiteDataReader reader =
                    cmd.ExecuteReader();

                if (reader.Read())
                {
                    MessageBox.Show("Login successful!");

                    Form3 dashboard = new Form3();
                    dashboard.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
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
    }
}