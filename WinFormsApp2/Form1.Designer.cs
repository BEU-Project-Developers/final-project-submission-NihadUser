using System.Windows.Forms;

namespace WinFormsApp2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            loginBtn = new Button();
            textBox2 = new TextBox();
            pictureBox = new PictureBox();
            titleLabel = new Label();
            leftPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)leftPictureBox).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(536, 171);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Username";
            textBox1.Size = new Size(300, 34);
            textBox1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(250, 251, 255);
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(884, 490);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.DarkSlateBlue;
            loginBtn.Cursor = Cursors.Hand;
            loginBtn.FlatAppearance.BorderSize = 0;
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            loginBtn.ForeColor = Color.White;
            loginBtn.Location = new Point(582, 310);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(200, 50);
            loginBtn.TabIndex = 3;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(536, 233);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.PlaceholderText = "Password";
            textBox2.Size = new Size(300, 34);
            textBox2.TabIndex = 1;
            // 
            // pictureBox
            // 
            pictureBox.BackColor = Color.WhiteSmoke;
            pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox.Location = new Point(0, 23);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(372, 317);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 100;
            pictureBox.TabStop = false;
            // 
            // titleLabel
            // 
            titleLabel.BackColor = Color.FromArgb(250, 251, 255);
            titleLabel.Font = new Font("Viner Hand ITC", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.DarkSlateBlue;
            titleLabel.Location = new Point(536, 70);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(300, 50);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Welcome Back!";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // leftPictureBox
            // 
            leftPictureBox.BackColor = Color.LightGray;
            leftPictureBox.BackgroundImage = (Image)resources.GetObject("leftPictureBox.BackgroundImage");
            leftPictureBox.Location = new Point(12, 41);
            leftPictureBox.Name = "leftPictureBox";
            leftPictureBox.Size = new Size(476, 359);
            leftPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            leftPictureBox.TabIndex = 101;
            leftPictureBox.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 490);
            Controls.Add(leftPictureBox);
            Controls.Add(titleLabel);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(loginBtn);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)leftPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.PictureBox leftPictureBox; // Declare leftPictureBox
    }
}
