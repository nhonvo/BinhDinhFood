using System.ComponentModel.DataAnnotations;
using BinhDinhFood.Application.Common.Models;

namespace BinhDinhFood.Domain.Entities;

public class Product : BaseModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string? Description { get; set; }
    public int Amount { get; set; }
    public int Discount { get; set; }
    public int Rating { get; set; }
    public string? Image { get; set; }// change to list use media entity
    public DateTime DateCreated { get; set; } = DateTime.Now;
    public virtual Category? Category { get; set; }
    public int CategoryId { get; set; }
    public virtual ICollection<OrderDetail>? OrderDetails { get; set; }
    public virtual ICollection<ProductRating>? ProductRatings { get; set; }
    public virtual ICollection<Favorite>? Favorites { get; set; }
}
