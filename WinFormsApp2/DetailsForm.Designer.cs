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
            this.pictureBox = new PictureBox();
            this.lblProductName = new Label();
            this.lblPrice = new Label();
            this.lblCategory = new Label();
            this.lblOwner = new Label();
            this.lblOwnerPhone = new Label();
            this.lblProductAddress = new Label();
            this.lblDescription = new Label();
            this.detailsPanel = new Panel();
            this.btnSave = new Button();
            this.btnShare = new Button();

            // PictureBox for product image
            this.pictureBox.Location = new System.Drawing.Point(20, 20);
            this.pictureBox.Size = new System.Drawing.Size(350, 250);
            this.pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            // Panel for product details
            this.detailsPanel.Location = new System.Drawing.Point(400, 20);
            this.detailsPanel.Size = new System.Drawing.Size(480, 550);
            this.detailsPanel.BackColor = System.Drawing.Color.WhiteSmoke;

            // Label for product name
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI", 18, System.Drawing.FontStyle.Bold);
            this.lblProductName.Location = new System.Drawing.Point(20, 20);
            this.lblProductName.AutoSize = true;

            // Label for price
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 14, System.Drawing.FontStyle.Regular);
            this.lblPrice.Location = new System.Drawing.Point(20, 70);
            this.lblPrice.AutoSize = true;

            // Label for category
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 14, System.Drawing.FontStyle.Regular);
            this.lblCategory.Location = new System.Drawing.Point(20, 120);
            this.lblCategory.AutoSize = true;

            // Label for owner
            this.lblOwner.Font = new System.Drawing.Font("Segoe UI", 14, System.Drawing.FontStyle.Regular);
            this.lblOwner.Location = new System.Drawing.Point(20, 170);
            this.lblOwner.AutoSize = true;

            // Label for owner phone
            this.lblOwnerPhone.Font = new System.Drawing.Font("Segoe UI", 14, System.Drawing.FontStyle.Regular);
            this.lblOwnerPhone.Location = new System.Drawing.Point(20, 220);
            this.lblOwnerPhone.AutoSize = true;

            // Label for product address
            this.lblProductAddress.Font = new System.Drawing.Font("Segoe UI", 14, System.Drawing.FontStyle.Regular);
            this.lblProductAddress.Location = new System.Drawing.Point(20, 270);
            this.lblProductAddress.AutoSize = true;

            // Label for description
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 12, System.Drawing.FontStyle.Regular);
            this.lblDescription.Location = new System.Drawing.Point(20, 320);
            this.lblDescription.Size = new System.Drawing.Size(340, 100);
            this.lblDescription.AutoEllipsis = true;

            // Save Button
            this.btnSave.Text = "Save";
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12, System.Drawing.FontStyle.Bold);
            this.btnSave.BackColor = System.Drawing.Color.LightGreen;
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(20, 430);
            this.btnSave.Size = new System.Drawing.Size(150, 40);
            this.btnSave.FlatStyle = FlatStyle.Flat;

            // Share Button
            this.btnShare.Text = "Share";
            this.btnShare.Font = new System.Drawing.Font("Segoe UI", 12, System.Drawing.FontStyle.Bold);
            this.btnShare.BackColor = System.Drawing.Color.LightBlue;
            this.btnShare.ForeColor = System.Drawing.Color.Black;
            this.btnShare.Location = new System.Drawing.Point(200, 430);
            this.btnShare.Size = new System.Drawing.Size(150, 40);
            this.btnShare.FlatStyle = FlatStyle.Flat;

            // Add components to panel
            this.detailsPanel.Controls.Add(this.lblProductName);
            this.detailsPanel.Controls.Add(this.lblPrice);
            this.detailsPanel.Controls.Add(this.lblCategory);
            this.detailsPanel.Controls.Add(this.lblOwner);
            this.detailsPanel.Controls.Add(this.lblOwnerPhone);
            this.detailsPanel.Controls.Add(this.lblProductAddress);
            this.detailsPanel.Controls.Add(this.lblDescription);
            this.detailsPanel.Controls.Add(this.btnSave);
            this.detailsPanel.Controls.Add(this.btnShare);

            // DetailsForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.detailsPanel);
            this.Text = "Product Details";
            this.Load += new System.EventHandler(this.DetailsForm_Load);
        }

        #endregion
    }
}
