namespace CQRS.Domain.Entities
{
    public class Comment : BaseEntity
    {
        public int PostId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Body { get; set; }

        #region Navigation properties

        public Post Post { get; set; }

        #endregion Navigation properties
    }
}
