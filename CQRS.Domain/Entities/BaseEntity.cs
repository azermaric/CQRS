namespace CQRS.Domain.Entities
{
    public interface IEntity<TKey>
    {
        public TKey Id { get; set; }
    }

    /// <summary>
    /// Base implementation used by most of the entities
    /// </summary>
    public abstract class BaseEntity : BaseEntity<int>
    {
    }

    /// <summary>
    /// Generic implementation
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    public abstract class BaseEntity<TKey> : IEntity<TKey>
    {
        public TKey Id { get; set; }
    }
}
