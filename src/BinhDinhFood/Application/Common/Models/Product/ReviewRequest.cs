namespace BinhDinhFood.Application.Common.Models.Product;

public class ReviewRequest
{
    public int? Stars { get; set; }
    public string? Content { get; set; }
    public int ProductId { get; set; }
}