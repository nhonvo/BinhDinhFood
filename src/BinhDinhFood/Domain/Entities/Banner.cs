using BinhDinhFood.Application.Common.Models;

namespace BinhDinhFood.Domain.Entities;

public class Banner : BaseModel
{
    public string? Name { get; set; }
    public int? Discount { get; set; }
    public decimal? Price { get; set; }
    public string? Description { get; set; }
    public Media? Image { get; set; }
    public DateTime? DateCreated { get; set; }
}
