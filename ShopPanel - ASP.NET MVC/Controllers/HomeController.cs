using Microsoft.AspNetCore.Mvc;
using ShopPanel___ASP.NET_MVC.Data;
using ShopPanel___ASPNetMVC.Data;

namespace ShopPanel___ASP.NET_MVC.Controllers
{
    public class HomeController : Controller
    {

        private readonly ShopContext _db;
        private readonly BuyerRepository _buyerRepository;
        private readonly ProductsRepository _productsRepository;
        private int pageSize = 3;
        public HomeController(ShopContext db)
        {
            _db = db;
            _buyerRepository = new BuyerRepository(_db);
            _productsRepository = new ProductsRepository(_db);
        }

        [HttpGet]
        public IActionResult Index(int pageNumber = 1)
        {
            
            IEnumerable<Buyer> buyerList = _buyerRepository.Get();

            var countItems = buyerList.Count();

            ViewBag.countItems = countItems;
            ViewBag.pageNumber = pageNumber;
            ViewBag.pageSize = pageSize;
            ViewBag.countPages = countItems % pageSize == 0 ? countItems / pageSize : countItems / pageSize + 1;

            buyerList = buyerList.Skip((pageNumber - 1) * pageSize).Take(pageSize);

            return View(buyerList);
        }

        [HttpGet]
        public IActionResult Edit(int id, int pageNumber = 1)
        {
            var buyer = _buyerRepository.Get(id);

            ViewBag.pageNumber = pageNumber;
            ViewBag.products = _productsRepository.Get().Where(a => a.BuyerId == id).ToList();

            return View(buyer);
        }

        [HttpGet]
        public IActionResult EditP(int id, int pageNumber = 1)
        {
            var product = _productsRepository.Get(id);

            ViewBag.pageNumber = pageNumber;

            return View(product);
        }
        [HttpGet]
        public IActionResult CreateP(int buyerId,int pageNumber = 1)
        {
            var product = new Products();

            product.BuyerId = buyerId; 
            ViewBag.pageNumber = pageNumber;

            return View("EditOrCreateP", product);
        }
        [HttpGet]
        public IActionResult Create(int pageNumber = 1)
        {
            var buyer = new Buyer();

            ViewBag.pageNumber = pageNumber;

            return View("Edit",buyer);
        }

        [HttpPost]
        public IActionResult EditOrCreate(Buyer buyer)
        {
            var _buyer = _buyerRepository.Get(buyer.Id);

            if (_buyer != null) 
                _buyerRepository.Update(buyer);
            else
                _buyerRepository.Create(buyer);

            return Ok();
        }

        [HttpPost]
        public IActionResult EditOrCreateP(Products products, int buyerId)
        {
            products.BuyerId = buyerId; 
            var _products = _productsRepository.Get(products.Id);

            if (_products != null)
                _productsRepository.Update(products);
            else
            {
                products.Id = 0;
                _productsRepository.Create(products);
            }

            return Ok();
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            _buyerRepository.Delete(id);

            return Ok();
        }
    }
}