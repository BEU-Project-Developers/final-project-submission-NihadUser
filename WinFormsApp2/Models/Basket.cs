    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace WinFormsApp2.Models
    {

        public class Basket
        {
            public int Id { get; set; } 
            public int UserId { get; set; }
            public int ProductId { get; set; }
            public DateTime CreatedAt { get; set; } = DateTime.Now;
            public bool IsCheckedOut { get; set; } = false;
            public DateTime? UpdatedAt { get; set; }
            public DateTime? DeletedAt { get; set; }
            public virtual Product Product { get; set; }

        }
    }
