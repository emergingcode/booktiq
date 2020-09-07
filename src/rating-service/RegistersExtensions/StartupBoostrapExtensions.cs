using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

using RatingService.Settings;

namespace RatingService.RegistersExtensions
{
    public static class StartupBoostrapExtensions
    {
        public static ServiceSettings StartupBoostrap(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<ServiceSettings>(configuration.GetSection(nameof(ServiceSettings)));
            var serviceProvider = services.BuildServiceProvider();
            var iop = serviceProvider.GetService<IOptions<ServiceSettings>>();
            return iop.Value;
        }
    }
}