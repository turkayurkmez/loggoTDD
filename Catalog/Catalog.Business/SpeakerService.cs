using Catalog.Data;
using Catalog.Entity;

namespace Catalog.Business
{
    public class SpeakerService : ISpeakerService
    {

        private List<Speaker> speakers;
        private readonly ISpeakerRepository speakerRepository;

        public SpeakerService(ISpeakerRepository speakerRepository)
        {
            this.speakerRepository = speakerRepository;
        }

        
        public IEnumerable<Speaker> Search(string speakerName)
        {

            return speakerRepository.SearchSpeakers(speakerName);
        }

        public IEnumerable<Speaker> GetAll()
        {
            return speakerRepository.GetAll();
        }
    }
}
