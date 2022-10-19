using ShopPanel___ASPNetMVC.Data;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace ShopPanel___ASP.NET_MVC.Data
{
    public class ShopContext : DbContext
    {
        public DbSet<Buyer> Buyer { get; set; }
        public DbSet<Products> Products { get; set; }
        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    var connection = Configuration.("DefaultConnection");
        //    optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=ShopPanel;Trusted_Connection=True;");
        //}
    }

}