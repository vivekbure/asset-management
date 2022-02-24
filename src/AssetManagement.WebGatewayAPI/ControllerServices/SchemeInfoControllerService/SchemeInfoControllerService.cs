using AssetManagement.DataAccessLayer.Models;
using AssetManagement.DataAccessLayer.SQLService;
using AssetManagement.WebGatewayAPI.Services.RapidAPIService;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace AssetManagement.WebGatewayAPI.ControllerServices.SchemeInfoControllerService
{
    public class SchemeInfoControllerService : ISchemeInfoControllerService
    {
        private readonly IRapidAPIService _rapidAPIService;
        private readonly IAssetManagementSQLService _assetManagementDBService;

        public SchemeInfoControllerService(
            IRapidAPIService rapidAPIService,
            IAssetManagementSQLService assetManagementDBService)
        {
            _rapidAPIService = rapidAPIService;
            _assetManagementDBService = assetManagementDBService;
        }

        public async Task<bool> UpdateSchemeInfosDatabase()
        {
            var schemeInfos = await _rapidAPIService.FetchLatestNav();
            var databaseSchemesInfo = schemeInfos.Select(scheme => new SchemeInfo
            {
                SchemeCode = Convert.ToInt32(scheme.SchemeCode),
                SchemeName = scheme.SchemeName,
                Amc = scheme.MutualFundFamily,
                NetAssetValue = scheme.NetAssetValue,
                Date = DateTime.ParseExact(scheme.Date, "dd-MMM-yyyy", System.Globalization.CultureInfo.InvariantCulture)
            }).OrderBy(schemeInfos => schemeInfos.SchemeName).ToList();

            var status = _assetManagementDBService.UpdateSchemes(databaseSchemesInfo);

            return status;
        }
    }
}
