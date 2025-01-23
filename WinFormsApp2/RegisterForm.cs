using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
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

            string hashedPassword = HashPassword(txtPassword.Text);

            try
            {
                using (var context = new AppDbContext())
                {
                    bool usernameExists = context.Users.Any(u => u.UserName == txtUsername.Text);
                    if (usernameExists)
                    {
                        lblMessage.Text = "Username already exists!";
                        return;
                    }

                    var newUser = new User
                    {
                        Name = txtName.Text,
                        UserName = txtUsername.Text,
                        Password = hashedPassword
                    };

                    context.Users.Add(newUser);
                    context.SaveChanges();

                    MessageBox.Show("Registration successful!");

                    Form1 loginForm = new Form1();
                    loginForm.Show();
                    //this.Close();
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
