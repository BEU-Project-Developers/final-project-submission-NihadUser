namespace WinFormsApp2
{
    partial class Form3
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
            Go_To_Details_btn = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // Go_To_Details_btn
            // 
            Go_To_Details_btn.BackColor = System.Drawing.SystemColors.Highlight;
            Go_To_Details_btn.Location = new System.Drawing.Point(283, 276);
            Go_To_Details_btn.Name = "Go_To_Details_btn";
            Go_To_Details_btn.Size = new System.Drawing.Size(171, 58);
            Go_To_Details_btn.TabIndex = 0;
            Go_To_Details_btn.Text = "Go To Details";
            Go_To_Details_btn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Tan;
            label1.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(235, 65);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(267, 62);
            label1.TabIndex = 1;
            label1.Text = "Home Page";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Tan;
            label2.Location = new System.Drawing.Point(52, 167);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(724, 20);
            label2.TabIndex = 2;
            label2.Text = "Our platform is designed to provide a seamless online shopping experience. With a wide range of products, ";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Tan;
            label3.Location = new System.Drawing.Point(64, 197);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(703, 20);
            label3.TabIndex = 3;
            label3.Text = "intuitive navigation, and secure payment options, we aim to connect customers with the brands they love.";
            // 
            // Form3
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.download__1_;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Go_To_Details_btn);
            Name = "Form3";
            Text = "Home";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button Go_To_Details_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}