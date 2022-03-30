using Udea.Chaos.Owner.Application.Dtos;

namespace Udea.Chaos.Owner.Application.Ports
{
    public interface IVehicleService
    {
        Task<IEnumerable<VehicleDto>> GetVehicles(Guid ownerId);
    }
}