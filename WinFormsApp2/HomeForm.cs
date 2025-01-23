using Microsoft.EntityFrameworkCore;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using WinFormsApp2.Models;
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

            label1.Text = $"Welcome, {loggedInUserName}!";
            label1.Font = new Font("Arial", 16, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point((ClientSize.Width - label1.Width) / 2, 30);

            LoadProducts(loggedInUserId);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int loggedInUserId = UserSession.UserId;
            LoadProducts(loggedInUserId);
        }

        private void LoadProducts(int loggedInUserId, string searchQuery = null)
        {
            flowLayoutPanel1.Controls.Clear();

            try
            {
                using (var context = new AppDbContext())
                {
                    var productsQuery = context.Products
                        .Where(p => p.DeletedAt == null);

                    if (!string.IsNullOrEmpty(searchQuery))
                    {
                        productsQuery = productsQuery.Where(p => p.Name.Contains(searchQuery));
                    }

                    var products = productsQuery
                        .OrderByDescending(p => p.CreatedAt)
                        .ToList();

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
            Panel panel = new Panel
            {
                Size = new Size((flowLayoutPanel1.ClientSize.Width / 2) - 45, 500),
                Margin = new Padding(20, 10, 20, 10),
                Padding = new Padding(20),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };

            PictureBox pictureBox = new PictureBox
            {
                Size = new Size(panel.Width - 40, 200),
                Location = new Point(20, 20),
                SizeMode = PictureBoxSizeMode.StretchImage,
                BorderStyle = BorderStyle.None
            };

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

            Label lblName = new Label
            {
                Text = product.Name,
                Font = new Font("Arial", 14, FontStyle.Bold),
                Location = new Point(20, pictureBox.Bottom + 10),
                AutoSize = true,
                ForeColor = Color.Black
            };

            Label lblPrice = new Label
            {
                Text = $"${product.Price:F2}/Day",
                Font = new Font("Arial", 14, FontStyle.Bold),
                Location = new Point(20, lblName.Bottom + 5),
                AutoSize = true,
                ForeColor = Color.FromArgb(0, 120, 215)
            };

            Label lblLocation = new Label
            {
                Text = !string.IsNullOrEmpty(product.ProductAddress) ? product.ProductAddress : "--", // Show "--" if location is null
                Font = new Font("Arial", 10, FontStyle.Regular),
                Location = new Point(20, lblPrice.Bottom + 5),
                AutoSize = true,
                ForeColor = Color.Gray
            };

            Label lblRating = new Label
            {
                Text = "★ 5.0 (120 reviews)",
                Font = new Font("Arial", 10, FontStyle.Bold),
                Location = new Point(20, lblLocation.Bottom + 5),
                AutoSize = true,
                ForeColor = Color.OrangeRed
            };

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

            if (product.UserId == loggedInUserId)
            {
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
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string searchQuery = txtSearch.Text.Trim();
            LoadProducts(UserSession.UserId, searchQuery);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RecycleForm recycleForm = new RecycleForm();
            recycleForm.Show();
        }
    }
}