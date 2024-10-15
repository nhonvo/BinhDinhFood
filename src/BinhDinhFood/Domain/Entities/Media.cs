using BinhDinhFood.Application.Common.Models;
using BinhDinhFood.Domain.Entities.Auth;

namespace BinhDinhFood.Domain.Entities;

public class Media : BaseModel
{
    public MediaType Type { get; set; }
    public string PathMedia { get; set; }
    public string Caption { get; set; }
    public long FileSize { get; set; }
    public DateTime DateCreated { get; set; }
    public ApplicationUser User { get; set; }
}
