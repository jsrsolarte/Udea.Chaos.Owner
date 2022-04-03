using MediatR;
using Udea.Chaos.Owner.Application.Dtos;
using Udea.Chaos.Owner.Application.Extensions;
using Udea.Chaos.Owner.Application.Ports;
using Udea.Chaos.Owner.Domain.Ports;

namespace Udea.Chaos.Owner.Application.Queries
{
    public class GetOwnerDetailHandler : IRequestHandler<GetOwnerDetail, OwnerWithVehiclesDto?>
    {
        private readonly IVehicleService _vehicleService;
        private readonly IOwnerRepository _ownerRepository;

        public GetOwnerDetailHandler(IVehicleService vehicleService, IOwnerRepository ownerRepository)
        {
            _vehicleService = vehicleService;
            _ownerRepository = ownerRepository;
        }

        public async Task<OwnerWithVehiclesDto?> Handle(GetOwnerDetail request, CancellationToken cancellationToken)
        {
            var vehicles = await _vehicleService.GetVehicles(request.Id);
            var owner = await _ownerRepository.GetByIdAsync(request.Id.ToString(), cancellationToken);
            if (owner == null) return null;
            return owner.ToDto(vehicles);
        }
    }
}