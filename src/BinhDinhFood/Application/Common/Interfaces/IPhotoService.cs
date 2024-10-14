using BinhDinhFood.Application.Common.Models.AuthIdentity.File;
using BinhDinhFood.Application.Common.Models.AuthIdentity.Media;

namespace BinhDinhFood.Application.Common.Interfaces;

public interface IPhotoService
{
    public Task<FileUploadResult> AddFileAsync(IFormFile file);
    public Task DeleteFileAsync(DeleteFileRequest request);
    public string GetFileUrl(AddFileRequest request);
}
