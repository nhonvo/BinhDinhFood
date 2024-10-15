using System.Linq.Expressions;
using BinhDinhFood.Application.Common.Interfaces;
using BinhDinhFood.Application.Common.Models;
using BinhDinhFood.Application.Common.Models.Product;
using Microsoft.EntityFrameworkCore;

namespace BinhDinhFood.Application.Services;

public class ProductService(IUnitOfWork unitOfWork) : IProductService
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    public async Task<ProductResponse> Get(int id)
    {
        var product = await _unitOfWork.ProductRepository.FirstOrDefaultAsync(
            filter: x => x.Id == id,
            include: x => x.Include(x => x.Category));

        return MapToProductResponse(product);
    }

    public async Task<Pagination<ProductResponse>> Get(int pageIndex, int pageSize, bool ascending, string orderBy = "", string filter = "")
    {
        Expression<Func<Product, object>>? orderByExpression = null;
        if (!string.IsNullOrEmpty(orderBy))
        {
            orderByExpression = orderBy.ToLower() switch
            {
                "name" => x => x.Name,
                "date" => x => x.DateCreated,
                "price" => x => x.Price,
                "rate" => x => x.Rating,
                _ => x => x.Id
            };
        }

        // Fetch paginated product data
        var products = await _unitOfWork.ProductRepository.ToPagination(
            pageIndex: pageIndex,
            pageSize: pageSize,
            filter: x => x.Name.Contains(filter, StringComparison.CurrentCultureIgnoreCase),
            include: x => x.Include(x => x.Category),
            orderBy: orderByExpression,
            ascending: ascending);

        // Map to ProductResponse and return pagination result
        var result = new Pagination<ProductResponse>
        {
            Items = products.Items.Select(MapToProductResponse).ToList(),
            TotalItemsCount = products.TotalItemsCount,
            PageSize = pageSize,
            PageIndex = pageIndex
        };

        return result;
    }

    private ProductResponse MapToProductResponse(Product product)
    {
        return new ProductResponse
        {
            Name = product.Name,
            Price = product.Price,
            Description = product.Description,
            Amount = product.Amount,
            Discount = product.Discount,
            Rating = product.Rating,
            Image = product.Image,
            DateCreated = product.DateCreated,
            CategoryName =
            [
                product.Category?.Name ?? "Uncategorized"
            ]
        };
    }


    // public async Task Add(BookDTO request, CancellationToken token)
    // {
    //     var book = _mapper.Map<Book>(request);
    //     await _unitOfWork.ExecuteTransactionAsync(async () => await _unitOfWork.ProductRepository.AddAsync(book), token);
    // }

    // public async Task Update(Book request, CancellationToken token)
    // {
    //     var book = await _unitOfWork.ProductRepository.FirstOrDefaultAsync(x => x.Id == request.Id);
    //     await _unitOfWork.ExecuteTransactionAsync(() => _unitOfWork.ProductRepository.Update(book), token);
    // }

    public async Task Delete(int id, CancellationToken token)
    {

        var product = await _unitOfWork.ProductRepository.FirstOrDefaultAsync(x => x.Id == id);
        await _unitOfWork.ExecuteTransactionAsync(() => _unitOfWork.ProductRepository.Delete(product), token);
    }
}
