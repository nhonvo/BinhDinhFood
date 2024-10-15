using AutoMapper;
using BinhDinhFood.Application.Common.Models.Book;
using BinhDinhFood.Application.Common.Models.User;
using BinhDinhFood.Domain.Entities.Auth;

namespace BinhDinhFood.Application.Common.Mappings;

public class MapProfile : Profile
{
    public MapProfile()
    {
        CreateMap<Book, BookDTO>().ReverseMap();

        CreateMap<User, UserSignInRequest>().ReverseMap();
        CreateMap<User, UserSignInResponse>().ReverseMap();
        CreateMap<User, UserSignUpRequest>().ReverseMap();
        CreateMap<User, UserSignUpResponse>().ReverseMap();
        CreateMap<User, UserProfileResponse>().ReverseMap();
    }
}
