﻿namespace BinhDinhFood.Application.Common.Models.Auth.LoginSocial;

public class GetUserLoginSocialRequest
{
    public string LoginProvider { get; set; }
    public string ProviderKey { get; set; }
    public Guid UserId { get; set; }
    public string ProviderDisplayName { get; set; }
}
