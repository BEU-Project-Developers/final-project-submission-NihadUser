namespace WinFormsApp2
{
    partial class DetailsForm
    {
        private System.ComponentModel.IContainer components = null;

        // Declare components
        private PictureBox pictureBox;
        private Label lblProductName;
        private Label lblPrice;
        private Label lblCategory;
        private Label lblOwner;
        private Label lblOwnerPhone;
        private Label lblProductAddress;
        private Label lblDescription;
        private Panel detailsPanel;
        private Button btnSave;
        private Button btnShare;

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
            pictureBox = new PictureBox();
            lblProductName = new Label();
            lblPrice = new Label();
            lblCategory = new Label();
            lblOwner = new Label();
            lblOwnerPhone = new Label();
            lblProductAddress = new Label();
            lblDescription = new Label();
            detailsPanel = new Panel();
            btnSave = new Button();
            btnShare = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            detailsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(20, 25);
            pictureBox.Margin = new Padding(3, 4, 3, 4);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(350, 312);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblProductName.Location = new Point(20, 25);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(0, 41);
            lblProductName.TabIndex = 0;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 10F);
            lblPrice.Location = new Point(20, 88);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(0, 23);
            lblPrice.TabIndex = 1;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 10F);
            lblCategory.Location = new Point(20, 150);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(0, 23);
            lblCategory.TabIndex = 2;
            // 
            // lblOwner
            // 
            lblOwner.AutoSize = true;
            lblOwner.Font = new Font("Segoe UI", 10F);
            lblOwner.Location = new Point(20, 212);
            lblOwner.Name = "lblOwner";
            lblOwner.Size = new Size(0, 23);
            lblOwner.TabIndex = 3;
            // 
            // lblOwnerPhone
            // 
            lblOwnerPhone.AutoSize = true;
            lblOwnerPhone.Font = new Font("Segoe UI", 10F);
            lblOwnerPhone.Location = new Point(20, 275);
            lblOwnerPhone.Name = "lblOwnerPhone";
            lblOwnerPhone.Size = new Size(0, 23);
            lblOwnerPhone.TabIndex = 4;
            // 
            // lblProductAddress
            // 
            lblProductAddress.AutoSize = true;
            lblProductAddress.Font = new Font("Segoe UI", 10F);
            lblProductAddress.Location = new Point(20, 338);
            lblProductAddress.Name = "lblProductAddress";
            lblProductAddress.Size = new Size(0, 23);
            lblProductAddress.TabIndex = 5;
            // 
            // lblDescription
            // 
            lblDescription.AutoEllipsis = true;
            lblDescription.Font = new Font("Segoe UI", 8F);
            lblDescription.Location = new Point(20, 400);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(340, 125);
            lblDescription.TabIndex = 6;
            // 
            // detailsPanel
            // 
            detailsPanel.BackColor = Color.WhiteSmoke;
            detailsPanel.Controls.Add(lblProductName);
            detailsPanel.Controls.Add(lblPrice);
            detailsPanel.Controls.Add(lblCategory);
            detailsPanel.Controls.Add(lblOwner);
            detailsPanel.Controls.Add(lblOwnerPhone);
            detailsPanel.Controls.Add(lblProductAddress);
            detailsPanel.Controls.Add(lblDescription);
            detailsPanel.Controls.Add(btnSave);
            detailsPanel.Controls.Add(btnShare);
            detailsPanel.Location = new Point(400, 25);
            detailsPanel.Margin = new Padding(3, 4, 3, 4);
            detailsPanel.Name = "detailsPanel";
            detailsPanel.Size = new Size(480, 688);
            detailsPanel.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.LightGreen;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSave.ForeColor = Color.Black;
            btnSave.Location = new Point(20, 538);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 50);
            btnSave.TabIndex = 7;
            btnSave.Text = "Basket";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnShare
            // 
            btnShare.BackColor = Color.LightBlue;
            btnShare.FlatStyle = FlatStyle.Flat;
            btnShare.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnShare.ForeColor = Color.Black;
            btnShare.Location = new Point(200, 538);
            btnShare.Margin = new Padding(3, 4, 3, 4);
            btnShare.Name = "btnShare";
            btnShare.Size = new Size(150, 50);
            btnShare.TabIndex = 8;
            btnShare.Text = "Share";
            btnShare.UseVisualStyleBackColor = false;
            // 
            // DetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 625);
            Controls.Add(pictureBox);
            Controls.Add(detailsPanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DetailsForm";
            Text = "Product Details";
            Load += DetailsForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            detailsPanel.ResumeLayout(false);
            detailsPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
    }
}
