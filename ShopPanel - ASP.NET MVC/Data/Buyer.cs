namespace ShopPanel___ASPNetMVC.Data
{
    public class Buyer
    {
        int ID { get; set; }
        string firstName { get; set; }
        string secondName { get; set; }

        List<Products> products { get; set; }

    }
}
