using BinhDinhFood.Infrastructure.Data;
using BinhDinhFood.Infrastructure.Interface;

namespace BinhDinhFood.Application.Repositories;

public class RefreshTokenRepository(ApplicationDbContext context) : GenericRepository<RefreshToken>(context), IRefreshTokenRepository { }
