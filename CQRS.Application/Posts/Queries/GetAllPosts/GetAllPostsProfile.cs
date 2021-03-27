using AutoMapper;
using CQRS.Domain.Entities;

namespace CQRS.Application.Posts.Queries.GetAllPosts
{
    public class GetAllPostsProfile : Profile
    {
        public GetAllPostsProfile()
        {
            CreateMap<Post, GetAllPostsDto>()
                .ForMember(dest => dest.User, opt => opt.MapFrom(src => src.User));
            CreateMap<User, GetAllPostsUserDto>();
        }
    }
}
