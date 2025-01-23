using Microsoft.EntityFrameworkCore;
using System;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using WinFormsApp2.Models; // Adjust according to your namespace

namespace WinFormsApp2
{
    public partial class DetailsForm : Form
    {
        private readonly int _productId;

        public DetailsForm(int productId)
        {
            _productId = productId;
            InitializeComponent();
        }

        private void DetailsForm_Load(object sender, EventArgs e)
        {
            LoadProductDetails();
        }

        private void LoadProductDetails()
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    // Fetch product details
                    var product = context.Products.FirstOrDefault(p => p.Id == _productId);

                    if (product == null)
                    {
                        MessageBox.Show("Product not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Close();
                        return;
                    }

                    // Fetch category name
                    var categoryName = context.Categories
                        .Where(c => c.Id == product.CategoryId)
                        .Select(c => c.Name)
                        .FirstOrDefault() ?? "Unknown";

                    // Fetch user/owner details
                    var owner = context.Users
                        .Where(u => u.Id == product.UserId)
                        .Select(u => new { u.Name })
                        .FirstOrDefault();

                    var ownerName = owner?.Name ?? "Unknown";
                    var ownerPhone = product?.OwnerPhone ?? "Not available";

                    // Set form details
                    lblProductName.Text = product.Name;
                    lblPrice.Text = $"Price: ${product.Price:F2}";
                    lblCategory.Text = $"Category: {categoryName}";
                    lblOwner.Text = $"Owner: {ownerName}";
                    lblOwnerPhone.Text = $"Owner Phone: {ownerPhone}";
                    lblProductAddress.Text = $"Address: {product.ProductAddress ?? "Not available"}";
                    lblDescription.Text = product.Description ?? "No description available.";

                    // Load image
                    if (!string.IsNullOrEmpty(product.Image))
                    {
                        try
                        {
                            if (product.Image.StartsWith("http"))
                            {
                                using (var client = new WebClient())
                                {
                                    byte[] imageBytes = client.DownloadData(product.Image);
                                    using (var ms = new System.IO.MemoryStream(imageBytes))
                                    {
                                        pictureBox.Image = Image.FromStream(ms);
                                    }
                                }
                            }
                            else
                            {
                                pictureBox.Image = Image.FromFile(product.Image);
                            }
                        }
                        catch
                        {
                            pictureBox.Image = null; // Fallback if the image fails to load
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading product details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int currentUserId = UserSession.UserId;

                using (var context = new AppDbContext())
                {
                    var existingBasketItem = context.Baskets
                        .FirstOrDefault(b => b.UserId == currentUserId && b.ProductId == _productId && !b.IsCheckedOut && b.DeletedAt == null);

                    if (existingBasketItem != null)
                    {
                        MessageBox.Show("This product is already in your basket.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    var basketItem = new Basket
                    {
                        UserId = currentUserId,
                        ProductId = _productId,
                        CreatedAt = DateTime.Now
                    };

                    context.Baskets.Add(basketItem);
                    context.SaveChanges();
                    MessageBox.Show("Product added to basket successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BasketForm basket = new BasketForm(currentUserId);
                    basket.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding the product to the basket: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
