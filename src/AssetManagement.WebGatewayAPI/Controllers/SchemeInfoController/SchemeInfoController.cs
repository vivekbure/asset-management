using AssetManagement.DataAccessLayer;
using AssetManagement.WebGatewayAPI.ControllerServices.SchemeInfoControllerService;
using AssetManagement.WebGatewayAPI.Services.RapidAPIService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AssetManagement.WebGatewayAPI.Controllers.SchemeInfoController
{
    [ApiController]
    public class SchemeInfoController : Controller
    {
        private readonly IAssetManagementDBService _assetManagementDBService;
        private readonly IRapidAPIService _rapidAPIService;
        private readonly ISchemeInfoControllerService _schemeInfoControllerService;

        public SchemeInfoController(
            IAssetManagementDBService assetManagementDBService,
            IRapidAPIService rapidAPIService,
            ISchemeInfoControllerService schemeInfoControllerService)
        {
            _assetManagementDBService = assetManagementDBService;
            _rapidAPIService = rapidAPIService;
            _schemeInfoControllerService = schemeInfoControllerService;
        }

        [HttpGet("/FetchSchemesFromDatabase")]
        public async Task<IEnumerable<object>> FetchSchemes()
        {
            return await _assetManagementDBService.FetchSchemes();
        }

        [HttpGet("/FetchAllSchemeNames")]
        public async Task<List<string>> FetchAllSchemeNamesAsync()
        {
            return await _rapidAPIService.FetchAllSchemeNames();
        }

        [HttpPost("/UpdateSchemesDatabase")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<ActionResult<bool>> UpdateSchemeInfosDatabase()
        {
            await _schemeInfoControllerService.UpdateSchemeInfosDatabase();
            return NoContent();
        }
    }
}
