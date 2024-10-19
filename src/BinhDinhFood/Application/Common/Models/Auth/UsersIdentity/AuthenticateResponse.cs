namespace BinhDinhFood.Application.Common.Models.Auth.UsersIdentity;

public class AuthenticateResponse : TokenResult
{
    public UserViewModel Profile { get; set; }
}
