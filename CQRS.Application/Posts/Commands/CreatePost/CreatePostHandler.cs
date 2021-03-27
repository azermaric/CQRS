using CQRS.Data;
using CQRS.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS.Application.Posts.Commands.CreatePost
{
    public class CreatePostHandler : IRequestHandler<CreatePostCommand, CreatePostDto>
    {
        private readonly ApplicationDbContext _dbContext;

        public CreatePostHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<CreatePostDto> Handle(CreatePostCommand request, CancellationToken cancellationToken)
        {
            var post = new Post()
            {
                UserId = 1,//TODO: Get logged user from request
                Title = request.Title,
                Body = request.Body
            };

            _dbContext.Posts.Add(post);
            await _dbContext.SaveChangesAsync();

            var result = new CreatePostDto()
            {
                Id = post.Id
            };

            return result;
        }
    }
}
