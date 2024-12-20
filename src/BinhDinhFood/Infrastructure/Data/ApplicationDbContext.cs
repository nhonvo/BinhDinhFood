using System.Reflection;
using BinhDinhFood.Domain.Entities.Auth;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BinhDinhFood.Infrastructure.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :
            IdentityDbContext<ApplicationUser, RoleIdentity, Guid,
            IdentityUserClaim<Guid>, UserRoles, IdentityUserLogin<Guid>,
            IdentityRoleClaim<Guid>, IdentityUserToken<Guid>>(options)
{
    public DbSet<Book> Books { get; set; }
    public DbSet<ApplicationUser> Customers { get; set; }
    public DbSet<RefreshToken> RefreshTokens { get; set; }
    public DbSet<ForgotPassword> ForgotPassword { get; set; }
    public DbSet<Media> Media { get; set; }

    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderDetail> OrderDetails { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductCategory> ProductCategories { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<Banner> Banners { get; set; }
    public DbSet<Favorite> Favorites { get; set; }
    public DbSet<Blog> Blog { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        builder.Entity<IdentityUserClaim<Guid>>().ToTable("UserClaims");
        builder.Entity<IdentityUserLogin<Guid>>().ToTable("UserLogin").HasKey(l => new
        {
            l.LoginProvider,
            l.ProviderKey,
            l.UserId
        });
        builder.Entity<IdentityRoleClaim<Guid>>().ToTable("RoleClaims");
        builder.Entity<IdentityUserToken<Guid>>().ToTable("UserTokens").HasKey(x => x.UserId);

        builder.Seed();
    }
}
