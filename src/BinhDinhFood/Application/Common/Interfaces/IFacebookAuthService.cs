using BinhDinhFood.Application.Common.Models.Auth.LoginSocial;

namespace BinhDinhFood.Application.Common.Interfaces;

public interface IFacebookAuthService
{
    Task<FacebookTokenValidationResult> ValidationAccessTokenAsync(string accessToken);
    Task<FacebookUserInfoResult> GetUsersInfoAsync(string accessToken);
}
