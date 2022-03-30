using Flurl.Http;
using Flurl.Http.Configuration;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udea.Chaos.Owner.Application.Dtos;
using Udea.Chaos.Owner.Application.Ports;

namespace Udea.Chaos.Owner.Infrastructure.Adapters
{
    public class VehicleService : IVehicleService
    {
        private readonly IFlurlClient _flurlClient;

        public VehicleService(IFlurlClientFactory flurlClientFac, IConfiguration config)
        {
            _flurlClient = flurlClientFac.Get(config.GetSection("UrlVehicleApi").Value);
        }

        public async Task<IEnumerable<VehicleDto>> GetVehicles(Guid ownerId)
        {
            var response = await _flurlClient.Request($"by-owner/{ownerId}").GetAsync();
            return await response.GetJsonAsync<IEnumerable<VehicleDto>>();
        }
    }
}
