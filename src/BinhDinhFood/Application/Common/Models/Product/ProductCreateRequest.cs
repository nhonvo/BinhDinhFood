namespace BinhDinhFood.Application.Common.Models.Product;

public class ProductCreateRequest
{
    public string? Name { get; set; }
    public decimal? Price { get; set; }
    public string? Description { get; set; }
    public int? Amount { get; set; }
    public int? Discount { get; set; }
    public string? Image { get; set; }
    public List<ProductCategoryRequest>? Categories { get; set; }
}

public class ProductCategoryRequest
{
    public int? Id { get; set; }
    public string? Name { get; set; }
}

