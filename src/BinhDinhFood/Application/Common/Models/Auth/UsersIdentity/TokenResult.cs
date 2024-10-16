namespace BinhDinhFood.Application.Common.Models.Auth.UsersIdentity;

public class TokenResult
{
    public Guid UserId { get; set; }

    public string Token { get; set; }

    public DateTime Expires { get; set; }
}
