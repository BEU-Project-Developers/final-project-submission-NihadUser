using System;
using System.Collections.Generic;

namespace WinFormsApp2.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public decimal TotalAmount { get; set; }
        public int Status { get; set; } = 1;
        public virtual List<Basket> Baskets { get; set; }
        public string PaymentMethod { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string Phone { get; set; }
    }
}
