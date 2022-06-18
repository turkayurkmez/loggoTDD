using Catalog.Data;
using Catalog.Entity;

using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Catalog.Tests
{
    public class FakeDependency : IRepository<Speaker>
    {
        public void Add(Speaker item)
        {
            Debug.WriteLine("Added");
        }

        public void Delete(int id)
        {
            Debug.WriteLine("Deleted");

        }

        public Speaker Get(int id)
        {

            return new Speaker() { Name = "Türkay" };

        }

        public IEnumerable<Speaker> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Speaker item)
        {
            throw new NotImplementedException();
        }
    }
}
