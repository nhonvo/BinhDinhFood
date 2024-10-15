using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BinhDinhFood.Infrastructure.Data.Configurations;

public class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        // Table name
        builder.ToTable("Order");

        // Primary key configuration
        builder.HasKey(o => o.Id);

        // Foreign key relationship with Customer
        builder.HasOne(o => o.Customer)
            .WithMany(c => c.Orders) // A customer can have many orders
            .HasForeignKey(o => o.CustomerId)
            .OnDelete(DeleteBehavior.Cascade); // Cascade delete when Customer is deleted

        // Relationship with OrderDetails
        builder.HasMany(o => o.OrderDetails)
            .WithOne(od => od.Order) // Each OrderDetail must have one Order
            .HasForeignKey(od => od.OrderId)
            .OnDelete(DeleteBehavior.Cascade); // Cascade delete when Order is deleted
    }
}
