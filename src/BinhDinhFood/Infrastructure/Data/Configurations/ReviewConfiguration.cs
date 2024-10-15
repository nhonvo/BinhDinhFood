using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BinhDinhFood.Infrastructure.Data.Configurations;

public class ReviewConfiguration : IEntityTypeConfiguration<Review>
{
    public void Configure(EntityTypeBuilder<Review> builder)
    {
        // Table name
        builder.ToTable("Review");

        builder.HasKey(pr => pr.Id);

        // Stars: range 1 to 5
        builder.Property(pr => pr.Stars)
            .HasDefaultValue(1); // Default value (optional)

        // Foreign key relationship with Product
        builder.HasOne(pr => pr.Product)
            .WithMany(p => p.Reviews)
            .HasForeignKey(pr => pr.ProductId)
            .OnDelete(DeleteBehavior.Cascade); // Cascade delete behavior if Product is deleted

        // Foreign key relationship with Customer
        builder.HasOne(pr => pr.Customer)
            .WithMany(c => c.Reviews)
            .HasForeignKey(pr => pr.CustomerId)
            .OnDelete(DeleteBehavior.Cascade); // Cascade delete behavior if Customer is deleted
    }
}
