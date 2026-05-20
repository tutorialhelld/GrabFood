namespace GrabFood
{
    partial class jollibee
    {
        private System.ComponentModel.IContainer components = null;

        private Panel topPanel;
        private Label lblTitle;
        private Button btnCart;
        private Button btnBack;

        private TabControl tabControl1;
        private TabPage tabFaves;
        private TabPage tabChicken;
        private TabPage tabDesserts;

        private FlowLayoutPanel flowFaves;
        private FlowLayoutPanel flowChicken;
        private FlowLayoutPanel flowDesserts;
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
            topPanel = new Panel();
            lblTitle = new Label();
            btnCart = new Button();
            btnBack = new Button();

            tabControl1 = new TabControl();
            tabFaves = new TabPage();
            tabChicken = new TabPage();
            tabDesserts = new TabPage();

            flowFaves = new FlowLayoutPanel();
            flowChicken = new FlowLayoutPanel();
            flowDesserts = new FlowLayoutPanel();

            topPanel.SuspendLayout();
            tabControl1.SuspendLayout();
            tabFaves.SuspendLayout();
            tabChicken.SuspendLayout();
            tabDesserts.SuspendLayout();
            SuspendLayout();

            // topPanel
            topPanel.BackColor = Color.White;
            topPanel.BorderStyle = BorderStyle.FixedSingle;
            topPanel.Controls.Add(lblTitle);
            topPanel.Controls.Add(btnCart);
            topPanel.Dock = DockStyle.Top;
            topPanel.Height = 60;

            // lblTitle
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Green;
            lblTitle.Location = new Point(15, 10);
            lblTitle.Text = "GrabFood";

            // btnCart
            btnCart.BackColor = Color.ForestGreen;
            btnCart.ForeColor = Color.White;
            btnCart.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCart.Location = new Point(835, 12);
            btnCart.Size = new Size(120, 35);
            btnCart.Text = "View Cart";
            btnCart.UseVisualStyleBackColor = false;
            btnCart.Click += btnCart_Click;

            // btnBack
            btnBack.BackColor = Color.Gray;
            btnBack.ForeColor = Color.White;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBack.Location = new Point(700, 12);
            btnBack.Size = new Size(120, 35);
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;

            topPanel.Controls.Add(btnBack);

            // tabControl1
            tabControl1.Controls.Add(tabFaves);
            tabControl1.Controls.Add(tabChicken);
            tabControl1.Controls.Add(tabDesserts);
            tabControl1.Location = new Point(12, 75);
            tabControl1.Size = new Size(950, 580);

            // tabFaves
            tabFaves.Text = "Jollibee Bundles";
            tabFaves.BackColor = Color.White;
            tabFaves.Controls.Add(flowFaves);

            // tabChicken
            tabChicken.Text = "Chicken Joy";
            tabChicken.BackColor = Color.White;
            tabChicken.Controls.Add(flowChicken);

            // tabDesserts
            tabDesserts.Text = "Jolli Desserts";
            tabDesserts.BackColor = Color.White;
            tabDesserts.Controls.Add(flowDesserts);

            // flowFaves
            flowFaves.Dock = DockStyle.Fill;
            flowFaves.AutoScroll = true;
            flowFaves.Padding = new Padding(20);
            flowFaves.FlowDirection = FlowDirection.TopDown;
            flowFaves.WrapContents = false;

            // flowChicken
            flowChicken.Dock = DockStyle.Fill;
            flowChicken.AutoScroll = true;
            flowChicken.Padding = new Padding(20);
            flowChicken.FlowDirection = FlowDirection.TopDown;
            flowChicken.WrapContents = false;

            // flowDesserts
            flowDesserts.Dock = DockStyle.Fill;
            flowDesserts.AutoScroll = true;
            flowDesserts.Padding = new Padding(20);
            flowDesserts.FlowDirection = FlowDirection.TopDown;
            flowDesserts.WrapContents = false;

            // jollibee
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(977, 670);
            Controls.Add(tabControl1);
            Controls.Add(topPanel);
            Name = "jollibee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "jollibee";
            Load += jollibee_Load;

            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabFaves.ResumeLayout(false);
            tabChicken.ResumeLayout(false);
            tabDesserts.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
    }
}