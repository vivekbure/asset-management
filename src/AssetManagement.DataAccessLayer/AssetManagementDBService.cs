using AssetManagement.DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AssetManagement.DataAccessLayer
{
    public class AssetManagementDBService : IAssetManagementDBService
    {
        private readonly AssetManagementDBContext _assetManagementDBContext;

        public AssetManagementDBService(AssetManagementDBContext assetManagementDBContext)
        {
            _assetManagementDBContext = assetManagementDBContext;
        }

        public bool UpdateSchemes(List<SchemeInfo> schemeInfos)
        {
            _assetManagementDBContext.SchemeInfos.RemoveRange(FetchSchemes().Result);
            _assetManagementDBContext.SaveChanges();
            _assetManagementDBContext.SchemeInfos.AddRange(schemeInfos);
            var entries = _assetManagementDBContext.SaveChanges();
            if (entries > 0)
                return true;
            return false;
        }

        public async Task<List<SchemeInfo>> FetchSchemes()
        {
            var schemes = await _assetManagementDBContext.SchemeInfos.ToListAsync();
            return schemes;
        }
    }
}
