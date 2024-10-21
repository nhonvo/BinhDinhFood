using BinhDinhFood.Application.Common.Models;
using BinhDinhFood.Domain.Entities.Auth;

namespace BinhDinhFood.Domain.Entities;

public class Media : BaseModel
{
    public MediaType? Type { get; set; }
    public string PathMedia { get; set; }
    public string? Caption { get; set; }
    public long? FileSize { get; set; }
    public Guid? CustomerId { get; set;}
    public ApplicationUser Customer { get; set; }

    public int? BannerId { get; set; }
    public Banner? Banner { get; set; }

    public int? ProductId { get; set; }
    public Product? Product { get; set; }

    public int? BlogId { get; set; }
    public Blog? Blog { get; set; }
}
