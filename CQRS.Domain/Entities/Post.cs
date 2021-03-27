namespace CQRS.Domain.Entities
{
    public class Post : BaseEntity
    {
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }

        #region Navigation properties

        public User User { get; set; }

        #endregion Navigation properties
    }
}
