using System.ComponentModel.DataAnnotations;

namespace ShopPanel___ASPNetMVC.Data
{
    public class Buyer
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string secondName { get; set; }

        public List<Products> products { get; set; }

    }
}
