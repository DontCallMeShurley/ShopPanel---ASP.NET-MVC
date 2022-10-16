using Microsoft.AspNetCore.Mvc;
using ShopPanel___ASP.NET_MVC.Data;
using ShopPanel___ASPNetMVC.Data;
using System.Diagnostics;
using ZOLLA.TestTask.Models;

namespace ShopPanel___ASP.NET_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        ShopContext shopContext = new ShopContext();
        
        public IActionResult Index()
        {
            var _buyerRepository = new BuyerRepository(shopContext);
            _buyerRepository.Create(new Buyer { firstName = "test", Id = 1, secondName = "" });
            IEnumerable<Buyer> buyerList = _buyerRepository.Get();
            ViewBag.BuyerList = buyerList;
            return View();
        }
    }
}