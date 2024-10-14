using BinhDinhFood.Infrastructure.Interface;

namespace BinhDinhFood.Application;

public interface IUnitOfWork
{
    IUserRepository UserRepository { get; }
    IBookRepository BookRepository { get; }
    IRefreshTokenRepository RefreshTokenRepository { get; }
    IMediaRepository MediaRepository { get; }
    IForgotPasswordRepository ForgotPasswordRepository { get; }
    Task SaveChangesAsync(CancellationToken token);
    Task ExecuteTransactionAsync(Action action, CancellationToken token);
    Task ExecuteTransactionAsync(Func<Task> action, CancellationToken token);
}
