using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2.Models
{

    public class Product
    {
        public int Id { get; set; } 
        public string Name { get; set; } 
        public decimal Price { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now; 
        public DateTime? UpdatedAt { get; set; } 
        public DateTime? DeletedAt { get; set; }
        public int UserId { get; set; }
        public int CategoryId { get; set; }
        public string Image { get; set; }
        public int Status { get; set; } = 1;
        public string OwnerPhone { get; set; }
        public string ProductAddress { get; set; }
    }
}
