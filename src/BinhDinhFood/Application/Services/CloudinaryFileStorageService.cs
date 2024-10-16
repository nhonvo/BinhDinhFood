using BinhDinhFood.Application.Common;
using BinhDinhFood.Application.Common.Interfaces;
using BinhDinhFood.Application.Common.Models.Auth.File;
using BinhDinhFood.Application.Common.Models.Auth.Media;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;

namespace BinhDinhFood.Application.Services;

public class CloudinaryFileStorageService(AppSettings appsettings) : IFileStorageService
{
    private readonly Cloudinary _cloudinary = new(
        new Account(
            appsettings.Cloudinary.CloudName,
            appsettings.Cloudinary.ApiKey,
            appsettings.Cloudinary.ApiSecret
        ));
    public async Task<FileUploadResult> AddFileAsync(IFormFile file)
    {

        await using var stream = file.OpenReadStream();
        var uploadParams = new ImageUploadParams
        {
            File = new FileDescription(file.FileName, stream),
            Transformation = new Transformation().Height(500).Width(500).Crop("fill")
        };

        var uploadResult = await _cloudinary.UploadAsync(uploadParams);

        return uploadResult.Error != null
            ? throw new InvalidOperationException(uploadResult.Error.Message)
            : new FileUploadResult
            {
                Name = uploadResult.PublicId,
                Path = uploadResult.SecureUrl.ToString()
            };
    }

    public async Task DeleteFileAsync(DeleteFileRequest request)
    {

        var deleteParams = new DeletionParams(request.FileName);
        var result = await _cloudinary.DestroyAsync(deleteParams);

        if (result.Result != "ok")
        {
            throw new InvalidOperationException("Failed to delete photo");
        }
    }

    public string GetFileUrl(AddFileRequest request)
    {
        return _cloudinary.Api.UrlImgUp.BuildUrl(request.FileName);
    }
}
