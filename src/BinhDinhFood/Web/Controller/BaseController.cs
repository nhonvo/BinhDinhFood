using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BinhDinhFood.Web.Controller;

[ApiController]
[Route("api/[controller]/")]
[AllowAnonymous]
public class BaseController : ControllerBase { }
