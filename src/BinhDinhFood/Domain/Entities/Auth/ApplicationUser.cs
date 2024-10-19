using Microsoft.AspNetCore.Identity;

namespace BinhDinhFood.Domain.Entities.Auth;

public class ApplicationUser : IdentityUser<Guid>
{
    public string Name { get; set; }
    public int? AvatarId { get; set; }
    public Media Avatar { get; set; }
    public virtual ICollection<UserRoles> UserRoles { get; set; }
    public ICollection<RefreshToken> RefreshTokens { get; set; }

    // add-on fields
    public string? Address { get; set; }
    public ICollection<Order> Orders { get; set; }
    public virtual ICollection<Review> Reviews { get; set; }
    public virtual ICollection<Favorite> Favorites { get; set; }
}

