using BinhDinhFood.Application.Common.Models;
using BinhDinhFood.Application.Common.Models.Product;

namespace BinhDinhFood.Application.Common.Interfaces;

public interface IProductService
{
    Task<ProductResponse> Get(int id);
    Task<Pagination<ProductResponse>> Get(int pageIndex, int pageSize, bool ascending, string orderBy = "", string filter = "");
    Task Delete(int id, CancellationToken token);
}
