using System.ComponentModel.DataAnnotations;

namespace ShopPanel___ASPNetMVC.Data
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public int dateCreated { get; set; }

        public int BuyerId { get; set; }   
    }
}
