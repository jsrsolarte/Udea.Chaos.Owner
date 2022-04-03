using MediatR;
using Udea.Chaos.Owner.Application.Dtos;
using Udea.Chaos.Owner.Application.Extensions;
using Udea.Chaos.Owner.Application.Ports;
using Udea.Chaos.Owner.Domain.Ports;

namespace Udea.Chaos.Owner.Application.Queries
{
    public class GetOwnerDetailJourneysHandler : IRequestHandler<GetOwnerDetailJourneys, OwnerWithJourneysDto?>
    {
        private readonly IVehicleService _vehicleService;
        private readonly IOwnerRepository _ownerRepository;
        private readonly IJourneyService _journeyService;

        public GetOwnerDetailJourneysHandler(IVehicleService vehicleService, IOwnerRepository ownerRepository, IJourneyService journeyService)
        {
            _vehicleService = vehicleService;
            _ownerRepository = ownerRepository;
            _journeyService = journeyService;
        }

        public async Task<OwnerWithJourneysDto?> Handle(GetOwnerDetailJourneys request, CancellationToken cancellationToken)
        {
            var vehicles = await _vehicleService.GetVehicles(request.Id);
            var journeys = new List<JourneyDto>();
            foreach (var vehicle in vehicles)
            {
                journeys.AddRange(await _journeyService.GetJourneys(vehicle.Id));
            }
            var owner = await _ownerRepository.GetByIdAsync(request.Id.ToString(), cancellationToken);
            if (owner == null) return null;
            return owner.ToDto(journeys);
        }
    }
}