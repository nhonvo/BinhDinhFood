using System.Text;
using BinhDinhFood.Application.Common;
using BinhDinhFood.Domain.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.IdentityModel.Tokens;
namespace BinhDinhFood.Web.Extensions;
public static class AuthenticationExtensions
{
    public static void AddAuth(this IServiceCollection services, Jwt identitySettings)
    {
        var authenticationBuilder = services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme);
        authenticationBuilder.AddJwtBearer($"{JwtBearerDefaults.AuthenticationScheme}_{identitySettings.Issuer}", options =>
        {
            options.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidateLifetime = true,
                ValidateAudience = true,
                ValidIssuer = identitySettings.Issuer,
                ValidAudience = identitySettings.Audience,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(identitySettings.Key)),
                ValidateIssuerSigningKey = true,
            };
            
            options.SaveToken = true;  
            // Cache the token
            options.RequireHttpsMetadata = identitySettings.ValidateHttps;
        });

        //custom policy scheme using AddPolicyScheme in ASP.NET Core, it allows you to dynamically choose an authentication scheme based on the incoming request. This is useful if you have multiple authentication methods (e.g., JWT Bearer, Cookies, etc.)
        
        // TODO: Research this block code make the response time very long 
        // => Solution: cache profile 
        //authenticationBuilder.AddPolicyScheme("CustomScheme", "CustomScheme", options =>
        //{
        //    options.ForwardDefaultSelector = context =>
        //    {
        //        // Example logic to select authentication scheme
        //        if (context.Request.Headers.ContainsKey("Authorization"))
        //        {
        //            return "Bearer"; // Use JWT Bearer if there's an Authorization header
        //        }

        //        return "Cookie"; // Default to Cookie
        //    };
        //});

        services.AddAuthorization(options =>
        {
            var authSchemes = $"{JwtBearerDefaults.AuthenticationScheme}_{identitySettings.Issuer}"; 
            
            options.DefaultPolicy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser()
                                                                    .AddAuthenticationSchemes(authSchemes)
                                                                    .Build();

            options.AddPolicy("user_read", policy => policy.Requirements.Add(
                new HasScopeRequirement(identitySettings.ScopeBaseDomain,
                                        identitySettings.ScopeBaseDomain + "/read",
                                        identitySettings.Issuer)));

            options.AddPolicy("user_write", policy => policy.Requirements.Add(
                new HasScopeRequirement(identitySettings.ScopeBaseDomain,
                                        identitySettings.ScopeBaseDomain + "/write",
                                        identitySettings.Issuer)));
        });
    }
}
