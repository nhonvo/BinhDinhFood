using BinhDinhFood.Application.Common.Models;

namespace BinhDinhFood.Domain.Entities;
public class OrderDetail : BaseModel
{
    public decimal UnitPrice { get; set; }
    public int Quantity { get; set; }
    
    public int OrderId { get; set; }
    public virtual Order Order { get; set; }
    
    public int ProductId { get; set; }
    public virtual Product Product { get; set; }
}
