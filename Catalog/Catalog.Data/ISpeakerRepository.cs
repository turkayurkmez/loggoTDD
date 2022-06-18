using Catalog.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Data
{
    public interface ISpeakerRepository : IRepository<Speaker>
    {
        IQueryable<Speaker> SearchSpeakers(string name);
    }
    
}
