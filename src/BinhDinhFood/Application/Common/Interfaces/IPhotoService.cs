using BinhDinhFood.Application.Common.Models.Auth.File;
using BinhDinhFood.Application.Common.Models.Auth.Media;

namespace BinhDinhFood.Application.Common.Interfaces;

public interface IPhotoService
{
    public Task<FileUploadResult> AddFileAsync(IFormFile file);
    public Task DeleteFileAsync(DeleteFileRequest request);
    public string GetFileUrl(AddFileRequest request);
}
