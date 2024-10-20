using BinhDinhFood.Application.Common.Models;
using BinhDinhFood.Application.Common.Models.Product;

namespace BinhDinhFood.Application.Common.Interfaces;

public interface IProductService
{
    Task<ProductDetailResponse> Get(int id);
    Task<Pagination<ProductResponse>> Get(int pageIndex, int pageSize, bool ascending, string orderBy = "", string filter = "");
    Task Create(ProductCreateRequest request, CancellationToken cancellationToken);
    Task Update(ProductUpdateRequest request, CancellationToken cancellationToken);
    Task Delete(int id, CancellationToken token);
    Task ReviewProduct(ReviewRequest request);
}
