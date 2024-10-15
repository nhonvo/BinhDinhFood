using BinhDinhFood.Infrastructure.Data;
using BinhDinhFood.Infrastructure.Interface;

namespace BinhDinhFood.Application.Repositories;

public class BookRepository(ApplicationDbContext context) : GenericRepository<Book>(context), IBookRepository { }
public class OrderRepository(ApplicationDbContext context) : GenericRepository<Order>(context), IOrderRepository { }
public class OrderDetailRepository(ApplicationDbContext context) : GenericRepository<OrderDetail>(context), IOrderDetailRepository { }
public class ProductRepository(ApplicationDbContext context) : GenericRepository<Product>(context), IProductRepository { }
public class CategoryRepository(ApplicationDbContext context) : GenericRepository<Category>(context), ICategoryRepository { }
public class ProductRatingRepository(ApplicationDbContext context) : GenericRepository<ProductRating>(context), IProductRatingRepository { }
public class BannerRepository(ApplicationDbContext context) : GenericRepository<Banner>(context), IBannerRepository { }
public class FavoriteRepository(ApplicationDbContext context) : GenericRepository<Favorite>(context), IFavoriteRepository { }
public class BlogRepository(ApplicationDbContext context) : GenericRepository<Blog>(context), IBlogRepository { }
