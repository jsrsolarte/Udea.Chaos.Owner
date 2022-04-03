namespace Udea.Chaos.Owner.Application.Dtos
{
    public record VehicleDto(
        Guid Id,
        string Plate,
        string Brand,
        string Model,
        string Type,
        string Vin,
        int Year
    );
}