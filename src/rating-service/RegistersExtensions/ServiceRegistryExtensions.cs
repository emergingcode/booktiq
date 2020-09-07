using System;

using Consul;

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

using RatingService.Settings;

namespace RatingService.RegistersExtensions
{
    public static class ServiceRegistryExtensions
    {
        public static IServiceCollection AddConsulSettings(this IServiceCollection services, ServiceSettings serviceSettings)
        {
            services.AddSingleton<IConsulClient, ConsulClient>(p => new ConsulClient(consulConfig =>
            {
                consulConfig.Address = new Uri(serviceSettings.ServiceDiscoveryAddress);
            }));
            return services;
        }

        public static IApplicationBuilder UseConsul(this IApplicationBuilder app, ServiceSettings serviceSettings)
        {
            var consulClient = app.ApplicationServices.GetRequiredService<IConsulClient>();
            var logger = app.ApplicationServices.GetRequiredService<ILoggerFactory>().CreateLogger("AppExtensions");
            var lifetime = app.ApplicationServices.GetRequiredService<IHostApplicationLifetime>();

            //var uri = new Uri(address);
            var registration = new AgentServiceRegistration()
            {
                ID = serviceSettings.ServiceName, //{uri.Port}",
                // servie name
                Name = serviceSettings.ServiceName,
                Address = serviceSettings.ServiceHost, //$"{uri.Host}",
                Port = serviceSettings.ServicePort  // uri.Port
            };

            logger.LogInformation("Registering with Consul");
            consulClient.Agent.ServiceDeregister(registration.ID).ConfigureAwait(true);
            consulClient.Agent.ServiceRegister(registration).ConfigureAwait(true);

            lifetime.ApplicationStopping.Register(() =>
            {
                logger.LogInformation("Unregistering from Consul");
            });

            return app;
        }
    }
}