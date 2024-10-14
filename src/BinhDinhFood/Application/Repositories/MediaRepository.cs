using BinhDinhFood.Infrastructure.Data;
using BinhDinhFood.Infrastructure.Interface;

namespace BinhDinhFood.Application.Repositories;

public class MediaRepository(ApplicationDbContext context) : GenericRepository<Media>(context), IMediaRepository { }
