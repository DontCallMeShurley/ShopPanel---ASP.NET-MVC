using System.ComponentModel.DataAnnotations;

namespace ShopPanel___ASPNetMVC.Data
{
    public class Buyer
    {
        public int Id { get; set; }
        [Display(Name = "Имя")]
        public string? firstName { get; set; }
        [Display(Name = "Фамилия")]
        public string? secondName { get; set; }

        public List<Products> products { get; set; }

    }
}
