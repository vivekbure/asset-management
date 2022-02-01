using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace AssetManagement.WebGatewayAPI.ServiceClients.RapidAPIServiceClient
{
    public class RapidAPIServiceClient : IRapidAPIServiceClient
    {
        private readonly HttpClient _httpClient;

        public RapidAPIServiceClient()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://latest-mutual-fund-nav.p.rapidapi.com")
            };
            _httpClient.DefaultRequestHeaders.Add("x-rapidapi-host", "latest-mutual-fund-nav.p.rapidapi.com");
            _httpClient.DefaultRequestHeaders.Add("x-rapidapi-key", "f8c841082amshaca44d12b715490p1e7277jsn6984f955b207");
            
        }

        public async Task<string> FetchLatestNavAsync()
        {
            var response = await _httpClient.GetAsync("/fetchLatestNAV");
            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();
            return body;
        }

        public async Task<string> FetchAllSchemeNames()
        {
            var response = await _httpClient.GetAsync("/fetchAllSchemeNames");
            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();
            return body;
        }
    }
}
