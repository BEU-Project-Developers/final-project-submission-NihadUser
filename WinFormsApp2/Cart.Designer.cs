 namespace WinFormsApp2
{
    partial class Cart
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
            listBox_Products = new System.Windows.Forms.ListBox();
            Go_Back_To_Login = new System.Windows.Forms.Button();
            button_remove_from_cart = new System.Windows.Forms.Button();
            Buy = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // listBox_Products
            // 
            listBox_Products.BackColor = System.Drawing.SystemColors.ControlDark;
            listBox_Products.FormattingEnabled = true;
            listBox_Products.ItemHeight = 20;
            listBox_Products.Location = new System.Drawing.Point(21, 25);
            listBox_Products.Name = "listBox_Products";
            listBox_Products.Size = new System.Drawing.Size(388, 264);
            listBox_Products.TabIndex = 0;
            // 
            // Go_Back_To_Login
            // 
            Go_Back_To_Login.BackColor = System.Drawing.SystemColors.Highlight;
            Go_Back_To_Login.Location = new System.Drawing.Point(250, 318);
            Go_Back_To_Login.Name = "Go_Back_To_Login";
            Go_Back_To_Login.Size = new System.Drawing.Size(159, 54);
            Go_Back_To_Login.TabIndex = 6;
            Go_Back_To_Login.Text = "Go Back To Login\r\n";
            Go_Back_To_Login.UseVisualStyleBackColor = false;
            // 
            // button_remove_from_cart
            // 
            button_remove_from_cart.BackColor = System.Drawing.SystemColors.ActiveCaption;
            button_remove_from_cart.Location = new System.Drawing.Point(562, 62);
            button_remove_from_cart.Name = "button_remove_from_cart";
            button_remove_from_cart.Size = new System.Drawing.Size(169, 61);
            button_remove_from_cart.TabIndex = 7;
            button_remove_from_cart.Text = "Remove From Cart";
            button_remove_from_cart.UseVisualStyleBackColor = false;
            button_remove_from_cart.Click += button_remove_from_cart_Click;
            // 
            // Buy
            // 
            Buy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            Buy.Location = new System.Drawing.Point(562, 160);
            Buy.Name = "Buy";
            Buy.Size = new System.Drawing.Size(169, 67);
            Buy.TabIndex = 8;
            Buy.Text = "Buy";
            Buy.UseVisualStyleBackColor = false;
            // 
            // Cart
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2024_12_04_003700;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(770, 415);
            Controls.Add(Buy);
            Controls.Add(button_remove_from_cart);
            Controls.Add(Go_Back_To_Login);
            Controls.Add(listBox_Products);
            DoubleBuffered = true;
            Name = "Cart";
            Text = "Cart";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Products;
        private System.Windows.Forms.Button Go_Back_To_Login;
        private System.Windows.Forms.Button button_remove_from_cart;
        private System.Windows.Forms.Button Buy;
    }
}