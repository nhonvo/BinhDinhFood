using BinhDinhFood.Domain.Entities.Auth;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BinhDinhFood.Infrastructure.Data.Configurations;


//public class CustomerConfiguration : IEntityTypeConfiguration<ApplicationUser>
//{
//    public void Configure(EntityTypeBuilder<ApplicationUser> builder)
//    {
//        // Table name
//        builder.ToTable("Customer");

//        // Relationship configuration for Orders
//        builder.HasMany(c => c.Orders)
//            .WithOne(o => o.Customer) // Each Order belongs to one Customer
//            .HasForeignKey(o => o.CustomerId)
//            .OnDelete(DeleteBehavior.Cascade); // Cascade delete on Customer deletion

//        // Relationship configuration for Favorites
//        builder.HasMany(c => c.Favorites)
//            .WithOne(f => f.Customer) // Each Favorite belongs to one Customer
//            .HasForeignKey(f => f.CustomerId)
//            .OnDelete(DeleteBehavior.Cascade); // Cascade delete on Customer deletion

//        // Relationship configuration for ProductRatings
//        builder.HasMany(c => c.ProductRatings)
//            .WithOne(pr => pr.Customer) // Each ProductRating belongs to one Customer
//            .HasForeignKey(pr => pr.CustomerId)
//            .OnDelete(DeleteBehavior.Cascade); // Cascade delete on Customer deletion
//    }
//}

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

public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
{
    public void Configure(EntityTypeBuilder<OrderDetail> builder)
    {
        // Table name
        builder.ToTable("OrderDetail");

        // Composite key configuration
        builder.HasKey(od => new { od.ProductId, od.OrderId });

        // Foreign key relationships with Order and Product
        builder.HasOne(od => od.Order)
            .WithMany(o => o.OrderDetails)
            .HasForeignKey(od => od.OrderId)
            .OnDelete(DeleteBehavior.Cascade); // Cascade delete when Order is deleted

        builder.HasOne(od => od.Product)
            .WithMany(p => p.OrderDetails)
            .HasForeignKey(od => od.ProductId)
            .OnDelete(DeleteBehavior.Cascade); // Cascade delete when Product is deleted
    }
}

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
        builder.HasOne(p => p.Category)
            .WithMany(c => c.Products)
            .HasForeignKey(p => p.CategoryId)
            .OnDelete(DeleteBehavior.Cascade);

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

public class ProductRatingConfiguration : IEntityTypeConfiguration<ProductRating>
{
    public void Configure(EntityTypeBuilder<ProductRating> builder)
    {
        // Table name
        builder.ToTable("ProductRating");

        builder.HasKey(pr => pr.Id);

        // Stars: range 1 to 5
        builder.Property(pr => pr.Stars)
            .HasDefaultValue(1); // Default value (optional)

        // Foreign key relationship with Product
        builder.HasOne(pr => pr.Product)
            .WithMany(p => p.ProductRatings)
            .HasForeignKey(pr => pr.ProductId)
            .OnDelete(DeleteBehavior.Cascade); // Cascade delete behavior if Product is deleted

        // Foreign key relationship with Customer
        builder.HasOne(pr => pr.Customer)
            .WithMany(c => c.ProductRatings)
            .HasForeignKey(pr => pr.CustomerId)
            .OnDelete(DeleteBehavior.Cascade); // Cascade delete behavior if Customer is deleted
    }
}


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
    }
}


public class FavoriteConfiguration : IEntityTypeConfiguration<Favorite>
{
    public void Configure(EntityTypeBuilder<Favorite> builder)
    {
        builder.ToTable("Favorite");
        builder.HasKey(f => new { f.ProductId, f.CustomerId });
    }
}

public class BlogConfiguration : IEntityTypeConfiguration<Blog>
{
    public void Configure(EntityTypeBuilder<Blog> builder)
    {
        builder.ToTable("Blog");
        builder.HasKey(b => b.Id);
    }
}
