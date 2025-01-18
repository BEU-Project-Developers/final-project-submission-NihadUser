using System;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        }
    }
}
