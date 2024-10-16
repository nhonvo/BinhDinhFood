using BinhDinhFood.Application.Common.Models.Auth.File;
using BinhDinhFood.Application.Common.Models.Auth.Media;

namespace BinhDinhFood.Application.Common.Interfaces;

public interface IFileStorageService
{
    Task DeleteFileAsync(DeleteFileRequest request);
    Task<FileUploadResult> AddFileAsync(IFormFile file);
    string GetFileUrl(AddFileRequest request);
}
