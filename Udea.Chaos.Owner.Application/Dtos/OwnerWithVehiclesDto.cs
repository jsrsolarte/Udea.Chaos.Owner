namespace Udea.Chaos.Owner.Application.Dtos
{
    public record OwnerWithVehiclesDto(string Id, string Identificacion, string Nombres, DateTime FechaNacimiento, string Direccion, string Email, IEnumerable<VehicleDto> Vehicles) : OwnerDto(Id, Identificacion, Nombres, FechaNacimiento, Direccion, Email);
}