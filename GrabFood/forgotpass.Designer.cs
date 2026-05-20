using System.Drawing;
using System.Windows.Forms;

namespace GrabFood
{
    partial class forgotpass
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private TextBox txtUsername;
        private TextBox txtPhone;
        private TextBox txtNewPassword;
        private Button btnReset;
        private Button btnBack;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            txtUsername = new TextBox();
            txtPhone = new TextBox();
            txtNewPassword = new TextBox();
            btnReset = new Button();
            btnBack = new Button();

            SuspendLayout();

            lblTitle.Text = "Forgot Password";
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Green;
            lblTitle.Location = new Point(120, 30);
            lblTitle.Size = new Size(350, 45);

            txtUsername.PlaceholderText = "Username";
            txtUsername.Location = new Point(120, 100);
            txtUsername.Size = new Size(300, 30);

            txtPhone.PlaceholderText = "Phone Number";
            txtPhone.Location = new Point(120, 145);
            txtPhone.Size = new Size(300, 30);

            txtNewPassword.PlaceholderText = "New Password";
            txtNewPassword.Location = new Point(120, 190);
            txtNewPassword.Size = new Size(300, 30);

            btnReset.Text = "Reset Password";
            btnReset.BackColor = Color.ForestGreen;
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(120, 245);
            btnReset.Size = new Size(145, 40);
            btnReset.Click += btnReset_Click;

            btnBack.Text = "Back";
            btnBack.Location = new Point(275, 245);
            btnBack.Size = new Size(145, 40);
            btnBack.Click += btnBack_Click;

            ClientSize = new Size(550, 340);
            Controls.Add(lblTitle);
            Controls.Add(txtUsername);
            Controls.Add(txtPhone);
            Controls.Add(txtNewPassword);
            Controls.Add(btnReset);
            Controls.Add(btnBack);

            Name = "forgotpass";
            Text = "Forgot Password";
            StartPosition = FormStartPosition.CenterScreen;

            ResumeLayout(false);
            PerformLayout();
        }
    }
}