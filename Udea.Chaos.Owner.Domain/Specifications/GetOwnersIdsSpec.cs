using Ardalis.Specification;

namespace Udea.Chaos.Owner.Domain.Specifications
{
    public class GetOwnersIdsSpec : Specification<Entities.Owner, string>
    {
        public GetOwnersIdsSpec()
        {
            Query.Select(_ => _.Id);
        }
    }
}