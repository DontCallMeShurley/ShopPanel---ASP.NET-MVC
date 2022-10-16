namespace ShopPanel___ASPNetMVC.Data
{
    public class Products
    {
        int ID { get; set; }
        string Name { get; set; }
        double Price { get; set; }

        int dateCreated { get; set; }
        
        Buyer Buyer { get; set; }   
    }
}
