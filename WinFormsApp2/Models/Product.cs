using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2.Models
{

    public class Product
    {
        public int Id { get; set; } // Primary Key
        public string Name { get; set; } // Product Name
        public decimal Price { get; set; } // Product Price
        public string Description { get; set; } // Product Description
        public DateTime CreatedAt { get; set; } = DateTime.Now; // Created Timestamp
        public DateTime? UpdatedAt { get; set; } // Updated Timestamp (nullable)
        public DateTime? DeletedAt { get; set; } // Soft Delete Timestamp (nullable)
        public int UserId { get; set; } // Foreign Key to Users table (admin/user who added the product)
        public int CategoryId { get; set; } // Foreign Key to Categories table (admin/user who added the product)   
        public string Image { get; set; }  // This will store the image URL or path
        public int Status { get; set; } = 1; // Product Status (default to 1)
        public string OwnerPhone { get; set; } // Phone number of the product owner
        public string ProductAddress { get; set; }
    }
}
