using System.Data.Entity;
using ShopPanel___ASPNetMVC.Data;
using ShopPanel___ASP.NET_MVC.Interfaces;
using ShopPanel___ASP.NET_MVC.Data;

namespace ZOLLA.TestTask.Models
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
        }

        public void Delete(int id)
        {
            var client = context.Products.Find(id);

            if (client != null)
            {
                context.Products.Remove(client);
            }
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
        }
    }
}