using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class EditProduct : Form
    {
        private readonly int _productId; 
        private readonly AppDbContext _dbContext;

        public EditProduct(int productId)
        {
            InitializeComponent();
            _productId = productId;
            _dbContext = new AppDbContext(); 
            LoadProductData(); 
        }

        private void LoadProductData()
        {
            try
            {

                var product = _dbContext.Products.FirstOrDefault(p => p.Id == _productId);

                if (product == null)
                {
                    MessageBox.Show("Product not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                txtProductName.Text = product.Name;
                txtProductPrice.Text = product.Price.ToString("F2");
                txtProductDescription.Text = product.Description;
                txtImageUrl.Text = product.Image;

                txtOwnerPhone.Text = product.OwnerPhone;
                txtOwnerAddress.Text = product.ProductAddress;

                var categories = _dbContext.Categories.ToList();
                cmbCategory.DataSource = categories;
                cmbCategory.DisplayMember = "Name";
                cmbCategory.ValueMember = "Id";

                cmbCategory.SelectedValue = product.CategoryId;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading the product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                var product = _dbContext.Products.FirstOrDefault(p => p.Id == _productId);

                if (product == null)
                {
                    MessageBox.Show("Product not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                product.Name = txtProductName.Text;
                product.Price = decimal.Parse(txtProductPrice.Text);
                product.Description = txtProductDescription.Text;
                product.Image = txtImageUrl.Text;
                product.CategoryId = (int)cmbCategory.SelectedValue;

                product.OwnerPhone = txtOwnerPhone.Text;
                product.ProductAddress = txtOwnerAddress.Text;

                _dbContext.SaveChanges();

                MessageBox.Show("Product updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving the product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void lblProductDescription_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
