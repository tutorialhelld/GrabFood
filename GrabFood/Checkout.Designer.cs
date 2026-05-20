namespace GrabFood
{
    partial class Checkout
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
            headerPanel = new Panel();
            lblLogo = new Label();
            lblTitle = new Label();
            cartGrid = new DataGridView();
            summaryPanel = new Panel();
            lblSummary = new Label();
            lblSubtotalText = new Label();
            lblSubtotal = new Label();
            lblDeliveryText = new Label();
            lblDeliveryFee = new Label();
            lblTotalText = new Label();
            lblTotal = new Label();
            btnPlaceOrder = new Button();
            btnClearCart = new Button();
            button8 = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            textBox1 = new TextBox();
            label1 = new Label();
            headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cartGrid).BeginInit();
            summaryPanel.SuspendLayout();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.White;
            headerPanel.Controls.Add(radioButton2);
            headerPanel.Controls.Add(radioButton1);
            headerPanel.Controls.Add(lblLogo);
            headerPanel.Controls.Add(lblTitle);
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1056, 75);
            headerPanel.TabIndex = 0;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblLogo.ForeColor = Color.FromArgb(0, 170, 80);
            lblLogo.Location = new Point(25, 15);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(170, 45);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "GrabFood";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(800, 22);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(110, 30);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Checkout";
            // 
            // cartGrid
            // 
            cartGrid.AllowUserToAddRows = false;
            cartGrid.AllowUserToDeleteRows = false;
            cartGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cartGrid.BackgroundColor = Color.White;
            cartGrid.BorderStyle = BorderStyle.None;
            cartGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cartGrid.Location = new Point(35, 110);
            cartGrid.Name = "cartGrid";
            cartGrid.ReadOnly = true;
            cartGrid.RowTemplate.Height = 35;
            cartGrid.Size = new Size(640, 370);
            cartGrid.TabIndex = 1;
            cartGrid.CellContentClick += cartGrid_CellContentClick;
            // 
            // summaryPanel
            // 
            summaryPanel.BackColor = Color.White;
            summaryPanel.Controls.Add(lblSummary);
            summaryPanel.Controls.Add(lblSubtotalText);
            summaryPanel.Controls.Add(lblSubtotal);
            summaryPanel.Controls.Add(lblDeliveryText);
            summaryPanel.Controls.Add(lblDeliveryFee);
            summaryPanel.Controls.Add(lblTotalText);
            summaryPanel.Controls.Add(lblTotal);
            summaryPanel.Controls.Add(btnPlaceOrder);
            summaryPanel.Controls.Add(btnClearCart);
            summaryPanel.Location = new Point(715, 110);
            summaryPanel.Name = "summaryPanel";
            summaryPanel.Size = new Size(300, 370);
            summaryPanel.TabIndex = 2;
            // 
            // lblSummary
            // 
            lblSummary.AutoSize = true;
            lblSummary.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblSummary.Location = new Point(25, 25);
            lblSummary.Name = "lblSummary";
            lblSummary.Size = new Size(179, 30);
            lblSummary.TabIndex = 0;
            lblSummary.Text = "Order Summary";
            // 
            // lblSubtotalText
            // 
            lblSubtotalText.AutoSize = true;
            lblSubtotalText.Font = new Font("Segoe UI", 11F);
            lblSubtotalText.Location = new Point(25, 90);
            lblSubtotalText.Name = "lblSubtotalText";
            lblSubtotalText.Size = new Size(65, 20);
            lblSubtotalText.TabIndex = 1;
            lblSubtotalText.Text = "Subtotal";
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblSubtotal.Location = new Point(190, 90);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(50, 20);
            lblSubtotal.TabIndex = 2;
            lblSubtotal.Text = "₱0.00";
            // 
            // lblDeliveryText
            // 
            lblDeliveryText.AutoSize = true;
            lblDeliveryText.Font = new Font("Segoe UI", 11F);
            lblDeliveryText.Location = new Point(25, 130);
            lblDeliveryText.Name = "lblDeliveryText";
            lblDeliveryText.Size = new Size(90, 20);
            lblDeliveryText.TabIndex = 3;
            lblDeliveryText.Text = "Delivery Fee";
            // 
            // lblDeliveryFee
            // 
            lblDeliveryFee.AutoSize = true;
            lblDeliveryFee.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblDeliveryFee.Location = new Point(190, 130);
            lblDeliveryFee.Name = "lblDeliveryFee";
            lblDeliveryFee.Size = new Size(59, 20);
            lblDeliveryFee.TabIndex = 4;
            lblDeliveryFee.Text = "₱49.00";
            // 
            // lblTotalText
            // 
            lblTotalText.AutoSize = true;
            lblTotalText.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTotalText.Location = new Point(25, 190);
            lblTotalText.Name = "lblTotalText";
            lblTotalText.Size = new Size(55, 25);
            lblTotalText.TabIndex = 5;
            lblTotalText.Text = "Total";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTotal.ForeColor = Color.FromArgb(0, 150, 70);
            lblTotal.Location = new Point(180, 190);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(62, 25);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "₱0.00";
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.BackColor = Color.FromArgb(0, 150, 70);
            btnPlaceOrder.FlatAppearance.BorderSize = 0;
            btnPlaceOrder.FlatStyle = FlatStyle.Flat;
            btnPlaceOrder.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnPlaceOrder.ForeColor = Color.White;
            btnPlaceOrder.Location = new Point(25, 260);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new Size(250, 45);
            btnPlaceOrder.TabIndex = 7;
            btnPlaceOrder.Text = "Place Order";
            btnPlaceOrder.UseVisualStyleBackColor = false;
            btnPlaceOrder.Click += btnPlaceOrder_Click;
            // 
            // btnClearCart
            // 
            btnClearCart.BackColor = Color.White;
            btnClearCart.FlatStyle = FlatStyle.Flat;
            btnClearCart.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClearCart.ForeColor = Color.Firebrick;
            btnClearCart.Location = new Point(25, 315);
            btnClearCart.Name = "btnClearCart";
            btnClearCart.Size = new Size(250, 35);
            btnClearCart.TabIndex = 8;
            btnClearCart.Text = "Clear Cart";
            btnClearCart.UseVisualStyleBackColor = false;
            btnClearCart.Click += btnClearCart_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.ForestGreen;
            button8.ForeColor = Color.White;
            button8.Location = new Point(782, 491);
            button8.Margin = new Padding(4, 3, 4, 3);
            button8.Name = "button8";
            button8.Size = new Size(146, 46);
            button8.TabIndex = 16;
            button8.Text = "Back";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(931, 12);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(113, 19);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "Cash on Delivery";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(931, 41);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(57, 19);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "Gcash";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(532, 504);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(410, 512);
            label1.Name = "label1";
            label1.Size = new Size(116, 15);
            label1.TabIndex = 18;
            label1.Text = "Enter Gcash Number";
            // 
            // Checkout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 245);
            ClientSize = new Size(1056, 549);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button8);
            Controls.Add(headerPanel);
            Controls.Add(cartGrid);
            Controls.Add(summaryPanel);
            Name = "Checkout";
            Text = "Checkout";
            Load += Checkout_Load;
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cartGrid).EndInit();
            summaryPanel.ResumeLayout(false);
            summaryPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView cartGrid;
        private System.Windows.Forms.Panel summaryPanel;
        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.Label lblSubtotalText;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblDeliveryText;
        private System.Windows.Forms.Label lblDeliveryFee;
        private System.Windows.Forms.Label lblTotalText;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnClearCart;
        private Button button8;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TextBox textBox1;
        private Label label1;
    }
}