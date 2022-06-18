using Catalog.Business;
using Catalog.Entity;
using System.Collections.Generic;
using System.Linq;

namespace Catalog.Tests
{
    public class FakeSpeakerService : ISpeakerService
    {
        private List<Speaker> speakers;
        public FakeSpeakerService()
        {
            speakers = new List<Speaker>
            {
                new Speaker
                {
                    Id = 1,
                    Name = "Mustafa",
                    Blog = "http://www.turkayurkmez.com",
                },
                new Speaker
                {
                    Id = 1,
                    Name = "Mustafa",
                    Blog = "http://www.turkayurkmez.com",
                },
                new Speaker
                {
                    Id = 1,
                    Name = "Mustafa",
                    Blog = "http://www.turkayurkmez.com",
                }
            };
        }
        public IEnumerable<Speaker> Search(string speakerName)
        {
            return speakers.Where(x => x.Name.Contains(speakerName));
        }
    }
}
