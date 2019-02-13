using Microsoft.EntityFrameworkCore;
using Postgres.Domain.Entities;

namespace Postgres.Persistance
{
    public class FrcContext : DbContext
    {
        public DbSet<AggregatedEvents> AggregatedEvents { get; set; }
        public DbSet<Identity> Identities { get; set; }
        public DbSet<FrcEvent> Events { get; set; }

        public FrcContext(DbContextOptions<FrcContext> options) : base(options)
        {
        }
    }
}