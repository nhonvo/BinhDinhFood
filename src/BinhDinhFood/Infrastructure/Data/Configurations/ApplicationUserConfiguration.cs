using BinhDinhFood.Domain.Entities.Auth;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BinhDinhFood.Infrastructure.Data.Configurations;

public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
{
    public void Configure(EntityTypeBuilder<ApplicationUser> builder)
    {
        builder.ToTable("ApplicationUser");

        builder.HasOne(x => x.Avatar).WithOne(x => x.User).HasForeignKey<ApplicationUser>(x => x.AvatarId);


        // Table name
        //builder.ToTable("Customer");

        // Relationship configuration for Orders
        builder.HasMany(c => c.Orders)
            .WithOne(o => o.Customer) // Each Order belongs to one Customer
            .HasForeignKey(o => o.CustomerId)
            .OnDelete(DeleteBehavior.Cascade); // Cascade delete on Customer deletion

        // Relationship configuration for Favorites
        builder.HasMany(c => c.Favorites)
            .WithOne(f => f.Customer) // Each Favorite belongs to one Customer
            .HasForeignKey(f => f.CustomerId)
            .OnDelete(DeleteBehavior.Cascade); // Cascade delete on Customer deletion

        // Relationship configuration for Reviews
        builder.HasMany(c => c.Reviews)
            .WithOne(pr => pr.Customer) // Each Review belongs to one Customer
            .HasForeignKey(pr => pr.CustomerId)
            .OnDelete(DeleteBehavior.Cascade); // Cascade delete on Customer deletion
    }
}
