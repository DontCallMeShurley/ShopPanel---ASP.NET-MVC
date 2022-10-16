using System;
using System.Collections.Generic;
using System.Web;
using System.Data.Entity;
using ShopPanel___ASPNetMVC.Data;

namespace ShopPanel___ASP.NET_MVC.Data
{
    public class ShopContext : DbContext
    {
        public DbSet<Buyer> Buyer { get; set; }
        public DbSet<Products> Products { get; set; }
    }
}