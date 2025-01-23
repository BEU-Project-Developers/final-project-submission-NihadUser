// BasketForm.Designer.cs
namespace WinFormsApp2
{
    partial class BasketForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAddNewPlan;
        private System.Windows.Forms.Label totalPriceLabel;

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
            flowLayoutPanel = new FlowLayoutPanel();
            lblTitle = new Label();
            btnAddNewPlan = new Button();
            totalPriceLabel = new Label();

            SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.BackColor = Color.WhiteSmoke;
            flowLayoutPanel.Location = new Point(23, 80);
            flowLayoutPanel.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(869, 440);
            flowLayoutPanel.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(23, 27);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(88, 32);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Basket";
            // 
            // btnAddNewPlan
            // 
            btnAddNewPlan.Font = new Font("Segoe UI", 10F);
            btnAddNewPlan.Location = new Point(23, 533);
            btnAddNewPlan.Margin = new Padding(3, 4, 3, 4);
            btnAddNewPlan.Name = "btnAddNewPlan";
            btnAddNewPlan.Size = new Size(229, 40);
            btnAddNewPlan.TabIndex = 2;
            btnAddNewPlan.Text = "Order Products";
            btnAddNewPlan.UseVisualStyleBackColor = true;
            btnAddNewPlan.Click += BtnAddNewPlan_Click;
            // 
            // totalPriceLabel
            // 
            totalPriceLabel.AutoSize = true;
            totalPriceLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            totalPriceLabel.ForeColor = Color.Green;
            totalPriceLabel.Location = new Point(680, 533);
            totalPriceLabel.Name = "totalPriceLabel";
            totalPriceLabel.Size = new Size(150, 28);
            totalPriceLabel.TabIndex = 300000;
            //totalPriceLabel.Text = "Total Price: $0.00";
            totalPriceLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // BasketForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(totalPriceLabel);
            Controls.Add(btnAddNewPlan);
            Controls.Add(lblTitle);
            Controls.Add(flowLayoutPanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "BasketForm";
            Text = "BasketForm";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
