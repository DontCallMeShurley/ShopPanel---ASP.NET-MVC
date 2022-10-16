using System.Collections.Generic;
using System.Data.Entity;
using System;
using ShopPanel___ASPNetMVC.Data;
using ShopPanel___ASP.NET_MVC.Interfaces;
using ShopPanel___ASP.NET_MVC.Data;

namespace ZOLLA.TestTask.Models
{
    internal class BuyerRepository : IRepository<Buyer>
    {
        private readonly ShopContext context;



        public BuyerRepository(ShopContext context)
        {
            this.context = context;
        }



        public void Create(Buyer item)
        {
            if (item == null)
            {
                return;
            }

            context.Buyer.Add(item);
        }

        public void Delete(int id)
        {
            var client = context.Buyer.Find(id);

            if (client != null)
            {
                context.Buyer.Remove(client);
            }
        }

        public IEnumerable<Buyer> Get()
        {
            return context.Buyer;
        }

        public Buyer Get(int id)
        {
            return context.Buyer.Find(id);
        }

        public void Update(Buyer item)
        {
            context.Entry(item).State = EntityState.Modified;
        }
    }
}