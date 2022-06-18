using Catalog.Data.Data;
using Catalog.Entity;

namespace Catalog.Data
{
    public class EFSpeakerRepository : ISpeakerRepository
    {
        private readonly SpeakersDbContext _context;

        public EFSpeakerRepository(SpeakersDbContext context)
        {
            _context = context;
        }

        public void Add(Speaker item)
        {
            _context.Add(item);
            _context.SaveChanges();
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
            return _context.Speakers;

        }

        public IQueryable<Speaker> SearchSpeakers(string name)
        {
            return _context.Speakers.Where(s => s.Name.Contains(name));

        }

        public void Update(Speaker item)
        {
            throw new NotImplementedException();
        }
    }
}
