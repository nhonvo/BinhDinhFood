using BinhDinhFood.Application.Common.Models.Auth.Media;

namespace BinhDinhFood.Application.Common.Interfaces;

public interface IMediaService
{
    Task RemoveMediaAsync(int mediaId, CancellationToken cancellationToken);
    Task UpdateMediaAsync(int mediaId, MediaCreateRequest request, CancellationToken cancellationToken);
}
