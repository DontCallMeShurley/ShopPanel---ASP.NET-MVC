using Microsoft.AspNetCore.Mvc;
using ShopPanel___ASP.NET_MVC.Data;
using ShopPanel___ASPNetMVC.Data;
using System.Diagnostics;

namespace ShopPanel___ASP.NET_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        ShopContext shopContext = new ShopContext();
        public IActionResult Index()
        {
            IEnumerable<Buyer> buyerList = shopContext.Buyer;
            ViewBag.BuyerList = buyerList;
            return View();
        }
    }
}