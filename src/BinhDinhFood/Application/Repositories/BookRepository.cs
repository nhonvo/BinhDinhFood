using BinhDinhFood.Infrastructure.Data;
using BinhDinhFood.Infrastructure.Interface;

namespace BinhDinhFood.Application.Repositories;

public class BookRepository(ApplicationDbContext context) : GenericRepository<Book>(context), IBookRepository
{
}
