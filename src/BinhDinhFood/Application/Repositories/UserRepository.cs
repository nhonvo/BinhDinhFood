using BinhDinhFood.Domain.Entities.Auth;
using BinhDinhFood.Infrastructure.Data;
using BinhDinhFood.Infrastructure.Interface;

namespace BinhDinhFood.Application.Repositories;

public class UserRepository(ApplicationDbContext context) : GenericRepository<User>(context), IUserRepository { }
