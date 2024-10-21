using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BinhDinhFood.Infrastructure.Data.Configurations;

public class MediaConfiguration : IEntityTypeConfiguration<Media>
{
    public void Configure(EntityTypeBuilder<Media> builder)
    {
        builder.ToTable("Media");

        // Primary key
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Caption)
            .HasMaxLength(500);

        // Relationships: banner, product, blog, customer
        builder.HasOne(p => p.Banner).WithOne(b => b.Image).HasForeignKey<Media>(p => p.BannerId);

        builder.HasOne(p => p.Product).WithMany(pr => pr.Images).HasForeignKey(p => p.ProductId);

        builder.HasOne(p => p.Blog).WithMany(b => b.Images).HasForeignKey(p => p.BlogId);

        builder.HasOne(p => p.Customer).WithOne(u => u.Image).HasForeignKey<Media>(p => p.CustomerId);
    }
}
