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
            txtSearch = new TextBox();
            btnSearch = new Button();
            button3 = new Button();
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
            flowLayoutPanel1.Location = new Point(20, 120);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1000, 471);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.FromArgb(28, 112, 187);
            btnCreate.FlatAppearance.BorderSize = 0;
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(20, 20);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(118, 40);
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
            // txtSearch
            // 
            txtSearch.Font = new Font("Arial", 12F);
            txtSearch.Location = new Point(20, 80);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search by product name";
            txtSearch.Size = new Size(200, 30);
            txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(0, 120, 215);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(230, 80);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 30);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += BtnSearch_Click;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Location = new Point(835, 20);
            button3.Name = "button3";
            button3.Size = new Size(39, 40);
            button3.TabIndex = 5;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1020, 608);
            Controls.Add(button3);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnCreate);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            Name = "HomeForm";
            Text = "HomeForm";
            Load += HomeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Button button1;
        private Button button2;
        private Button button3;
    }
}
