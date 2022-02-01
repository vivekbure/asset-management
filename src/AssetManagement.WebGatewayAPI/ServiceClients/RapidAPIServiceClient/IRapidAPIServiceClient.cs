using AssetManagement.WebGatewayAPI.Controllers.SchemeInfoController.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AssetManagement.WebGatewayAPI.ServiceClients.RapidAPIServiceClient
{
    public interface IRapidAPIServiceClient
    {
        Task<string> FetchLatestNavAsync();

        Task<string> FetchAllSchemeNames();
    }
}
