namespace GrabFood
{
    partial class ActiveDelivery
    {
        private System.ComponentModel.IContainer components = null;

        private Label label2;
        private DataGridView dgvDeliveries;
        private ComboBox comboStatus;
        private Button button1;
        private Button button2;
        private Label label1;

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
            label2 = new Label();
            dgvDeliveries = new DataGridView();
            comboStatus = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDeliveries).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(125, 30);
            label2.TabIndex = 2;
            label2.Text = "Grab Rider";
            // 
            // dgvDeliveries
            // 
            dgvDeliveries.AllowUserToAddRows = false;
            dgvDeliveries.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDeliveries.Location = new Point(12, 65);
            dgvDeliveries.MultiSelect = false;
            dgvDeliveries.Name = "dgvDeliveries";
            dgvDeliveries.ReadOnly = true;
            dgvDeliveries.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDeliveries.Size = new Size(760, 280);
            dgvDeliveries.TabIndex = 3;
            // 
            // comboStatus
            // 
            comboStatus.Location = new Point(12, 385);
            comboStatus.Name = "comboStatus";
            comboStatus.Size = new Size(180, 23);
            comboStatus.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(210, 384);
            button1.Name = "button1";
            button1.Size = new Size(130, 25);
            button1.TabIndex = 6;
            button1.Text = "Update Delivery";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(360, 384);
            button2.Name = "button2";
            button2.Size = new Size(100, 25);
            button2.TabIndex = 7;
            button2.Text = "Refresh";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 365);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 4;
            label1.Text = "Status";
            // 
            // button3
            // 
            button3.Location = new Point(669, 385);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 8;
            button3.Text = "Log Out";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // ActiveDelivery
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(793, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboStatus);
            Controls.Add(label1);
            Controls.Add(dgvDeliveries);
            Controls.Add(label2);
            Name = "ActiveDelivery";
            Text = "ActiveDelivery";
            Load += ActiveDelivery_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDeliveries).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private Button button3;
    }
}