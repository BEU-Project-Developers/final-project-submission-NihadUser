using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
            //this.FormClosing += Home_FormClosing; // Attach the FormClosing event
        }
        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // Ensure all threads and processes are stopped
        }
        private void HomeForm_Load(object sender, EventArgs e)
        {
            int loggedInUserId = UserSession.UserId;
            string loggedInUserName = UserSession.UserName;

            // Display user information (optional)
            label1.Text = $"Welcome, {loggedInUserName}!";
        }
    }
}
