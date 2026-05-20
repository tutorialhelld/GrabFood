using System.Drawing;
using System.Windows.Forms;

namespace GrabFood
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            topPanel = new Panel();
            btnLogout = new Button();
            linkOrders = new LinkLabel();
            linkHistory = new LinkLabel();
            lblLogo = new Label();

            heroPanel = new Panel();
            lblHeroBadge = new Label();
            lblHeroSubtitle = new Label();
            lblHeroTitle = new Label();
            heroImage = new PictureBox();

            lblCategoryTitle = new Label();
            categoryFlow = new FlowLayoutPanel();

            lblRestaurantTitle = new Label();
            lblRestaurantSub = new Label();
            restaurantFlow = new FlowLayoutPanel();

            topPanel.SuspendLayout();
            heroPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)heroImage).BeginInit();
            SuspendLayout();

            // topPanel
            topPanel.BackColor = Color.White;
            topPanel.Controls.Add(btnLogout);
            topPanel.Controls.Add(linkOrders);
            topPanel.Controls.Add(linkHistory);
            topPanel.Controls.Add(lblLogo);
            topPanel.Dock = DockStyle.Top;
            topPanel.Height = 65;

            // lblLogo
            lblLogo.Text = "GrabFood";
            lblLogo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblLogo.ForeColor = Color.SeaGreen;
            lblLogo.Location = new Point(25, 15);
            lblLogo.AutoSize = true;

            // linkHistory
            linkHistory.Text = "History";
            linkHistory.Font = new Font("Segoe UI", 11F);
            linkHistory.LinkColor = Color.SeaGreen;
            linkHistory.Location = new Point(210, 23);
            linkHistory.AutoSize = true;
            linkHistory.LinkClicked += linkHistory_LinkClicked;

            // linkOrders
            linkOrders.Text = "Orders";
            linkOrders.Font = new Font("Segoe UI", 11F);
            linkOrders.LinkColor = Color.SeaGreen;
            linkOrders.Location = new Point(285, 23);
            linkOrders.AutoSize = true;
            linkOrders.LinkClicked += linkOrders_LinkClicked;

            // btnLogout
            btnLogout.Text = "Log Out";
            btnLogout.BackColor = Color.SeaGreen;
            btnLogout.ForeColor = Color.White;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLogout.Size = new Size(100, 35);
            btnLogout.Location = new Point(1010, 15);
            btnLogout.Click += btnLogout_Click;

            // heroPanel
            heroPanel.BackColor = Color.FromArgb(232, 245, 233);
            heroPanel.Location = new Point(25, 90);
            heroPanel.Size = new Size(1090, 240);
            heroPanel.BorderStyle = BorderStyle.None;
            heroPanel.Controls.Add(heroImage);
            heroPanel.Controls.Add(lblHeroBadge);
            heroPanel.Controls.Add(lblHeroSubtitle);
            heroPanel.Controls.Add(lblHeroTitle);

            // heroImage
            heroImage.Image = Image.FromFile(
            @"C:\Users\User\source\repos\GrabFood\GrabFood\bin\x64\Debug\net8.0-windows\images\bowlplatedshrimp.jpg");
            heroImage.SizeMode = PictureBoxSizeMode.Zoom;
            heroImage.Size = new Size(380, 220);
            heroImage.Location = new Point(680, 5);
            heroImage.BackColor = Color.Transparent;

            // lblHeroBadge
            lblHeroBadge.Text = "PABORITO NG BAYAN";
            lblHeroBadge.BackColor = Color.SeaGreen;
            lblHeroBadge.ForeColor = Color.White;
            lblHeroBadge.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblHeroBadge.Location = new Point(35, 30);
            lblHeroBadge.Size = new Size(165, 28);
            lblHeroBadge.TextAlign = ContentAlignment.MiddleCenter;

            // lblHeroTitle
            lblHeroTitle.Text = "Lutong Bahay,\r\nLasang Pinoy";
            lblHeroTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblHeroTitle.ForeColor = Color.FromArgb(30, 30, 30);
            lblHeroTitle.Location = new Point(35, 70);
            lblHeroTitle.Size = new Size(500, 100);

            // lblHeroSubtitle
            lblHeroSubtitle.Text = "Order your favorite Filipino food from trusted restaurants.";
            lblHeroSubtitle.Font = new Font("Segoe UI", 12F);
            lblHeroSubtitle.ForeColor = Color.DimGray;
            lblHeroSubtitle.Location = new Point(40, 185);
            lblHeroSubtitle.AutoSize = true;

            // lblCategoryTitle
            lblCategoryTitle.Text = "Categories";
            lblCategoryTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblCategoryTitle.Location = new Point(35, 360);
            lblCategoryTitle.AutoSize = true;

            // categoryFlow
            categoryFlow.Location = new Point(25, 400);
            categoryFlow.Size = new Size(1090, 65);
            categoryFlow.BackColor = Color.Transparent;
            categoryFlow.WrapContents = false;

            // lblRestaurantTitle
            lblRestaurantTitle.Text = "Pinoy Favorites";
            lblRestaurantTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblRestaurantTitle.Location = new Point(35, 490);
            lblRestaurantTitle.AutoSize = true;

            // lblRestaurantSub
            lblRestaurantSub.Text = "Most loved Filipino restaurants";
            lblRestaurantSub.Font = new Font("Segoe UI", 9F);
            lblRestaurantSub.ForeColor = Color.DimGray;
            lblRestaurantSub.Location = new Point(37, 520);
            lblRestaurantSub.AutoSize = true;

            // restaurantFlow
            restaurantFlow.Location = new Point(25, 550);
            restaurantFlow.Size = new Size(1090, 260);
            restaurantFlow.BackColor = Color.Transparent;
            restaurantFlow.AutoScroll = true;

            // Form3
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1142, 830);
            Controls.Add(restaurantFlow);
            Controls.Add(lblRestaurantSub);
            Controls.Add(lblRestaurantTitle);
            Controls.Add(categoryFlow);
            Controls.Add(lblCategoryTitle);
            Controls.Add(heroPanel);
            Controls.Add(topPanel);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GrabFood Home";
            Load += Form3_Load;

            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            heroPanel.ResumeLayout(false);
            heroPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)heroImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Panel topPanel;
        private Button btnLogout;
        private LinkLabel linkOrders;
        private LinkLabel linkHistory;
        private Label lblLogo;

        private Panel heroPanel;
        private Label lblHeroBadge;
        private Label lblHeroSubtitle;
        private Label lblHeroTitle;
        private PictureBox heroImage;

        private Label lblCategoryTitle;
        private FlowLayoutPanel categoryFlow;

        private Label lblRestaurantTitle;
        private Label lblRestaurantSub;
        private FlowLayoutPanel restaurantFlow;
    }
}