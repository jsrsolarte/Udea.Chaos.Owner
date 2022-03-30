using MediatR;
using Udea.Chaos.Owner.Domain.Ports;
using Udea.Chaos.Owner.Domain.Specifications;

namespace Udea.Chaos.Owner.Application.Queries
{
    public class GetAllOwnersHandler : IRequestHandler<GetAllOwners, IEnumerable<Guid>>
    {
        private readonly IOwnerRepository _ownerRepository;

        public GetAllOwnersHandler(IOwnerRepository ownerRepository)
        {
            _ownerRepository = ownerRepository;
        }

        public async Task<IEnumerable<Guid>> Handle(GetAllOwners request, CancellationToken cancellationToken)
        {
            var spec = new GetOwnersIdsSpec();
            var ownersIds = await _ownerRepository.ListAsync(spec, cancellationToken);
            return ownersIds.Select(_ => Guid.Parse(_));
        }
    }
}