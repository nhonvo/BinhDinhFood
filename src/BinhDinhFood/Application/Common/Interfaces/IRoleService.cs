using BinhDinhFood.Application.Common.Models.Auth.Roles;

namespace BinhDinhFood.Application.Common.Interfaces;

public interface IRoleService
{
    Task<List<RoleViewModel>> GetAll();
}
