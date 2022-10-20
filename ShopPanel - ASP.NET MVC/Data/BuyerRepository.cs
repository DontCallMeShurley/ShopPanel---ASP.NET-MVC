using System.Collections.Generic;
//using System.Data.Entity;
using System;
using ShopPanel___ASPNetMVC.Data;
using ShopPanel___ASP.NET_MVC.Interfaces;
using ShopPanel___ASP.NET_MVC.Data;
using Microsoft.EntityFrameworkCore;

namespace ShopPanel___ASPNetMVC.Data
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
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var client = context.Buyer.Find(id);

            if (client != null)
            {
                context.Buyer.Remove(client);
            }
            context.SaveChanges();
        }

        public IEnumerable<Buyer> Get()
        {
            return context.Buyer.AsNoTracking();
        }

        public Buyer Get(int id)
        {
            var _item = context.Buyer.Find(id);
            if (_item != null)
                context.Entry(_item).State = EntityState.Detached;

            return _item;
        }

        public void Update(Buyer item)
        {
            context.Entry(item).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}