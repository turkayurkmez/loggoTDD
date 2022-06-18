using Catalog.Entity;
using Microsoft.EntityFrameworkCore;

namespace Catalog.Data.Data
{
    public class SpeakersDbContext : DbContext
    {
        public SpeakersDbContext(DbContextOptions<SpeakersDbContext> option) : base(option)
        {

        }

        public DbSet<Speaker> Speakers { get; set; }

    }
}
