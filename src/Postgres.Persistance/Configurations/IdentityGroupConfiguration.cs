using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Postgres.Domain.Entities;

namespace Postgres.Persistance.Configurations
{
    public class IdentityGroupConfiguration : IEntityTypeConfiguration<IdentityGroup>
    {
        public void Configure(EntityTypeBuilder<IdentityGroup> builder)
        {
            builder.HasKey(k => new { k.IdentityId, k.GroupId });

            builder.HasOne(d => d.Identity)
                .WithMany(p => p.IdentityGroups)
                .HasForeignKey(d => d.IdentityId);

            builder.HasOne(d => d.Group)
                .WithMany(p => p.IdentityGroups)
                .HasForeignKey(d => d.GroupId);
        }
    }
}