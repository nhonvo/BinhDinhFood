using BinhDinhFood.Application.Common.Models;
using BinhDinhFood.Domain.Entities.Auth;

namespace BinhDinhFood.Domain.Entities;

public class Favorite : BaseModel
{
    public int ProductId { get; set; }
    public Guid CustomerId { get; set; }
    public DateTime DateCreated { get; set; } = DateTime.Now;
    public Product? Product { get; set; }
    public ApplicationUser? Customer { get; set; }
}
