using Udea.Chaos.Owner.Domain.Ports;

namespace Udea.Chaos.Owner.Infrastructure.Adapters
{
    public class OwnerRepository : CosmosRepository<Domain.Entities.Owner>, IOwnerRepository
    {
        public OwnerRepository(ICosmosContainerFactory cosmosDbContainerFactory) : base(cosmosDbContainerFactory)
        {
        }
    }
}