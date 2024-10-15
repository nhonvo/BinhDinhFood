using BinhDinhFood.Application.Common.Models;

namespace BinhDinhFood.Domain.Entities;

public class Category : BaseModel
{
    public string Name { get; set; }
    public DateTime CategoryDateCreated { get; set; } = DateTime.Now;
    public ICollection<Product> Products { get; set; }
}
