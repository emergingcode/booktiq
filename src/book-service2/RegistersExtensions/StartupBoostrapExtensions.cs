using BookService.Settings;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace BookService.RegistersExtensions
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