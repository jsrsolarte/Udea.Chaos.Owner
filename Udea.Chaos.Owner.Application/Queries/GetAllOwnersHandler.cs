using MediatR;
using Udea.Chaos.Owner.Application.Dtos;
using Udea.Chaos.Owner.Application.Extensions;
using Udea.Chaos.Owner.Domain.Ports;

namespace Udea.Chaos.Owner.Application.Queries
{
    public class GetAllOwnersHandler : IRequestHandler<GetAllOwners, IEnumerable<OwnerDto>>
    {
        private readonly IOwnerRepository _ownerRepository;

        public GetAllOwnersHandler(IOwnerRepository ownerRepository)
        {
            _ownerRepository = ownerRepository;
        }

        public async Task<IEnumerable<OwnerDto>> Handle(GetAllOwners request, CancellationToken cancellationToken)
        {
            var owners = await _ownerRepository.ListAsync();
            return owners.Select(_ => _.ToDto());
        }
    }
}