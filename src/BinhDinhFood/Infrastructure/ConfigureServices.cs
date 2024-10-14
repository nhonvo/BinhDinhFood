using BinhDinhFood.Application;
using BinhDinhFood.Application.Common;
using BinhDinhFood.Application.Repositories;
using BinhDinhFood.Domain.Authorization;
using BinhDinhFood.Domain.Entities.Auth;
using BinhDinhFood.Infrastructure.Data;
using BinhDinhFood.Infrastructure.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BinhDinhFood.Infrastructure;

public static class ConfigureServices
{
    public static IServiceCollection AddInfrastructuresService(this IServiceCollection services, AppSettings configuration)
    {
        if (configuration.UseInMemoryDatabase)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseInMemoryDatabase("BinhDinhFood"));
        }
        else
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(configuration.ConnectionStrings.DefaultConnection));
        }

        services.AddIdentity<ApplicationUser, RoleIdentity>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

        // register services
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IBookRepository, BookRepository>();
        services.AddScoped<IRefreshTokenRepository, RefreshTokenRepository>();
        services.AddScoped<IMediaRepository, MediaRepository>();
        services.AddScoped<IForgotPasswordRepository, ForgotPasswordRepository>();
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<ApplicationDbContextInitializer>();

        services.AddSingleton<IAuthorizationHandler, HasScopeHandler>();
        return services;
    }
}
