using Microsoft.Data.SqlClient; // You can use this if you're manually interacting with SQL Server
using Microsoft.EntityFrameworkCore; // Entity Framework Core
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using WinFormsApp2.Migrations;
using WinFormsApp2.Models;

namespace WinFormsApp2
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void RegisterForm_Load_1(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Validate the input
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtUsername.Text) ||
                string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtRepeatPassword.Text))
            {
                lblMessage.Text = "All fields must be filled!";
                return;
            }

            if (txtPassword.Text != txtRepeatPassword.Text)
            {
                lblMessage.Text = "Passwords do not match!";
                return;
            }

            // Hash the password
            string hashedPassword = HashPassword(txtPassword.Text);

            // Save the user to the database using Entity Framework
            try
            {
                using (var context = new AppDbContext())
                {
                    // Check if the username already exists
                    bool usernameExists = context.Users.Any(u => u.UserName == txtUsername.Text);
                    if (usernameExists)
                    {
                        lblMessage.Text = "Username already exists!";
                        return;
                    }

                    // Create the new user object
                    var newUser = new User
                    {
                        Name = txtName.Text,
                        UserName = txtUsername.Text,
                        Password = hashedPassword
                    };

                    // Add the user to the database and save changes
                    context.Users.Add(newUser);
                    context.SaveChanges();

                    MessageBox.Show("Registration successful!");

                    // After successful registration, open the login form
                    Form1 loginForm = new Form1();
                    loginForm.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Error: " + ex.Message;
            }
        }


        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(hashBytes);
            }
        }
    }
}
