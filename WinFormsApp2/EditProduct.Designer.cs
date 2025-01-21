namespace WinFormsApp2
{
    partial class EditProduct
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        // Update the InitializeComponent method to fix the layout
        private void InitializeComponent()
        {
            lblProductName = new Label();
            txtProductName = new TextBox();
            lblProductPrice = new Label();
            txtProductPrice = new TextBox();
            lblProductDescription = new Label();
            txtProductDescription = new TextBox();
            lblImageUrl = new Label();
            txtImageUrl = new TextBox();
            lblCategory = new Label();
            cmbCategory = new ComboBox();
            btnSave = new Button();
            btnCancel = new Button();
            picProductImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picProductImage).BeginInit();
            SuspendLayout();
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblProductName.Location = new Point(50, 50);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(127, 19);
            lblProductName.TabIndex = 0;
            lblProductName.Text = "Product Name:";
            // 
            // txtProductName
            // 
            txtProductName.Font = new Font("Arial", 10F);
            txtProductName.Location = new Point(200, 50);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(400, 27);
            txtProductName.TabIndex = 1;
            // 
            // lblProductPrice
            // 
            lblProductPrice.AutoSize = true;
            lblProductPrice.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblProductPrice.Location = new Point(50, 100);
            lblProductPrice.Name = "lblProductPrice";
            lblProductPrice.Size = new Size(123, 19);
            lblProductPrice.TabIndex = 2;
            lblProductPrice.Text = "Product Price:";
            // 
            // txtProductPrice
            // 
            txtProductPrice.Font = new Font("Arial", 10F);
            txtProductPrice.Location = new Point(200, 100);
            txtProductPrice.Name = "txtProductPrice";
            txtProductPrice.Size = new Size(400, 27);
            txtProductPrice.TabIndex = 3;
            // 
            // lblProductDescription
            // 
            lblProductDescription.AutoSize = true;
            lblProductDescription.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblProductDescription.Location = new Point(21, 150);
            lblProductDescription.Name = "lblProductDescription";
            lblProductDescription.Size = new Size(173, 19);
            lblProductDescription.TabIndex = 4;
            lblProductDescription.Text = "Product Description:";
            // 
            // txtProductDescription
            // 
            txtProductDescription.Font = new Font("Arial", 10F);
            txtProductDescription.Location = new Point(200, 150);
            txtProductDescription.Multiline = true;
            txtProductDescription.Name = "txtProductDescription";
            txtProductDescription.Size = new Size(400, 100);
            txtProductDescription.TabIndex = 5;
            // 
            // lblImageUrl
            // 
            lblImageUrl.AutoSize = true;
            lblImageUrl.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblImageUrl.Location = new Point(50, 320);
            lblImageUrl.Name = "lblImageUrl";
            lblImageUrl.Size = new Size(100, 19);
            lblImageUrl.TabIndex = 8;
            lblImageUrl.Text = "Image URL:";
            // 
            // txtImageUrl
            // 
            txtImageUrl.Font = new Font("Arial", 10F);
            txtImageUrl.Location = new Point(200, 320);
            txtImageUrl.Name = "txtImageUrl";
            txtImageUrl.Size = new Size(400, 27);
            txtImageUrl.TabIndex = 9;
            txtImageUrl.TextChanged += txtImageUrl_TextChanged;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblCategory.Location = new Point(50, 270);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(87, 19);
            lblCategory.TabIndex = 6;
            lblCategory.Text = "Category:";
            // 
            // cmbCategory
            // 
            cmbCategory.Font = new Font("Arial", 10F);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(200, 270);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(400, 27);
            cmbCategory.TabIndex = 7;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.LimeGreen;
            btnSave.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(200, 530);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 40);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click_1;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Crimson;
            btnCancel.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(340, 530);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 40);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click_1;
            // 
            // picProductImage
            // 
            picProductImage.Location = new Point(200, 360);
            picProductImage.Name = "picProductImage";
            picProductImage.Size = new Size(400, 150);
            picProductImage.SizeMode = PictureBoxSizeMode.StretchImage;
            picProductImage.TabIndex = 10;
            picProductImage.TabStop = false;
            // 
            // EditProduct
            // 
            ClientSize = new Size(700, 600);
            Controls.Add(lblProductName);
            Controls.Add(txtProductName);
            Controls.Add(lblProductPrice);
            Controls.Add(txtProductPrice);
            Controls.Add(lblProductDescription);
            Controls.Add(txtProductDescription);
            Controls.Add(lblCategory);
            Controls.Add(cmbCategory);
            Controls.Add(lblImageUrl);
            Controls.Add(txtImageUrl);
            Controls.Add(picProductImage);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Name = "EditProduct";
            Text = "Edit Product";
            ((System.ComponentModel.ISupportInitialize)picProductImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.Label lblProductDescription;
        private System.Windows.Forms.TextBox txtProductDescription;
        private System.Windows.Forms.Label lblImageUrl;
        private System.Windows.Forms.TextBox txtImageUrl;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox picProductImage; // PictureBox for product image preview

        // Event handler to load the image from the URL when the user enters a new URL
        private void txtImageUrl_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string imageUrl = txtImageUrl.Text;
                if (!string.IsNullOrEmpty(imageUrl) && Uri.IsWellFormedUriString(imageUrl, UriKind.Absolute))
                {
                    picProductImage.Load(imageUrl); // Load image from URL into PictureBox
                }
                else
                {
                    picProductImage.Image = null; // Clear image if the URL is not valid
                }
            }
            catch
            {
                picProductImage.Image = null; // Handle error and clear image if any issue occurs
            }
        }
    }
}
