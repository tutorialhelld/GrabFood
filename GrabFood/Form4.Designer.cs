namespace GrabFood
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
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
            label1.Font = new Font("Segoe UI", 55F);
            label1.ForeColor = Color.FromArgb(0, 192, 0);
            label1.Location = new Point(214, 9);
            label1.Name = "label1";
            label1.Size = new Size(367, 99);
            label1.TabIndex = 0;
            label1.Text = "GrabFood";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(258, 146);
            label2.Name = "label2";
            label2.Size = new Size(277, 19);
            label2.TabIndex = 1;
            label2.Text = "Enter your username to sign up for this app";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(329, 125);
            label3.Name = "label3";
            label3.Size = new Size(141, 21);
            label3.TabIndex = 2;
            label3.Text = "Create an account";
            label3.Click += label3_Click;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(248, 168);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Horizontal;
            textBox1.Size = new Size(297, 29);
            textBox1.TabIndex = 3;
            textBox1.Text = "Username";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(248, 220);
            button1.Name = "button1";
            button1.Size = new Size(297, 30);
            button1.TabIndex = 4;
            button1.Text = "Continue";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(-5, 271);
            panel1.Name = "panel1";
            panel1.Size = new Size(809, 10);
            panel1.TabIndex = 5;
            panel1.Visible = false;
            panel1.VisibleChanged += Form4_Load;
            panel1.Paint += panel1_Paint;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(68, 349);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.ScrollBars = ScrollBars.Horizontal;
            textBox2.Size = new Size(297, 29);
            textBox2.TabIndex = 6;
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.Visible = false;
            textBox2.TextChanged += textBox2_TextChanged;
            textBox2.VisibleChanged += button1_Click;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(68, 436);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.ScrollBars = ScrollBars.Horizontal;
            textBox3.Size = new Size(297, 29);
            textBox3.TabIndex = 7;
            textBox3.TextAlign = HorizontalAlignment.Center;
            textBox3.Visible = false;
            textBox3.TextChanged += textBox3_TextChanged;
            textBox3.VisibleChanged += button1_Click;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(464, 349);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.ScrollBars = ScrollBars.Horizontal;
            textBox4.Size = new Size(297, 29);
            textBox4.TabIndex = 8;
            textBox4.TextAlign = HorizontalAlignment.Center;
            textBox4.Visible = false;
            textBox4.TextChanged += textBox4_TextChanged;
            textBox4.VisibleChanged += button1_Click;
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(464, 436);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.ScrollBars = ScrollBars.Horizontal;
            textBox5.Size = new Size(297, 29);
            textBox5.TabIndex = 9;
            textBox5.TextAlign = HorizontalAlignment.Center;
            textBox5.Visible = false;
            textBox5.TextChanged += textBox5_TextChanged;
            textBox5.VisibleChanged += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(68, 327);
            label4.Name = "label4";
            label4.Size = new Size(67, 19);
            label4.TabIndex = 10;
            label4.Text = "Password";
            label4.Visible = false;
            label4.VisibleChanged += button1_Click;
            label4.Click += label4_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(68, 414);
            label5.Name = "label5";
            label5.Size = new Size(120, 19);
            label5.TabIndex = 11;
            label5.Text = "Confirm Password";
            label5.Visible = false;
            label5.VisibleChanged += button1_Click;
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(464, 327);
            label6.Name = "label6";
            label6.Size = new Size(102, 19);
            label6.TabIndex = 12;
            label6.Text = "Phone Number";
            label6.Visible = false;
            label6.VisibleChanged += button1_Click;
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(464, 414);
            label7.Name = "label7";
            label7.Size = new Size(58, 19);
            label7.TabIndex = 13;
            label7.Text = "Address";
            label7.Visible = false;
            label7.VisibleChanged += button1_Click;
            label7.Click += label7_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 192, 0);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.ControlText;
            button2.Location = new Point(248, 497);
            button2.Name = "button2";
            button2.Size = new Size(297, 30);
            button2.TabIndex = 14;
            button2.Text = "Continue";
            button2.UseVisualStyleBackColor = false;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 556);
            Controls.Add(button2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
    }
}