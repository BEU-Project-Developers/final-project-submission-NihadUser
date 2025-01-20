namespace WinFormsApp2
{
    partial class CreateProduct
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblProductName;
        private Label lblProductPrice;
        private Label lblProductDescription;
        private Label lblProductImageUrl;
        private Label lblCategory;

        private TextBox txtProductName;
        private TextBox txtProductPrice;
        private TextBox txtProductDescription;
        private TextBox txtProductImageUrl;

        private ComboBox cmbCategory;

        private Button btnSave;
        private Button btnCancel;

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
            lblProductName = new Label();
            lblProductPrice = new Label();
            lblProductDescription = new Label();
            lblProductImageUrl = new Label();
            lblCategory = new Label();
            txtProductName = new TextBox();
            txtProductPrice = new TextBox();
            txtProductDescription = new TextBox();
            txtProductImageUrl = new TextBox();
            cmbCategory = new ComboBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblProductName
            // 
            lblProductName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblProductName.ForeColor = Color.Black;
            lblProductName.Location = new Point(85, 50);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(215, 30);
            lblProductName.TabIndex = 0;
            lblProductName.Text = "Product Name:";
            // 
            // lblProductPrice
            // 
            lblProductPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblProductPrice.ForeColor = Color.Black;
            lblProductPrice.Location = new Point(150, 100);
            lblProductPrice.Name = "lblProductPrice";
            lblProductPrice.Size = new Size(150, 30);
            lblProductPrice.TabIndex = 2;
            lblProductPrice.Text = "Product Price:";
            // 
            // lblProductDescription
            // 
            lblProductDescription.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblProductDescription.ForeColor = Color.Black;
            lblProductDescription.Location = new Point(55, 150);
            lblProductDescription.Name = "lblProductDescription";
            lblProductDescription.Size = new Size(259, 30);
            lblProductDescription.TabIndex = 4;
            lblProductDescription.Text = "Product Description:";
            // 
            // lblProductImageUrl
            // 
            lblProductImageUrl.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblProductImageUrl.ForeColor = Color.Black;
            lblProductImageUrl.Location = new Point(150, 200);
            lblProductImageUrl.Name = "lblProductImageUrl";
            lblProductImageUrl.Size = new Size(150, 30);
            lblProductImageUrl.TabIndex = 6;
            lblProductImageUrl.Text = "Image URL:";
            // 
            // lblCategory
            // 
            lblCategory.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCategory.ForeColor = Color.Black;
            lblCategory.Location = new Point(150, 250);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(150, 30);
            lblCategory.TabIndex = 8;
            lblCategory.Text = "Category:";
            // 
            // txtProductName
            // 
            txtProductName.Font = new Font("Segoe UI", 10F);
            txtProductName.Location = new Point(320, 50);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(300, 30);
            txtProductName.TabIndex = 1;
            // 
            // txtProductPrice
            // 
            txtProductPrice.Font = new Font("Segoe UI", 10F);
            txtProductPrice.Location = new Point(320, 100);
            txtProductPrice.Name = "txtProductPrice";
            txtProductPrice.Size = new Size(300, 30);
            txtProductPrice.TabIndex = 3;
            // 
            // txtProductDescription
            // 
            txtProductDescription.Font = new Font("Segoe UI", 10F);
            txtProductDescription.Location = new Point(320, 150);
            txtProductDescription.Name = "txtProductDescription";
            txtProductDescription.Size = new Size(300, 30);
            txtProductDescription.TabIndex = 5;
            // 
            // txtProductImageUrl
            // 
            txtProductImageUrl.Font = new Font("Segoe UI", 10F);
            txtProductImageUrl.Location = new Point(320, 200);
            txtProductImageUrl.Name = "txtProductImageUrl";
            txtProductImageUrl.Size = new Size(300, 30);
            txtProductImageUrl.TabIndex = 7;
            // 
            // cmbCategory
            // 
            cmbCategory.Font = new Font("Segoe UI", 10F);
            cmbCategory.Location = new Point(320, 250);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(300, 31);
            cmbCategory.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Green;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(320, 325);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 40);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click_1;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(450, 325);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 40);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click_1;
            // 
            // CreateProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 500);
            Controls.Add(lblProductName);
            Controls.Add(txtProductName);
            Controls.Add(lblProductPrice);
            Controls.Add(txtProductPrice);
            Controls.Add(lblProductDescription);
            Controls.Add(txtProductDescription);
            Controls.Add(lblProductImageUrl);
            Controls.Add(txtProductImageUrl);
            Controls.Add(lblCategory);
            Controls.Add(cmbCategory);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Name = "CreateProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Product";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
