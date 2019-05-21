using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Postgres.Domain.Entities;

namespace Postgres.Persistance.Configurations
{
    public class ReferenceImagesConfiguration : IEntityTypeConfiguration<ReferenceImage>
    {
        public void Configure(EntityTypeBuilder<ReferenceImage> builder)
        {
            builder.HasOne(d => d.Identity)
                .WithMany(p => p.ReferenceImages)
                .HasForeignKey(d => d.IdentityId);
        }
    }
}