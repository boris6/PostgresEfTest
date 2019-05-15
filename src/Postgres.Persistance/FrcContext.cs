using Microsoft.EntityFrameworkCore;
using Postgres.Domain.Entities;

namespace Postgres.Persistance
{
    public class FrcContext : DbContext
    {
        public DbSet<AggregatedEvents> AggregatedEvents { get; set; }
        public DbSet<Identity> Identities { get; set; }
        public DbSet<FrcEvent> Events { get; set; }
        public DbSet<Camera> Cameras { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<IdentityGroup> IdentityGroups { get; set; }


        public FrcContext(DbContextOptions<FrcContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(FrcContext).Assembly);
        }

    }
}