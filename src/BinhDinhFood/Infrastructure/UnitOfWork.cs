using BinhDinhFood.Application;
using BinhDinhFood.Application.Common.Exceptions;
using BinhDinhFood.Application.Repositories;
using BinhDinhFood.Infrastructure.Data;
using BinhDinhFood.Infrastructure.Interface;

namespace BinhDinhFood.Infrastructure;

public class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationDbContext _context;

    public IBookRepository BookRepository { get; }
    public IRefreshTokenRepository RefreshTokenRepository { get; }
    public IMediaRepository MediaRepository { get; }
    public IForgotPasswordRepository ForgotPasswordRepository { get; }
    public IOrderRepository OrderRepository { get; }
    public IOrderDetailRepository OrderDetailRepository { get; }
    public IProductRepository ProductRepository { get; }
    public IProductCategoryRepository ProductCategoryRepository { get; }
    public ICategoryRepository CategoryRepository { get; }
    public IReviewRepository ReviewRepository { get; }
    public IBannerRepository BannerRepository { get; }
    public IFavoriteRepository FavoriteRepository { get; }
    public IBlogRepository BlogRepository { get; }


    public UnitOfWork(ApplicationDbContext dbContext)
    {
        _context = dbContext;
        BookRepository = new BookRepository(_context);
        RefreshTokenRepository = new RefreshTokenRepository(_context);
        MediaRepository = new MediaRepository(_context);
        ForgotPasswordRepository = new ForgotPasswordRepository(_context);
        OrderRepository = new OrderRepository(_context);
        OrderDetailRepository = new OrderDetailRepository(_context);
        ProductRepository = new ProductRepository(_context);
        ProductCategoryRepository = new ProductCategoryRepository(_context);
        CategoryRepository = new CategoryRepository(_context);
        ReviewRepository = new ReviewRepository(_context);
        BannerRepository = new BannerRepository(_context);
        FavoriteRepository = new FavoriteRepository(_context);
        BlogRepository = new BlogRepository(_context);
    }
    public async Task SaveChangesAsync(CancellationToken token)
        => await _context.SaveChangesAsync(token);

    public async Task ExecuteTransactionAsync(Action action, CancellationToken token)
    {
        using var transaction = await _context.Database.BeginTransactionAsync(token);
        try
        {
            action();
            await _context.SaveChangesAsync(token);
            await transaction.CommitAsync(token);
        }
        catch (Exception ex)
        {
            await transaction.RollbackAsync(token);
            throw TransactionException.TransactionNotExecuteException(ex);
        }
    }

    public async Task ExecuteTransactionAsync(Func<Task> action, CancellationToken token)
    {
        using var transaction = await _context.Database.BeginTransactionAsync(token);
        try
        {
            await action();
            await _context.SaveChangesAsync(token);
            await transaction.CommitAsync(token);
        }
        catch (Exception ex)
        {
            await transaction.RollbackAsync(token);
            throw TransactionException.TransactionNotExecuteException(ex);
        }
    }
}
