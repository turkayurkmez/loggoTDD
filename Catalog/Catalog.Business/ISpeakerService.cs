using Catalog.Entity;

namespace Catalog.Business
{
    public interface ISpeakerService
    {
        IEnumerable<Speaker> Search(string speakerName);
        IEnumerable<Speaker> GetAll();

        void Add(Speaker speaker);
    }
}
