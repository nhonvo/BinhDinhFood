namespace BinhDinhFood.Application.Common.Models.Product;
// TODO: change the product entity
public class ProductResponse
{
    public int? _id { get; set; } // change for fe due to fe use _id too much
    public string? Name { get; set; }
    public decimal? Price { get; set; }
    public int? Quality { get; set; }
    public int? Discount { get; set; } // replace -> OffPrice
    public int? Rating { get; set; }
    public string? Poster { get; set; }
    public int? OffPrice { get; set; } // new
    public DateTime? DateCreated { get; set; }
    public DateTime? DateUpdated { get; set; } // new
    public List<string>? Category { get; set; }
}

public class ProductDetailResponse : ProductResponse
{
    public List<Media> Gallery { get; set; } // new
    public string? Description { get; set; }
    public List<ReviewResponse> Reviews { get; set; }
}

public class ReviewResponse
{
    public int? Id { get; set; }
    public int? Rating { get; set; }
    public string? Comment { get; set; }
    public DateTime? DateCreated { get; set; }
}