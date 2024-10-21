using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BinhDinhFood.Infrastructure.Data.Configurations;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("Product");

        // Primary key
        builder.HasKey(p => p.Id);

        // Name
        builder.Property(p => p.Name)
            .IsRequired()
            .HasMaxLength(100);

        // Discount
        builder.Property(p => p.OffPrice)
            .HasDefaultValue(0)
            .HasMaxLength(1); // Programmatic range can be enforced elsewhere if needed

        // Relationships: Category, OrderDetails, Favorites, Reviews, Media
        builder.HasMany(p => p.ProductCategories).WithOne(c => c.Product).HasForeignKey(x => x.ProductId);

        builder.HasMany(p => p.OrderDetails).WithOne().HasForeignKey(od => od.ProductId);

        builder.HasMany(p => p.Favorites).WithOne().HasForeignKey(f => f.ProductId);

        builder.HasMany(p => p.Reviews).WithOne().HasForeignKey(pr => pr.ProductId);

        builder.HasMany(p => p.Images).WithOne(i => i.Product).HasForeignKey(i => i.ProductId);
    }
}
