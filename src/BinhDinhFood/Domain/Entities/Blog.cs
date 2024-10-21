using BinhDinhFood.Application.Common.Models;

namespace BinhDinhFood.Domain.Entities;

public class Blog : BaseModel
{
    public string? Name { get; set; }
    public string? Content { get; set; }
    public List<Media>? Images { get; set; }
    public DateTime DateCreated { get; set; }
}
