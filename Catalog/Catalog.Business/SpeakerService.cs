using Catalog.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Business
{
    public class SpeakerService : ISpeakerService
    {

        private List<Speaker> speakers;
        public SpeakerService()
        {
            speakers = new List<Speaker>()
            {
                new Speaker
                {
                    Id = 1,
                    Name = "Mustafa",
                    Blog = "http://www.turkayurkmez.com",

                },

                new Speaker
                {
                    Id = 2,
                    Name = "Murtaza",
                    Blog = "http://www.turkayurkmez.com",

                },
                new Speaker
                {
                    Id = 3,
                    Name = "Türkay",
                    Blog = "http://www.turkayurkmez.com",

                },
            };
        }
        public IEnumerable<Speaker> Search(string speakerName)
        {

            return speakers.Where(x => x.Name.ToLower().Contains(speakerName.ToLower()));
        }
    }
}
