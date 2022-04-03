using Udea.Chaos.Owner.Application.Dtos;

namespace Udea.Chaos.Owner.Application.Ports
{
    public interface IJourneyService
    {
        Task<IEnumerable<JourneyDto>> GetJourneys(Guid vehicleId);
    }
}