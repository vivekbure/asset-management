using AssetManagement.WebGatewayAPI.Controllers.SchemeInfoController.Models;
using AssetManagement.WebGatewayAPI.ServiceClients.RapidAPIServiceClient;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AssetManagement.WebGatewayAPI.Services.RapidAPIService
{
    public class RapidAPIService : IRapidAPIService
    {
        private readonly IRapidAPIServiceClient _rapidAPIServiceClient;
        public RapidAPIService(IRapidAPIServiceClient rapidAPIServiceClient)
        {
            _rapidAPIServiceClient = rapidAPIServiceClient;
        }

        public async Task<List<SchemeInfo>> FetchLatestNav()
        {
            var response = await _rapidAPIServiceClient.FetchLatestNavAsync();
            var schemeInfos = JsonConvert.DeserializeObject<List<SchemeInfo>>(response);
            return schemeInfos;
        }

        public async Task<List<string>> FetchAllSchemeNames()
        {   
            var response = await _rapidAPIServiceClient.FetchAllSchemeNames();
            var schemeNames = JsonConvert.DeserializeObject<List<string>>(response);
            return schemeNames;
        }
    }
}
