namespace Udea.Chaos.Owner.Application.Dtos
{
    public record JourneyDto(double Kilometers, double PricePerKilometer, DateTime InitialDateTime, DateTime FinalDateTime, Guid VehicleId, string UserEmail);
}