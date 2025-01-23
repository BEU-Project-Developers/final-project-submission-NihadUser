namespace WinFormsApp2
{
    partial class OrderForm
    {
        private System.ComponentModel.IContainer components = null;

        private GroupBox paymentGroupBox;
        private GroupBox billingGroupBox;
        private Button btnConfirm;

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
            paymentGroupBox = new GroupBox();
            billingGroupBox = new GroupBox();
            btnConfirm = new Button();
            SuspendLayout();
            // 
            // paymentGroupBox
            // 
            paymentGroupBox.Location = new Point(50, 50); // Adjusted location
            paymentGroupBox.Name = "paymentGroupBox";
            paymentGroupBox.Size = new Size(400, 200); // Adjusted size
            paymentGroupBox.TabIndex = 0;
            paymentGroupBox.TabStop = false;
            paymentGroupBox.Text = "Payment Details"; // Added title for clarity
            // 
            // billingGroupBox
            // 
            billingGroupBox.Location = new Point(500, 50); // Adjusted location
            billingGroupBox.Name = "billingGroupBox";
            billingGroupBox.Size = new Size(400, 250); // Adjusted size
            billingGroupBox.TabIndex = 1;
            billingGroupBox.TabStop = false;
            billingGroupBox.Text = "Billing Details"; // Added title for clarity
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point((ClientSize.Width - 200) / 2, 350); // Centered position
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(200, 50); // Adjusted size for better usability
            btnConfirm.TabIndex = 2;
            btnConfirm.Text = "Confirm Payment";
            btnConfirm.UseVisualStyleBackColor = true;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 500); // Adjusted form size
            Controls.Add(paymentGroupBox);
            Controls.Add(billingGroupBox);
            Controls.Add(btnConfirm);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "OrderForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Order Form";
            ResumeLayout(false);
        }
    }
}
