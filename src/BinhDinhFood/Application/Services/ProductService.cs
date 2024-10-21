using System.Linq.Expressions;
using BinhDinhFood.Application.Common.Interfaces;
using BinhDinhFood.Application.Common.Models;
using BinhDinhFood.Application.Common.Models.Product;
using Microsoft.EntityFrameworkCore;
using BinhDinhFood.Application.Common.Exceptions;

namespace BinhDinhFood.Application.Services;

public class ProductService(IUnitOfWork unitOfWork, ICurrentUser currentUser) : IProductService
{
    private readonly ICurrentUser _currentUser = currentUser;
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    public async Task<ProductDetailResponse> Get(int id)
    {
        var product = await _unitOfWork.ProductRepository.FirstOrDefaultAsync(
            filter: x => x.Id == id,
            include: x => x.Include(x => x.ProductCategories).ThenInclude(x => x.Category).Include(x => x.Reviews));

        return MapToProductDetailResponse(product);
    }

    public async Task<Pagination<ProductResponse>> Get(int pageIndex, int pageSize, bool ascending, string orderBy = "", string filter = "")
    {
        // TODO: calculate the min and max price in paging
        // change the name paging
        // update the filter match with fe && sort 'relevance' | 'new arrivals' | 'price:low' | 'price:high' 

        // public decimal MinPrice { get; set; }
        // public decimal MaxPrice { get; set; }
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
        var normalizeFilter = filter.ToLower();
        // Fetch paginated product data
        var products = await _unitOfWork.ProductRepository.ToPagination(
            pageIndex: pageIndex,
            pageSize: pageSize,
            filter: x => x.Name.ToLower().Contains(normalizeFilter)
                || x.ProductCategories.Select(x => x.Category).Select(x => x.Name).Contains(normalizeFilter),
            include: x => x.Include(x => x.ProductCategories).ThenInclude(x => x.Category),
            orderBy: orderByExpression,
            ascending: ascending);

        // Map to ProductResponse and return pagination result
        var result = new Pagination<ProductResponse>
        {
            Items = products.Items.Select(MapToProductResponse).ToList(),
            TotalPages = products.TotalPages,
            PageSize = pageSize,
            CurrentPage = pageIndex
        };

        return result;
    }

    public async Task ReviewProduct(ReviewRequest request)
    {
        var rateProduct = new Review
        {
            Stars = request.Stars ?? 1,
            Content = request.Content,
            ProductId = request.ProductId,
            CustomerId = new Guid(_currentUser.GetCurrentStringUserId())
        };
        await _unitOfWork.ReviewRepository.AddAsync(rateProduct);
    }
    public async Task Create(ProductCreateRequest request, CancellationToken cancellationToken)
    {
        // Step1: Initialize a new Product
        Product product = new()
        {
            Name = request.Name,
            Price = request.Price ?? 0,
            Description = request.Description,
            Quality = request.Amount ?? 0,
            OffPrice = request.Discount ?? 0,
            Images = [new Media { PathMedia = request.Image }],
            DateCreated = DateTime.Now
        };
        // Step2: Loop through the provided categories in the request
        foreach (var categoryDto in request.Categories)
        {
            Category category;

            if (categoryDto.Id != null)
            {
                // If Id is provided, find the existing category
                category = await _unitOfWork.CategoryRepository.FirstOrDefaultAsync(c => c.Id == categoryDto.Id.Value, null)
                    ?? throw new UserFriendlyException(ErrorCode.NotFound, $"Category with Id {categoryDto.Id.Value} not found.");
                await _unitOfWork.ProductCategoryRepository.AddAsync(new ProductCategory
                {
                    Product = product,
                    CategoryId = category.Id
                });
            }
            else if (!string.IsNullOrEmpty(categoryDto.Name))
            {
                // If only Name is provided, check if it exists, otherwise create a new one
                category = await _unitOfWork.CategoryRepository
                            .FirstOrDefaultAsync(c => c.Name == categoryDto.Name);
                if (category == null)
                {
                    category = new Category
                    {
                        Name = categoryDto.Name,
                        DateCreated = DateTime.Now
                    };

                    // Add the new category to the context
                    await _unitOfWork.CategoryRepository.AddAsync(category);
                }
                // Add the relationship to ProductCategories 
                await _unitOfWork.ProductCategoryRepository.AddAsync(new ProductCategory
                {
                    Product = product,
                    Category = category
                });
            }
            else
            {
                throw new UserFriendlyException(ErrorCode.NotFound, "Either Id or Name must be provided.");
            }
        }
        // Step3: TODO: Provide list image through media entity

        // Add the new product to the context and save changes
        await _unitOfWork.ProductRepository.AddAsync(product);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
    }


