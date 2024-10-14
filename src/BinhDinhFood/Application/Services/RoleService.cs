using BinhDinhFood.Application.Common.Interfaces;
using BinhDinhFood.Application.Common.Models.AuthIdentity.Roles;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BinhDinhFood.Application.Services;

public class RoleService(RoleManager<RoleIdentity> roleManager) : IRoleService
{
    private readonly RoleManager<RoleIdentity> _roleManager = roleManager;

    public async Task<List<RoleViewModel>> GetAll()
    {
        var roles = await _roleManager.Roles
            .Select(x => new RoleViewModel()
            {
                Id = x.Id,
                Name = x.Name,
            }).ToListAsync();

        return roles;
    }
}
