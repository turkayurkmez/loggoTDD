using Catalog.Business;
using Catalog.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Tests
{
    public class TestSpeakerService : ISpeakerService
    {
        public IEnumerable<Speaker> Search(string speakerName)
        {
            throw new NotImplementedException();
        }
    }
}
