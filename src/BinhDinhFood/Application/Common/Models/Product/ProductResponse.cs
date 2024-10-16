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
    public DateTime? DateCreated { get; set; }
    public List<string>? Category { get; set; }
    public List<ReviewResponse> Reviews { get; set; }
}

public class ReviewResponse
{
    public int? Id { get; set; }
    public int? Rating { get; set; }
    public string? Comment { get; set; }
    public DateTime? DateCreated { get; set; }
}