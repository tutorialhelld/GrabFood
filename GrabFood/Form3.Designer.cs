using System.Drawing.Drawing2D;

namespace GrabFood
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            panel1 = new Panel();
            linkLabel2 = new LinkLabel();
            linkLabel1 = new LinkLabel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label5 = new Label();
            label6 = new Label();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            pictureBox9 = new PictureBox();
            label12 = new Label();
            label13 = new Label();
            pictureBox10 = new PictureBox();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            pictureBox11 = new PictureBox();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(linkLabel2);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1142, 57);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // linkLabel2
            // 
            linkLabel2.ActiveLinkColor = Color.Lime;
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Segoe UI", 12F);
            linkLabel2.LinkColor = Color.SeaGreen;
            linkLabel2.Location = new Point(288, 17);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(60, 21);
            linkLabel2.TabIndex = 2;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "History";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Lime;
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 12F);
            linkLabel1.LinkColor = Color.SeaGreen;
            linkLabel1.Location = new Point(229, 17);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(53, 21);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Offers";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, -16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(191, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 72);
            panel2.Name = "panel2";
            panel2.Size = new Size(1118, 246);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ImageAlign = ContentAlignment.MiddleRight;
            label4.Location = new Point(60, 128);
            label4.Name = "label4";
            label4.Size = new Size(343, 21);
            label4.TabIndex = 3;
            label4.Text = "Relish the authentic taste of Filipino cuisine";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.ImageAlign = ContentAlignment.TopRight;
            label3.Location = new Point(60, 51);
            label3.Name = "label3";
            label3.Size = new Size(217, 64);
            label3.TabIndex = 2;
            label3.Text = "LUTONG BAHAY,\r\nLASANG PINOY\r\n";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.ImageAlign = ContentAlignment.MiddleRight;
            label2.Location = new Point(60, 18);
            label2.Name = "label2";
            label2.Size = new Size(124, 17);
            label2.TabIndex = 1;
            label2.Text = "PABORITO NG BAYAN";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(40, 321);
            label5.Name = "label5";
            label5.Size = new Size(156, 28);
            label5.TabIndex = 8;
            label5.Text = "Pinoy Favorites";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Light", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(40, 349);
            label6.Name = "label6";
            label6.Size = new Size(167, 13);
            label6.TabIndex = 9;
            label6.Text = "The most loved Filipino Restaurants";
            label6.Click += label6_Click;
            // 
            // button9
            // 
            button9.Location = new Point(40, 365);
            button9.Name = "button9";
            button9.Size = new Size(257, 250);
            button9.TabIndex = 10;
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Location = new Point(303, 365);
            button10.Name = "button10";
            button10.Size = new Size(207, 250);
            button10.TabIndex = 11;
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Location = new Point(514, 365);
            button11.Name = "button11";
            button11.Size = new Size(205, 266);
            button11.TabIndex = 12;
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(40, 365);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(257, 175);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 23;
            pictureBox9.TabStop = false;
            pictureBox9.Click += pictureBox9_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(49, 543);
            label12.Name = "label12";
            label12.Size = new Size(139, 27);
            label12.TabIndex = 24;
            label12.Text = "Mang Inasal";
            label12.Click += label12_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(49, 573);
            label13.Name = "label13";
            label13.Size = new Size(206, 30);
            label13.TabIndex = 25;
            label13.Text = "Home to the famous chicken\r\ninasal with unlimited rice experience";
            label13.Click += label13_Click;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.Location = new Point(303, 365);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(205, 108);
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox10.TabIndex = 26;
            pictureBox10.TabStop = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(305, 481);
            label14.Name = "label14";
            label14.Size = new Size(164, 23);
            label14.TabIndex = 27;
            label14.Text = "Max's Restaurant";
            label14.Click += label14_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(305, 517);
            label15.Name = "label15";
            label15.Size = new Size(203, 14);
            label15.TabIndex = 28;
            label15.Text = "Filipino | the house that fried chicken built";
            label15.Click += label15_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.ForestGreen;
            label16.Location = new Point(305, 545);
            label16.Name = "label16";
            label16.Size = new Size(126, 23);
            label16.TabIndex = 29;
            label16.Text = "Free Delivery";
            // 
            // pictureBox11
            // 
            pictureBox11.Image = (Image)resources.GetObject("pictureBox11.Image");
            pictureBox11.Location = new Point(514, 365);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(205, 132);
            pictureBox11.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox11.TabIndex = 30;
            pictureBox11.TabStop = false;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(518, 508);
            label17.Name = "label17";
            label17.Size = new Size(80, 23);
            label17.TabIndex = 31;
            label17.Text = "Jollibee";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.Location = new Point(514, 543);
            label18.Name = "label18";
            label18.Size = new Size(191, 14);
            label18.TabIndex = 32;
            label18.Text = "Fast Food | Chicken joy | jolly spaghetti";
            label18.Click += label18_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.ForestGreen;
            label19.Location = new Point(516, 567);
            label19.Name = "label19";
            label19.Size = new Size(78, 23);
            label19.TabIndex = 33;
            label19.Text = "20% Off";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1142, 744);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(pictureBox11);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(pictureBox10);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(pictureBox9);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form3";
            Text = "GrabFood Home";
            Load += Form3_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void RoundPanel(Panel panel, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            path.AddArc(new Rectangle(panel.Width - radius, 0, radius, radius), 270, 90);
            path.AddArc(new Rectangle(panel.Width - radius, panel.Height - radius, radius, radius), 0, 90);
            path.AddArc(new Rectangle(0, panel.Height - radius, radius, radius), 90, 90);
            path.CloseFigure();
            panel.Region = new Region(path);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private Panel panel2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label6;
        private Button button9;
        private Button button10;
        private Button button11;
        private PictureBox pictureBox9;
        private Label label12;
        private Label label13;
        private PictureBox pictureBox10;
        private Label label14;
        private Label label15;
        private Label label16;
        private PictureBox pictureBox11;
        private Label label17;
        private Label label18;
        private Label label19;
    }
}