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

                    // Fetch user/owner name
                    var ownerName = context.Users
                        .Where(u => u.Id == product.UserId)
                        .Select(u => u.Name)
                        .FirstOrDefault() ?? "Unknown";

                    // Set form details
                    lblProductName.Text = product.Name;
                    lblPrice.Text = $"Price: ${product.Price:F2}";
                    lblCategory.Text = $"Category: {categoryName}";
                    lblOwner.Text = $"Owner: {ownerName}";
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

    }
}
