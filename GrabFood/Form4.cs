using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace GrabFood
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

            textBox4.MaxLength = 11;
            textBox4.KeyPress += textBox4_KeyPress;
        }

        // CONTINUE BUTTON
        

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allow numbers and backspace only
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Enter username.");
                return;
            }

            panel1.Visible = true;

            label4.Visible = true;
            textBox2.Visible = true;

            label5.Visible = true;
            textBox3.Visible = true;

            label6.Visible = true;
            textBox4.Visible = true;

            label7.Visible = true;
            textBox5.Visible = true;

            button2.Visible = true;
        }

        // REGISTER BUTTON
        private void button2_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();
            string confirmPassword = textBox3.Text.Trim();
            string phone = textBox4.Text.Trim();
            string address = textBox5.Text.Trim();

            if (username == "" || password == "" || confirmPassword == "" || phone == "" || address == "")
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            if (phone.Length != 11)
            {
                MessageBox.Show("Phone number must be exactly 11 digits.");
                return;
            }

            using (var conn = Database.GetConnection())
            {
                string query = @"
                INSERT INTO users
                (username, password, phone_number, address, user_role)
                VALUES
                (@u, @p, @ph, @a, 'customer')";

                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@p", password);
                cmd.Parameters.AddWithValue("@ph", phone);
                cmd.Parameters.AddWithValue("@a", address);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Registered successfully!");

            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            textBox4.MaxLength = 11;

            textBox4.KeyPress += textBox4_KeyPress;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load_1(object sender, EventArgs e)
        {

        }

      

    }
}