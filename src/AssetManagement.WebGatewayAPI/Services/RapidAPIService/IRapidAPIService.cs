using AssetManagement.WebGatewayAPI.Controllers.SchemeInfoController.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AssetManagement.WebGatewayAPI.Services.RapidAPIService
{
    public interface IRapidAPIService
    {
        Task<List<SchemeInfo>> FetchLatestNav();

        Task<List<string>> FetchAllSchemeNames();
    }
}
