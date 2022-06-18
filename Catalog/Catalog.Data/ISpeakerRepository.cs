using Catalog.Entity;

namespace Catalog.Data
{
    public interface ISpeakerRepository : IRepository<Speaker>
    {
        IQueryable<Speaker> SearchSpeakers(string name);
    }

}
