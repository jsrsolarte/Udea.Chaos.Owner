using MediatR;
using Udea.Chaos.Owner.Application.Dtos;

namespace Udea.Chaos.Owner.Application.Queries
{
    public record GetOwnerDetail(Guid Id) : IRequest<OwnerWithVehiclesDto?>;
}