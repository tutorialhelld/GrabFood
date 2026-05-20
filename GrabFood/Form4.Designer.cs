namespace GrabFood
{
    partial class Form4
    {
        private System.ComponentModel.IContainer components = null;

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Button button1;
        private Panel panel1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button2;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            panel1 = new Panel();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 40F, FontStyle.Bold);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(220, 20);
            label1.Name = "label1";
            label1.Size = new Size(326, 72);
            label1.TabIndex = 0;
            label1.Text = "GRABFOOD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(250, 145);
            label2.Name = "label2";
            label2.Size = new Size(285, 19);
            label2.TabIndex = 1;
            label2.Text = "Enter your username to continue registration";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label3.Location = new Point(295, 110);
            label3.Name = "label3";
            label3.Size = new Size(203, 30);
            label3.TabIndex = 2;
            label3.Text = "Create an Account";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 11F);
            textBox1.Location = new Point(250, 180);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(300, 35);
            textBox1.TabIndex = 3;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(250, 235);
            button1.Name = "button1";
            button1.Size = new Size(300, 40);
            button1.TabIndex = 4;
            button1.Text = "Continue";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(0, 300);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 5);
            panel1.TabIndex = 5;
            panel1.Visible = false;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 11F);
            textBox2.Location = new Point(70, 355);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(280, 35);
            textBox2.TabIndex = 7;
            textBox2.Visible = false;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 11F);
            textBox3.Location = new Point(70, 435);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.Size = new Size(280, 35);
            textBox3.TabIndex = 9;
            textBox3.Visible = false;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 11F);
            textBox4.Location = new Point(450, 355);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(280, 35);
            textBox4.TabIndex = 11;
            textBox4.Visible = false;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 11F);
            textBox5.Location = new Point(450, 435);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(280, 35);
            textBox5.TabIndex = 13;
            textBox5.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(70, 330);
            label4.Name = "label4";
            label4.Size = new Size(67, 19);
            label4.TabIndex = 6;
            label4.Text = "Password";
            label4.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(70, 410);
            label5.Name = "label5";
            label5.Size = new Size(120, 19);
            label5.TabIndex = 8;
            label5.Text = "Confirm Password";
            label5.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(450, 330);
            label6.Name = "label6";
            label6.Size = new Size(102, 19);
            label6.TabIndex = 10;
            label6.Text = "Phone Number";
            label6.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(450, 410);
            label7.Name = "label7";
            label7.Size = new Size(58, 19);
            label7.TabIndex = 12;
            label7.Text = "Address";
            label7.Visible = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Green;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(250, 500);
            button2.Name = "button2";
            button2.Size = new Size(300, 40);
            button2.TabIndex = 14;
            button2.Text = "Register";
            button2.UseVisualStyleBackColor = false;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 600);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label7);
            Controls.Add(textBox5);
            Controls.Add(button2);
            Name = "Form4";
            Text = "GrabFood Register";
            Load += Form4_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}