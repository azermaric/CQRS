using MediatR;

namespace CQRS.Application.Posts.Commands.CreatePost
{
    public class CreatePostCommand : IRequest<CreatePostDto>
    {
        public string Title { get; set; }
        public string Body { get; set; }
    }
}
