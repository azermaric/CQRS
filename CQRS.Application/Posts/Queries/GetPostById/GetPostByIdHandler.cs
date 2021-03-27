using AutoMapper.QueryableExtensions;
using CQRS.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;


namespace CQRS.Application.Posts.Queries.GetPostById
{
    public class GetPostByIdHandler : IRequestHandler<GetPostByIdQuery, GetPostByIdDto>
    {
        private readonly ApplicationDbContext _dbContext;

        public GetPostByIdHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<GetPostByIdDto> Handle(GetPostByIdQuery request, CancellationToken cancellationToken)
        {
            var result = await _dbContext.Posts
                .ProjectTo<GetPostByIdDto>(ObjectMapper.Mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(c => c.Id == request.Id, cancellationToken: cancellationToken);

            return result;
        }
    }
}
