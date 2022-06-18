using Catalog.Business;
using Catalog.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
