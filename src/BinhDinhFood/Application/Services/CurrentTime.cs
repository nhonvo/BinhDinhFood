using BinhDinhFood.Application.Common.Interfaces;

namespace BinhDinhFood.Application.Services;

public class CurrentTime : ICurrentTime
{
    public DateTime GetCurrentTime() => DateTime.UtcNow;
}
