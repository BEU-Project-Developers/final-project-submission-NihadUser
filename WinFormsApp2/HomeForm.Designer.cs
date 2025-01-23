namespace WinFormsApp2
{
    partial class HomeForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnCreate;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
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
            btnCreate = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(350, 20);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(10, 80);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1000, 471);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // btnCreate
            // 

            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();

            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(20, 80); // Adjust position as needed
            this.txtSearch.Size = new System.Drawing.Size(200, 30);    // Adjust size as needed
            this.txtSearch.Font = new System.Drawing.Font("Arial", 12F);
            this.txtSearch.PlaceholderText = "Search by product name"; // Optional: Add placeholder text

            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(230, 80); // Adjust position next to the TextBox
            this.btnSearch.Size = new System.Drawing.Size(100, 30);    // Adjust size as needed
            this.btnSearch.Text = "Search";
            this.btnSearch.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);


            btnCreate.BackColor = Color.FromArgb(28, 112, 187);
            btnCreate.FlatAppearance.BorderSize = 0;
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(10, 20);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(120, 40);
            btnCreate.TabIndex = 2;
            btnCreate.Text = "Add Product";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(932, 20);
            button1.Name = "button1";
            button1.Size = new Size(47, 40);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(880, 20);
            button2.Name = "button2";
            button2.Size = new Size(46, 40);
            button2.TabIndex = 4;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1020, 608);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnCreate);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(20, 120); 

            Name = "HomeForm";
            Text = "HomeForm";
            Load += HomeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Button button1;
        private Button button2;
    }
}
