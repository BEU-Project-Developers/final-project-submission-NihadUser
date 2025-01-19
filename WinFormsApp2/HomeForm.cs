using System;
using System.Drawing;
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
            string loggedInUserName = UserSession.UserName;

            // Set a welcoming message with user's name
            label1.Text = $"Welcome, {loggedInUserName}!";
            label1.Font = new Font("Arial", 16, FontStyle.Bold);
            label1.ForeColor = Color.White;
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
            Panel panel = new Panel
            {
                Size = new Size(flowLayoutPanel1.ClientSize.Width - 75, 350), // Width matches FlowLayoutPanel minus padding
                Margin = new Padding(20, 10, 20, 10),
                Padding = new Padding(30),
                BackColor = Color.LightSteelBlue
            };

            // Set rounded corners
            SetRoundedCorners(panel, 15);

            Label lblName = new Label
            {
                Text = product.Name,
                Font = new Font("Arial", 12, FontStyle.Bold),
                Location = new Point(10, 10),
                AutoSize = true,
                ForeColor = Color.DarkSlateGray
            };

            Label lblPrice = new Label
            {
                Text = $"${product.Price:F2}",
                Font = new Font("Arial", 12, FontStyle.Regular),
                Location = new Point(10, 50),
                AutoSize = true,
                ForeColor = Color.DarkOliveGreen
            };

            Button btnAddToCart = new Button
            {
                Text = "Add to Cart",
                Location = new Point(10, 90),
                Size = new Size(160, 30),
                BackColor = Color.SkyBlue,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Arial", 10, FontStyle.Bold)
            };

            panel.Controls.Add(lblName);
            panel.Controls.Add(lblPrice);
            panel.Controls.Add(btnAddToCart);

            // Conditionally add Edit and Delete buttons if the logged-in user owns the product
            if (product.UserId == loggedInUserId)
            {
                Button btnEdit = new Button
                {
                    Text = "Edit",
                    Location = new Point(10, 130),
                    Size = new Size(75, 30),
                    BackColor = Color.YellowGreen,
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Arial", 10, FontStyle.Bold)
                };

                Button btnDelete = new Button
                {
                    Text = "Delete",
                    Location = new Point(95, 130),
                    Size = new Size(75, 30),
                    BackColor = Color.Crimson,
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Arial", 10, FontStyle.Bold)
                };

                panel.Controls.Add(btnEdit);
                panel.Controls.Add(btnDelete);

                // You can add event handlers for Edit and Delete buttons here (e.g., for updating or deleting the product)
            }

            return panel;
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
    }
}
