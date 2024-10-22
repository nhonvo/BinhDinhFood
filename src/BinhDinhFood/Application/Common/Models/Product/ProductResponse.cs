namespace BinhDinhFood.Application.Common.Models.Product;

public class ProductResponse
{
    public int? _id { get; set; } 
    public string? Name { get; set; }
    public decimal? Price { get; set; }
    public int? Quality { get; set; }
    public int? Rating { get; set; }
    public string? Poster { get; set; }
    public int? OffPrice { get; set; } 
    public DateTime? DateCreated { get; set; }
    public List<string>? Category { get; set; }
}

public class ProductDetailResponse : ProductResponse
{
    public List<Media>? Images { get; set; } // new
    public string? Description { get; set; }
    public List<ReviewResponse>? Reviews { get; set; }
}

public class ReviewResponse
{
    public int? Id { get; set; }
    public int? Rating { get; set; }
    public string? Comment { get; set; }
    public DateTime? DateCreated { get; set; }
}