using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using WinFormsApp2.Models;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing; // Attach the FormClosing event
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // Ensure all threads and processes are stopped
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = textBox2.Text;

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Username is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Password is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hash the entered password to compare with the stored one
            string hashedPassword = HashPassword(password);

            using (var context = new AppDbContext())
            {
                // Check if user exists
                var user = context.Users.FirstOrDefault(u => u.UserName == username);

                if (user == null)
                {
                    MessageBox.Show("User does not exist.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate password
                if (user.Password != hashedPassword)
                {
                    MessageBox.Show("Invalid password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Successful login
                MessageBox.Show("Login successful!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);

                UserSession.UserId = user.Id; // Store UserId
                UserSession.UserName = user.UserName;
                UserSession.Name = user.Name;


                // Open Home form or the next step in your application
                HomeForm homeForm = new HomeForm();
                homeForm.Show();
                //this.Close(); // Optional: hide the login form
            }
        }
    }
}
