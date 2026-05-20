namespace GrabFood
{
    partial class MAXS
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

        private void InitializeComponent()
        {
            topPanel = new Panel();
            lblTitle = new Label();
            btnCart = new Button();
            btnBack = new Button();
            tabControl1 = new TabControl();
            tabFaves = new TabPage();
            flowFaves = new FlowLayoutPanel();
            tabChicken = new TabPage();
            flowChicken = new FlowLayoutPanel();
            tabDesserts = new TabPage();
            flowDesserts = new FlowLayoutPanel();
            topPanel.SuspendLayout();
            tabControl1.SuspendLayout();
            tabFaves.SuspendLayout();
            tabChicken.SuspendLayout();
            tabDesserts.SuspendLayout();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.White;
            topPanel.BorderStyle = BorderStyle.FixedSingle;
            topPanel.Controls.Add(lblTitle);
            topPanel.Controls.Add(btnCart);
            topPanel.Controls.Add(btnBack);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(977, 60);
            topPanel.TabIndex = 1;
            topPanel.Paint += topPanel_Paint;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Green;
            lblTitle.Location = new Point(15, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(157, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "GrabFood";
            // 
            // btnCart
            // 
            btnCart.BackColor = Color.ForestGreen;
            btnCart.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCart.ForeColor = Color.White;
            btnCart.Location = new Point(835, 12);
            btnCart.Name = "btnCart";
            btnCart.Size = new Size(120, 35);
            btnCart.TabIndex = 1;
            btnCart.Text = "View Cart";
            btnCart.UseVisualStyleBackColor = false;
            btnCart.Click += btnCart_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Gray;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(700, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(120, 35);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabFaves);
            tabControl1.Controls.Add(tabChicken);
            tabControl1.Controls.Add(tabDesserts);
            tabControl1.Location = new Point(12, 75);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(950, 580);
            tabControl1.TabIndex = 0;
            // 
            // tabFaves
            // 
            tabFaves.BackColor = Color.White;
            tabFaves.Controls.Add(flowFaves);
            tabFaves.Location = new Point(4, 24);
            tabFaves.Name = "tabFaves";
            tabFaves.Size = new Size(942, 552);
            tabFaves.TabIndex = 0;
            tabFaves.Text = "Max Faves";
            // 
            // flowFaves
            // 
            flowFaves.AutoScroll = true;
            flowFaves.Dock = DockStyle.Fill;
            flowFaves.FlowDirection = FlowDirection.TopDown;
            flowFaves.Location = new Point(0, 0);
            flowFaves.Name = "flowFaves";
            flowFaves.Padding = new Padding(20);
            flowFaves.Size = new Size(942, 552);
            flowFaves.TabIndex = 0;
            flowFaves.WrapContents = false;
            // 
            // tabChicken
            // 
            tabChicken.BackColor = Color.White;
            tabChicken.Controls.Add(flowChicken);
            tabChicken.Location = new Point(4, 24);
            tabChicken.Name = "tabChicken";
            tabChicken.Size = new Size(942, 552);
            tabChicken.TabIndex = 1;
            tabChicken.Text = "Max Chicken";
            // 
            // flowChicken
            // 
            flowChicken.AutoScroll = true;
            flowChicken.Dock = DockStyle.Fill;
            flowChicken.FlowDirection = FlowDirection.TopDown;
            flowChicken.Location = new Point(0, 0);
            flowChicken.Name = "flowChicken";
            flowChicken.Padding = new Padding(20);
            flowChicken.Size = new Size(942, 552);
            flowChicken.TabIndex = 0;
            flowChicken.WrapContents = false;
            // 
            // tabDesserts
            // 
            tabDesserts.BackColor = Color.White;
            tabDesserts.Controls.Add(flowDesserts);
            tabDesserts.Location = new Point(4, 24);
            tabDesserts.Name = "tabDesserts";
            tabDesserts.Size = new Size(942, 552);
            tabDesserts.TabIndex = 2;
            tabDesserts.Text = "Desserts";
            // 
            // flowDesserts
            // 
            flowDesserts.AutoScroll = true;
            flowDesserts.Dock = DockStyle.Fill;
            flowDesserts.FlowDirection = FlowDirection.TopDown;
            flowDesserts.Location = new Point(0, 0);
            flowDesserts.Name = "flowDesserts";
            flowDesserts.Padding = new Padding(20);
            flowDesserts.Size = new Size(942, 552);
            flowDesserts.TabIndex = 0;
            flowDesserts.WrapContents = false;
            // 
            // MAXS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(977, 670);
            Controls.Add(tabControl1);
            Controls.Add(topPanel);
            Name = "MAXS";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MAXS";
            Load += MAXS_Load;
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabFaves.ResumeLayout(false);
            tabChicken.ResumeLayout(false);
            tabDesserts.ResumeLayout(false);
            ResumeLayout(false);


        }
    }
}