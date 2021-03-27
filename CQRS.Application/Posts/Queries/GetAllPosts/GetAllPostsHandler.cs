using AutoMapper.QueryableExtensions;
using CQRS.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS.Application.Posts.Queries.GetAllPosts
{
    public class GetAllPostsHandler : IRequestHandler<GetAllPostsQuery, IEnumerable<GetAllPostsDto>>
    {
        private readonly ApplicationDbContext _dbContext;

        public GetAllPostsHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<GetAllPostsDto>> Handle(GetAllPostsQuery request, CancellationToken cancellationToken)
        {
            var result = await _dbContext.Posts
                .ProjectTo<GetAllPostsDto>(ObjectMapper.Mapper.ConfigurationProvider)
                .ToListAsync();

            return result;
        }
    }
}
