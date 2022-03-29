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
        public async Task<IEnumerable<OwnerDto>> GetOwners()
        {
            return await _mediator.Send(new GetAllOwners());
        }

        [HttpPost]
        public async Task CreateOwner(CreateOwner createOwner)
        {
            await _mediator.Send(createOwner);
        }
    }
}