using BinhDinhFood.Domain.Entities.Auth;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BinhDinhFood.Infrastructure.Data.Configurations;

public class RoleConfig : IEntityTypeConfiguration<RoleIdentity>
{
    public void Configure(EntityTypeBuilder<RoleIdentity> builder)
    {
        builder.ToTable("Role");

        builder.HasMany(e => e.UserRoles)
            .WithOne(e => e.Role)
            .HasForeignKey(ur => ur.RoleId)
            .IsRequired()
            .OnDelete(DeleteBehavior.NoAction);
    }
}
