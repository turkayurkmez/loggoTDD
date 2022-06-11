using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Data
{
    public interface IRepository<T> where T : class, IEntity
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        void Add(T item);
        void Update(T item);
        void Delete(int id);
    }

    public interface IEntity
    {
        int Id { get; set; }
    }

    public class FakeRepository : IRepository<Product>
    {
        private List<Product> products = new List<Product>();

        public void Add(Product item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Product item)
        {
            throw new NotImplementedException();
        }
    }

    public class Product : IEntity
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
