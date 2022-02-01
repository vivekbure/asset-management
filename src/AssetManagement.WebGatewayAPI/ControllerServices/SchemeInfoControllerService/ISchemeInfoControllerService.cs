using System.Threading.Tasks;

namespace AssetManagement.WebGatewayAPI.ControllerServices.SchemeInfoControllerService
{
    public interface ISchemeInfoControllerService
    {
        Task<bool> UpdateSchemeInfosDatabase();
    }
}
