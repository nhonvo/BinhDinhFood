using BinhDinhFood.Infrastructure.Interface;

namespace BinhDinhFood.Application;

public interface IUnitOfWork
{
    IBookRepository BookRepository { get; }
    IRefreshTokenRepository RefreshTokenRepository { get; }
    IMediaRepository MediaRepository { get; }
    IForgotPasswordRepository ForgotPasswordRepository { get; }
    IOrderRepository OrderRepository { get; }
    IOrderDetailRepository OrderDetailRepository { get; }
    IProductRepository ProductRepository { get; }
    IProductCategoryRepository ProductCategoryRepository { get; }
    ICategoryRepository CategoryRepository { get; }
    IReviewRepository ReviewRepository { get; }
    IBannerRepository BannerRepository { get; }
    IFavoriteRepository FavoriteRepository { get; }
    IBlogRepository BlogRepository { get; }
    Task SaveChangesAsync(CancellationToken token);
    Task ExecuteTransactionAsync(Action action, CancellationToken token);
    Task ExecuteTransactionAsync(Func<Task> action, CancellationToken token);
}
