using BinhDinhFood.Application.Common.Interfaces;
using BinhDinhFood.Application.Common.Models.Auth.UsersIdentity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BinhDinhFood.Web.Controller;
public class AuthController(IAuthService authService) : BaseController
{
    private readonly IAuthService _authService = authService;

    [HttpPost("login")]
    public async Task<IActionResult> Authenticate([FromBody] LoginRequest request, CancellationToken cancellationToken)
    {
        var result = await _authService.Authenticate(request, cancellationToken);

        SetTokenInCookie(result.Token);
        return Ok(result);
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] RegisterRequest request, CancellationToken cancellationToken)
    {
        await _authService.Register(request, cancellationToken);
        return NoContent();
    }

    [HttpDelete("logout")]
    public async Task<IActionResult> Logout()
    {

        await _authService.LogOut();
        Request.Headers.Authorization.ToString().Replace("Bearer ", "");
        RemoveTokenInCookie();
        return NoContent();
    }

    [HttpGet("refreshToken")]
    [Authorize]
    public async Task<IActionResult> RefreshToken(CancellationToken cancellationToken)
    {
        var refreshToken = GetTokenInCookie();

        var response = await _authService.RefreshTokenAsync(refreshToken, cancellationToken);

        return Ok(response);
    }

    [HttpGet("profile")]
    [Authorize]
    // [Authorize(Policy = "user_read")]
    public async Task<IActionResult> Profile(CancellationToken cancellationToken)
        => Ok(await _authService.GetProfile(cancellationToken));

    [HttpPost("resetPassword")]
    public async Task<IActionResult> ResetPassword(ResetPasswordRequest request, CancellationToken cancellationToken)
    {
        await _authService.ResetPassword(request, cancellationToken);
        return NoContent();
    }

    [HttpPost("sendPasswordResetCode")]
    public async Task<IActionResult> SendPasswordResetCode(SendPasswordResetCodeRequest request, CancellationToken cancellationToken)
        => Ok(await _authService.SendPasswordResetCode(request, cancellationToken));

    // [HttpPost("SignInFacebook")]
    // public async Task<IActionResult> SignInFacebook([FromBody] LoginSocialRequest request, CancellationToken cancellationToken)
    //     => Ok(await _AuthService.SignInFacebook(request.AccessToken, cancellationToken));

    // [HttpPost("SignInGoogle")]
    // public async Task<IActionResult> SignInGoogle([FromBody] LoginSocialRequest request, CancellationToken cancellationToken)
    //     => Ok(await _AuthService.SignInGoogle(request.AccessToken, cancellationToken));

    // [HttpPost("SignInApple")]
    // public async Task<IActionResult> SignInApple([FromBody] LoginSocialRequest request, CancellationToken cancellationToken)
    //     => Ok(await _AuthService.SignInApple(request.FullName, request.AccessToken, cancellationToken));

    private string GetTokenInCookie() => Request.Cookies["token_key"];

    private void SetTokenInCookie(string refreshToken)
    {
        var cookieOptions = new CookieOptions
        {
            HttpOnly = true,
            Expires = DateTime.UtcNow.AddDays(10),
        };
        Response.Cookies.Append("token_key", refreshToken, cookieOptions);
    }
    private void RemoveTokenInCookie()
    {
        Response.Cookies.Delete("token_key");
    }
}
