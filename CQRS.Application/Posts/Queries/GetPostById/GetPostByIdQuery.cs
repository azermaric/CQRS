using MediatR;

namespace CQRS.Application.Posts.Queries.GetPostById
{
    public class GetPostByIdQuery : IRequest<GetPostByIdDto>
    {
        public GetPostByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; }
    }
}
