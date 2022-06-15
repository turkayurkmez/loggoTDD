using Catalog.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Business
{
    public interface ISpeakerService
    {
        IEnumerable<Speaker> Search(string speakerName);
    }
}
