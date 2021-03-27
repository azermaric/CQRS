namespace CQRS.Application.Posts.Queries.GetPostById
{
    public class GetPostByIdDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public GetPostByIdUserDto User { get; set; }
    }

    public class GetPostByIdUserDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
