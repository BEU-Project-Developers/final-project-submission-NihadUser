using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2.Models
{
    public class User
    {
        public int Id { get; set; }        // Primary Key
        public string Name { get; set; }  // Full Name
        public string UserName { get; set; } // Username for login
        public string Password { get; set; } // Password for login
        public DateTime CreatedAt { get; set; } = DateTime.Now; // Default value
    }
}
