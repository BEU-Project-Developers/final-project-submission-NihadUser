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
        private Label lblDescription;

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
            this.lblDescription = new Label();
            this.SuspendLayout();

            // PictureBox for product image
            this.pictureBox.Location = new System.Drawing.Point(20, 20);
            this.pictureBox.Size = new System.Drawing.Size(300, 200);
            this.pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            // Label for product name
            this.lblProductName.Font = new System.Drawing.Font("Arial", 18, System.Drawing.FontStyle.Bold);
            this.lblProductName.Location = new System.Drawing.Point(20, 240);
            this.lblProductName.AutoSize = true;

            // Label for price
            this.lblPrice.Font = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Regular);
            this.lblPrice.Location = new System.Drawing.Point(20, 280);
            this.lblPrice.AutoSize = true;

            // Label for category
            this.lblCategory.Font = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Regular);
            this.lblCategory.Location = new System.Drawing.Point(20, 320);
            this.lblCategory.AutoSize = true;

            // Label for owner
            this.lblOwner.Font = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Regular);
            this.lblOwner.Location = new System.Drawing.Point(20, 360);
            this.lblOwner.AutoSize = true;

            // Label for description
            this.lblDescription.Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Regular);
            this.lblDescription.Location = new System.Drawing.Point(20, 400);
            this.lblDescription.Size = new System.Drawing.Size(750, 100);
            this.lblDescription.AutoEllipsis = true;

            // DetailsForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblOwner);
            this.Controls.Add(this.lblDescription);
            this.Text = "Product Details";
            this.Load += new System.EventHandler(this.DetailsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
