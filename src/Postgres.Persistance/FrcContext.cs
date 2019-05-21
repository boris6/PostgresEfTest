using Microsoft.EntityFrameworkCore;
using Postgres.Domain.Entities;

namespace Postgres.Persistance
{
    public class FrcContext : DbContext
    {
        public FrcContext(DbContextOptions<FrcContext> options) : base(options)
        {
        }

        public DbSet<AggregatedEvents> AggregatedEvents { get; set; }
        public DbSet<Identity> Identities { get; set; }
        public DbSet<FrcEvent> Events { get; set; }
        public DbSet<Camera> Cameras { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<ReferenceImage> ReferenceImages { get; set; }
        public DbSet<IdentityGroup> IdentityGroups { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(FrcContext).Assembly);
        }
    }
}