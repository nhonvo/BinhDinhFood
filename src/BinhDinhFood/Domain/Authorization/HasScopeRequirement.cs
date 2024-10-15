using Microsoft.AspNetCore.Authorization;

namespace BinhDinhFood.Domain.Authorization;
public class HasScopeRequirement(string scopeBaseDomain, string scope, string issuer) : IAuthorizationRequirement
{
    public string ScopeBaseDomain { get; } = scopeBaseDomain;
    public string Scope { get; } = scope;
    public string Issuer { get; } = issuer;
}
