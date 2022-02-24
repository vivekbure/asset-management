using Microsoft.Extensions.DependencyInjection;
using StackExchange.Redis;

namespace AssetManagement.DataAccessLayer.RedisDBService
{
    public static class RedisDBExtensions
    {
        public static IServiceCollection AddRedisServices(this IServiceCollection services)
        {
            IDatabase redisDatabase = ConnectionMultiplexer.Connect("localhost").GetDatabase();
            services.AddSingleton(redisDatabase);

            return services;
        }
    }
}
