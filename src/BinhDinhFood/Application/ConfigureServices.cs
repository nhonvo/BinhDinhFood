using BinhDinhFood.Application.Common;
using BinhDinhFood.Application.Common.Interfaces;
using BinhDinhFood.Application.Common.Utilities;
using BinhDinhFood.Application.Services;
using BinhDinhFood.Web.Services;

namespace BinhDinhFood.Application;

public static class ConfigureServices
{
    public static IServiceCollection AddApplicationService(this IServiceCollection services, AppSettings appsettings)
    {
        services.AddScoped<IAuthService, AuthService>();
        services.AddScoped<IBookService, BookService>();
        services.AddScoped<IMailService, MailService>();
        services.AddScoped<IFacebookAuthService, FacebookAuthService>();
        services.AddScoped<IMediaService, MediaService>();
        services.AddScoped<IRoleService, RoleService>();
        services.AddScoped<IAuthIdentityService, AuthIdentityService>();

        if (appsettings.FileStorageSettings.LocalStorage)
        {
            services.AddScoped<IFileStorageService, LocalFileStorageService>();
        }
        else
        {
            services.AddScoped<IFileStorageService, CloudinaryFileStorageService>();
        }


        services.AddScoped<IUserService, UserService>();

        services.AddScoped<ICurrentTime, CurrentTime>();
        services.AddScoped<ICurrentUser, CurrentUser>();
        services.AddScoped<ITokenService, TokenService>();
        services.AddScoped<ICookieService, CookieService>();

        services.AddScoped<IProductService, ProductService>();


        return services;
    }
}
