using Microsoft.EntityFrameworkCore;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using WinFormsApp2.Models; // Adjust according to your namespace

namespace WinFormsApp2
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            int loggedInUserId = UserSession.UserId;
            string loggedInUserName = UserSession.Name;

            // Set a welcoming message with the user's name
            label1.Text = $"Welcome, {loggedInUserName}!";
            label1.Font = new Font("Arial", 16, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point((ClientSize.Width - label1.Width) / 2, 30); // Center the label

            // Load products into the FlowLayoutPanel
            LoadProducts(loggedInUserId);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int loggedInUserId = UserSession.UserId;
            LoadProducts(loggedInUserId); // Reload products
        }

        private void LoadProducts(int loggedInUserId)
        {
            // Clear existing controls in FlowLayoutPanel to prevent duplication
            flowLayoutPanel1.Controls.Clear();

            try
            {
                using (var context = new AppDbContext()) // Use DbContext for querying the database
                {
                    // Get products where DeletedAt is null
                    var products = context.Products
                    .Where(p => p.DeletedAt == null)
                    .OrderByDescending(p => p.CreatedAt) // Descending order
                    .ToList();

                    // Add product cards to the FlowLayoutPanel
                    foreach (var product in products)
                    {
                        var productCard = CreateProductCard(product, loggedInUserId);
                        flowLayoutPanel1.Controls.Add(productCard);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Panel CreateProductCard(Product product, int loggedInUserId)
        {
            // Main panel for the product card
            Panel panel = new Panel
            {
                Size = new Size((flowLayoutPanel1.ClientSize.Width / 2) - 45, 500), // Adjust width for two cards in a row
                Margin = new Padding(20, 10, 20, 10),
                Padding = new Padding(20),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle // Add border to each card
            };

            // PictureBox for product image
            PictureBox pictureBox = new PictureBox
            {
                Size = new Size(panel.Width - 40, 200),
                Location = new Point(20, 20),
                SizeMode = PictureBoxSizeMode.StretchImage,
                BorderStyle = BorderStyle.None
            };

            // Load the image from the product's Image property
            if (!string.IsNullOrEmpty(product.Image))
            {
                try
                {
                    if (product.Image.StartsWith("http"))
                    {
                        using (var client = new System.Net.WebClient())
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

            // Label for product name
            Label lblName = new Label
            {
                Text = product.Name,
                Font = new Font("Arial", 14, FontStyle.Bold),
                Location = new Point(20, pictureBox.Bottom + 10),
                AutoSize = true,
                ForeColor = Color.Black
            };

            // Label for price
            Label lblPrice = new Label
            {
                Text = $"${product.Price:F2}/Day",
                Font = new Font("Arial", 14, FontStyle.Bold),
                Location = new Point(20, lblName.Bottom + 5),
                AutoSize = true,
                ForeColor = Color.FromArgb(0, 120, 215)
            };

            // Label for location
            Label lblLocation = new Label
            {
                Text = !string.IsNullOrEmpty(product.ProductAddress) ? product.ProductAddress : "--", // Show "--" if location is null
                Font = new Font("Arial", 10, FontStyle.Regular),
                Location = new Point(20, lblPrice.Bottom + 5),
                AutoSize = true,
                ForeColor = Color.Gray
            };

            // Rating label (optional)
            Label lblRating = new Label
            {
                Text = "★ 5.0 (120 reviews)", // You can fetch actual ratings if available
                Font = new Font("Arial", 10, FontStyle.Bold),
                Location = new Point(20, lblLocation.Bottom + 5),
                AutoSize = true,
                ForeColor = Color.OrangeRed
            };

            // Button for viewing details
            Button btnViewDetails = new Button
            {
                Text = "View Details",
                Size = new Size(panel.Width - 40, 40),
                Location = new Point(20, lblRating.Bottom + 10),
                BackColor = Color.FromArgb(0, 120, 215),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Arial", 10, FontStyle.Bold)
            };

            btnViewDetails.FlatAppearance.BorderSize = 0;
            btnViewDetails.Click += (sender, e) =>
            {
                DetailsForm detailsForm = new DetailsForm(product.Id);
                detailsForm.Show();
            };

            // Show Edit and Delete buttons if the user is the product owner
            if (product.UserId == loggedInUserId)
            {
                // Edit button
                Button btnEdit = new Button
                {
                    Text = "Edit",
                    Size = new Size((panel.Width - 60) / 2, 40),
                    Location = new Point(20, btnViewDetails.Bottom + 10),
                    BackColor = Color.YellowGreen,
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Arial", 10, FontStyle.Bold)
                };
                btnEdit.FlatAppearance.BorderSize = 0;

                // Delete button
                Button btnDelete = new Button
                {
                    Text = "Delete",
                    Size = new Size((panel.Width - 60) / 2, 40),
                    Location = new Point(btnEdit.Right + 20, btnViewDetails.Bottom + 10),
                    BackColor = Color.Crimson,
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Arial", 10, FontStyle.Bold)
                };
                btnDelete.FlatAppearance.BorderSize = 0;

                btnEdit.Click += (sender, e) =>
                {
                    EditProduct editProductForm = new EditProduct(product.Id);
                    editProductForm.Show();
                };

                btnDelete.Click += (sender, e) =>
                {
                    try
                    {
                        using (var context = new AppDbContext())
                        {
                            product.DeletedAt = DateTime.Now;
                            context.Products.Update(product);
                            context.SaveChanges();
                        }

                        MessageBox.Show("Product marked as deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        panel.Visible = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                };

                panel.Controls.Add(btnEdit);
                panel.Controls.Add(btnDelete);
            }

            // Add controls to panel
            panel.Controls.Add(pictureBox);
            panel.Controls.Add(lblName);
            panel.Controls.Add(lblPrice);
            panel.Controls.Add(lblLocation);
            panel.Controls.Add(lblRating);
            panel.Controls.Add(btnViewDetails);

            return panel;
        }


        private void SetRoundedCorners(Panel panel, int radius)
        {
            var path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(panel.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(panel.Width - radius, panel.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, panel.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            panel.Region = new Region(path);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateProduct createProductForm = new CreateProduct();
            createProductForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int loggedInUserId = UserSession.UserId;
            BasketForm basket = new BasketForm(loggedInUserId);
            basket.Show();
        }
    }
}