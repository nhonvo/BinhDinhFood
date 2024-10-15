namespace BinhDinhFood.Application.Common.Models.Product;

public class ProductResponse
{
    public int? Id { get; set; }
    public string? Name { get; set; }
    public decimal? Price { get; set; }
    public string? Description { get; set; }
    public int? Amount { get; set; }
    public int? Discount { get; set; }
    public int? Rating { get; set; }
    public string? Image { get; set; }
    public DateTime? DateCreated { get; set; } = DateTime.Now;
    public List<string>? CategoryName { get; set; }
}