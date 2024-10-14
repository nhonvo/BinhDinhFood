using BinhDinhFood.Application.Common.Models.AuthIdentity.Roles;

namespace BinhDinhFood.Application.Common.Interfaces;

public interface IRoleService
{
    Task<List<RoleViewModel>> GetAll();
}
