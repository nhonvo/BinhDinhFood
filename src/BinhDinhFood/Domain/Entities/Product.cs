using BinhDinhFood.Application.Common.Models;

namespace BinhDinhFood.Domain.Entities;

public class Product : BaseModel
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string? Description { get; set; }
    public int Amount { get; set; }
    public int Discount { get; set; }
    public int Rating { get; set; }
    public string? Image { get; set; }// change to list use media entity
    public DateTime DateCreated { get; set; }
    public DateTime? DateUpdated { get; set; }
    public virtual ICollection<ProductCategory>? ProductCategories { get; set; }
    public virtual ICollection<OrderDetail>? OrderDetails { get; set; }
    public virtual ICollection<Review>? Reviews { get; set; }
    public virtual ICollection<Favorite>? Favorites { get; set; }
}
