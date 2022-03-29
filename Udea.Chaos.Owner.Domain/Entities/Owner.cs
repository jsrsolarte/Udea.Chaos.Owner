namespace Udea.Chaos.Owner.Domain.Entities
{
    public class Owner : EntityBase<string>
    {
        public string Identificacion { get; set; } = string.Empty;
        public string Nombres { get; set; } = string.Empty;
        public DateTime FechaNacimiento { get; set; }
        public string Direccion { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
    }
}