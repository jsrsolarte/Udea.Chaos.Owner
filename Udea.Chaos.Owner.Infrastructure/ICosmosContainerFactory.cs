using Microsoft.Azure.Cosmos;

namespace Udea.Chaos.Owner.Infrastructure
{
    public interface ICosmosContainerFactory
    {
        Container GetContainer(string containerName);
    }
}