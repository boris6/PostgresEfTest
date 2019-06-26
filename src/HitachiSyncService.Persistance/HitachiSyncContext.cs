using System;
using HitachiSyncService.Entities;
using Microsoft.EntityFrameworkCore;

namespace HitachiSyncService.Persistance
{
    public class HitachiSyncContext : DbContext
    {
        public HitachiSyncContext(DbContextOptions<HitachiSyncContext> options) : base(options)
        {

        }

        public DbSet<Identity> Identities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(HitachiSyncContext).Assembly);
        }
    }
}
