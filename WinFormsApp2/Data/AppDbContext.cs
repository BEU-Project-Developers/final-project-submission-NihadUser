using Microsoft.EntityFrameworkCore;
using WinFormsApp2.Models;
public class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Basket> Baskets { get; set; }
    public DbSet<Order> Orders { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Replace with your database connection string
        optionsBuilder.UseSqlServer("Data Source=DESKTOP-10DFVI1;Initial Catalog=ecommerce;Integrated Security=True;Trust Server Certificate=True");
    }
}

