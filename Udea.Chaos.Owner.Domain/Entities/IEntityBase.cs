namespace Udea.Chaos.Owner.Domain.Entities
{
    public interface IEntityBase<out T>
    {
        T Id { get; }
    }
}