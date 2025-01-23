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
        private readonly int _userId;
        private decimal totalPrice;
        private readonly AppDbContext _dbContext;

        public BasketForm(int userId)
        {
            InitializeComponent();
            _userId = userId;
            _dbContext = new AppDbContext();
            //InitializeTotalPriceLabel();
            LoadBasketItems();
        }

        //private void InitializeTotalPriceLabel()
        //{
        //    // Create and configure the total price label
        //    totalPriceLabel = new Label
        //    {
        //        Text = "Total Price: $0.00",
        //        Font = new Font("Arial", 14, FontStyle.Bold),
        //        ForeColor = Color.Green,
        //        Dock = DockStyle.Bottom,
        //        TextAlign = ContentAlignment.MiddleRight,
        //        Padding = new Padding(10)
        //    };

        //    // Add the label to the form
        //    Controls.Add(totalPriceLabel);
        //}

        private void LoadBasketItems()
        {
            try
            {
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

                flowLayoutPanel.Controls.Clear();
                decimal tp = 0;

                foreach (var item in basketItems)
                {
                    AddProductToUI(item.Name, item.Image, item.Price, item.CreatedAt, item.Id);
                    tp += item.Price;
                }

                // Update the total price label
                this.totalPrice = tp;
                UpdateTotalPriceLabel(tp);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }



        private void AddProductToUI(string name, string imageUrl, decimal price, DateTime createdAt, int productId)
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

            var deleteButton = new Button
            {
                Text = "Delete",
                BackColor = Color.Red,
                ForeColor = Color.White,
                Font = new Font("Arial", 10, FontStyle.Bold),
                Location = new Point(120, 100),
                Width = 80,
                Height = 30,
                Tag = productId
            };

            deleteButton.Click += (sender, e) => DeleteProduct(sender);

            productPanel.Controls.Add(pictureBox);
            productPanel.Controls.Add(nameLabel);
            productPanel.Controls.Add(priceLabel);
            productPanel.Controls.Add(dateLabel);
            productPanel.Controls.Add(deleteButton);

            flowLayoutPanel.Controls.Add(productPanel);
        }

        private void DeleteProduct(object sender)
        {
            if (sender is Button deleteButton && deleteButton.Tag is int productId)
            {
                try
                {
                    var basketItem = _dbContext.Baskets
                        .FirstOrDefault(b => b.UserId == _userId && b.ProductId == productId && b.DeletedAt == null);

                    if (basketItem != null)
                    {
                        basketItem.DeletedAt = DateTime.Now;
                        _dbContext.SaveChanges();

                        MessageBox.Show("Product deleted successfully.");

                        LoadBasketItems(); // Reload basket items after deletion
                    }
                    else
                    {
                        MessageBox.Show("Product not found or already deleted.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private void UpdateTotalPriceLabel(decimal totalPrice)
        {
            totalPriceLabel.Text = $"Total Price: {totalPrice.ToString():C}";
        }

        private void BtnAddNewPlan_Click(object sender, System.EventArgs e)
        {
            OrderForm orderForm = new OrderForm(_dbContext, this.totalPrice);
            orderForm.Show();
        }
    }
}
