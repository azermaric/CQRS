using CQRS.Application.Posts.Commands.CreatePost;
using CQRS.Application.Posts.Queries.GetAllPosts;
using CQRS.Application.Posts.Queries.GetPostById;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CQRS.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PostController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PostController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetAllPostsDto>>> GetAllPostsAsync()
        {
            var response = await _mediator.Send(new GetAllPostsQuery());

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<GetPostByIdDto>>> GetPostByIdAsync(int id)
        {
            var response = await _mediator.Send(new GetPostByIdQuery(id));

            if (response == null)
                return NotFound();

            return Ok(response);
        }

        [HttpPost()]
        public async Task<ActionResult<IEnumerable<GetPostByIdDto>>> CreateAsync(CreatePostCommand command)
        {
            var response = await _mediator.Send(command);

            return Ok(response);
        }
    }
}
