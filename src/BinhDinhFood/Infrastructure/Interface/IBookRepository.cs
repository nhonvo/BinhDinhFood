namespace BinhDinhFood.Infrastructure.Interface;

public interface IBookRepository : IGenericRepository<Book> { }
public interface IOrderRepository : IGenericRepository<Order> { }
public interface IOrderDetailRepository : IGenericRepository<OrderDetail> { }
public interface IProductRepository : IGenericRepository<Product> { }
public interface IProductCategoryRepository : IGenericRepository<ProductCategory> { }
public interface ICategoryRepository : IGenericRepository<Category> { }
public interface IReviewRepository : IGenericRepository<Review> { }
public interface IBannerRepository : IGenericRepository<Banner> { }
public interface IFavoriteRepository : IGenericRepository<Favorite> { }
public interface IBlogRepository : IGenericRepository<Blog> { }
