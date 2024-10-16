using Microsoft.EntityFrameworkCore;

namespace BinhDinhFood.Infrastructure.Data;
/// <summary>
/// Another way to seed data use DbContext
/// </summary>
public class ApplicationDbContextInitializer(ApplicationDbContext context, ILoggerFactory logger)
{
    private readonly ApplicationDbContext _context = context;
    private readonly ILogger _logger = logger.CreateLogger<ApplicationDbContextInitializer>();

    public async Task InitializeAsync()
    {
        try
        {
            await _context.Database.MigrateAsync();
            // await SeedUser();
        }
        catch (Exception exception)
        {
            _logger.LogError("Migration error {exception}", exception);
            throw;
        }
    }
}
