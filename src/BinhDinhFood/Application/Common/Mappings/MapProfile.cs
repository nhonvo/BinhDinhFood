using AutoMapper;
using BinhDinhFood.Application.Common.Models.Book;

namespace BinhDinhFood.Application.Common.Mappings;

public class MapProfile : Profile
{
    public MapProfile()
    {
        CreateMap<Book, BookDTO>().ReverseMap();
    }
}
