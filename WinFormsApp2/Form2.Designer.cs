namespace WinFormsApp2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            ListBoxProducts = new System.Windows.Forms.ListBox();
            add_to_cart = new System.Windows.Forms.Button();
            Search_btn = new System.Windows.Forms.Button();
            See_The_Cart_btn = new System.Windows.Forms.Button();
            Search_txtbox = new System.Windows.Forms.TextBox();
            Go_Back_To_Login = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // ListBoxProducts
            // 
            ListBoxProducts.FormattingEnabled = true;
            ListBoxProducts.ItemHeight = 20;
            ListBoxProducts.Location = new System.Drawing.Point(12, 42);
            ListBoxProducts.Name = "ListBoxProducts";
            ListBoxProducts.Size = new System.Drawing.Size(429, 224);
            ListBoxProducts.TabIndex = 0;
            // 
            // add_to_cart
            // 
            add_to_cart.BackColor = System.Drawing.SystemColors.Highlight;
            add_to_cart.Location = new System.Drawing.Point(533, 69);
            add_to_cart.Name = "add_to_cart";
            add_to_cart.Size = new System.Drawing.Size(163, 44);
            add_to_cart.TabIndex = 1;
            add_to_cart.Text = "Add To Cart";
            add_to_cart.UseVisualStyleBackColor = false;
            // 
            // Search_btn
            // 
            Search_btn.Location = new System.Drawing.Point(393, 9);
            Search_btn.Name = "Search_btn";
            Search_btn.Size = new System.Drawing.Size(64, 27);
            Search_btn.TabIndex = 2;
            Search_btn.Text = "Search";
            Search_btn.UseVisualStyleBackColor = true;
            // 
            // See_The_Cart_btn
            // 
            See_The_Cart_btn.BackColor = System.Drawing.SystemColors.Highlight;
            See_The_Cart_btn.Location = new System.Drawing.Point(533, 176);
            See_The_Cart_btn.Name = "See_The_Cart_btn";
            See_The_Cart_btn.Size = new System.Drawing.Size(163, 42);
            See_The_Cart_btn.TabIndex = 3;
            See_The_Cart_btn.Text = "See The Cart";
            See_The_Cart_btn.UseVisualStyleBackColor = false;
            // 
            // Search_txtbox
            // 
            Search_txtbox.Location = new System.Drawing.Point(12, 9);
            Search_txtbox.Name = "Search_txtbox";
            Search_txtbox.Size = new System.Drawing.Size(375, 27);
            Search_txtbox.TabIndex = 4;
            Search_txtbox.Text = "Type Something";
            // 
            // Go_Back_To_Login
            // 
            Go_Back_To_Login.BackColor = System.Drawing.SystemColors.Info;
            Go_Back_To_Login.Location = new System.Drawing.Point(126, 285);
            Go_Back_To_Login.Name = "Go_Back_To_Login";
            Go_Back_To_Login.Size = new System.Drawing.Size(159, 37);
            Go_Back_To_Login.TabIndex = 5;
            Go_Back_To_Login.Text = "Go Back To Login\r\n";
            Go_Back_To_Login.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2024_12_04_003931;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(800, 345);
            Controls.Add(Go_Back_To_Login);
            Controls.Add(Search_txtbox);
            Controls.Add(See_The_Cart_btn);
            Controls.Add(Search_btn);
            Controls.Add(add_to_cart);
            Controls.Add(ListBoxProducts);
            Name = "Form2";
            Text = "Details";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxProducts;
        private System.Windows.Forms.Button add_to_cart;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.Button See_The_Cart_btn;
        private System.Windows.Forms.TextBox Search_txtbox;
        private System.Windows.Forms.Button Go_Back_To_Login;
    }
}