using AssetManagement.WebGatewayAPI.ControllerServices.SchemeInfoControllerService;
using AssetManagement.WebGatewayAPI.ServiceClients.RapidAPIServiceClient;
using AssetManagement.WebGatewayAPI.Services.RapidAPIService;
using Microsoft.Extensions.DependencyInjection;

namespace AssetManagement.WebGatewayAPI.Controllers.SchemeInfoController
{
    public static class SchemeInfoControllerExtensions
    {
        public static IServiceCollection AddSchemeInfoServices(this IServiceCollection services)
        {
            services.AddSingleton<IRapidAPIService, RapidAPIService>();
            services.AddSingleton<IRapidAPIServiceClient, RapidAPIServiceClient>();
            services.AddSingleton<ISchemeInfoControllerService, SchemeInfoControllerService>();

            return services;
        }
    }
}
