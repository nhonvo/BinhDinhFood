using BinhDinhFood.Infrastructure.Data;
using BinhDinhFood.Infrastructure.Interface;

namespace BinhDinhFood.Application.Repositories;

public class ForgotPasswordRepository(ApplicationDbContext context) : GenericRepository<ForgotPassword>(context), IForgotPasswordRepository { }
