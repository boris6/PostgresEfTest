using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Postgres.Domain.Entities;

namespace Postgres.Persistance.Configurations
{
    public class IdentityCategoryConfiguration : IEntityTypeConfiguration<IdentityCategory>
    {
        public void Configure(EntityTypeBuilder<IdentityCategory> builder)
        {
            builder.HasKey(k => new {k.IdentityId, k.CategoryId});

            builder.HasOne(d => d.Identity)
                .WithMany(p => p.IdentityCategories)
                .HasForeignKey(d => d.IdentityId);

            builder.HasOne(d => d.Category)
                .WithMany(p => p.IdentityCategories)
                .HasForeignKey(d => d.CategoryId);
        }
    }
}