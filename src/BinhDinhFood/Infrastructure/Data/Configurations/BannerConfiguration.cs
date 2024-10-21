using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BinhDinhFood.Infrastructure.Data.Configurations;

public class BannerConfiguration : IEntityTypeConfiguration<Banner>
{
    public void Configure(EntityTypeBuilder<Banner> builder)
    {
        builder.ToTable("Banner");

        // Primary key
        builder.HasKey(b => b.Id);

        // Column configurations
        builder.Property(b => b.Name)
            .HasMaxLength(200);

        builder.Property(b => b.Discount)
            .HasDefaultValue(0) // Default value for discount
            .HasMaxLength(1);   // You can enforce the range programmatically elsewhere if needed.

        builder.HasOne(b => b.Image).WithOne(i => i.Banner).HasForeignKey<Media>(i => i.BannerId);
    }
}
