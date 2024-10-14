using BinhDinhFood.Application.Common.Models.User;

namespace BinhDinhFood.Application.Common.Interfaces;
public interface IAuthService
{
    Task<UserSignInResponse> SignIn(UserSignInRequest request);
    Task<UserSignUpResponse> SignUp(UserSignUpRequest request, CancellationToken token);
    void Logout();
    Task<string> RefreshToken();
    Task<UserProfileResponse> GetProfile();
}
