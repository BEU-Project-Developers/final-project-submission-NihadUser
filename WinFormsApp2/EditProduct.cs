using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class EditProduct : Form
    {
        private readonly int _productId; // Store the product ID
        private readonly AppDbContext _dbContext; // Your database context (replace `DbContext` with your actual context class)

        public EditProduct(int productId)
        {
            InitializeComponent();
            _productId = productId;
            _dbContext = new AppDbContext(); // Initialize your database context (replace with your actual context initialization)
            LoadProductData(); // Load product data when the form initializes
        }

        private void LoadProductData()
        {
            try
            {
                // Fetch the product from the database using the product ID
                var product = _dbContext.Products.FirstOrDefault(p => p.Id == _productId);

                if (product == null)
                {
                    MessageBox.Show("Product not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                // Populate form fields with product data
                txtProductName.Text = product.Name;
                txtProductPrice.Text = product.Price.ToString("F2");
                txtProductDescription.Text = product.Description;
                txtImageUrl.Text = product.Image;

                // Load the categories into the combo box (assuming `Categories` is a table or list)
                var categories = _dbContext.Categories.ToList();
                cmbCategory.DataSource = categories;
                cmbCategory.DisplayMember = "Name"; // Adjust based on your Category model
                cmbCategory.ValueMember = "Id";

                // Select the product's category
                cmbCategory.SelectedValue = product.CategoryId;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading the product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the form without saving
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Fetch the product to update
                var product = _dbContext.Products.FirstOrDefault(p => p.Id == _productId);

                if (product == null)
                {
                    MessageBox.Show("Product not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Update product properties with new values
                product.Name = txtProductName.Text;
                product.Price = decimal.Parse(txtProductPrice.Text);
                product.Description = txtProductDescription.Text;
                product.Image = txtImageUrl.Text;
                product.CategoryId = (int)cmbCategory.SelectedValue;

                // Save changes to the database
                _dbContext.SaveChanges();

                MessageBox.Show("Product updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Close the form after saving
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving the product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblProductDescription_Click(object sender, EventArgs e)
        {

        }
    }
}
