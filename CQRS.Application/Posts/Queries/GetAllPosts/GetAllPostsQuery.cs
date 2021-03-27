using MediatR;
using System.Collections.Generic;

namespace CQRS.Application.Posts.Queries.GetAllPosts
{
    public class GetAllPostsQuery : IRequest<IEnumerable<GetAllPostsDto>>
    {

    }
}
