using BinhDinhFood.Application.Common.Models;

namespace BinhDinhFood.Domain.Entities.Auth;

public class ForgotPassword : BaseModel
{
    public Guid UserId { get; set; }
    public string Email { get; set; }
    public string Token { get; set; }
    public string OTP { get; set; }
    public DateTime DateTime { get; set; }
}
