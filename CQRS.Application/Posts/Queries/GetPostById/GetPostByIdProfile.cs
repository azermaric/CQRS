using AutoMapper;
using CQRS.Domain.Entities;

namespace CQRS.Application.Posts.Queries.GetPostById
{
    public class GetPostByIdProfile : Profile
    {
        public GetPostByIdProfile()
        {
            CreateMap<Post, GetPostByIdDto>()
               .ForMember(dest => dest.User, opt => opt.MapFrom(src => src.User));
            CreateMap<User, GetPostByIdUserDto>();
        }
    }
}
