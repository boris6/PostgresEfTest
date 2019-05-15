using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Postgres.Domain.Entities;

namespace Postgres.Persistance.Configurations
{
    public class FrcEventConfiguration : IEntityTypeConfiguration<FrcEvent>
    {
        public void Configure(EntityTypeBuilder<FrcEvent> builder)
        {
            builder.Property(e => e.FrcEventId).ValueGeneratedOnAdd();
            builder.Property(e => e.Rectangle).HasColumnType("jsonb");
            builder.Property(e => e.Confidence).HasColumnType("jsonb");

            builder.HasOne(d => d.AggregatedEvents)
                .WithMany(p => p.FrcEvent)
                .HasForeignKey(d => d.AggregatedEventsId);
        }
    }
}