    // TODO: BUG update product with category
    public async Task Update(ProductUpdateRequest request, CancellationToken cancellationToken)
    {
        // Step 1: Fetch the existing product
        var existingProduct = await _unitOfWork.ProductRepository
                                .FirstOrDefaultAsync(p => p.Id == request.Id, include: p => p.Include(p => p.ProductCategories))
                                ?? throw new UserFriendlyException(ErrorCode.NotFound, $"Product with Id {request.Id} not found.");

        // Step 2: Update the product details
        existingProduct.Name = request.Name;
        existingProduct.Price = request.Price ?? existingProduct.Price;
        existingProduct.Description = request.Description;
        existingProduct.Quality = request.Amount ?? existingProduct.Quality;
        existingProduct.OffPrice = request.Discount ?? existingProduct.OffPrice;
        existingProduct.Images = [new Media { PathMedia = request.Image }];
        existingProduct.DateUpdated = DateTime.Now;

        // Step 3: Handle Categories (Update existing categories and add new ones)
        var newProductCategories = new List<ProductCategory>();
        if (request.Categories != null)
        {
            foreach (var categoryDto in request.Categories)
            {
                Category category;

                if (!string.IsNullOrEmpty(categoryDto.Name))
                {
                    // If CategoryName is provided, check if it exists, or create a new one
                    category = await _unitOfWork.CategoryRepository.FirstOrDefaultAsync(c => c.Name == categoryDto.Name);
                    if (category == null)
                    {
                        category = new Category
                        {
                            Name = categoryDto.Name,
                            DateCreated = DateTime.Now
                        };

                        await _unitOfWork.CategoryRepository.AddAsync(category);
                        // Add the relationship to ProductCategories
                        newProductCategories.Add(new ProductCategory
                        {
                            ProductId = request.Id, // Use the existing product ID
                            CategoryId = category.Id // newly created category ID
                        });
                    }
                }
            }
        }
        existingProduct.ProductCategories = existingProduct.ProductCategories;

        // Remove old ProductCategories and add the new ones
        _unitOfWork.ProductCategoryRepository.DeleteRange(existingProduct.ProductCategories);
        await _unitOfWork.ProductCategoryRepository.AddRangeAsync(newProductCategories);

        // Step 4: TODO: Handle media/images update logic

        // Step 5: Save the updated product and its associations
        _unitOfWork.ProductRepository.Update(existingProduct);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
    }


    public async Task Delete(int id, CancellationToken token)
    {
        var product = await _unitOfWork.ProductRepository.FirstOrDefaultAsync(x => x.Id == id);
        await _unitOfWork.ExecuteTransactionAsync(() => _unitOfWork.ProductRepository.Delete(product), token);
    }


    private ProductResponse MapToProductResponse(Product product)
    {
        return new ProductResponse
        {
            _id = product.Id,
            Name = product.Name,
            Price = product.Price,
            Quality = product.Quality,
            Discount = product.OffPrice,
            Rating = product.Rating,
            Poster = product.Images[0].PathMedia,
            DateCreated = product.DateCreated,
            Category = product.ProductCategories?.Select(x => x.Category).Select(x => x.Name).ToList(),
        };
    }

    private ProductDetailResponse MapToProductDetailResponse(Product product)
    {
        return new ProductDetailResponse
        {
            _id = product.Id,
            Name = product.Name,
            Price = product.Price,
            Description = product.Description,
            Quality = product.Quality,
            Discount = product.OffPrice,
            Rating = product.Rating,
            Poster = product.Images[0].PathMedia,
            DateCreated = product.DateCreated,
            Category = product.ProductCategories?.Select(x => x.Category).Select(x => x.Name).ToList(),
            Reviews = product.Reviews?.Select(review => new ReviewResponse
            {
                Id = review.Id,
                Rating = review.Stars,
                Comment = review.Content,
                DateCreated = review.DateCreated,
            }).ToList()
        };
    }
}
