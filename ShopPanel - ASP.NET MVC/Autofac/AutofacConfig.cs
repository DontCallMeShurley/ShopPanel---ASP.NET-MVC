using Autofac;
using Autofac.Integration.Mvc;
using Microsoft.Extensions.Options;
using ShopPanel___ASP.NET_MVC.Data;
using ShopPanel___ASP.NET_MVC.Interfaces;
using ShopPanel___ASPNetMVC.Data;
using System.Web.Mvc;

namespace ShopPanel___ASP.NET_MVC.Autofac
{
    public class AutofacConfig
    {
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(Program).Assembly);

            //builder.RegisterType<BuyerRepository>().As<IRepository<Buyer>>().WithParameter("context", new ShopContext());
            //builder.RegisterType<ProductsRepository>().As<IRepository<Products>>().WithParameter("context", new ShopContext());

            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

        }
    }
}
