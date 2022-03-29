using Microsoft.Azure.Cosmos;
using Udea.Chaos.Owner.Domain.Entities;

namespace Udea.Chaos.Owner.Infrastructure
{
    public interface IContainerContext<T> where T : EntityBase<string>
    {
        string ContainerName { get; }

        string GenerateId(T entity);

        PartitionKey ResolvePartitionKey(string entityId);
    }
}