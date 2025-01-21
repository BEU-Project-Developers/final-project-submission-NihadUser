using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WinFormsApp2.Models;

namespace WinFormsApp2
{
    public partial class BasketForm : Form
    {
        private readonly int _userId; // User ID passed to the form
        private readonly AppDbContext _dbContext; // Your EF Core DbContext

        public BasketForm(int userId)
        {
            InitializeComponent();
            _userId = userId;
            _dbContext = new AppDbContext(); // Initialize DbContext
            LoadBasketItems();
        }

        private void LoadBasketItems()
        {
            try
            {
                // Query Baskets and related Products using EF
                var basketItems = _dbContext.Baskets
                    .Where(b => b.UserId == _userId && !b.IsCheckedOut && b.DeletedAt == null)
                    .Select(b => new
                    {
                        b.Product.Id,
                        b.Product.Name,
                        b.Product.Image,
                        b.Product.Price,
                        b.CreatedAt
                    })
                    .ToList();

                // Add each product to the UI
                foreach (var item in basketItems)
                {
                    AddProductToUI(item.Name, item.Image, item.Price, item.CreatedAt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void AddProductToUI(string name, string imageUrl, decimal price, DateTime createdAt)
        {
            var productPanel = new Panel
            {
                Width = 300,
                Height = 150,
                Margin = new Padding(10),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };

            var pictureBox = new PictureBox
            {
                Width = 100,
                Height = 100,
                ImageLocation = imageUrl,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Location = new Point(10, 10)
            };

            var nameLabel = new Label
            {
                Text = name,
                Font = new Font("Arial", 12, FontStyle.Bold),
                Location = new Point(120, 10),
                AutoSize = true
            };

            var priceLabel = new Label
            {
                Text = $"Price: {price:C}",
                Font = new Font("Arial", 10),
                Location = new Point(120, 40),
                AutoSize = true
            };

            var dateLabel = new Label
            {
                Text = $"Added: {createdAt.ToShortDateString()}",
                Font = new Font("Arial", 8),
                Location = new Point(120, 70),
                AutoSize = true
            };

            productPanel.Controls.Add(pictureBox);
            productPanel.Controls.Add(nameLabel);
            productPanel.Controls.Add(priceLabel);
            productPanel.Controls.Add(dateLabel);

            flowLayoutPanel.Controls.Add(productPanel);
        }

        //private void BtnAddNewPlan_Click(object sender, EventArgs e)
        //{
        //    // Navigate to the new tour plan creation logic
        //    MessageBox.Show("Navigate to new tour plan creation.");
        //}
    }
}
