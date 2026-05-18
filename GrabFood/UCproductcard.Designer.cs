namespace GrabFood
{
    partial class UCproductcard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCproductcard));
            cardPanel = new Panel();
            productImage = new PictureBox();
            lblName = new Label();
            lblDescription = new Label();
            lblPrice = new Label();
            btnAddBasket = new Button();
            cardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productImage).BeginInit();
            SuspendLayout();
            // 
            // cardPanel
            // 
            cardPanel.BackColor = Color.White;
            cardPanel.Controls.Add(productImage);
            cardPanel.Controls.Add(lblName);
            cardPanel.Controls.Add(lblDescription);
            cardPanel.Controls.Add(lblPrice);
            cardPanel.Controls.Add(btnAddBasket);
            cardPanel.Location = new Point(8, 8);
            cardPanel.Name = "cardPanel";
            cardPanel.Size = new Size(270, 102);
            cardPanel.TabIndex = 0;
            // 
            // productImage
            // 
            productImage.ErrorImage = (Image)resources.GetObject("productImage.ErrorImage");
            productImage.Image = (Image)resources.GetObject("productImage.Image");
            productImage.Location = new Point(10, 10);
            productImage.Name = "productImage";
            productImage.Size = new Size(90, 80);
            productImage.SizeMode = PictureBoxSizeMode.Zoom;
            productImage.TabIndex = 1;
            productImage.TabStop = false;
            // 
            // lblName
            // 
            lblName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblName.ForeColor = Color.FromArgb(20, 30, 50);
            lblName.Location = new Point(110, 12);
            lblName.Name = "lblName";
            lblName.Size = new Size(95, 35);
            lblName.TabIndex = 2;
            lblName.Text = "6-pc Chickenjoy\r\nBucket";
            // 
            // lblDescription
            // 
            lblDescription.Font = new Font("Segoe UI", 7F);
            lblDescription.ForeColor = Color.DimGray;
            lblDescription.Location = new Point(110, 48);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(145, 28);
            lblDescription.TabIndex = 3;
            lblDescription.Text = "The world-famous crispy, juicy fried chicken.";
            // 
            // lblPrice
            // 
            lblPrice.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblPrice.ForeColor = Color.Green;
            lblPrice.Location = new Point(210, 12);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(55, 20);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "₱649.00";
            // 
            // btnAddBasket
            // 
            btnAddBasket.BackColor = Color.FromArgb(0, 150, 70);
            btnAddBasket.FlatAppearance.BorderSize = 0;
            btnAddBasket.FlatStyle = FlatStyle.Flat;
            btnAddBasket.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            btnAddBasket.ForeColor = Color.White;
            btnAddBasket.Location = new Point(110, 78);
            btnAddBasket.Name = "btnAddBasket";
            btnAddBasket.Size = new Size(105, 22);
            btnAddBasket.TabIndex = 5;
            btnAddBasket.Text = "Add to Basket";
            btnAddBasket.UseVisualStyleBackColor = false;
            // 
            // UCproductcard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(cardPanel);
            Name = "UCproductcard";
            Size = new Size(286, 118);
            Load += UCproductcard_Load;
            cardPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)productImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel cardPanel;
        private System.Windows.Forms.PictureBox productImage;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnAddBasket;
    }
}
