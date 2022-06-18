using Catalog.Data.Data;
using Catalog.Entity;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Tests.IntegrationTests
{
    public class SpeakerTestDbContext : SpeakersDbContext
    {
        public SpeakerTestDbContext(DbContextOptions<SpeakersDbContext> option) : base(option)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            seedDataFromFile<Speaker>(modelBuilder, "../../../Data/speakers.json");
        }

        private void seedDataFromFile<T>(ModelBuilder modelBuilder, string filePath) where T : class
        {
            var data = System.IO.File.ReadAllText(filePath);
            var items = JsonConvert.DeserializeObject<List<T>>(data);
            modelBuilder.Entity<T>().HasData(items);
        }
       
    }
}
