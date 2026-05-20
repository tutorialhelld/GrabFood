namespace GrabFood
{
    partial class jollibeevendor
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private DataGridView dgvProducts;
        private TextBox txtName;
        private TextBox txtPrice;
        private TextBox txtDescription;
        private TextBox txtImagePath;
        private ComboBox cmbCategory;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnRefresh;
        private Button btnBack;
        private Button btnEdit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            dgvProducts = new DataGridView();
            txtName = new TextBox();
            txtPrice = new TextBox();
            txtDescription = new TextBox();
            txtImagePath = new TextBox();
            cmbCategory = new ComboBox();
            btnAdd = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            btnBack = new Button();
            btnEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Green;
            lblTitle.Location = new Point(20, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(400, 40);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "jollibeevendor Product Management";
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.Location = new Point(20, 70);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(760, 250);
            dgvProducts.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(20, 340);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Product Name";
            txtName.Size = new Size(180, 23);
            txtName.TabIndex = 3;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(210, 340);
            txtPrice.Name = "txtPrice";
            txtPrice.PlaceholderText = "Price";
            txtPrice.Size = new Size(120, 23);
            txtPrice.TabIndex = 4;
            txtPrice.KeyPress += txtPrice_KeyPress;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(20, 380);
            txtDescription.Name = "txtDescription";
            txtDescription.PlaceholderText = "Description";
            txtDescription.Size = new Size(310, 23);
            txtDescription.TabIndex = 6;
            // 
            // txtImagePath
            // 
            txtImagePath.Location = new Point(340, 380);
            txtImagePath.Name = "txtImagePath";
            txtImagePath.PlaceholderText = "images\\sample.jpg";
            txtImagePath.Size = new Size(250, 23);
            txtImagePath.TabIndex = 7;
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Location = new Point(340, 340);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(150, 23);
            cmbCategory.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.ForestGreen;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(610, 340);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 30);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add Product";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Firebrick;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(610, 380);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 30);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete Product";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(20, 420);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(100, 30);
            btnRefresh.TabIndex = 10;
            btnRefresh.Text = "Refresh";
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(680, 420);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(100, 30);
            btnBack.TabIndex = 11;
            btnBack.Text = "Log Out";
            btnBack.Click += btnBack_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Orange;
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(548, 420);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(126, 30);
            btnEdit.TabIndex = 0;
            btnEdit.Text = "Edit Product";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // jollibeevendor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 470);
            Controls.Add(btnEdit);
            Controls.Add(lblTitle);
            Controls.Add(dgvProducts);
            Controls.Add(txtName);
            Controls.Add(txtPrice);
            Controls.Add(cmbCategory);
            Controls.Add(txtDescription);
            Controls.Add(txtImagePath);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(btnRefresh);
            Controls.Add(btnBack);
            Name = "jollibeevendor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "jollibeevendor";
            Load += jollibeevendor_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}