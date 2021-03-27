namespace CQRS.Application.Posts.Queries.GetAllPosts
{
    public class GetAllPostsDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public GetAllPostsUserDto User { get; set; }
    }

    public class GetAllPostsUserDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
