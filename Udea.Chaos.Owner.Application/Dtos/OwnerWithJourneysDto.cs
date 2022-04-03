namespace Udea.Chaos.Owner.Application.Dtos
{
    public record OwnerWithJourneysDto(string Id, string Identificacion, string Nombres, DateTime FechaNacimiento, string Direccion, string Email, IEnumerable<JourneyDto> Journeys, double TotalKms, double TotalProfit) : OwnerDto(Id, Identificacion, Nombres, FechaNacimiento, Direccion, Email);
}