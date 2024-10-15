using BinhDinhFood.Application.Common.Models;
using BinhDinhFood.Domain.Entities.Auth;

namespace BinhDinhFood.Domain.Entities;

public class Review : BaseModel
{
    public int Stars { get; set; }
    public string? Content { get; set; }
    public DateTime DateCreated { get; set; } = DateTime.Now;

    public int ProductId { get; set; }
    public Product Product { get; set; }

    public Guid CustomerId { get; set; }
    public ApplicationUser Customer { get; set; }
}
