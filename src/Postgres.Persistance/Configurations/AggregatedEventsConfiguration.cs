using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Postgres.Domain.Entities;

namespace Postgres.Persistance.Configurations
{
    public class AggregatedEventsConfiguration : IEntityTypeConfiguration<AggregatedEvents>
    {
        public void Configure(EntityTypeBuilder<AggregatedEvents> builder)
        {
            builder.Property(e => e.AggregatedEventsId).ValueGeneratedOnAdd();
        }
    }
}