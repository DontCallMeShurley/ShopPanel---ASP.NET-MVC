namespace ShopPanel___ASP.NET_MVC.Interfaces
{
    public interface IRepository<T> where T : class
    {
        void Create(T item);

        void Delete(int id);

        IEnumerable<T> Get();

        T Get(int id);

        void Update(T item);
    }
}
