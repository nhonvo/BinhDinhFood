using System.Security.Claims;
using BinhDinhFood.Application.Common.Models.AuthIdentity.UsersIdentity;
using BinhDinhFood.Domain.Entities.Auth;

namespace BinhDinhFood.Application.Common.Interfaces;

public interface ITokenService
{
    string GenerateToken(User user);
    ClaimsPrincipal ValidateToken(string token);
    Task<TokenResult> GenerateToken(ApplicationUser user, string[] scopes, CancellationToken cancellationToken);
}
