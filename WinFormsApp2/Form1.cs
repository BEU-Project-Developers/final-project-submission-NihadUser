using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;  

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
        public string sqlConn()
        {
            return "Data Source=DESKTOP-10DFVI1;Initial Catalog=e_commerce;Integrated Security=True;Trust Server Certificate=True";
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string conn = sqlConn();

            string uName = textBox1.Text.Trim();
            string psw = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(uName) || string.IsNullOrEmpty(psw))
            {
                MessageBox.Show("Enter name and password.");
                return;
            }

            string query = "SELECT * FROM users WHERE user_name = @user_name AND password = @password";

            using (SqlConnection connection = new SqlConnection(conn))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@user_name", uName);
                        command.Parameters.AddWithValue("@password", psw);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                reader.Read();

                                string userId = reader["id"]?.ToString() ?? "N/A";
                                string userName = reader["user_name"]?.ToString() ?? "N/A";

                                MessageBox.Show($"success! User id is: {userId}, user name is: {userName}");
                            }
                            else
                            {
                                MessageBox.Show("incorrect username or password.");
                            }
                        }
                    }
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show($"Error is : {sqlEx.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

    }
}
