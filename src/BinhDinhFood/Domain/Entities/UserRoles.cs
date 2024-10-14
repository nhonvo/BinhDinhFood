using Microsoft.AspNetCore.Identity;

namespace BinhDinhFood.Domain.Entities;

public class UserRoles : IdentityUserRole<Guid>
{
    public virtual ApplicationUser User { get; set; }

    public virtual RoleIdentity Role { get; set; }
}
