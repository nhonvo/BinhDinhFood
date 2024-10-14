using BinhDinhFood.Application.Common.Models;

namespace BinhDinhFood.Domain.Entities;

public class Book : BaseModel
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public double? Price { get; set; }
}
