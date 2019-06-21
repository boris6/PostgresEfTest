using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Postgres.Domain.Entities;

namespace Postgres.Persistance.Configurations
{
    public class IdentityConfigurations : IEntityTypeConfiguration<Identity>
    {
        public void Configure(EntityTypeBuilder<Identity> builder)
        {
            builder.Property(e => e.MiddleName).IsRequired(false);
            builder.Property(e => e.Info).IsRequired(false);
            builder.Property(e => e.BirthDate).HasColumnType("date");
            builder.HasMany(s => s.ReferenceImages).WithOne(w => w.Identity).IsRequired();


        }
    }
}