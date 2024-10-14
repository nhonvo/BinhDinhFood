using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace BinhDinhFood.Domain.Entities.Auth;

[NotMapped]
public class RoleIdentity : IdentityRole<Guid>
{
    public virtual ICollection<UserRoles> UserRoles { get; set; }
}

