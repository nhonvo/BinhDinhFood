using BinhDinhFood.Application.Common.Models;
using BinhDinhFood.Domain.Entities.Auth;

namespace BinhDinhFood.Domain.Entities;

public class Order : BaseModel
{
    public DateTime DayOrder { get; set; }
    public DateTime DayDelivery { get; set; }
    public bool PaidState { get; set; }
    public bool DeliveryState { get; set; }
    public decimal TotalMoney { get; set; }
    public Guid CustomerId { get; set; }
    public ApplicationUser Customer { get; set; }
    public virtual ICollection<OrderDetail> OrderDetails { get; set; }
}
