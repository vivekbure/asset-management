using AssetManagement.DataAccessLayer.Models;
using AssetManagement.DataAccessLayer.RedisDBService;
using AssetManagement.DataAccessLayer.SQLService;
using AssetManagement.WebGatewayAPI.Controllers.SchemeInfoController;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace AssetManagement.WebGatewayAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "AssetManagement.WebGatewayAPI", Version = "v1" });
            });

            // Dependency Injections
            services.AddSingleton<IAssetManagementSQLService, AssetManagementSQLService>();

            services.AddTransient<AssetManagementDBContext>();

            services.AddSchemeInfoServices();
            services.AddRedisServices();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "AssetManagement.WebGatewayAPI v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
