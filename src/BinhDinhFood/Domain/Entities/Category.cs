using BinhDinhFood.Application.Common.Models;

namespace BinhDinhFood.Domain.Entities;

public class Category : BaseModel
{
    public string Name { get; set; }
    public DateTime DateCreated { get; set; } = DateTime.Now;
    public ICollection<ProductCategory> ProductCategories { get; set; }
}
