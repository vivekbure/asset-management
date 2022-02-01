using AssetManagement.DataAccessLayer.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AssetManagement.DataAccessLayer
{
    public interface IAssetManagementDBService
    {
        bool UpdateSchemes(List<SchemeInfo> schemeInfos);

        Task<List<SchemeInfo>> FetchSchemes();
    }
}
