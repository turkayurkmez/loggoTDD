using Catalog.Entity;

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



    public class FakeRepository : ISpeakerRepository
    {
        private List<Speaker> speakers;
        public FakeRepository()
        {
           speakers = new List<Speaker>
            {
                new Speaker {Id = 1, Name = "John"},
                new Speaker {Id = 2, Name = "Jane"}
            };
        }
        public void Add(Speaker item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Speaker Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Speaker> GetAll()
        {
            return speakers;
        }

        public IQueryable<Speaker> SearchSpeakers(string name)
        {
            return speakers.Where(x => x.Name.Contains(name)).AsQueryable();
        }

        public void Update(Speaker item)
        {
            throw new NotImplementedException();
        }
    }

    public class Product : IEntity
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
