using BinhDinhFood.Application.Common.Models.Auth.UsersIdentity;

namespace BinhDinhFood.Application.Common.Models.Auth.Roles;

public class UserRoleViewModel
{
    public UserUpdateRequest EditUser { get; set; }

    public RoleAssignRequest EditRole { get; set; }
}
