using System;
using System.Linq;
using System.Windows.Forms;
using WinFormsApp2.Models;

namespace WinFormsApp2
{
    public partial class OrderForm : Form
    {
        private readonly AppDbContext _dbContext;
        private readonly decimal _totalAmount;

        public OrderForm(AppDbContext dbContext, decimal totalAmount)
        {
            InitializeComponent();
            _dbContext = dbContext;
            _totalAmount = totalAmount;

            this.Load += OrderForm_Load;
            //btnConfirm.Click += BtnConfirm_Click;

            SetupPaymentGroupBox();
            SetupBillingGroupBox();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            var centerX = this.ClientSize.Width / 2;
            var spacing = 20;

            paymentGroupBox.Location = new Point(centerX - paymentGroupBox.Width - spacing / 2, 100);
            billingGroupBox.Location = new Point(centerX + spacing / 2, 100);

            btnConfirm.Text = $"Confirm Pay - ${_totalAmount}";
            btnConfirm.Location = new Point(this.ClientSize.Width / 2 - btnConfirm.Width / 2, 400);
        }

        //private void BtnConfirm_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        // Retrieve the UserId from UserSession
        //        int userId = UserSession.UserId;

        //        if (userId <= 0)
        //        {
        //            MessageBox.Show("User session is invalid. Please log in again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return;
        //        }

        //        // Retrieve form values
        //        var paymentMethod = paymentGroupBox.Controls.OfType<ComboBox>().FirstOrDefault()?.SelectedItem?.ToString();
        //        var street = billingGroupBox.Controls.OfType<TextBox>().FirstOrDefault(c => c.Name == "txtStreet")?.Text;
        //        var city = billingGroupBox.Controls.OfType<TextBox>().FirstOrDefault(c => c.Name == "txtCity")?.Text;
        //        var state = billingGroupBox.Controls.OfType<TextBox>().FirstOrDefault(c => c.Name == "txtState")?.Text;
        //        var country = billingGroupBox.Controls.OfType<ComboBox>().FirstOrDefault()?.SelectedItem?.ToString();

        //        if (string.IsNullOrWhiteSpace(paymentMethod) || string.IsNullOrWhiteSpace(street) || string.IsNullOrWhiteSpace(city))
        //        {
        //            MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return;
        //        }

        //        // Create a new Order object
        //        var order = new Order
        //        {
        //            UserId = userId,
        //            TotalAmount = _totalAmount,
        //            PaymentMethod = paymentMethod,
        //            Street = street,
        //            City = city,
        //            State = state,
        //            Country = country
        //        };

        //        // Add the order to the database
        //        _dbContext.Orders.Add(order);

        //        // Retrieve baskets for the user and update their status
        //        var baskets = _dbContext.Baskets.Where(b => b.UserId == userId && b.Status == 1).ToList();
        //        foreach (var basket in baskets)
        //        {
        //            basket.Status = 2; // Update status to 2
        //            order.Baskets.Add(basket); // Link the basket to the order
        //        }

        //        // Save changes to the database
        //        _dbContext.SaveChanges();

        //        MessageBox.Show("Order placed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        this.Close(); // Close the form after success
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"An error occurred while placing the order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void SetupPaymentGroupBox()
        {
            var lblPaymentMethod = new Label
            {
                Text = "Select method",
                Location = new Point(20, 40),
                Font = new Font("Arial", 10)
            };
            var cmbPaymentMethod = new ComboBox
            {
                Location = new Point(150, 35),
                Width = 200,
                Font = new Font("Arial", 10),
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cmbPaymentMethod.Items.AddRange(new string[] { "Credit or Debit Card", "PayPal", "Google Pay", "Apple Pay" });

            var lblCardNumber = new Label
            {
                Text = "Card number",
                Location = new Point(20, 80),
                Font = new Font("Arial", 10)
            };
            var txtCardNumber = new TextBox
            {
                Location = new Point(150, 75),
                Width = 200,
                Font = new Font("Arial", 10)
            };

            var lblExpiration = new Label
            {
                Text = "Expiration (MM/YY)",
                Location = new Point(20, 120),
                Font = new Font("Arial", 10)
            };
            var txtExpiration = new TextBox
            {
                Location = new Point(150, 115),
                Width = 90,
                Font = new Font("Arial", 10)
            };

            var lblCVV = new Label
            {
                Text = "CVV",
                Location = new Point(250, 120),
                Font = new Font("Arial", 10)
            };
            var txtCVV = new TextBox
            {
                Location = new Point(300, 115),
                Width = 50,
                Font = new Font("Arial", 10),
                PasswordChar = '*'
            };

            paymentGroupBox.Controls.Add(lblPaymentMethod);
            paymentGroupBox.Controls.Add(cmbPaymentMethod);
            paymentGroupBox.Controls.Add(lblCardNumber);
            paymentGroupBox.Controls.Add(txtCardNumber);
            paymentGroupBox.Controls.Add(lblExpiration);
            paymentGroupBox.Controls.Add(txtExpiration);
            paymentGroupBox.Controls.Add(lblCVV);
            paymentGroupBox.Controls.Add(txtCVV);
        }

        private void SetupBillingGroupBox()
        {
            var lblStreet = new Label
            {
                Text = "Street",
                Location = new Point(20, 40),
                Font = new Font("Arial", 10)
            };
            var txtStreet = new TextBox
            {
                Location = new Point(150, 35),
                Width = 200,
                Font = new Font("Arial", 10)
            };

            var lblCity = new Label
            {
                Text = "City",
                Location = new Point(20, 80),
                Font = new Font("Arial", 10)
            };
            var txtCity = new TextBox
            {
                Location = new Point(150, 75),
                Width = 200,
                Font = new Font("Arial", 10)
            };

            var lblState = new Label
            {
                Text = "State",
                Location = new Point(20, 120),
                Font = new Font("Arial", 10)
            };
            var txtState = new TextBox
            {
                Location = new Point(150, 115),
                Width = 200,
                Font = new Font("Arial", 10)
            };

            var lblZipCode = new Label
            {
                Text = "ZIP Code",
                Location = new Point(20, 160),
                Font = new Font("Arial", 10)
            };
            var txtZipCode = new TextBox
            {
                Location = new Point(150, 155),
                Width = 200,
                Font = new Font("Arial", 10)
            };

            var lblCountry = new Label
            {
                Text = "Country/Region",
                Location = new Point(20, 200),
                Font = new Font("Arial", 10)
            };
            var cmbCountry = new ComboBox
            {
                Location = new Point(150, 195),
                Width = 200,
                Font = new Font("Arial", 10),
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cmbCountry.Items.AddRange(new string[] { "Baku, Azerbaijan", "Sumgait, Azerbaijan", "Siazan, Azerbaijan", "Other" });

            billingGroupBox.Controls.Add(lblStreet);
            billingGroupBox.Controls.Add(txtStreet);
            billingGroupBox.Controls.Add(lblCity);
            billingGroupBox.Controls.Add(txtCity);
            billingGroupBox.Controls.Add(lblState);
            billingGroupBox.Controls.Add(txtState);
            billingGroupBox.Controls.Add(lblZipCode);
            billingGroupBox.Controls.Add(txtZipCode);
            billingGroupBox.Controls.Add(lblCountry);
            billingGroupBox.Controls.Add(cmbCountry);
        }
    }
}
