using AssetManagement.DataAccessLayer.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AssetManagement.DataAccessLayer.SQLService
{
    public interface IAssetManagementSQLService
    {
        bool UpdateSchemes(List<SchemeInfo> schemeInfos);

        Task<List<SchemeInfo>> FetchSchemes();
    }
}
