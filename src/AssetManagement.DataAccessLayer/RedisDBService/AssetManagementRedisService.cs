using StackExchange.Redis;

namespace AssetManagement.DataAccessLayer.RedisDBService
{
    public class AssetManagementRedisService : IAssetManagementRedisService
    {
        private readonly IDatabase _redisDBService;

        public AssetManagementRedisService(IDatabase redisDBService)
        {
            _redisDBService = redisDBService;
        }
    }
}
