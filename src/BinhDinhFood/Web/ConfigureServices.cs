using System.Diagnostics;
using System.Reflection;
using BinhDinhFood.Application.Common;
using BinhDinhFood.Domain.Authorization;
using BinhDinhFood.Web.Extensions;
using BinhDinhFood.Web.Middlewares;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authorization;

namespace BinhDinhFood.Web;

public static class ConfigureServices
{
    public static IServiceCollection AddWebAPIService(this IServiceCollection services, AppSettings appSettings)
    {
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        services.AddFluentValidationAutoValidation();
        services.AddFluentValidationClientsideAdapters();
        services.AddDistributedMemoryCache();
        services.AddMemoryCache();
        services.AddAuth(appSettings.Jwt);
        services.AddSingleton<IAuthorizationHandler, HasScopeHandler>();

        // Middleware
        services.AddSingleton<GlobalExceptionMiddleware>();
        services.AddSingleton<PerformanceMiddleware>();
        services.AddSingleton<Stopwatch>();

        // Extension classes
        services.AddHealthChecks();
        services.AddCompressionCustom();
        services.AddCorsCustom(appSettings);
        services.AddHttpClient();
        services.AddSwaggerOpenAPI(appSettings);
        services.SetupHealthCheck(appSettings);

        return services;
    }
}
