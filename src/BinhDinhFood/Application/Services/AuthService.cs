using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using BinhDinhFood.Application.Common;
using BinhDinhFood.Application.Common.Exceptions;
using BinhDinhFood.Application.Common.Interfaces;
using BinhDinhFood.Application.Common.Models.Auth.UsersIdentity;
using BinhDinhFood.Application.Common.Utilities;
using BinhDinhFood.Domain.Entities.Auth;
using BinhDinhFood.Infrastructure.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using static Google.Apis.Auth.GoogleJsonWebSignature;
using Payload = Google.Apis.Auth.GoogleJsonWebSignature.Payload;

namespace BinhDinhFood.Application.Services;
public class AuthService(ApplicationDbContext context,
    UserManager<ApplicationUser> userManager,
    SignInManager<ApplicationUser> signInManager,
    IFacebookAuthService facebookAuthService,
    ITokenService tokenService,
    IUnitOfWork unitOfWork,
    IMailService emailSender,
    ICurrentUser currentUser,
    AppSettings appSettings) : IAuthService
{
    private readonly ApplicationDbContext _context = context;
    private readonly UserManager<ApplicationUser> _userManager = userManager;
    private readonly SignInManager<ApplicationUser> _signInManager = signInManager;
    private readonly IFacebookAuthService _facebookAuthService = facebookAuthService;
    private readonly IMailService _emailSender = emailSender;
    private readonly ITokenService _tokenService = tokenService;
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly ICurrentUser _currentUser = currentUser;
    private readonly AppSettings _appSettings = appSettings;

    public async Task LogOut()
    {
        await _signInManager.SignOutAsync();
    }

    public async Task<AuthenticateResponse> Authenticate(LoginRequest request, CancellationToken cancellationToken)
    {
        // Step 1: Retrieve the user with all needed data (roles, avatar) in a single query.
        var user = await _userManager.Users
            .Include(u => u.UserRoles).ThenInclude(ur => ur.Role)  // Load user roles in a single query
            .Include(u => u.Avatar)                               // Load avatar
            .FirstOrDefaultAsync(u => u.UserName == request.UserName, cancellationToken) 
            ?? throw AuthException.ThrowAccountDoesNotExist();

        // Step 2: Check the password first to avoid unnecessary database queries if invalid.
        var passwordCheckResult = await _signInManager.CheckPasswordSignInAsync(user, request.Password, lockoutOnFailure: true);

        if (!passwordCheckResult.Succeeded)
        {
            throw AuthException.ThrowLoginUnsuccessful();
        }

        // Step 3: Retrieve user's claims in bulk to avoid multiple individual queries.
        var userClaims = await _userManager.GetClaimsAsync(user);
        var scopes = userClaims.FirstOrDefault(c => c.Type == "scope")?.Value.Split(' ') ?? Array.Empty<string>();

        // Step 4: Generate authentication token.
        var token = await _tokenService.GenerateToken(user, scopes, cancellationToken);

        // Step 5: Prepare the user profile with roles and avatar (already included in the user object).
        var userProfile = new UserViewModel
        {
            UserId = user.Id,
            Email = user.Email,
            UserName = user.UserName,
            FullName = user.Name,
            Roles = user.UserRoles.Select(ur => ur.Role.Name).ToList(),
            Avatar = user.Avatar?.PathMedia
        };

        // Step 6: Return the response with the token and profile information.
        return new AuthenticateResponse
        {
            Token = token.Token,
            UserId = token.UserId,
            Expires = token.Expires,
            Profile = userProfile
        };
    }

    public async Task Register(RegisterRequest request, CancellationToken cancellationToken)
    {
        var user = await _userManager.FindByNameAsync(request.UserName);

        if (user != null)
        {
            throw AuthException.ThrowUsernameAvailable();
        }

        user = await _userManager.FindByEmailAsync(request.Email);

        if (user != null)
        {
            throw AuthException.ThrowEmailAvailable();
        }

        user = new ApplicationUser()
        {
            Email = request.Email,
            UserName = request.UserName,
            Name = request.Name
        };
        var result = await _userManager.CreateAsync(user, request.Password);

        if (result.Succeeded)
        {
            await _userManager.AddToRoleAsync(user, Role.User.ToString());
            // Add custom scope claim to the user
            string readScope = _appSettings.Jwt.ScopeBaseDomain + "/read";
            string writeScope = _appSettings.Jwt.ScopeBaseDomain + "/write";
            string[] scopes = [readScope, writeScope];

            // Add custom scope claim to the user
            var scopeClaim = new Claim("scope", string.Join(" ", scopes)); // Space-separated scopes

            await _userManager.AddClaimAsync(user, scopeClaim);
        }
        else
        {
            List<IdentityError> errorList = result.Errors.ToList();
            var errors = string.Join(", ", errorList.Select(e => e.Description));
            throw AuthException.ThrowRegisterUnsuccessful(errors);
        }
    }

    //Refresh Token
    public async Task<TokenResult> RefreshTokenAsync(string token, CancellationToken cancellationToken)
    {
        var user = await _userManager.Users.Include(x => x.RefreshTokens).SingleOrDefaultAsync(
            x => x.Id == new Guid(_currentUser.GetCurrentStringUserId()),
            cancellationToken) ?? throw AuthException.ThrowAccountDoesNotExist();

        var refreshToken = user.RefreshTokens.Single(x => x.Token == token);

        if (!refreshToken.IsActive)
        {
            throw AuthException.ThrowTokenNotActive();
        }

        // recall current token
        refreshToken.Revoked = DateTime.UtcNow;

        // Retrieve user's claims, including scope claim
        var userClaims = await _userManager.GetClaimsAsync(user);
        var scopeClaim = userClaims.FirstOrDefault(c => c.Type == "scope");


        // Extract scopes from the claim, if it exists
        var scopes = scopeClaim?.Value.Split(' ') ?? [];

        var res = await _tokenService.GenerateToken(user, scopes, cancellationToken);

        var result = new TokenResult
        {
            UserId = res.UserId,
            Expires = res.Expires,
            Token = res.Token,
        };
        return result;
    }

    public async Task<UserViewModel> GetProfile(CancellationToken cancellationToken)
    {
        var userId = _currentUser.GetCurrentStringUserId();

        var user = await _userManager.Users.Where(x => x.Id == new Guid(userId)).Include(u => u.UserRoles)
                        .ThenInclude(ur => ur.Role)
                    .Include(u => u.Avatar).Select(users => new UserViewModel
                    {
                        UserId = users.Id,
                        Email = users.Email,
                        UserName = users.UserName,
                        FullName = users.Name,
                        Roles = users.UserRoles.Select(ur => ur.Role.Name).ToList(),
                        Avatar = users.Avatar.PathMedia
                    }).SingleOrDefaultAsync(cancellationToken) ?? throw AuthException.ThrowAccountDoesNotExist(); ;

        return user;
    }

    public async Task<ForgotPassword> SendPasswordResetCode(SendPasswordResetCodeRequest request, CancellationToken cancellationToken)
    {
        //Get identity user details user manager
        var user = await _userManager.FindByEmailAsync(request.Email)
            ?? throw AuthException.ThrowUserNotFound();

        //Generate password reset token
        var token = await _userManager.GeneratePasswordResetTokenAsync(user);

        //Generate OTP
        int otp = StringHelper.GenerateRandom(100000, 999999);

        var resetPassword = new ForgotPassword()
        {
            Email = request.Email,
            OTP = otp.ToString(),
            Token = token,
            UserId = user.Id,
            DateTime = DateTime.Now
        };

        //save data into db with OTP
        await _unitOfWork.ExecuteTransactionAsync(
            async () => await _unitOfWork.ForgotPasswordRepository.AddAsync(resetPassword), cancellationToken);

        //To do: Send token in email
        await _emailSender.SendEmailAsync(request.Email, "Reset Password OTP", "Hello "
            + request.Email +
            "<br><br>Please find the reset password token below<br><br><b>"
            + otp +
            "<b><br><br>Thanks<br>nhonvo.github.io");

        return resetPassword;
    }

    public async Task ResetPassword(ResetPasswordRequest request, CancellationToken cancellationToken)
    {
        //Get identity user details user manager
        var user = await _userManager.FindByEmailAsync(request.Email);

        //Getting token from otp
        var resetPasswordDetails = await _unitOfWork.ForgotPasswordRepository.FirstOrDefaultAsync(
            filter: x => x.OTP == request.OTP && x.UserId == user.Id, x => x.DateTime, false);

        //Verify if token is older than 3 minutes
        var expirationDateTime = resetPasswordDetails.DateTime.AddMinutes(3);

        if (expirationDateTime < DateTime.Now)
        {
            throw AuthException.ThrowGenerateTheNewOTP();
        }

        var res = await _userManager.ResetPasswordAsync(user, resetPasswordDetails.Token, request.NewPassword);

        if (!res.Succeeded)
        {
            throw AuthException.ThrowOTPWrong();
        }
    }

    //Đăng nhập bằng Facebook
    public async Task<TokenResult> SignInFacebook(string accessToken, CancellationToken cancellationToken)
    {
        var validatedTokenResult = await _facebookAuthService.ValidationAccessTokenAsync(accessToken);

        if (!validatedTokenResult.Data.IsValid)
        {
            throw AuthException.ThrowInvalidFacebookToken();
        }

        //Lấy thông tin User Facebook từ AccessToken
        var userInfo = await _facebookAuthService.GetUsersInfoAsync(accessToken);

        //Cắt Email thành UsernName
        string userName = userInfo.Email.Split('@')[0];

        //Tạo FullName
        string fullName = (userInfo.LastName + userInfo.FirstName).ToString();

        //Kiểm tra user đã liên kết với Facebook chưa
        var checkLinked = await _signInManager.ExternalLoginSignInAsync("Facebook", userInfo.Id, false);

        //Nếu đã có liên kết trước đó (Email tồn tại) thì tiến hành đăng nhập luôn
        if (checkLinked.Succeeded)
        {
            var exist_user = await _userManager.FindByEmailAsync(userInfo.Email);

            var avatar = _context.Media.Where(m => m.Id == exist_user.AvatarId).Select(m => m.PathMedia)
                .FirstOrDefault();


            // Retrieve user's claims, including scope claim
            var userClaims = await _userManager.GetClaimsAsync(exist_user);
            var scopeClaim = userClaims.FirstOrDefault(c => c.Type == "scope");

            // Extract scopes from the claim, if it exists
            var scopes = scopeClaim?.Value.Split(' ') ?? [];

            var tokenResult = await _tokenService.GenerateToken(exist_user, scopes, cancellationToken);

            return tokenResult;
        }
        else //Chưa được liên kết với Facebook
        {
            var info = new ExternalLoginInfo(ClaimsPrincipal.Current, "Facebook", userInfo.Id, null);

            //Kiểm tra tồn tại Email
            var exist_user = await _userManager.FindByEmailAsync(userInfo.Email);

            if (exist_user != null)
            {
                //Gán tài khoản Facebook vào tài khoản đã có sẵn
                var result = await _userManager.AddLoginAsync(exist_user, info);
                if (result.Succeeded)
                {
                    var avatar = _context.Media.Where(m => m.Id == exist_user.AvatarId)
                        .Select(m => m.PathMedia).FirstOrDefault();

                    // Retrieve user's claims, including scope claim
                    var userClaims = await _userManager.GetClaimsAsync(exist_user);
                    var scopeClaim = userClaims.FirstOrDefault(c => c.Type == "scope");

                    // Extract scopes from the claim, if it exists
                    var scopes = scopeClaim?.Value.Split(' ') ?? [];

                    var tokenResult = await _tokenService.GenerateToken(exist_user, scopes, cancellationToken);
                    return tokenResult;
                }
                else
                {
                    throw AuthException.ThrowErrorLinkedFacebook();
                }
            }
            else //Tài khoản đăng nhập lần đầu
            {
                var identityUser = new ApplicationUser
                {
                    Id = Guid.NewGuid(),
                    Email = userInfo.Email,
                    UserName = userName,
                    Name = fullName
                };

                var result = await _userManager.CreateAsync(identityUser);

                if (result.Succeeded)
                {
                    result = await _userManager.AddLoginAsync(identityUser, info);

                    if (!result.Succeeded)
                    {
                        throw AuthException.ThrowErrorLinkedFacebook();
                    }

                    var roles = await _userManager.AddToRoleAsync(identityUser, Role.User.ToString());

                    // Retrieve user's claims, including scope claim
                    var userClaims = await _userManager.GetClaimsAsync(exist_user);
                    var scopeClaim = userClaims.FirstOrDefault(c => c.Type == "scope");

                    // Extract scopes from the claim, if it exists
                    var scopes = scopeClaim?.Value.Split(' ') ?? [];

                    var tokenResult = await _tokenService.GenerateToken(exist_user, scopes, cancellationToken);
                    return tokenResult;
                }
                else
                {
                    List<IdentityError> errorList = result.Errors.ToList();
                    var errors = string.Join(", ", errorList.Select(e => e.Description));
                    throw AuthException.ThrowRegisterFacebookUnsuccessful(errors);
                }
            }
        }
    }

    //Đăng nhập bằng Google
    public async Task<TokenResult> SignInGoogle(string accessToken, CancellationToken cancellationToken)
    {

        Payload payload = await ValidateAsync(accessToken)
            ?? throw AuthException.ThrowErrorLinkedGoogle();


        //Kiểm tra user đã liên kết với Google chưa
        var checkLinked = await _signInManager.ExternalLoginSignInAsync("Google", payload.Subject, false);

        //Cắt Email thành UserName
        string userName = payload.Email.Split('@')[0];

        //Tạo FullName
        string fullName = (payload.FamilyName + payload.GivenName).ToString();

        //Nếu đã có liên kết trước đó (Email) thì tiến hành đăng nhập luôn
        if (checkLinked.Succeeded)
        {
            var exist_user = await _userManager.FindByEmailAsync(payload.Email);

            var avatar = _context.Media.Where(m => m.Id == exist_user.AvatarId).Select(m => m.PathMedia)
                .FirstOrDefault();

            // Retrieve user's claims, including scope claim
            var userClaims = await _userManager.GetClaimsAsync(exist_user);
            var scopeClaim = userClaims.FirstOrDefault(c => c.Type == "scope");

            // Extract scopes from the claim, if it exists
            var scopes = scopeClaim?.Value.Split(' ') ?? [];

            var tokenResult = await _tokenService.GenerateToken(exist_user, scopes, cancellationToken);
            return tokenResult;
        }
        else //Chưa được liên kết với Google
        {
            var info = new ExternalLoginInfo(ClaimsPrincipal.Current, "Google", payload.Subject, null);

            //Kiểm tra tồn tại Email và Username
            var exist_user = await _userManager.FindByEmailAsync(payload.Email);

            if (exist_user != null)
            {
                //Gán tài khoản Facebook vào tài khoản đã có sẵn
                var result = await _userManager.AddLoginAsync(exist_user, info);

                if (result.Succeeded)
                {
                    var avatar = _context.Media.Where(m => m.Id == exist_user.AvatarId)
                        .Select(m => m.PathMedia).FirstOrDefault();

                    // Retrieve user's claims, including scope claim
                    var userClaims = await _userManager.GetClaimsAsync(exist_user);
                    var scopeClaim = userClaims.FirstOrDefault(c => c.Type == "scope");

                    // Extract scopes from the claim, if it exists
                    var scopes = scopeClaim?.Value.Split(' ') ?? [];

                    var tokenResult = await _tokenService.GenerateToken(exist_user, scopes, cancellationToken);

                    return tokenResult;
                }
                else
                {
                    throw AuthException.ThrowErrorLinkedGoogle();
                }
            }
            else //Tài khoản đăng nhập lần đầu
            {
                var identityUser = new ApplicationUser
                {
                    Id = Guid.NewGuid(),
                    Email = payload.Email,
                    UserName = userName,
                    Name = fullName
                };

                var result = await _userManager.CreateAsync(identityUser);

                if (result.Succeeded)
                {
                    result = await _userManager.AddLoginAsync(identityUser, info);

                    if (!result.Succeeded)
                    {
                        throw AuthException.ThrowErrorLinkedGoogle();
                    }

                    var roles = await _userManager.AddToRoleAsync(identityUser, Role.User.ToString());


                    // Retrieve user's claims, including scope claim
                    var userClaims = await _userManager.GetClaimsAsync(exist_user);
                    var scopeClaim = userClaims.FirstOrDefault(c => c.Type == "scope");

                    // Extract scopes from the claim, if it exists
                    var scopes = scopeClaim?.Value.Split(' ') ?? [];

                    var tokenResult = await _tokenService.GenerateToken(exist_user, scopes, cancellationToken);
                    return tokenResult;
                }
                else
                {
                    List<IdentityError> errorList = result.Errors.ToList();
                    var errors = string.Join(", ", errorList.Select(e => e.Description));
                    throw AuthException.ThrowRegisterGoogleUnsuccessful(errors);
                }
            }
        }
    }

    //Đăng nhập bằng Apple
    public async Task<TokenResult> SignInApple(string fullName, string identityToken, CancellationToken cancellationToken)
    {
        var tokenHandler = new JwtSecurityTokenHandler();
        var payload = tokenHandler.ReadJwtToken(identityToken) ?? throw AuthException.ThrowInvalidAppleToken();

        //Kiểm tra user đã liên kết với Google chưa
        var checkLinked = await _signInManager.ExternalLoginSignInAsync("Apple", payload.Subject, false);

        //Cắt Email thành UserName
        string email = payload.Payload.SingleOrDefault(x => x.Key == "email").Value.ToString()
            ?? throw AuthException.ThrowEmailRequired();

        string userName = email.Split('@')[0];

        //Nếu đã có liên kết trước đó (Email) thì tiến hành đăng nhập luôn
        if (checkLinked.Succeeded)
        {
            var exist_user = await _userManager.FindByEmailAsync(email);

            var avatar = _context.Media.Where(m => m.Id == exist_user.AvatarId).Select(m => m.PathMedia)
                .FirstOrDefault();

            // Retrieve user's claims, including scope claim
            var userClaims = await _userManager.GetClaimsAsync(exist_user);
            var scopeClaim = userClaims.FirstOrDefault(c => c.Type == "scope");

            // Extract scopes from the claim, if it exists
            var scopes = scopeClaim?.Value.Split(' ') ?? [];

            var tokenResult = await _tokenService.GenerateToken(exist_user, scopes, cancellationToken);

            return tokenResult;
        }
        else //Chưa được liên kết với Apple
        {
            var info = new ExternalLoginInfo(ClaimsPrincipal.Current, "Apple", payload.Subject, null);

            //Kiểm tra tồn tại Email và Username
            var exist_user = await _userManager.FindByEmailAsync(email);

            if (exist_user != null)
            {
                //Gán tài khoản Apple vào tài khoản đã có sẵn
                var result = await _userManager.AddLoginAsync(exist_user, info);

                if (result.Succeeded)
                {
                    var avatar = _context.Media.Where(m => m.Id == exist_user.AvatarId)
                        .Select(m => m.PathMedia).FirstOrDefault();

                    // Retrieve user's claims, including scope claim
                    var userClaims = await _userManager.GetClaimsAsync(exist_user);
                    var scopeClaim = userClaims.FirstOrDefault(c => c.Type == "scope");

                    // Extract scopes from the claim, if it exists
                    var scopes = scopeClaim?.Value.Split(' ') ?? [];

                    var tokenResult = await _tokenService.GenerateToken(exist_user, scopes, cancellationToken);
                    return tokenResult;
                }
                else
                {
                    throw AuthException.ThrowErrorLinkedApple();
                }
            }
            else //Tài khoản đăng nhập lần đầu
            {
                var identityUser = new ApplicationUser
                {
                    Id = Guid.NewGuid(),
                    Email = email,
                    UserName = userName,
                    Name = fullName
                };

                var result = await _userManager.CreateAsync(identityUser);

                if (result.Succeeded)
                {
                    result = await _userManager.AddLoginAsync(identityUser, info);

                    if (!result.Succeeded)
                    {
                        throw AuthException.ThrowErrorLinkedApple();
                    }

                    var roles = await _userManager.AddToRoleAsync(identityUser, Role.User.ToString());
                    // Retrieve user's claims, including scope claim
                    var userClaims = await _userManager.GetClaimsAsync(exist_user);
                    var scopeClaim = userClaims.FirstOrDefault(c => c.Type == "scope");

                    // Extract scopes from the claim, if it exists
                    var scopes = scopeClaim?.Value.Split(' ') ?? [];

                    var tokenResult = await _tokenService.GenerateToken(exist_user, scopes, cancellationToken);
                    return tokenResult;
                }
                else
                {
                    List<IdentityError> errorList = result.Errors.ToList();
                    var errors = string.Join(", ", errorList.Select(e => e.Description));
                    throw AuthException.ThrowRegisterAppleUnsuccessful(errors);
                }
            }
        }
    }
}
