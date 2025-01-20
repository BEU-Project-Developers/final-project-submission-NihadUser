using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;
using WinFormsApp2.Models;

namespace WinFormsApp2
{
    public partial class CreateProduct : Form
    {
        // Assuming you have a database context class named 'AppDbContext'
        private readonly AppDbContext _dbContext;

        public CreateProduct()
        {
            InitializeComponent();
            _dbContext = new AppDbContext();
            this.Load += CreateProduct_Load; // Attach the Load event here
            _dbContext = new AppDbContext();
        }

        private void CreateProduct_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void LoadCategories()
        {
            try
            {
                // Fetch categories from the Categories table
                var categories = _dbContext.Categories.ToList();
                cmbCategory.DisplayMember = "Name"; // Adjust property name if different
                cmbCategory.ValueMember = "Id";
                cmbCategory.DataSource = categories;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading categories: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtProductName.Text) ||
                    string.IsNullOrWhiteSpace(txtProductPrice.Text) ||
                    cmbCategory.SelectedValue == null)
                {
                    MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Create a new product object
                var newProduct = new Product
                {
                    Name = txtProductName.Text.Trim(),
                    Price = decimal.Parse(txtProductPrice.Text.Trim()),
                    Description = txtProductDescription.Text.Trim(),
                    Image = txtProductImageUrl.Text.Trim(),
                    CategoryId = (int)cmbCategory.SelectedValue,
                    UserId = (int)UserSession.UserId, // Assume Session.UserId exists
                    CreatedAt = DateTime.Now,
                    Status = 1
                };

                // Save the product to the database
                _dbContext.Products.Add(newProduct);
                _dbContext.SaveChanges();

                MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
