using System.Security.Claims;
using BinhDinhFood.Application.Common.Models.AuthIdentity.UsersIdentity;

namespace BinhDinhFood.Application.Common.Interfaces;

public interface ITokenService
{
    string GenerateToken(User user);
    ClaimsPrincipal ValidateToken(string token);
    Task<TokenResult> GenerateToken(ApplicationUser user, string[] scopes, CancellationToken cancellationToken);
}
