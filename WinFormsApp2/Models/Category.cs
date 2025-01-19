using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2.Models
{
    public class Category
    {
        public int Id { get; set; } // Primary Key
        public string Name { get; set; } // Category Name
        public DateTime CreatedAt { get; set; } = DateTime.Now; // Created Timestamp
        public DateTime? DeletedAt { get; set; } // Soft Delete Timestamp (nullable)
        public int Status { get; set; } = 1; // Category Status (default to 1)
    }
}
