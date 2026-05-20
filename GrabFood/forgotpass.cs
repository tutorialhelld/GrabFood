using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace GrabFood
{
    public partial class forgotpass : Form
    {
        public forgotpass()
        {
            InitializeComponent();

            txtPhone.MaxLength = 11;
            txtPhone.KeyPress += txtPhone_KeyPress;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string newPassword = txtNewPassword.Text.Trim();

            if (username == "" || phone == "" || newPassword == "")
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            if (phone.Length != 11)
            {
                MessageBox.Show("Phone number must be exactly 11 digits.");
                return;
            }

            using (var conn = Database.GetConnection())
            {
                string checkQuery = @"
                SELECT COUNT(*)
                FROM users
                WHERE username = @u
                AND phone_number = @ph";

                SQLiteCommand checkCmd = new SQLiteCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@u", username);
                checkCmd.Parameters.AddWithValue("@ph", phone);

                int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (count == 0)
                {
                    MessageBox.Show("Username and phone number do not match.");
                    return;
                }

                string updateQuery = @"
                UPDATE users
                SET password = @p
                WHERE username = @u
                AND phone_number = @ph";

                SQLiteCommand updateCmd = new SQLiteCommand(updateQuery, conn);
                updateCmd.Parameters.AddWithValue("@p", newPassword);
                updateCmd.Parameters.AddWithValue("@u", username);
                updateCmd.Parameters.AddWithValue("@ph", phone);

                updateCmd.ExecuteNonQuery();
            }

            MessageBox.Show("Password reset successful!");

            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }
    }
}