using Udea.Chaos.Owner.Application.Command;
using Udea.Chaos.Owner.Application.Dtos;

namespace Udea.Chaos.Owner.Application.Extensions
{
    public static class DtosExtension
    {
        public static OwnerDto ToDto(this Domain.Entities.Owner owner)
        {
            return new OwnerDto(owner.Id, owner.Identificacion, owner.Nombres, owner.FechaNacimiento, owner.Direccion, owner.Email);
        }

        public static OwnerWithVehiclesDto ToDto(this Domain.Entities.Owner owner, IEnumerable<VehicleDto> vehicles)
        {
            return new OwnerWithVehiclesDto(owner.Id, owner.Identificacion, owner.Nombres, owner.FechaNacimiento, owner.Direccion, owner.Email, vehicles);
        }

        public static Domain.Entities.Owner ToEntity(this CreateOwner owner)
        {
            return new Domain.Entities.Owner
            {
                Identificacion = owner.Identificacion,
                Nombres = owner.Nombres,
                FechaNacimiento = owner.FechaNacimiento,
                Direccion = owner.Direccion,
                Email = owner.Email
            };
        }
    }
}