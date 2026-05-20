namespace GrabFood
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private LinkLabel linkLabel2;
        private Label label3;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            linkLabel2 = new LinkLabel();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(56, 129);
            label1.Name = "label1";
            label1.Size = new Size(87, 21);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(56, 196);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(56, 153);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(300, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(56, 220);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(300, 23);
            textBox2.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(56, 298);
            button1.Name = "button1";
            button1.Size = new Size(300, 45);
            button1.TabIndex = 5;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(166, 363);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(89, 15);
            linkLabel2.TabIndex = 6;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Create Account";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            label3.ForeColor = Color.Green;
            label3.Location = new Point(79, 36);
            label3.Name = "label3";
            label3.Size = new Size(213, 47);
            label3.TabIndex = 0;
            label3.Text = "GRABFOOD";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(362, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(439, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(149, 392);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(127, 15);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgot your password?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(linkLabel2);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "Form1";
            Text = "GrabFood Login";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private LinkLabel linkLabel1;
    }
}