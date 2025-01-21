using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2.Models
{

    public class Basket
    {
        public int Id { get; set; } // Primary Key
        public int UserId { get; set; } // Foreign Key to Users table (admin/user who added the product)
        public int ProductId { get; set; } // Foreign Key to Categories table (admin/user who added the product)   
        public DateTime CreatedAt { get; set; } = DateTime.Now; // Created Timestamp
        public bool IsCheckedOut { get; set; } = false; // Indicates if the basket has been checked out
        public DateTime? UpdatedAt { get; set; } // Updated Timestamp (nullable)
        public DateTime? DeletedAt { get; set; } // Soft Delete Timestamp (nullable)
    }
}
