using Microsoft.EntityFrameworkCore;

namespace Postgres.Persistance
{
    public class FrcContext : DbContext
    {
        public DbSet<AggregatedEvents> AggregatedEvents { get; set; }
        public DbSet<Identity> Identities { get; set; }
        public DbSet<Event> Events { get; set; }

        public FrcContext(DbContextOptions<FrcContext> options) : base(options)
        {
        }
    }
}