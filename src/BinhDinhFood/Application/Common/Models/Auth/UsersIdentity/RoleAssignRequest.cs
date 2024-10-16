using BinhDinhFood.Domain.Common;

namespace BinhDinhFood.Application.Common.Models.Auth.UsersIdentity;

public class RoleAssignRequest
{
    public string UserId { get; set; }

    public List<SelectItem> Roles { get; set; } = new List<SelectItem>();
    public List<SelectItem> Scopes { get; set; }
}
