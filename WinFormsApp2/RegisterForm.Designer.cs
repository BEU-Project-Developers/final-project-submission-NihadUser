namespace WinFormsApp2
{
    public partial class RegisterForm : Form
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblMessage;  // Declare lblMessage here

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            lblHeading = new Label();
            txtName = new TextBox();
            lblName = new Label();
            txtUsername = new TextBox();
            lblUsername = new Label();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtRepeatPassword = new TextBox();
            lblRepeatPassword = new Label();
            btnRegister = new Button();
            pictureBox = new PictureBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            lblMessage = new Label();  // Initialize lblMessage

            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();

            // 
            // lblHeading
            // 
            lblHeading.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblHeading.Location = new Point(506, 23);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(294, 30);
            lblHeading.TabIndex = 9;
            lblHeading.Text = "Create Your Account";
            lblHeading.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 10F);
            txtName.Location = new Point(537, 81);
            txtName.Name = "txtName";
            txtName.Size = new Size(250, 30);
            txtName.TabIndex = 0;

            // 
            // lblName
            // 
            lblName.Font = new Font("Segoe UI", 10F);
            lblName.Location = new Point(457, 81);
            lblName.Name = "lblName";
            lblName.Size = new Size(75, 30);
            lblName.TabIndex = 8;
            lblName.Text = "Name:";
            lblName.TextAlign = ContentAlignment.MiddleRight;

            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 10F);
            txtUsername.Location = new Point(537, 134);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(250, 30);
            txtUsername.TabIndex = 1;

            // 
            // lblUsername
            // 
            lblUsername.Font = new Font("Segoe UI", 10F);
            lblUsername.Location = new Point(439, 134);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(93, 30);
            lblUsername.TabIndex = 7;
            lblUsername.Text = "Username:";
            lblUsername.TextAlign = ContentAlignment.MiddleRight;

            // 
            // lblMessage
            // 
            lblMessage.Font = new Font("Segoe UI", 10F);
            lblMessage.ForeColor = Color.Red;
            lblMessage.Location = new Point(476, 273);  // Adjust location as needed
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(300, 30);
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 10F);
            txtPassword.Location = new Point(537, 179);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(250, 30);
            txtPassword.TabIndex = 2;

            // 
            // lblPassword
            // 
            lblPassword.Font = new Font("Segoe UI", 10F);
            lblPassword.Location = new Point(424, 179);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(108, 30);
            lblPassword.TabIndex = 6;
            lblPassword.Text = "Password:";
            lblPassword.TextAlign = ContentAlignment.MiddleRight;

            // 
            // txtRepeatPassword
            // 
            txtRepeatPassword.Font = new Font("Segoe UI", 10F);
            txtRepeatPassword.Location = new Point(537, 229);
            txtRepeatPassword.Name = "txtRepeatPassword";
            txtRepeatPassword.PasswordChar = '*';
            txtRepeatPassword.Size = new Size(250, 30);
            txtRepeatPassword.TabIndex = 3;

            // 
            // lblRepeatPassword
            // 
            lblRepeatPassword.Font = new Font("Segoe UI", 10F);
            lblRepeatPassword.Location = new Point(378, 229);
            lblRepeatPassword.Name = "lblRepeatPassword";
            lblRepeatPassword.Size = new Size(154, 30);
            lblRepeatPassword.TabIndex = 5;
            lblRepeatPassword.Text = "Repeat Password:";
            lblRepeatPassword.TextAlign = ContentAlignment.MiddleRight;

            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.DeepSkyBlue;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(524, 300);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(263, 40);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "REGISTER NOW";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;

            // 
            // pictureBox
            // 
            pictureBox.BackColor = Color.WhiteSmoke;
            pictureBox.BackgroundImage = (Image)resources.GetObject("pictureBox.BackgroundImage");
            pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox.Location = new Point(0, 23);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(372, 317);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 10;
            pictureBox.TabStop = false;

            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;

            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(839, 427);
            Controls.Add(btnRegister);
            Controls.Add(txtRepeatPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtName);
            Controls.Add(lblRepeatPassword);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(lblMessage);  // Add lblMessage to controls
            Controls.Add(lblName);
            Controls.Add(lblHeading);
            Controls.Add(pictureBox);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            Load += RegisterForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtRepeatPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblRepeatPassword;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.PictureBox pictureBox;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}
