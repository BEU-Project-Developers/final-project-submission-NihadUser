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
        private AppDbContext _dbContext;

        public HomeForm()
        {
            InitializeComponent();
            _dbContext = new AppDbContext(); // Initialize DbContext
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            int loggedInUserId = UserSession.UserId;
            string loggedInUserName = UserSession.Name;

            // Set a welcoming message with user's name
            label1.Text = $"Welcome, {loggedInUserName}!";
            label1.Font = new Font("Arial", 16, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point((ClientSize.Width - label1.Width) / 2, 30); // Center the label

            // Load products into the FlowLayoutPanel
            LoadProducts(loggedInUserId);
        }

        private void LoadProducts(int loggedInUserId)
        {
            // Use Entity Framework to fetch products
            using (var context = new AppDbContext()) // Replace with your DbContext name
            {
                // Get products where deleted_at is null
                var products = context.Products
                                      .Where(p => p.DeletedAt == null) // Filter for products where DeletedAt is null
                                      .ToList();

                // Loop through the data and add product cards dynamically
                foreach (var product in products)
                {
                    // Create a panel for each product (card)
                    Panel productCard = CreateProductCard(product, loggedInUserId);

                    // Add the card to the FlowLayoutPanel
                    flowLayoutPanel1.Controls.Add(productCard);
                }
            }
        }

        private Panel CreateProductCard(Product product, int loggedInUserId)
        {
            // Main panel for the product card
            Panel panel = new Panel
            {
                Size = new Size((flowLayoutPanel1.ClientSize.Width / 2) - 45, 480), // Adjust width for two cards in a row
                Margin = new Padding(20, 10, 20, 10),
                Padding = new Padding(20),
                BackColor = Color.White, // White background for a clean look
                BorderStyle = BorderStyle.None // Default to none, we'll custom draw the border
            };

            // Set rounded corners
            SetRoundedCorners(panel, 20);

            // Draw light gray border
            panel.Paint += (sender, e) =>
            {
                var pnl = (Panel)sender;
                using (Pen pen = new Pen(Color.LightGray, 2)) // Light gray border color
                {
                    e.Graphics.DrawRectangle(pen, 0, 0, pnl.Width - 1, pnl.Height - 1); // Draw border inside the panel
                }
            };

            // PictureBox for product image
            PictureBox pictureBox = new PictureBox
            {
                Size = new Size(panel.Width - 40, 200),
                Location = new Point(20, 20),
                SizeMode = PictureBoxSizeMode.StretchImage,
                BorderStyle = BorderStyle.None
            };

            // Load the image from the product's Image property (URL or binary)
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
                    pictureBox.Image = null;
                }
            }
            else
            {
                pictureBox.Image = null;
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
                Text = $"${product.Price:F2}",
                Font = new Font("Arial", 14, FontStyle.Bold),
                Location = new Point(20, lblName.Bottom + 5),
                AutoSize = true,
                ForeColor = Color.FromArgb(0, 120, 215)
            };

            // Location label (optional)
            Label lblLocation = new Label
            {
                Text = "Chittagong, Bangladesh",
                Font = new Font("Arial", 10, FontStyle.Regular),
                Location = new Point(20, lblPrice.Bottom + 5),
                AutoSize = true,
                ForeColor = Color.Gray
            };

            // Rating label (optional)
            Label lblRating = new Label
            {
                Text = "\u2605 5.0 (120 reviews)",
                Font = new Font("Arial", 10, FontStyle.Regular),
                Location = new Point(20, lblLocation.Bottom + 5),
                AutoSize = true,
                ForeColor = Color.FromArgb(255, 165, 0)
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

                // Event handler for the "Edit" button
                btnEdit.Click += (sender, e) =>
                {
                    EditProduct editProductForm = new EditProduct(product.Id); // Pass the product Id to EditProduct form
                    editProductForm.Show();
                };

                // Event handler for the "Delete" button
                btnDelete.Click += (sender, e) =>
                {
                    try
                    {
                        // Set the deleted_at property to the current date/time
                            product.DeletedAt = DateTime.Now;

                        // Update the product in the database
                        _dbContext.Products.Update(product);
                        _dbContext.SaveChanges();

                        MessageBox.Show("Product marked as deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Optionally, remove the product card from the UI after deletion
                        panel.Visible = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                };

                // Add buttons to the panel
                panel.Controls.Add(btnEdit);
                panel.Controls.Add(btnDelete);
            }

            // Add controls to the panel
            panel.Controls.Add(pictureBox);
            panel.Controls.Add(lblName);
            panel.Controls.Add(lblPrice);
            panel.Controls.Add(lblLocation);
            panel.Controls.Add(lblRating);
            panel.Controls.Add(btnViewDetails);

            return panel;
        }


        private void CustomizeButton(Button button)
        {
            button.FlatAppearance.BorderSize = 0; // Remove default borders
            button.FlatStyle = FlatStyle.Flat; // Flat style for custom rendering
            button.Padding = new Padding(10); // Add more padding for better spacing

            button.Paint += (sender, e) =>
            {
                var btn = (Button)sender;
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                // Draw rounded rectangle
                using (GraphicsPath path = new GraphicsPath())
                {
                    int radius = 50; // Adjust the corner radius
                    Rectangle rect = btn.ClientRectangle;
                    path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                    path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                    path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                    path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                    path.CloseFigure();

                    // Fill button background
                    using (Brush brush = new SolidBrush(btn.BackColor))
                    {
                        e.Graphics.FillPath(brush, path);
                    }

                    // Optional: Draw border
                    using (Pen pen = new Pen(btn.BackColor, 2))
                    {
                        e.Graphics.DrawPath(pen, path);
                    }

                    // Draw text with proper centering
                    TextRenderer.DrawText(
                        e.Graphics,
                        btn.Text,
                        btn.Font,
                        rect,
                        btn.ForeColor,
                        TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                    );
                }
            };
        }
        // Function to set rounded corners for a Panel
        private void SetRoundedCorners(Panel panel, int radius)
        {
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(panel.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(panel.Width - radius, panel.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, panel.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();
            panel.Region = new Region(path);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateProduct productCreateForm = new CreateProduct();
            productCreateForm.Show();
        }
    }
}
