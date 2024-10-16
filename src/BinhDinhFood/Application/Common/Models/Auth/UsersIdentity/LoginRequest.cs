namespace BinhDinhFood.Application.Common.Models.Auth.UsersIdentity;

public class LoginRequest
{
    public string UserName { get; set; }
    public string Password { get; set; }
    public bool RememberMe { get; set; }
}
