using BinhDinhFood.Application.Common;
using BinhDinhFood.Application.Common.Exceptions;
using BinhDinhFood.Web.Extensions;

var builder = WebApplication.CreateBuilder(args);

var configuration = builder.Configuration.Get<AppSettings>()
    ?? throw ProgramException.AppsettingNotSetException();

builder.Services.AddSingleton(configuration);
var app = await builder.ConfigureServices(configuration).ConfigurePipelineAsync(configuration);

await app.RunAsync();

// this line for integration test
public partial class Program { }
