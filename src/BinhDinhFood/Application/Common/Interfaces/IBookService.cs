using BinhDinhFood.Application.Common.Models;
using BinhDinhFood.Application.Common.Models.Book;

namespace BinhDinhFood.Application.Common.Interfaces;

public interface IBookService
{
    Task<Pagination<Book>> Get(int pageIndex, int pageSize);
    Task<Book> Get(int id);
    Task Add(BookDTO request, CancellationToken token);
    Task Update(Book request, CancellationToken token);
    Task Delete(int id, CancellationToken token);
}
