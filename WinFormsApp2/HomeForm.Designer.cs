namespace WinFormsApp2
{
    partial class HomeForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1; // Add FlowLayoutPanel

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(219, 134);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown; // Flow vertically
            flowLayoutPanel1.WrapContents = false; // Prevent wrapping
            flowLayoutPanel1.Location = new Point(10, 80); // Adjusted location
            flowLayoutPanel1.Size = new Size(500, 471); // Ensure enough space for one card per row
            flowLayoutPanel1.TabIndex = 1;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(210, 203, 170);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(521, 608);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            Name = "HomeForm";
            Text = "HomeForm";
            Load += HomeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
