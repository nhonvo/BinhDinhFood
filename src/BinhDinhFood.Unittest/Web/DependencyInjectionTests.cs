using System.Diagnostics;
using BinhDinhFood.Application;
using BinhDinhFood.Application.Common;
using BinhDinhFood.Application.Common.Interfaces;
using BinhDinhFood.Application.Services;
using BinhDinhFood.Infrastructure;
using BinhDinhFood.Web;
using BinhDinhFood.Web.Middlewares;
using Microsoft.Extensions.DependencyInjection;

namespace BinhDinhFood.Unittest.Web;

public class DependencyInjectionTests
{
    private readonly ServiceProvider _serviceProvider;
    private readonly AppSettings _appSettings = new AppSettings
    {
        ApplicationDetail = new ApplicationDetail
        {
            ApplicationName = "app",
            ContactWebsite = "http://dummy.html",
            Description = "description"
        },
        ConnectionStrings = new ConnectionStrings
        {
            DefaultConnection = "Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;"
        },
        Jwt = new Jwt
        {
            Key = "your_jwt_key",
            Issuer = "your_jwt_issuer",
            Audience = "your_jwt_audience",
            ExpiredTime = 10
        },
        UseInMemoryDatabase = false,
        Logging = new Logging
        {
            RequestResponse = new RequestResponse
            {
                IsEnabled = true
            }
        },
        Cors = new[]
        {
        "http://localhost:4200",
        "https://myapp.com"
        },
        MailConfigurations = new MailConfigurations
        {
            From = "noreply@myapp.com",
            Host = "smtp.myapp.com",
            Password = "your_password",
            Port = 587
        },
        Cloudinary = new CloudinarySettings
        {
            CloudName = "mycloudname",
            ApiKey = "myapikey",
            ApiSecret = "myapisecret"
        },
        FileStorageSettings = new FileStorageSettings
        {
            LocalStorage = true,
            Path = "C:/FileStorage"
        },
        BaseURL = "https://myapp.com"
    };

    public DependencyInjectionTests()
    {
        var service = new ServiceCollection();
        service.AddApplicationService(_appSettings);
        service.AddInfrastructuresService(_appSettings);
        service.AddWebAPIService(_appSettings);

        _serviceProvider = service.BuildServiceProvider();
    }

    [Fact]
    public void DependencyInjectionTests_ServiceShouldResolveCorrectly()
    {
        var currentTimeServiceResolved = _serviceProvider.GetRequiredService<ICurrentTime>();
        var exceptionMiddlewareResolved = _serviceProvider.GetRequiredService<GlobalExceptionMiddleware>();
        var performanceMiddleware = _serviceProvider.GetRequiredService<PerformanceMiddleware>();
        var stopwatchResolved = _serviceProvider.GetRequiredService<Stopwatch>();

        Assert.Equal(typeof(CurrentTime), currentTimeServiceResolved.GetType());
        Assert.Equal(typeof(GlobalExceptionMiddleware), exceptionMiddlewareResolved.GetType());
        Assert.Equal(typeof(Stopwatch), stopwatchResolved.GetType());
        Assert.Equal(typeof(PerformanceMiddleware), performanceMiddleware.GetType());
    }
}
