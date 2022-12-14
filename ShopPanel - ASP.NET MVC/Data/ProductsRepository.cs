using ShopPanel___ASPNetMVC.Data;
using ShopPanel___ASP.NET_MVC.Interfaces;
using ShopPanel___ASP.NET_MVC.Data;
using Microsoft.EntityFrameworkCore;

namespace ShopPanel___ASPNetMVC.Data
{
    internal class ProductsRepository : IRepository<Products>
    {
        private readonly ShopContext context;



        public ProductsRepository(ShopContext context)
        {
            this.context = context;
        }



        public void Create(Products item)
        {
            if (item == null)
            {
                return;
            }

            context.Products.Add(item);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var client = context.Products.Find(id);

            if (client != null)
            {
                context.Products.Remove(client);
            }
            context.SaveChanges();
        }

        public IEnumerable<Products> Get()
        {
            return context.Products;
        }

        public Products Get(int id)
        {
            return context.Products.Find(id);
        }

        public void Update(Products item)
        {
            context.Entry(item).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}