// See https://aka.ms/new-console-template for more information




public interface IRepository<T> where T : class
{
    void Add(T entity);
    void Update(T entity);
    void Delete(T entity);
    T GetById(int id);
    IQueryable<T> GetAll();
}

public interface IProductRepository: IRepository<Product>
{
    IList<Product> GetByCategory(int categoryId);
    IList<Product> SearchByName(string name);


}

public class EFProductRepository : IProductRepository
{
    public void Add(Product entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(Product entity)
    {
        throw new NotImplementedException();
    }

    public IQueryable<Product> GetAll()
    {
        throw new NotImplementedException();
    }

    public IList<Product> GetByCategory(int categoryId)
    {
        throw new NotImplementedException();
    }

    public Product GetById(int id)
    {
        throw new NotImplementedException();
    }

    public IList<Product> SearchByName(string name)
    {
        throw new NotImplementedException();
    }

    public void Update(Product entity)
    {
        throw new NotImplementedException();
    }
}



