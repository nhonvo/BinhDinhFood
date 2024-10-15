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
        builder.Property(p => p.Discount)
            .HasDefaultValue(0)
            .HasMaxLength(1); // Programmatic range can be enforced elsewhere if needed

        // Category Relationship
        builder.HasMany(p => p.ProductCategories)
            .WithOne(c => c.Product)
            .HasForeignKey(x => x.ProductId);

        // Relationships: OrderDetails, Favorites, ProductRatings
        builder.HasMany(p => p.OrderDetails)
            .WithOne()
            .HasForeignKey(od => od.ProductId);

        builder.HasMany(p => p.Favorites)
            .WithOne()
            .HasForeignKey(f => f.ProductId);

        builder.HasMany(p => p.ProductRatings)
            .WithOne()
            .HasForeignKey(pr => pr.ProductId);
    }
}
