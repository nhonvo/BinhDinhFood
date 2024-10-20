using BinhDinhFood.Application.Common.Interfaces;
using BinhDinhFood.Application.Common.Models.Product;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BinhDinhFood.Web.Controller;

public class ProductController(IProductService productService) : BaseController
{
    private readonly IProductService _productService = productService;
    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
           => Ok(await _productService.Get(id));

    /// <param name="pageIndex">0</param>
    /// <param name="pageSize"><10/param>
    /// <param name="ascending">boolean</param>
    /// <param name="orderBy">name, date, price, rate</param>
    /// <param name="filter">name</param>
    /// <returns></returns>
    [HttpGet]
    public async Task<IActionResult> Get(int pageIndex = 0, int pageSize = 10, bool ascending = false, string orderBy = "", string filter = "")
        => Ok(await _productService.Get(pageIndex, pageSize, ascending, orderBy, filter));

    [HttpPost("review")]
    // [Authorize(Policy = "user_write")]
    public async Task<IActionResult> Review(ReviewRequest request)
    {
        await _productService.ReviewProduct(request);
        return NoContent();
    }

    [HttpPost]
    [Authorize]
    [Authorize(Roles = "Admin")]
    // [Authorize(Policy = "user_write")]
    public async Task<IActionResult> Create(ProductCreateRequest request, CancellationToken cancellationToken)
    {
        await _productService.Create(request, cancellationToken);
        return NoContent();
    }

    [HttpPut]
    [Authorize(Roles = "Admin")]
    // [Authorize(Policy = "user_write")]
    public async Task<IActionResult> Update(ProductUpdateRequest request, CancellationToken cancellationToken)
    {
        await _productService.Update(request, cancellationToken);
        return NoContent();
    }

    [HttpDelete]
    [Authorize(Roles = "Admin")]
    // [Authorize(Policy = "user_write")]
    public async Task<IActionResult> Delete(int id, CancellationToken cancellationToken)
    {
        await _productService.Delete(id, cancellationToken);
        return NoContent();
    }
}
