using MediatR;
using Udea.Chaos.Owner.Application.Extensions;
using Udea.Chaos.Owner.Domain.Ports;

namespace Udea.Chaos.Owner.Application.Command
{
    public class CreateOwnerHandler : AsyncRequestHandler<CreateOwner>
    {
        private readonly IOwnerRepository _ownerRepositry;

        public CreateOwnerHandler(IOwnerRepository ownerRepositry)
        {
            _ownerRepositry = ownerRepositry;
        }

        protected override async Task Handle(CreateOwner request, CancellationToken cancellationToken)
        {
            await _ownerRepositry.AddAsync(request.ToEntity());
        }
    }
}