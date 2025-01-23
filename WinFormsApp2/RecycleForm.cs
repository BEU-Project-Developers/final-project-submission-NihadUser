using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WinFormsApp2.Models;

namespace WinFormsApp2
{
    public partial class RecycleForm : Form
    {
        public RecycleForm()
        {
            InitializeComponent();
        }

        private void RecycleForm_Load(object sender, EventArgs e)
        {
            int loggedInUserId = UserSession.UserId;
            LoadDeletedProducts(loggedInUserId);
        }

        private void LoadDeletedProducts(int userId)
        {
            flowLayoutPanel1.Controls.Clear();

            try
            {
                using (var context = new AppDbContext())
                {
                    var deletedProducts = context.Products
                        .Where(p => p.DeletedAt != null && p.UserId == userId)
                        .OrderByDescending(p => p.DeletedAt)
                        .ToList();

                    foreach (var product in deletedProducts)
                    {
                        var productCard = CreateProductCard(product);
                        flowLayoutPanel1.Controls.Add(productCard);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading deleted products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Panel CreateProductCard(Product product)
        {
            Panel panel = new Panel
            {
                Size = new Size((flowLayoutPanel1.ClientSize.Width / 2) - 30, 250),
                Margin = new Padding(15),
                Padding = new Padding(10),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };

            PictureBox pictureBox = new PictureBox
            {
                Size = new Size(panel.Width - 20, 150),
                Location = new Point(10, 10),
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
                Font = new Font("Arial", 12, FontStyle.Bold),
                Location = new Point(10, pictureBox.Bottom + 10),
                AutoSize = true,
                ForeColor = Color.Black
            };

            Button btnRestore = new Button
            {
                Text = "Restore",
                Size = new Size(panel.Width - 20, 40),
                Location = new Point(10, lblName.Bottom + 10),
                BackColor = Color.Green,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Arial", 10, FontStyle.Bold)
            };

            btnRestore.FlatAppearance.BorderSize = 0;
            btnRestore.Click += (sender, e) => RestoreProduct(product, panel);

            panel.Controls.Add(pictureBox);
            panel.Controls.Add(lblName);
            panel.Controls.Add(btnRestore);

            return panel;
        }

        private void RestoreProduct(Product product, Panel panel)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    product.DeletedAt = null;
                    context.Products.Update(product);
                    context.SaveChanges();
                }

                MessageBox.Show("Product successfully restored!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                panel.Visible = false; // Hide the product card after restoration
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error restoring product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
