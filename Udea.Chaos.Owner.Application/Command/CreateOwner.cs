using MediatR;
using System.ComponentModel.DataAnnotations;

namespace Udea.Chaos.Owner.Application.Command
{
    public class CreateOwner : IRequest
    {
        [Required]
        public string Identificacion { get; set; } = string.Empty;

        [Required]
        public string Nombres { get; set; } = string.Empty;

        [Required]
        public DateTime FechaNacimiento { get; set; }

        [Required]
        public string Direccion { get; set; } = string.Empty;


        [Required]
        public string Email { get; set; } = string.Empty;
    }
}