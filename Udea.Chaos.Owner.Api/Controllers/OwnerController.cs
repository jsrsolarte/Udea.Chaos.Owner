using MediatR;
using Microsoft.AspNetCore.Mvc;
using Udea.Chaos.Owner.Application.Command;
using Udea.Chaos.Owner.Application.Dtos;
using Udea.Chaos.Owner.Application.Queries;

namespace Udea.Chaos.Owner.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class OwnerController
    {
        private readonly IMediator _mediator;

        public OwnerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IEnumerable<Guid>> GetOwnersIds()
        {
            return await _mediator.Send(new GetAllOwners());
        }

        [HttpGet("detail/{id}")]
        public async Task<OwnerWithVehiclesDto?> GetOwnerDetail(Guid id)
        {
            var owner = await _mediator.Send(new GetOwnerDetail(id));

            if (owner == null) return null;
            return owner;
        }

        [HttpGet("detail/{id}/journeys")]
        public async Task<OwnerWithJourneysDto?> GetOwnerDetailJourneys(Guid id)
        {
            var owner = await _mediator.Send(new GetOwnerDetailJourneys(id));

            if (owner == null) return null;
            return owner;
        }

        [HttpPost]
        public async Task CreateOwner(CreateOwner createOwner)
        {
            await _mediator.Send(createOwner);
        }
    }
}