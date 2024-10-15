namespace BinhDinhFood.Domain.Entities;

public class ProductCategory
{
    public int CategoryId { get; set; }
    public int ProductId { get; set; }
    public Product Product { get; set; }
    public Category Category { get; set; }
}
